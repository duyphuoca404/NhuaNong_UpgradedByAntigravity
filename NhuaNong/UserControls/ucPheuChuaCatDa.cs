// Decompiled with JetBrains decompiler
// Type: NhuaNong.UserControls.ucPheuChuaCatDa
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.UserControls
{
  public class ucPheuChuaCatDa : UserControl
  {
    private IContainer components;
    private Label lblName;

    public ucPheuChuaCatDa() => this.InitializeComponent();

    public string WeighName
    {
      get => this.lblName.Text;
      set => this.lblName.Text = value;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.lblName = new Label();
      this.SuspendLayout();
      this.lblName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblName.Location = new Point(3, 21);
      this.lblName.Name = "lblName";
      this.lblName.Size = new Size(69, 21);
      this.lblName.TabIndex = 0;
      this.lblName.Text = "AGG1";
      this.lblName.TextAlign = ContentAlignment.MiddleCenter;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Transparent;
      this.BackgroundImage = (Image) ResourceNhua._pheu_chua_catda;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.Controls.Add((Control) this.lblName);
      this.DoubleBuffered = true;
      this.Name = nameof (ucPheuChuaCatDa);
      this.Size = new Size(75, 75);
      this.ResumeLayout(false);
    }
  }
}
