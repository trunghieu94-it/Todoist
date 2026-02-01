using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class BorderPanel : Panel
{
    #region Fields
    private int _topLeft = 10;
    private int _topRight = 10;
    private int _bottomRight = 10;
    private int _bottomLeft = 10;

    private Color _borderColor = Color.Black;
    private int _borderThickness = 1;
    #endregion


    public BorderPanel()
    {
        DoubleBuffered = true;
        ResizeRedraw = true;
        BackColor = Color.White;
    }

    #region Properties
    [Category("Advanced Custom")]
    [DefaultValue(10)]
    public int TopLeftRadius
    {
        get => _topLeft;
        set { _topLeft = Math.Max(0, value); Invalidate(); }
    }

    [Category("Advanced Custom")]
    [DefaultValue(10)]
    public int TopRightRadius
    {
        get => _topRight;
        set { _topRight = Math.Max(0, value); Invalidate(); }
    }

    [Category("Advanced Custom")]
    [DefaultValue(10)]
    public int BottomRightRadius
    {
        get => _bottomRight;
        set { _bottomRight = Math.Max(0, value); Invalidate(); }
    }

    [Category("Advanced Custom")]
    [DefaultValue(10)]
    public int BottomLeftRadius
    {
        get => _bottomLeft;
        set { _bottomLeft = Math.Max(0, value); Invalidate(); }
    }

    [Category("Advanced Custom")]
    public Color BorderColor
    {
        get => _borderColor;
        set { _borderColor = value; Invalidate(); }
    }

    [Category("Advanced Custom")]
    [DefaultValue(1)]
    public int BorderThickness
    {
        get => _borderThickness;
        set { _borderThickness = Math.Max(0, value); Invalidate(); }
    }
    #endregion

    #region Methods
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rect = ClientRectangle;
        rect.Width -= 1;
        rect.Height -= 1;

        using (GraphicsPath path = GetPath(rect))
        {
            using (SolidBrush brush = new SolidBrush(BackColor))
                e.Graphics.FillPath(brush, path);

            if (_borderThickness > 0)
            {
                using (Pen pen = new Pen(_borderColor, _borderThickness))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, path);
                }
            }

            Region = new Region(path);
        }
    }

    private GraphicsPath GetPath(Rectangle r)
    {
        GraphicsPath path = new GraphicsPath();

        int tl = _topLeft * 2;
        int tr = _topRight * 2;
        int br = _bottomRight * 2;
        int bl = _bottomLeft * 2;

        path.StartFigure();

        if (tl > 0)
            path.AddArc(r.Left, r.Top, tl, tl, 180, 90);
        else
            path.AddLine(r.Left, r.Top, r.Left, r.Top);

        path.AddLine(r.Left + _topLeft, r.Top, r.Right - _topRight, r.Top);

        if (tr > 0)
            path.AddArc(r.Right - tr, r.Top, tr, tr, 270, 90);
        else
            path.AddLine(r.Right, r.Top, r.Right, r.Top);

        path.AddLine(r.Right, r.Top + _topRight, r.Right, r.Bottom - _bottomRight);

        if (br > 0)
            path.AddArc(r.Right - br, r.Bottom - br, br, br, 0, 90);
        else
            path.AddLine(r.Right, r.Bottom, r.Right, r.Bottom);

        path.AddLine(r.Right - _bottomRight, r.Bottom, r.Left + _bottomLeft, r.Bottom);

        if (bl > 0)
            path.AddArc(r.Left, r.Bottom - bl, bl, bl, 90, 90);
        else
            path.AddLine(r.Left, r.Bottom, r.Left, r.Bottom);

        path.AddLine(r.Left, r.Bottom - _bottomLeft, r.Left, r.Top + _topLeft);

        path.CloseFigure();

        return path;
    }
    #endregion
}
