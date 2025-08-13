// Decompiled with JetBrains decompiler
// Type: NhuaNong.UserControls.ucWeighAP
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Utils;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.UserControls
{
  public class ucWeighAP : ucBaseWeight
  {
    private IContainer components;

    public ucWeighAP() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.picWeigh.Properties.BeginInit();
      this.spinEdit1.Properties.BeginInit();
      this.SuspendLayout();
      this.picWeigh.BackgroundImage = (Image) ResourceNhua._can_AP;
      this.picWeigh.Properties.Appearance.BackColor = Color.Transparent;
      this.picWeigh.Properties.Appearance.Options.UseBackColor = true;
      this.spinEdit1.Location = new Point(3, 5);
      this.spinEdit1.Properties.Appearance.BackColor = Color.Black;
      this.spinEdit1.Properties.Appearance.Font = new Font("Tahoma", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.spinEdit1.Properties.Appearance.ForeColor = Color.Lime;
      this.spinEdit1.Properties.Appearance.Options.UseBackColor = true;
      this.spinEdit1.Properties.Appearance.Options.UseFont = true;
      this.spinEdit1.Properties.Appearance.Options.UseForeColor = true;
      this.spinEdit1.Properties.Appearance.Options.UseTextOptions = true;
      this.spinEdit1.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.spinEdit1.Properties.Appearance.TextOptions.VAlignment = VertAlignment.Center;
      this.spinEdit1.Properties.DisplayFormat.FormatString = "n0";
      this.spinEdit1.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spinEdit1.Properties.EditFormat.FormatString = "n0";
      this.spinEdit1.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spinEdit1.Properties.Mask.EditMask = "n0";
      this.spinEdit1.Size = new Size(74, 34);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Name = "ucWeighFD";
      this.picWeigh.Properties.EndInit();
      this.spinEdit1.Properties.EndInit();
      this.ResumeLayout(false);
    }
  }
}
