using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Guna.UI2.WinForms;

namespace RealEstateManagement
{
    public partial class frmMain : Form
    {


        private Guna2Button currentActiveButton;
        public frmMain()
        {
            InitializeComponent();
        }

    
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Set dashboard as active by default
            SetActiveButton(btnDashboard);

            // Update status
            UpdateStatusBar("الحالة: جاهز", "المستخدم: مدير النظام");


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد إغلاق البرنامج؟", "تأكيد الإغلاق",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == DialogResult.Yes)
            {
                Application.Exit();
            }
         
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }



        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnDashboard);
            lblFormTitle.Text = "لوحة التحكم";
            UpdateStatusBar("عرض لوحة التحكم");

            // Clear existing content
            mainMdiPanel.Controls.Clear();

            // Use GetRequiredService to throw an exception if resolution fails
            var frm = Program.ServiceProvider.GetRequiredService<frmDashboard>();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            mainMdiPanel.Controls.Add(frm);
            frm.Show();
        }

        private void btnPropertiesList_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnPropertiesList);
            lblFormTitle.Text = "إدارة العقارات";
            UpdateStatusBar("عرض قائمة العقارات");
            // Clear existing content
            mainMdiPanel.Controls.Clear();

            // Use GetRequiredService to throw an exception if resolution fails
            var frm = Program.ServiceProvider.GetRequiredService<frmPropertiesList>();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.SetMainForm(this);
            mainMdiPanel.Controls.Add(frm);
            frm.Show();
        }

        private void btnOwnersList_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnOwnersList);
            lblFormTitle.Text = "إدارة الملاك";
            UpdateStatusBar("عرض قائمة الملاك");

            // Clear existing content
            mainMdiPanel.Controls.Clear();

            // Use GetRequiredService to throw an exception if resolution fails
            var frmOwners = Program.ServiceProvider.GetRequiredService<frmOwners>();
            frmOwners.TopLevel = false;
            frmOwners.FormBorderStyle = FormBorderStyle.None;
            frmOwners.Dock = DockStyle.Fill;
            frmOwners.SetMainForm(this);
            mainMdiPanel.Controls.Add(frmOwners);
            frmOwners.Show();
        }

        private void btnClientsList_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnClientsList);
            lblFormTitle.Text = "إدارة العملاء";
            UpdateStatusBar("عرض قائمة العملاء");
            mainMdiPanel.Controls.Clear();

            // Use GetRequiredService to throw an exception if resolution fails
            var frmClients = Program.ServiceProvider.GetRequiredService<frmClients>();
            frmClients.TopLevel = false;
            frmClients.FormBorderStyle = FormBorderStyle.None;
            frmClients.Dock = DockStyle.Fill;
            mainMdiPanel.Controls.Add(frmClients);
            frmClients.Show();
        }
        private void btnTransactionsList_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnTransactionsList);
            lblFormTitle.Text = "المعاملات";
            UpdateStatusBar("عرض المعاملات");
            // TODO: Load transactions list
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnReports);
            lblFormTitle.Text = "التقارير";
            UpdateStatusBar("عرض التقارير", null);
            // TODO: Load reports
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnSettings);
            lblFormTitle.Text = "الإعدادات";
            UpdateStatusBar("عرض الإعدادات");

            // Clear existing content
            mainMdiPanel.Controls.Clear();

            // Create and add settings form
            frmSettings settingsForm = new frmSettings
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            mainMdiPanel.Controls.Add(settingsForm);
            settingsForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تسجيل الخروج؟", "تأكيد تسجيل الخروج",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin loginForm = new frmLogin
                {
                    StartPosition = FormStartPosition.CenterScreen
                };

                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Re-login successful, show main form again
                    this.Show();
                    UpdateStatusBar("تم تسجيل الدخول مرة أخرى", "المستخدم: مدير النظام");
                }
                else
                {
                    // User cancelled login, close application
                    Application.Exit();
                }
            }
        }


        private void SetActiveButton(Guna2Button button)
        {
            // Reset previous active button
            if (currentActiveButton != null)
            {
                currentActiveButton.FillColor = Color.FromArgb(30, 33, 45);
                currentActiveButton.ShadowDecoration.Enabled = false;
                currentActiveButton.ForeColor = Color.White;

            }

            // Set new active button
            currentActiveButton = button;
            button.FillColor = Color.FromArgb(94, 148, 255);
            button.ForeColor = Color.White;

            // Add subtle animation effect
            button.ShadowDecoration.Enabled = true;
            button.ShadowDecoration.Color = Color.FromArgb(94, 148, 255);
            button.ShadowDecoration.Depth = 15;
        }


        public   void UpdateStatusBar(string statusMessage, string userInfo = "")
        {
            if (!string.IsNullOrEmpty(statusMessage))
            {
                lblStatusMessage.Text = $"الحالة: {statusMessage}";
            }

            if (!string.IsNullOrEmpty(userInfo))
            {
                lblLoggedInUser.Text = userInfo;
            }
        }

        private void mainMdiPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}