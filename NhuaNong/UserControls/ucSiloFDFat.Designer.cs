using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhuaNong.UserControls
{
  public partial class ucSiloFDFat
  {
    private IContainer components;
    private Label label1;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label1 = new Label();
      this.SuspendLayout();
      this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.label1.Location = new Point(0, 188);
      this.label1.Name = "label1";
      this.label1.Size = new Size(70, 28);
      this.label1.TabIndex = 0;
      this.label1.Text = "F/D";
      this.label1.TextAlign = ContentAlignment.MiddleCenter;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Transparent;
      this.BackgroundImage = (Image)ResourceNhua._silo_FD_Fat;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.Controls.Add((Control)this.label1);
      this.DoubleBuffered = true;
      this.Name = "ucSiloFDFat";
      this.Size = new Size(70, 500);
      this.ResumeLayout(false);
    }
  }
}
