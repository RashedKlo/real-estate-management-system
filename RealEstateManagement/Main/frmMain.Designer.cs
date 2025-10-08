namespace RealEstateManagement
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.topPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.rightMenuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnReports = new Guna.UI2.WinForms.Guna2Button();
            this.btnTransactionsList = new Guna.UI2.WinForms.Guna2Button();
            this.btnClientsList = new Guna.UI2.WinForms.Guna2Button();
            this.btnOwnersList = new Guna.UI2.WinForms.Guna2Button();
            this.btnPropertiesList = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblAppName = new System.Windows.Forms.Label();
            this.logoPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.mainMdiPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.statusBarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.lblStatusMessage = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.rightMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.statusBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.topPanel.Controls.Add(this.lblFormTitle);
            this.topPanel.Controls.Add(this.btnMinimize);
            this.topPanel.Controls.Add(this.btnMaximize);
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1280, 40);
            this.topPanel.TabIndex = 3;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFormTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(1080, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFormTitle.Size = new System.Drawing.Size(200, 40);
            this.lblFormTitle.TabIndex = 2;
            this.lblFormTitle.Text = "لوحة التحكم";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(80, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 40);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMaximize.FillColor = System.Drawing.Color.Transparent;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(40, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(40, 40);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.topPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // rightMenuPanel
            // 
            this.rightMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.rightMenuPanel.Controls.Add(this.btnLogout);
            this.rightMenuPanel.Controls.Add(this.btnSettings);
            this.rightMenuPanel.Controls.Add(this.btnReports);
            this.rightMenuPanel.Controls.Add(this.btnTransactionsList);
            this.rightMenuPanel.Controls.Add(this.btnClientsList);
            this.rightMenuPanel.Controls.Add(this.btnOwnersList);
            this.rightMenuPanel.Controls.Add(this.btnPropertiesList);
            this.rightMenuPanel.Controls.Add(this.btnDashboard);
            this.rightMenuPanel.Controls.Add(this.guna2Separator1);
            this.rightMenuPanel.Controls.Add(this.lblAppName);
            this.rightMenuPanel.Controls.Add(this.logoPicture);
            this.rightMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.rightMenuPanel.Location = new System.Drawing.Point(0, 40);
            this.rightMenuPanel.Name = "rightMenuPanel";
            this.rightMenuPanel.Size = new System.Drawing.Size(220, 660);
            this.rightMenuPanel.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Animated = true;
            this.btnLogout.BorderRadius = 10;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnLogout.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLogout.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnLogout.Location = new System.Drawing.Point(10, 600);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnLogout.Size = new System.Drawing.Size(200, 45);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Tag = "logout";
            this.btnLogout.Text = "تسجيل الخروج";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLogout.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Animated = true;
            this.btnSettings.BorderRadius = 10;
            this.btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSettings.FillColor = System.Drawing.Color.Transparent;
            this.btnSettings.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSettings.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnSettings.Location = new System.Drawing.Point(10, 460);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnSettings.Size = new System.Drawing.Size(200, 45);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Tag = "settings";
            this.btnSettings.Text = "الإعدادات";
            this.btnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSettings.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnReports
            // 
            this.btnReports.Animated = true;
            this.btnReports.BorderRadius = 10;
            this.btnReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReports.FillColor = System.Drawing.Color.Transparent;
            this.btnReports.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnReports.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnReports.Location = new System.Drawing.Point(10, 410);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnReports.Size = new System.Drawing.Size(200, 45);
            this.btnReports.TabIndex = 8;
            this.btnReports.Tag = "reports";
            this.btnReports.Text = "التقارير";
            this.btnReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnReports.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnTransactionsList
            // 
            this.btnTransactionsList.Animated = true;
            this.btnTransactionsList.BorderRadius = 10;
            this.btnTransactionsList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransactionsList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransactionsList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransactionsList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransactionsList.FillColor = System.Drawing.Color.Transparent;
            this.btnTransactionsList.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionsList.ForeColor = System.Drawing.Color.White;
            this.btnTransactionsList.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnTransactionsList.Image = ((System.Drawing.Image)(resources.GetObject("btnTransactionsList.Image")));
            this.btnTransactionsList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTransactionsList.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnTransactionsList.Location = new System.Drawing.Point(10, 360);
            this.btnTransactionsList.Name = "btnTransactionsList";
            this.btnTransactionsList.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnTransactionsList.Size = new System.Drawing.Size(200, 45);
            this.btnTransactionsList.TabIndex = 7;
            this.btnTransactionsList.Tag = "transactions";
            this.btnTransactionsList.Text = "المعاملات";
            this.btnTransactionsList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTransactionsList.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnTransactionsList.Click += new System.EventHandler(this.btnTransactionsList_Click);
            // 
            // btnClientsList
            // 
            this.btnClientsList.Animated = true;
            this.btnClientsList.BorderRadius = 10;
            this.btnClientsList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClientsList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClientsList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClientsList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClientsList.FillColor = System.Drawing.Color.Transparent;
            this.btnClientsList.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientsList.ForeColor = System.Drawing.Color.White;
            this.btnClientsList.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnClientsList.Image = ((System.Drawing.Image)(resources.GetObject("btnClientsList.Image")));
            this.btnClientsList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnClientsList.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnClientsList.Location = new System.Drawing.Point(10, 310);
            this.btnClientsList.Name = "btnClientsList";
            this.btnClientsList.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnClientsList.Size = new System.Drawing.Size(200, 45);
            this.btnClientsList.TabIndex = 6;
            this.btnClientsList.Tag = "clients";
            this.btnClientsList.Text = "إدارة العملاء";
            this.btnClientsList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnClientsList.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnClientsList.Click += new System.EventHandler(this.btnClientsList_Click);
            // 
            // btnOwnersList
            // 
            this.btnOwnersList.Animated = true;
            this.btnOwnersList.BorderRadius = 10;
            this.btnOwnersList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOwnersList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOwnersList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOwnersList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOwnersList.FillColor = System.Drawing.Color.Transparent;
            this.btnOwnersList.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOwnersList.ForeColor = System.Drawing.Color.White;
            this.btnOwnersList.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnOwnersList.Image = ((System.Drawing.Image)(resources.GetObject("btnOwnersList.Image")));
            this.btnOwnersList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnOwnersList.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnOwnersList.Location = new System.Drawing.Point(10, 260);
            this.btnOwnersList.Name = "btnOwnersList";
            this.btnOwnersList.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnOwnersList.Size = new System.Drawing.Size(200, 45);
            this.btnOwnersList.TabIndex = 5;
            this.btnOwnersList.Tag = "owners";
            this.btnOwnersList.Text = "إدارة الملاك";
            this.btnOwnersList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnOwnersList.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnOwnersList.Click += new System.EventHandler(this.btnOwnersList_Click);
            // 
            // btnPropertiesList
            // 
            this.btnPropertiesList.Animated = true;
            this.btnPropertiesList.BorderRadius = 10;
            this.btnPropertiesList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPropertiesList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPropertiesList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPropertiesList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPropertiesList.FillColor = System.Drawing.Color.Transparent;
            this.btnPropertiesList.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropertiesList.ForeColor = System.Drawing.Color.White;
            this.btnPropertiesList.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnPropertiesList.Image = ((System.Drawing.Image)(resources.GetObject("btnPropertiesList.Image")));
            this.btnPropertiesList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPropertiesList.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnPropertiesList.Location = new System.Drawing.Point(10, 210);
            this.btnPropertiesList.Name = "btnPropertiesList";
            this.btnPropertiesList.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnPropertiesList.Size = new System.Drawing.Size(200, 45);
            this.btnPropertiesList.TabIndex = 4;
            this.btnPropertiesList.Tag = "properties";
            this.btnPropertiesList.Text = "إدارة العقارات";
            this.btnPropertiesList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPropertiesList.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnPropertiesList.Click += new System.EventHandler(this.btnPropertiesList_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Animated = true;
            this.btnDashboard.BorderRadius = 10;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(240)))));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDashboard.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnDashboard.Location = new System.Drawing.Point(10, 160);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnDashboard.Size = new System.Drawing.Size(200, 45);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Tag = "dashboard";
            this.btnDashboard.Text = "لوحة التحكم";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDashboard.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.guna2Separator1.Location = new System.Drawing.Point(10, 140);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // lblAppName
            // 
            this.lblAppName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppName.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(10, 55);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAppName.Size = new System.Drawing.Size(135, 60);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "نظام إدارة العقارات";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logoPicture
            // 
            this.logoPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoPicture.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.logoPicture.ImageRotate = 0F;
            this.logoPicture.Location = new System.Drawing.Point(150, 60);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.logoPicture.Size = new System.Drawing.Size(60, 60);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicture.TabIndex = 0;
            this.logoPicture.TabStop = false;
            // 
            // mainMdiPanel
            // 
            this.mainMdiPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.mainMdiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMdiPanel.Location = new System.Drawing.Point(220, 40);
            this.mainMdiPanel.Name = "mainMdiPanel";
            this.mainMdiPanel.Padding = new System.Windows.Forms.Padding(10);
            this.mainMdiPanel.Size = new System.Drawing.Size(1060, 630);
            this.mainMdiPanel.TabIndex = 5;
            this.mainMdiPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainMdiPanel_Paint);
            // 
            // statusBarPanel
            // 
            this.statusBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.statusBarPanel.Controls.Add(this.lblLoggedInUser);
            this.statusBarPanel.Controls.Add(this.lblStatusMessage);
            this.statusBarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarPanel.Location = new System.Drawing.Point(220, 670);
            this.statusBarPanel.Name = "statusBarPanel";
            this.statusBarPanel.Size = new System.Drawing.Size(1060, 30);
            this.statusBarPanel.TabIndex = 6;
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLoggedInUser.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblLoggedInUser.Location = new System.Drawing.Point(0, 0);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblLoggedInUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLoggedInUser.Size = new System.Drawing.Size(250, 30);
            this.lblLoggedInUser.TabIndex = 1;
            this.lblLoggedInUser.Text = "المستخدم: مدير النظام";
            this.lblLoggedInUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblStatusMessage.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblStatusMessage.Location = new System.Drawing.Point(560, 0);
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblStatusMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStatusMessage.Size = new System.Drawing.Size(500, 30);
            this.lblStatusMessage.TabIndex = 0;
            this.lblStatusMessage.Text = "الحالة: جاهز";
            this.lblStatusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1280, 700);
            this.Controls.Add(this.mainMdiPanel);
            this.Controls.Add(this.statusBarPanel);
            this.Controls.Add(this.rightMenuPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام إدارة العقارات - لوحة التحكم";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.topPanel.ResumeLayout(false);
            this.rightMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.statusBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel topPanel;
        private System.Windows.Forms.Label lblFormTitle;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox btnMaximize;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel rightMenuPanel;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnReports;
        private Guna.UI2.WinForms.Guna2Button btnTransactionsList;
        private Guna.UI2.WinForms.Guna2Button btnClientsList;
        private Guna.UI2.WinForms.Guna2Button btnOwnersList;
        private Guna.UI2.WinForms.Guna2Button btnPropertiesList;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lblAppName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox logoPicture;
        private Guna.UI2.WinForms.Guna2Panel statusBarPanel;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.Label lblStatusMessage;
        public Guna.UI2.WinForms.Guna2Panel mainMdiPanel;
    }
}