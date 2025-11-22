using DevExpress.Utils;
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
  public partial class FunctionAssign
  {
    private IContainer components;
    private PanelControl pnlMain;
    private GridControl grcFunction;
    private RepositoryItemCheckEdit ichkSelectDet;
    private GridView grvFunction;
    private GridColumn gcSelect;
    private RepositoryItemCheckEdit ichkSelect;
    private GridColumn gcFunctionName;
    private GridControl grcRole;
    private GridView grvRole;
    private GridColumn gcRoleName;
    private PanelControl pnlCommand;
    private SimpleButton btnClose;
    private SimpleButton btnSave;
    private GridView grvFunctionDetail;
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      GridLevelNode gridLevelNode = new GridLevelNode();
      this.grcFunction = new GridControl();
      this.grvFunction = new GridView();
      this.gcSelect = new GridColumn();
      this.ichkSelect = new RepositoryItemCheckEdit();
      this.gcFunctionName = new GridColumn();
      this.ichkSelectDet = new RepositoryItemCheckEdit();
      this.grvFunctionDetail = new GridView();
      this.pnlMain = new PanelControl();
      this.grcRole = new GridControl();
      this.grvRole = new GridView();
      this.gcRoleName = new GridColumn();
      this.pnlCommand = new PanelControl();
      this.btnClose = new SimpleButton();
      this.btnSave = new SimpleButton();
      this.grcFunction.BeginInit();
      this.grvFunction.BeginInit();
      this.ichkSelect.BeginInit();
      this.ichkSelectDet.BeginInit();
      this.grvFunctionDetail.BeginInit();
      this.pnlMain.BeginInit();
      this.pnlMain.SuspendLayout();
      this.grcRole.BeginInit();
      this.grvRole.BeginInit();
      this.pnlCommand.BeginInit();
      this.pnlCommand.SuspendLayout();
      this.SuspendLayout();
      this.grcFunction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.grcFunction.Cursor = Cursors.WaitCursor;
      gridLevelNode.RelationName = "Level1";
      this.grcFunction.LevelTree.Nodes.AddRange(new GridLevelNode[1]
      {
        gridLevelNode
      });
      this.grcFunction.Location = new Point(190, 0);
      this.grcFunction.MainView = (BaseView)this.grvFunction;
      this.grcFunction.Name = "grcFunction";
      this.grcFunction.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.ichkSelect,
        (RepositoryItem) this.ichkSelectDet
      });
      this.grcFunction.Size = new Size(1052, 510);
      this.grcFunction.TabIndex = 1;
      this.grcFunction.ViewCollection.AddRange(new BaseView[2]
      {
        (BaseView) this.grvFunction,
        (BaseView) this.grvFunctionDetail
      });
      this.grvFunction.Columns.AddRange(new GridColumn[2]
      {
        this.gcSelect,
        this.gcFunctionName
      });
      this.grvFunction.GridControl = this.grcFunction;
      this.grvFunction.Name = "grvFunction";
      this.grvFunction.CellValueChanging += new CellValueChangedEventHandler(this.grvFunction_CellValueChanging);
      this.gcSelect.Caption = "Select";
      this.gcSelect.ColumnEdit = (RepositoryItem)this.ichkSelect;
      this.gcSelect.FieldName = "NPSelect";
      this.gcSelect.Name = "gcSelect";
      this.gcSelect.Visible = true;
      this.gcSelect.VisibleIndex = 0;
      this.gcSelect.Width = 163;
      this.ichkSelect.AutoHeight = false;
      this.ichkSelect.Name = "ichkSelect";
      this.gcFunctionName.Caption = "Function Name";
      this.gcFunctionName.FieldName = "FunctionName";
      this.gcFunctionName.Name = "gcFunctionName";
      this.gcFunctionName.OptionsColumn.AllowEdit = false;
      this.gcFunctionName.OptionsColumn.AllowFocus = false;
      this.gcFunctionName.Visible = true;
      this.gcFunctionName.VisibleIndex = 1;
      this.gcFunctionName.Width = 864;
      this.ichkSelectDet.AutoHeight = false;
      this.ichkSelectDet.Name = "ichkSelectDet";
      this.grvFunctionDetail.GridControl = this.grcFunction;
      this.grvFunctionDetail.Name = "grvFunctionDetail";
      this.pnlMain.Controls.Add((Control)this.grcFunction);
      this.pnlMain.Controls.Add((Control)this.grcRole);
      this.pnlMain.Dock = DockStyle.Fill;
      this.pnlMain.Location = new Point(0, 0);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new Size(1256, 566);
      this.pnlMain.TabIndex = 0;
      this.grcRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.grcRole.Location = new Point(0, 0);
      this.grcRole.MainView = (BaseView)this.grvRole;
      this.grcRole.Name = "grcRole";
      this.grcRole.Size = new Size(193, 510);
      this.grcRole.TabIndex = 0;
      this.grcRole.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvRole
      });
      this.grvRole.Columns.AddRange(new GridColumn[1]
      {
        this.gcRoleName
      });
      this.grvRole.GridControl = this.grcRole;
      this.grvRole.Name = "grvRole";
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
      this.pnlCommand.Controls.Add((Control)this.btnClose);
      this.pnlCommand.Controls.Add((Control)this.btnSave);
      this.pnlCommand.Dock = DockStyle.Bottom;
      this.pnlCommand.Location = new Point(0, 516);
      this.pnlCommand.Name = "pnlCommand";
      this.pnlCommand.Size = new Size(1256, 50);
      this.pnlCommand.TabIndex = 1;
      this.btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnClose.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnClose.Appearance.Options.UseFont = true;
      this.btnClose.Location = new Point(1110, 10);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(98, 30);
      this.btnClose.TabIndex = 1;
      this.btnClose.Text = "Đóng";
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnSave.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnSave.Appearance.Options.UseFont = true;
      this.btnSave.Location = new Point(991, 10);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(98, 30);
      this.btnSave.TabIndex = 0;
      this.btnSave.Text = "Lưu";
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control)this.pnlCommand);
      this.Controls.Add((Control)this.pnlMain);
      this.Name = "FunctionAssign";
      this.Size = new Size(1256, 566);
      this.grcFunction.EndInit();
      this.grvFunction.EndInit();
      this.ichkSelect.EndInit();
      this.ichkSelectDet.EndInit();
      this.grvFunctionDetail.EndInit();
      this.pnlMain.EndInit();
      this.pnlMain.ResumeLayout(false);
      this.grcRole.EndInit();
      this.grvRole.EndInit();
      this.pnlCommand.EndInit();
      this.pnlCommand.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
