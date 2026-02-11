using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Todoist.WinForms.Views.Components
{
    internal class IconLabel : Label
    {
        private Image _icon;
        private Size _iconSize = new Size(16, 16);
        private int _iconPadding = 4;
        private int _iconTextSpacing = 6;

        [Category("Icon")]
        public Image Icon
        {
            get => _icon;
            set
            {
                _icon = value;
                Invalidate();
            }
        }

        [Category("Icon")]
        public Size IconSize
        {
            get => _iconSize;
            set
            {
                _iconSize = value;
                Invalidate();
            }
        }

        [Category("Icon")]
        public int IconPadding
        {
            get => _iconPadding;
            set
            {
                _iconPadding = Math.Max(0, value);
                Invalidate();
            }
        }

        [Category("Icon")]
        public int IconTextSpacing
        {
            get => _iconTextSpacing;
            set
            {
                _iconTextSpacing = Math.Max(0, value);
                Invalidate();
            }
        }

        public IconLabel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.UserPaint, true);

            AutoSize = false;
            TextAlign = ContentAlignment.MiddleLeft;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            e.Graphics.Clear(BackColor);

            int textOffsetX = 0;

            // ===== ICON =====
            if (_icon != null)
            {
                Rectangle iconRect = new Rectangle(
                    _iconPadding,
                    (Height - _iconSize.Height) / 2,
                    _iconSize.Width,
                    _iconSize.Height
                );

                e.Graphics.DrawImage(_icon, iconRect);

                textOffsetX = _iconPadding + _iconSize.Width + _iconTextSpacing;
            }

            // ===== TEXT =====
            Rectangle textRect = new Rectangle(
                textOffsetX,
                0,
                Width - textOffsetX,
                Height
            );

            TextRenderer.DrawText(
                e.Graphics,
                Text,
                Font,
                textRect,
                ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Left
            );
        }
    }
}
