using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using NhuaNong.ClientSetting;
using NhuaNong.Data;
using NhuaNong.Utils;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NhuaNong.MasterData
{
  public partial class DataMixMngView
  {
    private IContainer components;

    // Token: 0x04000687 RID: 1671
    private GroupBox groupBox4;

    // Token: 0x04000688 RID: 1672
    private PanelControl panelControl1;

    // Token: 0x04000689 RID: 1673
    private LabelControl labelControl4;

    // Token: 0x0400068A RID: 1674
    private GridControl grcDataMix;

    // Token: 0x0400068B RID: 1675
    private GridView grvDataMix;

    // Token: 0x0400068C RID: 1676
    private GridColumn gcMaPhieuTron;

    // Token: 0x0400068D RID: 1677
    private GridColumn gcDate;

    // Token: 0x0400068E RID: 1678
    private GridColumn gcTime;

    // Token: 0x0400068F RID: 1679
    private GridColumn gcKhachHang;

    // Token: 0x04000690 RID: 1680
    private GridColumn gcCongTruong;

    // Token: 0x04000691 RID: 1681
    private GridColumn gcTaiXe;

    // Token: 0x04000692 RID: 1682
    private GridColumn gcMAC;

    // Token: 0x04000693 RID: 1683
    private GridColumn gcKLMe;

    // Token: 0x04000694 RID: 1684
    private GridColumn gcAgg1;

    // Token: 0x04000695 RID: 1685
    private GridColumn gcAgg2;

    // Token: 0x04000696 RID: 1686
    private GridColumn gcAgg3;

    // Token: 0x04000697 RID: 1687
    private GridColumn gcAgg4;

    // Token: 0x04000698 RID: 1688
    private GridColumn gcAgg5;

    // Token: 0x04000699 RID: 1689
    private GridColumn gcAgg6;

    // Token: 0x0400069A RID: 1690
    private GridColumn gcCe1;

    // Token: 0x0400069B RID: 1691
    private GridColumn gcCe2;

    // Token: 0x0400069C RID: 1692
    private GridColumn gcCe3;

    // Token: 0x0400069D RID: 1693
    private GridColumn gcCe4;

    // Token: 0x0400069E RID: 1694
    private GridColumn gcCe5;

    // Token: 0x0400069F RID: 1695
    private GridColumn gcWa1;

    // Token: 0x040006A0 RID: 1696
    private GridColumn gcWa2;

    // Token: 0x040006A1 RID: 1697
    private GridColumn gcAdd1;

    // Token: 0x040006A2 RID: 1698
    private GridColumn gcAdd2;

    // Token: 0x040006A3 RID: 1699
    private GridColumn gcAdd3;

    // Token: 0x040006A4 RID: 1700
    private GridColumn gcAdd4;

    // Token: 0x040006A5 RID: 1701
    private GridColumn gcAdd5;

    // Token: 0x040006A6 RID: 1702
    private GridColumn gcAdd6;

    // Token: 0x040006A7 RID: 1703
    private GridView gridView1;

    // Token: 0x040006A8 RID: 1704
    private GroupControl groupControl1;

    // Token: 0x040006A9 RID: 1705
    private GroupBox groupBox3;

    // Token: 0x040006AA RID: 1706
    private DateEdit datToDate;

    // Token: 0x040006AB RID: 1707
    private SimpleButton simpleButton1;

    // Token: 0x040006AC RID: 1708
    private DateEdit datFromDate;

    // Token: 0x040006AD RID: 1709
    private LabelControl labelControl2;

    // Token: 0x040006AE RID: 1710
    private LookUpEdit lookUpEdit5;

    // Token: 0x040006AF RID: 1711
    private LabelControl labelControl1;

    // Token: 0x040006B0 RID: 1712
    private LabelControl labelControl9;

    // Token: 0x040006B1 RID: 1713
    private LookUpEdit lookUpEdit4;

    // Token: 0x040006B2 RID: 1714
    private LabelControl labelControl8;

    // Token: 0x040006B3 RID: 1715
    private LookUpEdit lookUpEdit3;

    // Token: 0x040006B4 RID: 1716
    private LabelControl labelControl7;

    // Token: 0x040006B5 RID: 1717
    private LookUpEdit lookUpEdit2;

    // Token: 0x040006B6 RID: 1718
    private LabelControl labelControl6;

    // Token: 0x040006B7 RID: 1719
    private LookUpEdit lookUpEdit1;

    // Token: 0x040006B8 RID: 1720
    private LabelControl labelControl5;

    // Token: 0x040006B9 RID: 1721
    private TextEdit txtMaPT;

    // Token: 0x040006BA RID: 1722
    private LabelControl labelControl3;

    // Token: 0x040006BB RID: 1723
    private GroupBox groupBox5;

    // Token: 0x040006BC RID: 1724
    private SimpleButton simpleButton2;

    // Token: 0x040006BD RID: 1725
    private GroupControl groupControl2;

    // Token: 0x040006BE RID: 1726
    private LookUpEdit lookUpEdit6;

    // Token: 0x040006BF RID: 1727
    private LabelControl labelControl10;

    // Token: 0x040006C0 RID: 1728
    private SimpleButton simpleButton3;

    // Token: 0x040006C1 RID: 1729
    private LookUpEdit lookUpEdit7;

    // Token: 0x040006C2 RID: 1730
    private LabelControl labelControl11;

    // Token: 0x040006C3 RID: 1731
    private LookUpEdit lookUpEdit8;

    // Token: 0x040006C4 RID: 1732
    private LabelControl labelControl12;

    // Token: 0x040006C5 RID: 1733
    private GridColumn gcAgg1_Bat;

    // Token: 0x040006C6 RID: 1734
    private GridColumn gcAgg2_Bat;

    // Token: 0x040006C7 RID: 1735
    private GridColumn gcAgg3_Bat;

    // Token: 0x040006C8 RID: 1736
    private GridColumn gcAgg4_Bat;

    // Token: 0x040006C9 RID: 1737
    private GridColumn gcAgg5_Bat;

    // Token: 0x040006CA RID: 1738
    private GridColumn gcAgg6_Bat;

    // Token: 0x040006CB RID: 1739
    private GridColumn gcCe1_Bat;

    // Token: 0x040006CC RID: 1740
    private GridColumn gcCe2_Bat;

    // Token: 0x040006CD RID: 1741
    private GridColumn gcCe3_Bat;

    // Token: 0x040006CE RID: 1742
    private GridColumn gcCe4_Bat;

    // Token: 0x040006CF RID: 1743
    private GridColumn gcCe5_Bat;

    // Token: 0x040006D0 RID: 1744
    private GridColumn gcWa1_Bat;

    // Token: 0x040006D1 RID: 1745
    private GridColumn gcWa2_Bat;

    // Token: 0x040006D2 RID: 1746
    private GridColumn gcAdd1_Bat;

    // Token: 0x040006D3 RID: 1747
    private GridColumn gcAdd2_Bat;

    // Token: 0x040006D4 RID: 1748
    private GridColumn gcAdd3_Bat;

    // Token: 0x040006D5 RID: 1749
    private GridColumn gcAdd4_Bat;

    // Token: 0x040006D6 RID: 1750
    private GridColumn gcAdd5_Bat;

    // Token: 0x040006D7 RID: 1751
    private GridColumn gridColumn1;

    // Token: 0x060008E7 RID: 2279 RVA: 0x000521F1 File Offset: 0x000503F1
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
      {
        this.components.Dispose();
      }
      base.Dispose(disposing);
    }

    // Token: 0x060008E8 RID: 2280 RVA: 0x00052210 File Offset: 0x00050410
    private void InitializeComponent()
    {
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
      this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
      this.grcDataMix = new DevExpress.XtraGrid.GridControl();
      this.grvDataMix = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.gcMaPhieuTron = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcDate = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcTime = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcCongTruong = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcTaiXe = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcMAC = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcKLMe = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcAgg1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcAgg1_Bat = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcAgg2 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcAgg2_Bat = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcAgg3 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcAgg3_Bat = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcAgg4 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcAgg4_Bat = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcAgg5 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcAgg5_Bat = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcAgg6 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcAgg6_Bat = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcCe1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcCe1_Bat = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcCe2 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcCe2_Bat = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcCe3 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcCe3_Bat = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcCe4 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcCe4_Bat = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcCe5 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcCe5_Bat = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcWa1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcWa1_Bat = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcWa2 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcWa2_Bat = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcAdd1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcAdd1_Bat = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcAdd2 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcAdd2_Bat = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcAdd3 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcAdd3_Bat = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcAdd4 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcAdd4_Bat = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcAdd5 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcAdd5_Bat = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcAdd6 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.lookUpEdit8 = new DevExpress.XtraEditors.LookUpEdit();
      this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
      this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
      this.lookUpEdit7 = new DevExpress.XtraEditors.LookUpEdit();
      this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
      this.lookUpEdit6 = new DevExpress.XtraEditors.LookUpEdit();
      this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
      this.datToDate = new DevExpress.XtraEditors.DateEdit();
      this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
      this.datFromDate = new DevExpress.XtraEditors.DateEdit();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.lookUpEdit5 = new DevExpress.XtraEditors.LookUpEdit();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
      this.lookUpEdit4 = new DevExpress.XtraEditors.LookUpEdit();
      this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
      this.lookUpEdit3 = new DevExpress.XtraEditors.LookUpEdit();
      this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
      this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
      this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
      this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
      this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
      this.txtMaPT = new DevExpress.XtraEditors.TextEdit();
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
      this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
      this.groupBox4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
      this.panelControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grcDataMix)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grvDataMix)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
      this.groupControl1.SuspendLayout();
      this.groupBox3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit8.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit7.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit6.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.datToDate.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.datToDate.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.datFromDate.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.datFromDate.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit5.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit4.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtMaPT.Properties)).BeginInit();
      this.groupBox5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
      this.groupControl2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.panelControl1);
      this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox4.Location = new System.Drawing.Point(0, 0);
      this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox4.Size = new System.Drawing.Size(1575, 189);
      this.groupBox4.TabIndex = 2;
      this.groupBox4.TabStop = false;
      // 
      // panelControl1
      // 
      this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.panelControl1.Controls.Add(this.labelControl4);
      this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelControl1.Location = new System.Drawing.Point(4, 19);
      this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new System.Drawing.Size(1567, 69);
      this.panelControl1.TabIndex = 2;
      // 
      // labelControl4
      // 
      this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelControl4.Appearance.Options.UseFont = true;
      this.labelControl4.Appearance.Options.UseTextOptions = true;
      this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.labelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.labelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.labelControl4.Location = new System.Drawing.Point(0, 0);
      this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new System.Drawing.Size(1567, 69);
      this.labelControl4.TabIndex = 0;
      this.labelControl4.Text = "BÁO CÁO CHI TIẾT MẺ TRỘN";
      // 
      // grcDataMix
      // 
      this.grcDataMix.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grcDataMix.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.grcDataMix.Location = new System.Drawing.Point(2, 28);
      this.grcDataMix.MainView = this.grvDataMix;
      this.grcDataMix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.grcDataMix.Name = "grcDataMix";
      this.grcDataMix.Size = new System.Drawing.Size(2435, 612);
      this.grcDataMix.TabIndex = 0;
      this.grcDataMix.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDataMix,
            this.gridView1});
      // 
      // grvDataMix
      // 
      this.grvDataMix.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMaPhieuTron,
            this.gcDate,
            this.gridColumn1,
            this.gcTime,
            this.gcKhachHang,
            this.gcCongTruong,
            this.gcTaiXe,
            this.gcMAC,
            this.gcKLMe,
            this.gcAgg1,
            this.gcAgg1_Bat,
            this.gcAgg2,
            this.gcAgg2_Bat,
            this.gcAgg3,
            this.gcAgg3_Bat,
            this.gcAgg4,
            this.gcAgg4_Bat,
            this.gcAgg5,
            this.gcAgg5_Bat,
            this.gcAgg6,
            this.gcAgg6_Bat,
            this.gcCe1,
            this.gcCe1_Bat,
            this.gcCe2,
            this.gcCe2_Bat,
            this.gcCe3,
            this.gcCe3_Bat,
            this.gcCe4,
            this.gcCe4_Bat,
            this.gcCe5,
            this.gcCe5_Bat,
            this.gcWa1,
            this.gcWa1_Bat,
            this.gcWa2,
            this.gcWa2_Bat,
            this.gcAdd1,
            this.gcAdd1_Bat,
            this.gcAdd2,
            this.gcAdd2_Bat,
            this.gcAdd3,
            this.gcAdd3_Bat,
            this.gcAdd4,
            this.gcAdd4_Bat,
            this.gcAdd5,
            this.gcAdd5_Bat,
            this.gcAdd6});
      this.grvDataMix.DetailHeight = 431;
      this.grvDataMix.GridControl = this.grcDataMix;
      this.grvDataMix.Name = "grvDataMix";
      this.grvDataMix.OptionsView.ShowFooter = true;
      // 
      // gcMaPhieuTron
      // 
      this.gcMaPhieuTron.Caption = "Mã Phiếu trộn";
      this.gcMaPhieuTron.FieldName = "MaPhieuTron";
      this.gcMaPhieuTron.MinWidth = 100;
      this.gcMaPhieuTron.Name = "gcMaPhieuTron";
      this.gcMaPhieuTron.OptionsColumn.AllowEdit = false;
      this.gcMaPhieuTron.OptionsColumn.ReadOnly = true;
      this.gcMaPhieuTron.Visible = true;
      this.gcMaPhieuTron.VisibleIndex = 0;
      this.gcMaPhieuTron.Width = 100;
      // 
      // gcDate
      // 
      this.gcDate.Caption = "Ngày trộn";
      this.gcDate.FieldName = "Ngay";
      this.gcDate.MinWidth = 100;
      this.gcDate.Name = "gcDate";
      this.gcDate.OptionsColumn.AllowEdit = false;
      this.gcDate.OptionsColumn.ReadOnly = true;
      this.gcDate.Visible = true;
      this.gcDate.VisibleIndex = 1;
      this.gcDate.Width = 100;
      // 
      // gridColumn1
      // 
      this.gridColumn1.Caption = "Is Manual";
      this.gridColumn1.FieldName = "IsManual";
      this.gridColumn1.MinWidth = 67;
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 2;
      this.gridColumn1.Width = 100;
      // 
      // gcTime
      // 
      this.gcTime.Caption = "Giờ";
      this.gcTime.FieldName = "Gio";
      this.gcTime.MinWidth = 100;
      this.gcTime.Name = "gcTime";
      this.gcTime.OptionsColumn.AllowEdit = false;
      this.gcTime.OptionsColumn.ReadOnly = true;
      this.gcTime.Visible = true;
      this.gcTime.VisibleIndex = 3;
      this.gcTime.Width = 100;
      // 
      // gcKhachHang
      // 
      this.gcKhachHang.Caption = "Khách hàng";
      this.gcKhachHang.FieldName = "KH";
      this.gcKhachHang.MinWidth = 133;
      this.gcKhachHang.Name = "gcKhachHang";
      this.gcKhachHang.OptionsColumn.AllowEdit = false;
      this.gcKhachHang.OptionsColumn.ReadOnly = true;
      this.gcKhachHang.Visible = true;
      this.gcKhachHang.VisibleIndex = 4;
      this.gcKhachHang.Width = 133;
      // 
      // gcCongTruong
      // 
      this.gcCongTruong.Caption = "Công trường";
      this.gcCongTruong.FieldName = "CT";
      this.gcCongTruong.MinWidth = 133;
      this.gcCongTruong.Name = "gcCongTruong";
      this.gcCongTruong.OptionsColumn.AllowEdit = false;
      this.gcCongTruong.OptionsColumn.ReadOnly = true;
      this.gcCongTruong.Visible = true;
      this.gcCongTruong.VisibleIndex = 5;
      this.gcCongTruong.Width = 133;
      // 
      // gcTaiXe
      // 
      this.gcTaiXe.Caption = "Tài xế";
      this.gcTaiXe.FieldName = "Name";
      this.gcTaiXe.MinWidth = 100;
      this.gcTaiXe.Name = "gcTaiXe";
      this.gcTaiXe.OptionsColumn.AllowEdit = false;
      this.gcTaiXe.OptionsColumn.ReadOnly = true;
      this.gcTaiXe.Visible = true;
      this.gcTaiXe.VisibleIndex = 44;
      this.gcTaiXe.Width = 100;
      // 
      // gcMAC
      // 
      this.gcMAC.Caption = "MAC";
      this.gcMAC.FieldName = "NoteMAC";
      this.gcMAC.MinWidth = 100;
      this.gcMAC.Name = "gcMAC";
      this.gcMAC.OptionsColumn.AllowEdit = false;
      this.gcMAC.OptionsColumn.ReadOnly = true;
      this.gcMAC.Visible = true;
      this.gcMAC.VisibleIndex = 6;
      this.gcMAC.Width = 100;
      // 
      // gcKLMe
      // 
      this.gcKLMe.Caption = "KL Mẻ";
      this.gcKLMe.FieldName = "KLMe";
      this.gcKLMe.MinWidth = 100;
      this.gcKLMe.Name = "gcKLMe";
      this.gcKLMe.OptionsColumn.AllowEdit = false;
      this.gcKLMe.OptionsColumn.ReadOnly = true;
      this.gcKLMe.Visible = true;
      this.gcKLMe.VisibleIndex = 7;
      this.gcKLMe.Width = 100;
      // 
      // gcAgg1
      // 
      this.gcAgg1.Caption = "Agg 1";
      this.gcAgg1.FieldName = "Agg1";
      this.gcAgg1.MinWidth = 100;
      this.gcAgg1.Name = "gcAgg1";
      this.gcAgg1.OptionsColumn.AllowEdit = false;
      this.gcAgg1.OptionsColumn.ReadOnly = true;
      this.gcAgg1.Visible = true;
      this.gcAgg1.VisibleIndex = 8;
      this.gcAgg1.Width = 100;
      // 
      // gcAgg1_Bat
      // 
      this.gcAgg1_Bat.Caption = "T_Agg1";
      this.gcAgg1_Bat.FieldName = "Agg1_Bat";
      this.gcAgg1_Bat.MinWidth = 100;
      this.gcAgg1_Bat.Name = "gcAgg1_Bat";
      this.gcAgg1_Bat.Visible = true;
      this.gcAgg1_Bat.VisibleIndex = 9;
      this.gcAgg1_Bat.Width = 100;
      // 
      // gcAgg2
      // 
      this.gcAgg2.Caption = "Agg 2";
      this.gcAgg2.FieldName = "Agg2";
      this.gcAgg2.MinWidth = 100;
      this.gcAgg2.Name = "gcAgg2";
      this.gcAgg2.OptionsColumn.AllowEdit = false;
      this.gcAgg2.OptionsColumn.ReadOnly = true;
      this.gcAgg2.Visible = true;
      this.gcAgg2.VisibleIndex = 10;
      this.gcAgg2.Width = 100;
      // 
      // gcAgg2_Bat
      // 
      this.gcAgg2_Bat.Caption = "T_Agg2";
      this.gcAgg2_Bat.FieldName = "Agg2_Bat";
      this.gcAgg2_Bat.MinWidth = 100;
      this.gcAgg2_Bat.Name = "gcAgg2_Bat";
      this.gcAgg2_Bat.Visible = true;
      this.gcAgg2_Bat.VisibleIndex = 11;
      this.gcAgg2_Bat.Width = 100;
      // 
      // gcAgg3
      // 
      this.gcAgg3.Caption = "Agg 3";
      this.gcAgg3.FieldName = "Agg3";
      this.gcAgg3.MinWidth = 100;
      this.gcAgg3.Name = "gcAgg3";
      this.gcAgg3.OptionsColumn.AllowEdit = false;
      this.gcAgg3.OptionsColumn.ReadOnly = true;
      this.gcAgg3.Visible = true;
      this.gcAgg3.VisibleIndex = 12;
      this.gcAgg3.Width = 100;
      // 
      // gcAgg3_Bat
      // 
      this.gcAgg3_Bat.Caption = "T_Agg3";
      this.gcAgg3_Bat.FieldName = "Agg3_Bat";
      this.gcAgg3_Bat.MinWidth = 100;
      this.gcAgg3_Bat.Name = "gcAgg3_Bat";
      this.gcAgg3_Bat.Visible = true;
      this.gcAgg3_Bat.VisibleIndex = 13;
      this.gcAgg3_Bat.Width = 100;
      // 
      // gcAgg4
      // 
      this.gcAgg4.Caption = "Agg 4";
      this.gcAgg4.FieldName = "Agg4";
      this.gcAgg4.MinWidth = 100;
      this.gcAgg4.Name = "gcAgg4";
      this.gcAgg4.OptionsColumn.AllowEdit = false;
      this.gcAgg4.OptionsColumn.ReadOnly = true;
      this.gcAgg4.Visible = true;
      this.gcAgg4.VisibleIndex = 14;
      this.gcAgg4.Width = 100;
      // 
      // gcAgg4_Bat
      // 
      this.gcAgg4_Bat.Caption = "T_Agg4";
      this.gcAgg4_Bat.FieldName = "Agg4_Bat";
      this.gcAgg4_Bat.MinWidth = 100;
      this.gcAgg4_Bat.Name = "gcAgg4_Bat";
      this.gcAgg4_Bat.Visible = true;
      this.gcAgg4_Bat.VisibleIndex = 15;
      this.gcAgg4_Bat.Width = 100;
      // 
      // gcAgg5
      // 
      this.gcAgg5.Caption = "Agg 5";
      this.gcAgg5.FieldName = "Agg5";
      this.gcAgg5.MinWidth = 100;
      this.gcAgg5.Name = "gcAgg5";
      this.gcAgg5.OptionsColumn.AllowEdit = false;
      this.gcAgg5.OptionsColumn.ReadOnly = true;
      this.gcAgg5.Visible = true;
      this.gcAgg5.VisibleIndex = 16;
      this.gcAgg5.Width = 100;
      // 
      // gcAgg5_Bat
      // 
      this.gcAgg5_Bat.Caption = "T_Agg5";
      this.gcAgg5_Bat.FieldName = "Agg5_Bat";
      this.gcAgg5_Bat.MinWidth = 100;
      this.gcAgg5_Bat.Name = "gcAgg5_Bat";
      this.gcAgg5_Bat.Visible = true;
      this.gcAgg5_Bat.VisibleIndex = 17;
      this.gcAgg5_Bat.Width = 100;
      // 
      // gcAgg6
      // 
      this.gcAgg6.Caption = "Agg 6";
      this.gcAgg6.FieldName = "Agg6";
      this.gcAgg6.MinWidth = 100;
      this.gcAgg6.Name = "gcAgg6";
      this.gcAgg6.OptionsColumn.AllowEdit = false;
      this.gcAgg6.OptionsColumn.ReadOnly = true;
      this.gcAgg6.Visible = true;
      this.gcAgg6.VisibleIndex = 18;
      this.gcAgg6.Width = 100;
      // 
      // gcAgg6_Bat
      // 
      this.gcAgg6_Bat.Caption = "T_Agg6";
      this.gcAgg6_Bat.FieldName = "Agg6_Bat";
      this.gcAgg6_Bat.MinWidth = 100;
      this.gcAgg6_Bat.Name = "gcAgg6_Bat";
      this.gcAgg6_Bat.Visible = true;
      this.gcAgg6_Bat.VisibleIndex = 19;
      this.gcAgg6_Bat.Width = 100;
      // 
      // gcCe1
      // 
      this.gcCe1.Caption = "Ce 1";
      this.gcCe1.FieldName = "Ce1";
      this.gcCe1.MinWidth = 100;
      this.gcCe1.Name = "gcCe1";
      this.gcCe1.OptionsColumn.AllowEdit = false;
      this.gcCe1.OptionsColumn.ReadOnly = true;
      this.gcCe1.Visible = true;
      this.gcCe1.VisibleIndex = 20;
      this.gcCe1.Width = 100;
      // 
      // gcCe1_Bat
      // 
      this.gcCe1_Bat.Caption = "T_Ce1";
      this.gcCe1_Bat.FieldName = "Ce1_Bat";
      this.gcCe1_Bat.MinWidth = 100;
      this.gcCe1_Bat.Name = "gcCe1_Bat";
      this.gcCe1_Bat.Visible = true;
      this.gcCe1_Bat.VisibleIndex = 21;
      this.gcCe1_Bat.Width = 100;
      // 
      // gcCe2
      // 
      this.gcCe2.Caption = "Ce 2";
      this.gcCe2.FieldName = "Ce2";
      this.gcCe2.MinWidth = 100;
      this.gcCe2.Name = "gcCe2";
      this.gcCe2.OptionsColumn.AllowEdit = false;
      this.gcCe2.OptionsColumn.ReadOnly = true;
      this.gcCe2.Visible = true;
      this.gcCe2.VisibleIndex = 22;
      this.gcCe2.Width = 100;
      // 
      // gcCe2_Bat
      // 
      this.gcCe2_Bat.Caption = "T_Ce2";
      this.gcCe2_Bat.FieldName = "Ce2_Bat";
      this.gcCe2_Bat.MinWidth = 100;
      this.gcCe2_Bat.Name = "gcCe2_Bat";
      this.gcCe2_Bat.Visible = true;
      this.gcCe2_Bat.VisibleIndex = 23;
      this.gcCe2_Bat.Width = 100;
      // 
      // gcCe3
      // 
      this.gcCe3.Caption = "Ce 3";
      this.gcCe3.FieldName = "Ce3";
      this.gcCe3.MinWidth = 100;
      this.gcCe3.Name = "gcCe3";
      this.gcCe3.OptionsColumn.AllowEdit = false;
      this.gcCe3.OptionsColumn.ReadOnly = true;
      this.gcCe3.Visible = true;
      this.gcCe3.VisibleIndex = 24;
      this.gcCe3.Width = 100;
      // 
      // gcCe3_Bat
      // 
      this.gcCe3_Bat.Caption = "T_Ce3";
      this.gcCe3_Bat.FieldName = "Ce3_Bat";
      this.gcCe3_Bat.MinWidth = 100;
      this.gcCe3_Bat.Name = "gcCe3_Bat";
      this.gcCe3_Bat.Visible = true;
      this.gcCe3_Bat.VisibleIndex = 25;
      this.gcCe3_Bat.Width = 100;
      // 
      // gcCe4
      // 
      this.gcCe4.Caption = "Ce 4";
      this.gcCe4.FieldName = "Ce4";
      this.gcCe4.MinWidth = 100;
      this.gcCe4.Name = "gcCe4";
      this.gcCe4.OptionsColumn.AllowEdit = false;
      this.gcCe4.OptionsColumn.ReadOnly = true;
      this.gcCe4.Visible = true;
      this.gcCe4.VisibleIndex = 26;
      this.gcCe4.Width = 100;
      // 
      // gcCe4_Bat
      // 
      this.gcCe4_Bat.Caption = "T_Ce4";
      this.gcCe4_Bat.FieldName = "Ce4_Bat";
      this.gcCe4_Bat.MinWidth = 100;
      this.gcCe4_Bat.Name = "gcCe4_Bat";
      this.gcCe4_Bat.Visible = true;
      this.gcCe4_Bat.VisibleIndex = 27;
      this.gcCe4_Bat.Width = 100;
      // 
      // gcCe5
      // 
      this.gcCe5.Caption = "Ce 5";
      this.gcCe5.FieldName = "Ce5";
      this.gcCe5.MinWidth = 100;
      this.gcCe5.Name = "gcCe5";
      this.gcCe5.OptionsColumn.AllowEdit = false;
      this.gcCe5.OptionsColumn.ReadOnly = true;
      this.gcCe5.Visible = true;
      this.gcCe5.VisibleIndex = 28;
      this.gcCe5.Width = 100;
      // 
      // gcCe5_Bat
      // 
      this.gcCe5_Bat.Caption = "T_Ce5";
      this.gcCe5_Bat.FieldName = "Ce5_Bat";
      this.gcCe5_Bat.MinWidth = 100;
      this.gcCe5_Bat.Name = "gcCe5_Bat";
      this.gcCe5_Bat.Visible = true;
      this.gcCe5_Bat.VisibleIndex = 29;
      this.gcCe5_Bat.Width = 100;
      // 
      // gcWa1
      // 
      this.gcWa1.Caption = "Wa 1";
      this.gcWa1.FieldName = "Wa1";
      this.gcWa1.MinWidth = 100;
      this.gcWa1.Name = "gcWa1";
      this.gcWa1.OptionsColumn.AllowEdit = false;
      this.gcWa1.OptionsColumn.ReadOnly = true;
      this.gcWa1.Visible = true;
      this.gcWa1.VisibleIndex = 30;
      this.gcWa1.Width = 100;
      // 
      // gcWa1_Bat
      // 
      this.gcWa1_Bat.Caption = "T_Wa1";
      this.gcWa1_Bat.FieldName = "Wa1_Bat";
      this.gcWa1_Bat.MinWidth = 100;
      this.gcWa1_Bat.Name = "gcWa1_Bat";
      this.gcWa1_Bat.Visible = true;
      this.gcWa1_Bat.VisibleIndex = 31;
      this.gcWa1_Bat.Width = 100;
      // 
      // gcWa2
      // 
      this.gcWa2.Caption = "Wa 2";
      this.gcWa2.FieldName = "Wa2";
      this.gcWa2.MinWidth = 100;
      this.gcWa2.Name = "gcWa2";
      this.gcWa2.OptionsColumn.AllowEdit = false;
      this.gcWa2.OptionsColumn.ReadOnly = true;
      this.gcWa2.Visible = true;
      this.gcWa2.VisibleIndex = 32;
      this.gcWa2.Width = 100;
      // 
      // gcWa2_Bat
      // 
      this.gcWa2_Bat.Caption = "T_Wa2";
      this.gcWa2_Bat.FieldName = "Wa2_Bat";
      this.gcWa2_Bat.MinWidth = 100;
      this.gcWa2_Bat.Name = "gcWa2_Bat";
      this.gcWa2_Bat.Visible = true;
      this.gcWa2_Bat.VisibleIndex = 33;
      this.gcWa2_Bat.Width = 100;
      // 
      // gcAdd1
      // 
      this.gcAdd1.Caption = "Add 1";
      this.gcAdd1.FieldName = "Add1";
      this.gcAdd1.MinWidth = 100;
      this.gcAdd1.Name = "gcAdd1";
      this.gcAdd1.OptionsColumn.AllowEdit = false;
      this.gcAdd1.OptionsColumn.ReadOnly = true;
      this.gcAdd1.Visible = true;
      this.gcAdd1.VisibleIndex = 34;
      this.gcAdd1.Width = 100;
      // 
      // gcAdd1_Bat
      // 
      this.gcAdd1_Bat.Caption = "T_Add1";
      this.gcAdd1_Bat.FieldName = "Add1_Bat";
      this.gcAdd1_Bat.MinWidth = 100;
      this.gcAdd1_Bat.Name = "gcAdd1_Bat";
      this.gcAdd1_Bat.Visible = true;
      this.gcAdd1_Bat.VisibleIndex = 35;
      this.gcAdd1_Bat.Width = 100;
      // 
      // gcAdd2
      // 
      this.gcAdd2.Caption = "Add 2";
      this.gcAdd2.FieldName = "Add2";
      this.gcAdd2.MinWidth = 100;
      this.gcAdd2.Name = "gcAdd2";
      this.gcAdd2.OptionsColumn.AllowEdit = false;
      this.gcAdd2.OptionsColumn.ReadOnly = true;
      this.gcAdd2.Visible = true;
      this.gcAdd2.VisibleIndex = 36;
      this.gcAdd2.Width = 100;
      // 
      // gcAdd2_Bat
      // 
      this.gcAdd2_Bat.Caption = "T_Add2";
      this.gcAdd2_Bat.FieldName = "Add2_Bat";
      this.gcAdd2_Bat.MinWidth = 100;
      this.gcAdd2_Bat.Name = "gcAdd2_Bat";
      this.gcAdd2_Bat.Visible = true;
      this.gcAdd2_Bat.VisibleIndex = 37;
      this.gcAdd2_Bat.Width = 100;
      // 
      // gcAdd3
      // 
      this.gcAdd3.Caption = "Add 3";
      this.gcAdd3.FieldName = "Add3";
      this.gcAdd3.MinWidth = 100;
      this.gcAdd3.Name = "gcAdd3";
      this.gcAdd3.OptionsColumn.AllowEdit = false;
      this.gcAdd3.OptionsColumn.ReadOnly = true;
      this.gcAdd3.Visible = true;
      this.gcAdd3.VisibleIndex = 38;
      this.gcAdd3.Width = 100;
      // 
      // gcAdd3_Bat
      // 
      this.gcAdd3_Bat.Caption = "T_Add3";
      this.gcAdd3_Bat.FieldName = "Add3_Bat";
      this.gcAdd3_Bat.MinWidth = 100;
      this.gcAdd3_Bat.Name = "gcAdd3_Bat";
      this.gcAdd3_Bat.Visible = true;
      this.gcAdd3_Bat.VisibleIndex = 39;
      this.gcAdd3_Bat.Width = 100;
      // 
      // gcAdd4
      // 
      this.gcAdd4.Caption = "Add 4";
      this.gcAdd4.FieldName = "Add4";
      this.gcAdd4.MinWidth = 100;
      this.gcAdd4.Name = "gcAdd4";
      this.gcAdd4.OptionsColumn.AllowEdit = false;
      this.gcAdd4.OptionsColumn.ReadOnly = true;
      this.gcAdd4.Visible = true;
      this.gcAdd4.VisibleIndex = 40;
      this.gcAdd4.Width = 100;
      // 
      // gcAdd4_Bat
      // 
      this.gcAdd4_Bat.Caption = "T_Add4";
      this.gcAdd4_Bat.FieldName = "Add4_Bat";
      this.gcAdd4_Bat.MinWidth = 100;
      this.gcAdd4_Bat.Name = "gcAdd4_Bat";
      this.gcAdd4_Bat.Visible = true;
      this.gcAdd4_Bat.VisibleIndex = 41;
      this.gcAdd4_Bat.Width = 100;
      // 
      // gcAdd5
      // 
      this.gcAdd5.Caption = "Add 5";
      this.gcAdd5.FieldName = "Add5";
      this.gcAdd5.MinWidth = 100;
      this.gcAdd5.Name = "gcAdd5";
      this.gcAdd5.OptionsColumn.AllowEdit = false;
      this.gcAdd5.OptionsColumn.ReadOnly = true;
      this.gcAdd5.Visible = true;
      this.gcAdd5.VisibleIndex = 42;
      this.gcAdd5.Width = 100;
      // 
      // gcAdd5_Bat
      // 
      this.gcAdd5_Bat.Caption = "T_Add5";
      this.gcAdd5_Bat.FieldName = "Add5_Bat";
      this.gcAdd5_Bat.MinWidth = 100;
      this.gcAdd5_Bat.Name = "gcAdd5_Bat";
      this.gcAdd5_Bat.Visible = true;
      this.gcAdd5_Bat.VisibleIndex = 43;
      this.gcAdd5_Bat.Width = 100;
      // 
      // gcAdd6
      // 
      this.gcAdd6.Caption = "Add 6";
      this.gcAdd6.FieldName = "Add5";
      this.gcAdd6.MinWidth = 100;
      this.gcAdd6.Name = "gcAdd6";
      this.gcAdd6.OptionsColumn.AllowEdit = false;
      this.gcAdd6.OptionsColumn.ReadOnly = true;
      this.gcAdd6.Visible = true;
      this.gcAdd6.VisibleIndex = 45;
      this.gcAdd6.Width = 100;
      // 
      // gridView1
      // 
      this.gridView1.DetailHeight = 431;
      this.gridView1.GridControl = this.grcDataMix;
      this.gridView1.Name = "gridView1";
      // 
      // groupControl1
      // 
      this.groupControl1.Controls.Add(this.grcDataMix);
      this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
      this.groupControl1.Location = new System.Drawing.Point(-864, 189);
      this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.Size = new System.Drawing.Size(2439, 642);
      this.groupControl1.TabIndex = 4;
      this.groupControl1.Text = "Dữ liệu";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.lookUpEdit8);
      this.groupBox3.Controls.Add(this.labelControl12);
      this.groupBox3.Controls.Add(this.simpleButton3);
      this.groupBox3.Controls.Add(this.lookUpEdit7);
      this.groupBox3.Controls.Add(this.labelControl11);
      this.groupBox3.Controls.Add(this.lookUpEdit6);
      this.groupBox3.Controls.Add(this.labelControl10);
      this.groupBox3.Controls.Add(this.datToDate);
      this.groupBox3.Controls.Add(this.simpleButton1);
      this.groupBox3.Controls.Add(this.datFromDate);
      this.groupBox3.Controls.Add(this.labelControl2);
      this.groupBox3.Controls.Add(this.lookUpEdit5);
      this.groupBox3.Controls.Add(this.labelControl1);
      this.groupBox3.Controls.Add(this.labelControl9);
      this.groupBox3.Controls.Add(this.lookUpEdit4);
      this.groupBox3.Controls.Add(this.labelControl8);
      this.groupBox3.Controls.Add(this.lookUpEdit3);
      this.groupBox3.Controls.Add(this.labelControl7);
      this.groupBox3.Controls.Add(this.lookUpEdit2);
      this.groupBox3.Controls.Add(this.labelControl6);
      this.groupBox3.Controls.Add(this.lookUpEdit1);
      this.groupBox3.Controls.Add(this.labelControl5);
      this.groupBox3.Controls.Add(this.txtMaPT);
      this.groupBox3.Controls.Add(this.labelControl3);
      this.groupBox3.Location = new System.Drawing.Point(7, 37);
      this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox3.Size = new System.Drawing.Size(305, 471);
      this.groupBox3.TabIndex = 3;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Bộ lọc";
      // 
      // lookUpEdit8
      // 
      this.lookUpEdit8.Location = new System.Drawing.Point(136, 194);
      this.lookUpEdit8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.lookUpEdit8.Name = "lookUpEdit8";
      this.lookUpEdit8.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lookUpEdit8.Properties.NullText = "";
      this.lookUpEdit8.Size = new System.Drawing.Size(153, 22);
      this.lookUpEdit8.TabIndex = 19;
      // 
      // labelControl12
      // 
      this.labelControl12.Location = new System.Drawing.Point(48, 198);
      this.labelControl12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.labelControl12.Name = "labelControl12";
      this.labelControl12.Size = new System.Drawing.Size(57, 16);
      this.labelControl12.TabIndex = 18;
      this.labelControl12.Text = "Hạng mục";
      // 
      // simpleButton3
      // 
      this.simpleButton3.Location = new System.Drawing.Point(23, 404);
      this.simpleButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.simpleButton3.Name = "simpleButton3";
      this.simpleButton3.Size = new System.Drawing.Size(99, 39);
      this.simpleButton3.TabIndex = 17;
      this.simpleButton3.Text = "Làm mới";
      // 
      // lookUpEdit7
      // 
      this.lookUpEdit7.Location = new System.Drawing.Point(136, 226);
      this.lookUpEdit7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.lookUpEdit7.Name = "lookUpEdit7";
      this.lookUpEdit7.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lookUpEdit7.Properties.NullText = "";
      this.lookUpEdit7.Size = new System.Drawing.Size(153, 22);
      this.lookUpEdit7.TabIndex = 16;
      // 
      // labelControl11
      // 
      this.labelControl11.Location = new System.Drawing.Point(72, 230);
      this.labelControl11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.labelControl11.Name = "labelControl11";
      this.labelControl11.Size = new System.Drawing.Size(35, 16);
      this.labelControl11.TabIndex = 15;
      this.labelControl11.Text = "Tài xế";
      // 
      // lookUpEdit6
      // 
      this.lookUpEdit6.Location = new System.Drawing.Point(136, 162);
      this.lookUpEdit6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.lookUpEdit6.Name = "lookUpEdit6";
      this.lookUpEdit6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lookUpEdit6.Properties.NullText = "";
      this.lookUpEdit6.Size = new System.Drawing.Size(153, 22);
      this.lookUpEdit6.TabIndex = 14;
      // 
      // labelControl10
      // 
      this.labelControl10.Location = new System.Drawing.Point(29, 166);
      this.labelControl10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.labelControl10.Name = "labelControl10";
      this.labelControl10.Size = new System.Drawing.Size(71, 16);
      this.labelControl10.TabIndex = 13;
      this.labelControl10.Text = "Công trường";
      // 
      // datToDate
      // 
      this.datToDate.EditValue = null;
      this.datToDate.Location = new System.Drawing.Point(136, 66);
      this.datToDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.datToDate.Name = "datToDate";
      this.datToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.datToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.datToDate.Size = new System.Drawing.Size(153, 22);
      this.datToDate.TabIndex = 3;
      // 
      // simpleButton1
      // 
      this.simpleButton1.Location = new System.Drawing.Point(152, 404);
      this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new System.Drawing.Size(137, 39);
      this.simpleButton1.TabIndex = 2;
      this.simpleButton1.Text = "Tìm kiếm";
      // 
      // datFromDate
      // 
      this.datFromDate.EditValue = null;
      this.datFromDate.Location = new System.Drawing.Point(136, 34);
      this.datFromDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.datFromDate.Name = "datFromDate";
      this.datFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.datFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.datFromDate.Size = new System.Drawing.Size(153, 22);
      this.datFromDate.TabIndex = 2;
      // 
      // labelControl2
      // 
      this.labelControl2.Location = new System.Drawing.Point(84, 70);
      this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(23, 16);
      this.labelControl2.TabIndex = 1;
      this.labelControl2.Text = "Đến";
      // 
      // lookUpEdit5
      // 
      this.lookUpEdit5.Location = new System.Drawing.Point(136, 354);
      this.lookUpEdit5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.lookUpEdit5.Name = "lookUpEdit5";
      this.lookUpEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lookUpEdit5.Properties.NullText = "";
      this.lookUpEdit5.Size = new System.Drawing.Size(153, 22);
      this.lookUpEdit5.TabIndex = 12;
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(93, 38);
      this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(16, 16);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "Từ";
      // 
      // labelControl9
      // 
      this.labelControl9.Location = new System.Drawing.Point(65, 358);
      this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.labelControl9.Name = "labelControl9";
      this.labelControl9.Size = new System.Drawing.Size(40, 16);
      this.labelControl9.TabIndex = 11;
      this.labelControl9.Text = "Chế độ";
      // 
      // lookUpEdit4
      // 
      this.lookUpEdit4.Location = new System.Drawing.Point(136, 322);
      this.lookUpEdit4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.lookUpEdit4.Name = "lookUpEdit4";
      this.lookUpEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lookUpEdit4.Properties.NullText = "";
      this.lookUpEdit4.Size = new System.Drawing.Size(153, 22);
      this.lookUpEdit4.TabIndex = 10;
      // 
      // labelControl8
      // 
      this.labelControl8.Location = new System.Drawing.Point(47, 326);
      this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.labelControl8.Name = "labelControl8";
      this.labelControl8.Size = new System.Drawing.Size(56, 16);
      this.labelControl8.TabIndex = 9;
      this.labelControl8.Text = "Nhân viên";
      // 
      // lookUpEdit3
      // 
      this.lookUpEdit3.Location = new System.Drawing.Point(136, 258);
      this.lookUpEdit3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.lookUpEdit3.Name = "lookUpEdit3";
      this.lookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lookUpEdit3.Properties.NullText = "";
      this.lookUpEdit3.Size = new System.Drawing.Size(153, 22);
      this.lookUpEdit3.TabIndex = 8;
      // 
      // labelControl7
      // 
      this.labelControl7.Location = new System.Drawing.Point(65, 262);
      this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.labelControl7.Name = "labelControl7";
      this.labelControl7.Size = new System.Drawing.Size(41, 16);
      this.labelControl7.TabIndex = 7;
      this.labelControl7.Text = "Biển số";
      // 
      // lookUpEdit2
      // 
      this.lookUpEdit2.Location = new System.Drawing.Point(136, 290);
      this.lookUpEdit2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.lookUpEdit2.Name = "lookUpEdit2";
      this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lookUpEdit2.Properties.NullText = "";
      this.lookUpEdit2.Size = new System.Drawing.Size(153, 22);
      this.lookUpEdit2.TabIndex = 6;
      // 
      // labelControl6
      // 
      this.labelControl6.Location = new System.Drawing.Point(53, 294);
      this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new System.Drawing.Size(52, 16);
      this.labelControl6.TabIndex = 5;
      this.labelControl6.Text = "Tên MAC";
      // 
      // lookUpEdit1
      // 
      this.lookUpEdit1.Location = new System.Drawing.Point(136, 130);
      this.lookUpEdit1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.lookUpEdit1.Name = "lookUpEdit1";
      this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lookUpEdit1.Properties.NullText = "";
      this.lookUpEdit1.Size = new System.Drawing.Size(153, 22);
      this.lookUpEdit1.TabIndex = 4;
      // 
      // labelControl5
      // 
      this.labelControl5.Location = new System.Drawing.Point(36, 134);
      this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new System.Drawing.Size(66, 16);
      this.labelControl5.TabIndex = 3;
      this.labelControl5.Text = "Khách hàng";
      // 
      // txtMaPT
      // 
      this.txtMaPT.Location = new System.Drawing.Point(136, 98);
      this.txtMaPT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtMaPT.Name = "txtMaPT";
      this.txtMaPT.Size = new System.Drawing.Size(153, 22);
      this.txtMaPT.TabIndex = 2;
      // 
      // labelControl3
      // 
      this.labelControl3.Location = new System.Drawing.Point(23, 102);
      this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(79, 16);
      this.labelControl3.TabIndex = 1;
      this.labelControl3.Text = "Mã phiếu trộn";
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.simpleButton2);
      this.groupBox5.Location = new System.Drawing.Point(7, 516);
      this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox5.Size = new System.Drawing.Size(304, 119);
      this.groupBox5.TabIndex = 4;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Xuất dữ liệu";
      this.groupBox5.Visible = false;
      // 
      // simpleButton2
      // 
      this.simpleButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.simpleButton2.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
      this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
      this.simpleButton2.Location = new System.Drawing.Point(84, 42);
      this.simpleButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.simpleButton2.Name = "simpleButton2";
      this.simpleButton2.Size = new System.Drawing.Size(115, 57);
      this.simpleButton2.TabIndex = 13;
      // 
      // groupControl2
      // 
      this.groupControl2.Controls.Add(this.groupBox5);
      this.groupControl2.Controls.Add(this.groupBox3);
      this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
      this.groupControl2.Location = new System.Drawing.Point(0, 189);
      this.groupControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupControl2.Name = "groupControl2";
      this.groupControl2.Size = new System.Drawing.Size(619, 642);
      this.groupControl2.TabIndex = 5;
      this.groupControl2.Text = "Tìm kiếm";
      // 
      // DataMixMngView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.groupControl2);
      this.Controls.Add(this.groupControl1);
      this.Controls.Add(this.groupBox4);
      this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.Name = "DataMixMngView";
      this.Size = new System.Drawing.Size(1575, 831);
      //this.Load += new System.EventHandler(this.DataMixMngView_Load_1);
      this.Load += new System.EventHandler(this.DataMixMngView_Load); // <-- Thêm dòng này
      this.groupBox4.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
      this.panelControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grcDataMix)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grvDataMix)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
      this.groupControl1.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit8.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit7.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit6.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.datToDate.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.datToDate.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.datFromDate.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.datFromDate.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit5.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit4.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtMaPT.Properties)).EndInit();
      this.groupBox5.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
      this.groupControl2.ResumeLayout(false);
      this.ResumeLayout(false);

    }
  }
}
