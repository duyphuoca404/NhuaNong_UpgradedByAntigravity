// Decompiled with JetBrains decompiler
// Type: NhuaNong.FrmRemind
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong
{
  public class FrmRemind : DialogViewBase
  {
    private IContainer components;
    private PanelControl panelControl1;
    private PictureEdit pictureEdit1;
    private LabelControl labelControl1;
    private LabelControl labelControl2;

    public FrmRemind() => this.InitializeComponent();

    private void FrmRemind_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = true;

    private void FrmRemind_Load(object sender, EventArgs e) => this.EndPreventEvent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmRemind));
      this.panelControl1 = new PanelControl();
      this.labelControl2 = new LabelControl();
      this.labelControl1 = new LabelControl();
      this.pictureEdit1 = new PictureEdit();
      this.panelControl1.BeginInit();
      this.panelControl1.SuspendLayout();
      this.pictureEdit1.Properties.BeginInit();
      this.SuspendLayout();
      this.panelControl1.Controls.Add((Control) this.labelControl2);
      this.panelControl1.Controls.Add((Control) this.labelControl1);
      this.panelControl1.Controls.Add((Control) this.pictureEdit1);
      this.panelControl1.Dock = DockStyle.Fill;
      this.panelControl1.Location = new Point(0, 0);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new Size(833, 440);
      this.panelControl1.TabIndex = 0;
      this.labelControl2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.labelControl2.Appearance.BackColor = Color.Transparent;
      this.labelControl2.Appearance.BackColor2 = Color.Transparent;
      this.labelControl2.Appearance.Font = new Font("Tahoma", 20.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.labelControl2.Appearance.ForeColor = Color.Red;
      this.labelControl2.Appearance.Options.UseBackColor = true;
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Appearance.Options.UseForeColor = true;
      this.labelControl2.AutoSizeMode = LabelAutoSizeMode.None;
      this.labelControl2.Location = new Point(2, 130);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(823, 55);
      this.labelControl2.TabIndex = 2;
      this.labelControl2.Text = "   PHẦN MỀM SẼ CẬP NHẬT SAU 24H\r\n";
      this.labelControl2.Visible = false;
      this.labelControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.labelControl1.Appearance.BackColor = Color.Orange;
      this.labelControl1.Appearance.BackColor2 = Color.FromArgb((int) byte.MaxValue, 128, 128);
      this.labelControl1.Appearance.Font = new Font("Tahoma", 20.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.labelControl1.Appearance.ForeColor = Color.White;
      this.labelControl1.Appearance.Options.UseBackColor = true;
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Appearance.Options.UseForeColor = true;
      this.labelControl1.AutoSizeMode = LabelAutoSizeMode.None;
      this.labelControl1.Location = new Point(5, 205);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(823, 120);
      this.labelControl1.TabIndex = 1;
      this.labelControl1.Text = " VUI LÒNG LIÊN HỆ ĐỘI NGŨ PHÁT TRIỂN ĐỂ ĐƯỢC \r\n CẬP NHẬT PHIÊN BẢN MỚI NHẤT";
      this.labelControl1.Visible = false;
      this.pictureEdit1.BackgroundImage = (Image) componentResourceManager.GetObject("pictureEdit1.BackgroundImage");
      this.pictureEdit1.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureEdit1.Dock = DockStyle.Fill;
      this.pictureEdit1.Location = new Point(2, 2);
      this.pictureEdit1.Name = "pictureEdit1";
      this.pictureEdit1.Properties.Appearance.BackColor = Color.Transparent;
      this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
      this.pictureEdit1.Properties.NullText = " ";
      this.pictureEdit1.Properties.ShowCameraMenuItem = CameraMenuItemVisibility.Auto;
      this.pictureEdit1.Properties.SizeMode = PictureSizeMode.Stretch;
      this.pictureEdit1.Size = new Size(829, 436);
      this.pictureEdit1.TabIndex = 0;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(833, 440);
      this.ControlBox = false;
      this.Controls.Add((Control) this.panelControl1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.IconOptions.Image = (Image) componentResourceManager.GetObject("FrmRemind.IconOptions.Image");
      this.Name = nameof (FrmRemind);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (FrmRemind);
      this.FormClosing += new FormClosingEventHandler(this.FrmRemind_FormClosing);
      this.Load += new EventHandler(this.FrmRemind_Load);
      this.panelControl1.EndInit();
      this.panelControl1.ResumeLayout(false);
      this.pictureEdit1.Properties.EndInit();
      this.ResumeLayout(false);
    }
  }
}
