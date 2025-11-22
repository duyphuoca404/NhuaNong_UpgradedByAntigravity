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
  public partial class ucNoiTron
  {
    private IContainer components;
    private Label lblTG_ThucTron;
    private Label lblKL;
    private Label lblTG_ThucXa;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.lblTG_ThucTron = new Label();
      this.lblKL = new Label();
      this.lblTG_ThucXa = new Label();
      this.SuspendLayout();
      this.lblTG_ThucTron.BackColor = Color.Black;
      this.lblTG_ThucTron.BorderStyle = BorderStyle.Fixed3D;
      this.lblTG_ThucTron.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.lblTG_ThucTron.ForeColor = Color.Lime;
      this.lblTG_ThucTron.Location = new Point(128, 97);
      this.lblTG_ThucTron.Name = "lblTG_ThucTron";
      this.lblTG_ThucTron.Size = new Size(82, 37);
      this.lblTG_ThucTron.TabIndex = 1;
      this.lblTG_ThucTron.Text = "0";
      this.lblTG_ThucTron.TextAlign = ContentAlignment.MiddleCenter;
      this.lblKL.BackColor = Color.Black;
      this.lblKL.BorderStyle = BorderStyle.Fixed3D;
      this.lblKL.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.lblKL.ForeColor = Color.Lime;
      this.lblKL.Location = new Point(256, 45);
      this.lblKL.Name = "lblKL";
      this.lblKL.Size = new Size(82, 37);
      this.lblKL.TabIndex = 2;
      this.lblKL.Text = "0";
      this.lblKL.TextAlign = ContentAlignment.MiddleCenter;
      this.lblTG_ThucXa.BackColor = Color.Black;
      this.lblTG_ThucXa.BorderStyle = BorderStyle.Fixed3D;
      this.lblTG_ThucXa.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.lblTG_ThucXa.ForeColor = Color.Lime;
      this.lblTG_ThucXa.Location = new Point(256, 97);
      this.lblTG_ThucXa.Name = "lblTG_ThucXa";
      this.lblTG_ThucXa.Size = new Size(82, 37);
      this.lblTG_ThucXa.TabIndex = 3;
      this.lblTG_ThucXa.Text = "0";
      this.lblTG_ThucXa.TextAlign = ContentAlignment.MiddleCenter;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Transparent;
      this.BackgroundImage = (Image)ResourceNhua._noi_tron;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.Controls.Add((Control)this.lblTG_ThucXa);
      this.Controls.Add((Control)this.lblKL);
      this.Controls.Add((Control)this.lblTG_ThucTron);
      this.DoubleBuffered = true;
      this.Name = "ucNoiTron";
      this.Size = new Size(470, 160);
      this.ResumeLayout(false);
    }
  }
}
