namespace RealEstateManagement
{
    partial class frmPropertyDetails
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
            this.btnEditProperty = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblPropertyID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlImageGalleryWrapper = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlImageGallery = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.lblValueDate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblValueBathrooms = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblValueRooms = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblValueArea = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblValueCity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblValueTransaction = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValueType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageFinancials = new System.Windows.Forms.TabPage();
            this.lblValueDLDFee = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblValueCommission = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblValuePrice = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPageDescription = new System.Windows.Forms.TabPage();
            this.pnlAmenities = new System.Windows.Forms.FlowLayoutPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.pnlRightInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAgentEmail = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblAgentPhone = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblAgentName = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblStatus = new Guna.UI2.WinForms.Guna2Button();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlTopBar.SuspendLayout();
            this.pnlImageGalleryWrapper.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.tabPageDetails.SuspendLayout();
            this.tabPageFinancials.SuspendLayout();
            this.tabPageDescription.SuspendLayout();
            this.pnlRightInfo.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.pnlTopBar.Controls.Add(this.btnEditProperty);
            this.pnlTopBar.Controls.Add(this.btnClose);
            this.pnlTopBar.Controls.Add(this.lblPropertyID);
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTopBar.Size = new System.Drawing.Size(1040, 70);
            this.pnlTopBar.TabIndex = 2;
            // 
            // btnEditProperty
            // 
            this.btnEditProperty.Animated = true;
            this.btnEditProperty.BorderRadius = 8;
            this.btnEditProperty.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditProperty.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditProperty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditProperty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditProperty.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditProperty.ForeColor = System.Drawing.Color.White;
            this.btnEditProperty.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(240)))));
            this.btnEditProperty.Location = new System.Drawing.Point(108, 17);
            this.btnEditProperty.Name = "btnEditProperty";
            this.btnEditProperty.Size = new System.Drawing.Size(120, 35);
            this.btnEditProperty.TabIndex = 6;
            this.btnEditProperty.Text = "تعديل العقار";
            this.btnEditProperty.Click += new System.EventHandler(this.btnEditProperty_Click);
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.BorderRadius = 8;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnClose.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.btnClose.Location = new System.Drawing.Point(12, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "إغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPropertyID
            // 
            this.lblPropertyID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPropertyID.Font = new System.Drawing.Font("Cairo", 10F);
            this.lblPropertyID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblPropertyID.Location = new System.Drawing.Point(802, 17);
            this.lblPropertyID.Name = "lblPropertyID";
            this.lblPropertyID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPropertyID.Size = new System.Drawing.Size(228, 21);
            this.lblPropertyID.TabIndex = 1;
            this.lblPropertyID.Text = "رقم العقار: 101";
            this.lblPropertyID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Cairo", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(400, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(628, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "فيلا فاخرة - نخلة جميرا";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlImageGalleryWrapper
            // 
            this.pnlImageGalleryWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlImageGalleryWrapper.BorderRadius = 15;
            this.pnlImageGalleryWrapper.Controls.Add(this.pnlImageGallery);
            this.pnlImageGalleryWrapper.Controls.Add(this.label13);
            this.pnlImageGalleryWrapper.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.pnlImageGalleryWrapper.Location = new System.Drawing.Point(15, 85);
            this.pnlImageGalleryWrapper.Name = "pnlImageGalleryWrapper";
            this.pnlImageGalleryWrapper.Padding = new System.Windows.Forms.Padding(15);
            this.pnlImageGalleryWrapper.Size = new System.Drawing.Size(684, 186);
            this.pnlImageGalleryWrapper.TabIndex = 3;
            // 
            // pnlImageGallery
            // 
            this.pnlImageGallery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlImageGallery.AutoScroll = true;
            this.pnlImageGallery.BackColor = System.Drawing.Color.Transparent;
            this.pnlImageGallery.Location = new System.Drawing.Point(18, 50);
            this.pnlImageGallery.Name = "pnlImageGallery";
            this.pnlImageGallery.Padding = new System.Windows.Forms.Padding(5);
            this.pnlImageGallery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlImageGallery.Size = new System.Drawing.Size(648, 120);
            this.pnlImageGallery.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label13.Location = new System.Drawing.Point(550, 15);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(116, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "صور العقار";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.guna2TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TabControl1.Controls.Add(this.tabPageDetails);
            this.guna2TabControl1.Controls.Add(this.tabPageFinancials);
            this.guna2TabControl1.Controls.Add(this.tabPageDescription);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 45);
            this.guna2TabControl1.Location = new System.Drawing.Point(15, 277);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(684, 341);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Cairo", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(164)))), ((int)(((byte)(166)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 45);
            this.guna2TabControl1.TabIndex = 4;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.VerticalRight;
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.tabPageDetails.Controls.Add(this.lblValueDate);
            this.tabPageDetails.Controls.Add(this.label12);
            this.tabPageDetails.Controls.Add(this.lblValueBathrooms);
            this.tabPageDetails.Controls.Add(this.label10);
            this.tabPageDetails.Controls.Add(this.lblValueRooms);
            this.tabPageDetails.Controls.Add(this.label8);
            this.tabPageDetails.Controls.Add(this.lblValueArea);
            this.tabPageDetails.Controls.Add(this.label6);
            this.tabPageDetails.Controls.Add(this.lblValueCity);
            this.tabPageDetails.Controls.Add(this.label4);
            this.tabPageDetails.Controls.Add(this.lblValueTransaction);
            this.tabPageDetails.Controls.Add(this.label2);
            this.tabPageDetails.Controls.Add(this.lblValueType);
            this.tabPageDetails.Controls.Add(this.label1);
            this.tabPageDetails.Location = new System.Drawing.Point(4, 4);
            this.tabPageDetails.Name = "tabPageDetails";
            this.tabPageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPageDetails.Size = new System.Drawing.Size(496, 333);
            this.tabPageDetails.TabIndex = 0;
            this.tabPageDetails.Text = "التفاصيل";
            // 
            // lblValueDate
            // 
            this.lblValueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValueDate.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.lblValueDate.ForeColor = System.Drawing.Color.White;
            this.lblValueDate.Location = new System.Drawing.Point(20, 240);
            this.lblValueDate.Name = "lblValueDate";
            this.lblValueDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValueDate.Size = new System.Drawing.Size(150, 30);
            this.lblValueDate.TabIndex = 13;
            this.lblValueDate.Text = "01/10/2024";
            this.lblValueDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Cairo", 9F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label12.Location = new System.Drawing.Point(20, 215);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(150, 25);
            this.label12.TabIndex = 12;
            this.label12.Text = "تاريخ الإضافة:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValueBathrooms
            // 
            this.lblValueBathrooms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValueBathrooms.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.lblValueBathrooms.ForeColor = System.Drawing.Color.White;
            this.lblValueBathrooms.Location = new System.Drawing.Point(180, 240);
            this.lblValueBathrooms.Name = "lblValueBathrooms";
            this.lblValueBathrooms.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValueBathrooms.Size = new System.Drawing.Size(120, 30);
            this.lblValueBathrooms.TabIndex = 11;
            this.lblValueBathrooms.Text = "7";
            this.lblValueBathrooms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Cairo", 9F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label10.Location = new System.Drawing.Point(180, 215);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(120, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "عدد الحمامات:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValueRooms
            // 
            this.lblValueRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValueRooms.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.lblValueRooms.ForeColor = System.Drawing.Color.White;
            this.lblValueRooms.Location = new System.Drawing.Point(320, 240);
            this.lblValueRooms.Name = "lblValueRooms";
            this.lblValueRooms.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValueRooms.Size = new System.Drawing.Size(150, 30);
            this.lblValueRooms.TabIndex = 9;
            this.lblValueRooms.Text = "6";
            this.lblValueRooms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Cairo", 9F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label8.Location = new System.Drawing.Point(320, 215);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(150, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "عدد الغرف:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValueArea
            // 
            this.lblValueArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValueArea.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.lblValueArea.ForeColor = System.Drawing.Color.White;
            this.lblValueArea.Location = new System.Drawing.Point(320, 160);
            this.lblValueArea.Name = "lblValueArea";
            this.lblValueArea.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValueArea.Size = new System.Drawing.Size(150, 30);
            this.lblValueArea.TabIndex = 7;
            this.lblValueArea.Text = "750.0 م²";
            this.lblValueArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Cairo", 9F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label6.Location = new System.Drawing.Point(320, 135);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(150, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "المساحة:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValueCity
            // 
            this.lblValueCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValueCity.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.lblValueCity.ForeColor = System.Drawing.Color.White;
            this.lblValueCity.Location = new System.Drawing.Point(20, 80);
            this.lblValueCity.Name = "lblValueCity";
            this.lblValueCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValueCity.Size = new System.Drawing.Size(150, 30);
            this.lblValueCity.TabIndex = 5;
            this.lblValueCity.Text = "دبي";
            this.lblValueCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Cairo", 9F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label4.Location = new System.Drawing.Point(20, 55);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "الموقع:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValueTransaction
            // 
            this.lblValueTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValueTransaction.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.lblValueTransaction.ForeColor = System.Drawing.Color.White;
            this.lblValueTransaction.Location = new System.Drawing.Point(180, 80);
            this.lblValueTransaction.Name = "lblValueTransaction";
            this.lblValueTransaction.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValueTransaction.Size = new System.Drawing.Size(120, 30);
            this.lblValueTransaction.TabIndex = 3;
            this.lblValueTransaction.Text = "للبيع";
            this.lblValueTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Cairo", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(180, 55);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "نوع المعاملة:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValueType
            // 
            this.lblValueType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValueType.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.lblValueType.ForeColor = System.Drawing.Color.White;
            this.lblValueType.Location = new System.Drawing.Point(320, 80);
            this.lblValueType.Name = "lblValueType";
            this.lblValueType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValueType.Size = new System.Drawing.Size(150, 30);
            this.lblValueType.TabIndex = 1;
            this.lblValueType.Text = "فيلا";
            this.lblValueType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Cairo", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label1.Location = new System.Drawing.Point(320, 55);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "نوع العقار:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPageFinancials
            // 
            this.tabPageFinancials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.tabPageFinancials.Controls.Add(this.lblValueDLDFee);
            this.tabPageFinancials.Controls.Add(this.label19);
            this.tabPageFinancials.Controls.Add(this.lblValueCommission);
            this.tabPageFinancials.Controls.Add(this.label17);
            this.tabPageFinancials.Controls.Add(this.lblValuePrice);
            this.tabPageFinancials.Controls.Add(this.label15);
            this.tabPageFinancials.Location = new System.Drawing.Point(4, 4);
            this.tabPageFinancials.Name = "tabPageFinancials";
            this.tabPageFinancials.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFinancials.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPageFinancials.Size = new System.Drawing.Size(496, 333);
            this.tabPageFinancials.TabIndex = 1;
            this.tabPageFinancials.Text = "المعلومات المالية";
            // 
            // lblValueDLDFee
            // 
            this.lblValueDLDFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValueDLDFee.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.lblValueDLDFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lblValueDLDFee.Location = new System.Drawing.Point(290, 240);
            this.lblValueDLDFee.Name = "lblValueDLDFee";
            this.lblValueDLDFee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValueDLDFee.Size = new System.Drawing.Size(180, 30);
            this.lblValueDLDFee.TabIndex = 5;
            this.lblValueDLDFee.Text = "-";
            this.lblValueDLDFee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.Font = new System.Drawing.Font("Cairo", 9F);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label19.Location = new System.Drawing.Point(290, 215);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label19.Size = new System.Drawing.Size(180, 25);
            this.label19.TabIndex = 4;
            this.label19.Text = "رسوم التسجيل:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValueCommission
            // 
            this.lblValueCommission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValueCommission.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.lblValueCommission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblValueCommission.Location = new System.Drawing.Point(290, 160);
            this.lblValueCommission.Name = "lblValueCommission";
            this.lblValueCommission.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValueCommission.Size = new System.Drawing.Size(180, 30);
            this.lblValueCommission.TabIndex = 3;
            this.lblValueCommission.Text = "750,000 ج.م";
            this.lblValueCommission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.Font = new System.Drawing.Font("Cairo", 9F);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label17.Location = new System.Drawing.Point(290, 135);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label17.Size = new System.Drawing.Size(180, 25);
            this.label17.TabIndex = 2;
            this.label17.Text = "العمولة:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValuePrice
            // 
            this.lblValuePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValuePrice.Font = new System.Drawing.Font("Cairo", 16F, System.Drawing.FontStyle.Bold);
            this.lblValuePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblValuePrice.Location = new System.Drawing.Point(200, 72);
            this.lblValuePrice.Name = "lblValuePrice";
            this.lblValuePrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValuePrice.Size = new System.Drawing.Size(270, 40);
            this.lblValuePrice.TabIndex = 1;
            this.lblValuePrice.Text = "15,000,000 ج.م";
            this.lblValuePrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.Font = new System.Drawing.Font("Cairo", 9F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label15.Location = new System.Drawing.Point(370, 47);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(100, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "السعر:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPageDescription
            // 
            this.tabPageDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.tabPageDescription.Controls.Add(this.pnlAmenities);
            this.tabPageDescription.Controls.Add(this.label21);
            this.tabPageDescription.Controls.Add(this.txtDescription);
            this.tabPageDescription.Controls.Add(this.label20);
            this.tabPageDescription.Location = new System.Drawing.Point(4, 4);
            this.tabPageDescription.Name = "tabPageDescription";
            this.tabPageDescription.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPageDescription.Size = new System.Drawing.Size(496, 333);
            this.tabPageDescription.TabIndex = 2;
            this.tabPageDescription.Text = "الوصف والمميزات";
            // 
            // pnlAmenities
            // 
            this.pnlAmenities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAmenities.BackColor = System.Drawing.Color.Transparent;
            this.pnlAmenities.Location = new System.Drawing.Point(18, 226);
            this.pnlAmenities.Name = "pnlAmenities";
            this.pnlAmenities.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlAmenities.Size = new System.Drawing.Size(460, 90);
            this.pnlAmenities.TabIndex = 3;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(388, 204);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label21.Size = new System.Drawing.Size(90, 19);
            this.label21.TabIndex = 2;
            this.label21.Text = "المميزات:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Location = new System.Drawing.Point(18, 47);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(460, 150);
            this.txtDescription.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(405, 25);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label20.Size = new System.Drawing.Size(73, 19);
            this.label20.TabIndex = 0;
            this.label20.Text = "الوصف:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlRightInfo
            // 
            this.pnlRightInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRightInfo.AutoScroll = true;
            this.pnlRightInfo.Controls.Add(this.guna2Panel3);
            this.pnlRightInfo.Controls.Add(this.guna2Panel1);
            this.pnlRightInfo.Location = new System.Drawing.Point(705, 85);
            this.pnlRightInfo.Name = "pnlRightInfo";
            this.pnlRightInfo.Padding = new System.Windows.Forms.Padding(5);
            this.pnlRightInfo.Size = new System.Drawing.Size(323, 533);
            this.pnlRightInfo.TabIndex = 5;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderRadius = 15;
            this.guna2Panel3.Controls.Add(this.lblAgentEmail);
            this.guna2Panel3.Controls.Add(this.label24);
            this.guna2Panel3.Controls.Add(this.lblAgentPhone);
            this.guna2Panel3.Controls.Add(this.label23);
            this.guna2Panel3.Controls.Add(this.lblAgentName);
            this.guna2Panel3.Controls.Add(this.label22);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.guna2Panel3.Location = new System.Drawing.Point(5, 175);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Padding = new System.Windows.Forms.Padding(15);
            this.guna2Panel3.Size = new System.Drawing.Size(310, 200);
            this.guna2Panel3.TabIndex = 1;
            // 
            // lblAgentEmail
            // 
            this.lblAgentEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAgentEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblAgentEmail.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.lblAgentEmail.ForeColor = System.Drawing.Color.White;
            this.lblAgentEmail.Location = new System.Drawing.Point(16, 160);
            this.lblAgentEmail.Name = "lblAgentEmail";
            this.lblAgentEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAgentEmail.Size = new System.Drawing.Size(278, 25);
            this.lblAgentEmail.TabIndex = 5;
            this.lblAgentEmail.Text = "العنوان";
            this.lblAgentEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Cairo", 9F);
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label24.Location = new System.Drawing.Point(220, 135);
            this.label24.Name = "label24";
            this.label24.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label24.Size = new System.Drawing.Size(74, 25);
            this.label24.TabIndex = 4;
            this.label24.Text = "العنوان:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAgentPhone
            // 
            this.lblAgentPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAgentPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblAgentPhone.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.lblAgentPhone.ForeColor = System.Drawing.Color.White;
            this.lblAgentPhone.Location = new System.Drawing.Point(16, 105);
            this.lblAgentPhone.Name = "lblAgentPhone";
            this.lblAgentPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAgentPhone.Size = new System.Drawing.Size(278, 25);
            this.lblAgentPhone.TabIndex = 3;
            this.lblAgentPhone.Text = "+971 50 123456";
            this.lblAgentPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Cairo", 9F);
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label23.Location = new System.Drawing.Point(228, 80);
            this.label23.Name = "label23";
            this.label23.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label23.Size = new System.Drawing.Size(66, 25);
            this.label23.TabIndex = 2;
            this.label23.Text = "الهاتف:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAgentName
            // 
            this.lblAgentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAgentName.BackColor = System.Drawing.Color.Transparent;
            this.lblAgentName.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.lblAgentName.ForeColor = System.Drawing.Color.White;
            this.lblAgentName.Location = new System.Drawing.Point(80, 45);
            this.lblAgentName.Name = "lblAgentName";
            this.lblAgentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAgentName.Size = new System.Drawing.Size(214, 30);
            this.lblAgentName.TabIndex = 1;
            this.lblAgentName.Text = "اسم المالك";
            this.lblAgentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label22.Location = new System.Drawing.Point(170, 15);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label22.Size = new System.Drawing.Size(124, 25);
            this.label22.TabIndex = 0;
            this.label22.Text = "بيانات المالك";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.lblStatus);
            this.guna2Panel1.Controls.Add(this.label14);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.guna2Panel1.Location = new System.Drawing.Point(5, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(15);
            this.guna2Panel1.Size = new System.Drawing.Size(310, 160);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Animated = true;
            this.lblStatus.BorderRadius = 10;
            this.lblStatus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lblStatus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lblStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lblStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.lblStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblStatus.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(65, 80);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(180, 50);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "متاح";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Cairo", 11F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label14.Location = new System.Drawing.Point(170, 15);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(124, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "حالة العقار";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmPropertyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1040, 630);
            this.Controls.Add(this.pnlRightInfo);
            this.Controls.Add(this.guna2TabControl1);
            this.Controls.Add(this.pnlImageGalleryWrapper);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPropertyDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفاصيل العقار";
            this.Load += new System.EventHandler(this.frmPropertyDetails_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlImageGalleryWrapper.ResumeLayout(false);
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPageDetails.ResumeLayout(false);
            this.tabPageFinancials.ResumeLayout(false);
            this.tabPageDescription.ResumeLayout(false);
            this.pnlRightInfo.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlImageGalleryWrapper;
        private System.Windows.Forms.Label lblPropertyID;
        private System.Windows.Forms.FlowLayoutPanel pnlImageGallery;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPageDetails;
        private System.Windows.Forms.TabPage tabPageFinancials;
        private System.Windows.Forms.TabPage tabPageDescription;
        private Guna.UI2.WinForms.Guna2Panel pnlRightInfo;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnEditProperty;
        private System.Windows.Forms.Label lblValueType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValueTransaction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValueCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblValueArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblValueRooms;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblValueBathrooms;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblValueDate;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Button lblStatus;
        private System.Windows.Forms.Label lblValuePrice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblValueCommission;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblValueDLDFee;
        private System.Windows.Forms.Label label19;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.FlowLayoutPanel pnlAmenities;
        private System.Windows.Forms.Label label21;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label lblAgentName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblAgentPhone;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblAgentEmail;
        private System.Windows.Forms.Label label24;
    }
}