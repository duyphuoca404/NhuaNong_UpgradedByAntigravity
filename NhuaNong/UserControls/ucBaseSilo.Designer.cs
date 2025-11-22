using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using NhuaNong.MasterData;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NhuaNong.UserControls
{
  public partial class ucBaseSilo
  {
    private IContainer components;
    protected PictureEdit picBackground;
    protected LabelControl lblCaption;
    protected LabelControl lblDesc;
    protected SpinEdit spn0;
    protected SpinEdit spn1;
    protected SpinEdit spn2;
    protected SpinEdit spn3;
    public LabelControl labelControl1;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.picBackground = new PictureEdit();
      this.lblCaption = new LabelControl();
      this.lblDesc = new LabelControl();
      this.spn0 = new SpinEdit();
      this.spn1 = new SpinEdit();
      this.spn2 = new SpinEdit();
      this.spn3 = new SpinEdit();
      this.labelControl1 = new LabelControl();
      this.picBackground.Properties.BeginInit();
      this.spn0.Properties.BeginInit();
      this.spn1.Properties.BeginInit();
      this.spn2.Properties.BeginInit();
      this.spn3.Properties.BeginInit();
      this.SuspendLayout();
      this.picBackground.AllowDrop = true;
      this.picBackground.Dock = DockStyle.Fill;
      this.picBackground.Location = new Point(0, 0);
      this.picBackground.Margin = new Padding(3, 2, 3, 2);
      this.picBackground.Name = "picBackground";
      this.picBackground.Properties.AllowFocused = false;
      this.picBackground.Properties.Appearance.BackColor = Color.Maroon;
      this.picBackground.Properties.Appearance.Options.UseBackColor = true;
      this.picBackground.Properties.BorderStyle = BorderStyles.NoBorder;
      this.picBackground.Properties.ShowCameraMenuItem = CameraMenuItemVisibility.Auto;
      this.picBackground.Size = new Size(100, 206);
      this.picBackground.TabIndex = 0;
      this.picBackground.Click += new EventHandler(this.picBackground_Click);
      this.lblCaption.Appearance.BackColor = Color.LimeGreen;
      this.lblCaption.Appearance.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.lblCaption.Appearance.ForeColor = SystemColors.Window;
      this.lblCaption.Appearance.Options.UseBackColor = true;
      this.lblCaption.Appearance.Options.UseFont = true;
      this.lblCaption.Appearance.Options.UseForeColor = true;
      this.lblCaption.Appearance.Options.UseTextOptions = true;
      this.lblCaption.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.lblCaption.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblCaption.BorderStyle = BorderStyles.Flat;
      this.lblCaption.Dock = DockStyle.Bottom;
      this.lblCaption.Location = new Point(0, 193);
      this.lblCaption.Name = "lblCaption";
      this.lblCaption.Size = new Size(100, 13);
      this.lblCaption.TabIndex = 3;
      this.lblCaption.Text = "SILO";
      this.lblCaption.Visible = false;
      this.lblCaption.TextChanged += new EventHandler(this.lblCaption_TextChanged);
      this.lblCaption.Click += new EventHandler(this.lblCaption_Click);
      this.lblDesc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.lblDesc.Appearance.BackColor = Color.Transparent;
      this.lblDesc.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.lblDesc.Appearance.ForeColor = Color.White;
      this.lblDesc.Appearance.Options.UseBackColor = true;
      this.lblDesc.Appearance.Options.UseFont = true;
      this.lblDesc.Appearance.Options.UseForeColor = true;
      this.lblDesc.Appearance.Options.UseTextOptions = true;
      this.lblDesc.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.lblDesc.Appearance.TextOptions.VAlignment = VertAlignment.Bottom;
      this.lblDesc.Appearance.TextOptions.WordWrap = WordWrap.Wrap;
      this.lblDesc.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblDesc.Location = new Point(3, 86);
      this.lblDesc.Margin = new Padding(3, 2, 3, 2);
      this.lblDesc.Name = "lblDesc";
      this.lblDesc.Size = new Size(92, 25);
      this.lblDesc.TabIndex = 3;
      this.lblDesc.Text = "Diễn Giải";
      this.lblDesc.MouseHover += new EventHandler(this.lblDesc_MouseHover);
      this.spn0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.spn0.EditValue = (object)new Decimal(new int[4]);
      this.spn0.Location = new Point(3, 107);
      this.spn0.Name = "spn0";
      this.spn0.Properties.Appearance.BackColor = Color.Black;
      this.spn0.Properties.Appearance.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.spn0.Properties.Appearance.ForeColor = Color.White;
      this.spn0.Properties.Appearance.Options.UseBackColor = true;
      this.spn0.Properties.Appearance.Options.UseFont = true;
      this.spn0.Properties.Appearance.Options.UseForeColor = true;
      this.spn0.Properties.BorderStyle = BorderStyles.Style3D;
      this.spn0.Properties.DisplayFormat.FormatString = "n2";
      this.spn0.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spn0.Properties.EditFormat.FormatString = "n2";
      this.spn0.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spn0.Properties.Mask.EditMask = "n2";
      this.spn0.Properties.MaxValue = new Decimal(new int[4]
      {
        99,
        0,
        0,
        0
      });
      this.spn0.Size = new Size(92, 22);
      this.spn0.TabIndex = 3;
      this.spn0.ToolTip = "Độ Ẩm Cát Đá";
      this.spn0.EditValueChanged += new EventHandler(this.spn0_EditValueChanged);
      this.spn1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.spn1.EditValue = (object)new Decimal(new int[4]);
      this.spn1.Location = new Point(3, 34);
      this.spn1.Margin = new Padding(3, 2, 3, 2);
      this.spn1.Name = "spn1";
      this.spn1.Properties.AllowFocused = false;
      this.spn1.Properties.Appearance.BackColor = Color.Black;
      this.spn1.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.spn1.Properties.Appearance.ForeColor = Color.Red;
      this.spn1.Properties.Appearance.Options.UseBackColor = true;
      this.spn1.Properties.Appearance.Options.UseFont = true;
      this.spn1.Properties.Appearance.Options.UseForeColor = true;
      this.spn1.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.spn1.Properties.BorderStyle = BorderStyles.Flat;
      this.spn1.Properties.DisplayFormat.FormatString = "n0";
      this.spn1.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spn1.Properties.EditFormat.FormatString = "n2";
      this.spn1.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spn1.Properties.Mask.EditMask = "n0";
      this.spn1.Properties.ReadOnly = true;
      this.spn1.Size = new Size(92, 24);
      this.spn1.TabIndex = 4;
      this.spn1.ToolTip = "KL Cài Đặt";
      this.spn1.Click += new EventHandler(this.spn1_Click);
      this.spn2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.spn2.EditValue = (object)new Decimal(new int[4]);
      this.spn2.Location = new Point(3, 60);
      this.spn2.Margin = new Padding(3, 2, 3, 2);
      this.spn2.Name = "spn2";
      this.spn2.Properties.AllowFocused = false;
      this.spn2.Properties.Appearance.BackColor = Color.Black;
      this.spn2.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.spn2.Properties.Appearance.ForeColor = Color.Lime;
      this.spn2.Properties.Appearance.Options.UseBackColor = true;
      this.spn2.Properties.Appearance.Options.UseFont = true;
      this.spn2.Properties.Appearance.Options.UseForeColor = true;
      this.spn2.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.spn2.Properties.BorderStyle = BorderStyles.Flat;
      this.spn2.Properties.DisplayFormat.FormatString = "n0";
      this.spn2.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spn2.Properties.EditFormat.FormatString = "n2";
      this.spn2.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spn2.Properties.Mask.EditMask = "n0";
      this.spn2.Properties.ReadOnly = true;
      this.spn2.Size = new Size(92, 24);
      this.spn2.TabIndex = 5;
      this.spn2.ToolTip = "KL Cần Cân";
      this.spn2.Click += new EventHandler(this.spn2_Click);
      this.spn3.EditValue = (object)new Decimal(new int[4]);
      this.spn3.Location = new Point(3, 132);
      this.spn3.Margin = new Padding(3, 2, 3, 2);
      this.spn3.Name = "spn3";
      this.spn3.Properties.AllowFocused = false;
      this.spn3.Properties.Appearance.BackColor = Color.Black;
      this.spn3.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.spn3.Properties.Appearance.ForeColor = Color.Yellow;
      this.spn3.Properties.Appearance.Options.UseBackColor = true;
      this.spn3.Properties.Appearance.Options.UseFont = true;
      this.spn3.Properties.Appearance.Options.UseForeColor = true;
      this.spn3.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.spn3.Properties.BorderStyle = BorderStyles.Flat;
      this.spn3.Properties.DisplayFormat.FormatString = "n0";
      this.spn3.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spn3.Properties.EditFormat.FormatString = "n2";
      this.spn3.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spn3.Properties.Mask.EditMask = "n0";
      this.spn3.Properties.ReadOnly = true;
      this.spn3.Size = new Size(92, 24);
      this.spn3.TabIndex = 6;
      this.spn3.ToolTip = "KL Thực Tế";
      this.spn3.Click += new EventHandler(this.spn3_Click);
      this.labelControl1.AutoSizeMode = LabelAutoSizeMode.None;
      this.labelControl1.BorderStyle = BorderStyles.NoBorder;
      this.labelControl1.Dock = DockStyle.Top;
      this.labelControl1.Location = new Point(0, 0);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(100, 15);
      this.labelControl1.TabIndex = 1;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control)this.labelControl1);
      this.Controls.Add((Control)this.spn3);
      this.Controls.Add((Control)this.spn2);
      this.Controls.Add((Control)this.spn1);
      this.Controls.Add((Control)this.spn0);
      this.Controls.Add((Control)this.lblDesc);
      this.Controls.Add((Control)this.lblCaption);
      this.Controls.Add((Control)this.picBackground);
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = "ucBaseSilo";
      this.Size = new Size(100, 206);
      this.picBackground.Properties.EndInit();
      this.spn0.Properties.EndInit();
      this.spn1.Properties.EndInit();
      this.spn2.Properties.EndInit();
      this.spn3.Properties.EndInit();
      this.ResumeLayout(false);
    }
  }
}
