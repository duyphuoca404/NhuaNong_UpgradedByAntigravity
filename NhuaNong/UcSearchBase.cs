// Decompiled with JetBrains decompiler
// Type: NhuaNong.UcSearchBase
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong
{
  public partial class UcSearchBase : ControlViewBase
  {
    

    private UcSearchBase()
    {
      this.InitializeComponent();
      this.Name = nameof(UcSearchBase);
      this.Text = nameof(UcSearchBase);
    }

    public UcSearchBase(ControlViewBase ctrView, string caption)
      : this()
    {
      ctrView.Dock = DockStyle.Fill;
      this.pnlContainer.Controls.Add((Control) ctrView);
      int num = (int) MessageBox.Show(this.pnlContainer.Controls.Count.ToString());
      this.Caption = caption;
    }

    public new List<T> GetSelectedObjects<T>() where T : class
    {
      return this.pnlContainer.Controls.Count > 0 ? (this.pnlContainer.Controls[0] as ControlViewBase).GetSelectedObjects<T>() : (List<T>) null;
    }

    private void btnSelect_Click(object sender, EventArgs e) => this._dlgRes = DialogResult.OK;

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this._dlgRes = DialogResult.Cancel;
      this.Close();
    }

    
  }
}
