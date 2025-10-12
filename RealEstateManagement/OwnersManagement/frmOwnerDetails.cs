using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Services.Interfaces;
using RealEstateManagement.Data.DTOs.Owners.Queries;

namespace RealEstateManagement
{
    public partial class frmOwnerDetails : Form
    {
        #region Fields

        private readonly IOwnersService _ownersService;
        private readonly ILogger<frmOwnerDetails> _logger;
        private frmMain _mainForm;
        private int _ownerId;
        private int _currentPage = 1;
        private const int PAGE_SIZE = 3;
        private int _totalPages = 1;
        private int _totalRecords = 0;

        #endregion

        #region Constructor

        public frmOwnerDetails(
            IOwnersService ownersService,
            ILogger<frmOwnerDetails> logger)
        {
            if (ownersService == null)
                throw new ArgumentNullException(nameof(ownersService));

            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            InitializeComponent();

            _ownersService = ownersService;
            _logger = logger;

            SetupOptimization();
        }

        #endregion

        #region Public Methods

        public void SetMainForm(frmMain mainForm)
        {
            _mainForm = mainForm;
        }

        public void SetOwnerId(int ownerId)
        {
            _ownerId = ownerId;
        }

        #endregion

        #region Event Handlers

        private async void frmOwnerDetails_Load(object sender, EventArgs e)
        {
            try
            {
                lblHeader.Text = "جاري التحميل...";
                _mainForm?.UpdateStatusBar($"تحميل تفاصيل المالك رقم {_ownerId}");

                await LoadOwnerDataAsync();

                _mainForm?.UpdateStatusBar($"تم عرض تفاصيل المالك رقم {_ownerId}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading owner details");
                ShowError("حدث خطأ أثناء تحميل البيانات", ex);
                this.Close();
            }
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
            {
                _currentPage++;
                await LoadOwnerDataAsync();
            }
        }

        private async void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                await LoadOwnerDataAsync();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Private Methods

        private async Task LoadOwnerDataAsync()
        {
            try
            {
                // Disable pagination buttons during loading
                btnNextPage.Enabled = false;
                btnPrevPage.Enabled = false;
                lblPageInfo.Text = "جاري التحميل...";

                var request = new OwnerPropertiesGetRequestDto
                {
                    OwnerId = _ownerId,
                    Page = _currentPage,
                    Limit = PAGE_SIZE
                };

                var result = await _ownersService.GetOwnerPropertiesAsync(request);

                if (!result.IsSuccess)
                {
                    _logger.LogError("Failed to load owner properties: {Message}", result.Message);
                    MessageBox.Show(
                        result.Message ?? $"لم يتم العثور على المالك رقم {_ownerId}",
                        "خطأ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    this.Close();
                    return;
                }

                var data = result.Data;
                // Update pagination data from response
                _totalPages = data.TotalPages;
                _totalRecords = data.TotalRecords;
                _currentPage = data.CurrentPage; // Use actual page from response

                // Update owner information
                txtOwnerID.Text = _ownerId.ToString();
                txtFullName.Text = data.OwnerFullName ?? string.Empty;
                txtPhone.Text = data.OwnerPhoneNumber ?? string.Empty;
                txtAddress.Text = data.OwnerAddress ?? string.Empty;
                lblHeader.Text = $"تفاصيل المالك: {data.OwnerFullName}";

                // Display properties in DataGridView
                if(data.Properties.Count>0)
                DisplayProperties(data);

                // Update pagination UI
                UpdatePaginationInfo();

                _mainForm?.UpdateStatusBar(
                    $"تم تحميل بيانات المالك رقم {_ownerId} - {data.Properties.Count} من {_totalRecords} عقار");

                _logger.LogInformation(
                    "Owner data loaded successfully - OwnerId: {OwnerId}, Page: {Page}, Records: {Count}/{Total}",
                    _ownerId, _currentPage, data.Properties.Count, _totalRecords);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading owner data - OwnerId: {OwnerId}, Page: {Page}",
                    _ownerId, _currentPage);
                ShowError("حدث خطأ أثناء تحميل بيانات المالك", ex);
            }
        }

        private void DisplayProperties(OwnerPropertiesGetResponseDto data)
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
                    _logger.LogInformation("No properties found for owner {OwnerId}", _ownerId);
                    return;
                }

                // Add rows manually to match designer columns
                foreach (var property in data.Properties)
                {
                    int rowIndex = dgvProperties.Rows.Add();
                    DataGridViewRow row = dgvProperties.Rows[rowIndex];

                    // Map data to columns based on designer names
                    row.Cells["colPropertyId"].Value = property.PropertyId;
                    row.Cells["colLocation"].Value = property.Location ?? "-";
                    row.Cells["colNumOfRooms"].Value = property.NumOfRooms;
                    row.Cells["colStatus"].Value = property.Status ?? "-";
                    row.Cells["colAvailability"].Value = property.Availability ?? "-";
                    row.Cells["colRentPrice"].Value = property.RentPrice.HasValue
                        ? property.RentPrice.Value.ToString("N2") + " ج.م"
                        : "-";
                    row.Cells["colSalePrice"].Value = property.SalePrice.HasValue
                        ? property.SalePrice.Value.ToString("N2") + " ج.م"
                        : "-";
                    row.Cells["colMortgagePrice"].Value = property.MortgagePrice.HasValue
                        ? property.MortgagePrice.Value.ToString("N2") + " ج.م"
                        : "-";
                    row.Cells["colCreatedAt"].Value = property.CreatedAt.ToString("dd/MM/yyyy");

                    // Store the full property object in the row's Tag for later use
                    row.Tag = property;
                }

                _logger.LogInformation(
                    "Displayed {Count} properties for owner {OwnerId}",
                    data.Properties.Count, _ownerId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error displaying properties for owner {OwnerId}", _ownerId);
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
            // Update owner ID label
            lblOwnerId.Text = $"رقم المالك: {_ownerId}";

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