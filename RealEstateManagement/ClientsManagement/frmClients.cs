using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using RealEstateManagement.Services.Interfaces;
using RealEstateManagement.Data.DTOs.Clients.Queries;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Models;
using System.Collections.Generic;

namespace RealEstateManagement
{
    public partial class frmClients : Form
    {
        #region Fields

        private readonly IClientsService _clientsService;
        private readonly ILogger<frmClients> _logger;
        private frmMain _frmMain;

        private int _currentPage = 1;
        private const int PAGE_SIZE = 3;
        private int _totalPages = 1;
        private int _totalRecords = 0;
        private bool _hasNextPage = false;
        private bool _hasPreviousPage = false;

        #endregion

        #region Constructor

        public frmClients(IClientsService clientsService, ILogger<frmClients> logger)
        {
            ValidateDependencies(clientsService, logger);

            InitializeComponent();

            _clientsService = clientsService;
            _logger = logger;

            SetupOptimization();
        }

        private void ValidateDependencies(IClientsService clientsService, ILogger<frmClients> logger)
        {
            if (clientsService == null)
                throw new ArgumentNullException(nameof(clientsService), "ClientsService cannot be null");

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

        private async void frmClients_Load(object sender, EventArgs e)
        {
            try
            {
                _logger.LogInformation("Form load started");

                CheckMainFormReference();
                await LoadClientsData();
                UpdateButtonStates();
                UpdateStatusBar("Client list loaded successfully");

                _logger.LogInformation("Form load completed successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while loading clients form");
                ShowError("حدث خطأ أثناء تحميل البيانات", ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEditClient frmClients = Program.ServiceProvider.GetRequiredService<frmEditClient>();
            frmClients.SetMainForm(_frmMain);
            frmClients.Mode = frmEditClient.EnMode.Add;
            frmClients.ShowDialog();
          

        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            if (!_hasNextPage) return;

            try
            {
                _currentPage++;
                await LoadClientsData();
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
                await LoadClientsData();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error navigating to previous page");
                ShowError("خطأ في الانتقال للصفحة السابقة", ex);
            }
        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtonStates();
        }

        #endregion

        #region Private Methods - Data Loading

        private async System.Threading.Tasks.Task LoadClientsData()
        {
            _logger.LogInformation("Loading clients data - Page: {Page}, PageSize: {PageSize}",
                _currentPage, PAGE_SIZE);

            try
            {
                ValidateClientService();

                ClientsGetRequestDto request = CreateGetClientsRequest();
                OperationResult<ClientsGetResponseDto> result = await _clientsService.GetClientsAsync(request);

                if (!ValidateServiceResult(result))
                    return;

                UpdatePaginationState(result.Data);
                DisplayClients(result.Data.Clients);
                UpdateStatusBar($"Loaded {_totalRecords} clients");

                _logger.LogInformation("Client data loaded successfully - Total records: {TotalRecords}",
                    _totalRecords);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading client data");
                ShowError("خطأ في تحميل البيانات", ex);
            }
        }

        private ClientsGetRequestDto CreateGetClientsRequest()
        {
            return new ClientsGetRequestDto
            {
                Page = _currentPage,
                Limit = PAGE_SIZE,
                FullName=txtFilterName.Text,
                PhoneNumber=txtFilterPhone.Text


            };
        }

        #endregion

        #region Private Methods - Validation

        private void ValidateClientService()
        {
            if (_clientsService == null)
            {
                _logger.LogError("ClientsService is null");
                throw new InvalidOperationException("Client service is not available");
            }
        }

        private bool ValidateServiceResult(OperationResult<ClientsGetResponseDto> result)
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

        private void UpdatePaginationState(ClientsGetResponseDto data)
        {
            _totalPages = data.TotalPages;
            _totalRecords = data.TotalRecords;
            _hasNextPage = data.HasNextPage;
            _hasPreviousPage = data.HasPreviousPage;

            UpdatePaginationInfo();
            UpdateTotalClientsLabel();
        }

        private void DisplayClients(List<ClientModel> clients)
        {
            List<ClientModel> safeClients = clients ?? new List<ClientModel>();

            if (clients == null)
            {
                _logger.LogWarning("Clients list is null, using empty list");
            }

            DataTable dataTable = ConvertToDataTable(safeClients);
            BindClientsToGrid(dataTable);
        }

        private void BindClientsToGrid(DataTable dataTable)
        {
            try
            {
                if (dataTable == null)
                {
                    _logger.LogError("DataTable is null");
                    dgvClients.DataSource = null;
                    return;
                }

                dgvClients.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error binding data to grid");
                throw;
            }
        }

        private DataTable ConvertToDataTable(List<ClientModel> clients)
        {
            _logger.LogInformation("Converting {Count} clients to DataTable", clients?.Count ?? 0);

            DataTable dataTable = CreateClientsDataTable();

            if (clients == null || clients.Count == 0)
                return dataTable;

            PopulateDataTable(dataTable, clients);

            _logger.LogInformation("Successfully converted {Count} clients to DataTable", dataTable.Rows.Count);

            return dataTable;
        }

        private DataTable CreateClientsDataTable()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ClientId", typeof(int));
            dataTable.Columns.Add("FullName", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("CreatedAt", typeof(DateTime));

            return dataTable;
        }

        private void PopulateDataTable(DataTable dataTable, List<ClientModel> clients)
        {
            foreach (ClientModel client in clients)
            {
                if (client == null)
                {
                    _logger.LogWarning("Null client found in list, skipping");
                    continue;
                }

                try
                {
                    dataTable.Rows.Add(
                        client.ClientId,
                        client.FullName ?? string.Empty,
                        client.PhoneNumber ?? string.Empty,
                        client.Address ?? string.Empty,
                        client.CreatedAt
                    );
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error adding client row - ClientId: {ClientId}", client.ClientId);
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

        private void UpdateTotalClientsLabel()
        {
            try
            {
                lblTotalClients.Text = $"إجمالي العملاء: {_totalRecords}";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating total clients label");
            }
        }

        private void UpdateButtonStates()
        {
            try
            {
                bool hasSelection = dgvClients.SelectedRows.Count > 0;
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
            await LoadClientsData();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد عميل للعرض.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int clientId = Convert.ToInt32(dgvClients.SelectedRows[0].Cells["colClientId"].Value);

            frmClientDetails frmClients = Program.ServiceProvider.GetRequiredService<frmClientDetails>();
            frmClients.SetClientId(clientId);
            frmClients.SetMainForm(_frmMain);
            frmClients.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد عميل للعرض.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int clientId = Convert.ToInt32(dgvClients.SelectedRows[0].Cells["colClientId"].Value);

            frmEditClient frmClients = Program.ServiceProvider.GetRequiredService<frmEditClient>();
            frmClients.SetClientId(clientId);
            frmClients.SetMainForm(_frmMain);
            frmClients.Mode = frmEditClient.EnMode.Update;
            frmClients.ShowDialog();
        }
        private async void txtFilter_TextChanged(object sender, EventArgs e)
        {
            await LoadClientsData();
        }
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClients.SelectedRows.Count == 0)
                {
                    MessageBox.Show("الرجاء تحديد عميل للحذف.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int clientId = Convert.ToInt32(dgvClients.SelectedRows[0].Cells["colClientId"].Value);
                string fullName = dgvClients.SelectedRows[0].Cells["colFullName"].Value.ToString();

                var confirm = MessageBox.Show(
                    $"هل أنت متأكد من حذف العميل '{fullName}'؟",
                    "تأكيد الحذف",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes)
                    return;

                var result = await _clientsService.DeleteClientAsync(new Data.DTOs.Clients.Delete.ClientDeleteRequestDto {
                ClientId=clientId});
                if (result.IsSuccess)
                {
                    MessageBox.Show("تم حذف العميل بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadClientsData();
                }
                else
                {
                    MessageBox.Show($"فشل الحذف: {result.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting client");
                ShowError("حدث خطأ أثناء حذف العميل", ex);
            }
        }

        private  async void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtFilterPhone.Clear();
            txtFilterName.Clear();
            await LoadClientsData();
        }
    }
}