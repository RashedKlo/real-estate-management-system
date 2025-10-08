using System;
using System.Drawing;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using RealEstateManagement.Global;

namespace RealEstateManagement
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }
        private void LoadCurrentUser()
        {
            txtCurrentUsername.Text = GlobalUser.CurrentUser.userName;
            txtCurrentPassword.Text = GlobalUser.CurrentUser.password;

        }
        private void frmSettings_Load(object sender, EventArgs e)
        {
            LoadCurrentUser();
            HideError();
        }

 
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSettings_Resize(object sender, EventArgs e)
        {
            CenterContentPanel();
        }

        private void CenterContentPanel()
        {
            if (mainContainer != null && contentPanel != null)
            {
                int x = (mainContainer.Width - contentPanel.Width) / 2;
                int y = (mainContainer.Height - contentPanel.Height) / 2;

                if (x < 20) x = 20;
                if (y < 20) y = 20;

                contentPanel.Location = new Point(x, y);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;
            try
            {
                // Validate current credentials first
                if (!ValidateCurrentCredentials())
                {
                    ShowError("بيانات الاعتماد الحالية غير صحيحة");
                    return;
                }
                string newUsername = !string.IsNullOrEmpty(txtNewUsername.Text) ? txtNewUsername.Text.Trim() : GlobalUser.CurrentUser.userName;
                string newPassword = !string.IsNullOrEmpty(txtNewPassword.Text) ? txtNewPassword.Text : GlobalUser.CurrentUser.password;
                GlobalUser.CurrentUser = new CredentialUser(newUsername, newPassword, GlobalUser.CurrentUser.IsRememberMe);
                CredentialManager.Save(GlobalUser.CurrentUser);

                MessageBox.Show("تم حفظ التغييرات بنجاح", "نجح",
                    MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

                ClearFields();
            }
            catch (Exception ex)
            {
                ShowError($"حدث خطأ أثناء حفظ التغييرات: {ex.Message}");
            }
            this.Close();

        }

        private bool ValidateInputs()
        {

            if (!string.IsNullOrWhiteSpace(txtNewUsername.Text))
            {

                if (string.IsNullOrWhiteSpace(txtCurrentUsername.Text))
                {
                    ShowError("الرجاء إدخال اسم المستخدم الحالي");
                    txtCurrentUsername.Focus();
                    return false;
                }

                if (txtNewUsername.Text.Trim().Length < 3)
                {
                    ShowError("اسم المستخدم الجديد يجب أن يكون 3 أحرف على الأقل");
                    txtNewUsername.Focus();
                    return false;
                }

                if (txtNewUsername.Text.Trim() == txtCurrentUsername.Text.Trim())
                {
                    ShowError("اسم المستخدم الجديد يجب أن يكون مختلفاً عن الحالي");
                    txtNewUsername.Focus();
                    return false;
                }
            }

            // Validate password change
            if (!string.IsNullOrWhiteSpace(txtNewPassword.Text) ||
                !string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
                {
                    ShowError("الرجاء إدخال كلمة المرور الحالية");
                    txtCurrentPassword.Focus();
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
                {
                    ShowError("الرجاء إدخال كلمة المرور الجديدة");
                    txtNewPassword.Focus();
                    return false;
                }

                if (txtNewPassword.Text.Length < 6)
                {
                    ShowError("كلمة المرور الجديدة يجب أن تكون 6 أحرف على الأقل");
                    txtNewPassword.Focus();
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
                {
                    ShowError("الرجاء تأكيد كلمة المرور الجديدة");
                    txtConfirmPassword.Focus();
                    return false;
                }

                if (txtNewPassword.Text != txtConfirmPassword.Text)
                {
                    ShowError("كلمة المرور الجديدة وتأكيدها غير متطابقين");
                    txtConfirmPassword.Focus();
                    return false;
                }

                if (txtNewPassword.Text == txtCurrentPassword.Text)
                {
                    ShowError("كلمة المرور الجديدة يجب أن تكون مختلفة عن الحالية");
                    txtNewPassword.Focus();
                    return false;
                }
            }

            return true;
        }

        private bool ValidateCurrentCredentials()
        {
            if (!string.IsNullOrWhiteSpace(txtNewUsername.Text))
            {
                if (txtCurrentUsername.Text.Trim() != GlobalUser.CurrentUser.userName)
                {
                    return false;
                }
            }

            if (!string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                if (txtCurrentPassword.Text != GlobalUser.CurrentUser.password)
                {
                    return false;
                }
            }
            return true;
        }

        private void ClearFields()
        {
            txtNewUsername.Clear();
            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
            HideError();
        }

        private void ShowError(string message)
        {
            lblError.Text = message;
            lblError.Visible = true;
        }

        private void HideError()
        {
            lblError.Visible = false;
            lblError.Text = string.Empty;
        }

        // TextChanged events to hide error when user starts typing
        private void txtCurrentUsername_TextChanged(object sender, EventArgs e)
        {
            HideError();
        }

        private void txtNewUsername_TextChanged(object sender, EventArgs e)
        {
            HideError();
        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            HideError();
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            HideError();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            HideError();
        }
    }
}