using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using DevExpress.XtraGrid.Columns;
using NhuaNong.Data;
using NhuaNong.Utils;
using System.Collections.ObjectModel;

namespace NhuaNong.Administration
{
  public partial class FunctionAssignUP
  {
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
      this.grvFunctionDetail.Appearance.Row.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
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
      this.gcSelectDet.ColumnEdit = (RepositoryItem)this.ichkSelectDet;
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
      this.grcFunction.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      gridLevelNode.LevelTemplate = (BaseView)this.grvFunctionDetail;
      gridLevelNode.RelationName = "LstChildFunction";
      this.grcFunction.LevelTree.Nodes.AddRange(new GridLevelNode[1]
      {
        gridLevelNode
      });
      this.grcFunction.Location = new Point(281, 5);
      this.grcFunction.MainView = (BaseView)this.grvFunction;
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
      this.grvFunction.Appearance.Row.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
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
      this.gcSelect.ColumnEdit = (RepositoryItem)this.ichkSelect;
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
      this.grcRole.MainView = (BaseView)this.grvRole;
      this.grcRole.Name = "grcRole";
      this.grcRole.Size = new Size(270, 576);
      this.grcRole.TabIndex = 0;
      this.grcRole.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvRole
      });
      this.grvRole.Appearance.Row.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
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
      this.pnlMain.Controls.Add((Control)this.grcRole);
      this.pnlMain.Controls.Add((Control)this.grcFunction);
      this.pnlMain.Dock = DockStyle.Fill;
      this.pnlMain.Location = new Point(0, 0);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new Size(950, 637);
      this.pnlMain.TabIndex = 2;
      this.panelControl1.Controls.Add((Control)this.btnClose);
      this.panelControl1.Controls.Add((Control)this.btnSave);
      this.panelControl1.Dock = DockStyle.Bottom;
      this.panelControl1.Location = new Point(0, 587);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new Size(950, 50);
      this.panelControl1.TabIndex = 3;
      this.btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnClose.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnClose.Appearance.Options.UseFont = true;
      this.btnClose.Location = new Point(791, 10);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(98, 30);
      this.btnClose.TabIndex = 1;
      this.btnClose.Text = "Đóng";
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnSave.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnSave.Appearance.Options.UseFont = true;
      this.btnSave.Location = new Point(672, 10);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(98, 30);
      this.btnSave.TabIndex = 0;
      this.btnSave.Text = "Lưu";
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control)this.panelControl1);
      this.Controls.Add((Control)this.pnlMain);
      this.Name = "FunctionAssignUP";
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
