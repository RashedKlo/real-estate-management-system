namespace RealEstateManagement
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.topPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.mainPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.leftPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.loginContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.chkRememberMe = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.rightPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSubText = new System.Windows.Forms.Label();
            this.lblWelcomeBack = new System.Windows.Forms.Label();
            this.logoPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.topPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.loginContainer.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.topPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPanel.Controls.Add(this.btnMinimize);
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1000, 40);
            this.topPanel.TabIndex = 2;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(45, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 30);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(5, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 25;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.leftPanel);
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.mainPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.mainPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1000, 600);
            this.mainPanel.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.Transparent;
            this.leftPanel.Controls.Add(this.loginContainer);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(0, 40);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Padding = new System.Windows.Forms.Padding(40, 60, 40, 60);
            this.leftPanel.Size = new System.Drawing.Size(500, 560);
            this.leftPanel.TabIndex = 1;
            // 
            // loginContainer
            // 
            this.loginContainer.BackColor = System.Drawing.Color.Transparent;
            this.loginContainer.BorderRadius = 25;
            this.loginContainer.Controls.Add(this.lblError);
            this.loginContainer.Controls.Add(this.btnLogin);
            this.loginContainer.Controls.Add(this.chkRememberMe);
            this.loginContainer.Controls.Add(this.txtPassword);
            this.loginContainer.Controls.Add(this.txtUsername);
            this.loginContainer.Controls.Add(this.lblSubtitle);
            this.loginContainer.Controls.Add(this.lblLoginTitle);
            this.loginContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginContainer.Location = new System.Drawing.Point(40, 60);
            this.loginContainer.Name = "loginContainer";
            this.loginContainer.Padding = new System.Windows.Forms.Padding(40, 50, 40, 50);
            this.loginContainer.ShadowDecoration.BorderRadius = 25;
            this.loginContainer.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginContainer.ShadowDecoration.Depth = 40;
            this.loginContainer.ShadowDecoration.Enabled = true;
            this.loginContainer.Size = new System.Drawing.Size(420, 440);
            this.loginContainer.TabIndex = 0;
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.lblError.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(40, 285);
            this.lblError.Name = "lblError";
            this.lblError.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.lblError.Size = new System.Drawing.Size(340, 45);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "رسالة الخطأ هنا";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Animated = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(240)))));
            this.btnLogin.Location = new System.Drawing.Point(40, 345);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.BorderRadius = 15;
            this.btnLogin.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnLogin.ShadowDecoration.Depth = 25;
            this.btnLogin.ShadowDecoration.Enabled = true;
            this.btnLogin.Size = new System.Drawing.Size(340, 55);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "تسجيل الدخول";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.BackColor = System.Drawing.Color.Transparent;
            this.chkRememberMe.Checked = true;
            this.chkRememberMe.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkRememberMe.CheckedState.BorderRadius = 3;
            this.chkRememberMe.CheckedState.BorderThickness = 0;
            this.chkRememberMe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkRememberMe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRememberMe.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRememberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.chkRememberMe.Location = new System.Drawing.Point(321, 250);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkRememberMe.Size = new System.Drawing.Size(59, 20);
            this.chkRememberMe.TabIndex = 4;
            this.chkRememberMe.Text = "تذكرني";
            this.chkRememberMe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkRememberMe.UncheckedState.BorderRadius = 3;
            this.chkRememberMe.UncheckedState.BorderThickness = 2;
            this.chkRememberMe.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.chkRememberMe.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Animated = true;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.txtPassword.BorderRadius = 12;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.IconLeft = global::RealEstateManagement.Properties.Resources.show;
            this.txtPassword.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.txtPassword.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtPassword.Location = new System.Drawing.Point(40, 185);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtPassword.PlaceholderText = "أدخل كلمة المرور";
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(340, 55);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Tag = "admin";
            this.txtPassword.TextOffset = new System.Drawing.Point(8, 0);
            this.txtPassword.IconLeftClick += new System.EventHandler(this.txtPassword_IconLeftClick);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Animated = true;
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.txtUsername.BorderRadius = 12;
            this.txtUsername.BorderThickness = 2;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(40, 120);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtUsername.PlaceholderText = "أدخل اسم المستخدم";
            this.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(340, 55);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Tag = "admin";
            this.txtUsername.TextOffset = new System.Drawing.Point(8, 0);
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblSubtitle.Location = new System.Drawing.Point(40, 85);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSubtitle.Size = new System.Drawing.Size(340, 25);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "الرجاء إدخال بيانات الدخول للمتابعة";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.ForeColor = System.Drawing.Color.White;
            this.lblLoginTitle.Location = new System.Drawing.Point(30, 30);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLoginTitle.Size = new System.Drawing.Size(360, 60);
            this.lblLoginTitle.TabIndex = 0;
            this.lblLoginTitle.Text = "مرحباً بعودتك";
            this.lblLoginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.Transparent;
            this.rightPanel.Controls.Add(this.lblSubText);
            this.rightPanel.Controls.Add(this.lblWelcomeBack);
            this.rightPanel.Controls.Add(this.logoPicture);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(500, 40);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(500, 560);
            this.rightPanel.TabIndex = 0;
            // 
            // lblSubText
            // 
            this.lblSubText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblSubText.Location = new System.Drawing.Point(50, 330);
            this.lblSubText.Name = "lblSubText";
            this.lblSubText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSubText.Size = new System.Drawing.Size(400, 80);
            this.lblSubText.TabIndex = 2;
            this.lblSubText.Text = "بسّط إدارة العقارات الخاصة بك\r\nتتبع العملاء وأغلق الصفقات بشكل أسرع\r\nمع منصتنا ال" +
    "شاملة";
            this.lblSubText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWelcomeBack
            // 
            this.lblWelcomeBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWelcomeBack.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeBack.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeBack.Location = new System.Drawing.Point(50, 260);
            this.lblWelcomeBack.Name = "lblWelcomeBack";
            this.lblWelcomeBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWelcomeBack.Size = new System.Drawing.Size(400, 70);
            this.lblWelcomeBack.TabIndex = 1;
            this.lblWelcomeBack.Text = "إدارة العقارات";
            this.lblWelcomeBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoPicture
            // 
            this.logoPicture.BackColor = System.Drawing.Color.Transparent;
            this.logoPicture.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.logoPicture.ImageRotate = 0F;
            this.logoPicture.Location = new System.Drawing.Point(175, 100);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.logoPicture.ShadowDecoration.Enabled = true;
            this.logoPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.logoPicture.Size = new System.Drawing.Size(150, 150);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicture.TabIndex = 0;
            this.logoPicture.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول - إدارة العقارات";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.topPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.loginContainer.ResumeLayout(false);
            this.loginContainer.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel mainPanel;
        private Guna.UI2.WinForms.Guna2Panel leftPanel;
        private Guna.UI2.WinForms.Guna2Panel loginContainer;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2CheckBox chkRememberMe;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Label lblError;
        private Guna.UI2.WinForms.Guna2Panel rightPanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox logoPicture;
        private System.Windows.Forms.Label lblWelcomeBack;
        private System.Windows.Forms.Label lblSubText;
        private Guna.UI2.WinForms.Guna2Panel topPanel;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
    }
}