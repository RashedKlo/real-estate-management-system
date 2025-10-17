namespace RealEstateManagement
{
    partial class frmOwners
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.contentArea = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvOwners = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colOwnerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bottomBar = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnNextPage = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrevPage = new Guna.UI2.WinForms.Guna2Button();
            this.topBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnView = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.lblTotalOwners = new System.Windows.Forms.Label();
            this.sideFilterPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnClearFilter = new Guna.UI2.WinForms.Guna2Button();
            this.btnApplyFilter = new Guna.UI2.WinForms.Guna2Button();
            this.txtFilterPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilterName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.mainContainer.SuspendLayout();
            this.contentArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwners)).BeginInit();
            this.bottomBar.SuspendLayout();
            this.topBar.SuspendLayout();
            this.sideFilterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.mainContainer.Controls.Add(this.contentArea);
            this.mainContainer.Controls.Add(this.sideFilterPanel);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Padding = new System.Windows.Forms.Padding(10);
            this.mainContainer.Size = new System.Drawing.Size(1040, 630);
            this.mainContainer.TabIndex = 0;
            // 
            // contentArea
            // 
            this.contentArea.BackColor = System.Drawing.Color.Transparent;
            this.contentArea.Controls.Add(this.dgvOwners);
            this.contentArea.Controls.Add(this.bottomBar);
            this.contentArea.Controls.Add(this.topBar);
            this.contentArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentArea.Location = new System.Drawing.Point(10, 10);
            this.contentArea.Name = "contentArea";
            this.contentArea.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.contentArea.Size = new System.Drawing.Size(760, 610);
            this.contentArea.TabIndex = 1;
            // 
            // dgvOwners
            // 
            this.dgvOwners.AllowUserToAddRows = false;
            this.dgvOwners.AllowUserToDeleteRows = false;
            this.dgvOwners.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvOwners.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOwners.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOwners.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOwners.ColumnHeadersHeight = 50;
            this.dgvOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvOwners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOwnerId,
            this.colFullName,
            this.colPhoneNumber,
            this.colAddress,
            this.colCreatedAt});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Cairo", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(106)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOwners.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOwners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOwners.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.dgvOwners.Location = new System.Drawing.Point(0, 60);
            this.dgvOwners.MultiSelect = false;
            this.dgvOwners.Name = "dgvOwners";
            this.dgvOwners.ReadOnly = true;
            this.dgvOwners.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvOwners.RowHeadersVisible = false;
            this.dgvOwners.RowTemplate.Height = 42;
            this.dgvOwners.Size = new System.Drawing.Size(750, 490);
            this.dgvOwners.TabIndex = 2;
            this.dgvOwners.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.dgvOwners.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOwners.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOwners.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvOwners.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvOwners.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.dgvOwners.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.dgvOwners.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.dgvOwners.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOwners.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.dgvOwners.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOwners.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvOwners.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvOwners.ThemeStyle.ReadOnly = true;
            this.dgvOwners.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.dgvOwners.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOwners.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Cairo", 10F);
            this.dgvOwners.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOwners.ThemeStyle.RowsStyle.Height = 42;
            this.dgvOwners.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(106)))), ((int)(((byte)(182)))));
            this.dgvOwners.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // colOwnerId
            // 
            this.colOwnerId.DataPropertyName = "OwnerId";
            this.colOwnerId.HeaderText = "المعرف";
            this.colOwnerId.Name = "colOwnerId";
            this.colOwnerId.ReadOnly = true;
            // 
            // colFullName
            // 
            this.colFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFullName.DataPropertyName = "FullName";
            this.colFullName.HeaderText = "الاسم الكامل";
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.DataPropertyName = "PhoneNumber";
            this.colPhoneNumber.HeaderText = "رقم الهاتف";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "العنوان";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.DataPropertyName = "CreatedAt";
            this.colCreatedAt.HeaderText = "تاريخ الإضافة";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.ReadOnly = true;
            // 
            // bottomBar
            // 
            this.bottomBar.BackColor = System.Drawing.Color.Transparent;
            this.bottomBar.Controls.Add(this.lblPageInfo);
            this.bottomBar.Controls.Add(this.btnNextPage);
            this.bottomBar.Controls.Add(this.btnPrevPage);
            this.bottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.bottomBar.Location = new System.Drawing.Point(0, 550);
            this.bottomBar.Name = "bottomBar";
            this.bottomBar.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.bottomBar.Size = new System.Drawing.Size(750, 60);
            this.bottomBar.TabIndex = 1;
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPageInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblPageInfo.ForeColor = System.Drawing.Color.White;
            this.lblPageInfo.Location = new System.Drawing.Point(275, 17);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPageInfo.Size = new System.Drawing.Size(200, 25);
            this.lblPageInfo.TabIndex = 2;
            this.lblPageInfo.Text = "صفحة 1 من 1";
            this.lblPageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Animated = true;
            this.btnNextPage.BorderRadius = 8;
            this.btnNextPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNextPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNextPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnNextPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnNextPage.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(240)))));
            this.btnNextPage.Location = new System.Drawing.Point(15, 13);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(65, 36);
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
            this.btnPrevPage.Location = new System.Drawing.Point(86, 13);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(59, 36);
            this.btnPrevPage.TabIndex = 0;
            this.btnPrevPage.Text = " →";
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.Transparent;
            this.topBar.Controls.Add(this.btnDelete);
            this.topBar.Controls.Add(this.btnEdit);
            this.topBar.Controls.Add(this.btnView);
            this.topBar.Controls.Add(this.btnAdd);
            this.topBar.Controls.Add(this.lblTotalOwners);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.topBar.Size = new System.Drawing.Size(750, 60);
            this.topBar.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.BorderRadius = 8;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDelete.Location = new System.Drawing.Point(15, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 36);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Animated = true;
            this.btnEdit.BorderRadius = 8;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnEdit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnEdit.Location = new System.Drawing.Point(116, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 36);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnView
            // 
            this.btnView.Animated = true;
            this.btnView.BorderRadius = 8;
            this.btnView.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnView.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnView.Location = new System.Drawing.Point(217, 12);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(95, 36);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "عرض";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.BorderRadius = 8;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(240)))));
            this.btnAdd.Location = new System.Drawing.Point(318, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+ إضافة عميل";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTotalOwners
            // 
            this.lblTotalOwners.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalOwners.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalOwners.ForeColor = System.Drawing.Color.White;
            this.lblTotalOwners.Location = new System.Drawing.Point(550, 17);
            this.lblTotalOwners.Name = "lblTotalOwners";
            this.lblTotalOwners.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalOwners.Size = new System.Drawing.Size(185, 25);
            this.lblTotalOwners.TabIndex = 0;
            this.lblTotalOwners.Text = "إجمالي العملاء: 0";
            this.lblTotalOwners.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sideFilterPanel
            // 
            this.sideFilterPanel.BackColor = System.Drawing.Color.Transparent;
            this.sideFilterPanel.BorderRadius = 12;
            this.sideFilterPanel.Controls.Add(this.btnRefresh);
            this.sideFilterPanel.Controls.Add(this.guna2Separator1);
            this.sideFilterPanel.Controls.Add(this.btnClearFilter);
            this.sideFilterPanel.Controls.Add(this.btnApplyFilter);
            this.sideFilterPanel.Controls.Add(this.txtFilterPhone);
            this.sideFilterPanel.Controls.Add(this.label2);
            this.sideFilterPanel.Controls.Add(this.txtFilterName);
            this.sideFilterPanel.Controls.Add(this.label1);
            this.sideFilterPanel.Controls.Add(this.lblFilterTitle);
            this.sideFilterPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sideFilterPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.sideFilterPanel.Location = new System.Drawing.Point(770, 10);
            this.sideFilterPanel.Name = "sideFilterPanel";
            this.sideFilterPanel.Padding = new System.Windows.Forms.Padding(15);
            this.sideFilterPanel.Size = new System.Drawing.Size(260, 610);
            this.sideFilterPanel.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Animated = true;
            this.btnRefresh.BorderRadius = 8;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnRefresh.Location = new System.Drawing.Point(15, 555);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(230, 40);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "🔄 تحديث القائمة";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.guna2Separator1.Location = new System.Drawing.Point(15, 235);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(230, 10);
            this.guna2Separator1.TabIndex = 6;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearFilter.Animated = true;
            this.btnClearFilter.BorderRadius = 8;
            this.btnClearFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnClearFilter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnClearFilter.Location = new System.Drawing.Point(15, 194);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(105, 35);
            this.btnClearFilter.TabIndex = 5;
            this.btnClearFilter.Text = "مسح";
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyFilter.Animated = true;
            this.btnApplyFilter.BorderRadius = 8;
            this.btnApplyFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApplyFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnApplyFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApplyFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnApplyFilter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnApplyFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilter.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(240)))));
            this.btnApplyFilter.Location = new System.Drawing.Point(130, 194);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(115, 35);
            this.btnApplyFilter.TabIndex = 4;
            this.btnApplyFilter.Text = "تطبيق الفلتر";
            // 
            // txtFilterPhone
            // 
            this.txtFilterPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterPhone.Animated = true;
            this.txtFilterPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.txtFilterPhone.BorderRadius = 8;
            this.txtFilterPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterPhone.DefaultText = "";
            this.txtFilterPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterPhone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.txtFilterPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterPhone.Font = new System.Drawing.Font("Arial", 9F);
            this.txtFilterPhone.ForeColor = System.Drawing.Color.White;
            this.txtFilterPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterPhone.Location = new System.Drawing.Point(15, 145);
            this.txtFilterPhone.Name = "txtFilterPhone";
            this.txtFilterPhone.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtFilterPhone.PlaceholderText = "أدخل رقم الهاتف";
            this.txtFilterPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFilterPhone.SelectedText = "";
            this.txtFilterPhone.Size = new System.Drawing.Size(230, 38);
            this.txtFilterPhone.TabIndex = 3;
            this.txtFilterPhone.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label2.Location = new System.Drawing.Point(15, 125);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(230, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "رقم الهاتف:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFilterName
            // 
            this.txtFilterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterName.Animated = true;
            this.txtFilterName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.txtFilterName.BorderRadius = 8;
            this.txtFilterName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterName.DefaultText = "";
            this.txtFilterName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.txtFilterName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterName.Font = new System.Drawing.Font("Arial", 9F);
            this.txtFilterName.ForeColor = System.Drawing.Color.White;
            this.txtFilterName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterName.Location = new System.Drawing.Point(15, 75);
            this.txtFilterName.Name = "txtFilterName";
            this.txtFilterName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtFilterName.PlaceholderText = "أدخل الاسم";
            this.txtFilterName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFilterName.SelectedText = "";
            this.txtFilterName.Size = new System.Drawing.Size(230, 38);
            this.txtFilterName.TabIndex = 1;
            this.txtFilterName.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(230, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم العميل:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFilterTitle
            // 
            this.lblFilterTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilterTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFilterTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblFilterTitle.ForeColor = System.Drawing.Color.White;
            this.lblFilterTitle.Location = new System.Drawing.Point(15, 15);
            this.lblFilterTitle.Name = "lblFilterTitle";
            this.lblFilterTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFilterTitle.Size = new System.Drawing.Size(230, 30);
            this.lblFilterTitle.TabIndex = 0;
            this.lblFilterTitle.Text = "🔍 البحث والفلترة";
            this.lblFilterTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmOwners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1040, 630);
            this.Controls.Add(this.mainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "frmOwners";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "إدارة العملاء";
            this.Load += new System.EventHandler(this.frmOwners_Load);
            this.mainContainer.ResumeLayout(false);
            this.contentArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwners)).EndInit();
            this.bottomBar.ResumeLayout(false);
            this.topBar.ResumeLayout(false);
            this.sideFilterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainContainer;
        private Guna.UI2.WinForms.Guna2Panel contentArea;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOwners;
        private Guna.UI2.WinForms.Guna2Panel bottomBar;
        private Guna.UI2.WinForms.Guna2Panel topBar;
        private Guna.UI2.WinForms.Guna2Panel sideFilterPanel;
        private System.Windows.Forms.Label lblFilterTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterPhone;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnClearFilter;
        private Guna.UI2.WinForms.Guna2Button btnApplyFilter;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.Label lblTotalOwners;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnView;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnPrevPage;
        private Guna.UI2.WinForms.Guna2Button btnNextPage;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOwnerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedAt;
    }
}