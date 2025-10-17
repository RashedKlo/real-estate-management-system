using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Services.Interfaces;
using RealEstateManagement.Data.DTOs.Properties.Queries;

namespace RealEstateManagement
{
    public partial class frmPropertyDetails : Form
    {
        #region Fields

        private readonly IPropertiesService _propertiesService;
        private readonly ILogger<frmPropertyDetails> _logger;
        private frmMain _mainForm;
        private int _propertyId;

        #endregion

        #region Constructor

        public frmPropertyDetails(
            IPropertiesService propertiesService,
            ILogger<frmPropertyDetails> logger)
        {
            if (propertiesService == null)
                throw new ArgumentNullException(nameof(propertiesService));

            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            InitializeComponent();

            _propertiesService = propertiesService;
            _logger = logger;

            SetupOptimization();
            SetupArabicUI();
        }

        #endregion

        #region Public Methods

        public void SetMainForm(frmMain mainForm)
        {
            _mainForm = mainForm;
        }

        public void SetPropertyId(int propertyId)
        {
            _propertyId = propertyId;
        }

        #endregion

        #region Event Handlers

        private async void frmPropertyDetails_Load(object sender, EventArgs e)
        {
            try
            {
                lblTitle.Text = "جاري التحميل...";
                _mainForm?.UpdateStatusBar($"تحميل تفاصيل العقار رقم {_propertyId}");

                await LoadPropertyDataAsync();

                _mainForm?.UpdateStatusBar($"تم عرض تفاصيل العقار رقم {_propertyId}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading property details for PropertyId: {PropertyId}", _propertyId);
                ShowError("حدث خطأ أثناء تحميل البيانات", ex);
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditProperty_Click(object sender, EventArgs e)
        {
            // TODO: Implement edit functionality
            MessageBox.Show(
                "سيتم إضافة وظيفة التعديل قريباً",
                "قيد التطوير",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        #endregion

        #region Private Methods

        private async Task LoadPropertyDataAsync()
        {
            try
            {
                // Show loading state
                SetLoadingState(true);

                var request = new PropertyGetRequestDto
                {
                    PropertyId = _propertyId
                };

                var result = await _propertiesService.GetPropertyAsync(request);

                if (!result.IsSuccess)
                {
                    _logger.LogError("Failed to load property: {Message}", result.Message);
                    MessageBox.Show(
                        result.Message ?? $"لم يتم العثور على العقار رقم {_propertyId}",
                        "خطأ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    this.Close();
                    return;
                }

                var data = result.Data;

                // Display property information
                DisplayPropertyDetails(data);

                _mainForm?.UpdateStatusBar($"تم تحميل بيانات العقار رقم {_propertyId} بنجاح");

                _logger.LogInformation(
                    "Property data loaded successfully - PropertyId: {PropertyId}, Location: {Location}",
                    _propertyId, data.Location);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading property data - PropertyId: {PropertyId}", _propertyId);
                ShowError("حدث خطأ أثناء تحميل بيانات العقار", ex);
                this.Close();
            }
            finally
            {
                SetLoadingState(false);
            }
        }

        private void DisplayPropertyDetails(PropertyGetResponseDto data)
        {
            try
            {
                // Update header and ID
                lblTitle.Text = $"{data.Location} - رقم {data.PropertyId}";
                lblPropertyID.Text = $"رقم العقار: {data.PropertyId}";

                // Details Tab
                lblValueType.Text = GetPropertyTypeArabic(data.Status);
                lblValueTransaction.Text = GetAvailabilityArabic(data.Availability);
                lblValueCity.Text = data.Location ?? "-";
                lblValueArea.Text = $"{data.Area:N2} م²";
                lblValueRooms.Text = data.NumOfRooms.ToString();
                lblValueBathrooms.Text = "-"; // Not in DTO
                lblValueDate.Text = data.CreatedAt.ToString("dd/MM/yyyy");

                // Financials Tab
                lblValuePrice.Text = $"{data.Price:N2} ج.م";
                lblValueCommission.Text = CalculateCommission(data.Price);
                lblValueDLDFee.Text = "-"; // Not in DTO

                // Description Tab
                txtDescription.Text = string.IsNullOrWhiteSpace(data.Description)
                    ? "لا يوجد وصف متاح"
                    : data.Description;

                // Status Panel
                UpdateStatusDisplay(data.Availability);

                // Owner/Agent Information
                lblAgentName.Text = data.OwnerName ?? "غير متوفر";
                lblAgentPhone.Text = data.OwnerPhone ?? "غير متوفر";
                lblAgentEmail.Text = data.OwnerAddress ?? "غير متوفر";

                _logger.LogInformation(
                    "Property details displayed successfully - PropertyId: {PropertyId}",
                    _propertyId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error displaying property details - PropertyId: {PropertyId}", _propertyId);
                MessageBox.Show(
                    "حدث خطأ أثناء عرض تفاصيل العقار",
                    "خطأ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }

        private void SetupArabicUI()
        {
            // Set RTL for the entire form
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;

            // Update button texts
            btnClose.Text = "إغلاق";
            btnEditProperty.Text = "تعديل العقار";

            // Update tab texts
            tabPageDetails.Text = "التفاصيل";
            tabPageFinancials.Text = "المعلومات المالية";
            tabPageDescription.Text = "الوصف والمميزات";

            // Update labels in Details tab
            label1.Text = "نوع العقار:";
            label2.Text = "نوع المعاملة:";
            label4.Text = "الموقع:";
            label6.Text = "المساحة:";
            label8.Text = "عدد الغرف:";
            label10.Text = "عدد الحمامات:";
            label12.Text = "تاريخ الإضافة:";

            // Update labels in Financials tab
            label15.Text = "السعر:";
            label17.Text = "العمولة:";
            label19.Text = "رسوم التسجيل:";

            // Update labels in Description tab
            label20.Text = "الوصف:";
            label21.Text = "المميزات:";

            // Update right panel labels
            label14.Text = "حالة العقار";
            label22.Text = "بيانات المالك";
            label23.Text = "الهاتف:";
            label24.Text = "العنوان:";

            // Image gallery
            label13.Text = "صور العقار";
        }

        private void UpdateStatusDisplay(string availability)
        {
            if (string.IsNullOrWhiteSpace(availability))
            {
                lblStatus.Text = "غير محدد";
                lblStatus.FillColor = System.Drawing.Color.Gray;
                return;
            }

            switch (availability.ToLower())
            {
                case "available":
                case "متاح":
                    lblStatus.Text = "متاح";
                    lblStatus.FillColor = System.Drawing.Color.FromArgb(0, 192, 0);
                    break;
                case "sold":
                case "مباع":
                    lblStatus.Text = "مباع";
                    lblStatus.FillColor = System.Drawing.Color.FromArgb(220, 53, 69);
                    break;
                case "reserved":
                case "محجوز":
                    lblStatus.Text = "محجوز";
                    lblStatus.FillColor = System.Drawing.Color.FromArgb(255, 193, 7);
                    break;
                case "pending":
                case "قيد الانتظار":
                    lblStatus.Text = "قيد الانتظار";
                    lblStatus.FillColor = System.Drawing.Color.FromArgb(23, 162, 184);
                    break;
                default:
                    lblStatus.Text = availability;
                    lblStatus.FillColor = System.Drawing.Color.Gray;
                    break;
            }
        }

        private string GetPropertyTypeArabic(string status)
        {
            if (string.IsNullOrWhiteSpace(status))
                return "-";

            switch (status.ToLower())
            {
                case "villa":
                case "فيلا":
                    return "فيلا";
                case "apartment":
                case "شقة":
                    return "شقة";
                case "land":
                case "أرض":
                    return "أرض";
                case "commercial":
                case "تجاري":
                    return "عقار تجاري";
                case "office":
                case "مكتب":
                    return "مكتب";
                default:
                    return status;
            }
        }

        private string GetAvailabilityArabic(string availability)
        {
            if (string.IsNullOrWhiteSpace(availability))
                return "-";

            switch (availability.ToLower())
            {
                case "sale":
                case "للبيع":
                    return "للبيع";
                case "rent":
                case "للإيجار":
                    return "للإيجار";
                case "both":
                case "كلاهما":
                    return "للبيع والإيجار";
                default:
                    return availability;
            }
        }

        private string CalculateCommission(decimal price)
        {
            // Calculate 5% commission as example
            decimal commission = price * 0.05m;
            return $"{commission:N2} ج.م";
        }

        private void SetLoadingState(bool isLoading)
        {
            if (isLoading)
            {
                lblTitle.Text = "جاري التحميل...";
                btnEditProperty.Enabled = false;
                guna2TabControl1.Enabled = false;
            }
            else
            {
                btnEditProperty.Enabled = true;
                guna2TabControl1.Enabled = true;
            }
        }

        private void SetupOptimization()
        {
            // Enable double buffering for better performance
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                         ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.UserPaint, true);
            this.UpdateStyles();

            // Optimize tab control
            guna2TabControl1.SuspendLayout();
            guna2TabControl1.ResumeLayout(false);

            // Optimize panels
            pnlRightInfo.SuspendLayout();
            pnlRightInfo.ResumeLayout(false);
        }

        private void ShowError(string message, Exception ex)
        {
            _logger.LogError(ex, message);
            MessageBox.Show(
                $"{message}\n\nتفاصيل الخطأ: {ex?.Message}",
                "خطأ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        #endregion


    }
}