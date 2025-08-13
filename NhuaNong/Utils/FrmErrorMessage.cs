// Decompiled with JetBrains decompiler
// Type: NhuaNong.Utils.FrmErrorMessage
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.Utils
{
  public class FrmErrorMessage : XtraForm
  {
    private int _originSize;
    private int _fixedSize;
    private bool _showException;
    private string _alertMsg = "Error in system.\nPlease contact with Aministrator for more detail.";
    private string _errorContent = string.Empty;
    private PictureEdit picIcon;
    private SimpleButton btnOk;
    private PanelControl panelControl1;
    private PanelControl panelControl2;
    private PanelControl pnlException;
    private LabelControl lblErrorMessage;
    private MemoEdit memException;
    private PictureEdit picDown;
    private IContainer components;

    public string AlertMessage
    {
      get => this._alertMsg;
      set => this._alertMsg = value;
    }

    public string ErrorContent
    {
      get => this._errorContent;
      set => this._errorContent = value;
    }

    public FrmErrorMessage()
    {
      this.InitializeComponent();
      this._originSize = this.Height;
      this._fixedSize = this.Height - this.pnlException.Height;
    }

    public FrmErrorMessage(System.Exception ex, bool showException)
      : this()
    {
      this._errorContent = ex.ToString();
      this._showException = showException;
    }

    public FrmErrorMessage(string errorContent, bool showException)
      : this()
    {
      this._errorContent = errorContent;
      this._showException = showException;
    }

    private void ShowException(bool showException)
    {
      this.pnlException.Visible = showException;
      this.Height = showException ? this._originSize : this._fixedSize;
    }

    private void picDown_MouseUp(object sender, MouseEventArgs e)
    {
      this.ShowException(!this.pnlException.Visible);
      this.btnOk.Focus();
    }

    private void btnOk_Click(object sender, EventArgs e) => this.Close();

    private void FrmErrorMessage_Load(object sender, EventArgs e)
    {
      this.ShowException(this._showException);
      this.lblErrorMessage.Text = this._alertMsg;
      this.memException.Text = this._errorContent;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.SuspendLayout();
      this.ClientSize = new Size(346, 260);
      this.Name = nameof (FrmErrorMessage);
      this.ResumeLayout(false);
    }
  }
}
