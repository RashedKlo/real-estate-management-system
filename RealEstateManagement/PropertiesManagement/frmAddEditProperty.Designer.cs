

namespace RealEstateManagement
{
    partial class frmAddEditProperty
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
            this.pnlTopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMainContent = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlOwnerSection = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSelectedOwner = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClearOwner = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreateOwner = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchOwner = new Guna.UI2.WinForms.Guna2Button();
            this.lblOwnerTitle = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtRooms = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtArea = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFinancialsTitle = new System.Windows.Forms.Label();
            this.pnlGeneralInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUploadImage = new Guna.UI2.WinForms.Guna2Button();
            this.cmbCity = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTransactionType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitleInput = new System.Windows.Forms.Label();
            this.lblGeneralTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTopBar.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.pnlOwnerSection.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.pnlGeneralInfo.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.pnlTopBar.Size = new System.Drawing.Size(1040, 70);
            this.pnlTopBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Cairo", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(342, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(330, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إضافة عقار جديد";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.AutoScroll = true;
            this.pnlMainContent.Controls.Add(this.pnlOwnerSection);
            this.pnlMainContent.Controls.Add(this.guna2Panel2);
            this.pnlMainContent.Controls.Add(this.pnlGeneralInfo);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 70);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMainContent.Size = new System.Drawing.Size(1040, 490);
            this.pnlMainContent.TabIndex = 2;
            // 
            // pnlOwnerSection
            // 
            this.pnlOwnerSection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOwnerSection.BorderRadius = 12;
            this.pnlOwnerSection.Controls.Add(this.txtSelectedOwner);
            this.pnlOwnerSection.Controls.Add(this.btnClearOwner);
            this.pnlOwnerSection.Controls.Add(this.btnCreateOwner);
            this.pnlOwnerSection.Controls.Add(this.btnSearchOwner);
            this.pnlOwnerSection.Controls.Add(this.lblOwnerTitle);
            this.pnlOwnerSection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.pnlOwnerSection.Location = new System.Drawing.Point(20, 470);
            this.pnlOwnerSection.Name = "pnlOwnerSection";
            this.pnlOwnerSection.Padding = new System.Windows.Forms.Padding(20);
            this.pnlOwnerSection.Size = new System.Drawing.Size(1000, 140);
            this.pnlOwnerSection.TabIndex = 3;
            // 
            // txtSelectedOwner
            // 
            this.txtSelectedOwner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedOwner.Animated = true;
            this.txtSelectedOwner.BackColor = System.Drawing.Color.Transparent;
            this.txtSelectedOwner.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.txtSelectedOwner.BorderRadius = 8;
            this.txtSelectedOwner.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSelectedOwner.DefaultText = "";
            this.txtSelectedOwner.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSelectedOwner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSelectedOwner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSelectedOwner.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSelectedOwner.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.txtSelectedOwner.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSelectedOwner.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtSelectedOwner.ForeColor = System.Drawing.Color.White;
            this.txtSelectedOwner.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSelectedOwner.Location = new System.Drawing.Point(20, 19);
            this.txtSelectedOwner.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSelectedOwner.Name = "txtSelectedOwner";
            this.txtSelectedOwner.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtSelectedOwner.PlaceholderText = "لم يتم اختيار مالك بعد";
            this.txtSelectedOwner.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSelectedOwner.SelectedText = "";
            this.txtSelectedOwner.Size = new System.Drawing.Size(261, 36);
            this.txtSelectedOwner.TabIndex = 4;
            // 
            // btnClearOwner
            // 
            this.btnClearOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearOwner.Animated = true;
            this.btnClearOwner.BorderRadius = 8;
            this.btnClearOwner.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearOwner.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearOwner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearOwner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearOwner.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnClearOwner.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.btnClearOwner.ForeColor = System.Drawing.Color.White;
            this.btnClearOwner.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnClearOwner.Location = new System.Drawing.Point(20, 80);
            this.btnClearOwner.Name = "btnClearOwner";
            this.btnClearOwner.Size = new System.Drawing.Size(150, 40);
            this.btnClearOwner.TabIndex = 3;
            this.btnClearOwner.Text = "مسح الاختيار";
            this.btnClearOwner.Click += new System.EventHandler(this.btnClearOwner_Click);
            // 
            // btnCreateOwner
            // 
            this.btnCreateOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateOwner.Animated = true;
            this.btnCreateOwner.BorderRadius = 8;
            this.btnCreateOwner.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateOwner.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateOwner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateOwner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateOwner.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnCreateOwner.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.btnCreateOwner.ForeColor = System.Drawing.Color.White;
            this.btnCreateOwner.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(140)))), ((int)(((byte)(56)))));
            this.btnCreateOwner.Location = new System.Drawing.Point(650, 80);
            this.btnCreateOwner.Name = "btnCreateOwner";
            this.btnCreateOwner.Size = new System.Drawing.Size(150, 40);
            this.btnCreateOwner.TabIndex = 2;
            this.btnCreateOwner.Text = "إنشاء مالك جديد";
            this.btnCreateOwner.Click += new System.EventHandler(this.btnCreateOwner_Click);
            // 
            // btnSearchOwner
            // 
            this.btnSearchOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchOwner.Animated = true;
            this.btnSearchOwner.BorderRadius = 8;
            this.btnSearchOwner.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchOwner.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchOwner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchOwner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchOwner.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearchOwner.ForeColor = System.Drawing.Color.White;
            this.btnSearchOwner.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(240)))));
            this.btnSearchOwner.Location = new System.Drawing.Point(810, 80);
            this.btnSearchOwner.Name = "btnSearchOwner";
            this.btnSearchOwner.Size = new System.Drawing.Size(150, 40);
            this.btnSearchOwner.TabIndex = 1;
            this.btnSearchOwner.Text = "البحث عن مالك";
            this.btnSearchOwner.Click += new System.EventHandler(this.btnSearchOwner_Click);
            // 
            // lblOwnerTitle
            // 
            this.lblOwnerTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOwnerTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblOwnerTitle.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.lblOwnerTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblOwnerTitle.Location = new System.Drawing.Point(850, 25);
            this.lblOwnerTitle.Name = "lblOwnerTitle";
            this.lblOwnerTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblOwnerTitle.Size = new System.Drawing.Size(130, 30);
            this.lblOwnerTitle.TabIndex = 0;
            this.lblOwnerTitle.Text = "مالك العقار";
            this.lblOwnerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BorderRadius = 12;
            this.guna2Panel2.Controls.Add(this.txtRooms);
            this.guna2Panel2.Controls.Add(this.label7);
            this.guna2Panel2.Controls.Add(this.txtArea);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.txtPrice);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.lblFinancialsTitle);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.guna2Panel2.Location = new System.Drawing.Point(20, 330);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(20);
            this.guna2Panel2.Size = new System.Drawing.Size(1000, 130);
            this.guna2Panel2.TabIndex = 1;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // txtRooms
            // 
            this.txtRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRooms.Animated = true;
            this.txtRooms.BackColor = System.Drawing.Color.Transparent;
            this.txtRooms.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.txtRooms.BorderRadius = 8;
            this.txtRooms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRooms.DefaultText = "";
            this.txtRooms.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRooms.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRooms.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.txtRooms.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRooms.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtRooms.ForeColor = System.Drawing.Color.White;
            this.txtRooms.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRooms.Location = new System.Drawing.Point(760, 70);
            this.txtRooms.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtRooms.Name = "txtRooms";
            this.txtRooms.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtRooms.PlaceholderText = "مثال: 4";
            this.txtRooms.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRooms.SelectedText = "";
            this.txtRooms.Size = new System.Drawing.Size(200, 36);
            this.txtRooms.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cairo", 9F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label7.Location = new System.Drawing.Point(880, 45);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "عدد الغرف:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtArea
            // 
            this.txtArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArea.Animated = true;
            this.txtArea.BackColor = System.Drawing.Color.Transparent;
            this.txtArea.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.txtArea.BorderRadius = 8;
            this.txtArea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArea.DefaultText = "";
            this.txtArea.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.txtArea.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtArea.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtArea.ForeColor = System.Drawing.Color.White;
            this.txtArea.Location = new System.Drawing.Point(380, 70);
            this.txtArea.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtArea.Name = "txtArea";
            this.txtArea.PlaceholderText = "المساحة";
            this.txtArea.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtArea.SelectedText = "";
            this.txtArea.Size = new System.Drawing.Size(300, 36);
            this.txtArea.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cairo", 9F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label6.Location = new System.Drawing.Point(560, 45);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "المساحة (م²):";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrice
            // 
            this.txtPrice.Animated = true;
            this.txtPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.txtPrice.BorderRadius = 8;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(20, 70);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderText = "السعر";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(300, 36);
            this.txtPrice.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cairo", 9F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label5.Location = new System.Drawing.Point(240, 45);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "السعر:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFinancialsTitle
            // 
            this.lblFinancialsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFinancialsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFinancialsTitle.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.lblFinancialsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblFinancialsTitle.Location = new System.Drawing.Point(820, 20);
            this.lblFinancialsTitle.Name = "lblFinancialsTitle";
            this.lblFinancialsTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFinancialsTitle.Size = new System.Drawing.Size(160, 30);
            this.lblFinancialsTitle.TabIndex = 0;
            this.lblFinancialsTitle.Text = "التفاصيل المالية والفنية";
            this.lblFinancialsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlGeneralInfo
            // 
            this.pnlGeneralInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGeneralInfo.BorderRadius = 12;
            this.pnlGeneralInfo.Controls.Add(this.btnUploadImage);
            this.pnlGeneralInfo.Controls.Add(this.cmbCity);
            this.pnlGeneralInfo.Controls.Add(this.label4);
            this.pnlGeneralInfo.Controls.Add(this.cmbTransactionType);
            this.pnlGeneralInfo.Controls.Add(this.label1);
            this.pnlGeneralInfo.Controls.Add(this.txtDescription);
            this.pnlGeneralInfo.Controls.Add(this.label2);
            this.pnlGeneralInfo.Controls.Add(this.txtTitle);
            this.pnlGeneralInfo.Controls.Add(this.lblTitleInput);
            this.pnlGeneralInfo.Controls.Add(this.lblGeneralTitle);
            this.pnlGeneralInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.pnlGeneralInfo.Location = new System.Drawing.Point(20, 20);
            this.pnlGeneralInfo.Name = "pnlGeneralInfo";
            this.pnlGeneralInfo.Padding = new System.Windows.Forms.Padding(20);
            this.pnlGeneralInfo.Size = new System.Drawing.Size(1000, 300);
            this.pnlGeneralInfo.TabIndex = 0;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUploadImage.Animated = true;
            this.btnUploadImage.BorderRadius = 8;
            this.btnUploadImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUploadImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUploadImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUploadImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUploadImage.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.btnUploadImage.ForeColor = System.Drawing.Color.White;
            this.btnUploadImage.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(240)))));
            this.btnUploadImage.Location = new System.Drawing.Point(20, 251);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(150, 40);
            this.btnUploadImage.TabIndex = 11;
            this.btnUploadImage.Text = "تحميل صورة";
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // cmbCity
            // 
            this.cmbCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCity.BackColor = System.Drawing.Color.Transparent;
            this.cmbCity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.cmbCity.BorderRadius = 8;
            this.cmbCity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.cmbCity.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCity.Font = new System.Drawing.Font("Cairo", 9F);
            this.cmbCity.ForeColor = System.Drawing.Color.White;
            this.cmbCity.ItemHeight = 30;
            this.cmbCity.Location = new System.Drawing.Point(656, 255);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbCity.Size = new System.Drawing.Size(320, 36);
            this.cmbCity.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cairo", 9F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label4.Location = new System.Drawing.Point(900, 225);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "المدينة:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbTransactionType
            // 
            this.cmbTransactionType.BackColor = System.Drawing.Color.Transparent;
            this.cmbTransactionType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.cmbTransactionType.BorderRadius = 8;
            this.cmbTransactionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransactionType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.cmbTransactionType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTransactionType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTransactionType.Font = new System.Drawing.Font("Cairo", 9F);
            this.cmbTransactionType.ForeColor = System.Drawing.Color.White;
            this.cmbTransactionType.ItemHeight = 30;
            this.cmbTransactionType.Location = new System.Drawing.Point(196, 255);
            this.cmbTransactionType.Name = "cmbTransactionType";
            this.cmbTransactionType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbTransactionType.Size = new System.Drawing.Size(320, 36);
            this.cmbTransactionType.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cairo", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label1.Location = new System.Drawing.Point(396, 230);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "نوع المعاملة:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Animated = true;
            this.txtDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.txtDescription.BorderRadius = 8;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(20, 140);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "وصف تفصيلي للعقار";
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(960, 80);
            this.txtDescription.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cairo", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(900, 115);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "الوصف:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Animated = true;
            this.txtTitle.BackColor = System.Drawing.Color.Transparent;
            this.txtTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.txtTitle.BorderRadius = 8;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(20, 70);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PlaceholderText = "مثال: شقة جميلة بثلاث غرف نوم مطلة على المحيط";
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTitle.SelectedText = "";
            this.txtTitle.Size = new System.Drawing.Size(960, 36);
            this.txtTitle.TabIndex = 2;
            // 
            // lblTitleInput
            // 
            this.lblTitleInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleInput.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleInput.Font = new System.Drawing.Font("Cairo", 9F);
            this.lblTitleInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblTitleInput.Location = new System.Drawing.Point(860, 45);
            this.lblTitleInput.Name = "lblTitleInput";
            this.lblTitleInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitleInput.Size = new System.Drawing.Size(120, 25);
            this.lblTitleInput.TabIndex = 1;
            this.lblTitleInput.Text = "موقع العقار:";
            this.lblTitleInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGeneralTitle
            // 
            this.lblGeneralTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGeneralTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGeneralTitle.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.lblGeneralTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblGeneralTitle.Location = new System.Drawing.Point(800, 20);
            this.lblGeneralTitle.Name = "lblGeneralTitle";
            this.lblGeneralTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGeneralTitle.Size = new System.Drawing.Size(180, 30);
            this.lblGeneralTitle.TabIndex = 0;
            this.lblGeneralTitle.Text = "المعلومات العامة";
            this.lblGeneralTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.pnlFooter.Location = new System.Drawing.Point(0, 560);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(20);
            this.pnlFooter.Size = new System.Drawing.Size(1040, 70);
            this.pnlFooter.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCancel.BorderRadius = 8;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.FillColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCancel.Location = new System.Drawing.Point(157, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BorderRadius = 8;
            this.btnSave.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(20, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "حفظ العقار";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1040, 630);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditProperty";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة/تعديل عقار";
            this.Load += new System.EventHandler(this.frmAddEditProperty_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlMainContent.ResumeLayout(false);
            this.pnlOwnerSection.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.pnlGeneralInfo.ResumeLayout(false);
            this.pnlGeneralInfo.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlMainContent;
        private Guna.UI2.WinForms.Guna2Panel pnlGeneralInfo;
        private System.Windows.Forms.Label lblGeneralTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlFooter;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private System.Windows.Forms.Label lblTitleInput;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTransactionType;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCity;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lblFinancialsTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtRooms;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtArea;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel pnlOwnerSection;
        private System.Windows.Forms.Label lblOwnerTitle;
        private Guna.UI2.WinForms.Guna2Button btnSearchOwner;
        private Guna.UI2.WinForms.Guna2Button btnCreateOwner;
        private Guna.UI2.WinForms.Guna2Button btnUploadImage;
        private Guna.UI2.WinForms.Guna2Button btnClearOwner;
        private Guna.UI2.WinForms.Guna2TextBox txtSelectedOwner;
    }
}