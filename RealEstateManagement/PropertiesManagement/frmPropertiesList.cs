using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using RealEstateManagement.Services.Interfaces;
using RealEstateManagement.Data.DTOs.Properties.Queries;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Models;
using System.Collections.Generic;

namespace RealEstateManagement
{
    public partial class frmPropertiesList : Form
    {
        #region Fields

        private readonly IPropertiesService _propertiesService;
        private readonly ILogger<frmPropertiesList> _logger;
        private frmMain _frmMain;

        private int _currentPage = 1;
        private const int PAGE_SIZE = 5;
        private int _totalPages = 1;
        private int _totalRecords = 0;
        private bool _hasNextPage = false;
        private bool _hasPreviousPage = false;

        #endregion

        #region Constructor

        public frmPropertiesList(IPropertiesService propertiesService, ILogger<frmPropertiesList> logger)
        {
            ValidateDependencies(propertiesService, logger);

            InitializeComponent();

            _propertiesService = propertiesService;
            _logger = logger;

            SetupOptimization();
        }

        private void ValidateDependencies(IPropertiesService propertiesService, ILogger<frmPropertiesList> logger)
        {
            if (propertiesService == null)
                throw new ArgumentNullException(nameof(propertiesService), "PropertiesService cannot be null");

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

        private async void FrmPropertiesList_Load(object sender, EventArgs e)
        {
            try
            {
                _logger.LogInformation("Form load started");

                CheckMainFormReference();
                await LoadPropertiesData();
                UpdateButtonStates();
                UpdateStatusBar("Property list loaded successfully");

                _logger.LogInformation("Form load completed successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while loading properties form");
                ShowError("حدث خطأ أثناء تحميل البيانات", ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditProperty frmProperty = Program.ServiceProvider.GetRequiredService<frmAddEditProperty>();
            frmProperty.SetMainForm(_frmMain);
            frmProperty.ShowDialog();
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            if (!_hasNextPage) return;

            try
            {
                _currentPage++;
                await LoadPropertiesData();
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
                await LoadPropertiesData();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error navigating to previous page");
                ShowError("خطأ في الانتقال للصفحة السابقة", ex);
            }
        }

        private void dgvProperties_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtonStates();
        }

        #endregion

        #region Private Methods - Data Loading

        private async System.Threading.Tasks.Task LoadPropertiesData()
        {
            _logger.LogInformation("Loading properties data - Page: {Page}, PageSize: {PageSize}",
                _currentPage, PAGE_SIZE);

            try
            {
                ValidatePropertyService();

                PropertiesGetRequestDto request = CreateGetPropertiesRequest();
                OperationResult<PropertiesGetResponseDto> result = await _propertiesService.GetPropertiesAsync(request);
                //if (!ValidateServiceResult(result))
                //    return;

                UpdatePaginationState(result.Data);
                DisplayProperties(result.Data.Properties);
                UpdateStatusBar($"Loaded {_totalRecords} properties");

                _logger.LogInformation("Property data loaded successfully - Total records: {TotalRecords}",
                    _totalRecords);
            }
            catch (Exception ex)
            {
                dgvProperties.DataSource = CreatePropertiesDataTable();
                _logger.LogError(ex, "Error loading property data");
                ShowError("خطأ في تحميل البيانات", ex);
            }
        }

        private PropertiesGetRequestDto CreateGetPropertiesRequest()
        {
            return new PropertiesGetRequestDto
            {
                Page = _currentPage,
                Limit = PAGE_SIZE,
                Location = txtFilterLocation.Text,
                Status = cmbFilterStatus.SelectedItem?.ToString(),
                Availability = cmbFilterAvailability.SelectedItem?.ToString(),
                NumOfRooms = string.IsNullOrWhiteSpace(txtFilterRooms.Text) ? (int?)null : int.Parse(txtFilterRooms.Text),
                PriceFrom = string.IsNullOrWhiteSpace(txtFilterPriceFrom.Text) ? (decimal?)null : decimal.Parse(txtFilterPriceFrom.Text),
                PriceTo = string.IsNullOrWhiteSpace(txtFilterPriceTo.Text) ? (decimal?)null : decimal.Parse(txtFilterPriceTo.Text),
                AreaFrom = string.IsNullOrWhiteSpace(txtFilterAreaFrom.Text) ? (decimal?)null : decimal.Parse(txtFilterAreaFrom.Text),
                AreaTo = string.IsNullOrWhiteSpace(txtFilterAreaTo.Text) ? (decimal?)null : decimal.Parse(txtFilterAreaTo.Text)
            };
        }

        #endregion

        #region Private Methods - Validation

        private void ValidatePropertyService()
        {
            if (_propertiesService == null)
            {
                _logger.LogError("PropertiesService is null");
                throw new InvalidOperationException("Property service is not available");
            }
        }

        private bool ValidateServiceResult(OperationResult<PropertiesGetResponseDto> result)
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
                ShowError($"خطأ: {result.Message}", null);
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

        private void UpdatePaginationState(PropertiesGetResponseDto data)
        {
            _totalPages = data.TotalPages;
            _totalRecords = data.TotalRecords;
            _hasNextPage = data.HasNextPage;
            _hasPreviousPage = data.HasPreviousPage;

            UpdatePaginationInfo();
            UpdateTotalPropertiesLabel();
        }

        private void DisplayProperties(List<PropertyModel> properties)
        {
            List<PropertyModel> safeProperties = properties ?? new List<PropertyModel>();

            if (properties == null)
            {
                _logger.LogWarning("Properties list is null, using empty list");
            }

            DataTable dataTable = ConvertToDataTable(safeProperties);
            BindPropertiesToGrid(dataTable);
        }

        private void BindPropertiesToGrid(DataTable dataTable)
        {
            try
            {
                if (dataTable == null)
                {
                    _logger.LogError("DataTable is null");
                    dgvProperties.DataSource = null;
                    return;
                }

                dgvProperties.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error binding data to grid");
                throw;
            }
        }

        private DataTable ConvertToDataTable(List<PropertyModel> properties)
        {
            _logger.LogInformation("Converting {Count} properties to DataTable", properties?.Count ?? 0);

            DataTable dataTable = CreatePropertiesDataTable();

            if (properties == null || properties.Count == 0)
                return dataTable;

            PopulateDataTable(dataTable, properties);

            _logger.LogInformation("Successfully converted {Count} properties to DataTable", dataTable.Rows.Count);

            return dataTable;
        }

        private DataTable CreatePropertiesDataTable()
        {
            DataTable dataTable = new DataTable();

            // Match the column names with DataGridView DataPropertyName
            dataTable.Columns.Add("ID", typeof(int));              // PropertyId -> ID (colID)
            dataTable.Columns.Add("Title", typeof(string));        // Location -> Title (colTitle)
            dataTable.Columns.Add("City", typeof(string));         // NumOfRooms -> City (colCity) - we'll show rooms as text
            dataTable.Columns.Add("Type", typeof(string));         // Status -> Type (colType)
            dataTable.Columns.Add("Transaction", typeof(string));  // Availability -> Transaction (colTransaction)
            dataTable.Columns.Add("Price", typeof(decimal));       // Price -> Price (colPrice)
            dataTable.Columns.Add("Status", typeof(string));       // Area -> Status (colStatus) - we'll show area as text

            return dataTable;
        }

        private void PopulateDataTable(DataTable dataTable, List<PropertyModel> properties)
        {
            foreach (PropertyModel property in properties)
            {
                if (property == null)
                {
                    _logger.LogWarning("Null property found in list, skipping");
                    continue;
                }

                try
                {
                    // Map data to match DataGridView column structure
                    dataTable.Rows.Add(
                        property.PropertyId,                                    // ID
                        property.Location ?? string.Empty,                      // Title (Location)
                        $"{property.NumOfRooms} غرفة",                         // City (Number of Rooms as text)
                        property.Status ?? string.Empty,                        // Type (Status)
                        property.Availability ?? string.Empty,                  // Transaction (Availability)
                        property.Price,                                         // Price
                        $"{property.Area} م²"                                  // Status (Area with unit)
                    );
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error adding property row - PropertyId: {PropertyId}", property.PropertyId);
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

        private void UpdateTotalPropertiesLabel()
        {
            try
            {
              //  lblTotalProperties.Text = $"إجمالي العقارات: {_totalRecords}";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating total properties label");
            }
        }

        private void UpdateButtonStates()
        {
            try
            {
                bool hasSelection = dgvProperties.SelectedRows.Count > 0;
                btnEdit.Enabled = hasSelection;
                btnViewDetails.Enabled = hasSelection;
             //   btnDelete.Enabled = hasSelection;
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
            _logger.LogError(ex, "Error: {Message}", fullMessage);
            MessageBox.Show(message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #region Button Event Handlers

        #endregion

        #region Private Methods - Optimization


        #endregion

        #region Button Event Handlers

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            _currentPage = 1;
            btnClearFilter_Click(sender, e);
            await LoadPropertiesData();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvProperties.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد عقار للعرض.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int propertyId = Convert.ToInt32(dgvProperties.SelectedRows[0].Cells["colID"].Value);

            frmPropertyDetails frmProperty = Program.ServiceProvider.GetRequiredService<frmPropertyDetails>();
            frmProperty.SetPropertyId(propertyId);
            frmProperty.SetMainForm(_frmMain);
            frmProperty.ShowDialog();
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await LoadPropertiesData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProperties.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد عقار للتعديل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int propertyId = Convert.ToInt32(dgvProperties.SelectedRows[0].Cells["colID"].Value);

           frmAddEditProperty frmProperty = Program.ServiceProvider.GetRequiredService<frmAddEditProperty>();
            frmProperty.SetPropertyId(propertyId);
            frmProperty.SetMainForm(_frmMain);
            frmProperty.ShowDialog();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProperties.SelectedRows.Count == 0)
                {
                    MessageBox.Show("الرجاء تحديد عقار للحذف.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int propertyId = Convert.ToInt32(dgvProperties.SelectedRows[0].Cells["colID"].Value);
                string location = dgvProperties.SelectedRows[0].Cells["colTitle"].Value.ToString();

                var confirm = MessageBox.Show(
                    $"هل أنت متأكد من حذف العقار في '{location}'؟",
                    "تأكيد الحذف",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes)
                    return;

                var result = await _propertiesService.DeletePropertyAsync(
                    new Data.DTOs.Properties.Delete.PropertyDeleteRequestDto
                    {
                        PropertyId = propertyId
                    });

                if (result.IsSuccess)
                {
                    MessageBox.Show("تم حذف العقار بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadPropertiesData();
                }
                else
                {
                    MessageBox.Show($"فشل الحذف: {result.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting property");
                ShowError("حدث خطأ أثناء حذف العقار", ex);
            }
        }

        private async void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtFilterLocation.Clear();
            txtFilterRooms.Clear();
            txtFilterPriceFrom.Clear();
            txtFilterPriceTo.Clear();
            txtFilterAreaFrom.Clear();
            txtFilterAreaTo.Clear();

            if (cmbFilterStatus.Items.Count > 0)
                cmbFilterStatus.SelectedIndex = -1;

            if (cmbFilterAvailability.Items.Count > 0)
                cmbFilterAvailability.SelectedIndex = -1;

            _currentPage = 1;
            await LoadPropertiesData();
        }

        private async void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            await LoadPropertiesData();
        }

        private async void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            await LoadPropertiesData();
        }


#endregion
    }
}