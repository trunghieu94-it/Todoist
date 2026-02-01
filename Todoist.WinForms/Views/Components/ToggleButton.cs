using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Todoist.WinForms.Views.Components
{
    internal class ToggleButton : CheckBox
    {
        // Fields
        private Color _onBackColor = Color.MediumSlateBlue;
        private Color _onToggleColor = Color.WhiteSmoke;
        private Color _offBackColor = Color.Gray;
        private Color _offToggleColor = Color.Gainsboro;

        // Properties
        public Color OnBackColor
        {
            get => _onBackColor;
            set
            {
                _onBackColor = value;
                Invalidate();
            }
        }
        public Color OnToggleColor
        {
            get => _onToggleColor;
            set
            {
                _onToggleColor = value;
                Invalidate();
            }
        }
        public Color OffBackColor
        {
            get => _offBackColor;
            set
            {
                _offBackColor = value;
                Invalidate();
            }
        }
        public Color OffToggleColor
        {
            get => _offToggleColor;
            set
            {
                _offToggleColor = value;
                Invalidate();
            }
        }

        [Category("Layout")]
        [DefaultValue(false)]
        public override bool AutoSize
        {
            get => false;
            set { }
        }


        public override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        // Constructor
        public ToggleButton()
        {
            AutoSize = false;
            MinimumSize = new Size(45, 22);
        }

        // Methods
        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked)
            {
                pevent.Graphics.FillPath(new SolidBrush(_onBackColor), GetFigurePath());
                pevent.Graphics.FillEllipse(
                    new SolidBrush(_onToggleColor),
                    new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize)
                    );
            }
            else
            {
                pevent.Graphics.FillPath(new SolidBrush(_offBackColor), GetFigurePath());
                pevent.Graphics.FillEllipse(
                    new SolidBrush(_offToggleColor),
                    new Rectangle(2, 2, toggleSize, toggleSize)
                    );
            }
        }
    }
}
