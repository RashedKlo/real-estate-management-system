using System;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Services.Interfaces;
using RealEstateManagement.Data.DTOs.Clients.Queries;
using RealEstateManagement.Data.DTOs.Clients.Update;
using RealEstateManagement.Data.DTOs.Clients.Create ;
using System.Threading.Tasks;

namespace RealEstateManagement
{
    public partial class frmEditClient : Form
    {
        #region Fields

        private readonly IClientsService _clientsService;
        private readonly ILogger<frmEditClient> _logger;
        private frmMain _mainForm;
        private int _clientId;

        #endregion

        #region Properties

        public enum EnMode { Add, Update }
        public EnMode Mode { get; set; }

        #endregion

        #region Constructor

        public frmEditClient(IClientsService clientsService, ILogger<frmEditClient> logger)
        {
            if (clientsService == null)
                throw new ArgumentNullException(nameof(clientsService));

            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            InitializeComponent();

            _clientsService = clientsService;
            _logger = logger;
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

        private async void frmEditClient_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Mode == EnMode.Update
                    ? $"تعديل بيانات العميل (ID: {_clientId})"
                    : "إضافة بيانات عميل جديد";

                if (Mode == EnMode.Update)
                {
                    await LoadClientData();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading form");
                ShowError("حدث خطأ أثناء تحميل البيانات", ex);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm() || !ConfirmSave())
                return;

            try
            {
                await SaveClient();

                _mainForm?.UpdateStatusBar($"تم تحديث العميل رقم {_clientId} بنجاح");
                MessageBox.Show("تم حفظ البيانات بنجاح", "نجاح",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error saving client");
                ShowError("حدث خطأ أثناء حفظ البيانات", ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Private Methods

        private async System.Threading.Tasks.Task LoadClientData()
        {
            var request = new ClientGetRequestDto { ClientId = _clientId };
            var result = await _clientsService.GetClientAsync(request);

            if (!result.IsSuccess)
            {
                MessageBox.Show($"لم يتم العثور على العميل رقم {_clientId}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            var client = result.Data;
            var name = client.FullName.Split(' ');
            txtClientID.Text = client.ClientId.ToString();
            txtFirstName.Text = name[0];
            txtLastName.Text = name[1];
            txtPhone.Text = client.PhoneNumber;
            txtAddress.Text = client.Address;
            dtpDateRegistered.Value = client.CreatedAt;
            lblHeader.Text = $"تعديل بيانات العميل: {client.FullName}";

            _mainForm?.UpdateStatusBar($"تم تحميل بيانات العميل رقم {_clientId}");
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("يرجى إدخال جميع الحقول المطلوبة", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ConfirmSave()
        {
            string details = $"رقم العميل: {_clientId}\n" +
                           $"الاسم: {txtFirstName.Text} {txtLastName.Text}\n";
                         

            var result = MessageBox.Show(
                $"هل تريد حفظ التعديلات؟\n\n{details}",
                "تأكيد الحفظ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return result == DialogResult.Yes;
        }
        private async Task UpdateClient()
        {
            var request = new ClientUpdateRequestDto
            {
                ClientId = _clientId,
                FullName = $"{txtFirstName.Text} {txtLastName.Text}",
                PhoneNumber = txtPhone.Text.Trim(),
                Address = txtAddress.Text
            };

            var result = await _clientsService.UpdateClientAsync(request);
            if (result == null || !result.IsSuccess)
            {
                throw new Exception(result.Message ?? "فشل في حفظ البيانات");
            }

        }
        private async Task AddClient()
        {
            var request = new ClientCreateRequestDto
            {
                FullName = $"{txtFirstName.Text} {txtLastName.Text}",
                PhoneNumber = txtPhone.Text.Trim(),
                Address = txtAddress.Text
            };

            var result = await _clientsService.AddClientAsync(request);
            if (result == null || !result.IsSuccess)
            {
                throw new Exception(result.Message ?? "فشل في حفظ البيانات");
            }

        }
        private async Task SaveClient()
        {
          
           if (EnMode.Add == Mode)
            {
                await AddClient();
            }
           else
            {
                await UpdateClient();
            }
        }

        private void ShowError(string message, Exception ex)
        {
            _logger.LogError(ex, message);
            MessageBox.Show($"{message}\n{ex?.Message}", "خطأ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
    }
}