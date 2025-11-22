using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Base;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using NhuaNong.Data;
using NhuaNong.Utils;
using System.Collections.ObjectModel;

namespace NhuaNong.Administration
{
  public partial class RoleAssign
  {
    private IContainer components;
    private PanelControl pnlMain;
    private PanelControl pnlCommand;
    private SimpleButton btnClose;
    private SimpleButton btnSave;
    private GridControl grcUser;
    private GridView grvUser;
    private GridControl grcRole;
    private GridView grvRole;
    private GridColumn gcUserName;
    private GridColumn gcRoleName;
    private GridColumn gcSelect;
    private RepositoryItemCheckEdit ichkSelect;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.pnlMain = new PanelControl();
      this.grcRole = new GridControl();
      this.grvRole = new GridView();
      this.gcRoleName = new GridColumn();
      this.gcSelect = new GridColumn();
      this.ichkSelect = new RepositoryItemCheckEdit();
      this.grcUser = new GridControl();
      this.grvUser = new GridView();
      this.gcUserName = new GridColumn();
      this.pnlCommand = new PanelControl();
      this.btnClose = new SimpleButton();
      this.btnSave = new SimpleButton();
      this.pnlMain.BeginInit();
      this.pnlMain.SuspendLayout();
      this.grcRole.BeginInit();
      this.grvRole.BeginInit();
      this.ichkSelect.BeginInit();
      this.grcUser.BeginInit();
      this.grvUser.BeginInit();
      this.pnlCommand.BeginInit();
      this.pnlCommand.SuspendLayout();
      this.SuspendLayout();
      this.pnlMain.Controls.Add((Control)this.grcRole);
      this.pnlMain.Controls.Add((Control)this.grcUser);
      this.pnlMain.Dock = DockStyle.Fill;
      this.pnlMain.Location = new Point(0, 0);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new Size(950, 554);
      this.pnlMain.TabIndex = 0;
      this.grcRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.grcRole.Location = new Point(281, 5);
      this.grcRole.MainView = (BaseView)this.grvRole;
      this.grcRole.Name = "grcRole";
      this.grcRole.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.ichkSelect
      });
      this.grcRole.Size = new Size(400, 493);
      this.grcRole.TabIndex = 1;
      this.grcRole.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvRole
      });
      this.grvRole.Appearance.Row.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.grvRole.Appearance.Row.Options.UseFont = true;
      this.grvRole.Columns.AddRange(new GridColumn[2]
      {
        this.gcRoleName,
        this.gcSelect
      });
      this.grvRole.FocusRectStyle = DrawFocusRectStyle.None;
      this.grvRole.GridControl = this.grcRole;
      this.grvRole.Name = "grvRole";
      this.grvRole.OptionsView.ShowColumnHeaders = false;
      this.grvRole.OptionsView.ShowDetailButtons = false;
      this.grvRole.OptionsView.ShowGroupPanel = false;
      this.grvRole.OptionsView.ShowHorizontalLines = DefaultBoolean.False;
      this.grvRole.OptionsView.ShowIndicator = false;
      this.grvRole.OptionsView.ShowVerticalLines = DefaultBoolean.False;
      this.grvRole.OptionsView.ShowViewCaption = true;
      this.grvRole.ViewCaption = "Vai trò";
      this.grvRole.CellValueChanging += new CellValueChangedEventHandler(this.grvRole_CellValueChanging);
      this.gcRoleName.Caption = "Role Name";
      this.gcRoleName.FieldName = "RoleName";
      this.gcRoleName.Name = "gcRoleName";
      this.gcRoleName.OptionsColumn.AllowEdit = false;
      this.gcRoleName.OptionsColumn.AllowFocus = false;
      this.gcRoleName.Visible = true;
      this.gcRoleName.VisibleIndex = 0;
      this.gcSelect.Caption = "Select";
      this.gcSelect.ColumnEdit = (RepositoryItem)this.ichkSelect;
      this.gcSelect.FieldName = "NPSelect";
      this.gcSelect.Name = "gcSelect";
      this.gcSelect.Visible = true;
      this.gcSelect.VisibleIndex = 1;
      this.ichkSelect.AutoHeight = false;
      this.ichkSelect.Name = "ichkSelect";
      this.grcUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.grcUser.Location = new Point(5, 5);
      this.grcUser.MainView = (BaseView)this.grvUser;
      this.grcUser.Name = "grcUser";
      this.grcUser.Size = new Size(270, 493);
      this.grcUser.TabIndex = 0;
      this.grcUser.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvUser
      });
      this.grvUser.Appearance.Row.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.grvUser.Appearance.Row.Options.UseFont = true;
      this.grvUser.Columns.AddRange(new GridColumn[1]
      {
        this.gcUserName
      });
      this.grvUser.GridControl = this.grcUser;
      this.grvUser.Name = "grvUser";
      this.grvUser.OptionsView.ShowColumnHeaders = false;
      this.grvUser.OptionsView.ShowDetailButtons = false;
      this.grvUser.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
      this.grvUser.OptionsView.ShowGroupPanel = false;
      this.grvUser.OptionsView.ShowHorizontalLines = DefaultBoolean.False;
      this.grvUser.OptionsView.ShowIndicator = false;
      this.grvUser.OptionsView.ShowVerticalLines = DefaultBoolean.False;
      this.grvUser.OptionsView.ShowViewCaption = true;
      this.grvUser.ViewCaption = "Người dùng";
      this.grvUser.FocusedRowChanged += new FocusedRowChangedEventHandler(this.grvUser_FocusedRowChanged);
      this.gcUserName.Caption = "User Name";
      this.gcUserName.FieldName = "UserName";
      this.gcUserName.Name = "gcUserName";
      this.gcUserName.OptionsColumn.AllowEdit = false;
      this.gcUserName.OptionsColumn.AllowFocus = false;
      this.gcUserName.Visible = true;
      this.gcUserName.VisibleIndex = 0;
      this.pnlCommand.Controls.Add((Control)this.btnClose);
      this.pnlCommand.Controls.Add((Control)this.btnSave);
      this.pnlCommand.Dock = DockStyle.Bottom;
      this.pnlCommand.Location = new Point(0, 504);
      this.pnlCommand.Name = "pnlCommand";
      this.pnlCommand.Size = new Size(950, 50);
      this.pnlCommand.TabIndex = 1;
      this.btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnClose.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnClose.Appearance.Options.UseFont = true;
      this.btnClose.Location = new Point(791, 10);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(98, 30);
      this.btnClose.TabIndex = 3;
      this.btnClose.Text = "Đóng";
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnSave.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnSave.Appearance.Options.UseFont = true;
      this.btnSave.Location = new Point(672, 10);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(98, 30);
      this.btnSave.TabIndex = 2;
      this.btnSave.Text = "Lưu";
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control)this.pnlCommand);
      this.Controls.Add((Control)this.pnlMain);
      this.Name = "RoleAssign";
      this.Size = new Size(950, 554);
      this.pnlMain.EndInit();
      this.pnlMain.ResumeLayout(false);
      this.grcRole.EndInit();
      this.grvRole.EndInit();
      this.ichkSelect.EndInit();
      this.grcUser.EndInit();
      this.grvUser.EndInit();
      this.pnlCommand.EndInit();
      this.pnlCommand.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
