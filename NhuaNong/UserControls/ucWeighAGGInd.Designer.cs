using DevExpress.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NhuaNong.UserControls
{
  public partial class ucWeighAGGInd
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
      this.picWeigh.Properties.BeginInit();
      this.spinEdit1.Properties.BeginInit();
      this.SuspendLayout();
      
      // picWeigh - Hình nền phễu cân, dùng hình cân AGG
      this.picWeigh.Anchor = AnchorStyles.Top | AnchorStyles.Left;
      this.picWeigh.BackgroundImage = (Image)ResourceNhua._can_AGG;
      this.picWeigh.Location = new Point(0, 0);
      this.picWeigh.Properties.Appearance.BackColor = Color.Transparent;
      this.picWeigh.Properties.Appearance.Options.UseBackColor = true;
      this.picWeigh.Size = new Size(80, 60);
      
      // spinEdit1 - Hiển thị giá trị cân
      this.spinEdit1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
      this.spinEdit1.Location = new Point(5, 3);
      this.spinEdit1.Properties.Appearance.BackColor = Color.Black;
      this.spinEdit1.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
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
      this.spinEdit1.Properties.MaskSettings.Set("mask", (object)"n0");
      this.spinEdit1.Size = new Size(70, 24);
      
      // ucWeighAGGInd
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Name = "ucWeighAGGInd";
      this.Size = new Size(80, 78);
      
      this.picWeigh.Properties.EndInit();
      this.spinEdit1.Properties.EndInit();
      this.ResumeLayout(false);
    }
  }
}
