using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SystemAnalysisAndDesignProject
{
    public class RoundedTextBox : TextBox
    {
        private int _borderRadius = 15; // ברירת מחדל לרדיוס הפינות
        private Color _borderColor = Color.Gray; // צבע ברירת מחדל לגבול
        private int _borderWidth = 2; // רוחב הגבול

        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                _borderRadius = value;
                this.Invalidate(); // רענון הרכיב
            }
        }

        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                this.Invalidate(); // רענון הרכיב
            }
        }

        public int BorderWidth
        {
            get => _borderWidth;
            set
            {
                _borderWidth = value;
                this.Invalidate(); // רענון הרכיב
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // צייר את הגבול עם הפינות המעוגלות
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, _borderRadius, _borderRadius, 180, 90);
                path.AddArc(this.Width - _borderRadius, 0, _borderRadius, _borderRadius, 270, 90);
                path.AddArc(this.Width - _borderRadius, this.Height - _borderRadius, _borderRadius, _borderRadius, 0, 90);
                path.AddArc(0, this.Height - _borderRadius, _borderRadius, _borderRadius, 90, 90);
                path.CloseAllFigures();

                this.Region = new Region(path);

                using (Pen pen = new Pen(_borderColor, _borderWidth))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }
}
