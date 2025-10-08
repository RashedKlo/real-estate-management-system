namespace RealEstateManagement
{
    partial class frmSplash
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.mainPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.contentPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblLoadingPercent = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.progressBar = new RealEstateManagement.RightToLeftProgressBar();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.logoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.logoPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.footerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.mainPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.footerPanel.SuspendLayout();
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
            this.guna2DragControl1.TargetControl = this.mainPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // mainPanel
            // 
            this.mainPanel.BorderRadius = 20;
            this.mainPanel.Controls.Add(this.contentPanel);
            this.mainPanel.Controls.Add(this.footerPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.mainPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.mainPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(900, 550);
            this.mainPanel.TabIndex = 0;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.Transparent;
            this.contentPanel.Controls.Add(this.guna2Panel1);
            this.contentPanel.Controls.Add(this.lblSubtitle);
            this.contentPanel.Controls.Add(this.lblTitle);
            this.contentPanel.Controls.Add(this.logoPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contentPanel.Size = new System.Drawing.Size(900, 490);
            this.contentPanel.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.lblLoadingPercent);
            this.guna2Panel1.Controls.Add(this.lblLoading);
            this.guna2Panel1.Controls.Add(this.progressBar);
            this.guna2Panel1.Location = new System.Drawing.Point(150, 360);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2Panel1.Size = new System.Drawing.Size(600, 100);
            this.guna2Panel1.TabIndex = 3;
            // 
            // lblLoadingPercent
            // 
            this.lblLoadingPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblLoadingPercent.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblLoadingPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblLoadingPercent.Location = new System.Drawing.Point(20, 10);
            this.lblLoadingPercent.Name = "lblLoadingPercent";
            this.lblLoadingPercent.Size = new System.Drawing.Size(60, 25);
            this.lblLoadingPercent.TabIndex = 2;
            this.lblLoadingPercent.Text = "0%";
            this.lblLoadingPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLoading
            // 
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblLoading.Location = new System.Drawing.Point(280, 10);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLoading.Size = new System.Drawing.Size(300, 25);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Text = "جارٍ تهيئة التطبيق...";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.BorderRadius = 12;
            this.progressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.progressBar.Location = new System.Drawing.Point(20, 50);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.progressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.progressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar.ShadowDecoration.Enabled = true;
            this.progressBar.Size = new System.Drawing.Size(560, 25);
            this.progressBar.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblSubtitle.Location = new System.Drawing.Point(250, 300);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(400, 40);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "نظام إدارة العقارات";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(200, 230);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 70);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "عقاراتي";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.Transparent;
            this.logoPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.logoPanel.BorderRadius = 50;
            this.logoPanel.BorderThickness = 3;
            this.logoPanel.Controls.Add(this.logoPicture);
            this.logoPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.logoPanel.Location = new System.Drawing.Point(375, 60);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(150, 150);
            this.logoPanel.TabIndex = 0;
            // 
            // logoPicture
            // 
            this.logoPicture.BackColor = System.Drawing.Color.Transparent;
            this.logoPicture.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.logoPicture.ImageRotate = 0F;
            this.logoPicture.Location = new System.Drawing.Point(25, 25);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.logoPicture.Size = new System.Drawing.Size(100, 100);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicture.TabIndex = 0;
            this.logoPicture.TabStop = false;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.Transparent;
            this.footerPanel.Controls.Add(this.lblCopyright);
            this.footerPanel.Controls.Add(this.lblVersion);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 490);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.footerPanel.Size = new System.Drawing.Size(900, 60);
            this.footerPanel.TabIndex = 0;
            // 
            // lblCopyright
            // 
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblCopyright.Location = new System.Drawing.Point(250, 30);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(400, 20);
            this.lblCopyright.TabIndex = 1;
            this.lblCopyright.Text = "© 2025 جميع الحقوق محفوظة لشركتك.";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblVersion.Location = new System.Drawing.Point(380, 10);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(140, 20);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "الإصدار 1.0.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 25;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام إدارة العقارات";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.mainPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.footerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel mainPanel;
        private Guna.UI2.WinForms.Guna2Panel footerPanel;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblVersion;
        private Guna.UI2.WinForms.Guna2Panel contentPanel;
        private Guna.UI2.WinForms.Guna2Panel logoPanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox logoPicture;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblLoading;
        private RealEstateManagement.RightToLeftProgressBar progressBar;
        private System.Windows.Forms.Label lblLoadingPercent;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
    }
}
