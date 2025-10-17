namespace RealEstateManagement
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));

            this.pnlHeader = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.pnlMainContent = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlRecentActivities = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvRecentActivities = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblRecentActivitiesTitle = new System.Windows.Forms.Label();
            this.tblCharts = new System.Windows.Forms.TableLayoutPanel();
            this.pnlChart2 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaChart2 = new Guna.Charts.WinForms.GunaChart();
            this.lblChart2Title = new System.Windows.Forms.Label();
            this.pnlChart1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaChart1 = new Guna.Charts.WinForms.GunaChart();
            this.lblChart1Title = new System.Windows.Forms.Label();
            this.flowSummaryCards = new System.Windows.Forms.FlowLayoutPanel();
            this.cardTotalClients = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblClientsChange = new System.Windows.Forms.Label();
            this.lblClientsValue = new System.Windows.Forms.Label();
            this.lblClientsTitle = new System.Windows.Forms.Label();
            this.picClients = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.cardTotalOwners = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblOwnersChange = new System.Windows.Forms.Label();
            this.lblOwnersValue = new System.Windows.Forms.Label();
            this.lblOwnersTitle = new System.Windows.Forms.Label();
            this.picOwners = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.cardTotalProperties = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblPropertiesChange = new System.Windows.Forms.Label();
            this.lblPropertiesValue = new System.Windows.Forms.Label();
            this.lblPropertiesTitle = new System.Windows.Forms.Label();
            this.picProperties = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.cardTotalRevenue = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblRevenueChange = new System.Windows.Forms.Label();
            this.lblRevenueValue = new System.Windows.Forms.Label();
            this.lblRevenueTitle = new System.Windows.Forms.Label();
            this.picRevenue = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnlFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);

            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.pnlMainContent.SuspendLayout();
            this.pnlRecentActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentActivities)).BeginInit();
            this.tblCharts.SuspendLayout();
            this.pnlChart2.SuspendLayout();
            this.pnlChart1.SuspendLayout();
            this.flowSummaryCards.SuspendLayout();
            this.cardTotalClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClients)).BeginInit();
            this.cardTotalOwners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOwners)).BeginInit();
            this.cardTotalProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProperties)).BeginInit();
            this.cardTotalRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRevenue)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.guna2CirclePictureBox1);
            this.pnlHeader.Controls.Add(this.guna2ImageButton1);
            this.pnlHeader.Controls.Add(this.txtSearch);
            this.pnlHeader.Controls.Add(this.lblAppTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowColor = System.Drawing.Color.Black;
            this.pnlHeader.ShadowDepth = 80;
            this.pnlHeader.ShadowShift = 2;
            this.pnlHeader.Size = new System.Drawing.Size(1280, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(20, 15);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(40, 40);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 3;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(75, 15);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Size = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Animated = true;
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Tajawal", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(135, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearch.PlaceholderText = "بحث عن عملاء / عقارات / ملاك";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(300, 40);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Tajawal", 16F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(1095, 20);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(165, 32);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "إدارة العقارات";
            this.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.AutoScroll = true;
            this.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.pnlMainContent.Controls.Add(this.pnlRecentActivities);
            this.pnlMainContent.Controls.Add(this.tblCharts);
            this.pnlMainContent.Controls.Add(this.flowSummaryCards);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 70);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMainContent.Size = new System.Drawing.Size(1280, 650);
            this.pnlMainContent.TabIndex = 1;
            this.pnlMainContent.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnlMainContent_Scroll);
            // 
            // pnlRecentActivities
            // 
            this.pnlRecentActivities.BorderRadius = 15;
            this.pnlRecentActivities.Controls.Add(this.dgvRecentActivities);
            this.pnlRecentActivities.Controls.Add(this.lblRecentActivitiesTitle);
            this.pnlRecentActivities.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRecentActivities.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.pnlRecentActivities.Location = new System.Drawing.Point(20, 508);
            this.pnlRecentActivities.Name = "pnlRecentActivities";
            this.pnlRecentActivities.Padding = new System.Windows.Forms.Padding(20);
            this.pnlRecentActivities.ShadowDecoration.BorderRadius = 15;
            this.pnlRecentActivities.ShadowDecoration.Enabled = true;
            this.pnlRecentActivities.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.pnlRecentActivities.Size = new System.Drawing.Size(1217, 280);
            this.pnlRecentActivities.TabIndex = 2;
            // 
            // dgvRecentActivities
            // 
            this.dgvRecentActivities.AllowUserToAddRows = false;
            this.dgvRecentActivities.AllowUserToDeleteRows = false;
            this.dgvRecentActivities.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.dgvRecentActivities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentActivities.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecentActivities.ColumnHeadersHeight = 45;
            this.dgvRecentActivities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecentActivities.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.dgvRecentActivities.Location = new System.Drawing.Point(20, 52);
            this.dgvRecentActivities.Name = "dgvRecentActivities";
            this.dgvRecentActivities.ReadOnly = true;
            this.dgvRecentActivities.RowHeadersVisible = false;
            this.dgvRecentActivities.RowTemplate.Height = 40;
            this.dgvRecentActivities.Size = new System.Drawing.Size(1177, 208);
            this.dgvRecentActivities.TabIndex = 1;
            // 
            // lblRecentActivitiesTitle
            // 
            this.lblRecentActivitiesTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecentActivitiesTitle.Font = new System.Drawing.Font("Tajawal", 14F, System.Drawing.FontStyle.Bold);
            this.lblRecentActivitiesTitle.ForeColor = System.Drawing.Color.White;
            this.lblRecentActivitiesTitle.Location = new System.Drawing.Point(20, 20);
            this.lblRecentActivitiesTitle.Name = "lblRecentActivitiesTitle";
            this.lblRecentActivitiesTitle.Size = new System.Drawing.Size(1177, 32);
            this.lblRecentActivitiesTitle.TabIndex = 0;
            this.lblRecentActivitiesTitle.Text = "الأنشطة الأخيرة";
            this.lblRecentActivitiesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tblCharts
            // 
            this.tblCharts.ColumnCount = 2;
            this.tblCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCharts.Controls.Add(this.pnlChart2, 0, 0);
            this.tblCharts.Controls.Add(this.pnlChart1, 1, 0);
            this.tblCharts.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblCharts.Location = new System.Drawing.Point(20, 168);
            this.tblCharts.Name = "tblCharts";
            this.tblCharts.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.tblCharts.RowCount = 1;
            this.tblCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCharts.Size = new System.Drawing.Size(1217, 340);
            this.tblCharts.TabIndex = 1;
            // 
            // pnlChart2
            // 
            this.pnlChart2.BorderRadius = 15;
            this.pnlChart2.Controls.Add(this.gunaChart2);
            this.pnlChart2.Controls.Add(this.lblChart2Title);
            this.pnlChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChart2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.pnlChart2.Location = new System.Drawing.Point(3, 3);
            this.pnlChart2.Name = "pnlChart2";
            this.pnlChart2.Padding = new System.Windows.Forms.Padding(20);
            this.pnlChart2.ShadowDecoration.BorderRadius = 15;
            this.pnlChart2.ShadowDecoration.Enabled = true;
            this.pnlChart2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.pnlChart2.Size = new System.Drawing.Size(602, 314);
            this.pnlChart2.TabIndex = 1;
            // 
            // gunaChart2
            // 
            this.gunaChart2.AutoSize = true;
            this.gunaChart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.gunaChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaChart2.ForeColor = System.Drawing.Color.White;
            this.gunaChart2.Location = new System.Drawing.Point(20, 52);
            this.gunaChart2.Name = "gunaChart2";
            this.gunaChart2.Size = new System.Drawing.Size(562, 242);
            this.gunaChart2.TabIndex = 1;
            // 
            // lblChart2Title
            // 
            this.lblChart2Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChart2Title.Font = new System.Drawing.Font("Tajawal", 14F, System.Drawing.FontStyle.Bold);
            this.lblChart2Title.ForeColor = System.Drawing.Color.White;
            this.lblChart2Title.Location = new System.Drawing.Point(20, 20);
            this.lblChart2Title.Name = "lblChart2Title";
            this.lblChart2Title.Size = new System.Drawing.Size(562, 32);
            this.lblChart2Title.TabIndex = 0;
            this.lblChart2Title.Text = "حالة العقارات";
            this.lblChart2Title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlChart1
            // 
            this.pnlChart1.BorderRadius = 15;
            this.pnlChart1.Controls.Add(this.gunaChart1);
            this.pnlChart1.Controls.Add(this.lblChart1Title);
            this.pnlChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChart1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.pnlChart1.Location = new System.Drawing.Point(611, 3);
            this.pnlChart1.Name = "pnlChart1";
            this.pnlChart1.Padding = new System.Windows.Forms.Padding(20);
            this.pnlChart1.ShadowDecoration.BorderRadius = 15;
            this.pnlChart1.ShadowDecoration.Enabled = true;
            this.pnlChart1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.pnlChart1.Size = new System.Drawing.Size(603, 314);
            this.pnlChart1.TabIndex = 0;
            // 
            // gunaChart1
            // 
            this.gunaChart1.AutoSize = true;
            this.gunaChart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.gunaChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaChart1.ForeColor = System.Drawing.Color.White;
            this.gunaChart1.Location = new System.Drawing.Point(20, 52);
            this.gunaChart1.Name = "gunaChart1";
            this.gunaChart1.Size = new System.Drawing.Size(563, 242);
            this.gunaChart1.TabIndex = 1;
            // 
            // lblChart1Title
            // 
            this.lblChart1Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChart1Title.Font = new System.Drawing.Font("Tajawal", 14F, System.Drawing.FontStyle.Bold);
            this.lblChart1Title.ForeColor = System.Drawing.Color.White;
            this.lblChart1Title.Location = new System.Drawing.Point(20, 20);
            this.lblChart1Title.Name = "lblChart1Title";
            this.lblChart1Title.Size = new System.Drawing.Size(563, 32);
            this.lblChart1Title.TabIndex = 0;
            this.lblChart1Title.Text = "الإيرادات الشهرية";
            this.lblChart1Title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowSummaryCards
            // 
            this.flowSummaryCards.AutoSize = true;
            this.flowSummaryCards.Controls.Add(this.cardTotalClients);
            this.flowSummaryCards.Controls.Add(this.cardTotalOwners);
            this.flowSummaryCards.Controls.Add(this.cardTotalProperties);
            this.flowSummaryCards.Controls.Add(this.cardTotalRevenue);
            this.flowSummaryCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowSummaryCards.Location = new System.Drawing.Point(20, 20);
            this.flowSummaryCards.Name = "flowSummaryCards";
            this.flowSummaryCards.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.flowSummaryCards.Size = new System.Drawing.Size(1217, 148);
            this.flowSummaryCards.TabIndex = 0;
            // 
            // cardTotalClients
            // 
            this.cardTotalClients.BackColor = System.Drawing.Color.Transparent;
            this.cardTotalClients.BorderRadius = 15;
            this.cardTotalClients.Controls.Add(this.lblClientsChange);
            this.cardTotalClients.Controls.Add(this.lblClientsValue);
            this.cardTotalClients.Controls.Add(this.lblClientsTitle);
            this.cardTotalClients.Controls.Add(this.picClients);
            this.cardTotalClients.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.cardTotalClients.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(75)))), ((int)(((byte)(162)))));
            this.cardTotalClients.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cardTotalClients.Location = new System.Drawing.Point(920, 10);
            this.cardTotalClients.Margin = new System.Windows.Forms.Padding(10);
            this.cardTotalClients.Name = "cardTotalClients";
            this.cardTotalClients.ShadowDecoration.BorderRadius = 15;
            this.cardTotalClients.ShadowDecoration.Enabled = true;
            this.cardTotalClients.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.cardTotalClients.Size = new System.Drawing.Size(280, 108);
            this.cardTotalClients.TabIndex = 0;
            // 
            // lblClientsChange
            // 
            this.lblClientsChange.AutoSize = true;
            this.lblClientsChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblClientsChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblClientsChange.Location = new System.Drawing.Point(20, 80);
            this.lblClientsChange.Name = "lblClientsChange";
            this.lblClientsChange.Size = new System.Drawing.Size(84, 15);
            this.lblClientsChange.TabIndex = 3;
            this.lblClientsChange.Text = "▲ +10% شهريًا";
            // 
            // lblClientsValue
            // 
            this.lblClientsValue.AutoSize = true;
            this.lblClientsValue.Font = new System.Drawing.Font("Tajawal", 22F, System.Drawing.FontStyle.Bold);
            this.lblClientsValue.ForeColor = System.Drawing.Color.White;
            this.lblClientsValue.Location = new System.Drawing.Point(15, 40);
            this.lblClientsValue.Name = "lblClientsValue";
            this.lblClientsValue.Size = new System.Drawing.Size(66, 44);
            this.lblClientsValue.TabIndex = 2;
            this.lblClientsValue.Text = "120";
            // 
            // lblClientsTitle
            // 
            this.lblClientsTitle.AutoSize = true;
            this.lblClientsTitle.Font = new System.Drawing.Font("Tajawal", 11F, System.Drawing.FontStyle.Bold);
            this.lblClientsTitle.ForeColor = System.Drawing.Color.White;
            this.lblClientsTitle.Location = new System.Drawing.Point(15, 15);
            this.lblClientsTitle.Name = "lblClientsTitle";
            this.lblClientsTitle.Size = new System.Drawing.Size(101, 22);
            this.lblClientsTitle.TabIndex = 1;
            this.lblClientsTitle.Text = "إجمالي العملاء";
            // 
            // picClients
            // 
            this.picClients.BackColor = System.Drawing.Color.Transparent;
            this.picClients.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(30)))));
            this.picClients.ImageRotate = 0F;
            this.picClients.Location = new System.Drawing.Point(220, 15);
            this.picClients.Name = "picClients";
            this.picClients.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picClients.Size = new System.Drawing.Size(45, 45);
            this.picClients.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClients.TabIndex = 0;
            this.picClients.TabStop = false;
            // 
            // cardTotalOwners
            // 
            this.cardTotalOwners.BackColor = System.Drawing.Color.Transparent;
            this.cardTotalOwners.BorderRadius = 15;
            this.cardTotalOwners.Controls.Add(this.lblOwnersChange);
            this.cardTotalOwners.Controls.Add(this.lblOwnersValue);
            this.cardTotalOwners.Controls.Add(this.lblOwnersTitle);
            this.cardTotalOwners.Controls.Add(this.picOwners);
            this.cardTotalOwners.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.cardTotalOwners.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.cardTotalOwners.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cardTotalOwners.Location = new System.Drawing.Point(620, 10);
            this.cardTotalOwners.Margin = new System.Windows.Forms.Padding(10);
            this.cardTotalOwners.Name = "cardTotalOwners";
            this.cardTotalOwners.ShadowDecoration.BorderRadius = 15;
            this.cardTotalOwners.ShadowDecoration.Enabled = true;
            this.cardTotalOwners.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.cardTotalOwners.Size = new System.Drawing.Size(280, 108);
            this.cardTotalOwners.TabIndex = 1;
            // 
            // lblOwnersChange
            // 
            this.lblOwnersChange.AutoSize = true;
            this.lblOwnersChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOwnersChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.lblOwnersChange.Location = new System.Drawing.Point(20, 80);
            this.lblOwnersChange.Name = "lblOwnersChange";
            this.lblOwnersChange.Size = new System.Drawing.Size(82, 15);
            this.lblOwnersChange.TabIndex = 3;
            this.lblOwnersChange.Text = "▲ +8% شهريًا";
            // 
            // lblOwnersValue
            // 
            this.lblOwnersValue.AutoSize = true;
            this.lblOwnersValue.Font = new System.Drawing.Font("Tajawal", 22F, System.Drawing.FontStyle.Bold);
            this.lblOwnersValue.ForeColor = System.Drawing.Color.White;
            this.lblOwnersValue.Location = new System.Drawing.Point(15, 40);
            this.lblOwnersValue.Name = "lblOwnersValue";
            this.lblOwnersValue.Size = new System.Drawing.Size(48, 44);
            this.lblOwnersValue.TabIndex = 2;
            this.lblOwnersValue.Text = "85";
            // 
            // lblOwnersTitle
            // 
            this.lblOwnersTitle.AutoSize = true;
            this.lblOwnersTitle.Font = new System.Drawing.Font("Tajawal", 11F, System.Drawing.FontStyle.Bold);
            this.lblOwnersTitle.ForeColor = System.Drawing.Color.White;
            this.lblOwnersTitle.Location = new System.Drawing.Point(15, 15);
            this.lblOwnersTitle.Name = "lblOwnersTitle";
            this.lblOwnersTitle.Size = new System.Drawing.Size(99, 22);
            this.lblOwnersTitle.TabIndex = 1;
            this.lblOwnersTitle.Text = "إجمالي الملاك";
            // 
            // picOwners
            // 
            this.picOwners.BackColor = System.Drawing.Color.Transparent;
            this.picOwners.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(30)))));
            this.picOwners.ImageRotate = 0F;
            this.picOwners.Location = new System.Drawing.Point(220, 15);
            this.picOwners.Name = "picOwners";
            this.picOwners.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picOwners.Size = new System.Drawing.Size(45, 45);
            this.picOwners.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOwners.TabIndex = 0;
            this.picOwners.TabStop = false;
            // 
            // cardTotalProperties
            // 
            this.cardTotalProperties.BackColor = System.Drawing.Color.Transparent;
            this.cardTotalProperties.BorderRadius = 15;
            this.cardTotalProperties.Controls.Add(this.lblPropertiesChange);
            this.cardTotalProperties.Controls.Add(this.lblPropertiesValue);
            this.cardTotalProperties.Controls.Add(this.lblPropertiesTitle);
            this.cardTotalProperties.Controls.Add(this.picProperties);
            this.cardTotalProperties.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(146)))), ((int)(((byte)(60)))));
            this.cardTotalProperties.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(113)))), ((int)(((byte)(133)))));
            this.cardTotalProperties.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cardTotalProperties.Location = new System.Drawing.Point(320, 10);
            this.cardTotalProperties.Margin = new System.Windows.Forms.Padding(10);
            this.cardTotalProperties.Name = "cardTotalProperties";
            this.cardTotalProperties.ShadowDecoration.BorderRadius = 15;
            this.cardTotalProperties.ShadowDecoration.Enabled = true;
            this.cardTotalProperties.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.cardTotalProperties.Size = new System.Drawing.Size(280, 108);
            this.cardTotalProperties.TabIndex = 2;
            // 
            // lblPropertiesChange
            // 
            this.lblPropertiesChange.AutoSize = true;
            this.lblPropertiesChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPropertiesChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.lblPropertiesChange.Location = new System.Drawing.Point(20, 80);
            this.lblPropertiesChange.Name = "lblPropertiesChange";
            this.lblPropertiesChange.Size = new System.Drawing.Size(78, 15);
            this.lblPropertiesChange.TabIndex = 3;
            this.lblPropertiesChange.Text = "▲ +5% شهريًا";
            // 
            // lblPropertiesValue
            // 
            this.lblPropertiesValue.AutoSize = true;
            this.lblPropertiesValue.Font = new System.Drawing.Font("Tajawal", 22F, System.Drawing.FontStyle.Bold);
            this.lblPropertiesValue.ForeColor = System.Drawing.Color.White;
            this.lblPropertiesValue.Location = new System.Drawing.Point(15, 40);
            this.lblPropertiesValue.Name = "lblPropertiesValue";
            this.lblPropertiesValue.Size = new System.Drawing.Size(66, 44);
            this.lblPropertiesValue.TabIndex = 2;
            this.lblPropertiesValue.Text = "512";
            // 
            // lblPropertiesTitle
            // 
            this.lblPropertiesTitle.AutoSize = true;
            this.lblPropertiesTitle.Font = new System.Drawing.Font("Tajawal", 11F, System.Drawing.FontStyle.Bold);
            this.lblPropertiesTitle.ForeColor = System.Drawing.Color.White;
            this.lblPropertiesTitle.Location = new System.Drawing.Point(15, 15);
            this.lblPropertiesTitle.Name = "lblPropertiesTitle";
            this.lblPropertiesTitle.Size = new System.Drawing.Size(111, 22);
            this.lblPropertiesTitle.TabIndex = 1;
            this.lblPropertiesTitle.Text = "إجمالي العقارات";
            // 
            // picProperties
            // 
            this.picProperties.BackColor = System.Drawing.Color.Transparent;
            this.picProperties.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(30)))));
            this.picProperties.ImageRotate = 0F;
            this.picProperties.Location = new System.Drawing.Point(220, 15);
            this.picProperties.Name = "picProperties";
            this.picProperties.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picProperties.Size = new System.Drawing.Size(45, 45);
            this.picProperties.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProperties.TabIndex = 0;
            this.picProperties.TabStop = false;
            // 
            // cardTotalRevenue
            // 
            this.cardTotalRevenue.BackColor = System.Drawing.Color.Transparent;
            this.cardTotalRevenue.BorderRadius = 15;
            this.cardTotalRevenue.Controls.Add(this.lblRevenueChange);
            this.cardTotalRevenue.Controls.Add(this.lblRevenueValue);
            this.cardTotalRevenue.Controls.Add(this.lblRevenueTitle);
            this.cardTotalRevenue.Controls.Add(this.picRevenue);
            this.cardTotalRevenue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.cardTotalRevenue.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cardTotalRevenue.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cardTotalRevenue.Location = new System.Drawing.Point(20, 10);
            this.cardTotalRevenue.Margin = new System.Windows.Forms.Padding(10);
            this.cardTotalRevenue.Name = "cardTotalRevenue";
            this.cardTotalRevenue.ShadowDecoration.BorderRadius = 15;
            this.cardTotalRevenue.ShadowDecoration.Enabled = true;
            this.cardTotalRevenue.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.cardTotalRevenue.Size = new System.Drawing.Size(280, 108);
            this.cardTotalRevenue.TabIndex = 3;
            // 
            // lblRevenueChange
            // 
            this.lblRevenueChange.AutoSize = true;
            this.lblRevenueChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRevenueChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblRevenueChange.Location = new System.Drawing.Point(20, 80);
            this.lblRevenueChange.Name = "lblRevenueChange";
            this.lblRevenueChange.Size = new System.Drawing.Size(85, 15);
            this.lblRevenueChange.TabIndex = 3;
            this.lblRevenueChange.Text = "▲ +15% شهريًا";
            // 
            // lblRevenueValue
            // 
            this.lblRevenueValue.AutoSize = true;
            this.lblRevenueValue.Font = new System.Drawing.Font("Tajawal", 22F, System.Drawing.FontStyle.Bold);
            this.lblRevenueValue.ForeColor = System.Drawing.Color.White;
            this.lblRevenueValue.Location = new System.Drawing.Point(15, 40);
            this.lblRevenueValue.Name = "lblRevenueValue";
            this.lblRevenueValue.Size = new System.Drawing.Size(107, 44);
            this.lblRevenueValue.TabIndex = 2;
            this.lblRevenueValue.Text = "$1.2M";
            // 
            // lblRevenueTitle
            // 
            this.lblRevenueTitle.AutoSize = true;
            this.lblRevenueTitle.Font = new System.Drawing.Font("Tajawal", 11F, System.Drawing.FontStyle.Bold);
            this.lblRevenueTitle.ForeColor = System.Drawing.Color.White;
            this.lblRevenueTitle.Location = new System.Drawing.Point(15, 15);
            this.lblRevenueTitle.Name = "lblRevenueTitle";
            this.lblRevenueTitle.Size = new System.Drawing.Size(113, 22);
            this.lblRevenueTitle.TabIndex = 1;
            this.lblRevenueTitle.Text = "إجمالي الإيرادات";
            // 
            // picRevenue
            // 
            this.picRevenue.BackColor = System.Drawing.Color.Transparent;
            this.picRevenue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(30)))));
            this.picRevenue.ImageRotate = 0F;
            this.picRevenue.Location = new System.Drawing.Point(220, 15);
            this.picRevenue.Name = "picRevenue";
            this.picRevenue.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picRevenue.Size = new System.Drawing.Size(45, 45);
            this.picRevenue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRevenue.TabIndex = 0;
            this.picRevenue.TabStop = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.pnlFooter.Controls.Add(this.lblDeveloper);
            this.pnlFooter.Controls.Add(this.lblDateTime);
            this.pnlFooter.Controls.Add(this.lblVersion);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 720);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1280, 40);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Tajawal", 9F);
            this.lblDeveloper.ForeColor = System.Drawing.Color.Gray;
            this.lblDeveloper.Location = new System.Drawing.Point(1100, 11);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(170, 18);
            this.lblDeveloper.TabIndex = 2;
            this.lblDeveloper.Text = "تم التطوير بواسطة فريق العمل";
            this.lblDeveloper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Tajawal", 9F);
            this.lblDateTime.ForeColor = System.Drawing.Color.Silver;
            this.lblDateTime.Location = new System.Drawing.Point(490, 11);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(300, 18);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "الاثنين، 14 أكتوبر 2025 10:30 صباحًا";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Tajawal", 9F);
            this.lblVersion.ForeColor = System.Drawing.Color.Gray;
            this.lblVersion.Location = new System.Drawing.Point(20, 11);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(80, 18);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "الإصدار 1.0.0";
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "frmDashboard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لوحة تحكم إدارة العقارات";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            this.pnlRecentActivities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentActivities)).EndInit();
            this.tblCharts.ResumeLayout(false);
            this.pnlChart2.ResumeLayout(false);
            this.pnlChart2.PerformLayout();
            this.pnlChart1.ResumeLayout(false);
            this.pnlChart1.PerformLayout();
            this.flowSummaryCards.ResumeLayout(false);
            this.cardTotalClients.ResumeLayout(false);
            this.cardTotalClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClients)).EndInit();
            this.cardTotalOwners.ResumeLayout(false);
            this.cardTotalOwners.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOwners)).EndInit();
            this.cardTotalProperties.ResumeLayout(false);
            this.cardTotalProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProperties)).EndInit();
            this.cardTotalRevenue.ResumeLayout(false);
            this.cardTotalRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRevenue)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlHeader;
        private System.Windows.Forms.Label lblAppTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Panel pnlMainContent;
        private System.Windows.Forms.FlowLayoutPanel flowSummaryCards;
        private Guna.UI2.WinForms.Guna2GradientPanel cardTotalClients;
        private System.Windows.Forms.Label lblClientsTitle;
        private System.Windows.Forms.Label lblClientsValue;
        private System.Windows.Forms.Label lblClientsChange;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picClients;
        private Guna.UI2.WinForms.Guna2GradientPanel cardTotalOwners;
        private System.Windows.Forms.Label lblOwnersTitle;
        private System.Windows.Forms.Label lblOwnersValue;
        private System.Windows.Forms.Label lblOwnersChange;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picOwners;
        private Guna.UI2.WinForms.Guna2GradientPanel cardTotalProperties;
        private System.Windows.Forms.Label lblPropertiesTitle;
        private System.Windows.Forms.Label lblPropertiesValue;
        private System.Windows.Forms.Label lblPropertiesChange;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picProperties;
        private Guna.UI2.WinForms.Guna2GradientPanel cardTotalRevenue;
        private System.Windows.Forms.Label lblRevenueTitle;
        private System.Windows.Forms.Label lblRevenueValue;
        private System.Windows.Forms.Label lblRevenueChange;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picRevenue;
        private System.Windows.Forms.TableLayoutPanel tblCharts;
        private Guna.UI2.WinForms.Guna2Panel pnlChart1;
        private Guna.Charts.WinForms.GunaChart gunaChart1;
        private System.Windows.Forms.Label lblChart1Title;
        private Guna.UI2.WinForms.Guna2Panel pnlChart2;
        private Guna.Charts.WinForms.GunaChart gunaChart2;
        private System.Windows.Forms.Label lblChart2Title;
        private Guna.UI2.WinForms.Guna2Panel pnlRecentActivities;
        private System.Windows.Forms.Label lblRecentActivitiesTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRecentActivities;
        private Guna.UI2.WinForms.Guna2Panel pnlFooter;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Timer timerDateTime;
    }
}