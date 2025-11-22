using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NhuaNong.UserControls
{
  public partial class ucSoMeDaCan
  {
    private IContainer components;
    private LabelControl labelControl1;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.labelControl1 = new LabelControl();
      this.SuspendLayout();
      this.labelControl1.Appearance.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Appearance.Options.UseTextOptions = true;
      this.labelControl1.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.labelControl1.Appearance.TextOptions.VAlignment = VertAlignment.Center;
      this.labelControl1.AutoSizeMode = LabelAutoSizeMode.None;
      this.labelControl1.BorderStyle = BorderStyles.Simple;
      this.labelControl1.Dock = DockStyle.Fill;
      this.labelControl1.Location = new Point(0, 0);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(65, 20);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "01/01";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control)this.labelControl1);
      this.Name = "ucSoMeDaCan";
      this.Size = new Size(65, 20);
      this.ResumeLayout(false);
    }
  }
}
