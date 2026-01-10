using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NhuaNong.UserControls
{
  /// <summary>
  /// Thanh gom ngang - Horizontal collecting trough for independent weigh hoppers
  /// </summary>
  public partial class ucThanhGom : UserControl
  {
    private decimal _weight;
    private Color _troughColor = Color.FromArgb(80, 80, 80);
    private Color _borderColor = Color.FromArgb(40, 40, 40);

    [Category("Data")]
    [Description("Khối lượng tổng trong thanh gom")]
    public decimal Weight
    {
      get => this._weight;
      set
      {
        this._weight = value;
        this.Invalidate();
      }
    }

    [Category("Appearance")]
    [Description("Màu nền thanh gom")]
    public Color TroughColor
    {
      get => this._troughColor;
      set
      {
        this._troughColor = value;
        this.Invalidate();
      }
    }

    public ucThanhGom()
    {
      this.InitializeComponent();
      this.Name = nameof(ucThanhGom);
      this.DoubleBuffered = true;
      this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);
      Graphics g = e.Graphics;
      g.SmoothingMode = SmoothingMode.AntiAlias;

      int w = this.Width;
      int h = this.Height;
      int margin = 2;
      int topInset = 10; // Tạo hình thang: miệng rộng hơn đáy

      // Vẽ hình thang (trapezoid) - miệng rộng ở trên, đáy hẹp ở dưới
      Point[] trapezoid = new Point[]
      {
        new Point(margin, margin),                    // Top-left
        new Point(w - margin, margin),                // Top-right
        new Point(w - margin - topInset, h - margin), // Bottom-right
        new Point(margin + topInset, h - margin)      // Bottom-left
      };

      // Fill trapezoid
      using (SolidBrush brush = new SolidBrush(this._troughColor))
      {
        g.FillPolygon(brush, trapezoid);
      }

      // Draw border
      using (Pen pen = new Pen(this._borderColor, 2))
      {
        g.DrawPolygon(pen, trapezoid);
      }

      // Draw weight text in center if > 0
      if (this._weight > 0)
      {
        string text = this._weight.ToString("N0");
        using (Font font = new Font("Tahoma", 9f, FontStyle.Bold))
        using (SolidBrush textBrush = new SolidBrush(Color.Lime))
        {
          SizeF textSize = g.MeasureString(text, font);
          float x = (w - textSize.Width) / 2;
          float y = (h - textSize.Height) / 2;
          g.DrawString(text, font, textBrush, x, y);
        }
      }
    }
  }
}
