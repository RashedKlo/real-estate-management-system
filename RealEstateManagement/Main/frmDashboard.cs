using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Guna.Charts.WinForms;

namespace RealEstateManagement
{
    public partial class frmDashboard : Form
    {
        #region Constants
        private const int CHART_CORNER_RADIUS = 8;
        private const int RECENT_ACTIVITIES_LIMIT = 5;
        #endregion

        #region Fields
        private DataTable _activitiesData;
        #endregion

        #region Constructor
        public frmDashboard()
        {
            InitializeComponent();
            InitializeFormSettings();
        }
        #endregion

        #region Initialization
        private void InitializeFormSettings()
        {
            // Set form properties for better performance
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                         ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.UserPaint, true);
            this.UpdateStyles();

            // Enable double buffering for main content panel
            EnableDoubleBuffering(pnlMainContent);

            // Optimize scroll performance
            pnlMainContent.AutoScroll = true;
            pnlMainContent.HorizontalScroll.Enabled = false;
            pnlMainContent.HorizontalScroll.Visible = false;
        }

        private void EnableDoubleBuffering(Control control)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, control, new object[] { true });

            // Enable double buffering for all child controls
            foreach (Control child in control.Controls)
            {
                EnableDoubleBuffering(child);
            }
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                // Suspend all layouts during initialization
                SuspendAllLayouts();

                LoadDashboardData();
                SetupCharts();
                LoadRecentActivities();
                UpdateDateTime();

                // Resume all layouts after initialization
                ResumeAllLayouts();

                // Optimize scroll after load
                OptimizeScrollPerformance();
            }
            catch (Exception ex)
            {
                ShowError("خطأ في تحميل لوحة التحكم", ex.Message);
            }
        }

        private void SuspendAllLayouts()
        {
            this.SuspendLayout();
            pnlMainContent.SuspendLayout();
            flowSummaryCards.SuspendLayout();
            tblCharts.SuspendLayout();
            pnlRecentActivities.SuspendLayout();
        }

        private void ResumeAllLayouts()
        {
            pnlRecentActivities.ResumeLayout(false);
            pnlRecentActivities.PerformLayout();

            tblCharts.ResumeLayout(false);
            tblCharts.PerformLayout();

            flowSummaryCards.ResumeLayout(false);
            flowSummaryCards.PerformLayout();

            pnlMainContent.ResumeLayout(false);
            pnlMainContent.PerformLayout();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void OptimizeScrollPerformance()
        {
            // Remove scroll lag by optimizing auto-scroll
            pnlMainContent.AutoScroll = false;
            pnlMainContent.AutoScroll = true;

            // Set smooth scrolling
            pnlMainContent.AutoScrollMinSize = new Size(0,
                flowSummaryCards.Height + tblCharts.Height + pnlRecentActivities.Height + 40);
        }
        #endregion

        #region Data Loading
        private void LoadDashboardData()
        {
            // TODO: Replace with actual database calls
            // Consider using async/await for database operations

            UpdateStatisticsCards();
        }

        private void UpdateStatisticsCards()
        {
            // Update card values - these should come from your data layer
            lblClientsValue.Text = GetTotalClients().ToString();
            lblOwnersValue.Text = GetTotalOwners().ToString();
            lblPropertiesValue.Text = GetTotalProperties().ToString();
            lblRevenueValue.Text = FormatCurrency(GetTotalRevenue());

            // Update change percentages
            lblClientsChange.Text = FormatChangePercentage(10);
            lblOwnersChange.Text = FormatChangePercentage(8);
            lblPropertiesChange.Text = FormatChangePercentage(5);
            lblRevenueChange.Text = FormatChangePercentage(15);
        }

        // TODO: Implement these methods with actual data layer calls
        private int GetTotalClients() => 120;
        private int GetTotalOwners() => 85;
        private int GetTotalProperties() => 512;
        private decimal GetTotalRevenue() => 1200000;
        #endregion

        #region Charts Setup
        private void SetupCharts()
        {
            SetupPropertiesChart();
            SetupRevenueChart();
        }

        private void SetupPropertiesChart()
        {
            try
            {
                gunaChart2.Datasets.Clear();

                var dataset = new GunaDoughnutDataset
                {
                    Label = "العقارات"
                };

                // Property data
                var propertyData = new[]
                {
                    new { Name = "شقق", Value = 45, Color = Color.FromArgb(94, 148, 255) },
                    new { Name = "فلل", Value = 30, Color = Color.FromArgb(255, 152, 0) },
                    new { Name = "أراضي", Value = 15, Color = Color.FromArgb(76, 175, 80) },
                    new { Name = "محلات", Value = 10, Color = Color.FromArgb(156, 39, 176) }
                };

                foreach (var item in propertyData)
                {
                    dataset.DataPoints.Add(item.Name, item.Value);
                    dataset.FillColors.Add(item.Color);
                    dataset.BorderColors.Add(item.Color);
                }

                dataset.BorderWidth = 2;
                gunaChart2.Datasets.Add(dataset);
                gunaChart2.Update();
            }
            catch (Exception ex)
            {
                ShowError("خطأ في رسم مخطط العقارات", ex.Message);
            }
        }

        private void SetupRevenueChart()
        {
            try
            {
                gunaChart1.Datasets.Clear();

                var dataset = new GunaBarDataset
                {
                    Label = "الإيرادات (بالآلاف)",
                    BorderWidth = 0,
                    CornerRadius = CHART_CORNER_RADIUS
                };

                // Monthly revenue data - should come from database
                var revenueData = GetMonthlyRevenue();

                foreach (var item in revenueData)
                {
                    dataset.DataPoints.Add(item.Key, item.Value);
                    dataset.FillColors.Add(Color.FromArgb(94, 148, 255));
                    dataset.BorderColors.Add(Color.FromArgb(94, 148, 255));
                }

                gunaChart1.Datasets.Add(dataset);
                gunaChart1.Update();
            }
            catch (Exception ex)
            {
                ShowError("خطأ في رسم مخطط الإيرادات", ex.Message);
            }
        }

        private System.Collections.Generic.Dictionary<string, double> GetMonthlyRevenue()
        {
            // TODO: Replace with actual database query
            return new System.Collections.Generic.Dictionary<string, double>
            {
                { "يناير", 180 },
                { "فبراير", 220 },
                { "مارس", 195 },
                { "أبريل", 250 },
                { "مايو", 290 },
                { "يونيو", 320 }
            };
        }
        #endregion

        #region Recent Activities
        private void LoadRecentActivities()
        {
            try
            {
                _activitiesData = CreateActivitiesDataTable();
                PopulateActivitiesData(_activitiesData);

                dgvRecentActivities.DataSource = _activitiesData;
                StyleDataGridView();
            }
            catch (Exception ex)
            {
                ShowError("خطأ في تحميل الأنشطة الأخيرة", ex.Message);
            }
        }

        private DataTable CreateActivitiesDataTable()
        {
            var dt = new DataTable();
            dt.Columns.Add("التاريخ", typeof(string));
            dt.Columns.Add("النشاط", typeof(string));
            dt.Columns.Add("الهدف", typeof(string));
            dt.Columns.Add("الحالة", typeof(string));
            return dt;
        }

        private void PopulateActivitiesData(DataTable dt)
        {
            // TODO: Replace with actual database query
            // Consider using parameterized queries and limiting results

            var activities = new[]
            {
                new { Date = "2025-10-13", Activity = "عملية بيع", Target = "شقة 102 - الرياض", Status = "مكتملة" },
                new { Date = "2025-10-12", Activity = "إضافة عميل", Target = "أحمد محمد", Status = "جديد" },
                new { Date = "2025-10-12", Activity = "تحديث عقار", Target = "فيلا 205 - جدة", Status = "متاح" },
                new { Date = "2025-10-11", Activity = "عملية إيجار", Target = "محل 15 - الدمام", Status = "مكتملة" },
                new { Date = "2025-10-10", Activity = "إضافة مالك", Target = "سعد خالد", Status = "جديد" }
            };

            foreach (var activity in activities)
            {
                dt.Rows.Add(activity.Date, activity.Activity, activity.Target, activity.Status);
            }
        }

        private void StyleDataGridView()
        {
            dgvRecentActivities.EnableHeadersVisualStyles = false;

            // Header styling
            var headerStyle = dgvRecentActivities.ColumnHeadersDefaultCellStyle;
            headerStyle.BackColor = Color.FromArgb(50, 50, 70);
            headerStyle.ForeColor = Color.White;
            headerStyle.Font = new Font("Tajawal", 11F, FontStyle.Bold);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            headerStyle.Padding = new Padding(5);

            // Cell styling
            var cellStyle = dgvRecentActivities.DefaultCellStyle;
            cellStyle.BackColor = Color.FromArgb(30, 30, 46);
            cellStyle.ForeColor = Color.White;
            cellStyle.Font = new Font("Tajawal", 10F);
            cellStyle.SelectionBackColor = Color.FromArgb(94, 148, 255);
            cellStyle.SelectionForeColor = Color.White;
            cellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alternating row styling
            var altRowStyle = dgvRecentActivities.AlternatingRowsDefaultCellStyle;
            altRowStyle.BackColor = Color.FromArgb(40, 40, 58);

            // Auto-size columns
            dgvRecentActivities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        #endregion

        #region Timer Events
        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd، dd MMMM yyyy hh:mm tt",
                new System.Globalization.CultureInfo("ar-SA"));
        }
        #endregion

        #region Helper Methods
        private string FormatCurrency(decimal amount)
        {
            if (amount >= 1000000)
                return $"${amount / 1000000:F1}M";
            else if (amount >= 1000)
                return $"${amount / 1000:F1}K";
            else
                return $"${amount:F0}";
        }

        private string FormatChangePercentage(double percentage)
        {
            string arrow = percentage >= 0 ? "▲" : "▼";
            return $"{arrow} {Math.Abs(percentage):+0;-0}% شهريًا";
        }

        private void ShowError(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Handle scroll event to reduce lag
        private void pnlMainContent_Scroll(object sender, ScrollEventArgs e)
        {
            // Disable shadows during fast scrolling for better performance
            bool isScrolling = (e.Type == ScrollEventType.ThumbTrack ||
                               e.Type == ScrollEventType.LargeDecrement ||
                               e.Type == ScrollEventType.LargeIncrement);

            if (isScrolling)
            {
                // Temporarily disable expensive visual effects
                ToggleVisualEffects(false);
            }
            else if (e.Type == ScrollEventType.EndScroll)
            {
                // Re-enable visual effects when scrolling stops
                ToggleVisualEffects(true);
                pnlMainContent.Refresh();
            }
        }

        private void ToggleVisualEffects(bool enabled)
        {
            // Toggle shadows on cards
            cardTotalClients.ShadowDecoration.Enabled = enabled;
            cardTotalOwners.ShadowDecoration.Enabled = enabled;
            cardTotalProperties.ShadowDecoration.Enabled = enabled;
            cardTotalRevenue.ShadowDecoration.Enabled = enabled;

            // Toggle shadows on chart panels
            pnlChart1.ShadowDecoration.Enabled = enabled;
            pnlChart2.ShadowDecoration.Enabled = enabled;
            pnlRecentActivities.ShadowDecoration.Enabled = enabled;
        }
        #endregion


    }
}