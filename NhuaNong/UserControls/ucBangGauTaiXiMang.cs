// Decompiled with JetBrains decompiler
// Type: NhuaNong.UserControls.ucBangGauTaiXiMang
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.UserControls
{
  public class ucBangGauTaiXiMang : UserControl
  {
    private IContainer components;

    public ucBangGauTaiXiMang() => this.InitializeComponent();

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
      this.BackgroundImage = (Image) ResourceNhua._banggautaiximang;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.DoubleBuffered = true;
      this.Name = nameof (ucBangGauTaiXiMang);
      this.Size = new Size(42, 607);
      this.ResumeLayout(false);
    }
  }
}
