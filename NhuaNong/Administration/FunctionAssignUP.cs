// Decompiled with JetBrains decompiler
// Type: NhuaNong.Administration.FunctionAssignUP
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using NhuaNong.Data;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.Administration
{
  public class FunctionAssignUP : ControlViewBase, IFunctionAssignView, IBase
  {
    private FunctionAssignDataPresenter _presenter;
    private ObjSEC_Role _role;
    private BindingList<ObjSEC_Function> _blstFunction_FuncType = new BindingList<ObjSEC_Function>();
    private BindingList<ObjSEC_Function> _blstFunction_MenuType = new BindingList<ObjSEC_Function>();
    private BindingList<ObjSEC_Role> _blstRole = new BindingList<ObjSEC_Role>();
    private BindingList<ObjSEC_RoleFunction> _blstRoleFunction = new BindingList<ObjSEC_RoleFunction>();
    private IContainer components;
    private GridControl grcRole;
    private GridView grvRole;
    private GridColumn gcRoleName;
    private GridControl grcFunction;
    private GridView grvFunction;
    private GridColumn gcSelect;
    private GridColumn gcFunctionName;
    private RepositoryItemCheckEdit ichkSelect;
    private GridView grvFunctionDetail;
    private GridColumn gcSelectDet;
    private RepositoryItemCheckEdit ichkSelectDet;
    private GridColumn gcFunctionNameDet;
    private PanelControl pnlMain;
    private PanelControl panelControl1;
    private SimpleButton btnClose;
    private SimpleButton btnSave;

    public FunctionAssignUP()
    {
      this.InitializeComponent();
      this._presenter = new FunctionAssignDataPresenter((IFunctionAssignView) this);
      this.Caption = "Phân quyền chức năng";
    }

    BindingList<ObjSEC_Function> IFunctionAssignView.BLstFunction_FuncType
    {
      set
      {
        this._blstFunction_FuncType = value;
        foreach (ObjSEC_Function objSecFunction1 in (Collection<ObjSEC_Function>) this._blstFunction_MenuType)
        {
          objSecFunction1.LstChildFunction = new List<ObjSEC_Function>();
          foreach (ObjSEC_Function objSecFunction2 in (Collection<ObjSEC_Function>) this._blstFunction_FuncType)
          {
            int? parentId = objSecFunction2.ParentID;
            int functionId = objSecFunction1.FunctionID;
            if (parentId.GetValueOrDefault() == functionId & parentId.HasValue)
              objSecFunction1.LstChildFunction.Add(objSecFunction2);
          }
        }
      }
    }

    BindingList<ObjSEC_Function> IFunctionAssignView.BLstFunction_MenuType
    {
      set
      {
        this._blstFunction_MenuType = value;
        this.grcFunction.DataSource = (object) this._blstFunction_MenuType;
      }
    }

    BindingList<ObjSEC_Role> IFunctionAssignView.BLstRole
    {
      set
      {
        this._blstRole = value;
        this.grcRole.DataSource = (object) this._blstRole;
      }
    }

    BindingList<ObjSEC_RoleFunction> IFunctionAssignView.BLstRoleFunction
    {
      set
      {
        this._blstRoleFunction = value;
        this.MapRoleFunction();
      }
    }

    bool IFunctionAssignView.IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    protected override void PopulateStaticData()
    {
      this._presenter.ListRole();
      this._presenter.ListFunction_MenuType();
      this._presenter.ListFunction_FuncType();
    }

    protected override void PopulateData() => this._presenter.ListRoleFunction();

    private void MapRoleFunction()
    {
      foreach (ObjSEC_Function function in (Collection<ObjSEC_Function>) this._blstFunction_MenuType)
        function.NPSelect = this.CheckIsSelected(this._role, function);
      foreach (ObjSEC_Function function in (Collection<ObjSEC_Function>) this._blstFunction_FuncType)
        function.NPSelect = this.CheckIsSelected(this._role, function);
      this.grvFunction.RefreshData();
      for (int rowHandle = 0; rowHandle < this.grvFunction.DataRowCount; ++rowHandle)
      {
        if (this.grvFunction.GetVisibleDetailView(rowHandle) is GridView visibleDetailView)
          visibleDetailView.RefreshData();
      }
    }

    private bool CheckIsSelected(ObjSEC_Role role, ObjSEC_Function function)
    {
      foreach (ObjSEC_RoleFunction objSecRoleFunction in (Collection<ObjSEC_RoleFunction>) this._blstRoleFunction)
      {
        if (!objSecRoleFunction.MarkAsDeleted && objSecRoleFunction.RoleID == role.RoleID && objSecRoleFunction.FunctionID == function.FunctionID)
          return true;
      }
      return false;
    }

    private ObjSEC_RoleFunction GetRoleFunction(ObjSEC_Role role, ObjSEC_Function function)
    {
      foreach (ObjSEC_RoleFunction roleFunction in (Collection<ObjSEC_RoleFunction>) this._blstRoleFunction)
      {
        if (roleFunction.RoleID == role.RoleID && roleFunction.FunctionID == function.FunctionID)
          return roleFunction;
      }
      return (ObjSEC_RoleFunction) null;
    }

    private void AssignFunction(ObjSEC_Role role, ObjSEC_Function function, bool isAssign)
    {
      if (isAssign)
      {
        ObjSEC_RoleFunction roleFunction = this.GetRoleFunction(role, function);
        if (roleFunction == null)
          this._blstRoleFunction.Add(new ObjSEC_RoleFunction()
          {
            RoleID = role.RoleID,
            FunctionID = function.FunctionID
          });
        else
          roleFunction.MarkAsDeleted = false;
      }
      else
      {
        ObjSEC_RoleFunction roleFunction = this.GetRoleFunction(role, function);
        if (roleFunction.IsNewObject)
          this._blstRoleFunction.Remove(roleFunction);
        else
          roleFunction.MarkAsDeleted = true;
      }
    }

    private void SaveData() => this._presenter.SaveRoleFunction(this._blstRoleFunction);

    private void SuccessfullySave(bool isSuccess)
    {
      if (!isSuccess)
        return;
      this._presenter.ListRoleFunction();
      TramTromMessageBox.ShowMessageDialog(GlobalValues.Messages.SuccessProceed);
    }

    private void grvRole_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
    {
      if (e.FocusedRowHandle < 0)
        return;
      this._role = this.grvRole.GetRow(this.grvRole.FocusedRowHandle) as ObjSEC_Role;
      this.MapRoleFunction();
    }

    private void grvFunction_CellValueChanging(object sender, CellValueChangedEventArgs e)
    {
      this.AssignFunction(this._role, this.grvFunction.GetRow(this.grvFunction.FocusedRowHandle) as ObjSEC_Function, Convert.ToBoolean(e.Value));
    }

    private void grvFunctionDetail_CellValueChanging(object sender, CellValueChangedEventArgs e)
    {
      this.AssignFunction(this._role, (sender as GridView).GetRow(e.RowHandle) as ObjSEC_Function, Convert.ToBoolean(e.Value));
    }

    private void btnSave_Click(object sender, EventArgs e) => this.SaveData();

    private void btnClose_Click(object sender, EventArgs e) => this.Close();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      GridLevelNode gridLevelNode = new GridLevelNode();
      this.grvFunctionDetail = new GridView();
      this.gcSelectDet = new GridColumn();
      this.ichkSelectDet = new RepositoryItemCheckEdit();
      this.gcFunctionNameDet = new GridColumn();
      this.grcFunction = new GridControl();
      this.grvFunction = new GridView();
      this.gcSelect = new GridColumn();
      this.ichkSelect = new RepositoryItemCheckEdit();
      this.gcFunctionName = new GridColumn();
      this.grcRole = new GridControl();
      this.grvRole = new GridView();
      this.gcRoleName = new GridColumn();
      this.pnlMain = new PanelControl();
      this.panelControl1 = new PanelControl();
      this.btnClose = new SimpleButton();
      this.btnSave = new SimpleButton();
      this.grvFunctionDetail.BeginInit();
      this.ichkSelectDet.BeginInit();
      this.grcFunction.BeginInit();
      this.grvFunction.BeginInit();
      this.ichkSelect.BeginInit();
      this.grcRole.BeginInit();
      this.grvRole.BeginInit();
      this.pnlMain.BeginInit();
      this.pnlMain.SuspendLayout();
      this.panelControl1.BeginInit();
      this.panelControl1.SuspendLayout();
      this.SuspendLayout();
      this.grvFunctionDetail.Appearance.Row.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.grvFunctionDetail.Appearance.Row.Options.UseFont = true;
      this.grvFunctionDetail.BorderStyle = BorderStyles.Flat;
      this.grvFunctionDetail.Columns.AddRange(new GridColumn[2]
      {
        this.gcSelectDet,
        this.gcFunctionNameDet
      });
      this.grvFunctionDetail.FocusRectStyle = DrawFocusRectStyle.None;
      this.grvFunctionDetail.GridControl = this.grcFunction;
      this.grvFunctionDetail.Name = "grvFunctionDetail";
      this.grvFunctionDetail.OptionsView.ShowColumnHeaders = false;
      this.grvFunctionDetail.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
      this.grvFunctionDetail.OptionsView.ShowGroupExpandCollapseButtons = false;
      this.grvFunctionDetail.OptionsView.ShowGroupPanel = false;
      this.grvFunctionDetail.OptionsView.ShowHorizontalLines = DefaultBoolean.False;
      this.grvFunctionDetail.OptionsView.ShowIndicator = false;
      this.grvFunctionDetail.OptionsView.ShowVerticalLines = DefaultBoolean.False;
      this.grvFunctionDetail.ViewCaption = " ";
      this.grvFunctionDetail.CellValueChanging += new CellValueChangedEventHandler(this.grvFunctionDetail_CellValueChanging);
      this.gcSelectDet.Caption = "Select";
      this.gcSelectDet.ColumnEdit = (RepositoryItem) this.ichkSelectDet;
      this.gcSelectDet.FieldName = "NPSelect";
      this.gcSelectDet.Name = "gcSelectDet";
      this.gcSelectDet.Visible = true;
      this.gcSelectDet.VisibleIndex = 0;
      this.ichkSelectDet.AutoHeight = false;
      this.ichkSelectDet.Name = "ichkSelectDet";
      this.gcFunctionNameDet.Caption = "Detail";
      this.gcFunctionNameDet.FieldName = "FunctionName";
      this.gcFunctionNameDet.Name = "gcFunctionNameDet";
      this.gcFunctionNameDet.OptionsColumn.AllowEdit = false;
      this.gcFunctionNameDet.OptionsColumn.AllowFocus = false;
      this.gcFunctionNameDet.Visible = true;
      this.gcFunctionNameDet.VisibleIndex = 1;
      this.gcFunctionNameDet.Width = 250;
      this.grcFunction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.grcFunction.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridLevelNode.LevelTemplate = (BaseView) this.grvFunctionDetail;
      gridLevelNode.RelationName = "LstChildFunction";
      this.grcFunction.LevelTree.Nodes.AddRange(new GridLevelNode[1]
      {
        gridLevelNode
      });
      this.grcFunction.Location = new Point(281, 5);
      this.grcFunction.MainView = (BaseView) this.grvFunction;
      this.grcFunction.Name = "grcFunction";
      this.grcFunction.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.ichkSelect,
        (RepositoryItem) this.ichkSelectDet
      });
      this.grcFunction.ShowOnlyPredefinedDetails = true;
      this.grcFunction.Size = new Size(400, 576);
      this.grcFunction.TabIndex = 1;
      this.grcFunction.ViewCollection.AddRange(new BaseView[2]
      {
        (BaseView) this.grvFunction,
        (BaseView) this.grvFunctionDetail
      });
      this.grvFunction.Appearance.Row.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.grvFunction.Appearance.Row.Options.UseFont = true;
      this.grvFunction.Columns.AddRange(new GridColumn[2]
      {
        this.gcSelect,
        this.gcFunctionName
      });
      this.grvFunction.FocusRectStyle = DrawFocusRectStyle.None;
      this.grvFunction.GridControl = this.grcFunction;
      this.grvFunction.Name = "grvFunction";
      this.grvFunction.OptionsView.ShowColumnHeaders = false;
      this.grvFunction.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
      this.grvFunction.OptionsView.ShowGroupPanel = false;
      this.grvFunction.OptionsView.ShowHorizontalLines = DefaultBoolean.False;
      this.grvFunction.OptionsView.ShowIndicator = false;
      this.grvFunction.OptionsView.ShowVerticalLines = DefaultBoolean.False;
      this.grvFunction.OptionsView.ShowViewCaption = true;
      this.grvFunction.ViewCaption = "Chức năng";
      this.grvFunction.CellValueChanging += new CellValueChangedEventHandler(this.grvFunction_CellValueChanging);
      this.gcSelect.Caption = "Select";
      this.gcSelect.ColumnEdit = (RepositoryItem) this.ichkSelect;
      this.gcSelect.FieldName = "NPSelect";
      this.gcSelect.Name = "gcSelect";
      this.gcSelect.Visible = true;
      this.gcSelect.VisibleIndex = 0;
      this.gcSelect.Width = 106;
      this.ichkSelect.AutoHeight = false;
      this.ichkSelect.Name = "ichkSelect";
      this.gcFunctionName.Caption = "Function Name";
      this.gcFunctionName.FieldName = "FunctionName";
      this.gcFunctionName.Name = "gcFunctionName";
      this.gcFunctionName.OptionsColumn.AllowEdit = false;
      this.gcFunctionName.OptionsColumn.AllowFocus = false;
      this.gcFunctionName.Visible = true;
      this.gcFunctionName.VisibleIndex = 1;
      this.gcFunctionName.Width = 545;
      this.grcRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.grcRole.Location = new Point(5, 5);
      this.grcRole.MainView = (BaseView) this.grvRole;
      this.grcRole.Name = "grcRole";
      this.grcRole.Size = new Size(270, 576);
      this.grcRole.TabIndex = 0;
      this.grcRole.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvRole
      });
      this.grvRole.Appearance.Row.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.grvRole.Appearance.Row.Options.UseFont = true;
      this.grvRole.Columns.AddRange(new GridColumn[1]
      {
        this.gcRoleName
      });
      this.grvRole.GridControl = this.grcRole;
      this.grvRole.Name = "grvRole";
      this.grvRole.OptionsView.ShowColumnHeaders = false;
      this.grvRole.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
      this.grvRole.OptionsView.ShowGroupPanel = false;
      this.grvRole.OptionsView.ShowHorizontalLines = DefaultBoolean.False;
      this.grvRole.OptionsView.ShowIndicator = false;
      this.grvRole.OptionsView.ShowVerticalLines = DefaultBoolean.False;
      this.grvRole.OptionsView.ShowViewCaption = true;
      this.grvRole.ViewCaption = "Vai trò";
      this.grvRole.FocusedRowChanged += new FocusedRowChangedEventHandler(this.grvRole_FocusedRowChanged);
      this.gcRoleName.Caption = "Role Name";
      this.gcRoleName.FieldName = "RoleName";
      this.gcRoleName.Name = "gcRoleName";
      this.gcRoleName.OptionsColumn.AllowEdit = false;
      this.gcRoleName.OptionsColumn.AllowFocus = false;
      this.gcRoleName.Visible = true;
      this.gcRoleName.VisibleIndex = 0;
      this.pnlMain.Controls.Add((Control) this.grcRole);
      this.pnlMain.Controls.Add((Control) this.grcFunction);
      this.pnlMain.Dock = DockStyle.Fill;
      this.pnlMain.Location = new Point(0, 0);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new Size(950, 637);
      this.pnlMain.TabIndex = 2;
      this.panelControl1.Controls.Add((Control) this.btnClose);
      this.panelControl1.Controls.Add((Control) this.btnSave);
      this.panelControl1.Dock = DockStyle.Bottom;
      this.panelControl1.Location = new Point(0, 587);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new Size(950, 50);
      this.panelControl1.TabIndex = 3;
      this.btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnClose.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnClose.Appearance.Options.UseFont = true;
      this.btnClose.Location = new Point(791, 10);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(98, 30);
      this.btnClose.TabIndex = 1;
      this.btnClose.Text = "Đóng";
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnSave.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSave.Appearance.Options.UseFont = true;
      this.btnSave.Location = new Point(672, 10);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(98, 30);
      this.btnSave.TabIndex = 0;
      this.btnSave.Text = "Lưu";
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.panelControl1);
      this.Controls.Add((Control) this.pnlMain);
      this.Name = nameof (FunctionAssignUP);
      this.Size = new Size(950, 637);
      this.grvFunctionDetail.EndInit();
      this.ichkSelectDet.EndInit();
      this.grcFunction.EndInit();
      this.grvFunction.EndInit();
      this.ichkSelect.EndInit();
      this.grcRole.EndInit();
      this.grvRole.EndInit();
      this.pnlMain.EndInit();
      this.pnlMain.ResumeLayout(false);
      this.panelControl1.EndInit();
      this.panelControl1.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
