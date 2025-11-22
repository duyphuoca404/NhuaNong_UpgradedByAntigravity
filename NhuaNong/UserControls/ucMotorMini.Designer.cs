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
  public partial class ucMotorMini
  {
    private IContainer components;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.SuspendLayout();
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Transparent;
      this.BackgroundImage = (Image)ResourceNhua._motor_mini;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.DoubleBuffered = true;
      this.Name = "ucMotorMini";
      this.Size = new Size(60, 36);
      this.Click += new EventHandler(this.ucMotorMini_Click);
      this.MouseDown += new MouseEventHandler(this.ucMotorMini_MouseDown);
      this.MouseUp += new MouseEventHandler(this.ucMotorMini_MouseUp);
      this.ResumeLayout(false);
    }
  }
}
