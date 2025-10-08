namespace RealEstateManagement
{
    partial class frmOwnerDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSendMessage = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblOwnerId = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlDetails = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDateJoined = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblContactAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblContactPhone = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblContactEmail = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlProperties = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPropertyCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvProperties = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btnViewContract = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.pnlProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.pnlHeader.Controls.Add(this.btnSendMessage);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblOwnerId);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(950, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSendMessage.Animated = true;
            this.btnSendMessage.BorderRadius = 8;
            this.btnSendMessage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSendMessage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSendMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSendMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSendMessage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSendMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSendMessage.ForeColor = System.Drawing.Color.White;
            this.btnSendMessage.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(240)))));
            this.btnSendMessage.Location = new System.Drawing.Point(135, 20);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(140, 35);
            this.btnSendMessage.TabIndex = 4;
            this.btnSendMessage.Text = "إرسال رسالة/تنبيه";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Animated = true;
            this.btnClose.BorderRadius = 8;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnClose.Location = new System.Drawing.Point(15, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "إغلاق العرض";
            // 
            // lblOwnerId
            // 
            this.lblOwnerId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOwnerId.AutoSize = true;
            this.lblOwnerId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblOwnerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblOwnerId.Location = new System.Drawing.Point(830, 42);
            this.lblOwnerId.Name = "lblOwnerId";
            this.lblOwnerId.Size = new System.Drawing.Size(97, 19);
            this.lblOwnerId.TabIndex = 2;
            this.lblOwnerId.Text = "هوية المالك: 0";
            this.lblOwnerId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(753, 5);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(175, 37);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "[اسم المالك]";
            this.lblHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.lblDateJoined);
            this.pnlDetails.Controls.Add(this.label7);
            this.pnlDetails.Controls.Add(this.lblContactAddress);
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.lblContactPhone);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.lblContactEmail);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.pnlDetails.Location = new System.Drawing.Point(0, 70);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Padding = new System.Windows.Forms.Padding(15);
            this.pnlDetails.Size = new System.Drawing.Size(950, 150);
            this.pnlDetails.TabIndex = 1;
            // 
            // lblDateJoined
            // 
            this.lblDateJoined.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateJoined.AutoSize = true;
            this.lblDateJoined.BackColor = System.Drawing.Color.Transparent;
            this.lblDateJoined.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateJoined.ForeColor = System.Drawing.Color.White;
            this.lblDateJoined.Location = new System.Drawing.Point(741, 115);
            this.lblDateJoined.Name = "lblDateJoined";
            this.lblDateJoined.Size = new System.Drawing.Size(117, 19);
            this.lblDateJoined.TabIndex = 9;
            this.lblDateJoined.Text = "[DD/MM/YYYY]";
            this.lblDateJoined.RightToLeft = System.Windows.Forms.RightToLeft.No; // Date is usually LTR
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(845, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "تاريخ التسجيل:";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // lblContactAddress
            // 
            this.lblContactAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContactAddress.AutoSize = true;
            this.lblContactAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblContactAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblContactAddress.ForeColor = System.Drawing.Color.White;
            this.lblContactAddress.Location = new System.Drawing.Point(407, 85);
            this.lblContactAddress.Name = "lblContactAddress";
            this.lblContactAddress.Size = new System.Drawing.Size(76, 19);
            this.lblContactAddress.TabIndex = 7;
            this.lblContactAddress.Text = "[العنوان]";
            this.lblContactAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(882, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "العنوان:";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // lblContactPhone
            // 
            this.lblContactPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContactPhone.Animated = true;
            this.lblContactPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblContactPhone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lblContactPhone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lblContactPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.lblContactPhone.DisabledState.ForeColor = System.Drawing.Color.White;
            this.lblContactPhone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.lblContactPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblContactPhone.ForeColor = System.Drawing.Color.White;
            this.lblContactPhone.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.lblContactPhone.HoverState.ForeColor = System.Drawing.Color.LightBlue;
            this.lblContactPhone.Location = new System.Drawing.Point(730, 52);
            this.lblContactPhone.Name = "lblContactPhone";
            this.lblContactPhone.Size = new System.Drawing.Size(100, 25);
            this.lblContactPhone.TabIndex = 5;
            this.lblContactPhone.Text = "[Phone]";
            this.lblContactPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right; // Right alignment for RTL display of LTR number
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(882, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "الهاتف:";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // lblContactEmail
            // 
            this.lblContactEmail.Animated = true;
            this.lblContactEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblContactEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lblContactEmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lblContactEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.lblContactEmail.DisabledState.ForeColor = System.Drawing.Color.White;
            this.lblContactEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.lblContactEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblContactEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblContactEmail.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.lblContactEmail.HoverState.ForeColor = System.Drawing.Color.LightBlue;
            this.lblContactEmail.Location = new System.Drawing.Point(15, 52);
            this.lblContactEmail.Name = "lblContactEmail";
            this.lblContactEmail.Size = new System.Drawing.Size(220, 25);
            this.lblContactEmail.TabIndex = 3;
            this.lblContactEmail.Text = "[Email]";
            this.lblContactEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left; // Email is LTR
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(234, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "الإيميل:";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(821, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "بيانات الاتصال";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // pnlProperties
            // 
            this.pnlProperties.Controls.Add(this.btnViewContract);
            this.pnlProperties.Controls.Add(this.lblPropertyCount);
            this.pnlProperties.Controls.Add(this.label9);
            this.pnlProperties.Controls.Add(this.dgvProperties);
            this.pnlProperties.Controls.Add(this.label10);
            this.pnlProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProperties.Location = new System.Drawing.Point(0, 220);
            this.pnlProperties.Name = "pnlProperties";
            this.pnlProperties.Padding = new System.Windows.Forms.Padding(15);
            this.pnlProperties.Size = new System.Drawing.Size(950, 380);
            this.pnlProperties.TabIndex = 2;
            // 
            // lblPropertyCount
            // 
            this.lblPropertyCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPropertyCount.AutoSize = true;
            this.lblPropertyCount.BackColor = System.Drawing.Color.Transparent;
            this.lblPropertyCount.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPropertyCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblPropertyCount.Location = new System.Drawing.Point(600, 17);
            this.lblPropertyCount.Name = "lblPropertyCount";
            this.lblPropertyCount.Size = new System.Drawing.Size(125, 19);
            this.lblPropertyCount.TabIndex = 13;
            this.lblPropertyCount.Text = "[عدد العقارات N]";
            this.lblPropertyCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(727, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "الوحدات العقارية المملوكة";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // dgvProperties
            // 
            this.dgvProperties.AllowUserToAddRows = false;
            this.dgvProperties.AllowUserToDeleteRows = false;
            this.dgvProperties.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvProperties.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProperties.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProperties.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProperties.ColumnHeadersHeight = 40;
            this.dgvProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProperties.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProperties.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.dgvProperties.Location = new System.Drawing.Point(15, 45);
            this.dgvProperties.MultiSelect = false;
            this.dgvProperties.Name = "dgvProperties";
            this.dgvProperties.ReadOnly = true;
            this.dgvProperties.RowHeadersVisible = false;
            this.dgvProperties.RowTemplate.Height = 35;
            this.dgvProperties.Size = new System.Drawing.Size(920, 320);
            this.dgvProperties.TabIndex = 3;
            this.dgvProperties.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.dgvProperties.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProperties.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProperties.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProperties.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProperties.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.dgvProperties.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.dgvProperties.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.dgvProperties.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProperties.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvProperties.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProperties.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProperties.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvProperties.ThemeStyle.ReadOnly = true;
            this.dgvProperties.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.dgvProperties.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProperties.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvProperties.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProperties.ThemeStyle.RowsStyle.Height = 35;
            this.dgvProperties.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dgvProperties.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 21);
            this.label10.TabIndex = 2;
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // btnViewContract
            // 
            this.btnViewContract.Animated = true;
            this.btnViewContract.BorderRadius = 8;
            this.btnViewContract.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewContract.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewContract.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewContract.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewContract.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnViewContract.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnViewContract.ForeColor = System.Drawing.Color.White;
            this.btnViewContract.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnViewContract.Location = new System.Drawing.Point(15, 10);
            this.btnViewContract.Name = "btnViewContract";
            this.btnViewContract.Size = new System.Drawing.Size(130, 30);
            this.btnViewContract.TabIndex = 14;
            this.btnViewContract.Text = "عرض بيانات العقار";
            // 
            // frmOwnerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.pnlProperties);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOwnerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تفاصيل المالك";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlProperties.ResumeLayout(false);
            this.pnlProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblOwnerId;
        private System.Windows.Forms.Label lblHeader;
        private Guna.UI2.WinForms.Guna2Panel pnlDetails;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel pnlProperties;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button lblContactEmail;
        private Guna.UI2.WinForms.Guna2Button lblContactPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblContactAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDateJoined;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProperties;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button btnSendMessage;
        private System.Windows.Forms.Label lblPropertyCount;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnViewContract; // Renamed from btnViewContract
    }
}