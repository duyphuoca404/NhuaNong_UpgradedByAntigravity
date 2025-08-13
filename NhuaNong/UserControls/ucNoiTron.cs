// Decompiled with JetBrains decompiler
// Type: NhuaNong.UserControls.ucNoiTron
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.UserControls
{
  public class ucNoiTron : UserControl
  {
    private IContainer components;
    private Label lblTG_ThucTron;
    private Label lblKL;
    private Label lblTG_ThucXa;

    public Decimal KL_TRON
    {
      get => Convert.ToDecimal(this.lblKL.Text);
      set => this.lblKL.Text = value.ToString(this.Text);
    }

    public Decimal TG_TRON
    {
      get => Convert.ToDecimal(this.lblTG_ThucTron.Text);
      set => this.lblTG_ThucTron.Text = value.ToString(this.Text);
    }

    public Decimal TG_THỰC_XA
    {
      get => Convert.ToDecimal(this.lblTG_ThucXa.Text);
      set => this.lblTG_ThucXa.Text = value.ToString(this.Text);
    }

    public ucNoiTron() => this.InitializeComponent();

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
      this.lblTG_ThucTron.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblTG_ThucTron.ForeColor = Color.Lime;
      this.lblTG_ThucTron.Location = new Point(128, 97);
      this.lblTG_ThucTron.Name = "lblTG_ThucTron";
      this.lblTG_ThucTron.Size = new Size(82, 37);
      this.lblTG_ThucTron.TabIndex = 1;
      this.lblTG_ThucTron.Text = "0";
      this.lblTG_ThucTron.TextAlign = ContentAlignment.MiddleCenter;
      this.lblKL.BackColor = Color.Black;
      this.lblKL.BorderStyle = BorderStyle.Fixed3D;
      this.lblKL.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblKL.ForeColor = Color.Lime;
      this.lblKL.Location = new Point(256, 45);
      this.lblKL.Name = "lblKL";
      this.lblKL.Size = new Size(82, 37);
      this.lblKL.TabIndex = 2;
      this.lblKL.Text = "0";
      this.lblKL.TextAlign = ContentAlignment.MiddleCenter;
      this.lblTG_ThucXa.BackColor = Color.Black;
      this.lblTG_ThucXa.BorderStyle = BorderStyle.Fixed3D;
      this.lblTG_ThucXa.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
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
      this.BackgroundImage = (Image) ResourceNhua._noi_tron;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.Controls.Add((Control) this.lblTG_ThucXa);
      this.Controls.Add((Control) this.lblKL);
      this.Controls.Add((Control) this.lblTG_ThucTron);
      this.DoubleBuffered = true;
      this.Name = nameof (ucNoiTron);
      this.Size = new Size(470, 160);
      this.ResumeLayout(false);
    }
  }
}
