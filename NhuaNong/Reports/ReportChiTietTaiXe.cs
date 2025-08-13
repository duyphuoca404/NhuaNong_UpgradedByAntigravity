// Decompiled with JetBrains decompiler
// Type: NhuaNong.Reports.ReportChiTietTaiXe
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using NhuaNong.ClientSetting;
using NhuaNong.Data;
using NhuaNong.KWS;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.Reports
{
  public class ReportChiTietTaiXe : ControlViewBase
  {
    private IServices _ser = ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode);
    private BindingList<Objvw_DriverDetailDayWithID> _blstTotalDriver = new BindingList<Objvw_DriverDetailDayWithID>();
    private BindingList<Objvw_DriverDetailDayWithID> _blstDriverDetailDay = new BindingList<Objvw_DriverDetailDayWithID>();
    private BindingList<Objvw_DriverDetailDayWithID> _blstDriverDetailDayID = new BindingList<Objvw_DriverDetailDayWithID>();
    private BindingList<ObjTaiXe> _blstTaiXe = new BindingList<ObjTaiXe>();
    private BindingList<ObjDriverSummary> _blstDriverSummary = new BindingList<ObjDriverSummary>();
    private IContainer components;
    private PanelControl panelControl2;
    private GroupControl groupControl2;
    private GridControl grcChiTietTaiXe;
    private GridView grvChiTietTaiXe;
    private GridColumn gcMaTaiXe;
    private GridColumn gcTenTaiXe;
    private GridColumn gcTotal_Tranfer;
    private GridColumn gcTotal_KL;
    private GroupControl groupControl1;
    private GroupBox groupBox2;
    private LookUpEdit lueCheDo;
    private SimpleButton btnReset;
    private SimpleButton btnTimKiem;
    private LookUpEdit lueTaiXe;
    private LabelControl labelControl3;
    private LabelControl labelControl2;
    private DateEdit datToDate;
    private DateEdit datFromDate;
    private LabelControl labelControl1;
    private LabelControl lblFromDate;
    private GroupBox groupBox1;
    private SimpleButton btnExportExcel;
    private PanelControl panelControl1;
    private LabelControl labelControl4;

    public ReportChiTietTaiXe()
    {
      this.InitializeComponent();
      this.Caption = "Chi tiết tài xế";
      this._blstTaiXe = Converter.ConvertToBindingList<ObjTaiXe>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListTaiXe() as List<ObjTaiXe>);
    }

    protected override void PopulateStaticData()
    {
      this.lueCheDo.Properties.DataSource = (object) Converter.EnumToListFieldCode<Enums.SimMode>(true);
      this.lueTaiXe.Properties.DataSource = (object) this._blstTaiXe;
      this.LoadSearchDefaultValues();
    }

    protected override void PopulateData()
    {
      Task.Run((Action) (() => this.LoadData()));
      Task.Run((Action) (() => this.LoadData_DetailDay()));
    }

    private void LoadSearchDefaultValues()
    {
      this.datFromDate.EditValue = (object) DateTime.Now.AddDays(-(double) ConfigManager.TramTronConfig.LatestBaoCaoDays);
      this.datToDate.EditValue = (object) DateTime.Now;
      this.lueTaiXe.EditValue = (object) null;
      this.lueCheDo.EditValue = (object) 2;
    }

    private void LoadData()
    {
      bool? isManual = new bool?();
      if (Convert.ToInt32(this.lueCheDo.EditValue) == 1)
        isManual = new bool?(false);
      else if (Convert.ToInt32(this.lueCheDo.EditValue) == 2)
        isManual = new bool?(true);
      this._blstTotalDriver = Converter.ConvertToBindingList<Objvw_DriverDetailDayWithID>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListTotalDriver_ByCondition((int?) this.lueTaiXe.EditValue, isManual) as List<Objvw_DriverDetailDayWithID>);
    }

    private void LoadData_DetailDay()
    {
      this._blstDriverDetailDay.Clear();
      this._blstDriverDetailDayID.Clear();
      if (Convert.ToInt32(this.lueCheDo.EditValue) != 1)
        Convert.ToInt32(this.lueCheDo.EditValue);
      for (int index = 1; index <= this._blstTotalDriver.Count; ++index)
      {
        this._blstDriverDetailDay = Converter.ConvertToBindingList<Objvw_DriverDetailDayWithID>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListDriverDetailDay_ByCondition(new DateTime?(), new DateTime?(), new int?(index), new bool?()) as List<Objvw_DriverDetailDayWithID>);
        this._blstDriverDetailDayID.Add(this._blstDriverDetailDay[0]);
      }
      this.FilterData();
      BindingList<ObjDriverSummary> list = new BindingList<ObjDriverSummary>();
      list.Clear();
      list = Converter.ConvertToBindingList<ObjDriverSummary>(this.GroupAndSumDriverDetail(this._blstDriverDetailDayID));
      this.Invoke((Delegate) (() => this.UpdateUI_ID(list)));
    }

    public void FilterData()
    {
      bool? active = new bool?();
      if (Convert.ToInt32(this.lueCheDo.EditValue) == 1)
        active = new bool?(false);
      else if (Convert.ToInt32(this.lueCheDo.EditValue) == 2)
        active = new bool?(true);
      int? taiXeID = new int?();
      if (Convert.ToInt32(this.lueTaiXe.EditValue) != 0)
        taiXeID = new int?(Convert.ToInt32(this.lueTaiXe.EditValue));
      DateTime startDate = Searching.Build_StartDateTime(this.datFromDate.DateTime.AddDays(-1.0));
      DateTime endDate = Searching.Build_EndDateTime(this.datToDate.DateTime.AddDays(-1.0));
      List<Objvw_DriverDetailDayWithID> list = this._blstDriverDetailDayID.Where<Objvw_DriverDetailDayWithID>((Func<Objvw_DriverDetailDayWithID, bool>) (item =>
      {
        DateTime? ngayMeTron1 = item.NgayMeTron;
        DateTime dateTime1 = startDate;
        if ((ngayMeTron1.HasValue ? (ngayMeTron1.GetValueOrDefault() >= dateTime1 ? 1 : 0) : 0) != 0)
        {
          DateTime? ngayMeTron2 = item.NgayMeTron;
          DateTime dateTime2 = endDate;
          if ((ngayMeTron2.HasValue ? (ngayMeTron2.GetValueOrDefault() <= dateTime2 ? 1 : 0) : 0) != 0)
          {
            if (active.HasValue)
            {
              bool? isManual = item.IsManual;
              bool? nullable = active;
              if (!(isManual.GetValueOrDefault() == nullable.GetValueOrDefault() & isManual.HasValue == nullable.HasValue))
                goto label_7;
            }
            if (!taiXeID.HasValue)
              return true;
            int taiXeId = item.TaiXeID;
            int? nullable1 = taiXeID;
            int valueOrDefault = nullable1.GetValueOrDefault();
            return taiXeId == valueOrDefault & nullable1.HasValue;
          }
        }
label_7:
        return false;
      })).ToList<Objvw_DriverDetailDayWithID>();
      this._blstDriverDetailDayID.Clear();
      foreach (Objvw_DriverDetailDayWithID driverDetailDayWithId in list)
        this._blstDriverDetailDayID.Add(driverDetailDayWithId);
    }

    public List<ObjDriverSummary> GroupAndSumDriverDetail(
      BindingList<Objvw_DriverDetailDayWithID> driverDetailDays)
    {
      return driverDetailDays.GroupBy<Objvw_DriverDetailDayWithID, int>((Func<Objvw_DriverDetailDayWithID, int>) (d => d.TaiXeID)).Select<IGrouping<int, Objvw_DriverDetailDayWithID>, ObjDriverSummary>((Func<IGrouping<int, Objvw_DriverDetailDayWithID>, ObjDriverSummary>) (g => new ObjDriverSummary()
      {
        TaiXeID = g.Key,
        TenTaiXe = g.First<Objvw_DriverDetailDayWithID>().TenTaiXe,
        Total_Tranfer = g.Sum<Objvw_DriverDetailDayWithID>((Func<Objvw_DriverDetailDayWithID, int?>) (x => x.Total_Tranfer)),
        Total_KL = new Decimal?(g.Sum<Objvw_DriverDetailDayWithID>((Func<Objvw_DriverDetailDayWithID, Decimal>) (x => x.Total_KL.Value)))
      })).ToList<ObjDriverSummary>();
    }

    private void UpdateUI(BindingList<Objvw_DriverDetailDayWithID> result)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) (() => this.UpdateUI(result)));
      else
        this.grcChiTietTaiXe.DataSource = (object) result;
    }

    private void UpdateUI_ID(BindingList<ObjDriverSummary> result)
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) (() => this.UpdateUI_ID(result)));
      }
      else
      {
        this.grcChiTietTaiXe.DataSource = (object) null;
        this.grcChiTietTaiXe.DataSource = (object) result;
      }
    }

    private void btnTimKiem_Click(object sender, EventArgs e)
    {
      Task.Run((Action) (() => this.LoadData_DetailDay()));
    }

    private void btnReset_Click(object sender, EventArgs e) => this.LoadSearchDefaultValues();

    private void btnExportExcel_Click(object sender, EventArgs e)
    {
      try
      {
        string title = "BÁO CÁO CHI TIẾT TÀI XẾ";
        string str1 = string.Format("Từ ngày: {0} - đến ngày: {1}", (object) FormatToString.DateTimeToString(this.datFromDate.DateTime), (object) FormatToString.DateTimeToString(this.datToDate.DateTime));
        string str2 = string.Format("Tài xế: {0}", (object) this.lueTaiXe.Text);
        List<string> lstHeader = new List<string>();
        lstHeader.Add(str1);
        if (this.lueTaiXe.EditValue != null)
          lstHeader.Add(str2);
        new Helpper().ExportExcelWithHeader(true, (IPrintable) this.grcChiTietTaiXe, true, true, title, lstHeader);
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      GridGroupSummaryItem groupSummaryItem1 = new GridGroupSummaryItem();
      GridGroupSummaryItem groupSummaryItem2 = new GridGroupSummaryItem();
      this.gcTotal_Tranfer = new GridColumn();
      this.gcTotal_KL = new GridColumn();
      this.panelControl2 = new PanelControl();
      this.groupControl2 = new GroupControl();
      this.grcChiTietTaiXe = new GridControl();
      this.grvChiTietTaiXe = new GridView();
      this.gcMaTaiXe = new GridColumn();
      this.gcTenTaiXe = new GridColumn();
      this.groupControl1 = new GroupControl();
      this.groupBox2 = new GroupBox();
      this.lueCheDo = new LookUpEdit();
      this.btnReset = new SimpleButton();
      this.btnTimKiem = new SimpleButton();
      this.lueTaiXe = new LookUpEdit();
      this.labelControl3 = new LabelControl();
      this.labelControl2 = new LabelControl();
      this.datToDate = new DateEdit();
      this.datFromDate = new DateEdit();
      this.labelControl1 = new LabelControl();
      this.lblFromDate = new LabelControl();
      this.groupBox1 = new GroupBox();
      this.btnExportExcel = new SimpleButton();
      this.panelControl1 = new PanelControl();
      this.labelControl4 = new LabelControl();
      this.panelControl2.BeginInit();
      this.groupControl2.BeginInit();
      this.grcChiTietTaiXe.BeginInit();
      this.grvChiTietTaiXe.BeginInit();
      this.groupControl1.BeginInit();
      this.groupBox2.SuspendLayout();
      this.lueCheDo.Properties.BeginInit();
      this.lueTaiXe.Properties.BeginInit();
      this.datToDate.Properties.BeginInit();
      this.datToDate.Properties.CalendarTimeProperties.BeginInit();
      this.datFromDate.Properties.BeginInit();
      this.datFromDate.Properties.CalendarTimeProperties.BeginInit();
      this.groupBox1.SuspendLayout();
      this.panelControl1.BeginInit();
      this.SuspendLayout();
      this.gcTotal_Tranfer.Caption = "Tổng số chuyến";
      this.gcTotal_Tranfer.FieldName = "Total_Tranfer";
      this.gcTotal_Tranfer.GroupFormat.FormatString = "n2";
      this.gcTotal_Tranfer.GroupFormat.FormatType = FormatType.Numeric;
      this.gcTotal_Tranfer.Name = "gcTotal_Tranfer";
      this.gcTotal_Tranfer.OptionsColumn.AllowFocus = false;
      this.gcTotal_Tranfer.OptionsColumn.ReadOnly = true;
      this.gcTotal_Tranfer.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Total_Tranfer", "{0:0.##}")
      });
      this.gcTotal_Tranfer.Visible = true;
      this.gcTotal_Tranfer.VisibleIndex = 2;
      this.gcTotal_KL.Caption = "Tổng khối lượng";
      this.gcTotal_KL.FieldName = "Total_KL";
      this.gcTotal_KL.GroupFormat.FormatString = "n2";
      this.gcTotal_KL.GroupFormat.FormatType = FormatType.Numeric;
      this.gcTotal_KL.Name = "gcTotal_KL";
      this.gcTotal_KL.OptionsColumn.AllowFocus = false;
      this.gcTotal_KL.OptionsColumn.ReadOnly = true;
      this.gcTotal_KL.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Total_KL", "{0:0.##}")
      });
      this.gcTotal_KL.Visible = true;
      this.gcTotal_KL.VisibleIndex = 3;
      this.panelControl2.Controls.Add((Control) this.groupControl2);
      this.panelControl2.Controls.Add((Control) this.groupControl1);
      this.panelControl2.Dock = DockStyle.Fill;
      this.panelControl2.Location = new Point(0, 50);
      this.panelControl2.Name = "panelControl2";
      this.panelControl2.Size = new Size(913, 466);
      this.panelControl2.TabIndex = 5;
      this.groupControl2.Controls.Add((Control) this.grcChiTietTaiXe);
      this.groupControl2.Dock = DockStyle.Fill;
      this.groupControl2.Location = new Point(2, 2);
      this.groupControl2.Name = "groupControl2";
      this.groupControl2.Size = new Size(629, 462);
      this.groupControl2.TabIndex = 1;
      this.groupControl2.Text = "Dữ liệu";
      this.grcChiTietTaiXe.Dock = DockStyle.Fill;
      this.grcChiTietTaiXe.Location = new Point(2, 23);
      this.grcChiTietTaiXe.MainView = (BaseView) this.grvChiTietTaiXe;
      this.grcChiTietTaiXe.Name = "grcChiTietTaiXe";
      this.grcChiTietTaiXe.Size = new Size(625, 437);
      this.grcChiTietTaiXe.TabIndex = 0;
      this.grcChiTietTaiXe.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvChiTietTaiXe
      });
      this.grvChiTietTaiXe.AppearancePrint.HeaderPanel.BackColor = Color.DodgerBlue;
      this.grvChiTietTaiXe.AppearancePrint.HeaderPanel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.grvChiTietTaiXe.AppearancePrint.HeaderPanel.ForeColor = Color.White;
      this.grvChiTietTaiXe.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
      this.grvChiTietTaiXe.AppearancePrint.HeaderPanel.Options.UseFont = true;
      this.grvChiTietTaiXe.AppearancePrint.HeaderPanel.Options.UseForeColor = true;
      this.grvChiTietTaiXe.Columns.AddRange(new GridColumn[3]
      {
        this.gcTenTaiXe,
        this.gcTotal_Tranfer,
        this.gcTotal_KL
      });
      this.grvChiTietTaiXe.GridControl = this.grcChiTietTaiXe;
      groupSummaryItem1.DisplayFormat = "Tổng CP:{0:0.##}";
      groupSummaryItem1.FieldName = "Sum_ValueCP";
      groupSummaryItem1.ShowInGroupColumnFooter = this.gcTotal_Tranfer;
      groupSummaryItem1.SummaryType = SummaryItemType.Sum;
      groupSummaryItem1.Tag = (object) "Sum_ValueCP";
      groupSummaryItem2.DisplayFormat = "Tổng Thực cân:{0:0.##}";
      groupSummaryItem2.FieldName = "Sum_ValueBat";
      groupSummaryItem2.ShowInGroupColumnFooter = this.gcTotal_KL;
      groupSummaryItem2.SummaryType = SummaryItemType.Sum;
      groupSummaryItem2.Tag = (object) "Sum_ValueBat";
      this.grvChiTietTaiXe.GroupSummary.AddRange(new GridSummaryItem[2]
      {
        (GridSummaryItem) groupSummaryItem1,
        (GridSummaryItem) groupSummaryItem2
      });
      this.grvChiTietTaiXe.Name = "grvChiTietTaiXe";
      this.grvChiTietTaiXe.OptionsBehavior.AlignGroupSummaryInGroupRow = DefaultBoolean.True;
      this.grvChiTietTaiXe.OptionsBehavior.AutoExpandAllGroups = true;
      this.grvChiTietTaiXe.OptionsMenu.ShowGroupSummaryEditorItem = true;
      this.grvChiTietTaiXe.OptionsView.ShowFooter = true;
      this.grvChiTietTaiXe.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.gcTenTaiXe, ColumnSortOrder.Ascending)
      });
      this.gcMaTaiXe.Caption = "Mã Tài xế";
      this.gcMaTaiXe.FieldName = "MaTaiXe";
      this.gcMaTaiXe.Name = "gcMaTaiXe";
      this.gcMaTaiXe.OptionsColumn.AllowFocus = false;
      this.gcMaTaiXe.OptionsColumn.ReadOnly = true;
      this.gcMaTaiXe.Visible = true;
      this.gcMaTaiXe.VisibleIndex = 0;
      this.gcTenTaiXe.Caption = "Tên Tài xế";
      this.gcTenTaiXe.FieldName = "TenTaiXe";
      this.gcTenTaiXe.Name = "gcTenTaiXe";
      this.gcTenTaiXe.OptionsColumn.AllowFocus = false;
      this.gcTenTaiXe.OptionsColumn.ReadOnly = true;
      this.gcTenTaiXe.Visible = true;
      this.gcTenTaiXe.VisibleIndex = 1;
      this.groupControl1.Controls.Add((Control) this.groupBox2);
      this.groupControl1.Controls.Add((Control) this.groupBox1);
      this.groupControl1.Dock = DockStyle.Right;
      this.groupControl1.Location = new Point(631, 2);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.Size = new Size(280, 462);
      this.groupControl1.TabIndex = 0;
      this.groupControl1.Text = "Tác vụ";
      this.groupBox2.Controls.Add((Control) this.lueCheDo);
      this.groupBox2.Controls.Add((Control) this.btnReset);
      this.groupBox2.Controls.Add((Control) this.btnTimKiem);
      this.groupBox2.Controls.Add((Control) this.lueTaiXe);
      this.groupBox2.Controls.Add((Control) this.labelControl3);
      this.groupBox2.Controls.Add((Control) this.labelControl2);
      this.groupBox2.Controls.Add((Control) this.datToDate);
      this.groupBox2.Controls.Add((Control) this.datFromDate);
      this.groupBox2.Controls.Add((Control) this.labelControl1);
      this.groupBox2.Controls.Add((Control) this.lblFromDate);
      this.groupBox2.Dock = DockStyle.Fill;
      this.groupBox2.Location = new Point(2, 23);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(276, 291);
      this.groupBox2.TabIndex = 75;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Bộ lọc";
      this.lueCheDo.Location = new Point(112, 120);
      this.lueCheDo.Name = "lueCheDo";
      this.lueCheDo.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueCheDo.Properties.Appearance.Options.UseFont = true;
      this.lueCheDo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueCheDo.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("ID", "ID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("DisplayText", "Chế độ")
      });
      this.lueCheDo.Properties.DisplayMember = "DisplayText";
      this.lueCheDo.Properties.NullText = "";
      this.lueCheDo.Properties.ValueMember = "ID";
      this.lueCheDo.Size = new Size(150, 22);
      this.lueCheDo.TabIndex = 72;
      this.btnReset.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnReset.Appearance.Options.UseFont = true;
      this.btnReset.Location = new Point(22, 173);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new Size(108, 32);
      this.btnReset.TabIndex = 9;
      this.btnReset.Text = "Làm mới";
      this.btnReset.Click += new EventHandler(this.btnReset_Click);
      this.btnTimKiem.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnTimKiem.Appearance.Options.UseFont = true;
      this.btnTimKiem.Location = new Point(154, 173);
      this.btnTimKiem.Name = "btnTimKiem";
      this.btnTimKiem.Size = new Size(108, 32);
      this.btnTimKiem.TabIndex = 8;
      this.btnTimKiem.Text = "Tìm";
      this.btnTimKiem.Click += new EventHandler(this.btnTimKiem_Click);
      this.lueTaiXe.Location = new Point(112, 90);
      this.lueTaiXe.Name = "lueTaiXe";
      this.lueTaiXe.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueTaiXe.Properties.Appearance.Options.UseFont = true;
      this.lueTaiXe.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueTaiXe.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("TaiXeID", "TaiXeID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("TenTaiXe", "Tên Tài xế")
      });
      this.lueTaiXe.Properties.DisplayMember = "TenTaiXe";
      this.lueTaiXe.Properties.NullText = "";
      this.lueTaiXe.Properties.ValueMember = "TaiXeID";
      this.lueTaiXe.Size = new Size(150, 22);
      this.lueTaiXe.TabIndex = 6;
      this.labelControl3.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Location = new Point(22, 123);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new Size(40, 16);
      this.labelControl3.TabIndex = 5;
      this.labelControl3.Text = "Chế độ";
      this.labelControl2.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new Point(22, 93);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(61, 16);
      this.labelControl2.TabIndex = 4;
      this.labelControl2.Text = "Tên Tài xế";
      this.datToDate.EditValue = (object) new DateTime(2024, 5, 20, 0, 0, 0, 0);
      this.datToDate.Location = new Point(112, 60);
      this.datToDate.Name = "datToDate";
      this.datToDate.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.datToDate.Properties.Appearance.Options.UseFont = true;
      this.datToDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datToDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
      this.datToDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.datToDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
      this.datToDate.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.datToDate.Properties.Mask.EditMask = "dd/MM/yyyy";
      this.datToDate.Size = new Size(150, 22);
      this.datToDate.TabIndex = 3;
      this.datFromDate.EditValue = (object) new DateTime(2024, 5, 20, 0, 0, 0, 0);
      this.datFromDate.Location = new Point(112, 30);
      this.datFromDate.Name = "datFromDate";
      this.datFromDate.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.datFromDate.Properties.Appearance.Options.UseFont = true;
      this.datFromDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datFromDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
      this.datFromDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.datFromDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
      this.datFromDate.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.datFromDate.Properties.Mask.EditMask = "dd/MM/yyyy";
      this.datFromDate.Size = new Size(150, 22);
      this.datFromDate.TabIndex = 2;
      this.labelControl1.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(22, 63);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(54, 16);
      this.labelControl1.TabIndex = 1;
      this.labelControl1.Text = "Đến ngày";
      this.lblFromDate.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblFromDate.Appearance.Options.UseFont = true;
      this.lblFromDate.Location = new Point(22, 33);
      this.lblFromDate.Name = "lblFromDate";
      this.lblFromDate.Size = new Size(69, 16);
      this.lblFromDate.TabIndex = 0;
      this.lblFromDate.Text = "Tạo từ ngày";
      this.groupBox1.Controls.Add((Control) this.btnExportExcel);
      this.groupBox1.Dock = DockStyle.Bottom;
      this.groupBox1.Location = new Point(2, 314);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(276, 146);
      this.groupBox1.TabIndex = 74;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Xuất dữ liệu";
      this.btnExportExcel.AllowFocus = false;
      this.btnExportExcel.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnExportExcel.Appearance.Options.UseFont = true;
      this.btnExportExcel.ImageOptions.AllowGlyphSkinning = DefaultBoolean.False;
      this.btnExportExcel.ImageOptions.Image = (Image) ResourceNhua.eexport_Excel;
      this.btnExportExcel.ImageOptions.ImageToTextAlignment = ImageAlignToText.LeftCenter;
      this.btnExportExcel.ImageOptions.Location = ImageLocation.MiddleCenter;
      this.btnExportExcel.Location = new Point(80, 60);
      this.btnExportExcel.Name = "btnExportExcel";
      this.btnExportExcel.Size = new Size(120, 45);
      this.btnExportExcel.TabIndex = 74;
      this.btnExportExcel.Text = "Xuất Excel";
      this.btnExportExcel.Click += new EventHandler(this.btnExportExcel_Click);
      this.panelControl1.Controls.Add((Control) this.labelControl4);
      this.panelControl1.Dock = DockStyle.Top;
      this.panelControl1.Location = new Point(0, 0);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new Size(913, 50);
      this.panelControl1.TabIndex = 4;
      this.labelControl4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.labelControl4.Appearance.Font = new Font("Tahoma", 15.75f, FontStyle.Bold);
      this.labelControl4.Appearance.Options.UseFont = true;
      this.labelControl4.AutoSizeMode = LabelAutoSizeMode.None;
      this.labelControl4.Location = new Point(10, 2);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new Size(903, 0);
      this.labelControl4.TabIndex = 0;
      this.labelControl4.Text = "BÁO CÁO CHI TIẾT TÀI XẾ";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.panelControl2);
      this.Controls.Add((Control) this.panelControl1);
      this.Name = nameof (ReportChiTietTaiXe);
      this.Size = new Size(913, 516);
      this.panelControl2.EndInit();
      this.groupControl2.EndInit();
      this.grcChiTietTaiXe.EndInit();
      this.grvChiTietTaiXe.EndInit();
      this.groupControl1.EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.lueCheDo.Properties.EndInit();
      this.lueTaiXe.Properties.EndInit();
      this.datToDate.Properties.CalendarTimeProperties.EndInit();
      this.datToDate.Properties.EndInit();
      this.datFromDate.Properties.CalendarTimeProperties.EndInit();
      this.datFromDate.Properties.EndInit();
      this.groupBox1.ResumeLayout(false);
      this.panelControl1.EndInit();
      this.ResumeLayout(false);
    }
  }
}
