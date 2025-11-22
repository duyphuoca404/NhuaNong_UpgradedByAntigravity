// Decompiled with JetBrains decompiler
// Type: NhuaNong.DialogViewBase
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.XtraEditors;
using NhuaNong.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong
{
  public partial class DialogViewBase : XtraForm
  {
    private bool _eventIsPrevented;
    //private IContainer components;

    protected bool EventIsPrevented => this._eventIsPrevented;

    protected virtual void PopulateStaticData()
    {
    }

    protected virtual void PopulateData()
    {
    }

    protected virtual void SetupLayout()
    {
    }

    protected virtual void BindData()
    {
    }

    protected virtual void AdjustCulture()
    {
    }

    protected override void OnLoad(EventArgs e)
    {
      try
      {
        this.SetupLayout();
        this.AdjustCulture();
        this.PopulateStaticData();
        this.PopulateData();
        this.BindData();
        base.OnLoad(e);
        this.InitLayout();
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        this.Close();
      }
    }

    protected void StartPreventEvent() => this._eventIsPrevented = true;

    protected void EndPreventEvent() => this._eventIsPrevented = false;

    public DialogViewBase()
    {
      this.InitializeComponent();
      this.Name = nameof(DialogViewBase);
      this.Text = nameof(DialogViewBase);
    }

    /// Loại bỏ phần code này vì nó trùng với những khai báo có trong file .designer.cs (file này dootpeek đã không tạo ra, sử dụng file do DnySpy tạo ra)
    //protected override void Dispose(bool disposing)
    //{
    //  if (disposing && this.components != null)
    //    this.components.Dispose();
    //  base.Dispose(disposing);
    //}

    //private void InitializeComponent()
    //{
    //  this.SuspendLayout();
    //  this.AutoScaleDimensions = new SizeF(7f, 16f);
    //  this.AutoScaleMode = AutoScaleMode.Font;
    //  this.ClientSize = new Size(507, 260);
    //  this.MaximizeBox = false;
    //  this.MinimizeBox = false;
    //  this.Name = nameof (DialogViewBase);
    //  this.ShowInTaskbar = false;
    //  this.StartPosition = FormStartPosition.CenterParent;
    //  this.Text = nameof (DialogViewBase);
    //  this.ResumeLayout(false);
    //}
  }
}
