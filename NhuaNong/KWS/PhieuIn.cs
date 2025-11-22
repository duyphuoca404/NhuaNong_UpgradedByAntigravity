using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.KWS
{
  public partial class PhieuIn : XtraForm
  {
    private FormPhieuIn pi;
    //private IContainer components;

    public PhieuIn()
    {
      this.InitializeComponent();
      this.Name = nameof(PhieuIn);
      this.pi = new FormPhieuIn();
      this.pi.Location = new Point(1, 1);
      this.pi.Size = new Size(1148, 719);
      this.Controls.Add((Control) this.pi);
      this.KeyDown += new KeyEventHandler(this.MainForm_KeyDown);
    }

    private void PhieuIn_KeyDown(object sender, KeyEventArgs e)
    {
      if (!e.Shift)
        return;
      int keyCode = (int) e.KeyCode;
    }

    private void MainForm_KeyDown(object sender, KeyEventArgs e)
    {
      if (!e.Shift || e.KeyCode != Keys.A)
        return;
      this.pi.HandleShortcutKeys(e.KeyCode, e.Shift);
      e.Handled = true;
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
      if (keyData != Keys.F1)
        return base.ProcessCmdKey(ref msg, keyData);
      this.MainForm_KeyDown((object) this, new KeyEventArgs(keyData));
      return true;
    }

    //protected override void Dispose(bool disposing)
    //{
    //  if (disposing && this.components != null)
    //    this.components.Dispose();
    //  base.Dispose(disposing);
    //}

    //private void InitializeComponent()
    //{
    //  this.SuspendLayout();
    //  this.AutoScaleDimensions = new SizeF(6f, 13f);
    //  this.AutoScaleMode = AutoScaleMode.Font;
    //  this.ClientSize = new Size(1148, 713);
    //  this.IconOptions.Image = (Image) ResourceNhua.logoV_64;
    //  this.IconOptions.LargeImage = (Image) ResourceNhua.IIon;
    //  this.KeyPreview = true;
    //  this.MaximizeBox = false;
    //  this.MinimizeBox = false;
    //  this.Name = nameof (PhieuIn);
    //  this.Text = "Phiếu In";
    //  this.KeyDown += new KeyEventHandler(this.PhieuIn_KeyDown);
    //  this.ResumeLayout(false);
    //}
  }
}
