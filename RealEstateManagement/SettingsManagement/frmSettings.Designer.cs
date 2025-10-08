// ============================================
// frmSettings.Designer.cs - Embedded Version
// ============================================
namespace RealEstateManagement
{
    partial class frmSettings
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.mainContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.contentPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlPasswordSection = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPasswordSectionTitle = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlUsernameSection = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUsernameSectionTitle = new System.Windows.Forms.Label();
            this.lblCurrentUsername = new System.Windows.Forms.Label();
            this.txtCurrentUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNewUsername = new System.Windows.Forms.Label();
            this.txtNewUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlActions = new Guna.UI2.WinForms.Guna2Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.mainContainer.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.pnlPasswordSection.SuspendLayout();
            this.pnlUsernameSection.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.mainContainer.Controls.Add(this.contentPanel);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Padding = new System.Windows.Forms.Padding(20);
            this.mainContainer.Size = new System.Drawing.Size(1060, 630);
            this.mainContainer.TabIndex = 0;
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contentPanel.BackColor = System.Drawing.Color.Transparent;
            this.contentPanel.Controls.Add(this.pnlPasswordSection);
            this.contentPanel.Controls.Add(this.pnlUsernameSection);
            this.contentPanel.Controls.Add(this.pnlActions);
            this.contentPanel.Location = new System.Drawing.Point(80, 40);
            this.contentPanel.MaximumSize = new System.Drawing.Size(900, 600);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(900, 550);
            this.contentPanel.TabIndex = 0;
            // 
            // pnlPasswordSection
            // 
            this.pnlPasswordSection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPasswordSection.BackColor = System.Drawing.Color.Transparent;
            this.pnlPasswordSection.BorderRadius = 10;
            this.pnlPasswordSection.Controls.Add(this.lblPasswordSectionTitle);
            this.pnlPasswordSection.Controls.Add(this.lblCurrentPassword);
            this.pnlPasswordSection.Controls.Add(this.txtCurrentPassword);
            this.pnlPasswordSection.Controls.Add(this.lblNewPassword);
            this.pnlPasswordSection.Controls.Add(this.txtNewPassword);
            this.pnlPasswordSection.Controls.Add(this.lblConfirmPassword);
            this.pnlPasswordSection.Controls.Add(this.txtConfirmPassword);
            this.pnlPasswordSection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.pnlPasswordSection.Location = new System.Drawing.Point(0, 210);
            this.pnlPasswordSection.Name = "pnlPasswordSection";
            this.pnlPasswordSection.ShadowDecoration.BorderRadius = 10;
            this.pnlPasswordSection.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlPasswordSection.ShadowDecoration.Depth = 20;
            this.pnlPasswordSection.ShadowDecoration.Enabled = true;
            this.pnlPasswordSection.Size = new System.Drawing.Size(900, 240);
            this.pnlPasswordSection.TabIndex = 2;
            // 
            // lblPasswordSectionTitle
            // 
            this.lblPasswordSectionTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPasswordSectionTitle.AutoSize = true;
            this.lblPasswordSectionTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordSectionTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPasswordSectionTitle.ForeColor = System.Drawing.Color.White;
            this.lblPasswordSectionTitle.Location = new System.Drawing.Point(757, 20);
            this.lblPasswordSectionTitle.Name = "lblPasswordSectionTitle";
            this.lblPasswordSectionTitle.Size = new System.Drawing.Size(130, 25);
            this.lblPasswordSectionTitle.TabIndex = 0;
            this.lblPasswordSectionTitle.Text = "تغيير كلمة المرور";
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblCurrentPassword.Location = new System.Drawing.Point(764, 65);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(123, 19);
            this.lblCurrentPassword.TabIndex = 1;
            this.lblCurrentPassword.Text = "كلمة المرور الحالية";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.txtCurrentPassword.BorderRadius = 8;
            this.txtCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentPassword.DefaultText = "";
            this.txtCurrentPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCurrentPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCurrentPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.txtCurrentPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCurrentPassword.ForeColor = System.Drawing.Color.White;
            this.txtCurrentPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentPassword.Location = new System.Drawing.Point(490, 90);
            this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '●';
            this.txtCurrentPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtCurrentPassword.PlaceholderText = "أدخل كلمة المرور الحالية";
            this.txtCurrentPassword.SelectedText = "";
            this.txtCurrentPassword.Size = new System.Drawing.Size(380, 45);
            this.txtCurrentPassword.TabIndex = 2;
            this.txtCurrentPassword.TextChanged += new System.EventHandler(this.txtCurrentPassword_TextChanged);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblNewPassword.Location = new System.Drawing.Point(347, 65);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(123, 19);
            this.lblNewPassword.TabIndex = 3;
            this.lblNewPassword.Text = "كلمة المرور الجديدة";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.txtNewPassword.BorderRadius = 8;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.DefaultText = "";
            this.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNewPassword.ForeColor = System.Drawing.Color.White;
            this.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.Location = new System.Drawing.Point(30, 90);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtNewPassword.PlaceholderText = "أدخل كلمة المرور الجديدة";
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.Size = new System.Drawing.Size(380, 45);
            this.txtNewPassword.TabIndex = 4;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblConfirmPassword.Location = new System.Drawing.Point(733, 150);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(154, 19);
            this.lblConfirmPassword.TabIndex = 5;
            this.lblConfirmPassword.Text = "تأكيد كلمة المرور الجديدة";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.txtConfirmPassword.BorderRadius = 8;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(260, 175);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtConfirmPassword.PlaceholderText = "أعد إدخال كلمة المرور الجديدة";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(610, 45);
            this.txtConfirmPassword.TabIndex = 6;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // pnlUsernameSection
            // 
            this.pnlUsernameSection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUsernameSection.BackColor = System.Drawing.Color.Transparent;
            this.pnlUsernameSection.BorderRadius = 10;
            this.pnlUsernameSection.Controls.Add(this.lblUsernameSectionTitle);
            this.pnlUsernameSection.Controls.Add(this.lblCurrentUsername);
            this.pnlUsernameSection.Controls.Add(this.txtCurrentUsername);
            this.pnlUsernameSection.Controls.Add(this.lblNewUsername);
            this.pnlUsernameSection.Controls.Add(this.txtNewUsername);
            this.pnlUsernameSection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.pnlUsernameSection.Location = new System.Drawing.Point(0, 0);
            this.pnlUsernameSection.Name = "pnlUsernameSection";
            this.pnlUsernameSection.ShadowDecoration.BorderRadius = 10;
            this.pnlUsernameSection.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlUsernameSection.ShadowDecoration.Depth = 20;
            this.pnlUsernameSection.ShadowDecoration.Enabled = true;
            this.pnlUsernameSection.Size = new System.Drawing.Size(900, 180);
            this.pnlUsernameSection.TabIndex = 1;
            // 
            // lblUsernameSectionTitle
            // 
            this.lblUsernameSectionTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsernameSectionTitle.AutoSize = true;
            this.lblUsernameSectionTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblUsernameSectionTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblUsernameSectionTitle.ForeColor = System.Drawing.Color.White;
            this.lblUsernameSectionTitle.Location = new System.Drawing.Point(725, 20);
            this.lblUsernameSectionTitle.Name = "lblUsernameSectionTitle";
            this.lblUsernameSectionTitle.Size = new System.Drawing.Size(162, 25);
            this.lblUsernameSectionTitle.TabIndex = 0;
            this.lblUsernameSectionTitle.Text = "تغيير اسم المستخدم";
            // 
            // lblCurrentUsername
            // 
            this.lblCurrentUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentUsername.AutoSize = true;
            this.lblCurrentUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCurrentUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblCurrentUsername.Location = new System.Drawing.Point(755, 65);
            this.lblCurrentUsername.Name = "lblCurrentUsername";
            this.lblCurrentUsername.Size = new System.Drawing.Size(132, 19);
            this.lblCurrentUsername.TabIndex = 1;
            this.lblCurrentUsername.Text = "اسم المستخدم الحالي";
            // 
            // txtCurrentUsername
            // 
            this.txtCurrentUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.txtCurrentUsername.BorderRadius = 8;
            this.txtCurrentUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentUsername.DefaultText = "";
            this.txtCurrentUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCurrentUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCurrentUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.txtCurrentUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCurrentUsername.ForeColor = System.Drawing.Color.White;
            this.txtCurrentUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentUsername.Location = new System.Drawing.Point(490, 90);
            this.txtCurrentUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCurrentUsername.Name = "txtCurrentUsername";
            this.txtCurrentUsername.PasswordChar = '\0';
            this.txtCurrentUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtCurrentUsername.PlaceholderText = "أدخل اسم المستخدم الحالي";
            this.txtCurrentUsername.SelectedText = "";
            this.txtCurrentUsername.Size = new System.Drawing.Size(380, 45);
            this.txtCurrentUsername.TabIndex = 2;
            this.txtCurrentUsername.TextChanged += new System.EventHandler(this.txtCurrentUsername_TextChanged);
            // 
            // lblNewUsername
            // 
            this.lblNewUsername.AutoSize = true;
            this.lblNewUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblNewUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNewUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblNewUsername.Location = new System.Drawing.Point(335, 65);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.Size = new System.Drawing.Size(135, 19);
            this.lblNewUsername.TabIndex = 3;
            this.lblNewUsername.Text = "اسم المستخدم الجديد";
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.txtNewUsername.BorderRadius = 8;
            this.txtNewUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewUsername.DefaultText = "";
            this.txtNewUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.txtNewUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNewUsername.ForeColor = System.Drawing.Color.White;
            this.txtNewUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewUsername.Location = new System.Drawing.Point(30, 90);
            this.txtNewUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.PasswordChar = '\0';
            this.txtNewUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtNewUsername.PlaceholderText = "أدخل اسم المستخدم الجديد";
            this.txtNewUsername.SelectedText = "";
            this.txtNewUsername.Size = new System.Drawing.Size(380, 45);
            this.txtNewUsername.TabIndex = 4;
            this.txtNewUsername.TextChanged += new System.EventHandler(this.txtNewUsername_TextChanged);
            // 
            // pnlActions
            // 
            this.pnlActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActions.BackColor = System.Drawing.Color.Transparent;
            this.pnlActions.Controls.Add(this.lblError);
            this.pnlActions.Controls.Add(this.btnSave);
            this.pnlActions.Controls.Add(this.btnCancel);
            this.pnlActions.Location = new System.Drawing.Point(0, 470);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(900, 80);
            this.pnlActions.TabIndex = 3;
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.lblError.Location = new System.Drawing.Point(0, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(900, 25);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Animated = true;
            this.btnSave.BorderRadius = 10;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.btnSave.Location = new System.Drawing.Point(470, 35);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.BorderRadius = 10;
            this.btnSave.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSave.ShadowDecoration.Depth = 20;
            this.btnSave.ShadowDecoration.Enabled = true;
            this.btnSave.Size = new System.Drawing.Size(200, 45);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "حفظ التغييرات";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Animated = true;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderThickness = 2;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCancel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnCancel.Location = new System.Drawing.Point(230, 35);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 45);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1060, 630);
            this.Controls.Add(this.mainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الإعدادات";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.Resize += new System.EventHandler(this.frmSettings_Resize);
            this.mainContainer.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.pnlPasswordSection.ResumeLayout(false);
            this.pnlPasswordSection.PerformLayout();
            this.pnlUsernameSection.ResumeLayout(false);
            this.pnlUsernameSection.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainContainer;
        private Guna.UI2.WinForms.Guna2Panel contentPanel;
        private Guna.UI2.WinForms.Guna2Panel pnlPasswordSection;
        private System.Windows.Forms.Label lblPasswordSectionTitle;
        private System.Windows.Forms.Label lblCurrentPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtCurrentPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2Panel pnlUsernameSection;
        private System.Windows.Forms.Label lblUsernameSectionTitle;
        private System.Windows.Forms.Label lblCurrentUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtCurrentUsername;
        private System.Windows.Forms.Label lblNewUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtNewUsername;
        private Guna.UI2.WinForms.Guna2Panel pnlActions;
        private System.Windows.Forms.Label lblError;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}


