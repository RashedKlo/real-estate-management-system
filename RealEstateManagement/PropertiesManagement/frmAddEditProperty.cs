using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using RealEstateManagement.Services.Interfaces;
using RealEstateManagement.Data.DTOs.Properties.Create;
using RealEstateManagement.Data.DTOs.Clients.Create;
using RealEstateManagement.Data.DTOs.Clients.Queries;
using RealEstateManagement.Data.DTOs.Properties.Update;
using RealEstateManagement.Data.DTOs.Properties.Queries;


namespace RealEstateManagement
{
    public partial class frmAddEditProperty : Form
    {
        #region Fields

        private readonly IPropertiesService _propertiesService;
        private readonly IClientsService _clientsService;
        private readonly ILogger<frmAddEditProperty> _logger;
        private frmMain _mainForm;
        private int? _propertyId;
        private int? _selectedOwnerId;
        private string _selectedOwnerName;
        private bool _isEditMode = false;

        #endregion

        #region Constructor

        public frmAddEditProperty(
            IPropertiesService propertiesService,
            IClientsService clientsService,
            ILogger<frmAddEditProperty> logger)
        {
            if (propertiesService == null)
                throw new ArgumentNullException(nameof(propertiesService));

            if (clientsService == null)
                throw new ArgumentNullException(nameof(clientsService));

            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            InitializeComponent();

            _propertiesService = propertiesService;
            _clientsService = clientsService;
            _logger = logger;

            SetupOptimization();
            InitializeFormControls();
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
            _isEditMode = true;
            lblTitle.Text = "تعديل العقار";
            btnSave.Text = "حفظ التعديلات";
        }

        #endregion

        #region Event Handlers

        private async void frmAddEditProperty_Load(object sender, EventArgs e)
        {
            try
            {
                _mainForm?.UpdateStatusBar(_isEditMode ? $"تحميل بيانات العقار رقم {_propertyId}" : "إضافة عقار جديد");

                await LoadComboBoxData();

                if (_isEditMode && _propertyId.HasValue)
                {
                    await LoadPropertyDataForEdit();
                }

                _mainForm?.UpdateStatusBar("جاهز");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading form");
                ShowError("حدث خطأ أثناء تحميل النموذج", ex);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                _mainForm?.UpdateStatusBar("جاري حفظ البيانات...");

                if (_isEditMode && _propertyId.HasValue)
                {
                    await UpdateProperty();
                }
                else
                {
                    await CreateProperty();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error saving property");
                ShowError("حدث خطأ أثناء حفظ البيانات", ex);
            }
            finally
            {
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
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



        #region Helper Classes


        public class ClientsSearchRequestDto
        {
            public string SearchTerm { get; set; }
            public int Page { get; set; }
            public int Limit { get; set; }
        }



        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchOwner_Click(object sender, EventArgs e)
        {
            frmSearchOwner frmClients = Program.ServiceProvider.GetRequiredService<frmSearchOwner>();
          
            frmClients.ShowDialog();
        }

        private void btnCreateOwner_Click(object sender, EventArgs e)
        {
            frmEditClient frmClients = Program.ServiceProvider.GetRequiredService<frmEditClient>();
            frmClients.SetMainForm(_mainForm);
            frmClients.Mode = frmEditClient.EnMode.Add;
            frmClients.ShowDialog();
            // After creating, perhaps refresh or set selected
            if (frmClients.DialogResult == DialogResult.OK)
            {
                // Assuming frmEditClient sets some global or something, but better to get the new ID
                // For now, assume user will search again
            }
        }

        private void btnClearOwner_Click(object sender, EventArgs e)
        {
            ClearOwnerSelection();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            // TODO: Implement image upload
            MessageBox.Show(
                "سيتم إضافة وظيفة تحميل الصور قريباً",
                "قيد التطوير",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }



        #region Private Methods - Initialization

        private void InitializeFormControls()
        {
            // Initialize ComboBoxes
            cmbTransactionType.Items.Clear();
            cmbTransactionType.Items.AddRange(new object[] { "للبيع", "للإيجار" });

            // Set default selections
            if (cmbTransactionType.Items.Count > 0)
                cmbTransactionType.SelectedIndex = 0;
            // Setup numeric validation
            txtRooms.KeyPress += NumericTextBox_KeyPress;
            txtPrice.KeyPress += DecimalTextBox_KeyPress;
            txtArea.KeyPress += DecimalTextBox_KeyPress;

            // Hook up event handlers
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
            btnUploadImage.Click += btnUploadImage_Click;
            this.Load += frmAddEditProperty_Load;

            // Make txtSelectedOwner read-only
            txtSelectedOwner.ReadOnly = true;
            txtSelectedOwner.BackColor = System.Drawing.Color.FromArgb(40, 43, 55);
        }

        private async Task LoadComboBoxData()
        {
            try
            {
                // Load cities - you can expand this list or load from database
                cmbCity.Items.Clear();
                cmbCity.Items.AddRange(new object[]
                {
                    "القاهرة", "الإسكندرية", "الجيزة", "الشرقية", "الدقهلية",
                    "البحيرة", "المنيا", "سوهاج", "أسيوط", "الغربية",
                    "الفيوم", "بني سويف", "الإسماعيلية", "السويس"
                });

                if (cmbCity.Items.Count > 0)
                    cmbCity.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading combo box data");
            }
        }

        #endregion

        #region Private Methods - Data Operations

        private async Task CreateProperty()
        {
            try
            {
                // Determine if we need to create owner or use existing
                PropertyCreateRequestDto request;

                if (_selectedOwnerId.HasValue)
                {
                    // Use existing owner
                    request = new PropertyCreateRequestDto
                    {
                        Location = txtTitle.Text.Trim(),
                        NumOfRooms = int.Parse(txtRooms.Text.Trim()),
                        Availability = GetEnglishAvailability(cmbTransactionType.Text),
                        Price = decimal.Parse(txtPrice.Text.Trim()),
                        Description = txtDescription.Text.Trim(),
                        Area = decimal.Parse(txtArea.Text.Trim()),
                        OwnerId = _selectedOwnerId.Value
                    };
                }
                else
                {
                    // Show dialog to get owner info
                    var ownerInfo = ShowOwnerInfoDialog();
                    if (ownerInfo == null)
                    {
                        MessageBox.Show(
                            "يجب تحديد مالك للعقار",
                            "تنبيه",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                        return;
                    }

                    request = new PropertyCreateRequestDto
                    {
                        Location = txtTitle.Text.Trim(),
                        NumOfRooms = int.Parse(txtRooms.Text.Trim()),
                        Availability = GetEnglishAvailability(cmbTransactionType.Text),
                        Price = decimal.Parse(txtPrice.Text.Trim()),
                        Description = txtDescription.Text.Trim(),
                        Area = decimal.Parse(txtArea.Text.Trim()),
                        OwnerFullName = ownerInfo.Value.FullName,
                        OwnerPhoneNumber = ownerInfo.Value.Phone,
                        OwnerAddress = ownerInfo.Value.Address,
                    };
                }

                var result = await _propertiesService.AddPropertyAsync(request);

                if (result.IsSuccess)
                {
                    MessageBox.Show(
                        "تم إضافة العقار بنجاح",
                        "نجح",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

                    _logger.LogInformation("Property created successfully - PropertyId: {PropertyId}", result.Data?.PropertyId);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        result.Message ?? "فشل في إضافة العقار",
                        "خطأ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating property");
                throw;
            }
        }

        private async Task UpdateProperty()
        {
            try
            {
                var request = new PropertyUpdateRequestDto
                {
                    PropertyId = _propertyId.Value,
                    Location = txtTitle.Text.Trim(),
                    NumOfRooms = int.Parse(txtRooms.Text.Trim()),
                    Availability = GetEnglishAvailability(cmbTransactionType.Text),
                    Status="جيد",
                    Price = decimal.Parse(txtPrice.Text.Trim()),
                    Description = txtDescription.Text.Trim(),
                    Area = decimal.Parse(txtArea.Text.Trim())
                };

                var result = await _propertiesService.UpdatePropertyAsync(request);

                if (result.IsSuccess)
                {
                    MessageBox.Show(
                        "تم تحديث العقار بنجاح",
                        "نجح",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

                    _logger.LogInformation("Property updated successfully - PropertyId: {PropertyId}", _propertyId);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        result.Message ?? "فشل في تحديث العقار",
                        "خطأ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating property - PropertyId: {PropertyId}", _propertyId);
                throw;
            }
        }

        private async Task LoadPropertyDataForEdit()
        {
            try
            {
                var request = new PropertyGetRequestDto { PropertyId = _propertyId.Value };
                var result = await _propertiesService.GetPropertyAsync(request);

                if (!result.IsSuccess || result.Data == null)
                {
                    MessageBox.Show(
                        "فشل في تحميل بيانات العقار",
                        "خطأ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    this.Close();
                    return;
                }

                var data = result.Data;

                // Fill form fields
                txtTitle.Text = data.Location;
                txtDescription.Text = data.Description;
                txtRooms.Text = data.NumOfRooms.ToString();
                txtPrice.Text = data.Price.ToString("0.00");
                txtArea.Text = data.Area.ToString("0.00");

                // Set combo boxes
                SetComboBoxValue(cmbTransactionType, (data.Availability));

                // Set owner info
                _selectedOwnerId = data.OwnerId;

                // Fetch owner name
                var ownerRequest = new ClientGetRequestDto { ClientId = data.OwnerId };
                var ownerResult = await _clientsService.GetClientAsync(ownerRequest);
                if (ownerResult.IsSuccess && ownerResult.Data != null)
                {
                    _selectedOwnerName = ownerResult.Data.FullName;
                    txtSelectedOwner.Text = _selectedOwnerName;
                }

                _logger.LogInformation("Property data loaded for edit - PropertyId: {PropertyId}", _propertyId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading property data for edit - PropertyId: {PropertyId}", _propertyId);
                throw;
            }
        }

        #endregion

        #region Private Methods - Owner Management

        private async void ShowOwnerSearchDialog()
        {
            using (var searchForm = new Form())
            {
                searchForm.Text = "البحث عن مالك";
                searchForm.Size = new System.Drawing.Size(600, 400);
                searchForm.StartPosition = FormStartPosition.CenterParent;
                searchForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                searchForm.MaximizeBox = false;
                searchForm.MinimizeBox = false;
                searchForm.RightToLeft = RightToLeft.Yes;
                searchForm.RightToLeftLayout = true;

                var txtSearch = new Guna.UI2.WinForms.Guna2TextBox
                {
                    Location = new System.Drawing.Point(20, 20),
                    Size = new System.Drawing.Size(560, 36),
                    PlaceholderText = "ابحث بالاسم أو رقم الهاتف...",
                    BorderRadius = 8
                };

                var dgvResults = new DataGridView
                {
                    Location = new System.Drawing.Point(20, 70),
                    Size = new System.Drawing.Size(560, 240),
                    AllowUserToAddRows = false,
                    AllowUserToDeleteRows = false,
                    ReadOnly = true,
                    MultiSelect = false,
                    SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    BackgroundColor = System.Drawing.Color.FromArgb(30, 33, 45),
                    BorderStyle = BorderStyle.None
                };

                dgvResults.Columns.Add("ClientId", "الرقم");
                dgvResults.Columns.Add("FullName", "الاسم");
                dgvResults.Columns.Add("Phone", "الهاتف");

                var btnSelect = new Guna.UI2.WinForms.Guna2Button
                {
                    Text = "اختيار",
                    Location = new System.Drawing.Point(480, 320),
                    Size = new System.Drawing.Size(100, 36),
                    BorderRadius = 8
                };

                var btnClose = new Guna.UI2.WinForms.Guna2Button
                {
                    Text = "إغلاق",
                    Location = new System.Drawing.Point(370, 320),
                    Size = new System.Drawing.Size(100, 36),
                    BorderRadius = 8,
                    FillColor = System.Drawing.Color.FromArgb(220, 53, 69)
                };

                txtSearch.TextChanged += async (s, e) =>
                {
                    if (string.IsNullOrWhiteSpace(txtSearch.Text) || txtSearch.Text.Length < 2)
                        return;

                    try
                    {
                        var request = new ClientsGetRequestDto
                        {
                            Page = 1,
                            Limit = 10,
                            FullName = "",
                            PhoneNumber = ""
                        };

                        var result = await _clientsService.GetClientsAsync(request);

                        if (result.IsSuccess && result.Data != null)
                        {
                            dgvResults.Rows.Clear();
                            foreach (var client in result.Data.Clients)
                            {
                                dgvResults.Rows.Add(
                                    client.ClientId,
                                    client.FullName,
                                    client.PhoneNumber
                                );
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Error searching clients");
                    }
                };

                btnSelect.Click += (s, e) =>
                {
                    if (dgvResults.SelectedRows.Count > 0)
                    {
                        _selectedOwnerId = Convert.ToInt32(dgvResults.SelectedRows[0].Cells["ClientId"].Value);
                        _selectedOwnerName = dgvResults.SelectedRows[0].Cells["FullName"].Value.ToString();
                        txtSelectedOwner.Text = _selectedOwnerName;

                        MessageBox.Show(
                            $"تم اختيار المالك: {_selectedOwnerName}",
                            "نجح",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

                        searchForm.DialogResult = DialogResult.OK;
                        searchForm.Close();
                    }
                };

                btnClose.Click += (s, e) => searchForm.Close();

                searchForm.Controls.AddRange(new Control[] { txtSearch, dgvResults, btnSelect, btnClose });
                searchForm.ShowDialog(this);
            }
        }

        private async void ShowCreateOwnerDialog()
        {
            using (var createForm = new Form())
            {
                createForm.Text = "إضافة مالك جديد";
                createForm.Size = new System.Drawing.Size(500, 300);
                createForm.StartPosition = FormStartPosition.CenterParent;
                createForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                createForm.MaximizeBox = false;
                createForm.MinimizeBox = false;
                createForm.RightToLeft = RightToLeft.Yes;
                createForm.RightToLeftLayout = true;

                var lblName = new Label { Text = "الاسم الكامل:", Location = new System.Drawing.Point(20, 20), AutoSize = true };
                var txtName = new Guna.UI2.WinForms.Guna2TextBox { Location = new System.Drawing.Point(20, 45), Size = new System.Drawing.Size(450, 36), BorderRadius = 8 };

                var lblPhone = new Label { Text = "رقم الهاتف:", Location = new System.Drawing.Point(20, 90), AutoSize = true };
                var txtPhone = new Guna.UI2.WinForms.Guna2TextBox { Location = new System.Drawing.Point(20, 115), Size = new System.Drawing.Size(450, 36), BorderRadius = 8 };

                var lblAddress = new Label { Text = "العنوان:", Location = new System.Drawing.Point(20, 160), AutoSize = true };
                var txtAddress = new Guna.UI2.WinForms.Guna2TextBox { Location = new System.Drawing.Point(20, 185), Size = new System.Drawing.Size(450, 36), BorderRadius = 8 };

                var btnCreate = new Guna.UI2.WinForms.Guna2Button
                {
                    Text = "إضافة",
                    Location = new System.Drawing.Point(370, 230),
                    Size = new System.Drawing.Size(100, 36),
                    BorderRadius = 8
                };

                var btnClose = new Guna.UI2.WinForms.Guna2Button
                {
                    Text = "إلغاء",
                    Location = new System.Drawing.Point(260, 230),
                    Size = new System.Drawing.Size(100, 36),
                    BorderRadius = 8,
                    FillColor = System.Drawing.Color.FromArgb(220, 53, 69)
                };

                btnCreate.Click += async (s, e) =>
                {
                    if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
                    {
                        MessageBox.Show(
                            "يرجى إدخال الاسم ورقم الهاتف على الأقل",
                            "تنبيه",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                        return;
                    }

                    try
                    {
                        var request = new ClientCreateRequestDto
                        {
                            FullName = txtName.Text.Trim(),
                            PhoneNumber = txtPhone.Text.Trim(),
                            Address = txtAddress.Text.Trim()
                        };

                        var result = await _clientsService.AddClientAsync(request);

                        if (result.IsSuccess && result.Data != null)
                        {
                            _selectedOwnerId = result.Data.ClientId;
                            _selectedOwnerName = txtName.Text.Trim();
                            txtSelectedOwner.Text = _selectedOwnerName;

                            MessageBox.Show(
                                $"تم إضافة المالك بنجاح: {_selectedOwnerName}",
                                "نجح",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

                            createForm.DialogResult = DialogResult.OK;
                            createForm.Close();
                        }
                        else
                        {
                            MessageBox.Show(
                                result.Message ?? "فشل في إضافة المالك",
                                "خطأ",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                        }
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Error creating owner");
                        MessageBox.Show(
                            "حدث خطأ أثناء إضافة المالك",
                            "خطأ",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    }
                };

                btnClose.Click += (s, e) => createForm.Close();

                createForm.Controls.AddRange(new Control[] { lblName, txtName, lblPhone, txtPhone, lblAddress, txtAddress, btnCreate, btnClose });
                createForm.ShowDialog(this);
            }
        }

        private (string FullName, string Phone, string Address)? ShowOwnerInfoDialog()
        {
            var choice = MessageBox.Show(
                "هل تريد البحث عن مالك موجود أم إنشاء مالك جديد؟\n\nنعم = بحث\nلا = إنشاء جديد\nإلغاء = الرجوع",
                "اختر المالك",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

            if (choice == DialogResult.Yes)
            {
                ShowOwnerSearchDialog();
                return null; // Owner ID is set in search dialog
            }
            else if (choice == DialogResult.No)
            {
                ShowCreateOwnerDialog();
                return null; // Owner ID is set in create dialog
            }

            return null;
        }

        private void ClearOwnerSelection()
        {
            _selectedOwnerId = null;
            _selectedOwnerName = null;
            txtSelectedOwner.Text = "";
            MessageBox.Show(
                "تم إلغاء اختيار المالك",
                "تنبيه",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        #endregion

        #region Private Methods - Helpers

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DecimalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if (e.KeyChar == '.' && ((sender as Guna.UI2.WinForms.Guna2TextBox)?.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private string GetEnglishPropertyType(string arabicType)
        {
            switch (arabicType)
            {
                case "فيلا": return "Villa";
                case "شقة": return "Apartment";
                case "أرض": return "Land";
                case "عقار تجاري": return "Commercial";
                case "مكتب": return "Office";
                case "مستودع": return "Warehouse";
                default: return arabicType;
            }
        }

        private string GetArabicPropertyType(string englishType)
        {
            switch (englishType?.ToLower())
            {
                case "villa": return "فيلا";
                case "apartment": return "شقة";
                case "land": return "أرض";
                case "commercial": return "عقار تجاري";
                case "office": return "مكتب";
                case "warehouse": return "مستودع";
                default: return englishType;
            }
        }

        private string GetEnglishAvailability(string arabicAvailability)
        {
            switch (arabicAvailability)
            {
                case "للبيع": return "بيع";
                case "للإيجار": return "إيجار";
                case "للرهن": return "رهن";
                default: return arabicAvailability;
            }
        }


        private void SetComboBoxValue(Guna.UI2.WinForms.Guna2ComboBox comboBox, string value)
        {
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                if (comboBox.Items[i].ToString() == value)
                {
                    comboBox.SelectedIndex = i;
                    return;
                }
            }
        }

        private void SetupOptimization()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                         ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }
        #endregion

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
