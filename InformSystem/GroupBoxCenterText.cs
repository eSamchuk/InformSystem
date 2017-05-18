using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace InformSystem
{
    class GroupBoxCenterText : GroupBox
    {
        private string _Text = "";
        public GroupBoxCenterText()
        {
            base.Text = "";
        }
        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue("GroupBoxText")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new string Text
        {
            get
            {
                return _Text;
            }
            set
            {
                _Text = value;
                this.Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            SolidBrush colorBrush = new SolidBrush(this.ForeColor);
            var backColor = new SolidBrush(this.BackColor);
            var size = TextRenderer.MeasureText(this.Text, this.Font);
            int left = (this.Width - size.Width) / 2;
            e.Graphics.FillRectangle(backColor, new Rectangle(left, 0, size.Width, size.Height));
            e.Graphics.DrawString(this.Text, this.Font, colorBrush, new PointF(left, 0));
        }
    }
}
