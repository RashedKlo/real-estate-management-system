using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealEstateManagement.Data.Settings;
using RealEstateManagement.Data.Repositories.Client;
using RealEstateManagement.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace RealEstateManagement
{
    public partial class frmClientDetails : Form
    {
        private  frmMain _mainForm;
        private  int _clientId;
        private int _currentPage = 1;
        private const int PAGE_SIZE = 10;
        private int _totalPages = 1;
        private int _totalRecords = 0;
        private readonly IClientsService _clientsService;
        private readonly ILogger<frmEditClient> _logger;

        public frmClientDetails(IClientsService clientsService, ILogger<frmEditClient> logger)
        {
            if (clientsService == null)
                throw new ArgumentNullException(nameof(clientsService));

            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            InitializeComponent();

            _clientsService = clientsService;
            _logger = logger;

            SetupOptimization();
        }

        public void setMainForm(frmMain main)
        {
            this._mainForm = main;
        }
        public void setClientId(int clientId)
        {
            this._clientId = clientId;
        }
        #region Form Events

        private async void frmClientDetails_Load(object sender, EventArgs e)
        {
            try
            {
                lblHeader.Text = "جاري التحميل...";
                _mainForm?.UpdateStatusBar($"تحميل تفاصيل العميل رقم {_clientId}");

                await LoadClientDataAsync();
                await LoadClientPropertiesAsync();

                _mainForm?.UpdateStatusBar($"تم عرض تفاصيل العميل رقم {_clientId}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل البيانات: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                this.Close();
            }
        }

        #endregion

        #region Data Loading

        private async Task LoadClientDataAsync()
        {
        
        }

        private async Task LoadClientPropertiesAsync()
        {
           
        }

        #endregion

        #region UI Updates

        private void UpdatePaginationInfo()
        {
            lblPageInfo.Text = $"صفحة {_currentPage} من {_totalPages}";
            btnPrevPage.Enabled = _currentPage < _totalPages;
            btnNextPage.Enabled = _currentPage > 1;
        }

        #endregion

        #region Button Events

        private async void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
            {
                _currentPage++;
                await LoadClientPropertiesAsync();
            }
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                await LoadClientPropertiesAsync();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Helper Methods

        private void SetupOptimization()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                         ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }

        #endregion
    }
}