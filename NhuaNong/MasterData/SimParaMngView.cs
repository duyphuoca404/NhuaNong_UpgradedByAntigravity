// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.SimParaMngView
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Data.Filtering;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using NhuaNong.Data;
using NhuaNong.Utils;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public class SimParaMngView : ControlViewBase, ITimerParaMngView, IBase, IPermission
  {
    private TimerParaMngDataPresenter _presenter;
    private BindingList<ObjTimerPara> _blstTimerPara = new BindingList<ObjTimerPara>();
    private List<ObjTimerPara> _listTimer = new List<ObjTimerPara>();
    private IContainer components;
    private BarManager barManager1;
    private Bar bar2;
    private BarStaticItem bsiCaption;
    private BarDockControl barDockControlTop;
    private BarDockControl barDockControlBottom;
    private BarDockControl barDockControlLeft;
    private BarDockControl barDockControlRight;
    private BarButtonItem bbiSaveTimer;
    private BarButtonItem bbiRefreshTimer;
    private BarButtonItem bbiPLCTimer;
    private GroupControl grcMaster;
    private GridControl grcData;
    private GridView grvData;
    private GridColumn gcTimerParaCode;
    private RepositoryItemTextEdit itxtTimerPara;
    private GridColumn gcDesc;
    private RepositoryItemTextEdit itxtDesc;
    private GridColumn gcTimerParaValue;
    private RepositoryItemSpinEdit ispnTimerParatValue;
    private GridColumn gcMarkAsDeleted;
    private RepositoryItemTimeEdit repositoryItemTimeEdit1;

    public SimParaMngView()
    {
      this.InitializeComponent();
      this._presenter = new TimerParaMngDataPresenter((ITimerParaMngView) this);
    }

    public BindingList<ObjTimerPara> BLstTimerPara
    {
      set
      {
        this._blstTimerPara = value;
        this._listTimer.Add(value[38]);
        this._listTimer.Add(value[39]);
        this._listTimer.Add(value[40]);
        this._listTimer.Add(value[41]);
        this._listTimer.Add(value[42]);
        this._listTimer.Add(value[43]);
        this._listTimer.Add(value[44]);
        this._listTimer.Add(value[45]);
        this._listTimer.Add(value[46]);
        this._listTimer.Add(value[47]);
        this._listTimer.Add(value[48]);
        this._listTimer.Add(value[49]);
        this._listTimer.Add(value[50]);
        this._listTimer.Add(value[51]);
        this._listTimer.Add(value[52]);
        this._listTimer.Add(value[53]);
        this._listTimer.Add(value[54]);
        this._listTimer.Add(value[55]);
        this._listTimer.Add(value[56]);
        this._listTimer.Add(value[57]);
        this._listTimer.Add(value[58]);
        this._listTimer.Add(value[59]);
        this._listTimer.Add(value[60]);
        this._listTimer.Add(value[61]);
        this._listTimer.Add(value[62]);
        this._listTimer.Add(value[63]);
        this._listTimer.Add(value[64]);
        this._listTimer.Add(value[65]);
        this._listTimer.Add(value[66]);
        this._listTimer.Add(value[67]);
        this._listTimer.Add(value[68]);
        this.grcData.DataSource = (object) this._listTimer;
      }
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    protected override void InitLayout()
    {
      this.grvData.ActiveFilterCriteria = (CriteriaOperator) new BinaryOperator("MarkAsDeleted", false);
    }

    protected override void PopulateData() => this._presenter.ListTimerPara();

    private void SuccessfullySave(bool isSuccess)
    {
      if (isSuccess)
      {
        TramTromMessageBox.ShowMessageDialog(GlobalValues.Messages.SuccessSavingData);
        this._dlgRes = DialogResult.OK;
        this.Close();
      }
      else
        TramTromMessageBox.ShowErrorDialog(GlobalValues.Messages.ErrorSavingData);
    }

    private void grcData_ProcessGridKey(object sender, KeyEventArgs e)
    {
      if (!e.Control || e.KeyCode != Keys.Delete)
        return;
      foreach (int selectedRow in this.grvData.GetSelectedRows())
      {
        if (selectedRow >= 0)
        {
          ObjTimerPara row = this.grvData.GetRow(selectedRow) as ObjTimerPara;
          if (row.IsNewObject)
            this._blstTimerPara.Remove(row);
          else
            row.MarkAsDeleted = true;
        }
      }
      this.grvData.RefreshData();
    }

    private void bbiSaveTimer_ItemClick(object sender, ItemClickEventArgs e)
    {
      foreach (ObjTimerPara objTimerPara in (Collection<ObjTimerPara>) this._blstTimerPara)
      {
        if (string.IsNullOrEmpty(objTimerPara.TimerParaCode))
        {
          TramTromMessageBox.ShowDEPErrorDialog(GlobalValues.Messages.ThieuMaThongSoThoiGian);
          return;
        }
      }
      this.grvData.PostEditor();
      this._presenter.SaveTimerPara(this._blstTimerPara);
    }

    private void bbiRefreshTimer_ItemClick(object sender, ItemClickEventArgs e)
    {
      this._presenter.ListTimerPara();
    }

    private void bbiPLCTimer_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      this.barManager1 = new BarManager(this.components);
      this.bar2 = new Bar();
      this.bsiCaption = new BarStaticItem();
      this.bbiSaveTimer = new BarButtonItem();
      this.bbiRefreshTimer = new BarButtonItem();
      this.bbiPLCTimer = new BarButtonItem();
      this.barDockControlTop = new BarDockControl();
      this.barDockControlBottom = new BarDockControl();
      this.barDockControlLeft = new BarDockControl();
      this.barDockControlRight = new BarDockControl();
      this.grcMaster = new GroupControl();
      this.grcData = new GridControl();
      this.grvData = new GridView();
      this.gcTimerParaCode = new GridColumn();
      this.itxtTimerPara = new RepositoryItemTextEdit();
      this.gcDesc = new GridColumn();
      this.itxtDesc = new RepositoryItemTextEdit();
      this.gcTimerParaValue = new GridColumn();
      this.ispnTimerParatValue = new RepositoryItemSpinEdit();
      this.gcMarkAsDeleted = new GridColumn();
      this.repositoryItemTimeEdit1 = new RepositoryItemTimeEdit();
      this.barManager1.BeginInit();
      this.grcMaster.BeginInit();
      this.grcMaster.SuspendLayout();
      this.grcData.BeginInit();
      this.grvData.BeginInit();
      this.itxtTimerPara.BeginInit();
      this.itxtDesc.BeginInit();
      this.ispnTimerParatValue.BeginInit();
      this.repositoryItemTimeEdit1.BeginInit();
      this.SuspendLayout();
      this.barManager1.Bars.AddRange(new Bar[1]{ this.bar2 });
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = (Control) this;
      this.barManager1.Items.AddRange(new BarItem[4]
      {
        (BarItem) this.bsiCaption,
        (BarItem) this.bbiSaveTimer,
        (BarItem) this.bbiRefreshTimer,
        (BarItem) this.bbiPLCTimer
      });
      this.barManager1.MainMenu = this.bar2;
      this.barManager1.MaxItemId = 4;
      this.bar2.BarName = "Main menu";
      this.bar2.DockCol = 0;
      this.bar2.DockRow = 0;
      this.bar2.DockStyle = BarDockStyle.Top;
      this.bar2.LinksPersistInfo.AddRange(new LinkPersistInfo[4]
      {
        new LinkPersistInfo((BarItem) this.bsiCaption),
        new LinkPersistInfo((BarItem) this.bbiSaveTimer),
        new LinkPersistInfo((BarItem) this.bbiRefreshTimer),
        new LinkPersistInfo((BarItem) this.bbiPLCTimer)
      });
      this.bar2.OptionsBar.MultiLine = true;
      this.bar2.OptionsBar.UseWholeRow = true;
      this.bar2.Text = "Main menu";
      this.bsiCaption.Caption = "Thông số Mô phỏng";
      this.bsiCaption.Id = 0;
      this.bsiCaption.ItemAppearance.Normal.Font = new Font("Tahoma", 13.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.bsiCaption.ItemAppearance.Normal.Options.UseFont = true;
      this.bsiCaption.Name = "bsiCaption";
      this.bbiSaveTimer.Caption = "Lưu";
      this.bbiSaveTimer.Id = 1;
      this.bbiSaveTimer.ImageOptions.Image = (Image) ResourceNhua.save_file;
      this.bbiSaveTimer.Name = "bbiSaveTimer";
      this.bbiSaveTimer.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiSaveTimer.ItemClick += new ItemClickEventHandler(this.bbiSaveTimer_ItemClick);
      this.bbiRefreshTimer.Caption = "Làm mới";
      this.bbiRefreshTimer.Id = 2;
      this.bbiRefreshTimer.ImageOptions.Image = (Image) ResourceNhua.refresh_file;
      this.bbiRefreshTimer.Name = "bbiRefreshTimer";
      this.bbiRefreshTimer.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiRefreshTimer.ItemClick += new ItemClickEventHandler(this.bbiRefreshTimer_ItemClick);
      this.bbiPLCTimer.Caption = "PLC";
      this.bbiPLCTimer.Id = 3;
      this.bbiPLCTimer.ImageOptions.Image = (Image) ResourceNhua.load_PLC;
      this.bbiPLCTimer.Name = "bbiPLCTimer";
      this.bbiPLCTimer.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiPLCTimer.Visibility = BarItemVisibility.Never;
      this.bbiPLCTimer.ItemClick += new ItemClickEventHandler(this.bbiPLCTimer_ItemClick);
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = DockStyle.Top;
      this.barDockControlTop.Location = new Point(0, 0);
      this.barDockControlTop.Manager = this.barManager1;
      this.barDockControlTop.Margin = new Padding(2);
      this.barDockControlTop.Size = new Size(772, 40);
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = DockStyle.Bottom;
      this.barDockControlBottom.Location = new Point(0, 488);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Margin = new Padding(2);
      this.barDockControlBottom.Size = new Size(772, 0);
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = DockStyle.Left;
      this.barDockControlLeft.Location = new Point(0, 40);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Margin = new Padding(2);
      this.barDockControlLeft.Size = new Size(0, 448);
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = DockStyle.Right;
      this.barDockControlRight.Location = new Point(772, 40);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Margin = new Padding(2);
      this.barDockControlRight.Size = new Size(0, 448);
      this.grcMaster.Controls.Add((Control) this.grcData);
      this.grcMaster.Dock = DockStyle.Fill;
      this.grcMaster.Location = new Point(0, 40);
      this.grcMaster.Margin = new Padding(2);
      this.grcMaster.Name = "grcMaster";
      this.grcMaster.Size = new Size(772, 448);
      this.grcMaster.TabIndex = 4;
      this.grcMaster.Text = "Dữ liệu";
      this.grcData.Dock = DockStyle.Fill;
      this.grcData.EmbeddedNavigator.Margin = new Padding(2);
      this.grcData.Location = new Point(2, 23);
      this.grcData.MainView = (BaseView) this.grvData;
      this.grcData.Margin = new Padding(2);
      this.grcData.MenuManager = (IDXMenuManager) this.barManager1;
      this.grcData.Name = "grcData";
      this.grcData.RepositoryItems.AddRange(new RepositoryItem[4]
      {
        (RepositoryItem) this.repositoryItemTimeEdit1,
        (RepositoryItem) this.itxtTimerPara,
        (RepositoryItem) this.itxtDesc,
        (RepositoryItem) this.ispnTimerParatValue
      });
      this.grcData.Size = new Size(768, 423);
      this.grcData.TabIndex = 0;
      this.grcData.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvData
      });
      this.grcData.ProcessGridKey += new KeyEventHandler(this.grcData_ProcessGridKey);
      this.grvData.Columns.AddRange(new GridColumn[4]
      {
        this.gcTimerParaCode,
        this.gcDesc,
        this.gcTimerParaValue,
        this.gcMarkAsDeleted
      });
      this.grvData.DetailHeight = 284;
      this.grvData.GridControl = this.grcData;
      this.grvData.Name = "grvData";
      this.grvData.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
      this.grvData.OptionsView.ShowFooter = true;
      this.gcTimerParaCode.Caption = "Mã";
      this.gcTimerParaCode.ColumnEdit = (RepositoryItem) this.itxtTimerPara;
      this.gcTimerParaCode.FieldName = "TimerParaCode";
      this.gcTimerParaCode.MinWidth = 22;
      this.gcTimerParaCode.Name = "gcTimerParaCode";
      this.gcTimerParaCode.Visible = true;
      this.gcTimerParaCode.VisibleIndex = 0;
      this.gcTimerParaCode.Width = 80;
      this.itxtTimerPara.AllowFocused = false;
      this.itxtTimerPara.AutoHeight = false;
      this.itxtTimerPara.Name = "itxtTimerPara";
      this.itxtTimerPara.ReadOnly = true;
      this.gcDesc.Caption = "Thông số mô phỏng";
      this.gcDesc.ColumnEdit = (RepositoryItem) this.itxtDesc;
      this.gcDesc.FieldName = "Description";
      this.gcDesc.MinWidth = 22;
      this.gcDesc.Name = "gcDesc";
      this.gcDesc.OptionsColumn.ReadOnly = true;
      this.gcDesc.Visible = true;
      this.gcDesc.VisibleIndex = 1;
      this.gcDesc.Width = 80;
      this.itxtDesc.AutoHeight = false;
      this.itxtDesc.Name = "itxtDesc";
      this.itxtDesc.ReadOnly = true;
      this.gcTimerParaValue.AppearanceCell.Options.UseTextOptions = true;
      this.gcTimerParaValue.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
      this.gcTimerParaValue.Caption = "Giá Trị";
      this.gcTimerParaValue.ColumnEdit = (RepositoryItem) this.ispnTimerParatValue;
      this.gcTimerParaValue.DisplayFormat.FormatString = "n2";
      this.gcTimerParaValue.DisplayFormat.FormatType = FormatType.Numeric;
      this.gcTimerParaValue.FieldName = "TimerParaValue";
      this.gcTimerParaValue.MinWidth = 22;
      this.gcTimerParaValue.Name = "gcTimerParaValue";
      this.gcTimerParaValue.Visible = true;
      this.gcTimerParaValue.VisibleIndex = 2;
      this.gcTimerParaValue.Width = 80;
      this.ispnTimerParatValue.AllowFocused = false;
      this.ispnTimerParatValue.AutoHeight = false;
      this.ispnTimerParatValue.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ispnTimerParatValue.DisplayFormat.FormatString = "n2";
      this.ispnTimerParatValue.DisplayFormat.FormatType = FormatType.Numeric;
      this.ispnTimerParatValue.EditFormat.FormatString = "n2";
      this.ispnTimerParatValue.EditFormat.FormatType = FormatType.Numeric;
      this.ispnTimerParatValue.Name = "ispnTimerParatValue";
      this.gcMarkAsDeleted.Caption = "Mark As Deleted";
      this.gcMarkAsDeleted.FieldName = "MarkAsDeleted";
      this.gcMarkAsDeleted.MinWidth = 22;
      this.gcMarkAsDeleted.Name = "gcMarkAsDeleted";
      this.gcMarkAsDeleted.Width = 80;
      this.repositoryItemTimeEdit1.AutoHeight = false;
      this.repositoryItemTimeEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Caption = "Simmer";
      this.Controls.Add((Control) this.grcMaster);
      this.Controls.Add((Control) this.barDockControlLeft);
      this.Controls.Add((Control) this.barDockControlRight);
      this.Controls.Add((Control) this.barDockControlBottom);
      this.Controls.Add((Control) this.barDockControlTop);
      this.Name = nameof (SimParaMngView);
      this.Size = new Size(772, 488);
      this.barManager1.EndInit();
      this.grcMaster.EndInit();
      this.grcMaster.ResumeLayout(false);
      this.grcData.EndInit();
      this.grvData.EndInit();
      this.itxtTimerPara.EndInit();
      this.itxtDesc.EndInit();
      this.ispnTimerParatValue.EndInit();
      this.repositoryItemTimeEdit1.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
