using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Todoist.WinForms.Views.Components
{
    internal class CustomButton : Button
    {
        #region Fields
        private int _borderSize = 0;
        private int _borderRadius = 0;
        private Color _borderColor = Color.PaleVioletRed;

        private Image _icon;
        private Size _iconSize = new Size(24, 24);
        private int _iconPadding = 10;
        private int _iconTextSpacing = 6;

        private bool _isHovered = false;
        private Color _hoverBackColor = Color.FromArgb(245, 245, 245); // tùy bạn
        #endregion

        #region Properties
        [Category("Advanced Custom")]
        public int BorderSize
        {
            get => _borderSize;
            set
            {
                _borderSize = value;
                Invalidate();
            }
        }

        [Category("Advanced Custom")]
        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                _borderRadius = value;
                Invalidate();
            }
        }

        [Category("Advanced Custom")]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        [Category("Advanced Custom")]
        public Color BackgroundColor
        {
            get => BackColor;
            set => BackColor = value;
        }

        [Category("Advanced Custom")]
        public Color TextColor
        {
            get => ForeColor;
            set => ForeColor = value;
        }

        [Category("Icon Custom")]
        public Image Icon
        {
            get => _icon;
            set
            {
                _icon = value;
                Invalidate();
            }
        }

        [Category("Icon Custom")]
        public Size IconSize
        {
            get => _iconSize;
            set
            {
                _iconSize = value;
                Invalidate();
            }
        }

        [Category("Icon Custom")]
        public int IconPadding
        {
            get => _iconPadding;
            set
            {
                _iconPadding = value;
                Invalidate();
            }
        }

        [Category("Icon Custom")]
        [DefaultValue(6)]
        public int IconTextSpacing
        {
            get => _iconTextSpacing;
            set
            {
                _iconTextSpacing = Math.Max(0, value);
                Invalidate();
            }
        }

        [Category("Hover Custom")]
        public Color HoverBackColor
        {
            get => _hoverBackColor;
            set
            {
                _hoverBackColor = value;
                Invalidate();
            }
        }
        #endregion

        #region Constructor
        public CustomButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
             ControlStyles.UserPaint |
             ControlStyles.OptimizedDoubleBuffer, true);

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);
            BackColor = Color.MediumSlateBlue;
            ForeColor = Color.White;
            Cursor = Cursors.Hand;
        }
        #endregion

        #region Methods
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Color currentBackColor = _isHovered ? _hoverBackColor : BackColor;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            RectangleF rectSurface = new RectangleF(0, 0, Width, Height);
            RectangleF rectBorder = new RectangleF(1, 1, Width - 0.8F, Height - 1);

            // ===== DRAW BACKGROUND & BORDER =====
            if (_borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, _borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, _borderRadius - 1F))
                using (Pen penSurface = new Pen(Parent.BackColor, 2))
                using (SolidBrush surfaceBrush = new SolidBrush(currentBackColor))
                using (Pen penBorder = new Pen(_borderColor, _borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;

                    // FILL BACKGROUND (QUAN TRỌNG)
                    pevent.Graphics.FillPath(surfaceBrush, pathSurface);

                    // SET REGION
                    Region = new Region(pathSurface);

                    // ANTI-ALIAS EDGE
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    if (_borderSize > 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                using (SolidBrush surfaceBrush = new SolidBrush(currentBackColor))
                {
                    pevent.Graphics.FillRectangle(surfaceBrush, rectSurface);
                }

                Region = new Region(rectSurface);

                if (_borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(_borderColor, _borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }
                }
            }


            // ===== ICON =====
            int textOffsetX = 0;

            if (_icon != null)
            {
                Rectangle iconRect = new Rectangle(
                    _iconPadding,
                    (Height - _iconSize.Height) / 2,
                    _iconSize.Width,
                    _iconSize.Height
                );

                if (Enabled)
                {
                    pevent.Graphics.DrawImage(_icon, iconRect);
                }
                else
                {
                    ControlPaint.DrawImageDisabled(
                        pevent.Graphics,
                        _icon,
                        iconRect.X,
                        iconRect.Y,
                        BackColor
                    );
                }

                textOffsetX = _iconTextSpacing;
            }

            // ===== TEXT =====
            Rectangle textRect = new Rectangle(
                textOffsetX,
                0,
                Width - textOffsetX,
                Height
            );

            TextRenderer.DrawText(
                pevent.Graphics,
                Text,
                Font,
                textRect,
                Enabled ? ForeColor : SystemColors.GrayText,
                TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter
            );
        }


        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            if (Parent != null)
                Parent.BackColorChanged += Parent_BackColorChanged;
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            if (Parent != null)
                Parent.BackColorChanged -= Parent_BackColorChanged;

            base.OnHandleDestroyed(e);
        }

        private void Parent_BackColorChanged(object sender, EventArgs e)
        {
            if (!IsDisposed)
                Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _isHovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isHovered = false;
            Invalidate();
        }
        #endregion
    }
}
