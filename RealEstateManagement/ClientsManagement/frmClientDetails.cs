using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Services.Interfaces;
using RealEstateManagement.Data.DTOs.Clients.Queries;

namespace RealEstateManagement
{
    public partial class frmClientDetails : Form
    {
        #region Fields

        private readonly IClientsService _clientsService;
        private readonly ILogger<frmClientDetails> _logger;
        private frmMain _mainForm;
        private int _clientId;
        private int _currentPage = 1;
        private const int PAGE_SIZE = 3;
        private int _totalPages = 1;
        private int _totalRecords = 0;

        #endregion

        #region Constructor

        public frmClientDetails(
            IClientsService clientsService,
            ILogger<frmClientDetails> logger)
        {
            if (clientsService == null)
                throw new ArgumentNullException(nameof(clientsService));

            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            InitializeComponent();

            _clientsService = clientsService;
            _logger = logger;

            SetupOptimization();
        }

        #endregion

        #region Public Methods

        public void SetMainForm(frmMain mainForm)
        {
            _mainForm = mainForm;
        }

        public void SetClientId(int clientId)
        {
            _clientId = clientId;
        }

        #endregion

        #region Event Handlers

        private async void frmClientDetails_Load(object sender, EventArgs e)
        {
            try
            {
                lblHeader.Text = "جاري التحميل...";
                _mainForm?.UpdateStatusBar($"تحميل تفاصيل العميل رقم {_clientId}");

                await LoadClientDataAsync();

                _mainForm?.UpdateStatusBar($"تم عرض تفاصيل العميل رقم {_clientId}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading client details");
                ShowError("حدث خطأ أثناء تحميل البيانات", ex);
                this.Close();
            }
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
            {
                _currentPage++;
                await LoadClientDataAsync();
            }
        }

        private async void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                await LoadClientDataAsync();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Private Methods

        private async Task LoadClientDataAsync()
        {
            try
            {
                // Disable pagination buttons during loading
                btnNextPage.Enabled = false;
                btnPrevPage.Enabled = false;
                lblPageInfo.Text = "جاري التحميل...";

                var request = new ClientPropertiesGetRequestDto
                {
                    ClientId = _clientId,
                    Page = _currentPage,
                    Limit = PAGE_SIZE
                };

                var result = await _clientsService.GetClientPropertiesAsync(request);

                if (!result.IsSuccess)
                {
                    _logger.LogError("Failed to load client properties: {Message}", result.Message);
                    MessageBox.Show(
                        result.Message ?? $"لم يتم العثور على العميل رقم {_clientId}",
                        "خطأ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    this.Close();
                    return;
                }

                var data = result.Data;
                // FIXED: Update pagination data from response
                _totalPages = data.TotalPages;
                _totalRecords = data.TotalRecords;
                _currentPage = data.CurrentPage; // Use actual page from response

                // Update client information
                txtClientID.Text = _clientId.ToString();
                txtFullName.Text = data.ClientFullName ?? string.Empty;
                txtPhone.Text = data.ClientPhoneNumber ?? string.Empty;
                txtAddress.Text = data.ClientAddress ?? string.Empty;
                lblHeader.Text = $"تفاصيل العميل: {data.ClientFullName}";

                // FIXED: Display properties in DataGridView (assuming you have dgvProperties)
                DisplayProperties(data);

                // Update pagination UI
                UpdatePaginationInfo();

                _mainForm?.UpdateStatusBar(
                    $"تم تحميل بيانات العميل رقم {_clientId} - {data.Properties.Count} من {_totalRecords} عقار");

                _logger.LogInformation(
                    "Client data loaded successfully - ClientId: {ClientId}, Page: {Page}, Records: {Count}/{Total}",
                    _clientId, _currentPage, data.Properties.Count, _totalRecords);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading client data - ClientId: {ClientId}, Page: {Page}",
                    _clientId, _currentPage);
                ShowError("حدث خطأ أثناء تحميل بيانات العميل", ex);
            }
        }

        private void DisplayProperties(ClientPropertiesGetResponseDto data)
        {
            try
            {
                // Clear existing rows
                dgvProperties.Rows.Clear();

                // Update properties count label
                lblPropertiesCount.Text = data.Properties == null || data.Properties.Count == 0
                    ? "(0 عقار)"
                    : $"({data.Properties.Count} عقار)";

                if (data.Properties == null || data.Properties.Count == 0)
                {
                    _logger.LogInformation("No properties found for client {ClientId}", _clientId);
                    return;
                }

                // Add rows manually to match designer columns
                foreach (var property in data.Properties)
                {
                    int rowIndex = dgvProperties.Rows.Add();
                    DataGridViewRow row = dgvProperties.Rows[rowIndex];

                    // Map data to columns based on designer names
                    row.Cells["colPropertyId"].Value = property.PropertyId;
                    row.Cells["colLocation"].Value = property.PropertyLocation ?? "-";
                    row.Cells["colTransactionType"].Value = property.TransactionType ?? "-";
                    row.Cells["colAmount"].Value = property.Amount.ToString("N2") + " ج.م";
                    row.Cells["colTransactionDate"].Value = property.TransactionDate.ToString("dd/MM/yyyy");

                    // Store the full property object in the row's Tag for later use
                    row.Tag = property;
                }

                _logger.LogInformation(
                    "Displayed {Count} properties for client {ClientId}",
                    data.Properties.Count, _clientId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error displaying properties for client {ClientId}", _clientId);
                MessageBox.Show(
                    "حدث خطأ أثناء عرض العقارات",
                    "خطأ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }

        private void UpdatePaginationInfo()
        {
            // Update client ID label
            lblClientId.Text = $"رقم العميل: {_clientId}";

            if (_totalRecords == 0)
            {
                lblPageInfo.Text = "لا توجد عقارات";
                btnNextPage.Enabled = false;
                btnPrevPage.Enabled = false;
                return;
            }

            lblPageInfo.Text = $"صفحة {_currentPage} من {_totalPages} ({_totalRecords} عقار)";
            btnNextPage.Enabled = _currentPage < _totalPages;
            btnPrevPage.Enabled = _currentPage > 1;
        }

        private void SetupOptimization()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                         ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }

        private void ShowError(string message, Exception ex)
        {
            _logger.LogError(ex, message);
            MessageBox.Show(
                $"{message}\n{ex?.Message}",
                "خطأ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        #endregion
    }
}