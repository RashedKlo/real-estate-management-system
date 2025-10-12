using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Services.Interfaces;
using RealEstateManagement.Data.DTOs.Owners.Queries;
using RealEstateManagement.Data.DTOs.Owners.Update;
using RealEstateManagement.Data.DTOs.Owners.Create;

namespace RealEstateManagement
{
    public partial class frmEditOwner : Form
    {
        #region Fields

        private readonly IOwnersService _ownersService;
        private readonly ILogger<frmEditOwner> _logger;
        private frmMain _mainForm;
        private int _ownerId;

        #endregion

        #region Properties

        public enum EnMode { Add, Update }
        public EnMode Mode { get; set; }

        #endregion

        #region Constructor

        public frmEditOwner(IOwnersService ownersService, ILogger<frmEditOwner> logger)
        {
            if (ownersService == null)
                throw new ArgumentNullException(nameof(ownersService));

            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            InitializeComponent();

            _ownersService = ownersService;
            _logger = logger;
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

        private async void frmEditOwner_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Mode == EnMode.Update
                    ? $"تعديل بيانات المالك (ID: {_ownerId})"
                    : "إضافة بيانات مالك جديد";

                if (Mode == EnMode.Update)
                {
                    await LoadOwnerData();
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
                await SaveOwner();

                _mainForm?.UpdateStatusBar($"تم تحديث المالك رقم {_ownerId} بنجاح");
                MessageBox.Show("تم حفظ البيانات بنجاح", "نجاح",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error saving owner");
                ShowError("حدث خطأ أثناء حفظ البيانات", ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Private Methods

        private async Task LoadOwnerData()
        {
            var request = new OwnerGetRequestDto { OwnerId = _ownerId };
            var result = await _ownersService.GetOwnerAsync(request);

            if (!result.IsSuccess)
            {
                MessageBox.Show($"لم يتم العثور على المالك رقم {_ownerId}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            var owner = result.Data;
            var name = owner.FullName.Split(' ');
            txtOwnerID.Text = owner.OwnerId.ToString();
            txtFirstName.Text = name[0];
            txtLastName.Text = name[1];
            txtPhone.Text = owner.PhoneNumber;
            txtAddress.Text = owner.Address;
            dtpDateJoined.Value = owner.CreatedAt;
            lblHeader.Text = $"تعديل بيانات المالك: {owner.FullName}";

            _mainForm?.UpdateStatusBar($"تم تحميل بيانات المالك رقم {_ownerId}");
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
            string details = $"رقم المالك: {_ownerId}\n" +
                           $"الاسم: {txtFirstName.Text} {txtLastName.Text}\n";


            var result = MessageBox.Show(
                $"هل تريد حفظ التعديلات؟\n\n{details}",
                "تأكيد الحفظ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return result == DialogResult.Yes;
        }

        private async Task UpdateOwner()
        {
            var request = new OwnerUpdateRequestDto
            {
                OwnerId = _ownerId,
                FullName = $"{txtFirstName.Text} {txtLastName.Text}",
                PhoneNumber = txtPhone.Text.Trim(),
                Address = txtAddress.Text
            };

            var result = await _ownersService.UpdateOwnerAsync(request);
            if (result == null || !result.IsSuccess)
            {
                throw new Exception(result.Message ?? "فشل في حفظ البيانات");
            }

        }

        private async Task AddOwner()
        {
            var request = new OwnerCreateRequestDto
            {
                FullName = $"{txtFirstName.Text} {txtLastName.Text}",
                PhoneNumber = txtPhone.Text.Trim(),
                Address = txtAddress.Text
            };

            var result = await _ownersService.AddOwnerAsync(request);
            if (result == null || !result.IsSuccess)
            {
                throw new Exception(result.Message ?? "فشل في حفظ البيانات");
            }

        }

        private async Task SaveOwner()
        {

            if (EnMode.Add == Mode)
            {
                await AddOwner();
            }
            else
            {
                await UpdateOwner();
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