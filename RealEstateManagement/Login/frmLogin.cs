using System;
using System.Windows.Forms;
using RealEstateManagement.Global;

namespace RealEstateManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            logoPicture.Focus();

            LoadSavedCredentials();
        }
      
        private void LoadSavedCredentials()
        {
            try
            {
                CredentialUser savedUser = CredentialManager.Load();

                if (savedUser.IsRememberMe)
                {
                    txtUsername.Text = savedUser.userName;
                    txtPassword.Text = savedUser.password;
                    chkRememberMe.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading credentials: {ex.Message}");
            }
        }

        private bool CheckInputs()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                ShowError("الرجاء إدخال اسم المستخدم");
                txtUsername.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowError("الرجاء إدخال كلمة المرور");
                txtPassword.Focus();
                return false;
            }

            return true;
        }

        private void Reset()
        {
            btnLogin.Text = "تسجيل الدخول";
            btnLogin.Enabled = true;

        }
        private bool CheckAuthenticateUser()
        {
            var user = CredentialManager.Load();
            return txtPassword.Text == user.password
                  && txtUsername.Text == user.userName;
        }
        private bool Login()
        {
            btnLogin.Text = "جاري تسجيل الدخول...";
            btnLogin.Enabled = false;
            bool isAuthenticated = CheckAuthenticateUser();

            if (isAuthenticated)
            {
                GlobalUser.CurrentUser = new CredentialUser(txtUsername.Text, txtPassword.Text,chkRememberMe.Checked);
                CredentialManager.Save(GlobalUser.CurrentUser);
                return true;
            }
            return false;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!CheckInputs())
                return;

            bool loginSuccess = Login();
            if (loginSuccess)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ShowError("اسم المستخدم أو كلمة المرور غير صحيحة");
                Reset();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Application.Exit();

        private void btnMinimize_Click(object sender, EventArgs e) =>
            this.WindowState = FormWindowState.Minimized;

        private void txtUsername_TextChanged(object sender, EventArgs e) => HideError();

        private void txtPassword_TextChanged(object sender, EventArgs e) => HideError();

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              
                txtPassword.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassword_IconLeftClick(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '●')
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.IconLeft = Properties.Resources.hide;
            }
            else
            {
                txtPassword.PasswordChar = '●';
                txtPassword.IconLeft = Properties.Resources.show;
            }
        }

        private void ShowError(string message)
        {
            lblError.Visible = true;
            lblError.Text = message;
        }

        private void HideError()
        {
            if (lblError.Visible)
                lblError.Visible = false;
        }

    }
}