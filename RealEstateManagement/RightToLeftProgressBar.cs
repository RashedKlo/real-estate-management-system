using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace RealEstateManagement
{
    // Custom Guna2ProgressBar that fills right → left
    public class RightToLeftProgressBar : Guna2ProgressBar
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            // Flip drawing horizontally so gradient and fill look natural
            e.Graphics.TranslateTransform(this.Width, 0);
            e.Graphics.ScaleTransform(-1, 1);
            base.OnPaint(e);
        }
    }
}
