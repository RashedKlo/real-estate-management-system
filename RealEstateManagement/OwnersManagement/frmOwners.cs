using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using RealEstateManagement.Services.Interfaces;
using RealEstateManagement.Data.DTOs.Owners.Queries;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Models;
using System.Collections.Generic;

namespace RealEstateManagement
{
    public partial class frmOwners : Form
    {
        #region Fields

        private readonly IOwnersService _ownersService;
        private readonly ILogger<frmOwners> _logger;
        private frmMain _frmMain;

        private int _currentPage = 1;
        private const int PAGE_SIZE = 4;
        private int _totalPages = 1;
        private int _totalRecords = 0;
        private bool _hasNextPage = false;
        private bool _hasPreviousPage = false;

        #endregion

        #region Constructor

        public frmOwners(IOwnersService ownersService, ILogger<frmOwners> logger)
        {
            ValidateDependencies(ownersService, logger);

            InitializeComponent();

            _ownersService = ownersService;
            _logger = logger;

            SetupOptimization();
        }

        private void ValidateDependencies(IOwnersService ownersService, ILogger<frmOwners> logger)
        {
            if (ownersService == null)
                throw new ArgumentNullException(nameof(ownersService), "OwnersService cannot be null");

            if (logger == null)
                throw new ArgumentNullException(nameof(logger), "Logger cannot be null");
        }

        #endregion

        #region Public Methods

        public void SetMainForm(frmMain mainForm)
        {
            _frmMain = mainForm ?? throw new ArgumentNullException(nameof(mainForm));
        }

        #endregion

        #region Event Handlers

        private async void frmOwners_Load(object sender, EventArgs e)
        {
            try
            {
                _logger.LogInformation("Form load started");

                CheckMainFormReference();
                await LoadOwnersData();
                UpdateButtonStates();
                UpdateStatusBar("Owner list loaded successfully");

                _logger.LogInformation("Form load completed successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while loading owners form");
                ShowError("حدث خطأ أثناء تحميل البيانات", ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEditOwner frmOwner = Program.ServiceProvider.GetRequiredService<frmEditOwner>();
            frmOwner.SetMainForm(_frmMain);
            frmOwner.Mode = frmEditOwner.EnMode.Add;
            frmOwner.ShowDialog();
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            if (!_hasNextPage) return;

            try
            {
                _currentPage++;
                await LoadOwnersData();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error navigating to next page");
                ShowError("خطأ في الانتقال للصفحة التالية", ex);
            }
        }

        private async void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (!_hasPreviousPage) return;

            try
            {
                _currentPage--;
                await LoadOwnersData();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error navigating to previous page");
                ShowError("خطأ في الانتقال للصفحة السابقة", ex);
            }
        }

        private void dgvOwners_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtonStates();
        }

        #endregion

        #region Private Methods - Data Loading

        private async System.Threading.Tasks.Task LoadOwnersData()
        {
            _logger.LogInformation("Loading owners data - Page: {Page}, PageSize: {PageSize}",
                _currentPage, PAGE_SIZE);

            try
            {
                ValidateOwnerService();

                OwnersGetRequestDto request = CreateGetOwnersRequest();
                OperationResult<OwnersGetResponseDto> result = await _ownersService.GetOwnersAsync(request);

                if (!ValidateServiceResult(result))
                    return;

                UpdatePaginationState(result.Data);
                DisplayOwners(result.Data.Owners);
                UpdateStatusBar($"Loaded {_totalRecords} owners");

                _logger.LogInformation("Owner data loaded successfully - Total records: {TotalRecords}",
                    _totalRecords);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading owner data");
                ShowError("خطأ في تحميل البيانات", ex);
            }
        }

        private OwnersGetRequestDto CreateGetOwnersRequest()
        {
            return new OwnersGetRequestDto
            {
                Page = _currentPage,
                Limit = PAGE_SIZE,
                FullName = txtFilterName.Text,
                PhoneNumber = txtFilterPhone.Text
            };
        }

        #endregion

        #region Private Methods - Validation

        private void ValidateOwnerService()
        {
            if (_ownersService == null)
            {
                _logger.LogError("OwnersService is null");
                throw new InvalidOperationException("Owner service is not available");
            }
        }

        private bool ValidateServiceResult(OperationResult<OwnersGetResponseDto> result)
        {
            if (result == null)
            {
                _logger.LogError("Service returned null result");
                ShowError("خطأ: فشل في استرجاع البيانات", null);
                return false;
            }

            if (!result.IsSuccess)
            {
                _logger.LogWarning("Service call failed - Message: {Message}", result.Message);
                ShowError("خطأ: فشل في استرجاع البيانات", null);
                return false;
            }

            if (result.Data == null)
            {
                _logger.LogError("Service returned null data");
                ShowError("خطأ: البيانات المسترجعة فارغة", null);
                return false;
            }

            return true;
        }

        private void CheckMainFormReference()
        {
            if (_frmMain == null)
            {
                _logger.LogWarning("Main form reference is null - status bar updates will be skipped");
            }
        }

        #endregion

        #region Private Methods - UI Updates

        private void UpdatePaginationState(OwnersGetResponseDto data)
        {
            _totalPages = data.TotalPages;
            _totalRecords = data.TotalRecords;
            _hasNextPage = data.HasNextPage;
            _hasPreviousPage = data.HasPreviousPage;

            UpdatePaginationInfo();
            UpdateTotalOwnersLabel();
        }

        private void DisplayOwners(List<OwnerModel> owners)
        {
            List<OwnerModel> safeOwners = owners ?? new List<OwnerModel>();

            if (owners == null)
            {
                _logger.LogWarning("Owners list is null, using empty list");
            }

            DataTable dataTable = ConvertToDataTable(safeOwners);
            BindOwnersToGrid(dataTable);
        }

        private void BindOwnersToGrid(DataTable dataTable)
        {
            try
            {
                if (dataTable == null)
                {
                    _logger.LogError("DataTable is null");
                    dgvOwners.DataSource = null;
                    return;
                }

                dgvOwners.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error binding data to grid");
                throw;
            }
        }

        private DataTable ConvertToDataTable(List<OwnerModel> owners)
        {
            _logger.LogInformation("Converting {Count} owners to DataTable", owners?.Count ?? 0);

            DataTable dataTable = CreateOwnersDataTable();

            if (owners == null || owners.Count == 0)
                return dataTable;

            PopulateDataTable(dataTable, owners);

            _logger.LogInformation("Successfully converted {Count} owners to DataTable", dataTable.Rows.Count);

            return dataTable;
        }

        private DataTable CreateOwnersDataTable()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("OwnerId", typeof(int));
            dataTable.Columns.Add("FullName", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("CreatedAt", typeof(DateTime));

            return dataTable;
        }

        private void PopulateDataTable(DataTable dataTable, List<OwnerModel> owners)
        {
            foreach (OwnerModel owner in owners)
            {
                if (owner == null)
                {
                    _logger.LogWarning("Null owner found in list, skipping");
                    continue;
                }

                try
                {
                    dataTable.Rows.Add(
                        owner.OwnerId,
                        owner.FullName ?? string.Empty,
                        owner.PhoneNumber ?? string.Empty,
                        owner.Address ?? string.Empty,
                        owner.CreatedAt
                    );
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error adding owner row - OwnerId: {OwnerId}", owner.OwnerId);
                }
            }
        }

        private void UpdatePaginationInfo()
        {
            try
            {
                lblPageInfo.Text = $"صفحة {_currentPage} من {_totalPages}";
                btnPrevPage.Enabled = _hasPreviousPage;
                btnNextPage.Enabled = _hasNextPage;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating pagination info");
            }
        }

        private void UpdateTotalOwnersLabel()
        {
            try
            {
                lblTotalOwners.Text = $"إجمالي الملاك: {_totalRecords}";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating total owners label");
            }
        }

        private void UpdateButtonStates()
        {
            try
            {
                bool hasSelection = dgvOwners.SelectedRows.Count > 0;
                btnEdit.Enabled = hasSelection;
                btnView.Enabled = hasSelection;
                btnDelete.Enabled = hasSelection;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating button states");
            }
        }

        private void UpdateStatusBar(string message)
        {
            if (_frmMain != null)
            {
                _frmMain.UpdateStatusBar(message, null);
            }
        }

        private void ShowError(string message, Exception ex)
        {
            string fullMessage = ex != null ? $"{message}: {ex.Message}" : message;
            _logger.LogError(ex, "Error: {Message}", message);
            MessageBox.Show(fullMessage, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region Private Methods - Optimization

        private void SetupOptimization()
        {
            this.SetStyle(
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint,
                true);
            this.UpdateStyles();
        }

        #endregion

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            _currentPage = 1;
            await LoadOwnersData();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvOwners.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد مالك للعرض.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ownerId = Convert.ToInt32(dgvOwners.SelectedRows[0].Cells["colOwnerId"].Value);

            frmOwnerDetails frmOwner = Program.ServiceProvider.GetRequiredService<frmOwnerDetails>();
            frmOwner.SetOwnerId(ownerId);
            frmOwner.SetMainForm(_frmMain);
            frmOwner.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvOwners.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد مالك للتعديل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ownerId = Convert.ToInt32(dgvOwners.SelectedRows[0].Cells["colOwnerId"].Value);

            frmEditOwner frmOwner = Program.ServiceProvider.GetRequiredService<frmEditOwner>();
            frmOwner.SetOwnerId(ownerId);
            frmOwner.SetMainForm(_frmMain);
            frmOwner.Mode = frmEditOwner.EnMode.Update;
            frmOwner.ShowDialog();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOwners.SelectedRows.Count == 0)
                {
                    MessageBox.Show("الرجاء تحديد مالك للحذف.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int ownerId = Convert.ToInt32(dgvOwners.SelectedRows[0].Cells["colOwnerId"].Value);
                string fullName = dgvOwners.SelectedRows[0].Cells["colFullName"].Value.ToString();

                var confirm = MessageBox.Show(
                    $"هل أنت متأكد من حذف المالك '{fullName}'؟",
                    "تأكيد الحذف",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes)
                    return;

                var result = await _ownersService.DeleteOwnerAsync(new Data.DTOs.Owners.Delete.OwnerDeleteRequestDto
                {
                    OwnerId = ownerId
                });

                if (result.IsSuccess)
                {
                    MessageBox.Show("تم حذف المالك بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadOwnersData();
                }
                else
                {
                    MessageBox.Show($"فشل الحذف: {result.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting owner");
                ShowError("حدث خطأ أثناء حذف المالك", ex);
            }
        }

        private async void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtFilterName.Clear();
            txtFilterPhone.Clear();
            await  LoadOwnersData();
        }

        private async void txtFilter_TextChanged(object sender, EventArgs e)
        {
            await LoadOwnersData();
        }
    }
}