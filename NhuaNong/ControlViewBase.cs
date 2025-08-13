// Decompiled with JetBrains decompiler
// Type: NhuaNong.ControlViewBase
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong
{
  public class ControlViewBase : UserControl
  {
    protected bool IsSuccess;
    protected DialogResult _dlgRes = DialogResult.Cancel;
    private string _caption = "Control View";
    private Enums.FormAction _action;
    private bool _eventIsPrevented;
    private IContainer components;

    public event ControlViewBase.DelFormClosingEventHandler ControlClosing;

    public event ControlViewBase.DelFormClosedEventHandler ControlClosed;

    public string Caption
    {
      get => this._caption;
      set
      {
        this._caption = value;
        if (this.Parent == null || !(this.Parent is XtraForm parent))
          return;
        parent.Text = this._caption;
      }
    }

    protected Enums.FormAction FormAction
    {
      get => this._action;
      set => this._action = value;
    }

    protected bool EventIsPrevented => this._eventIsPrevented;

    protected virtual void PopulateStaticData()
    {
    }

    protected virtual void PopulateData()
    {
    }

    protected virtual void BindData()
    {
    }

    protected virtual void SetupLayout()
    {
    }

    protected virtual void Loaded()
    {
    }

    protected virtual void AdjustCulture()
    {
    }

    protected override void OnLoad(EventArgs e)
    {
      this.SetupLayout();
      try
      {
        this.AdjustCulture();
      }
      catch (System.Exception ex)
      {
      }
      this.PopulateStaticData();
      this.PopulateData();
      this.BindData();
      base.OnLoad(e);
      this.InitLayout();
      this.Loaded();
    }

    protected void StartPreventEvent() => this._eventIsPrevented = true;

    protected void EndPreventEvent() => this._eventIsPrevented = false;

    protected void FocusRow(GridView grv, int focusedRowHandle)
    {
      if (grv.RowCount == 0)
        return;
      if (focusedRowHandle >= grv.RowCount)
        --focusedRowHandle;
      grv.ClearSelection();
      grv.SelectRows(focusedRowHandle, focusedRowHandle);
      grv.FocusedRowHandle = focusedRowHandle;
    }

    protected void FocusRow(AdvBandedGridView gra, int focusedRowHandle)
    {
      if (gra.RowCount == 0)
        return;
      if (focusedRowHandle >= gra.RowCount)
        --focusedRowHandle;
      gra.ClearSelection();
      gra.SelectRows(focusedRowHandle, focusedRowHandle);
      gra.FocusedRowHandle = focusedRowHandle;
    }

    public void DoClosed(FormClosedEventArgs e)
    {
      if (this.ControlClosed == null)
        return;
      this.ControlClosed((object) this, new FormClosedEventArgs(CloseReason.MdiFormClosing));
    }

    public void DoClosing(FormClosingEventArgs e)
    {
      if (this.ControlClosing == null)
        return;
      this.ControlClosing((object) this, e);
    }

    protected void Close()
    {
      if (this.Parent == null || !(this.Parent is XtraForm parent))
        return;
      parent.Close();
      parent.Dispose();
    }

    private void frm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (this.ControlClosing == null)
        return;
      this.ControlClosing(sender, e);
    }

    private void frm_FormClosed(object sender, FormClosedEventArgs e)
    {
      if (this.ControlClosed == null)
        return;
      this.ControlClosed(sender, e);
    }

    public virtual List<T> GetSelectedObjects<T>() where T : class
    {
      throw new NotImplementedException();
    }

    public DialogResult GetDialogResult() => this._dlgRes;

    public bool GetIsSuccess() => this.IsSuccess;

    public virtual void DoKeyDown(object sender, KeyEventArgs e)
    {
    }

    public ControlViewBase() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.SuspendLayout();
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Control;
      this.Margin = new Padding(2);
      this.Name = nameof (ControlViewBase);
      this.Size = new Size(743, 382);
      this.ResumeLayout(false);
    }

    public delegate void DelFormClosingEventHandler(object sender, FormClosingEventArgs e);

    public delegate void DelFormClosedEventHandler(object sender, FormClosedEventArgs e);
  }
}
