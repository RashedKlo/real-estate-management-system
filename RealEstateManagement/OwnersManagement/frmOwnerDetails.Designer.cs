namespace RealEstateManagement
{
    partial class frmOwnerDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.contentPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.propertiesSection = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvProperties = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colPropertyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumOfRooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvailability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMortgagePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paginationPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnNextPage = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrevPage = new Guna.UI2.WinForms.Guna2Button();
            this.propertiesHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPropertiesCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.detailsSection = new Guna.UI2.WinForms.Guna2Panel();
            this.txtOwnerID = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSectionTitle = new System.Windows.Forms.Label();
            this.topBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblOwnerId = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.mainContainer.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.propertiesSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).BeginInit();
            this.paginationPanel.SuspendLayout();
            this.propertiesHeader.SuspendLayout();
            this.detailsSection.SuspendLayout();
            this.topBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.mainContainer.Controls.Add(this.contentPanel);
            this.mainContainer.Controls.Add(this.topBar);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Padding = new System.Windows.Forms.Padding(10);
            this.mainContainer.Size = new System.Drawing.Size(1040, 630);
            this.mainContainer.TabIndex = 0;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.Transparent;
            this.contentPanel.Controls.Add(this.propertiesSection);
            this.contentPanel.Controls.Add(this.detailsSection);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(10, 80);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.contentPanel.Size = new System.Drawing.Size(1020, 540);
            this.contentPanel.TabIndex = 1;
            // 
            // propertiesSection
            // 
            this.propertiesSection.BorderRadius = 12;
            this.propertiesSection.Controls.Add(this.dgvProperties);
            this.propertiesSection.Controls.Add(this.paginationPanel);
            this.propertiesSection.Controls.Add(this.propertiesHeader);
            this.propertiesSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesSection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.propertiesSection.Location = new System.Drawing.Point(0, 180);
            this.propertiesSection.Name = "propertiesSection";
            this.propertiesSection.Padding = new System.Windows.Forms.Padding(15);
            this.propertiesSection.Size = new System.Drawing.Size(1020, 360);
            this.propertiesSection.TabIndex = 1;
            // 
            // dgvProperties
            // 
            this.dgvProperties.AllowUserToAddRows = false;
            this.dgvProperties.AllowUserToDeleteRows = false;
            this.dgvProperties.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvProperties.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProperties.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProperties.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProperties.ColumnHeadersHeight = 45;
            this.dgvProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProperties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPropertyId,
            this.colLocation,
            this.colNumOfRooms,
            this.colStatus,
            this.colAvailability,
            this.colRentPrice,
            this.colSalePrice,
            this.colMortgagePrice,
            this.colCreatedAt});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProperties.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProperties.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.dgvProperties.Location = new System.Drawing.Point(15, 55);
            this.dgvProperties.MultiSelect = false;
            this.dgvProperties.Name = "dgvProperties";
            this.dgvProperties.ReadOnly = true;
            this.dgvProperties.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvProperties.RowHeadersVisible = false;
            this.dgvProperties.RowTemplate.Height = 40;
            this.dgvProperties.Size = new System.Drawing.Size(990, 230);
            this.dgvProperties.TabIndex = 2;
            this.dgvProperties.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.dgvProperties.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProperties.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProperties.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProperties.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProperties.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(35)))));
            this.dgvProperties.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.dgvProperties.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.dgvProperties.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProperties.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.dgvProperties.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProperties.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProperties.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvProperties.ThemeStyle.ReadOnly = true;
            this.dgvProperties.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.dgvProperties.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProperties.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dgvProperties.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProperties.ThemeStyle.RowsStyle.Height = 40;
            this.dgvProperties.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dgvProperties.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // colPropertyId
            // 
            this.colPropertyId.HeaderText = "رقم العقار";
            this.colPropertyId.Name = "colPropertyId";
            this.colPropertyId.ReadOnly = true;
            // 
            // colLocation
            // 
            this.colLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLocation.HeaderText = "الموقع";
            this.colLocation.Name = "colLocation";
            this.colLocation.ReadOnly = true;
            // 
            // colNumOfRooms
            // 
            this.colNumOfRooms.HeaderText = "عدد الغرف";
            this.colNumOfRooms.Name = "colNumOfRooms";
            this.colNumOfRooms.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "الحالة";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colAvailability
            // 
            this.colAvailability.HeaderText = "التوفر";
            this.colAvailability.Name = "colAvailability";
            this.colAvailability.ReadOnly = true;
            // 
            // colRentPrice
            // 
            this.colRentPrice.HeaderText = "سعر الإيجار";
            this.colRentPrice.Name = "colRentPrice";
            this.colRentPrice.ReadOnly = true;
            // 
            // colSalePrice
            // 
            this.colSalePrice.HeaderText = "سعر البيع";
            this.colSalePrice.Name = "colSalePrice";
            this.colSalePrice.ReadOnly = true;
            // 
            // colMortgagePrice
            // 
            this.colMortgagePrice.HeaderText = "سعر الرهن";
            this.colMortgagePrice.Name = "colMortgagePrice";
            this.colMortgagePrice.ReadOnly = true;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.HeaderText = "تاريخ الإنشاء";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.ReadOnly = true;
            // 
            // paginationPanel
            // 
            this.paginationPanel.BackColor = System.Drawing.Color.Transparent;
            this.paginationPanel.Controls.Add(this.lblPageInfo);
            this.paginationPanel.Controls.Add(this.btnNextPage);
            this.paginationPanel.Controls.Add(this.btnPrevPage);
            this.paginationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paginationPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.paginationPanel.Location = new System.Drawing.Point(15, 285);
            this.paginationPanel.Name = "paginationPanel";
            this.paginationPanel.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.paginationPanel.Size = new System.Drawing.Size(990, 60);
            this.paginationPanel.TabIndex = 1;
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPageInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblPageInfo.ForeColor = System.Drawing.Color.White;
            this.lblPageInfo.Location = new System.Drawing.Point(395, 17);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPageInfo.Size = new System.Drawing.Size(200, 25);
            this.lblPageInfo.TabIndex = 2;
            this.lblPageInfo.Text = "صفحة 1 من 1";
            this.lblPageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPage.Animated = true;
            this.btnNextPage.BorderRadius = 8;
            this.btnNextPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNextPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNextPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnNextPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnNextPage.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(240)))));
            this.btnNextPage.Location = new System.Drawing.Point(18, 11);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(52, 36);
            this.btnNextPage.TabIndex = 1;
            this.btnNextPage.Text = "←";
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Animated = true;
            this.btnPrevPage.BorderRadius = 8;
            this.btnPrevPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnPrevPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnPrevPage.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevPage.ForeColor = System.Drawing.Color.White;
            this.btnPrevPage.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(240)))));
            this.btnPrevPage.Location = new System.Drawing.Point(89, 11);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(50, 36);
            this.btnPrevPage.TabIndex = 0;
            this.btnPrevPage.Text = "→";
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // propertiesHeader
            // 
            this.propertiesHeader.BackColor = System.Drawing.Color.Transparent;
            this.propertiesHeader.Controls.Add(this.lblPropertiesCount);
            this.propertiesHeader.Controls.Add(this.label8);
            this.propertiesHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.propertiesHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.propertiesHeader.Location = new System.Drawing.Point(15, 15);
            this.propertiesHeader.Name = "propertiesHeader";
            this.propertiesHeader.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.propertiesHeader.Size = new System.Drawing.Size(990, 40);
            this.propertiesHeader.TabIndex = 0;
            // 
            // lblPropertiesCount
            // 
            this.lblPropertiesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPropertiesCount.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPropertiesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblPropertiesCount.Location = new System.Drawing.Point(670, 10);
            this.lblPropertiesCount.Name = "lblPropertiesCount";
            this.lblPropertiesCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPropertiesCount.Size = new System.Drawing.Size(150, 20);
            this.lblPropertiesCount.TabIndex = 1;
            this.lblPropertiesCount.Text = "(0 عقار)";
            this.lblPropertiesCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(826, 9);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(149, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "العقارات المملوكة";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // detailsSection
            // 
            this.detailsSection.BorderRadius = 12;
            this.detailsSection.Controls.Add(this.txtOwnerID);
            this.detailsSection.Controls.Add(this.txtAddress);
            this.detailsSection.Controls.Add(this.label5);
            this.detailsSection.Controls.Add(this.txtPhone);
            this.detailsSection.Controls.Add(this.label3);
            this.detailsSection.Controls.Add(this.txtFullName);
            this.detailsSection.Controls.Add(this.label2);
            this.detailsSection.Controls.Add(this.lblSectionTitle);
            this.detailsSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailsSection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.detailsSection.Location = new System.Drawing.Point(0, 10);
            this.detailsSection.Name = "detailsSection";
            this.detailsSection.Padding = new System.Windows.Forms.Padding(20);
            this.detailsSection.Size = new System.Drawing.Size(1020, 170);
            this.detailsSection.TabIndex = 0;
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOwnerID.Font = new System.Drawing.Font("Arial", 8F);
            this.txtOwnerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtOwnerID.Location = new System.Drawing.Point(23, 8);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOwnerID.Size = new System.Drawing.Size(100, 15);
            this.txtOwnerID.TabIndex = 9;
            this.txtOwnerID.Text = "0";
            this.txtOwnerID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtOwnerID.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Font = new System.Drawing.Font("Arial", 10F);
            this.txtAddress.ForeColor = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(106, 110);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.Size = new System.Drawing.Size(827, 30);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.Text = "-";
            this.txtAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label5.Location = new System.Drawing.Point(939, 110);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "العنوان:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(694, 80);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPhone.Size = new System.Drawing.Size(236, 23);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.Text = "-";
            this.txtPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label3.Location = new System.Drawing.Point(939, 80);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "رقم الهاتف:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFullName.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.txtFullName.ForeColor = System.Drawing.Color.White;
            this.txtFullName.Location = new System.Drawing.Point(653, 50);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFullName.Size = new System.Drawing.Size(280, 20);
            this.txtFullName.TabIndex = 2;
            this.txtFullName.Text = "-";
            this.txtFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(939, 50);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاسم الكامل:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSectionTitle
            // 
            this.lblSectionTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSectionTitle.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lblSectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblSectionTitle.Location = new System.Drawing.Point(902, 8);
            this.lblSectionTitle.Name = "lblSectionTitle";
            this.lblSectionTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSectionTitle.Size = new System.Drawing.Size(140, 22);
            this.lblSectionTitle.TabIndex = 0;
            this.lblSectionTitle.Text = "📋 بيانات المالك";
            this.lblSectionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.Transparent;
            this.topBar.Controls.Add(this.btnClose);
            this.topBar.Controls.Add(this.lblOwnerId);
            this.topBar.Controls.Add(this.lblHeader);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.topBar.Location = new System.Drawing.Point(10, 10);
            this.topBar.Name = "topBar";
            this.topBar.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.topBar.Size = new System.Drawing.Size(1020, 70);
            this.topBar.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.BorderRadius = 8;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnClose.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnClose.Location = new System.Drawing.Point(15, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 36);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "✖";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblOwnerId
            // 
            this.lblOwnerId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOwnerId.Font = new System.Drawing.Font("Arial", 10F);
            this.lblOwnerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblOwnerId.Location = new System.Drawing.Point(770, 40);
            this.lblOwnerId.Name = "lblOwnerId";
            this.lblOwnerId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblOwnerId.Size = new System.Drawing.Size(235, 20);
            this.lblOwnerId.TabIndex = 1;
            this.lblOwnerId.Text = "رقم المالك: 0";
            this.lblOwnerId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(700, 8);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHeader.Size = new System.Drawing.Size(305, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "تفاصيل المالك";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmOwnerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1040, 630);
            this.Controls.Add(this.mainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "frmOwnerDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تفاصيل المالك";
            this.Load += new System.EventHandler(this.frmOwnerDetails_Load);
            this.mainContainer.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.propertiesSection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).EndInit();
            this.paginationPanel.ResumeLayout(false);
            this.propertiesHeader.ResumeLayout(false);
            this.detailsSection.ResumeLayout(false);
            this.topBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainContainer;
        private Guna.UI2.WinForms.Guna2Panel topBar;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblOwnerId;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Panel contentPanel;
        private Guna.UI2.WinForms.Guna2Panel detailsSection;
        private System.Windows.Forms.Label lblSectionTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtAddress;
        private System.Windows.Forms.Label txtOwnerID;
        private Guna.UI2.WinForms.Guna2Panel propertiesSection;
        private Guna.UI2.WinForms.Guna2Panel propertiesHeader;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPropertiesCount;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProperties;
        private Guna.UI2.WinForms.Guna2Panel paginationPanel;
        private Guna.UI2.WinForms.Guna2Button btnPrevPage;
        private Guna.UI2.WinForms.Guna2Button btnNextPage;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPropertyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumOfRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvailability;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRentPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMortgagePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedAt;
    }
}