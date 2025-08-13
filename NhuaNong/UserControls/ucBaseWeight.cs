// Decompiled with JetBrains decompiler
// Type: NhuaNong.UserControls.ucBaseWeight
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.UserControls
{
  public class ucBaseWeight : XtraUserControl
  {
    private Decimal _weight;
    private IContainer components;
    private PanelControl panelControl2;
    public PictureEdit picWeigh;
    private PanelControl panelControl3;
    private PictureEdit picLebEmpty;
    public SpinEdit spinEdit1;

    public event ucBaseWeight.DelCaptionEventHandler WeightClick;

    public Decimal Weight
    {
      get => this.spinEdit1.Value;
      set => this.spinEdit1.Value = value;
    }

    public ucBaseWeight() => this.InitializeComponent();

    public Decimal GiaTriWeight
    {
      get => Convert.ToDecimal(this.spinEdit1.EditValue);
      set => this.spinEdit1.EditValue = (object) value;
    }

    private void picWeigh_Click(object sender, EventArgs e)
    {
      if (this.WeightClick == null)
        return;
      this.WeightClick((object) this, new EventArgs());
    }

    private void spinEdit1_Click(object sender, EventArgs e)
    {
      if (this.WeightClick == null)
        return;
      this.WeightClick((object) this, new EventArgs());
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.panelControl2 = new PanelControl();
      this.spinEdit1 = new SpinEdit();
      this.picWeigh = new PictureEdit();
      this.panelControl3 = new PanelControl();
      this.picLebEmpty = new PictureEdit();
      this.panelControl2.BeginInit();
      this.panelControl2.SuspendLayout();
      this.spinEdit1.Properties.BeginInit();
      this.picWeigh.Properties.BeginInit();
      this.panelControl3.BeginInit();
      this.panelControl3.SuspendLayout();
      this.picLebEmpty.Properties.BeginInit();
      this.SuspendLayout();
      this.panelControl2.BorderStyle = BorderStyles.NoBorder;
      this.panelControl2.Controls.Add((Control) this.spinEdit1);
      this.panelControl2.Controls.Add((Control) this.picWeigh);
      this.panelControl2.Dock = DockStyle.Fill;
      this.panelControl2.Location = new Point(0, 0);
      this.panelControl2.Margin = new Padding(3, 2, 3, 2);
      this.panelControl2.Name = "panelControl2";
      this.panelControl2.Size = new Size(80, 78);
      this.panelControl2.TabIndex = 1;
      this.spinEdit1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.spinEdit1.EditValue = (object) new Decimal(new int[4]);
      this.spinEdit1.Location = new Point(3, 3);
      this.spinEdit1.Name = "spinEdit1";
      this.spinEdit1.Properties.AllowFocused = false;
      this.spinEdit1.Properties.Appearance.BackColor = Color.Black;
      this.spinEdit1.Properties.Appearance.Font = new Font("Tahoma", 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.spinEdit1.Properties.Appearance.ForeColor = Color.Lime;
      this.spinEdit1.Properties.Appearance.Options.UseBackColor = true;
      this.spinEdit1.Properties.Appearance.Options.UseFont = true;
      this.spinEdit1.Properties.Appearance.Options.UseForeColor = true;
      this.spinEdit1.Properties.Appearance.Options.UseTextOptions = true;
      this.spinEdit1.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.spinEdit1.Properties.Appearance.TextOptions.VAlignment = VertAlignment.Center;
      this.spinEdit1.Properties.BorderStyle = BorderStyles.Flat;
      this.spinEdit1.Properties.DisplayFormat.FormatString = "n0";
      this.spinEdit1.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spinEdit1.Properties.EditFormat.FormatString = "n0";
      this.spinEdit1.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spinEdit1.Properties.Mask.EditMask = "n0";
      this.spinEdit1.Properties.ReadOnly = true;
      this.spinEdit1.Size = new Size(74, 32);
      this.spinEdit1.TabIndex = 1;
      this.spinEdit1.Click += new EventHandler(this.spinEdit1_Click);
      this.picWeigh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.picWeigh.BackgroundImage = (Image) ResourceNhua._can_FD;
      this.picWeigh.BackgroundImageLayout = ImageLayout.Stretch;
      this.picWeigh.Location = new Point(0, 2);
      this.picWeigh.Margin = new Padding(3, 2, 3, 2);
      this.picWeigh.Name = "picWeigh";
      this.picWeigh.Properties.AllowFocused = false;
      this.picWeigh.Properties.Appearance.BackColor = Color.Transparent;
      this.picWeigh.Properties.Appearance.Options.UseBackColor = true;
      this.picWeigh.Properties.BorderStyle = BorderStyles.NoBorder;
      this.picWeigh.Properties.NullText = " ";
      this.picWeigh.Properties.ReadOnly = true;
      this.picWeigh.Properties.ShowCameraMenuItem = CameraMenuItemVisibility.Auto;
      this.picWeigh.Properties.SizeMode = PictureSizeMode.Stretch;
      this.picWeigh.Size = new Size(80, 60);
      this.picWeigh.TabIndex = 0;
      this.picWeigh.Click += new EventHandler(this.picWeigh_Click);
      this.panelControl3.BorderStyle = BorderStyles.NoBorder;
      this.panelControl3.Controls.Add((Control) this.picLebEmpty);
      this.panelControl3.Dock = DockStyle.Bottom;
      this.panelControl3.Location = new Point(0, 63);
      this.panelControl3.Margin = new Padding(3, 2, 3, 2);
      this.panelControl3.Name = "panelControl3";
      this.panelControl3.Size = new Size(80, 15);
      this.panelControl3.TabIndex = 2;
      this.picLebEmpty.BackgroundImageLayout = ImageLayout.Stretch;
      this.picLebEmpty.Dock = DockStyle.Fill;
      this.picLebEmpty.Location = new Point(0, 0);
      this.picLebEmpty.Margin = new Padding(3, 2, 3, 2);
      this.picLebEmpty.Name = "picLebEmpty";
      this.picLebEmpty.Properties.AllowFocused = false;
      this.picLebEmpty.Properties.Appearance.BackColor = Color.Transparent;
      this.picLebEmpty.Properties.Appearance.Options.UseBackColor = true;
      this.picLebEmpty.Properties.BorderStyle = BorderStyles.NoBorder;
      this.picLebEmpty.Properties.NullText = " ";
      this.picLebEmpty.Properties.ReadOnly = true;
      this.picLebEmpty.Properties.ShowCameraMenuItem = CameraMenuItemVisibility.Auto;
      this.picLebEmpty.Properties.SizeMode = PictureSizeMode.Stretch;
      this.picLebEmpty.Size = new Size(80, 15);
      this.picLebEmpty.TabIndex = 0;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.panelControl3);
      this.Controls.Add((Control) this.panelControl2);
      this.Margin = new Padding(3, 2, 3, 2);
      this.Name = nameof (ucBaseWeight);
      this.Size = new Size(80, 78);
      this.panelControl2.EndInit();
      this.panelControl2.ResumeLayout(false);
      this.spinEdit1.Properties.EndInit();
      this.picWeigh.Properties.EndInit();
      this.panelControl3.EndInit();
      this.panelControl3.ResumeLayout(false);
      this.picLebEmpty.Properties.EndInit();
      this.ResumeLayout(false);
    }

    public delegate void DelCaptionEventHandler(object sender, EventArgs e);
  }
}
