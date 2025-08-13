// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.UcLogicSiloAdd
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public class UcLogicSiloAdd : UcLogicBase
  {
    private IContainer components;

    public UcLogicSiloAdd() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.lueWeigh2.Properties.BeginInit();
      this.lueWeigh1.Properties.BeginInit();
      this.SuspendLayout();
      this.lueWeigh2.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueWeigh2.Properties.Appearance.Options.UseFont = true;
      this.lueWeigh1.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueWeigh1.Properties.Appearance.Options.UseFont = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Name = nameof (UcLogicSiloAdd);
      this.NhomSilo = UcLogicBase.NhomSiloEnum.ADD;
      this.lueWeigh2.Properties.EndInit();
      this.lueWeigh1.Properties.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
