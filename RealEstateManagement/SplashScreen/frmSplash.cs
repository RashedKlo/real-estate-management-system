// frmSplash.cs - Clean Version Without Fade, Smooth and Instant Transition
using System;
using System.Windows.Forms;

namespace RealEstateManagement
{
    public partial class frmSplash : Form
    {
        private Timer splashTimer;
        private int progressValue = 0;

        public frmSplash()
        {
            InitializeComponent();
            InitializeTimers();
            SetupAnimations();
        }

        private void InitializeTimers()
        {
            // Timer for progress updates
            splashTimer = new Timer
            {
                Interval = 25 // Smooth update every 25ms
            };
            splashTimer.Tick += SplashTimer_Tick;
        }

        private void SetupAnimations()
        {
            // Ensure centered display
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
                    splashTimer.Start(); // Start progress after logo animation
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            progressValue += 1;

            // Update progress bar
            if (progressBar != null)
            {
                progressBar.Value = progressValue;
                lblLoadingPercent.Text = progressValue + "%";
            }

            // Arabic loading messages
            if (lblLoading != null)
            {
                if (progressValue < 15)
                    lblLoading.Text = "جارٍ تهيئة التطبيق...";
                else if (progressValue < 30)
                    lblLoading.Text = "جارٍ تحميل الموارد...";
                else if (progressValue < 45)
                    lblLoading.Text = "جارٍ الاتصال بقاعدة البيانات...";
                else if (progressValue < 60)
                    lblLoading.Text = "جارٍ التحقق من الإعدادات...";
                else if (progressValue < 75)
                    lblLoading.Text = "جارٍ تحميل الوحدات...";
                else if (progressValue < 90)
                    lblLoading.Text = "جارٍ تجهيز واجهة المستخدم...";
                else if (progressValue < 100)
                    lblLoading.Text = "جارٍ إنهاء الإعداد...";
                else
                    lblLoading.Text = "جاهز! يتم تشغيل التطبيق...";
            }

            // Once progress completes
            if (progressValue >= 100)
            {
                splashTimer.Stop();

                    OpenNextForm();
               
            }
        }

        private  void  OpenNextForm()
        {

            this.Hide();
            // Initialize and open login form
            frmLogin loginForm = new frmLogin
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            loginForm.ShowDialog();
         

            // Optional: go to main form after successful login
            if (loginForm.DialogResult == DialogResult.OK)
            {
                this.Hide();
                frmMain mainForm = new frmMain
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                mainForm.ShowDialog();
            }

            // Exit app if login is cancelled
            Application.Exit();
        }
  
    }
}
