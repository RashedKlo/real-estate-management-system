using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Data.DTOs.Owners.Queries;
using RealEstateManagement.Data.Results;
using RealEstateManagement.Data.Models;
using RealEstateManagement.Services.Interfaces;
using System.Data;

namespace RealEstateManagement
{
    public partial class frmSearchOwner : Form
    {
        #region Fields

        private readonly IOwnersService _ownersService;
        private readonly ILogger<frmSearchOwner> _logger;
        private frmMain _frmMain;

        #endregion

        #region Properties

        public int? SelectedOwnerId { get; private set; }
        public string SelectedOwnerName { get; private set; }

        private int _currentPage = 1;
        private const int PAGE_SIZE = 4;
        private int _totalPages = 1;
        private int _totalRecords = 0;
        private bool _hasNextPage = false;
        private bool _hasPreviousPage = false;

        #endregion

        #region Constructor

        public frmSearchOwner(IOwnersService ownersService, ILogger<frmSearchOwner> logger)
        {
            _ownersService = ownersService ?? throw new ArgumentNullException(nameof(ownersService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

            InitializeComponent();
            SetupOptimization();
            this.Text = "البحث عن مالك";
            lblTitle.Text = "البحث عن مالك عقار";
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Setup DataGridView appearance for a modern look
          
        }

        #endregion

        #region Event Handlers
    
    

        #endregion

        #region Private Methods - Validation

    
        private void ShowError(string message, Exception ex)
        {
            string fullMessage = ex != null ? $"{message}: {ex.Message}" : message;
            _logger.LogError(ex, "Error: {Message}", message);
            MessageBox.Show(fullMessage, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        #endregion

        #region Private Methods - UI Updates


   

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await ExecuteSearch();
        }

        private async void txtSearchQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents the 'ding' sound
                await ExecuteSearch();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvOwners.SelectedRows.Count > 0)
            {
                var selectedRow = dgvOwners.SelectedRows[0];
                SelectedOwnerId = (int)selectedRow.Cells["OwnerIdColumn"].Value;
                SelectedOwnerName = selectedRow.Cells["FullNameColumn"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("يرجى تحديد مالك من القائمة أولاً.", "تحديد مطلوب",
                    MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dgvOwners_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Select the row on double-click
                dgvOwners.Rows[e.RowIndex].Selected = true;
                btnSelect_Click(sender, e);
            }
        }

        #endregion

        #region Private Methods

        private async Task ExecuteSearch()
        {
            string query = txtSearchQuery.Text.Trim();
            if (string.IsNullOrEmpty(query))
            {
                dgvOwners.DataSource = null;
                lblStatus.Text = "أدخل اسم المالك أو رقم الهاتف للبحث.";
                return;
            }

            try
            {
                lblStatus.Text = "جاري البحث...";
                dgvOwners.DataSource = null; // Clear old results
                var request = new OwnersGetRequestDto()
                {
                    Page = 1,
                    Limit = 50, // Increased limit for more results
                    FullName = query,
                    PhoneNumber = ""
                };
                var result = await _ownersService.GetOwnersAsync(request);

                if (!result.IsSuccess || result.Data == null || result.Data.Owners == null || !result.Data.Owners.Any())
                {
                    lblStatus.Text = "لم يتم العثور على نتائج مطابقة.";
                    return;
                }

                dgvOwners.DataSource = result.Data.Owners;
                lblStatus.Text = $"تم العثور على {result.Data.TotalRecords} من المالكين.";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to execute owner search.");
                lblStatus.Text = "حدث خطأ أثناء البحث.";
                MessageBox.Show("حدث خطأ أثناء البحث: " + ex.Message, "خطأ في البحث",
                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }

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