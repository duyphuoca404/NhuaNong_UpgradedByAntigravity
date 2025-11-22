using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
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
  public partial class ucSiloFD
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
      this.picBackground.Properties.BeginInit();
      this.spn0.Properties.BeginInit();
      this.spn1.Properties.BeginInit();
      this.spn2.Properties.BeginInit();
      this.spn3.Properties.BeginInit();
      this.SuspendLayout();
      this.picBackground.BackgroundImageLayout = ImageLayout.Center;
      this.picBackground.EditValue = (object)ResourceNhua._silo_FD;
      this.picBackground.Properties.Appearance.BackColor = Color.Transparent;
      this.picBackground.Properties.Appearance.Options.UseBackColor = true;
      this.picBackground.Size = new Size(80, 200);
      this.lblCaption.Appearance.BackColor = Color.LimeGreen;
      this.lblCaption.Appearance.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.lblCaption.Appearance.ForeColor = SystemColors.Window;
      this.lblCaption.Appearance.Options.UseBackColor = true;
      this.lblCaption.Appearance.Options.UseFont = true;
      this.lblCaption.Appearance.Options.UseForeColor = true;
      this.lblCaption.Appearance.Options.UseTextOptions = true;
      this.lblCaption.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.lblCaption.Location = new Point(0, 187);
      this.lblCaption.Size = new Size(80, 13);
      this.lblDesc.Appearance.BackColor = Color.Transparent;
      this.lblDesc.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.lblDesc.Appearance.ForeColor = Color.Black;
      this.lblDesc.Appearance.Options.UseBackColor = true;
      this.lblDesc.Appearance.Options.UseFont = true;
      this.lblDesc.Appearance.Options.UseForeColor = true;
      this.lblDesc.Appearance.Options.UseTextOptions = true;
      this.lblDesc.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.lblDesc.Appearance.TextOptions.VAlignment = VertAlignment.Center;
      this.lblDesc.Appearance.TextOptions.WordWrap = WordWrap.Wrap;
      this.lblDesc.BorderStyle = BorderStyles.NoBorder;
      this.lblDesc.Location = new Point(3, 88);
      this.lblDesc.Size = new Size(74, 20);
      this.lblDesc.Text = "F/D";
      this.spn0.Location = new Point(11, 107);
      this.spn0.Properties.Appearance.BackColor = Color.Black;
      this.spn0.Properties.Appearance.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.spn0.Properties.Appearance.ForeColor = Color.White;
      this.spn0.Properties.Appearance.Options.UseBackColor = true;
      this.spn0.Properties.Appearance.Options.UseFont = true;
      this.spn0.Properties.Appearance.Options.UseForeColor = true;
      this.spn0.Properties.DisplayFormat.FormatString = "n2";
      this.spn0.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spn0.Properties.EditFormat.FormatString = "n2";
      this.spn0.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spn0.Properties.Mask.EditMask = "n2";
      this.spn0.Size = new Size(56, 22);
      this.spn0.Visible = false;
      this.spn1.Location = new Point(3, 20);
      this.spn1.Properties.Appearance.BackColor = Color.Black;
      this.spn1.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.spn1.Properties.Appearance.ForeColor = Color.Red;
      this.spn1.Properties.Appearance.Options.UseBackColor = true;
      this.spn1.Properties.Appearance.Options.UseFont = true;
      this.spn1.Properties.Appearance.Options.UseForeColor = true;
      this.spn1.Properties.DisplayFormat.FormatString = "n0";
      this.spn1.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spn1.Properties.EditFormat.FormatString = "n2";
      this.spn1.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spn1.Properties.Mask.EditMask = "n0";
      this.spn1.Size = new Size(74, 28);
      this.spn2.Location = new Point(3, 51);
      this.spn2.Properties.Appearance.BackColor = Color.Black;
      this.spn2.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.spn2.Properties.Appearance.ForeColor = Color.Lime;
      this.spn2.Properties.Appearance.Options.UseBackColor = true;
      this.spn2.Properties.Appearance.Options.UseFont = true;
      this.spn2.Properties.Appearance.Options.UseForeColor = true;
      this.spn2.Properties.DisplayFormat.FormatString = "n0";
      this.spn2.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spn2.Properties.EditFormat.FormatString = "n2";
      this.spn2.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spn2.Properties.Mask.EditMask = "n0";
      this.spn2.Size = new Size(74, 28);
      this.spn3.Location = new Point(3, 122);
      this.spn3.Properties.Appearance.BackColor = Color.Black;
      this.spn3.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.spn3.Properties.Appearance.ForeColor = Color.Yellow;
      this.spn3.Properties.Appearance.Options.UseBackColor = true;
      this.spn3.Properties.Appearance.Options.UseFont = true;
      this.spn3.Properties.Appearance.Options.UseForeColor = true;
      this.spn3.Properties.DisplayFormat.FormatString = "n0";
      this.spn3.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spn3.Properties.EditFormat.FormatString = "n2";
      this.spn3.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spn3.Properties.Mask.EditMask = "n0";
      this.spn3.Size = new Size(74, 28);
      this.labelControl1.Size = new Size(80, 15);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Name = "ucSiloFD";
      this.SiloDesc = "F/D";
      this.Size = new Size(80, 200);
      this.picBackground.Properties.EndInit();
      this.spn0.Properties.EndInit();
      this.spn1.Properties.EndInit();
      this.spn2.Properties.EndInit();
      this.spn3.Properties.EndInit();
      this.ResumeLayout(false);
    }
  }
}
