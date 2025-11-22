using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using NhuaNong.ClientSetting;
using NhuaNong.Data;
using NhuaNong.MasterData;
using NhuaNong.Utils;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace NhuaNong.Reports
{
  public partial class RptChiTietMeTron
  {
    private IContainer components;
    private PanelControl panelControl1;
    private GroupControl groupControl2;
    private GroupControl groupControl3;
    private GridControl gridControl1;
    private BandedGridView bandedGridView1;
    private BandedGridColumn bgcMaPhieuTron;
    private BandedGridColumn bgcSTTMe;
    private BandedGridColumn bgcNgayTron;
    private BandedGridColumn bgcGioTron;
    private BandedGridColumn bgcKhachHang;
    private BandedGridColumn bgcCongTruong;
    private BandedGridColumn bgcTenHangMuc;
    private BandedGridColumn bgcMAC;
    private BandedGridColumn bgcNguoiTron;
    private BandedGridColumn bgcBienSo;
    private BandedGridColumn bgcTaiXe;
    private BandedGridColumn bgcIsQueued;
    private RepositoryItemCheckEdit repositoryItemCheckEdit1;
    private BandedGridColumn bgcKLMe;
    private BandedGridColumn bgcCP_Agg1;
    private BandedGridColumn bgcAgg1;
    private BandedGridColumn bgcT_Agg1;
    private BandedGridColumn bgcSaiSoAgg1;
    private BandedGridColumn bgcPerSaiSoAgg1;
    private BandedGridColumn bgcCP_Agg2;
    private BandedGridColumn bgcAgg2;
    private BandedGridColumn bgcT_Agg2;
    private BandedGridColumn bgcSaiSoAgg2;
    private BandedGridColumn bgcPerSaiSoAgg2;
    private BandedGridColumn bgcCP_Agg3;
    private BandedGridColumn bgcAgg3;
    private BandedGridColumn bgcT_Agg3;
    private BandedGridColumn bgcSaiSoAgg3;
    private BandedGridColumn bgcPerSaiSoAgg3;
    private BandedGridColumn bgcCP_Agg4;
    private BandedGridColumn bgcAgg4;
    private BandedGridColumn bgcT_Agg4;
    private BandedGridColumn bgcSaiSoAgg4;
    private BandedGridColumn bgcPerSaiSoAgg4;
    private BandedGridColumn bgcCP_Agg5;
    private BandedGridColumn bgcAgg5;
    private BandedGridColumn bgcT_Agg5;
    private BandedGridColumn bgcSaiSoAgg5;
    private BandedGridColumn bgcPerSaiSoAgg5;
    private BandedGridColumn bgcCP_Agg6;
    private BandedGridColumn bgcAgg6;
    private BandedGridColumn bgcT_Agg6;
    private BandedGridColumn bgcSaiSoAgg6;
    private BandedGridColumn bgcPerSaiSoAgg6;
    private BandedGridColumn bgcCP_Ce1;
    private BandedGridColumn bgcCe1;
    private BandedGridColumn bgcT_Ce1;
    private BandedGridColumn bgcSaiSoCe1;
    private BandedGridColumn bgcPerSaiSoCe1;
    private BandedGridColumn bgcCP_Ce2;
    private BandedGridColumn bgcCe2;
    private BandedGridColumn bgcT_Ce2;
    private BandedGridColumn bgcSaiSoCe2;
    private BandedGridColumn bgcPerSaiSoCe2;
    private BandedGridColumn bgcCP_Ce3;
    private BandedGridColumn bgcCe3;
    private BandedGridColumn bgcT_Ce3;
    private BandedGridColumn bgcSaiSoCe3;
    private BandedGridColumn bgcPerSaiSoCe3;
    private BandedGridColumn bgcCP_Ce4;
    private BandedGridColumn bgcCe4;
    private BandedGridColumn bgcT_Ce4;
    private BandedGridColumn bgcSaiSoCe4;
    private BandedGridColumn bgcPerSaiSoCe4;
    private BandedGridColumn bgcCP_Ce5;
    private BandedGridColumn bgcCe5;
    private BandedGridColumn bgcT_Ce5;
    private BandedGridColumn bgcSaiSoCe5;
    private BandedGridColumn bgcPerSaiSoCe5;
    private BandedGridColumn bgcCP_Wa1;
    private BandedGridColumn bgcWa1;
    private BandedGridColumn bgcT_Wa1;
    private BandedGridColumn bgcSaiSoWa1;
    private BandedGridColumn bgcPerSaiSoWa1;
    private BandedGridColumn bgcCP_Wa2;
    private BandedGridColumn bgcWa2;
    private BandedGridColumn bgcT_Wa2;
    private BandedGridColumn bgcSaiSoWa2;
    private BandedGridColumn bgcPerSaiSoWa2;
    private BandedGridColumn bgcCP_Add1;
    private BandedGridColumn bgcAdd1;
    private BandedGridColumn bgcT_Add1;
    private BandedGridColumn bgcSaiSoAdd1;
    private BandedGridColumn bgcPerSaiSoAdd1;
    private BandedGridColumn bgcCP_Add2;
    private BandedGridColumn bgcAdd2;
    private BandedGridColumn bgcT_Add2;
    private BandedGridColumn bgcSaiSoAdd2;
    private BandedGridColumn bgcPerSaiSoAdd2;
    private BandedGridColumn bgcCP_Add3;
    private BandedGridColumn bgcAdd3;
    private BandedGridColumn bgcT_Add3;
    private BandedGridColumn bgcSaiSoAdd3;
    private BandedGridColumn bgcPerSaiSoAdd3;
    private BandedGridColumn bgcCP_Add4;
    private BandedGridColumn bgcAdd4;
    private BandedGridColumn bgcT_Add4;
    private BandedGridColumn bgcSaiSoAdd4;
    private BandedGridColumn bgcPerSaiSoAdd4;
    private BandedGridColumn bgcCP_Add5;
    private BandedGridColumn bgcAdd5;
    private BandedGridColumn bgcT_Add5;
    private BandedGridColumn bgcSaiSoAdd5;
    private BandedGridColumn bgcPerSaiSoAdd5;
    private BandedGridColumn bgcCP_Add6;
    private BandedGridColumn bgcAdd6;
    private BandedGridColumn bgcT_Add6;
    private BandedGridColumn bgcSaiSoAdd6;
    private BandedGridColumn bgcPerSaiSoAdd6;
    private TextEdit txtMaPhieuTron;
    private LookUpEdit lueCheDo;
    private LabelControl labelControl11;
    private LookUpEdit lueNhanVien;
    private LabelControl labelControl10;
    private LookUpEdit lueMAC;
    private LabelControl labelControl9;
    private LookUpEdit lueBienSo;
    private LabelControl labelControl7;
    private LookUpEdit lueHangMuc;
    private LabelControl labelControl6;
    private LookUpEdit lueKhachHang;
    private LabelControl labelControl5;
    private LookUpEdit lueCongTruong;
    private LabelControl labelControl4;
    private SimpleButton btnReset;
    private SimpleButton btnSearch;
    private LookUpEdit lueTaiXe;
    private LabelControl labelControl3;
    private LabelControl labelControl2;
    private DateEdit datToDate;
    private DateEdit datFromDate;
    private LabelControl labelControl1;
    private LabelControl lblFromDate;
    private GridBand gridBandMa;
    private GridBand gridBand4;
    private GridBand gridBand2;
    private GridBand gridBand11;
    private GridBand gridBand3;
    private GridBand gridBand5;
    private GridBand gridBand77;
    private GridBand gridBand6;
    private GridBand gridBand7;
    private GridBand gridBand17;
    private GridBand gridBand8;
    private GridBand gridBand53;
    private GridBand gridBand70;
    private GridBand Agg1;
    private GridBand gridBand12;
    private GridBand gridBand9;
    private GridBand gridBand14;
    private GridBand gridBand15;
    private GridBand gridBand16;
    private GridBand Agg2;
    private GridBand gridBand18;
    private GridBand gridBand19;
    private GridBand gridBand20;
    private GridBand gridBand21;
    private GridBand gridBand22;
    private GridBand Agg3;
    private GridBand gridBand24;
    private GridBand gridBand25;
    private GridBand gridBand26;
    private GridBand gridBand27;
    private GridBand gridBand28;
    private GridBand Agg4;
    private GridBand gridBand30;
    private GridBand gridBand31;
    private GridBand gridBand32;
    private GridBand gridBand33;
    private GridBand gridBand34;
    private GridBand Agg5;
    private GridBand gridBand36;
    private GridBand gridBand37;
    private GridBand gridBand38;
    private GridBand gridBand39;
    private GridBand gridBand40;
    private GridBand Agg6;
    private GridBand gridBand42;
    private GridBand gridBand43;
    private GridBand gridBand44;
    private GridBand gridBand45;
    private GridBand gridBand46;
    private GridBand Ce1;
    private GridBand gridBand48;
    private GridBand gridBand49;
    private GridBand gridBand50;
    private GridBand gridBand51;
    private GridBand gridBand52;
    private GridBand Ce2;
    private GridBand gridBand1;
    private GridBand gridBand10;
    private GridBand gridBand13;
    private GridBand gridBand23;
    private GridBand gridBand29;
    private GridBand Ce3;
    private GridBand gridBand41;
    private GridBand gridBand54;
    private GridBand gridBand55;
    private GridBand gridBand56;
    private GridBand gridBand57;
    private GridBand Ce4;
    private GridBand gridBand59;
    private GridBand gridBand60;
    private GridBand gridBand61;
    private GridBand gridBand62;
    private GridBand gridBand63;
    private GridBand Ce5;
    private GridBand gridBand65;
    private GridBand gridBand66;
    private GridBand gridBand67;
    private GridBand gridBand68;
    private GridBand gridBand69;
    private GridBand Wa1;
    private GridBand gridBand71;
    private GridBand gridBand72;
    private GridBand gridBand73;
    private GridBand gridBand35;
    private GridBand gridBand47;
    private GridBand Wa2;
    private GridBand gridBand58;
    private GridBand gridBand64;
    private GridBand gridBand74;
    private GridBand gridBand75;
    private GridBand gridBand76;
    private GridBand Add1;
    private GridBand gridBand78;
    private GridBand gridBand79;
    private GridBand gridBand80;
    private GridBand gridBand81;
    private GridBand gridBand82;
    private GridBand Add2;
    private GridBand gridBand84;
    private GridBand gridBand85;
    private GridBand gridBand86;
    private GridBand gridBand87;
    private GridBand gridBand88;
    private GridBand Add3;
    private GridBand gridBand90;
    private GridBand gridBand91;
    private GridBand gridBand92;
    private GridBand gridBand93;
    private GridBand gridBand94;
    private GridBand Add4;
    private GridBand gridBand96;
    private GridBand gridBand97;
    private GridBand gridBand98;
    private GridBand gridBand99;
    private GridBand gridBand100;
    private GridBand Add5;
    private GridBand gridBand102;
    private GridBand gridBand103;
    private GridBand gridBand104;
    private GridBand gridBand105;
    private GridBand gridBand106;
    private GridBand Add6;
    private GridBand gridBand108;
    private GridBand gridBand109;
    private GridBand gridBand110;
    private GridBand gridBand111;
    private GridBand gridBand112;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.panelControl1 = new PanelControl();
      this.groupControl3 = new GroupControl();
      this.gridControl1 = new GridControl();
      this.bandedGridView1 = new BandedGridView();
      this.gridBandMa = new GridBand();
      this.bgcMaPhieuTron = new BandedGridColumn();
      this.gridBand4 = new GridBand();
      this.bgcSTTMe = new BandedGridColumn();
      this.gridBand2 = new GridBand();
      this.bgcNgayTron = new BandedGridColumn();
      this.gridBand11 = new GridBand();
      this.bgcGioTron = new BandedGridColumn();
      this.gridBand3 = new GridBand();
      this.bgcKhachHang = new BandedGridColumn();
      this.gridBand5 = new GridBand();
      this.bgcCongTruong = new BandedGridColumn();
      this.gridBand77 = new GridBand();
      this.bgcTenHangMuc = new BandedGridColumn();
      this.gridBand6 = new GridBand();
      this.bgcMAC = new BandedGridColumn();
      this.gridBand7 = new GridBand();
      this.bgcNguoiTron = new BandedGridColumn();
      this.gridBand17 = new GridBand();
      this.bgcBienSo = new BandedGridColumn();
      this.gridBand8 = new GridBand();
      this.bgcTaiXe = new BandedGridColumn();
      this.gridBand53 = new GridBand();
      this.bgcIsQueued = new BandedGridColumn();
      this.repositoryItemCheckEdit1 = new RepositoryItemCheckEdit();
      this.gridBand70 = new GridBand();
      this.bgcKLMe = new BandedGridColumn();
      this.Agg1 = new GridBand();
      this.gridBand12 = new GridBand();
      this.bgcCP_Agg1 = new BandedGridColumn();
      this.gridBand9 = new GridBand();
      this.bgcAgg1 = new BandedGridColumn();
      this.gridBand14 = new GridBand();
      this.bgcT_Agg1 = new BandedGridColumn();
      this.gridBand15 = new GridBand();
      this.bgcSaiSoAgg1 = new BandedGridColumn();
      this.gridBand16 = new GridBand();
      this.bgcPerSaiSoAgg1 = new BandedGridColumn();
      this.Agg2 = new GridBand();
      this.gridBand18 = new GridBand();
      this.bgcCP_Agg2 = new BandedGridColumn();
      this.gridBand19 = new GridBand();
      this.bgcAgg2 = new BandedGridColumn();
      this.gridBand20 = new GridBand();
      this.bgcT_Agg2 = new BandedGridColumn();
      this.gridBand21 = new GridBand();
      this.bgcSaiSoAgg2 = new BandedGridColumn();
      this.gridBand22 = new GridBand();
      this.bgcPerSaiSoAgg2 = new BandedGridColumn();
      this.Agg3 = new GridBand();
      this.gridBand24 = new GridBand();
      this.bgcCP_Agg3 = new BandedGridColumn();
      this.gridBand25 = new GridBand();
      this.bgcAgg3 = new BandedGridColumn();
      this.gridBand26 = new GridBand();
      this.bgcT_Agg3 = new BandedGridColumn();
      this.gridBand27 = new GridBand();
      this.bgcSaiSoAgg3 = new BandedGridColumn();
      this.gridBand28 = new GridBand();
      this.bgcPerSaiSoAgg3 = new BandedGridColumn();
      this.Agg4 = new GridBand();
      this.gridBand30 = new GridBand();
      this.bgcCP_Agg4 = new BandedGridColumn();
      this.gridBand31 = new GridBand();
      this.bgcAgg4 = new BandedGridColumn();
      this.gridBand32 = new GridBand();
      this.bgcT_Agg4 = new BandedGridColumn();
      this.gridBand33 = new GridBand();
      this.bgcSaiSoAgg4 = new BandedGridColumn();
      this.gridBand34 = new GridBand();
      this.bgcPerSaiSoAgg4 = new BandedGridColumn();
      this.Agg5 = new GridBand();
      this.gridBand36 = new GridBand();
      this.bgcCP_Agg5 = new BandedGridColumn();
      this.gridBand37 = new GridBand();
      this.bgcAgg5 = new BandedGridColumn();
      this.gridBand38 = new GridBand();
      this.bgcT_Agg5 = new BandedGridColumn();
      this.gridBand39 = new GridBand();
      this.bgcSaiSoAgg5 = new BandedGridColumn();
      this.gridBand40 = new GridBand();
      this.bgcPerSaiSoAgg5 = new BandedGridColumn();
      this.Agg6 = new GridBand();
      this.gridBand42 = new GridBand();
      this.bgcCP_Agg6 = new BandedGridColumn();
      this.gridBand43 = new GridBand();
      this.bgcAgg6 = new BandedGridColumn();
      this.gridBand44 = new GridBand();
      this.bgcT_Agg6 = new BandedGridColumn();
      this.gridBand45 = new GridBand();
      this.bgcSaiSoAgg6 = new BandedGridColumn();
      this.gridBand46 = new GridBand();
      this.bgcPerSaiSoAgg6 = new BandedGridColumn();
      this.Ce1 = new GridBand();
      this.gridBand48 = new GridBand();
      this.bgcCP_Ce1 = new BandedGridColumn();
      this.gridBand49 = new GridBand();
      this.bgcCe1 = new BandedGridColumn();
      this.gridBand50 = new GridBand();
      this.bgcT_Ce1 = new BandedGridColumn();
      this.gridBand51 = new GridBand();
      this.bgcSaiSoCe1 = new BandedGridColumn();
      this.gridBand52 = new GridBand();
      this.bgcPerSaiSoCe1 = new BandedGridColumn();
      this.Ce2 = new GridBand();
      this.gridBand1 = new GridBand();
      this.bgcCP_Ce2 = new BandedGridColumn();
      this.gridBand10 = new GridBand();
      this.bgcCe2 = new BandedGridColumn();
      this.gridBand13 = new GridBand();
      this.bgcT_Ce2 = new BandedGridColumn();
      this.gridBand23 = new GridBand();
      this.bgcSaiSoCe2 = new BandedGridColumn();
      this.gridBand29 = new GridBand();
      this.bgcPerSaiSoCe2 = new BandedGridColumn();
      this.Ce3 = new GridBand();
      this.gridBand41 = new GridBand();
      this.bgcCP_Ce3 = new BandedGridColumn();
      this.gridBand54 = new GridBand();
      this.bgcCe3 = new BandedGridColumn();
      this.gridBand55 = new GridBand();
      this.bgcT_Ce3 = new BandedGridColumn();
      this.gridBand56 = new GridBand();
      this.bgcSaiSoCe3 = new BandedGridColumn();
      this.gridBand57 = new GridBand();
      this.bgcPerSaiSoCe3 = new BandedGridColumn();
      this.Ce4 = new GridBand();
      this.gridBand59 = new GridBand();
      this.bgcCP_Ce4 = new BandedGridColumn();
      this.gridBand60 = new GridBand();
      this.bgcCe4 = new BandedGridColumn();
      this.gridBand61 = new GridBand();
      this.bgcT_Ce4 = new BandedGridColumn();
      this.gridBand62 = new GridBand();
      this.bgcSaiSoCe4 = new BandedGridColumn();
      this.gridBand63 = new GridBand();
      this.bgcPerSaiSoCe4 = new BandedGridColumn();
      this.Ce5 = new GridBand();
      this.gridBand65 = new GridBand();
      this.bgcCP_Ce5 = new BandedGridColumn();
      this.gridBand66 = new GridBand();
      this.bgcCe5 = new BandedGridColumn();
      this.gridBand67 = new GridBand();
      this.bgcT_Ce5 = new BandedGridColumn();
      this.gridBand68 = new GridBand();
      this.bgcSaiSoCe5 = new BandedGridColumn();
      this.gridBand69 = new GridBand();
      this.bgcPerSaiSoCe5 = new BandedGridColumn();
      this.Wa1 = new GridBand();
      this.gridBand71 = new GridBand();
      this.bgcCP_Wa1 = new BandedGridColumn();
      this.gridBand72 = new GridBand();
      this.bgcWa1 = new BandedGridColumn();
      this.gridBand73 = new GridBand();
      this.bgcT_Wa1 = new BandedGridColumn();
      this.gridBand35 = new GridBand();
      this.bgcSaiSoWa1 = new BandedGridColumn();
      this.gridBand47 = new GridBand();
      this.bgcPerSaiSoWa1 = new BandedGridColumn();
      this.Wa2 = new GridBand();
      this.gridBand58 = new GridBand();
      this.bgcCP_Wa2 = new BandedGridColumn();
      this.gridBand64 = new GridBand();
      this.bgcWa2 = new BandedGridColumn();
      this.gridBand74 = new GridBand();
      this.bgcT_Wa2 = new BandedGridColumn();
      this.gridBand75 = new GridBand();
      this.bgcSaiSoWa2 = new BandedGridColumn();
      this.gridBand76 = new GridBand();
      this.bgcPerSaiSoWa2 = new BandedGridColumn();
      this.Add1 = new GridBand();
      this.gridBand78 = new GridBand();
      this.bgcCP_Add1 = new BandedGridColumn();
      this.gridBand79 = new GridBand();
      this.bgcAdd1 = new BandedGridColumn();
      this.gridBand80 = new GridBand();
      this.bgcT_Add1 = new BandedGridColumn();
      this.gridBand81 = new GridBand();
      this.bgcSaiSoAdd1 = new BandedGridColumn();
      this.gridBand82 = new GridBand();
      this.bgcPerSaiSoAdd1 = new BandedGridColumn();
      this.Add2 = new GridBand();
      this.gridBand84 = new GridBand();
      this.bgcCP_Add2 = new BandedGridColumn();
      this.gridBand85 = new GridBand();
      this.bgcAdd2 = new BandedGridColumn();
      this.gridBand86 = new GridBand();
      this.bgcT_Add2 = new BandedGridColumn();
      this.gridBand87 = new GridBand();
      this.bgcSaiSoAdd2 = new BandedGridColumn();
      this.gridBand88 = new GridBand();
      this.bgcPerSaiSoAdd2 = new BandedGridColumn();
      this.Add3 = new GridBand();
      this.gridBand90 = new GridBand();
      this.bgcCP_Add3 = new BandedGridColumn();
      this.gridBand91 = new GridBand();
      this.bgcAdd3 = new BandedGridColumn();
      this.gridBand92 = new GridBand();
      this.bgcT_Add3 = new BandedGridColumn();
      this.gridBand93 = new GridBand();
      this.bgcSaiSoAdd3 = new BandedGridColumn();
      this.gridBand94 = new GridBand();
      this.bgcPerSaiSoAdd3 = new BandedGridColumn();
      this.Add4 = new GridBand();
      this.gridBand96 = new GridBand();
      this.bgcCP_Add4 = new BandedGridColumn();
      this.gridBand97 = new GridBand();
      this.bgcAdd4 = new BandedGridColumn();
      this.gridBand98 = new GridBand();
      this.bgcT_Add4 = new BandedGridColumn();
      this.gridBand99 = new GridBand();
      this.bgcSaiSoAdd4 = new BandedGridColumn();
      this.gridBand100 = new GridBand();
      this.bgcPerSaiSoAdd4 = new BandedGridColumn();
      this.Add5 = new GridBand();
      this.gridBand102 = new GridBand();
      this.bgcCP_Add5 = new BandedGridColumn();
      this.gridBand103 = new GridBand();
      this.bgcAdd5 = new BandedGridColumn();
      this.gridBand104 = new GridBand();
      this.bgcT_Add5 = new BandedGridColumn();
      this.gridBand105 = new GridBand();
      this.bgcSaiSoAdd5 = new BandedGridColumn();
      this.gridBand106 = new GridBand();
      this.bgcPerSaiSoAdd5 = new BandedGridColumn();
      this.Add6 = new GridBand();
      this.gridBand108 = new GridBand();
      this.bgcCP_Add6 = new BandedGridColumn();
      this.gridBand109 = new GridBand();
      this.bgcAdd6 = new BandedGridColumn();
      this.gridBand110 = new GridBand();
      this.bgcT_Add6 = new BandedGridColumn();
      this.gridBand111 = new GridBand();
      this.bgcSaiSoAdd6 = new BandedGridColumn();
      this.gridBand112 = new GridBand();
      this.bgcPerSaiSoAdd6 = new BandedGridColumn();
      this.groupControl2 = new GroupControl();
      this.txtMaPhieuTron = new TextEdit();
      this.lueCheDo = new LookUpEdit();
      this.labelControl11 = new LabelControl();
      this.lueNhanVien = new LookUpEdit();
      this.labelControl10 = new LabelControl();
      this.lueMAC = new LookUpEdit();
      this.labelControl9 = new LabelControl();
      this.lueBienSo = new LookUpEdit();
      this.labelControl7 = new LabelControl();
      this.lueHangMuc = new LookUpEdit();
      this.labelControl6 = new LabelControl();
      this.lueKhachHang = new LookUpEdit();
      this.labelControl5 = new LabelControl();
      this.lueCongTruong = new LookUpEdit();
      this.labelControl4 = new LabelControl();
      this.btnReset = new SimpleButton();
      this.btnSearch = new SimpleButton();
      this.lueTaiXe = new LookUpEdit();
      this.labelControl3 = new LabelControl();
      this.labelControl2 = new LabelControl();
      this.datToDate = new DateEdit();
      this.datFromDate = new DateEdit();
      this.labelControl1 = new LabelControl();
      this.lblFromDate = new LabelControl();
      this.panelControl1.BeginInit();
      this.panelControl1.SuspendLayout();
      this.groupControl3.BeginInit();
      this.groupControl3.SuspendLayout();
      this.gridControl1.BeginInit();
      this.bandedGridView1.BeginInit();
      this.repositoryItemCheckEdit1.BeginInit();
      this.groupControl2.BeginInit();
      this.groupControl2.SuspendLayout();
      this.txtMaPhieuTron.Properties.BeginInit();
      this.lueCheDo.Properties.BeginInit();
      this.lueNhanVien.Properties.BeginInit();
      this.lueMAC.Properties.BeginInit();
      this.lueBienSo.Properties.BeginInit();
      this.lueHangMuc.Properties.BeginInit();
      this.lueKhachHang.Properties.BeginInit();
      this.lueCongTruong.Properties.BeginInit();
      this.lueTaiXe.Properties.BeginInit();
      this.datToDate.Properties.CalendarTimeProperties.BeginInit();
      this.datToDate.Properties.BeginInit();
      this.datFromDate.Properties.CalendarTimeProperties.BeginInit();
      this.datFromDate.Properties.BeginInit();
      this.SuspendLayout();
      this.panelControl1.Controls.Add((Control)this.groupControl3);
      this.panelControl1.Controls.Add((Control)this.groupControl2);
      this.panelControl1.Dock = DockStyle.Fill;
      this.panelControl1.Location = new Point(0, 0);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new Size(1387, 839);
      this.panelControl1.TabIndex = 1;
      this.groupControl3.Controls.Add((Control)this.gridControl1);
      this.groupControl3.Dock = DockStyle.Fill;
      this.groupControl3.Location = new Point(2, 2);
      this.groupControl3.Name = "groupControl3";
      this.groupControl3.Size = new Size(1103, 835);
      this.groupControl3.TabIndex = 2;
      this.groupControl3.Text = "Dữ liệu";
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.Location = new Point(2, 23);
      this.gridControl1.MainView = (BaseView)this.bandedGridView1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[1]
      {
        (RepositoryItem) this.repositoryItemCheckEdit1
      });
      this.gridControl1.Size = new Size(1099, 810);
      this.gridControl1.TabIndex = 1;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.bandedGridView1
      });
      this.bandedGridView1.Bands.AddRange(new GridBand[32]
      {
        this.gridBandMa,
        this.gridBand4,
        this.gridBand2,
        this.gridBand11,
        this.gridBand3,
        this.gridBand5,
        this.gridBand77,
        this.gridBand6,
        this.gridBand7,
        this.gridBand17,
        this.gridBand8,
        this.gridBand53,
        this.gridBand70,
        this.Agg1,
        this.Agg2,
        this.Agg3,
        this.Agg4,
        this.Agg5,
        this.Agg6,
        this.Ce1,
        this.Ce2,
        this.Ce3,
        this.Ce4,
        this.Ce5,
        this.Wa1,
        this.Wa2,
        this.Add1,
        this.Add2,
        this.Add3,
        this.Add4,
        this.Add5,
        this.Add6
      });
      this.bandedGridView1.Columns.AddRange(new BandedGridColumn[108]
      {
        this.bgcMaPhieuTron,
        this.bgcNgayTron,
        this.bgcGioTron,
        this.bgcSTTMe,
        this.bgcKhachHang,
        this.bgcCongTruong,
        this.bgcMAC,
        this.bgcNguoiTron,
        this.bgcTaiXe,
        this.bgcBienSo,
        this.bgcCP_Agg1,
        this.bgcCP_Agg2,
        this.bgcCP_Agg3,
        this.bgcCP_Agg4,
        this.bgcCP_Agg5,
        this.bgcCP_Agg6,
        this.bgcAgg1,
        this.bgcAgg2,
        this.bgcAgg3,
        this.bgcAgg4,
        this.bgcAgg5,
        this.bgcAgg6,
        this.bgcT_Agg1,
        this.bgcT_Agg2,
        this.bgcT_Agg3,
        this.bgcT_Agg4,
        this.bgcT_Agg5,
        this.bgcT_Agg6,
        this.bgcSaiSoAgg1,
        this.bgcSaiSoAgg2,
        this.bgcSaiSoAgg3,
        this.bgcSaiSoAgg4,
        this.bgcSaiSoAgg5,
        this.bgcSaiSoAgg6,
        this.bgcPerSaiSoAgg1,
        this.bgcPerSaiSoAgg2,
        this.bgcPerSaiSoAgg3,
        this.bgcPerSaiSoAgg4,
        this.bgcPerSaiSoAgg5,
        this.bgcPerSaiSoAgg6,
        this.bgcCP_Ce1,
        this.bgcCP_Ce2,
        this.bgcCP_Ce3,
        this.bgcCP_Ce4,
        this.bgcCP_Ce5,
        this.bgcCe1,
        this.bgcCe2,
        this.bgcCe3,
        this.bgcCe4,
        this.bgcCe5,
        this.bgcT_Ce1,
        this.bgcT_Ce2,
        this.bgcT_Ce3,
        this.bgcT_Ce4,
        this.bgcT_Ce5,
        this.bgcSaiSoCe1,
        this.bgcSaiSoCe2,
        this.bgcSaiSoCe3,
        this.bgcSaiSoCe4,
        this.bgcSaiSoCe5,
        this.bgcPerSaiSoCe1,
        this.bgcPerSaiSoCe2,
        this.bgcPerSaiSoCe3,
        this.bgcPerSaiSoCe4,
        this.bgcPerSaiSoCe5,
        this.bgcCP_Wa1,
        this.bgcCP_Wa2,
        this.bgcWa1,
        this.bgcWa2,
        this.bgcT_Wa1,
        this.bgcT_Wa2,
        this.bgcSaiSoWa1,
        this.bgcSaiSoWa2,
        this.bgcPerSaiSoWa1,
        this.bgcPerSaiSoWa2,
        this.bgcCP_Add1,
        this.bgcCP_Add2,
        this.bgcCP_Add3,
        this.bgcCP_Add4,
        this.bgcCP_Add5,
        this.bgcCP_Add6,
        this.bgcAdd1,
        this.bgcAdd2,
        this.bgcAdd3,
        this.bgcAdd4,
        this.bgcAdd5,
        this.bgcAdd6,
        this.bgcT_Add1,
        this.bgcT_Add2,
        this.bgcT_Add3,
        this.bgcT_Add4,
        this.bgcT_Add5,
        this.bgcT_Add6,
        this.bgcSaiSoAdd1,
        this.bgcSaiSoAdd2,
        this.bgcSaiSoAdd3,
        this.bgcSaiSoAdd4,
        this.bgcSaiSoAdd5,
        this.bgcSaiSoAdd6,
        this.bgcPerSaiSoAdd1,
        this.bgcPerSaiSoAdd2,
        this.bgcPerSaiSoAdd3,
        this.bgcPerSaiSoAdd4,
        this.bgcPerSaiSoAdd5,
        this.bgcPerSaiSoAdd6,
        this.bgcKLMe,
        this.bgcIsQueued,
        this.bgcTenHangMuc
      });
      this.bandedGridView1.GridControl = this.gridControl1;
      this.bandedGridView1.Name = "bandedGridView1";
      this.bandedGridView1.OptionsFilter.AllowAutoFilterConditionChange = DefaultBoolean.True;
      this.bandedGridView1.OptionsView.ShowColumnHeaders = false;
      this.bandedGridView1.OptionsView.ShowFooter = true;
      this.gridBandMa.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBandMa.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBandMa.Caption = "Mã phiếu trộn";
      this.gridBandMa.Columns.Add(this.bgcMaPhieuTron);
      this.gridBandMa.Name = "gridBandMa";
      this.gridBandMa.VisibleIndex = 0;
      this.gridBandMa.Width = 100;
      this.bgcMaPhieuTron.FieldName = "MaPhieuTron";
      this.bgcMaPhieuTron.MinWidth = 100;
      this.bgcMaPhieuTron.Name = "bgcMaPhieuTron";
      this.bgcMaPhieuTron.OptionsColumn.AllowFocus = false;
      this.bgcMaPhieuTron.OptionsColumn.ReadOnly = true;
      this.bgcMaPhieuTron.OptionsFilter.FilterBySortField = DefaultBoolean.True;
      this.bgcMaPhieuTron.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Count, "MaPhieuTron", "{0} - phiếu trộn")
      });
      this.bgcMaPhieuTron.Visible = true;
      this.bgcMaPhieuTron.Width = 100;
      this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand4.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand4.Caption = "STT Mẻ";
      this.gridBand4.Columns.Add(this.bgcSTTMe);
      this.gridBand4.Name = "gridBand4";
      this.gridBand4.VisibleIndex = 1;
      this.gridBand4.Width = 80;
      this.bgcSTTMe.FieldName = "LnNo";
      this.bgcSTTMe.MinWidth = 80;
      this.bgcSTTMe.Name = "bgcSTTMe";
      this.bgcSTTMe.OptionsColumn.AllowFocus = false;
      this.bgcSTTMe.OptionsColumn.ReadOnly = true;
      this.bgcSTTMe.OptionsColumn.ShowCaption = false;
      this.bgcSTTMe.Visible = true;
      this.bgcSTTMe.Width = 80;
      this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand2.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand2.Caption = "Ngày trộn";
      this.gridBand2.Columns.Add(this.bgcNgayTron);
      this.gridBand2.Name = "gridBand2";
      this.gridBand2.VisibleIndex = 2;
      this.gridBand2.Width = 100;
      this.bgcNgayTron.DisplayFormat.FormatString = "dd/MM/yyyy";
      this.bgcNgayTron.DisplayFormat.FormatType = FormatType.DateTime;
      this.bgcNgayTron.FieldName = "Ngay";
      this.bgcNgayTron.MinWidth = 100;
      this.bgcNgayTron.Name = "bgcNgayTron";
      this.bgcNgayTron.OptionsColumn.AllowFocus = false;
      this.bgcNgayTron.OptionsColumn.ReadOnly = true;
      this.bgcNgayTron.OptionsColumn.ShowCaption = false;
      this.bgcNgayTron.Visible = true;
      this.bgcNgayTron.Width = 100;
      this.gridBand11.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand11.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand11.Caption = "Giờ trộn";
      this.gridBand11.Columns.Add(this.bgcGioTron);
      this.gridBand11.Name = "gridBand11";
      this.gridBand11.VisibleIndex = 3;
      this.gridBand11.Width = 100;
      this.bgcGioTron.DisplayFormat.FormatString = "T";
      this.bgcGioTron.DisplayFormat.FormatType = FormatType.DateTime;
      this.bgcGioTron.FieldName = "Gio";
      this.bgcGioTron.MinWidth = 100;
      this.bgcGioTron.Name = "bgcGioTron";
      this.bgcGioTron.OptionsColumn.AllowFocus = false;
      this.bgcGioTron.OptionsColumn.ReadOnly = true;
      this.bgcGioTron.OptionsColumn.ShowCaption = false;
      this.bgcGioTron.Visible = true;
      this.bgcGioTron.Width = 100;
      this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand3.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand3.Caption = "Khách hàng";
      this.gridBand3.Columns.Add(this.bgcKhachHang);
      this.gridBand3.Name = "gridBand3";
      this.gridBand3.VisibleIndex = 4;
      this.gridBand3.Width = 200;
      this.bgcKhachHang.FieldName = "KH";
      this.bgcKhachHang.MinWidth = 200;
      this.bgcKhachHang.Name = "bgcKhachHang";
      this.bgcKhachHang.OptionsColumn.AllowFocus = false;
      this.bgcKhachHang.OptionsColumn.ReadOnly = true;
      this.bgcKhachHang.OptionsColumn.ShowCaption = false;
      this.bgcKhachHang.OptionsFilter.FilterBySortField = DefaultBoolean.True;
      this.bgcKhachHang.Visible = true;
      this.bgcKhachHang.Width = 200;
      this.gridBand5.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand5.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand5.Caption = "Công trường";
      this.gridBand5.Columns.Add(this.bgcCongTruong);
      this.gridBand5.Name = "gridBand5";
      this.gridBand5.VisibleIndex = 5;
      this.gridBand5.Width = 150;
      this.bgcCongTruong.FieldName = "CT";
      this.bgcCongTruong.MinWidth = 150;
      this.bgcCongTruong.Name = "bgcCongTruong";
      this.bgcCongTruong.OptionsColumn.AllowFocus = false;
      this.bgcCongTruong.OptionsColumn.ReadOnly = true;
      this.bgcCongTruong.OptionsColumn.ShowCaption = false;
      this.bgcCongTruong.Visible = true;
      this.bgcCongTruong.Width = 150;
      this.gridBand77.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand77.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand77.Caption = "Hạng mục";
      this.gridBand77.Columns.Add(this.bgcTenHangMuc);
      this.gridBand77.Name = "gridBand77";
      this.gridBand77.VisibleIndex = 6;
      this.gridBand77.Width = 150;
      this.bgcTenHangMuc.Caption = "Hạng mục";
      this.bgcTenHangMuc.FieldName = "HM";
      this.bgcTenHangMuc.MinWidth = 150;
      this.bgcTenHangMuc.Name = "bgcTenHangMuc";
      this.bgcTenHangMuc.OptionsColumn.AllowFocus = false;
      this.bgcTenHangMuc.OptionsColumn.ReadOnly = true;
      this.bgcTenHangMuc.Visible = true;
      this.bgcTenHangMuc.Width = 150;
      this.gridBand6.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand6.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand6.Caption = "Tên MAC";
      this.gridBand6.Columns.Add(this.bgcMAC);
      this.gridBand6.Name = "gridBand6";
      this.gridBand6.VisibleIndex = 7;
      this.gridBand6.Width = 150;
      this.bgcMAC.FieldName = "NoteMAC";
      this.bgcMAC.MinWidth = 150;
      this.bgcMAC.Name = "bgcMAC";
      this.bgcMAC.OptionsColumn.AllowFocus = false;
      this.bgcMAC.OptionsColumn.ReadOnly = true;
      this.bgcMAC.OptionsColumn.ShowCaption = false;
      this.bgcMAC.Visible = true;
      this.bgcMAC.Width = 150;
      this.gridBand7.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand7.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand7.Caption = "Người trộn";
      this.gridBand7.Columns.Add(this.bgcNguoiTron);
      this.gridBand7.Name = "gridBand7";
      this.gridBand7.VisibleIndex = 8;
      this.gridBand7.Width = 100;
      this.bgcNguoiTron.FieldName = "TenNV";
      this.bgcNguoiTron.MinWidth = 100;
      this.bgcNguoiTron.Name = "bgcNguoiTron";
      this.bgcNguoiTron.OptionsColumn.AllowFocus = false;
      this.bgcNguoiTron.OptionsColumn.ReadOnly = true;
      this.bgcNguoiTron.Visible = true;
      this.bgcNguoiTron.Width = 100;
      this.gridBand17.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand17.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand17.Caption = "Biển số";
      this.gridBand17.Columns.Add(this.bgcBienSo);
      this.gridBand17.Name = "gridBand17";
      this.gridBand17.VisibleIndex = 9;
      this.gridBand17.Width = 100;
      this.bgcBienSo.FieldName = "Plate";
      this.bgcBienSo.MinWidth = 100;
      this.bgcBienSo.Name = "bgcBienSo";
      this.bgcBienSo.OptionsColumn.AllowFocus = false;
      this.bgcBienSo.OptionsColumn.ReadOnly = true;
      this.bgcBienSo.OptionsColumn.ShowCaption = false;
      this.bgcBienSo.Visible = true;
      this.bgcBienSo.Width = 100;
      this.gridBand8.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand8.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand8.Caption = "Tài xế";
      this.gridBand8.Columns.Add(this.bgcTaiXe);
      this.gridBand8.Name = "gridBand8";
      this.gridBand8.VisibleIndex = 10;
      this.gridBand8.Width = 100;
      this.bgcTaiXe.FieldName = "Name";
      this.bgcTaiXe.MinWidth = 100;
      this.bgcTaiXe.Name = "bgcTaiXe";
      this.bgcTaiXe.OptionsColumn.AllowFocus = false;
      this.bgcTaiXe.OptionsColumn.ReadOnly = true;
      this.bgcTaiXe.OptionsColumn.ShowCaption = false;
      this.bgcTaiXe.Visible = true;
      this.bgcTaiXe.Width = 100;
      this.gridBand53.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand53.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand53.Caption = "Mô phỏng";
      this.gridBand53.Columns.Add(this.bgcIsQueued);
      this.gridBand53.Name = "gridBand53";
      this.gridBand53.VisibleIndex = 11;
      this.gridBand53.Width = 80;
      this.bgcIsQueued.Caption = "Is Queued";
      this.bgcIsQueued.ColumnEdit = (RepositoryItem)this.repositoryItemCheckEdit1;
      this.bgcIsQueued.FieldName = "IsQueued";
      this.bgcIsQueued.MinWidth = 80;
      this.bgcIsQueued.Name = "bgcIsQueued";
      this.bgcIsQueued.OptionsColumn.AllowFocus = false;
      this.bgcIsQueued.OptionsColumn.ReadOnly = true;
      this.bgcIsQueued.Visible = true;
      this.bgcIsQueued.Width = 80;
      this.repositoryItemCheckEdit1.AutoHeight = false;
      this.repositoryItemCheckEdit1.CheckBoxOptions.Style = CheckBoxStyle.Custom;
      this.repositoryItemCheckEdit1.CheckBoxOptions.SvgColorChecked = Color.Red;
      this.repositoryItemCheckEdit1.CheckBoxOptions.SvgColorUnchecked = Color.Green;
      this.repositoryItemCheckEdit1.ImageOptions.ImageChecked = (Image)ResourceNhua.simulation;
      this.repositoryItemCheckEdit1.ImageOptions.ImageGrayed = (Image)ResourceNhua.simulation;
      this.repositoryItemCheckEdit1.ImageOptions.ImageIndexChecked = 0;
      this.repositoryItemCheckEdit1.ImageOptions.ImageUnchecked = (Image)ResourceNhua.simulation;
      this.repositoryItemCheckEdit1.ImageOptions.SvgImageSize = new Size(10, 10);
      this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
      this.repositoryItemCheckEdit1.ReadOnly = true;
      this.gridBand70.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand70.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand70.Caption = "Thể tích";
      this.gridBand70.Columns.Add(this.bgcKLMe);
      this.gridBand70.Name = "gridBand70";
      this.gridBand70.VisibleIndex = 12;
      this.gridBand70.Width = 80;
      this.bgcKLMe.Caption = "KL Me";
      this.bgcKLMe.FieldName = "KLMe";
      this.bgcKLMe.MinWidth = 80;
      this.bgcKLMe.Name = "bgcKLMe";
      this.bgcKLMe.OptionsColumn.AllowFocus = false;
      this.bgcKLMe.OptionsColumn.ReadOnly = true;
      this.bgcKLMe.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "KLMe", "{0:0.##}")
      });
      this.bgcKLMe.Visible = true;
      this.bgcKLMe.Width = 80;
      this.Agg1.AppearanceHeader.Options.UseTextOptions = true;
      this.Agg1.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Agg1.Caption = "AGG _1";
      this.Agg1.Children.AddRange(new GridBand[5]
      {
        this.gridBand12,
        this.gridBand9,
        this.gridBand14,
        this.gridBand15,
        this.gridBand16
      });
      this.Agg1.Name = "Agg1";
      this.Agg1.VisibleIndex = 13;
      this.Agg1.Width = 400;
      this.gridBand12.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand12.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand12.Caption = "Cấp phối";
      this.gridBand12.Columns.Add(this.bgcCP_Agg1);
      this.gridBand12.Name = "gridBand12";
      this.gridBand12.VisibleIndex = 0;
      this.gridBand12.Width = 80;
      this.bgcCP_Agg1.Caption = "CP_Agg1";
      this.bgcCP_Agg1.FieldName = "Agg1";
      this.bgcCP_Agg1.MinWidth = 80;
      this.bgcCP_Agg1.Name = "bgcCP_Agg1";
      this.bgcCP_Agg1.OptionsColumn.AllowFocus = false;
      this.bgcCP_Agg1.OptionsColumn.ReadOnly = true;
      this.bgcCP_Agg1.OptionsColumn.ShowCaption = false;
      this.bgcCP_Agg1.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg1", "{0:0.##}")
      });
      this.bgcCP_Agg1.Visible = true;
      this.bgcCP_Agg1.Width = 80;
      this.gridBand9.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand9.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand9.Caption = "Thực cân";
      this.gridBand9.Columns.Add(this.bgcAgg1);
      this.gridBand9.Name = "gridBand9";
      this.gridBand9.VisibleIndex = 1;
      this.gridBand9.Width = 80;
      this.bgcAgg1.Caption = "Agg 1";
      this.bgcAgg1.FieldName = "Agg1_Bat";
      this.bgcAgg1.MinWidth = 80;
      this.bgcAgg1.Name = "bgcAgg1";
      this.bgcAgg1.OptionsColumn.AllowFocus = false;
      this.bgcAgg1.OptionsColumn.ReadOnly = true;
      this.bgcAgg1.OptionsColumn.ShowCaption = false;
      this.bgcAgg1.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg1_Bat", "{0:0.##}")
      });
      this.bgcAgg1.Visible = true;
      this.bgcAgg1.Width = 80;
      this.gridBand14.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand14.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand14.Caption = "Thực cân tay";
      this.gridBand14.Columns.Add(this.bgcT_Agg1);
      this.gridBand14.Name = "gridBand14";
      this.gridBand14.VisibleIndex = 2;
      this.gridBand14.Width = 80;
      this.bgcT_Agg1.Caption = "T_Agg1";
      this.bgcT_Agg1.FieldName = "Agg1_Man";
      this.bgcT_Agg1.MinWidth = 80;
      this.bgcT_Agg1.Name = "bgcT_Agg1";
      this.bgcT_Agg1.OptionsColumn.AllowFocus = false;
      this.bgcT_Agg1.OptionsColumn.ReadOnly = true;
      this.bgcT_Agg1.OptionsColumn.ShowCaption = false;
      this.bgcT_Agg1.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg1_Man", "{0:0.##}")
      });
      this.bgcT_Agg1.Visible = true;
      this.bgcT_Agg1.Width = 80;
      this.gridBand15.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand15.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand15.Caption = "Sai số";
      this.gridBand15.Columns.Add(this.bgcSaiSoAgg1);
      this.gridBand15.Name = "gridBand15";
      this.gridBand15.VisibleIndex = 3;
      this.gridBand15.Width = 80;
      this.bgcSaiSoAgg1.Caption = "Sai So Agg1";
      this.bgcSaiSoAgg1.FieldName = "Agg1_Tol";
      this.bgcSaiSoAgg1.MinWidth = 80;
      this.bgcSaiSoAgg1.Name = "bgcSaiSoAgg1";
      this.bgcSaiSoAgg1.OptionsColumn.AllowFocus = false;
      this.bgcSaiSoAgg1.OptionsColumn.ReadOnly = true;
      this.bgcSaiSoAgg1.OptionsColumn.ShowCaption = false;
      this.bgcSaiSoAgg1.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg1_Tol", "{0:0.##}")
      });
      this.bgcSaiSoAgg1.Visible = true;
      this.bgcSaiSoAgg1.Width = 80;
      this.gridBand16.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand16.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand16.Caption = "% Sai số";
      this.gridBand16.Columns.Add(this.bgcPerSaiSoAgg1);
      this.gridBand16.Name = "gridBand16";
      this.gridBand16.VisibleIndex = 4;
      this.gridBand16.Width = 80;
      this.bgcPerSaiSoAgg1.Caption = "PerSaiSoAgg1";
      this.bgcPerSaiSoAgg1.FieldName = "Agg1_PerTol";
      this.bgcPerSaiSoAgg1.MinWidth = 80;
      this.bgcPerSaiSoAgg1.Name = "bgcPerSaiSoAgg1";
      this.bgcPerSaiSoAgg1.OptionsColumn.AllowFocus = false;
      this.bgcPerSaiSoAgg1.OptionsColumn.ReadOnly = true;
      this.bgcPerSaiSoAgg1.OptionsColumn.ShowCaption = false;
      this.bgcPerSaiSoAgg1.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg1_PerTol", "{0:0.##}")
      });
      this.bgcPerSaiSoAgg1.Visible = true;
      this.bgcPerSaiSoAgg1.Width = 80;
      this.Agg2.AppearanceHeader.Options.UseTextOptions = true;
      this.Agg2.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Agg2.Caption = "AGG_2";
      this.Agg2.Children.AddRange(new GridBand[5]
      {
        this.gridBand18,
        this.gridBand19,
        this.gridBand20,
        this.gridBand21,
        this.gridBand22
      });
      this.Agg2.Name = "Agg2";
      this.Agg2.VisibleIndex = 14;
      this.Agg2.Width = 400;
      this.gridBand18.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand18.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand18.Caption = "Cấp phối";
      this.gridBand18.Columns.Add(this.bgcCP_Agg2);
      this.gridBand18.Name = "gridBand18";
      this.gridBand18.VisibleIndex = 0;
      this.gridBand18.Width = 80;
      this.bgcCP_Agg2.Caption = "CP_Agg2";
      this.bgcCP_Agg2.FieldName = "Agg2";
      this.bgcCP_Agg2.MinWidth = 80;
      this.bgcCP_Agg2.Name = "bgcCP_Agg2";
      this.bgcCP_Agg2.OptionsColumn.AllowFocus = false;
      this.bgcCP_Agg2.OptionsColumn.ReadOnly = true;
      this.bgcCP_Agg2.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg2", "{0:0.##}")
      });
      this.bgcCP_Agg2.Visible = true;
      this.bgcCP_Agg2.Width = 80;
      this.gridBand19.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand19.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand19.Caption = "Thực cân";
      this.gridBand19.Columns.Add(this.bgcAgg2);
      this.gridBand19.Name = "gridBand19";
      this.gridBand19.VisibleIndex = 1;
      this.gridBand19.Width = 80;
      this.bgcAgg2.Caption = "Agg 2";
      this.bgcAgg2.FieldName = "Agg2_Bat";
      this.bgcAgg2.MinWidth = 80;
      this.bgcAgg2.Name = "bgcAgg2";
      this.bgcAgg2.OptionsColumn.AllowFocus = false;
      this.bgcAgg2.OptionsColumn.ReadOnly = true;
      this.bgcAgg2.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg2_Bat", "{0:0.##}")
      });
      this.bgcAgg2.Visible = true;
      this.bgcAgg2.Width = 80;
      this.gridBand20.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand20.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand20.Caption = "Thực cân tay";
      this.gridBand20.Columns.Add(this.bgcT_Agg2);
      this.gridBand20.Name = "gridBand20";
      this.gridBand20.VisibleIndex = 2;
      this.gridBand20.Width = 80;
      this.bgcT_Agg2.Caption = "T_Agg2";
      this.bgcT_Agg2.FieldName = "Agg2_Man";
      this.bgcT_Agg2.MinWidth = 80;
      this.bgcT_Agg2.Name = "bgcT_Agg2";
      this.bgcT_Agg2.OptionsColumn.AllowFocus = false;
      this.bgcT_Agg2.OptionsColumn.ReadOnly = true;
      this.bgcT_Agg2.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg2_Man", "{0:0.##}")
      });
      this.bgcT_Agg2.Visible = true;
      this.bgcT_Agg2.Width = 80;
      this.gridBand21.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand21.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand21.Caption = "Sai số";
      this.gridBand21.Columns.Add(this.bgcSaiSoAgg2);
      this.gridBand21.Name = "gridBand21";
      this.gridBand21.VisibleIndex = 3;
      this.gridBand21.Width = 80;
      this.bgcSaiSoAgg2.Caption = "Sai So Agg2";
      this.bgcSaiSoAgg2.FieldName = "Agg2_Tol";
      this.bgcSaiSoAgg2.MinWidth = 80;
      this.bgcSaiSoAgg2.Name = "bgcSaiSoAgg2";
      this.bgcSaiSoAgg2.OptionsColumn.AllowFocus = false;
      this.bgcSaiSoAgg2.OptionsColumn.ReadOnly = true;
      this.bgcSaiSoAgg2.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg2_Tol", "{0:0.##}")
      });
      this.bgcSaiSoAgg2.Visible = true;
      this.bgcSaiSoAgg2.Width = 80;
      this.gridBand22.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand22.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand22.Caption = "% Sai số";
      this.gridBand22.Columns.Add(this.bgcPerSaiSoAgg2);
      this.gridBand22.Name = "gridBand22";
      this.gridBand22.VisibleIndex = 4;
      this.gridBand22.Width = 80;
      this.bgcPerSaiSoAgg2.Caption = "PerSaiSoAgg2";
      this.bgcPerSaiSoAgg2.FieldName = "Agg2_PerTol";
      this.bgcPerSaiSoAgg2.MinWidth = 80;
      this.bgcPerSaiSoAgg2.Name = "bgcPerSaiSoAgg2";
      this.bgcPerSaiSoAgg2.OptionsColumn.AllowFocus = false;
      this.bgcPerSaiSoAgg2.OptionsColumn.ReadOnly = true;
      this.bgcPerSaiSoAgg2.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg2_PerTol", "{0:0.##}")
      });
      this.bgcPerSaiSoAgg2.Visible = true;
      this.bgcPerSaiSoAgg2.Width = 80;
      this.Agg3.AppearanceHeader.Options.UseTextOptions = true;
      this.Agg3.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Agg3.Caption = "AGG_3";
      this.Agg3.Children.AddRange(new GridBand[5]
      {
        this.gridBand24,
        this.gridBand25,
        this.gridBand26,
        this.gridBand27,
        this.gridBand28
      });
      this.Agg3.Name = "Agg3";
      this.Agg3.VisibleIndex = 15;
      this.Agg3.Width = 400;
      this.gridBand24.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand24.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand24.Caption = "Cấp phối";
      this.gridBand24.Columns.Add(this.bgcCP_Agg3);
      this.gridBand24.Name = "gridBand24";
      this.gridBand24.VisibleIndex = 0;
      this.gridBand24.Width = 80;
      this.bgcCP_Agg3.Caption = "CP_Agg3";
      this.bgcCP_Agg3.FieldName = "Agg3";
      this.bgcCP_Agg3.MinWidth = 80;
      this.bgcCP_Agg3.Name = "bgcCP_Agg3";
      this.bgcCP_Agg3.OptionsColumn.AllowFocus = false;
      this.bgcCP_Agg3.OptionsColumn.ReadOnly = true;
      this.bgcCP_Agg3.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg3", "{0:0.##}")
      });
      this.bgcCP_Agg3.Visible = true;
      this.bgcCP_Agg3.Width = 80;
      this.gridBand25.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand25.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand25.Caption = "Thực cân";
      this.gridBand25.Columns.Add(this.bgcAgg3);
      this.gridBand25.Name = "gridBand25";
      this.gridBand25.VisibleIndex = 1;
      this.gridBand25.Width = 80;
      this.bgcAgg3.Caption = "Agg 3";
      this.bgcAgg3.FieldName = "Agg3_Bat";
      this.bgcAgg3.MinWidth = 80;
      this.bgcAgg3.Name = "bgcAgg3";
      this.bgcAgg3.OptionsColumn.AllowFocus = false;
      this.bgcAgg3.OptionsColumn.ReadOnly = true;
      this.bgcAgg3.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg3_Bat", "{0:0.##}")
      });
      this.bgcAgg3.Visible = true;
      this.bgcAgg3.Width = 80;
      this.gridBand26.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand26.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand26.Caption = "Thực cân tay";
      this.gridBand26.Columns.Add(this.bgcT_Agg3);
      this.gridBand26.Name = "gridBand26";
      this.gridBand26.VisibleIndex = 2;
      this.gridBand26.Width = 80;
      this.bgcT_Agg3.Caption = "T_Agg3";
      this.bgcT_Agg3.FieldName = "Agg3_Man";
      this.bgcT_Agg3.MinWidth = 80;
      this.bgcT_Agg3.Name = "bgcT_Agg3";
      this.bgcT_Agg3.OptionsColumn.AllowFocus = false;
      this.bgcT_Agg3.OptionsColumn.ReadOnly = true;
      this.bgcT_Agg3.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg3_Man", "{0:0.##}")
      });
      this.bgcT_Agg3.Visible = true;
      this.bgcT_Agg3.Width = 80;
      this.gridBand27.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand27.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand27.Caption = "Sai số";
      this.gridBand27.Columns.Add(this.bgcSaiSoAgg3);
      this.gridBand27.Name = "gridBand27";
      this.gridBand27.VisibleIndex = 3;
      this.gridBand27.Width = 80;
      this.bgcSaiSoAgg3.Caption = "Sai So Agg3";
      this.bgcSaiSoAgg3.FieldName = "Agg3_Tol";
      this.bgcSaiSoAgg3.MinWidth = 80;
      this.bgcSaiSoAgg3.Name = "bgcSaiSoAgg3";
      this.bgcSaiSoAgg3.OptionsColumn.AllowFocus = false;
      this.bgcSaiSoAgg3.OptionsColumn.ReadOnly = true;
      this.bgcSaiSoAgg3.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg3_Tol", "{0:0.##}")
      });
      this.bgcSaiSoAgg3.Visible = true;
      this.bgcSaiSoAgg3.Width = 80;
      this.gridBand28.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand28.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand28.Caption = "% Sai số";
      this.gridBand28.Columns.Add(this.bgcPerSaiSoAgg3);
      this.gridBand28.Name = "gridBand28";
      this.gridBand28.VisibleIndex = 4;
      this.gridBand28.Width = 80;
      this.bgcPerSaiSoAgg3.Caption = "PerSaiSoAgg3";
      this.bgcPerSaiSoAgg3.FieldName = "Agg3_PerTol";
      this.bgcPerSaiSoAgg3.MinWidth = 80;
      this.bgcPerSaiSoAgg3.Name = "bgcPerSaiSoAgg3";
      this.bgcPerSaiSoAgg3.OptionsColumn.AllowFocus = false;
      this.bgcPerSaiSoAgg3.OptionsColumn.ReadOnly = true;
      this.bgcPerSaiSoAgg3.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg3_PerTol", "{0:0.##}")
      });
      this.bgcPerSaiSoAgg3.Visible = true;
      this.bgcPerSaiSoAgg3.Width = 80;
      this.Agg4.AppearanceHeader.Options.UseTextOptions = true;
      this.Agg4.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Agg4.Caption = "AGG_4";
      this.Agg4.Children.AddRange(new GridBand[5]
      {
        this.gridBand30,
        this.gridBand31,
        this.gridBand32,
        this.gridBand33,
        this.gridBand34
      });
      this.Agg4.Name = "Agg4";
      this.Agg4.VisibleIndex = 16;
      this.Agg4.Width = 400;
      this.gridBand30.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand30.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand30.Caption = "Cấp phối";
      this.gridBand30.Columns.Add(this.bgcCP_Agg4);
      this.gridBand30.Name = "gridBand30";
      this.gridBand30.VisibleIndex = 0;
      this.gridBand30.Width = 80;
      this.bgcCP_Agg4.Caption = "CP_Agg4";
      this.bgcCP_Agg4.FieldName = "Agg4";
      this.bgcCP_Agg4.MinWidth = 80;
      this.bgcCP_Agg4.Name = "bgcCP_Agg4";
      this.bgcCP_Agg4.OptionsColumn.AllowFocus = false;
      this.bgcCP_Agg4.OptionsColumn.ReadOnly = true;
      this.bgcCP_Agg4.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg4", "{0:0.##}")
      });
      this.bgcCP_Agg4.Visible = true;
      this.bgcCP_Agg4.Width = 80;
      this.gridBand31.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand31.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand31.Caption = "Thực cân";
      this.gridBand31.Columns.Add(this.bgcAgg4);
      this.gridBand31.Name = "gridBand31";
      this.gridBand31.VisibleIndex = 1;
      this.gridBand31.Width = 80;
      this.bgcAgg4.Caption = "Agg 4";
      this.bgcAgg4.FieldName = "Agg4_Bat";
      this.bgcAgg4.MinWidth = 80;
      this.bgcAgg4.Name = "bgcAgg4";
      this.bgcAgg4.OptionsColumn.AllowFocus = false;
      this.bgcAgg4.OptionsColumn.ReadOnly = true;
      this.bgcAgg4.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg4_Bat", "{0:0.##}")
      });
      this.bgcAgg4.Visible = true;
      this.bgcAgg4.Width = 80;
      this.gridBand32.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand32.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand32.Caption = "Thực cân tay";
      this.gridBand32.Columns.Add(this.bgcT_Agg4);
      this.gridBand32.Name = "gridBand32";
      this.gridBand32.VisibleIndex = 2;
      this.gridBand32.Width = 80;
      this.bgcT_Agg4.Caption = "T_Agg4";
      this.bgcT_Agg4.FieldName = "Agg4_Man";
      this.bgcT_Agg4.MinWidth = 80;
      this.bgcT_Agg4.Name = "bgcT_Agg4";
      this.bgcT_Agg4.OptionsColumn.AllowFocus = false;
      this.bgcT_Agg4.OptionsColumn.ReadOnly = true;
      this.bgcT_Agg4.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg4_Man", "{0:0.##}")
      });
      this.bgcT_Agg4.Visible = true;
      this.bgcT_Agg4.Width = 80;
      this.gridBand33.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand33.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand33.Caption = "Sai số";
      this.gridBand33.Columns.Add(this.bgcSaiSoAgg4);
      this.gridBand33.Name = "gridBand33";
      this.gridBand33.VisibleIndex = 3;
      this.gridBand33.Width = 80;
      this.bgcSaiSoAgg4.Caption = "Sai So Agg4";
      this.bgcSaiSoAgg4.FieldName = "Agg4_Tol";
      this.bgcSaiSoAgg4.MinWidth = 80;
      this.bgcSaiSoAgg4.Name = "bgcSaiSoAgg4";
      this.bgcSaiSoAgg4.OptionsColumn.AllowFocus = false;
      this.bgcSaiSoAgg4.OptionsColumn.ReadOnly = true;
      this.bgcSaiSoAgg4.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg4_Tol", "{0:0.##}")
      });
      this.bgcSaiSoAgg4.Visible = true;
      this.bgcSaiSoAgg4.Width = 80;
      this.gridBand34.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand34.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand34.Caption = "% Sai số";
      this.gridBand34.Columns.Add(this.bgcPerSaiSoAgg4);
      this.gridBand34.Name = "gridBand34";
      this.gridBand34.VisibleIndex = 4;
      this.gridBand34.Width = 80;
      this.bgcPerSaiSoAgg4.Caption = "PerSaiSoAgg4";
      this.bgcPerSaiSoAgg4.FieldName = "Agg4_PerTol";
      this.bgcPerSaiSoAgg4.MinWidth = 80;
      this.bgcPerSaiSoAgg4.Name = "bgcPerSaiSoAgg4";
      this.bgcPerSaiSoAgg4.OptionsColumn.AllowFocus = false;
      this.bgcPerSaiSoAgg4.OptionsColumn.ReadOnly = true;
      this.bgcPerSaiSoAgg4.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg4_PerTol", "{0:0.##}")
      });
      this.bgcPerSaiSoAgg4.Visible = true;
      this.bgcPerSaiSoAgg4.Width = 80;
      this.Agg5.AppearanceHeader.Options.UseTextOptions = true;
      this.Agg5.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Agg5.Caption = "AGG_5";
      this.Agg5.Children.AddRange(new GridBand[5]
      {
        this.gridBand36,
        this.gridBand37,
        this.gridBand38,
        this.gridBand39,
        this.gridBand40
      });
      this.Agg5.Name = "Agg5";
      this.Agg5.VisibleIndex = 17;
      this.Agg5.Width = 400;
      this.gridBand36.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand36.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand36.Caption = "Cấp phối";
      this.gridBand36.Columns.Add(this.bgcCP_Agg5);
      this.gridBand36.Name = "gridBand36";
      this.gridBand36.VisibleIndex = 0;
      this.gridBand36.Width = 80;
      this.bgcCP_Agg5.Caption = "CP_Agg5";
      this.bgcCP_Agg5.FieldName = "Agg5";
      this.bgcCP_Agg5.MinWidth = 80;
      this.bgcCP_Agg5.Name = "bgcCP_Agg5";
      this.bgcCP_Agg5.OptionsColumn.AllowFocus = false;
      this.bgcCP_Agg5.OptionsColumn.ReadOnly = true;
      this.bgcCP_Agg5.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg5", "{0:0.##}")
      });
      this.bgcCP_Agg5.Visible = true;
      this.bgcCP_Agg5.Width = 80;
      this.gridBand37.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand37.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand37.Caption = "Thực cân";
      this.gridBand37.Columns.Add(this.bgcAgg5);
      this.gridBand37.Name = "gridBand37";
      this.gridBand37.VisibleIndex = 1;
      this.gridBand37.Width = 80;
      this.bgcAgg5.Caption = "Agg 5";
      this.bgcAgg5.FieldName = "Agg5_Bat";
      this.bgcAgg5.MinWidth = 80;
      this.bgcAgg5.Name = "bgcAgg5";
      this.bgcAgg5.OptionsColumn.AllowFocus = false;
      this.bgcAgg5.OptionsColumn.ReadOnly = true;
      this.bgcAgg5.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg5_Bat", "{0:0.##}")
      });
      this.bgcAgg5.Visible = true;
      this.bgcAgg5.Width = 80;
      this.gridBand38.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand38.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand38.Caption = "Thực cân tay";
      this.gridBand38.Columns.Add(this.bgcT_Agg5);
      this.gridBand38.Name = "gridBand38";
      this.gridBand38.VisibleIndex = 2;
      this.gridBand38.Width = 80;
      this.bgcT_Agg5.Caption = "T_Agg5";
      this.bgcT_Agg5.FieldName = "Agg5_Man";
      this.bgcT_Agg5.MinWidth = 80;
      this.bgcT_Agg5.Name = "bgcT_Agg5";
      this.bgcT_Agg5.OptionsColumn.AllowFocus = false;
      this.bgcT_Agg5.OptionsColumn.ReadOnly = true;
      this.bgcT_Agg5.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg5_Man", "{0:0.##}")
      });
      this.bgcT_Agg5.Visible = true;
      this.bgcT_Agg5.Width = 80;
      this.gridBand39.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand39.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand39.Caption = "Sai số";
      this.gridBand39.Columns.Add(this.bgcSaiSoAgg5);
      this.gridBand39.Name = "gridBand39";
      this.gridBand39.VisibleIndex = 3;
      this.gridBand39.Width = 80;
      this.bgcSaiSoAgg5.Caption = "Sai So Agg5";
      this.bgcSaiSoAgg5.FieldName = "Agg5_Tol";
      this.bgcSaiSoAgg5.MinWidth = 80;
      this.bgcSaiSoAgg5.Name = "bgcSaiSoAgg5";
      this.bgcSaiSoAgg5.OptionsColumn.AllowFocus = false;
      this.bgcSaiSoAgg5.OptionsColumn.ReadOnly = true;
      this.bgcSaiSoAgg5.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg5_Tol", "{0:0.##}")
      });
      this.bgcSaiSoAgg5.Visible = true;
      this.bgcSaiSoAgg5.Width = 80;
      this.gridBand40.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand40.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand40.Caption = "% Sai số";
      this.gridBand40.Columns.Add(this.bgcPerSaiSoAgg5);
      this.gridBand40.Name = "gridBand40";
      this.gridBand40.VisibleIndex = 4;
      this.gridBand40.Width = 80;
      this.bgcPerSaiSoAgg5.Caption = "PerSaiSoAgg5";
      this.bgcPerSaiSoAgg5.FieldName = "Agg5_PerTol";
      this.bgcPerSaiSoAgg5.MinWidth = 80;
      this.bgcPerSaiSoAgg5.Name = "bgcPerSaiSoAgg5";
      this.bgcPerSaiSoAgg5.OptionsColumn.AllowFocus = false;
      this.bgcPerSaiSoAgg5.OptionsColumn.ReadOnly = true;
      this.bgcPerSaiSoAgg5.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg5_PerTol", "{0:0.##}")
      });
      this.bgcPerSaiSoAgg5.Visible = true;
      this.bgcPerSaiSoAgg5.Width = 80;
      this.Agg6.AppearanceHeader.Options.UseTextOptions = true;
      this.Agg6.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Agg6.Caption = "AGG_6";
      this.Agg6.Children.AddRange(new GridBand[5]
      {
        this.gridBand42,
        this.gridBand43,
        this.gridBand44,
        this.gridBand45,
        this.gridBand46
      });
      this.Agg6.Name = "Agg6";
      this.Agg6.VisibleIndex = 18;
      this.Agg6.Width = 400;
      this.gridBand42.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand42.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand42.Caption = "Cấp phối";
      this.gridBand42.Columns.Add(this.bgcCP_Agg6);
      this.gridBand42.Name = "gridBand42";
      this.gridBand42.VisibleIndex = 0;
      this.gridBand42.Width = 80;
      this.bgcCP_Agg6.Caption = "CP_Agg6";
      this.bgcCP_Agg6.FieldName = "Agg6";
      this.bgcCP_Agg6.MinWidth = 80;
      this.bgcCP_Agg6.Name = "bgcCP_Agg6";
      this.bgcCP_Agg6.OptionsColumn.AllowFocus = false;
      this.bgcCP_Agg6.OptionsColumn.ReadOnly = true;
      this.bgcCP_Agg6.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg6", "{0:0.##}")
      });
      this.bgcCP_Agg6.Visible = true;
      this.bgcCP_Agg6.Width = 80;
      this.gridBand43.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand43.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand43.Caption = "Thực cân";
      this.gridBand43.Columns.Add(this.bgcAgg6);
      this.gridBand43.Name = "gridBand43";
      this.gridBand43.VisibleIndex = 1;
      this.gridBand43.Width = 80;
      this.bgcAgg6.Caption = "Agg 6";
      this.bgcAgg6.FieldName = "Agg6_Bat";
      this.bgcAgg6.MinWidth = 80;
      this.bgcAgg6.Name = "bgcAgg6";
      this.bgcAgg6.OptionsColumn.AllowFocus = false;
      this.bgcAgg6.OptionsColumn.ReadOnly = true;
      this.bgcAgg6.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg6_Bat", "{0:0.##}")
      });
      this.bgcAgg6.Visible = true;
      this.bgcAgg6.Width = 80;
      this.gridBand44.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand44.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand44.Caption = "Thực cân tay";
      this.gridBand44.Columns.Add(this.bgcT_Agg6);
      this.gridBand44.Name = "gridBand44";
      this.gridBand44.VisibleIndex = 2;
      this.gridBand44.Width = 80;
      this.bgcT_Agg6.Caption = "T_Agg6";
      this.bgcT_Agg6.MinWidth = 80;
      this.bgcT_Agg6.Name = "bgcT_Agg6";
      this.bgcT_Agg6.OptionsColumn.AllowFocus = false;
      this.bgcT_Agg6.OptionsColumn.ReadOnly = true;
      this.bgcT_Agg6.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "", "{0:0.##}")
      });
      this.bgcT_Agg6.Visible = true;
      this.bgcT_Agg6.Width = 80;
      this.gridBand45.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand45.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand45.Caption = "Sai số";
      this.gridBand45.Columns.Add(this.bgcSaiSoAgg6);
      this.gridBand45.Name = "gridBand45";
      this.gridBand45.VisibleIndex = 3;
      this.gridBand45.Width = 80;
      this.bgcSaiSoAgg6.Caption = "Sai So Agg6";
      this.bgcSaiSoAgg6.FieldName = "Agg6_Tol";
      this.bgcSaiSoAgg6.MinWidth = 80;
      this.bgcSaiSoAgg6.Name = "bgcSaiSoAgg6";
      this.bgcSaiSoAgg6.OptionsColumn.AllowFocus = false;
      this.bgcSaiSoAgg6.OptionsColumn.ReadOnly = true;
      this.bgcSaiSoAgg6.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg6_Tol", "{0:0.##}")
      });
      this.bgcSaiSoAgg6.Visible = true;
      this.bgcSaiSoAgg6.Width = 80;
      this.gridBand46.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand46.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand46.Caption = "% Sai số";
      this.gridBand46.Columns.Add(this.bgcPerSaiSoAgg6);
      this.gridBand46.Name = "gridBand46";
      this.gridBand46.VisibleIndex = 4;
      this.gridBand46.Width = 80;
      this.bgcPerSaiSoAgg6.Caption = "PerSaiSoAgg6";
      this.bgcPerSaiSoAgg6.FieldName = "Agg6_PerTol";
      this.bgcPerSaiSoAgg6.MinWidth = 80;
      this.bgcPerSaiSoAgg6.Name = "bgcPerSaiSoAgg6";
      this.bgcPerSaiSoAgg6.OptionsColumn.AllowFocus = false;
      this.bgcPerSaiSoAgg6.OptionsColumn.ReadOnly = true;
      this.bgcPerSaiSoAgg6.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Agg6_PerTol", "{0:0.##}")
      });
      this.bgcPerSaiSoAgg6.Visible = true;
      this.bgcPerSaiSoAgg6.Width = 80;
      this.Ce1.AppearanceHeader.Options.UseTextOptions = true;
      this.Ce1.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Ce1.Caption = "CE_1";
      this.Ce1.Children.AddRange(new GridBand[5]
      {
        this.gridBand48,
        this.gridBand49,
        this.gridBand50,
        this.gridBand51,
        this.gridBand52
      });
      this.Ce1.Name = "Ce1";
      this.Ce1.VisibleIndex = 19;
      this.Ce1.Width = 400;
      this.gridBand48.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand48.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand48.Caption = "Cấp phối";
      this.gridBand48.Columns.Add(this.bgcCP_Ce1);
      this.gridBand48.Name = "gridBand48";
      this.gridBand48.VisibleIndex = 0;
      this.gridBand48.Width = 80;
      this.bgcCP_Ce1.Caption = "CP_Ce 1";
      this.bgcCP_Ce1.FieldName = "Ce1";
      this.bgcCP_Ce1.MinWidth = 80;
      this.bgcCP_Ce1.Name = "bgcCP_Ce1";
      this.bgcCP_Ce1.OptionsColumn.AllowFocus = false;
      this.bgcCP_Ce1.OptionsColumn.ReadOnly = true;
      this.bgcCP_Ce1.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce1", "{0:0.##}")
      });
      this.bgcCP_Ce1.Visible = true;
      this.bgcCP_Ce1.Width = 80;
      this.gridBand49.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand49.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand49.Caption = "Thực cân";
      this.gridBand49.Columns.Add(this.bgcCe1);
      this.gridBand49.Name = "gridBand49";
      this.gridBand49.VisibleIndex = 1;
      this.gridBand49.Width = 80;
      this.bgcCe1.Caption = "Ce 1";
      this.bgcCe1.FieldName = "Ce1_Bat";
      this.bgcCe1.MinWidth = 80;
      this.bgcCe1.Name = "bgcCe1";
      this.bgcCe1.OptionsColumn.AllowFocus = false;
      this.bgcCe1.OptionsColumn.ReadOnly = true;
      this.bgcCe1.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce1_Bat", "{0:0.##}")
      });
      this.bgcCe1.Visible = true;
      this.bgcCe1.Width = 80;
      this.gridBand50.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand50.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand50.Caption = "Thực cân tay";
      this.gridBand50.Columns.Add(this.bgcT_Ce1);
      this.gridBand50.Name = "gridBand50";
      this.gridBand50.VisibleIndex = 2;
      this.gridBand50.Width = 80;
      this.bgcT_Ce1.Caption = "T_Ce 1";
      this.bgcT_Ce1.FieldName = "Ce1_Man";
      this.bgcT_Ce1.MinWidth = 80;
      this.bgcT_Ce1.Name = "bgcT_Ce1";
      this.bgcT_Ce1.OptionsColumn.AllowFocus = false;
      this.bgcT_Ce1.OptionsColumn.ReadOnly = true;
      this.bgcT_Ce1.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce1_Man", "{0:0.##}")
      });
      this.bgcT_Ce1.Visible = true;
      this.bgcT_Ce1.Width = 80;
      this.gridBand51.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand51.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand51.Caption = "Sai số";
      this.gridBand51.Columns.Add(this.bgcSaiSoCe1);
      this.gridBand51.Name = "gridBand51";
      this.gridBand51.VisibleIndex = 3;
      this.gridBand51.Width = 80;
      this.bgcSaiSoCe1.Caption = "Sai So Ce1";
      this.bgcSaiSoCe1.FieldName = "Ce1_Tol";
      this.bgcSaiSoCe1.MinWidth = 80;
      this.bgcSaiSoCe1.Name = "bgcSaiSoCe1";
      this.bgcSaiSoCe1.OptionsColumn.AllowFocus = false;
      this.bgcSaiSoCe1.OptionsColumn.ReadOnly = true;
      this.bgcSaiSoCe1.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce1_Tol", "{0:0.##}")
      });
      this.bgcSaiSoCe1.Visible = true;
      this.bgcSaiSoCe1.Width = 80;
      this.gridBand52.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand52.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand52.Caption = "% Sai số";
      this.gridBand52.Columns.Add(this.bgcPerSaiSoCe1);
      this.gridBand52.Name = "gridBand52";
      this.gridBand52.VisibleIndex = 4;
      this.gridBand52.Width = 80;
      this.bgcPerSaiSoCe1.Caption = "PerSaiSoCe 1";
      this.bgcPerSaiSoCe1.FieldName = "Ce1_PerTol";
      this.bgcPerSaiSoCe1.MinWidth = 80;
      this.bgcPerSaiSoCe1.Name = "bgcPerSaiSoCe1";
      this.bgcPerSaiSoCe1.OptionsColumn.AllowFocus = false;
      this.bgcPerSaiSoCe1.OptionsColumn.ReadOnly = true;
      this.bgcPerSaiSoCe1.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce1_PerTol", "{0:0.##}")
      });
      this.bgcPerSaiSoCe1.Visible = true;
      this.bgcPerSaiSoCe1.Width = 80;
      this.Ce2.AppearanceHeader.Options.UseTextOptions = true;
      this.Ce2.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Ce2.Caption = "CE_2";
      this.Ce2.Children.AddRange(new GridBand[5]
      {
        this.gridBand1,
        this.gridBand10,
        this.gridBand13,
        this.gridBand23,
        this.gridBand29
      });
      this.Ce2.Name = "Ce2";
      this.Ce2.VisibleIndex = 20;
      this.Ce2.Width = 400;
      this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand1.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand1.Caption = "Cấp phối";
      this.gridBand1.Columns.Add(this.bgcCP_Ce2);
      this.gridBand1.Name = "gridBand1";
      this.gridBand1.VisibleIndex = 0;
      this.gridBand1.Width = 80;
      this.bgcCP_Ce2.Caption = "CP_Ce 2";
      this.bgcCP_Ce2.FieldName = "Ce2";
      this.bgcCP_Ce2.MinWidth = 80;
      this.bgcCP_Ce2.Name = "bgcCP_Ce2";
      this.bgcCP_Ce2.OptionsColumn.AllowFocus = false;
      this.bgcCP_Ce2.OptionsColumn.ReadOnly = true;
      this.bgcCP_Ce2.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce2", "{0:0.##}")
      });
      this.bgcCP_Ce2.Visible = true;
      this.bgcCP_Ce2.Width = 80;
      this.gridBand10.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand10.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand10.Caption = "Thực cân";
      this.gridBand10.Columns.Add(this.bgcCe2);
      this.gridBand10.Name = "gridBand10";
      this.gridBand10.VisibleIndex = 1;
      this.gridBand10.Width = 80;
      this.bgcCe2.Caption = "Ce 2";
      this.bgcCe2.FieldName = "Ce2_Bat";
      this.bgcCe2.MinWidth = 80;
      this.bgcCe2.Name = "bgcCe2";
      this.bgcCe2.OptionsColumn.AllowFocus = false;
      this.bgcCe2.OptionsColumn.ReadOnly = true;
      this.bgcCe2.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce2_Bat", "{0:0.##}")
      });
      this.bgcCe2.Visible = true;
      this.bgcCe2.Width = 80;
      this.gridBand13.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand13.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand13.Caption = "Thực cân tay";
      this.gridBand13.Columns.Add(this.bgcT_Ce2);
      this.gridBand13.Name = "gridBand13";
      this.gridBand13.VisibleIndex = 2;
      this.gridBand13.Width = 80;
      this.bgcT_Ce2.Caption = "T_Ce 2";
      this.bgcT_Ce2.FieldName = "Ce2_Man";
      this.bgcT_Ce2.MinWidth = 80;
      this.bgcT_Ce2.Name = "bgcT_Ce2";
      this.bgcT_Ce2.OptionsColumn.AllowFocus = false;
      this.bgcT_Ce2.OptionsColumn.ReadOnly = true;
      this.bgcT_Ce2.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce2_Man", "{0:0.##}")
      });
      this.bgcT_Ce2.Visible = true;
      this.bgcT_Ce2.Width = 80;
      this.gridBand23.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand23.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand23.Caption = "Sai số";
      this.gridBand23.Columns.Add(this.bgcSaiSoCe2);
      this.gridBand23.Name = "gridBand23";
      this.gridBand23.VisibleIndex = 3;
      this.gridBand23.Width = 80;
      this.bgcSaiSoCe2.Caption = "Sai So Ce2";
      this.bgcSaiSoCe2.FieldName = "Ce2_Tol";
      this.bgcSaiSoCe2.MinWidth = 80;
      this.bgcSaiSoCe2.Name = "bgcSaiSoCe2";
      this.bgcSaiSoCe2.OptionsColumn.AllowFocus = false;
      this.bgcSaiSoCe2.OptionsColumn.ReadOnly = true;
      this.bgcSaiSoCe2.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce2_Tol", "{0:0.##}")
      });
      this.bgcSaiSoCe2.Visible = true;
      this.bgcSaiSoCe2.Width = 80;
      this.gridBand29.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand29.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand29.Caption = "% Sai số";
      this.gridBand29.Columns.Add(this.bgcPerSaiSoCe2);
      this.gridBand29.Name = "gridBand29";
      this.gridBand29.VisibleIndex = 4;
      this.gridBand29.Width = 80;
      this.bgcPerSaiSoCe2.Caption = "PerSaiSoCe 2";
      this.bgcPerSaiSoCe2.FieldName = "Ce2_PerTol";
      this.bgcPerSaiSoCe2.MinWidth = 80;
      this.bgcPerSaiSoCe2.Name = "bgcPerSaiSoCe2";
      this.bgcPerSaiSoCe2.OptionsColumn.AllowFocus = false;
      this.bgcPerSaiSoCe2.OptionsColumn.ReadOnly = true;
      this.bgcPerSaiSoCe2.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce2_PerTol", "{0:0.##}")
      });
      this.bgcPerSaiSoCe2.Visible = true;
      this.bgcPerSaiSoCe2.Width = 80;
      this.Ce3.AppearanceHeader.Options.UseTextOptions = true;
      this.Ce3.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Ce3.Caption = "CE_3";
      this.Ce3.Children.AddRange(new GridBand[5]
      {
        this.gridBand41,
        this.gridBand54,
        this.gridBand55,
        this.gridBand56,
        this.gridBand57
      });
      this.Ce3.Name = "Ce3";
      this.Ce3.VisibleIndex = 21;
      this.Ce3.Width = 400;
      this.gridBand41.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand41.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand41.Caption = "Cấp phối";
      this.gridBand41.Columns.Add(this.bgcCP_Ce3);
      this.gridBand41.Name = "gridBand41";
      this.gridBand41.VisibleIndex = 0;
      this.gridBand41.Width = 80;
      this.bgcCP_Ce3.Caption = "CP_Ce 3";
      this.bgcCP_Ce3.FieldName = "Ce3";
      this.bgcCP_Ce3.MinWidth = 80;
      this.bgcCP_Ce3.Name = "bgcCP_Ce3";
      this.bgcCP_Ce3.OptionsColumn.AllowFocus = false;
      this.bgcCP_Ce3.OptionsColumn.ReadOnly = true;
      this.bgcCP_Ce3.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce3", "{0:0.##}")
      });
      this.bgcCP_Ce3.Visible = true;
      this.bgcCP_Ce3.Width = 80;
      this.gridBand54.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand54.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand54.Caption = "Thực cân";
      this.gridBand54.Columns.Add(this.bgcCe3);
      this.gridBand54.Name = "gridBand54";
      this.gridBand54.VisibleIndex = 1;
      this.gridBand54.Width = 80;
      this.bgcCe3.Caption = "Ce 3";
      this.bgcCe3.FieldName = "Ce3_Bat";
      this.bgcCe3.MinWidth = 80;
      this.bgcCe3.Name = "bgcCe3";
      this.bgcCe3.OptionsColumn.AllowFocus = false;
      this.bgcCe3.OptionsColumn.ReadOnly = true;
      this.bgcCe3.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce3_Bat", "{0:0.##}")
      });
      this.bgcCe3.Visible = true;
      this.bgcCe3.Width = 80;
      this.gridBand55.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand55.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand55.Caption = "Thực cân tay";
      this.gridBand55.Columns.Add(this.bgcT_Ce3);
      this.gridBand55.Name = "gridBand55";
      this.gridBand55.VisibleIndex = 2;
      this.gridBand55.Width = 80;
      this.bgcT_Ce3.Caption = "T_Ce 3";
      this.bgcT_Ce3.FieldName = "Ce3_Man";
      this.bgcT_Ce3.MinWidth = 80;
      this.bgcT_Ce3.Name = "bgcT_Ce3";
      this.bgcT_Ce3.OptionsColumn.AllowFocus = false;
      this.bgcT_Ce3.OptionsColumn.ReadOnly = true;
      this.bgcT_Ce3.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce3_Man", "{0:0.##}")
      });
      this.bgcT_Ce3.Visible = true;
      this.bgcT_Ce3.Width = 80;
      this.gridBand56.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand56.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand56.Caption = "Sai số";
      this.gridBand56.Columns.Add(this.bgcSaiSoCe3);
      this.gridBand56.Name = "gridBand56";
      this.gridBand56.VisibleIndex = 3;
      this.gridBand56.Width = 80;
      this.bgcSaiSoCe3.Caption = "Sai So Ce3";
      this.bgcSaiSoCe3.FieldName = "Ce3_Tol";
      this.bgcSaiSoCe3.MinWidth = 80;
      this.bgcSaiSoCe3.Name = "bgcSaiSoCe3";
      this.bgcSaiSoCe3.OptionsColumn.AllowFocus = false;
      this.bgcSaiSoCe3.OptionsColumn.ReadOnly = true;
      this.bgcSaiSoCe3.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce3_Tol", "{0:0.##}")
      });
      this.bgcSaiSoCe3.Visible = true;
      this.bgcSaiSoCe3.Width = 80;
      this.gridBand57.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand57.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand57.Caption = "% Sai số";
      this.gridBand57.Columns.Add(this.bgcPerSaiSoCe3);
      this.gridBand57.Name = "gridBand57";
      this.gridBand57.VisibleIndex = 4;
      this.gridBand57.Width = 80;
      this.bgcPerSaiSoCe3.Caption = "PerSaiSoCe 3";
      this.bgcPerSaiSoCe3.FieldName = "Ce3_PerTol";
      this.bgcPerSaiSoCe3.MinWidth = 80;
      this.bgcPerSaiSoCe3.Name = "bgcPerSaiSoCe3";
      this.bgcPerSaiSoCe3.OptionsColumn.AllowFocus = false;
      this.bgcPerSaiSoCe3.OptionsColumn.ReadOnly = true;
      this.bgcPerSaiSoCe3.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce3_PerTol", "{0:0.##}")
      });
      this.bgcPerSaiSoCe3.Visible = true;
      this.bgcPerSaiSoCe3.Width = 80;
      this.Ce4.AppearanceHeader.Options.UseTextOptions = true;
      this.Ce4.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Ce4.Caption = "CE_4";
      this.Ce4.Children.AddRange(new GridBand[5]
      {
        this.gridBand59,
        this.gridBand60,
        this.gridBand61,
        this.gridBand62,
        this.gridBand63
      });
      this.Ce4.Name = "Ce4";
      this.Ce4.VisibleIndex = 22;
      this.Ce4.Width = 400;
      this.gridBand59.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand59.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand59.Caption = "Cấp phối";
      this.gridBand59.Columns.Add(this.bgcCP_Ce4);
      this.gridBand59.Name = "gridBand59";
      this.gridBand59.VisibleIndex = 0;
      this.gridBand59.Width = 80;
      this.bgcCP_Ce4.Caption = "CP_Ce 4";
      this.bgcCP_Ce4.FieldName = "Ce4";
      this.bgcCP_Ce4.MinWidth = 80;
      this.bgcCP_Ce4.Name = "bgcCP_Ce4";
      this.bgcCP_Ce4.OptionsColumn.AllowFocus = false;
      this.bgcCP_Ce4.OptionsColumn.ReadOnly = true;
      this.bgcCP_Ce4.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce4", "{0:0.##}")
      });
      this.bgcCP_Ce4.Visible = true;
      this.bgcCP_Ce4.Width = 80;
      this.gridBand60.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand60.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand60.Caption = "Thực cân";
      this.gridBand60.Columns.Add(this.bgcCe4);
      this.gridBand60.Name = "gridBand60";
      this.gridBand60.VisibleIndex = 1;
      this.gridBand60.Width = 80;
      this.bgcCe4.Caption = "Ce 4";
      this.bgcCe4.FieldName = "Ce4_Bat";
      this.bgcCe4.MinWidth = 80;
      this.bgcCe4.Name = "bgcCe4";
      this.bgcCe4.OptionsColumn.AllowFocus = false;
      this.bgcCe4.OptionsColumn.ReadOnly = true;
      this.bgcCe4.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce4_Bat", "{0:0.##}")
      });
      this.bgcCe4.Visible = true;
      this.bgcCe4.Width = 80;
      this.gridBand61.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand61.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand61.Caption = "Thực cân tay";
      this.gridBand61.Columns.Add(this.bgcT_Ce4);
      this.gridBand61.Name = "gridBand61";
      this.gridBand61.VisibleIndex = 2;
      this.gridBand61.Width = 80;
      this.bgcT_Ce4.Caption = "T_Ce 4";
      this.bgcT_Ce4.FieldName = "Ce4_Man";
      this.bgcT_Ce4.MinWidth = 80;
      this.bgcT_Ce4.Name = "bgcT_Ce4";
      this.bgcT_Ce4.OptionsColumn.AllowFocus = false;
      this.bgcT_Ce4.OptionsColumn.ReadOnly = true;
      this.bgcT_Ce4.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce4_Man", "{0:0.##}")
      });
      this.bgcT_Ce4.Visible = true;
      this.bgcT_Ce4.Width = 80;
      this.gridBand62.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand62.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand62.Caption = "Sai số";
      this.gridBand62.Columns.Add(this.bgcSaiSoCe4);
      this.gridBand62.Name = "gridBand62";
      this.gridBand62.VisibleIndex = 3;
      this.gridBand62.Width = 80;
      this.bgcSaiSoCe4.Caption = "Sai So Ce4";
      this.bgcSaiSoCe4.FieldName = "Ce4_Tol";
      this.bgcSaiSoCe4.MinWidth = 80;
      this.bgcSaiSoCe4.Name = "bgcSaiSoCe4";
      this.bgcSaiSoCe4.OptionsColumn.AllowFocus = false;
      this.bgcSaiSoCe4.OptionsColumn.ReadOnly = true;
      this.bgcSaiSoCe4.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce4_Tol", "{0:0.##}")
      });
      this.bgcSaiSoCe4.Visible = true;
      this.bgcSaiSoCe4.Width = 80;
      this.gridBand63.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand63.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand63.Caption = "% Sai số";
      this.gridBand63.Columns.Add(this.bgcPerSaiSoCe4);
      this.gridBand63.Name = "gridBand63";
      this.gridBand63.VisibleIndex = 4;
      this.gridBand63.Width = 80;
      this.bgcPerSaiSoCe4.Caption = "PerSaiSoCe 4";
      this.bgcPerSaiSoCe4.FieldName = "Ce4_PerTol";
      this.bgcPerSaiSoCe4.MinWidth = 80;
      this.bgcPerSaiSoCe4.Name = "bgcPerSaiSoCe4";
      this.bgcPerSaiSoCe4.OptionsColumn.AllowFocus = false;
      this.bgcPerSaiSoCe4.OptionsColumn.ReadOnly = true;
      this.bgcPerSaiSoCe4.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce4_PerTol", "{0:0.##}")
      });
      this.bgcPerSaiSoCe4.Visible = true;
      this.bgcPerSaiSoCe4.Width = 80;
      this.Ce5.AppearanceHeader.Options.UseTextOptions = true;
      this.Ce5.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Ce5.Caption = "CE_5";
      this.Ce5.Children.AddRange(new GridBand[5]
      {
        this.gridBand65,
        this.gridBand66,
        this.gridBand67,
        this.gridBand68,
        this.gridBand69
      });
      this.Ce5.Name = "Ce5";
      this.Ce5.VisibleIndex = 23;
      this.Ce5.Width = 400;
      this.gridBand65.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand65.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand65.Caption = "Cấp phối";
      this.gridBand65.Columns.Add(this.bgcCP_Ce5);
      this.gridBand65.Name = "gridBand65";
      this.gridBand65.VisibleIndex = 0;
      this.gridBand65.Width = 80;
      this.bgcCP_Ce5.Caption = "CP_Ce 5";
      this.bgcCP_Ce5.FieldName = "Ce5";
      this.bgcCP_Ce5.MinWidth = 80;
      this.bgcCP_Ce5.Name = "bgcCP_Ce5";
      this.bgcCP_Ce5.OptionsColumn.AllowFocus = false;
      this.bgcCP_Ce5.OptionsColumn.ReadOnly = true;
      this.bgcCP_Ce5.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce5", "{0:0.##}")
      });
      this.bgcCP_Ce5.Visible = true;
      this.bgcCP_Ce5.Width = 80;
      this.gridBand66.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand66.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand66.Caption = "Thực cân";
      this.gridBand66.Columns.Add(this.bgcCe5);
      this.gridBand66.Name = "gridBand66";
      this.gridBand66.VisibleIndex = 1;
      this.gridBand66.Width = 80;
      this.bgcCe5.Caption = "Ce 5";
      this.bgcCe5.FieldName = "Ce5_Bat";
      this.bgcCe5.MinWidth = 80;
      this.bgcCe5.Name = "bgcCe5";
      this.bgcCe5.OptionsColumn.AllowFocus = false;
      this.bgcCe5.OptionsColumn.ReadOnly = true;
      this.bgcCe5.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce5_Bat", "{0:0.##}")
      });
      this.bgcCe5.Visible = true;
      this.bgcCe5.Width = 80;
      this.gridBand67.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand67.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand67.Caption = "Thực cân tay";
      this.gridBand67.Columns.Add(this.bgcT_Ce5);
      this.gridBand67.Name = "gridBand67";
      this.gridBand67.VisibleIndex = 2;
      this.gridBand67.Width = 80;
      this.bgcT_Ce5.Caption = "T_Ce 5";
      this.bgcT_Ce5.FieldName = "Ce5_Man";
      this.bgcT_Ce5.MinWidth = 80;
      this.bgcT_Ce5.Name = "bgcT_Ce5";
      this.bgcT_Ce5.OptionsColumn.AllowFocus = false;
      this.bgcT_Ce5.OptionsColumn.ReadOnly = true;
      this.bgcT_Ce5.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce5_Man", "{0:0.##}")
      });
      this.bgcT_Ce5.Visible = true;
      this.bgcT_Ce5.Width = 80;
      this.gridBand68.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand68.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand68.Caption = "Sai số";
      this.gridBand68.Columns.Add(this.bgcSaiSoCe5);
      this.gridBand68.Name = "gridBand68";
      this.gridBand68.VisibleIndex = 3;
      this.gridBand68.Width = 80;
      this.bgcSaiSoCe5.Caption = "Sai So Ce5";
      this.bgcSaiSoCe5.FieldName = "Ce5_Tol";
      this.bgcSaiSoCe5.MinWidth = 80;
      this.bgcSaiSoCe5.Name = "bgcSaiSoCe5";
      this.bgcSaiSoCe5.OptionsColumn.AllowFocus = false;
      this.bgcSaiSoCe5.OptionsColumn.ReadOnly = true;
      this.bgcSaiSoCe5.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce5_Tol", "{0:0.##}")
      });
      this.bgcSaiSoCe5.Visible = true;
      this.bgcSaiSoCe5.Width = 80;
      this.gridBand69.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand69.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand69.Caption = "% Sai số";
      this.gridBand69.Columns.Add(this.bgcPerSaiSoCe5);
      this.gridBand69.Name = "gridBand69";
      this.gridBand69.VisibleIndex = 4;
      this.gridBand69.Width = 80;
      this.bgcPerSaiSoCe5.Caption = "PerSaiSoCe 5";
      this.bgcPerSaiSoCe5.FieldName = "Ce5_PerTol";
      this.bgcPerSaiSoCe5.MinWidth = 80;
      this.bgcPerSaiSoCe5.Name = "bgcPerSaiSoCe5";
      this.bgcPerSaiSoCe5.OptionsColumn.AllowFocus = false;
      this.bgcPerSaiSoCe5.OptionsColumn.ReadOnly = true;
      this.bgcPerSaiSoCe5.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Ce5_PerTol", "{0:0.##}")
      });
      this.bgcPerSaiSoCe5.Visible = true;
      this.bgcPerSaiSoCe5.Width = 80;
      this.Wa1.AppearanceHeader.Options.UseTextOptions = true;
      this.Wa1.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Wa1.Caption = "WA_1";
      this.Wa1.Children.AddRange(new GridBand[5]
      {
        this.gridBand71,
        this.gridBand72,
        this.gridBand73,
        this.gridBand35,
        this.gridBand47
      });
      this.Wa1.Name = "Wa1";
      this.Wa1.VisibleIndex = 24;
      this.Wa1.Width = 400;
      this.gridBand71.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand71.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand71.Caption = "Cấp phối";
      this.gridBand71.Columns.Add(this.bgcCP_Wa1);
      this.gridBand71.Name = "gridBand71";
      this.gridBand71.VisibleIndex = 0;
      this.gridBand71.Width = 80;
      this.bgcCP_Wa1.Caption = "CP_Wa 1";
      this.bgcCP_Wa1.FieldName = "Wa1";
      this.bgcCP_Wa1.MinWidth = 80;
      this.bgcCP_Wa1.Name = "bgcCP_Wa1";
      this.bgcCP_Wa1.OptionsColumn.AllowFocus = false;
      this.bgcCP_Wa1.OptionsColumn.ReadOnly = true;
      this.bgcCP_Wa1.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Wa1", "{0:0.##}")
      });
      this.bgcCP_Wa1.Visible = true;
      this.bgcCP_Wa1.Width = 80;
      this.gridBand72.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand72.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand72.Caption = "Thực cân";
      this.gridBand72.Columns.Add(this.bgcWa1);
      this.gridBand72.Name = "gridBand72";
      this.gridBand72.VisibleIndex = 1;
      this.gridBand72.Width = 80;
      this.bgcWa1.Caption = "Wa 1";
      this.bgcWa1.FieldName = "Wa1_Bat";
      this.bgcWa1.MinWidth = 80;
      this.bgcWa1.Name = "bgcWa1";
      this.bgcWa1.OptionsColumn.AllowFocus = false;
      this.bgcWa1.OptionsColumn.ReadOnly = true;
      this.bgcWa1.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Wa1_Bat", "{0:0.##}")
      });
      this.bgcWa1.Visible = true;
      this.bgcWa1.Width = 80;
      this.gridBand73.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand73.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand73.Caption = "Thực cân tay";
      this.gridBand73.Columns.Add(this.bgcT_Wa1);
      this.gridBand73.Name = "gridBand73";
      this.gridBand73.VisibleIndex = 2;
      this.gridBand73.Width = 80;
      this.bgcT_Wa1.Caption = "T_Wa 1";
      this.bgcT_Wa1.FieldName = "Wa1_Man";
      this.bgcT_Wa1.MinWidth = 80;
      this.bgcT_Wa1.Name = "bgcT_Wa1";
      this.bgcT_Wa1.OptionsColumn.AllowFocus = false;
      this.bgcT_Wa1.OptionsColumn.ReadOnly = true;
      this.bgcT_Wa1.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Wa1_Man", "{0:0.##}")
      });
      this.bgcT_Wa1.Visible = true;
      this.bgcT_Wa1.Width = 80;
      this.gridBand35.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand35.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand35.Caption = "Sai số";
      this.gridBand35.Columns.Add(this.bgcSaiSoWa1);
      this.gridBand35.Name = "gridBand35";
      this.gridBand35.VisibleIndex = 3;
      this.gridBand35.Width = 80;
      this.bgcSaiSoWa1.Caption = "Sai So Wa1";
      this.bgcSaiSoWa1.FieldName = "Wa1_Tol";
      this.bgcSaiSoWa1.MinWidth = 80;
      this.bgcSaiSoWa1.Name = "bgcSaiSoWa1";
      this.bgcSaiSoWa1.OptionsColumn.AllowFocus = false;
      this.bgcSaiSoWa1.OptionsColumn.ReadOnly = true;
      this.bgcSaiSoWa1.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Wa1_Tol", "{0:0.##}")
      });
      this.bgcSaiSoWa1.Visible = true;
      this.bgcSaiSoWa1.Width = 80;
      this.gridBand47.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand47.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand47.Caption = "% Sai số";
      this.gridBand47.Columns.Add(this.bgcPerSaiSoWa1);
      this.gridBand47.Name = "gridBand47";
      this.gridBand47.VisibleIndex = 4;
      this.gridBand47.Width = 80;
      this.bgcPerSaiSoWa1.Caption = "PerSaiSoWa 1";
      this.bgcPerSaiSoWa1.FieldName = "Wa1_PerTol";
      this.bgcPerSaiSoWa1.MinWidth = 80;
      this.bgcPerSaiSoWa1.Name = "bgcPerSaiSoWa1";
      this.bgcPerSaiSoWa1.OptionsColumn.AllowFocus = false;
      this.bgcPerSaiSoWa1.OptionsColumn.ReadOnly = true;
      this.bgcPerSaiSoWa1.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Wa1_PerTol", "{0:0.##}")
      });
      this.bgcPerSaiSoWa1.Visible = true;
      this.bgcPerSaiSoWa1.Width = 80;
      this.Wa2.AppearanceHeader.Options.UseTextOptions = true;
      this.Wa2.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Wa2.Caption = "WA_2";
      this.Wa2.Children.AddRange(new GridBand[5]
      {
        this.gridBand58,
        this.gridBand64,
        this.gridBand74,
        this.gridBand75,
        this.gridBand76
      });
      this.Wa2.Name = "Wa2";
      this.Wa2.VisibleIndex = 25;
      this.Wa2.Width = 400;
      this.gridBand58.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand58.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand58.Caption = "Cấp phối";
      this.gridBand58.Columns.Add(this.bgcCP_Wa2);
      this.gridBand58.Name = "gridBand58";
      this.gridBand58.VisibleIndex = 0;
      this.gridBand58.Width = 80;
      this.bgcCP_Wa2.Caption = "CP_Wa 2";
      this.bgcCP_Wa2.FieldName = "Wa1";
      this.bgcCP_Wa2.MinWidth = 80;
      this.bgcCP_Wa2.Name = "bgcCP_Wa2";
      this.bgcCP_Wa2.OptionsColumn.AllowFocus = false;
      this.bgcCP_Wa2.OptionsColumn.ReadOnly = true;
      this.bgcCP_Wa2.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Wa1", "{0:0.##}")
      });
      this.bgcCP_Wa2.Visible = true;
      this.bgcCP_Wa2.Width = 80;
      this.gridBand64.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand64.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand64.Caption = "Thực cân";
      this.gridBand64.Columns.Add(this.bgcWa2);
      this.gridBand64.Name = "gridBand64";
      this.gridBand64.VisibleIndex = 1;
      this.gridBand64.Width = 80;
      this.bgcWa2.Caption = "Wa 2";
      this.bgcWa2.FieldName = "Wa2_Bat";
      this.bgcWa2.MinWidth = 80;
      this.bgcWa2.Name = "bgcWa2";
      this.bgcWa2.OptionsColumn.AllowFocus = false;
      this.bgcWa2.OptionsColumn.ReadOnly = true;
      this.bgcWa2.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Wa2_Bat", "{0:0.##}")
      });
      this.bgcWa2.Visible = true;
      this.bgcWa2.Width = 80;
      this.gridBand74.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand74.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand74.Caption = "Thực cân tay";
      this.gridBand74.Columns.Add(this.bgcT_Wa2);
      this.gridBand74.Name = "gridBand74";
      this.gridBand74.VisibleIndex = 2;
      this.gridBand74.Width = 80;
      this.bgcT_Wa2.Caption = "T_Wa 2";
      this.bgcT_Wa2.FieldName = "Wa2_Man";
      this.bgcT_Wa2.MinWidth = 80;
      this.bgcT_Wa2.Name = "bgcT_Wa2";
      this.bgcT_Wa2.OptionsColumn.AllowFocus = false;
      this.bgcT_Wa2.OptionsColumn.ReadOnly = true;
      this.bgcT_Wa2.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Wa2_Man", "{0:0.##}")
      });
      this.bgcT_Wa2.Visible = true;
      this.bgcT_Wa2.Width = 80;
      this.gridBand75.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand75.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand75.Caption = "Sai số";
      this.gridBand75.Columns.Add(this.bgcSaiSoWa2);
      this.gridBand75.Name = "gridBand75";
      this.gridBand75.VisibleIndex = 3;
      this.gridBand75.Width = 80;
      this.bgcSaiSoWa2.Caption = "Sai So Wa2";
      this.bgcSaiSoWa2.FieldName = "Wa2_Tol";
      this.bgcSaiSoWa2.MinWidth = 80;
      this.bgcSaiSoWa2.Name = "bgcSaiSoWa2";
      this.bgcSaiSoWa2.OptionsColumn.AllowFocus = false;
      this.bgcSaiSoWa2.OptionsColumn.ReadOnly = true;
      this.bgcSaiSoWa2.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Wa2_Tol", "{0:0.##}")
      });
      this.bgcSaiSoWa2.Visible = true;
      this.bgcSaiSoWa2.Width = 80;
      this.gridBand76.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand76.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand76.Caption = "% Sai số";
      this.gridBand76.Columns.Add(this.bgcPerSaiSoWa2);
      this.gridBand76.Name = "gridBand76";
      this.gridBand76.VisibleIndex = 4;
      this.gridBand76.Width = 80;
      this.bgcPerSaiSoWa2.Caption = "PerSaiSoWa 2";
      this.bgcPerSaiSoWa2.FieldName = "Wa2_PerTol";
      this.bgcPerSaiSoWa2.MinWidth = 80;
      this.bgcPerSaiSoWa2.Name = "bgcPerSaiSoWa2";
      this.bgcPerSaiSoWa2.OptionsColumn.AllowFocus = false;
      this.bgcPerSaiSoWa2.OptionsColumn.ReadOnly = true;
      this.bgcPerSaiSoWa2.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Wa2_PerTol", "{0:0.##}")
      });
      this.bgcPerSaiSoWa2.Visible = true;
      this.bgcPerSaiSoWa2.Width = 80;
      this.Add1.AppearanceHeader.Options.UseTextOptions = true;
      this.Add1.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Add1.Caption = "ADD_1";
      this.Add1.Children.AddRange(new GridBand[5]
      {
        this.gridBand78,
        this.gridBand79,
        this.gridBand80,
        this.gridBand81,
        this.gridBand82
      });
      this.Add1.Name = "Add1";
      this.Add1.VisibleIndex = 26;
      this.Add1.Width = 400;
      this.gridBand78.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand78.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand78.Caption = "Cấp phối";
      this.gridBand78.Columns.Add(this.bgcCP_Add1);
      this.gridBand78.Name = "gridBand78";
      this.gridBand78.VisibleIndex = 0;
      this.gridBand78.Width = 80;
      this.bgcCP_Add1.Caption = "CP_Add 1";
      this.bgcCP_Add1.FieldName = "Add1";
      this.bgcCP_Add1.MinWidth = 80;
      this.bgcCP_Add1.Name = "bgcCP_Add1";
      this.bgcCP_Add1.OptionsColumn.AllowFocus = false;
      this.bgcCP_Add1.OptionsColumn.ReadOnly = true;
      this.bgcCP_Add1.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add1", "{0:0.##}")
      });
      this.bgcCP_Add1.Visible = true;
      this.bgcCP_Add1.Width = 80;
      this.gridBand79.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand79.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand79.Caption = "Thực cân";
      this.gridBand79.Columns.Add(this.bgcAdd1);
      this.gridBand79.Name = "gridBand79";
      this.gridBand79.VisibleIndex = 1;
      this.gridBand79.Width = 80;
      this.bgcAdd1.Caption = "Add 1";
      this.bgcAdd1.FieldName = "Add1_Bat";
      this.bgcAdd1.MinWidth = 80;
      this.bgcAdd1.Name = "bgcAdd1";
      this.bgcAdd1.OptionsColumn.AllowFocus = false;
      this.bgcAdd1.OptionsColumn.ReadOnly = true;
      this.bgcAdd1.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add1_Bat", "{0:0.##}")
      });
      this.bgcAdd1.Visible = true;
      this.bgcAdd1.Width = 80;
      this.gridBand80.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand80.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand80.Caption = "Thực cân tay";
      this.gridBand80.Columns.Add(this.bgcT_Add1);
      this.gridBand80.Name = "gridBand80";
      this.gridBand80.VisibleIndex = 2;
      this.gridBand80.Width = 80;
      this.bgcT_Add1.Caption = "T_Add 1";
      this.bgcT_Add1.FieldName = "Add1_Man";
      this.bgcT_Add1.MinWidth = 80;
      this.bgcT_Add1.Name = "bgcT_Add1";
      this.bgcT_Add1.OptionsColumn.AllowFocus = false;
      this.bgcT_Add1.OptionsColumn.ReadOnly = true;
      this.bgcT_Add1.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add1_Man", "{0:0.##}")
      });
      this.bgcT_Add1.Visible = true;
      this.bgcT_Add1.Width = 80;
      this.gridBand81.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand81.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand81.Caption = "Sai số";
      this.gridBand81.Columns.Add(this.bgcSaiSoAdd1);
      this.gridBand81.Name = "gridBand81";
      this.gridBand81.VisibleIndex = 3;
      this.gridBand81.Width = 80;
      this.bgcSaiSoAdd1.Caption = "Sai So Add1";
      this.bgcSaiSoAdd1.FieldName = "Add1_Tol";
      this.bgcSaiSoAdd1.MinWidth = 80;
      this.bgcSaiSoAdd1.Name = "bgcSaiSoAdd1";
      this.bgcSaiSoAdd1.OptionsColumn.AllowFocus = false;
      this.bgcSaiSoAdd1.OptionsColumn.ReadOnly = true;
      this.bgcSaiSoAdd1.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add1_Tol", "{0:0.##}")
      });
      this.bgcSaiSoAdd1.Visible = true;
      this.bgcSaiSoAdd1.Width = 80;
      this.gridBand82.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand82.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand82.Caption = "% Sai số";
      this.gridBand82.Columns.Add(this.bgcPerSaiSoAdd1);
      this.gridBand82.Name = "gridBand82";
      this.gridBand82.VisibleIndex = 4;
      this.gridBand82.Width = 80;
      this.bgcPerSaiSoAdd1.Caption = "PerSaiSoAdd 1";
      this.bgcPerSaiSoAdd1.FieldName = "Add1_PerTol";
      this.bgcPerSaiSoAdd1.MinWidth = 80;
      this.bgcPerSaiSoAdd1.Name = "bgcPerSaiSoAdd1";
      this.bgcPerSaiSoAdd1.OptionsColumn.AllowFocus = false;
      this.bgcPerSaiSoAdd1.OptionsColumn.ReadOnly = true;
      this.bgcPerSaiSoAdd1.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add1_PerTol", "{0:0.##}")
      });
      this.bgcPerSaiSoAdd1.Visible = true;
      this.bgcPerSaiSoAdd1.Width = 80;
      this.Add2.AppearanceHeader.Options.UseTextOptions = true;
      this.Add2.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Add2.Caption = "ADD_2";
      this.Add2.Children.AddRange(new GridBand[5]
      {
        this.gridBand84,
        this.gridBand85,
        this.gridBand86,
        this.gridBand87,
        this.gridBand88
      });
      this.Add2.Name = "Add2";
      this.Add2.VisibleIndex = 27;
      this.Add2.Width = 400;
      this.gridBand84.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand84.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand84.Caption = "Cấp phối";
      this.gridBand84.Columns.Add(this.bgcCP_Add2);
      this.gridBand84.Name = "gridBand84";
      this.gridBand84.VisibleIndex = 0;
      this.gridBand84.Width = 80;
      this.bgcCP_Add2.Caption = "CP_Add 2";
      this.bgcCP_Add2.FieldName = "Add2";
      this.bgcCP_Add2.MinWidth = 80;
      this.bgcCP_Add2.Name = "bgcCP_Add2";
      this.bgcCP_Add2.OptionsColumn.AllowFocus = false;
      this.bgcCP_Add2.OptionsColumn.ReadOnly = true;
      this.bgcCP_Add2.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add2", "{0:0.##}")
      });
      this.bgcCP_Add2.Visible = true;
      this.bgcCP_Add2.Width = 80;
      this.gridBand85.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand85.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand85.Caption = "Thực cân";
      this.gridBand85.Columns.Add(this.bgcAdd2);
      this.gridBand85.Name = "gridBand85";
      this.gridBand85.VisibleIndex = 1;
      this.gridBand85.Width = 80;
      this.bgcAdd2.Caption = "Add 2";
      this.bgcAdd2.FieldName = "Add2_Bat";
      this.bgcAdd2.MinWidth = 80;
      this.bgcAdd2.Name = "bgcAdd2";
      this.bgcAdd2.OptionsColumn.AllowFocus = false;
      this.bgcAdd2.OptionsColumn.ReadOnly = true;
      this.bgcAdd2.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add2_Bat", "{0:0.##}")
      });
      this.bgcAdd2.Visible = true;
      this.bgcAdd2.Width = 80;
      this.gridBand86.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand86.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand86.Caption = "Thực cân tay";
      this.gridBand86.Columns.Add(this.bgcT_Add2);
      this.gridBand86.Name = "gridBand86";
      this.gridBand86.VisibleIndex = 2;
      this.gridBand86.Width = 80;
      this.bgcT_Add2.Caption = "T_Add 2";
      this.bgcT_Add2.FieldName = "Add2_Man";
      this.bgcT_Add2.MinWidth = 80;
      this.bgcT_Add2.Name = "bgcT_Add2";
      this.bgcT_Add2.OptionsColumn.AllowFocus = false;
      this.bgcT_Add2.OptionsColumn.ReadOnly = true;
      this.bgcT_Add2.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add2_Man", "{0:0.##}")
      });
      this.bgcT_Add2.Visible = true;
      this.bgcT_Add2.Width = 80;
      this.gridBand87.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand87.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand87.Caption = "Sai số";
      this.gridBand87.Columns.Add(this.bgcSaiSoAdd2);
      this.gridBand87.Name = "gridBand87";
      this.gridBand87.VisibleIndex = 3;
      this.gridBand87.Width = 80;
      this.bgcSaiSoAdd2.Caption = "Sai So Add2";
      this.bgcSaiSoAdd2.FieldName = "Add2_Tol";
      this.bgcSaiSoAdd2.MinWidth = 80;
      this.bgcSaiSoAdd2.Name = "bgcSaiSoAdd2";
      this.bgcSaiSoAdd2.OptionsColumn.AllowFocus = false;
      this.bgcSaiSoAdd2.OptionsColumn.ReadOnly = true;
      this.bgcSaiSoAdd2.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add2_Tol", "{0:0.##}")
      });
      this.bgcSaiSoAdd2.Visible = true;
      this.bgcSaiSoAdd2.Width = 80;
      this.gridBand88.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand88.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand88.Caption = "% Sai số";
      this.gridBand88.Columns.Add(this.bgcPerSaiSoAdd2);
      this.gridBand88.Name = "gridBand88";
      this.gridBand88.VisibleIndex = 4;
      this.gridBand88.Width = 80;
      this.bgcPerSaiSoAdd2.Caption = "PerSaiSoAdd 2";
      this.bgcPerSaiSoAdd2.FieldName = "Add2_PerTol";
      this.bgcPerSaiSoAdd2.MinWidth = 80;
      this.bgcPerSaiSoAdd2.Name = "bgcPerSaiSoAdd2";
      this.bgcPerSaiSoAdd2.OptionsColumn.AllowFocus = false;
      this.bgcPerSaiSoAdd2.OptionsColumn.ReadOnly = true;
      this.bgcPerSaiSoAdd2.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add2_PerTol", "{0:0.##}")
      });
      this.bgcPerSaiSoAdd2.Visible = true;
      this.bgcPerSaiSoAdd2.Width = 80;
      this.Add3.AppearanceHeader.Options.UseTextOptions = true;
      this.Add3.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Add3.Caption = "ADD_3";
      this.Add3.Children.AddRange(new GridBand[5]
      {
        this.gridBand90,
        this.gridBand91,
        this.gridBand92,
        this.gridBand93,
        this.gridBand94
      });
      this.Add3.Name = "Add3";
      this.Add3.VisibleIndex = 28;
      this.Add3.Width = 400;
      this.gridBand90.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand90.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand90.Caption = "Cấp phối";
      this.gridBand90.Columns.Add(this.bgcCP_Add3);
      this.gridBand90.Name = "gridBand90";
      this.gridBand90.VisibleIndex = 0;
      this.gridBand90.Width = 80;
      this.bgcCP_Add3.Caption = "CP_Add 3";
      this.bgcCP_Add3.FieldName = "Add3";
      this.bgcCP_Add3.MinWidth = 80;
      this.bgcCP_Add3.Name = "bgcCP_Add3";
      this.bgcCP_Add3.OptionsColumn.AllowFocus = false;
      this.bgcCP_Add3.OptionsColumn.ReadOnly = true;
      this.bgcCP_Add3.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add3", "{0:0.##}")
      });
      this.bgcCP_Add3.Visible = true;
      this.bgcCP_Add3.Width = 80;
      this.gridBand91.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand91.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand91.Caption = "Thực cân";
      this.gridBand91.Columns.Add(this.bgcAdd3);
      this.gridBand91.Name = "gridBand91";
      this.gridBand91.VisibleIndex = 1;
      this.gridBand91.Width = 80;
      this.bgcAdd3.Caption = "Add 3";
      this.bgcAdd3.FieldName = "Add3_Bat";
      this.bgcAdd3.MinWidth = 80;
      this.bgcAdd3.Name = "bgcAdd3";
      this.bgcAdd3.OptionsColumn.AllowFocus = false;
      this.bgcAdd3.OptionsColumn.ReadOnly = true;
      this.bgcAdd3.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add3_Bat", "{0:0.##}")
      });
      this.bgcAdd3.Visible = true;
      this.bgcAdd3.Width = 80;
      this.gridBand92.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand92.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand92.Caption = "Thực cân tay";
      this.gridBand92.Columns.Add(this.bgcT_Add3);
      this.gridBand92.Name = "gridBand92";
      this.gridBand92.VisibleIndex = 2;
      this.gridBand92.Width = 80;
      this.bgcT_Add3.Caption = "T_Add 3";
      this.bgcT_Add3.FieldName = "Add3_Man";
      this.bgcT_Add3.MinWidth = 80;
      this.bgcT_Add3.Name = "bgcT_Add3";
      this.bgcT_Add3.OptionsColumn.AllowFocus = false;
      this.bgcT_Add3.OptionsColumn.ReadOnly = true;
      this.bgcT_Add3.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add3_Man", "{0:0.##}")
      });
      this.bgcT_Add3.Visible = true;
      this.bgcT_Add3.Width = 80;
      this.gridBand93.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand93.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand93.Caption = "Sai số";
      this.gridBand93.Columns.Add(this.bgcSaiSoAdd3);
      this.gridBand93.Name = "gridBand93";
      this.gridBand93.VisibleIndex = 3;
      this.gridBand93.Width = 80;
      this.bgcSaiSoAdd3.Caption = "Sai So Add3";
      this.bgcSaiSoAdd3.FieldName = "Add3_Tol";
      this.bgcSaiSoAdd3.MinWidth = 80;
      this.bgcSaiSoAdd3.Name = "bgcSaiSoAdd3";
      this.bgcSaiSoAdd3.OptionsColumn.AllowFocus = false;
      this.bgcSaiSoAdd3.OptionsColumn.ReadOnly = true;
      this.bgcSaiSoAdd3.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add3_Tol", "{0:0.##}")
      });
      this.bgcSaiSoAdd3.Visible = true;
      this.bgcSaiSoAdd3.Width = 80;
      this.gridBand94.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand94.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand94.Caption = "% Sai số";
      this.gridBand94.Columns.Add(this.bgcPerSaiSoAdd3);
      this.gridBand94.Name = "gridBand94";
      this.gridBand94.VisibleIndex = 4;
      this.gridBand94.Width = 80;
      this.bgcPerSaiSoAdd3.Caption = "PerSaiSoAdd 3";
      this.bgcPerSaiSoAdd3.FieldName = "Add3_PerTol";
      this.bgcPerSaiSoAdd3.MinWidth = 80;
      this.bgcPerSaiSoAdd3.Name = "bgcPerSaiSoAdd3";
      this.bgcPerSaiSoAdd3.OptionsColumn.AllowFocus = false;
      this.bgcPerSaiSoAdd3.OptionsColumn.ReadOnly = true;
      this.bgcPerSaiSoAdd3.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add3_PerTol", "{0:0.##}")
      });
      this.bgcPerSaiSoAdd3.Visible = true;
      this.bgcPerSaiSoAdd3.Width = 80;
      this.Add4.AppearanceHeader.Options.UseTextOptions = true;
      this.Add4.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Add4.Caption = "ADD_4";
      this.Add4.Children.AddRange(new GridBand[5]
      {
        this.gridBand96,
        this.gridBand97,
        this.gridBand98,
        this.gridBand99,
        this.gridBand100
      });
      this.Add4.Name = "Add4";
      this.Add4.VisibleIndex = 29;
      this.Add4.Width = 400;
      this.gridBand96.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand96.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand96.Caption = "Cấp phối";
      this.gridBand96.Columns.Add(this.bgcCP_Add4);
      this.gridBand96.Name = "gridBand96";
      this.gridBand96.VisibleIndex = 0;
      this.gridBand96.Width = 80;
      this.bgcCP_Add4.Caption = "CP_Add 4";
      this.bgcCP_Add4.FieldName = "Add4";
      this.bgcCP_Add4.MinWidth = 80;
      this.bgcCP_Add4.Name = "bgcCP_Add4";
      this.bgcCP_Add4.OptionsColumn.AllowFocus = false;
      this.bgcCP_Add4.OptionsColumn.ReadOnly = true;
      this.bgcCP_Add4.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add4", "{0:0.##}")
      });
      this.bgcCP_Add4.Visible = true;
      this.bgcCP_Add4.Width = 80;
      this.gridBand97.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand97.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand97.Caption = "Thực cân";
      this.gridBand97.Columns.Add(this.bgcAdd4);
      this.gridBand97.Name = "gridBand97";
      this.gridBand97.VisibleIndex = 1;
      this.gridBand97.Width = 80;
      this.bgcAdd4.Caption = "Add 4";
      this.bgcAdd4.FieldName = "Add4_Bat";
      this.bgcAdd4.MinWidth = 80;
      this.bgcAdd4.Name = "bgcAdd4";
      this.bgcAdd4.OptionsColumn.AllowFocus = false;
      this.bgcAdd4.OptionsColumn.ReadOnly = true;
      this.bgcAdd4.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add4_Bat", "{0:0.##}")
      });
      this.bgcAdd4.Visible = true;
      this.bgcAdd4.Width = 80;
      this.gridBand98.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand98.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand98.Caption = "Thực cân tay";
      this.gridBand98.Columns.Add(this.bgcT_Add4);
      this.gridBand98.Name = "gridBand98";
      this.gridBand98.VisibleIndex = 2;
      this.gridBand98.Width = 80;
      this.bgcT_Add4.Caption = "T_Add 4";
      this.bgcT_Add4.FieldName = "Add4_Man";
      this.bgcT_Add4.MinWidth = 80;
      this.bgcT_Add4.Name = "bgcT_Add4";
      this.bgcT_Add4.OptionsColumn.AllowFocus = false;
      this.bgcT_Add4.OptionsColumn.ReadOnly = true;
      this.bgcT_Add4.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add4_Man", "{0:0.##}")
      });
      this.bgcT_Add4.Visible = true;
      this.bgcT_Add4.Width = 80;
      this.gridBand99.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand99.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand99.Caption = "Sai số";
      this.gridBand99.Columns.Add(this.bgcSaiSoAdd4);
      this.gridBand99.Name = "gridBand99";
      this.gridBand99.VisibleIndex = 3;
      this.gridBand99.Width = 80;
      this.bgcSaiSoAdd4.Caption = "Sai So Add4";
      this.bgcSaiSoAdd4.FieldName = "Add4_Tol";
      this.bgcSaiSoAdd4.MinWidth = 80;
      this.bgcSaiSoAdd4.Name = "bgcSaiSoAdd4";
      this.bgcSaiSoAdd4.OptionsColumn.AllowFocus = false;
      this.bgcSaiSoAdd4.OptionsColumn.ReadOnly = true;
      this.bgcSaiSoAdd4.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add4_Tol", "{0:0.##}")
      });
      this.bgcSaiSoAdd4.Visible = true;
      this.bgcSaiSoAdd4.Width = 80;
      this.gridBand100.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand100.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand100.Caption = "% Sai số";
      this.gridBand100.Columns.Add(this.bgcPerSaiSoAdd4);
      this.gridBand100.Name = "gridBand100";
      this.gridBand100.VisibleIndex = 4;
      this.gridBand100.Width = 80;
      this.bgcPerSaiSoAdd4.Caption = "PerSaiSoAdd 4";
      this.bgcPerSaiSoAdd4.FieldName = "Add4_PerTol";
      this.bgcPerSaiSoAdd4.MinWidth = 80;
      this.bgcPerSaiSoAdd4.Name = "bgcPerSaiSoAdd4";
      this.bgcPerSaiSoAdd4.OptionsColumn.AllowFocus = false;
      this.bgcPerSaiSoAdd4.OptionsColumn.ReadOnly = true;
      this.bgcPerSaiSoAdd4.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add4_PerTol", "{0:0.##}")
      });
      this.bgcPerSaiSoAdd4.Visible = true;
      this.bgcPerSaiSoAdd4.Width = 80;
      this.Add5.AppearanceHeader.Options.UseTextOptions = true;
      this.Add5.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Add5.Caption = "ADD_5";
      this.Add5.Children.AddRange(new GridBand[5]
      {
        this.gridBand102,
        this.gridBand103,
        this.gridBand104,
        this.gridBand105,
        this.gridBand106
      });
      this.Add5.Name = "Add5";
      this.Add5.VisibleIndex = 30;
      this.Add5.Width = 400;
      this.gridBand102.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand102.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand102.Caption = "Cấp phối";
      this.gridBand102.Columns.Add(this.bgcCP_Add5);
      this.gridBand102.Name = "gridBand102";
      this.gridBand102.VisibleIndex = 0;
      this.gridBand102.Width = 80;
      this.bgcCP_Add5.Caption = "CP_Add 5";
      this.bgcCP_Add5.FieldName = "Add5";
      this.bgcCP_Add5.MinWidth = 80;
      this.bgcCP_Add5.Name = "bgcCP_Add5";
      this.bgcCP_Add5.OptionsColumn.AllowFocus = false;
      this.bgcCP_Add5.OptionsColumn.ReadOnly = true;
      this.bgcCP_Add5.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add5", "{0:0.##}")
      });
      this.bgcCP_Add5.Visible = true;
      this.bgcCP_Add5.Width = 80;
      this.gridBand103.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand103.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand103.Caption = "Thực cân";
      this.gridBand103.Columns.Add(this.bgcAdd5);
      this.gridBand103.Name = "gridBand103";
      this.gridBand103.VisibleIndex = 1;
      this.gridBand103.Width = 80;
      this.bgcAdd5.Caption = "Add 5";
      this.bgcAdd5.FieldName = "Add5_Bat";
      this.bgcAdd5.MinWidth = 80;
      this.bgcAdd5.Name = "bgcAdd5";
      this.bgcAdd5.OptionsColumn.AllowFocus = false;
      this.bgcAdd5.OptionsColumn.ReadOnly = true;
      this.bgcAdd5.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add5_Bat", "{0:0.##}")
      });
      this.bgcAdd5.Visible = true;
      this.bgcAdd5.Width = 80;
      this.gridBand104.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand104.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand104.Caption = "Thực cân tay";
      this.gridBand104.Columns.Add(this.bgcT_Add5);
      this.gridBand104.Name = "gridBand104";
      this.gridBand104.VisibleIndex = 2;
      this.gridBand104.Width = 80;
      this.bgcT_Add5.Caption = "T_Add 5";
      this.bgcT_Add5.FieldName = "Add5_Man";
      this.bgcT_Add5.MinWidth = 80;
      this.bgcT_Add5.Name = "bgcT_Add5";
      this.bgcT_Add5.OptionsColumn.AllowFocus = false;
      this.bgcT_Add5.OptionsColumn.ReadOnly = true;
      this.bgcT_Add5.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add5_Man", "{0:0.##}")
      });
      this.bgcT_Add5.Visible = true;
      this.bgcT_Add5.Width = 80;
      this.gridBand105.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand105.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand105.Caption = "Sai số";
      this.gridBand105.Columns.Add(this.bgcSaiSoAdd5);
      this.gridBand105.Name = "gridBand105";
      this.gridBand105.VisibleIndex = 3;
      this.gridBand105.Width = 80;
      this.bgcSaiSoAdd5.Caption = "Sai So Add5";
      this.bgcSaiSoAdd5.FieldName = "Add5_Tol";
      this.bgcSaiSoAdd5.MinWidth = 80;
      this.bgcSaiSoAdd5.Name = "bgcSaiSoAdd5";
      this.bgcSaiSoAdd5.OptionsColumn.AllowFocus = false;
      this.bgcSaiSoAdd5.OptionsColumn.ReadOnly = true;
      this.bgcSaiSoAdd5.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add5_Tol", "{0:0.##}")
      });
      this.bgcSaiSoAdd5.Visible = true;
      this.bgcSaiSoAdd5.Width = 80;
      this.gridBand106.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand106.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand106.Caption = "% Sai số";
      this.gridBand106.Columns.Add(this.bgcPerSaiSoAdd5);
      this.gridBand106.Name = "gridBand106";
      this.gridBand106.VisibleIndex = 4;
      this.gridBand106.Width = 80;
      this.bgcPerSaiSoAdd5.Caption = "PerSaiSoAdd 5";
      this.bgcPerSaiSoAdd5.FieldName = "Add5_PerTol";
      this.bgcPerSaiSoAdd5.MinWidth = 80;
      this.bgcPerSaiSoAdd5.Name = "bgcPerSaiSoAdd5";
      this.bgcPerSaiSoAdd5.OptionsColumn.AllowFocus = false;
      this.bgcPerSaiSoAdd5.OptionsColumn.ReadOnly = true;
      this.bgcPerSaiSoAdd5.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add5_PerTol", "{0:0.##}")
      });
      this.bgcPerSaiSoAdd5.Visible = true;
      this.bgcPerSaiSoAdd5.Width = 80;
      this.Add6.AppearanceHeader.Options.UseTextOptions = true;
      this.Add6.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Add6.Caption = "ADD_6";
      this.Add6.Children.AddRange(new GridBand[5]
      {
        this.gridBand108,
        this.gridBand109,
        this.gridBand110,
        this.gridBand111,
        this.gridBand112
      });
      this.Add6.Name = "Add6";
      this.Add6.VisibleIndex = 31;
      this.Add6.Width = 400;
      this.gridBand108.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand108.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand108.Caption = "Cấp phối";
      this.gridBand108.Columns.Add(this.bgcCP_Add6);
      this.gridBand108.Name = "gridBand108";
      this.gridBand108.VisibleIndex = 0;
      this.gridBand108.Width = 80;
      this.bgcCP_Add6.Caption = "CP_Add 6";
      this.bgcCP_Add6.FieldName = "Add6";
      this.bgcCP_Add6.MinWidth = 80;
      this.bgcCP_Add6.Name = "bgcCP_Add6";
      this.bgcCP_Add6.OptionsColumn.AllowFocus = false;
      this.bgcCP_Add6.OptionsColumn.ReadOnly = true;
      this.bgcCP_Add6.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add6", "{0:0.##}")
      });
      this.bgcCP_Add6.Visible = true;
      this.bgcCP_Add6.Width = 80;
      this.gridBand109.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand109.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand109.Caption = "Thực cân";
      this.gridBand109.Columns.Add(this.bgcAdd6);
      this.gridBand109.Name = "gridBand109";
      this.gridBand109.VisibleIndex = 1;
      this.gridBand109.Width = 80;
      this.bgcAdd6.Caption = "Add 6";
      this.bgcAdd6.FieldName = "Add6_Bat";
      this.bgcAdd6.MinWidth = 80;
      this.bgcAdd6.Name = "bgcAdd6";
      this.bgcAdd6.OptionsColumn.AllowFocus = false;
      this.bgcAdd6.OptionsColumn.ReadOnly = true;
      this.bgcAdd6.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add6_Bat", "{0:0.##}")
      });
      this.bgcAdd6.Visible = true;
      this.bgcAdd6.Width = 80;
      this.gridBand110.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand110.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand110.Caption = "Thực cân tay";
      this.gridBand110.Columns.Add(this.bgcT_Add6);
      this.gridBand110.Name = "gridBand110";
      this.gridBand110.VisibleIndex = 2;
      this.gridBand110.Width = 80;
      this.bgcT_Add6.Caption = "T_Add 6";
      this.bgcT_Add6.FieldName = "Add6_Man";
      this.bgcT_Add6.MinWidth = 80;
      this.bgcT_Add6.Name = "bgcT_Add6";
      this.bgcT_Add6.OptionsColumn.AllowFocus = false;
      this.bgcT_Add6.OptionsColumn.ReadOnly = true;
      this.bgcT_Add6.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add6_Man", "{0:0.##}")
      });
      this.bgcT_Add6.Visible = true;
      this.bgcT_Add6.Width = 80;
      this.gridBand111.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand111.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand111.Caption = "Sai số";
      this.gridBand111.Columns.Add(this.bgcSaiSoAdd6);
      this.gridBand111.Name = "gridBand111";
      this.gridBand111.VisibleIndex = 3;
      this.gridBand111.Width = 80;
      this.bgcSaiSoAdd6.Caption = "Sai So Add6";
      this.bgcSaiSoAdd6.FieldName = "Add6_Tol";
      this.bgcSaiSoAdd6.MinWidth = 80;
      this.bgcSaiSoAdd6.Name = "bgcSaiSoAdd6";
      this.bgcSaiSoAdd6.OptionsColumn.AllowFocus = false;
      this.bgcSaiSoAdd6.OptionsColumn.ReadOnly = true;
      this.bgcSaiSoAdd6.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add6_Tol", "{0:0.##}")
      });
      this.bgcSaiSoAdd6.Visible = true;
      this.bgcSaiSoAdd6.Width = 80;
      this.gridBand112.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand112.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gridBand112.Caption = "% Sai số";
      this.gridBand112.Columns.Add(this.bgcPerSaiSoAdd6);
      this.gridBand112.Name = "gridBand112";
      this.gridBand112.VisibleIndex = 4;
      this.gridBand112.Width = 80;
      this.bgcPerSaiSoAdd6.Caption = "PerSaiSoAdd 6";
      this.bgcPerSaiSoAdd6.FieldName = "Add6_PerTol";
      this.bgcPerSaiSoAdd6.MinWidth = 80;
      this.bgcPerSaiSoAdd6.Name = "bgcPerSaiSoAdd6";
      this.bgcPerSaiSoAdd6.OptionsColumn.AllowFocus = false;
      this.bgcPerSaiSoAdd6.OptionsColumn.ReadOnly = true;
      this.bgcPerSaiSoAdd6.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Add6_PerTol", "{0:0.##}")
      });
      this.bgcPerSaiSoAdd6.Visible = true;
      this.bgcPerSaiSoAdd6.Width = 80;
      this.groupControl2.Controls.Add((Control)this.txtMaPhieuTron);
      this.groupControl2.Controls.Add((Control)this.lueCheDo);
      this.groupControl2.Controls.Add((Control)this.labelControl11);
      this.groupControl2.Controls.Add((Control)this.lueNhanVien);
      this.groupControl2.Controls.Add((Control)this.labelControl10);
      this.groupControl2.Controls.Add((Control)this.lueMAC);
      this.groupControl2.Controls.Add((Control)this.labelControl9);
      this.groupControl2.Controls.Add((Control)this.lueBienSo);
      this.groupControl2.Controls.Add((Control)this.labelControl7);
      this.groupControl2.Controls.Add((Control)this.lueHangMuc);
      this.groupControl2.Controls.Add((Control)this.labelControl6);
      this.groupControl2.Controls.Add((Control)this.lueKhachHang);
      this.groupControl2.Controls.Add((Control)this.labelControl5);
      this.groupControl2.Controls.Add((Control)this.lueCongTruong);
      this.groupControl2.Controls.Add((Control)this.labelControl4);
      this.groupControl2.Controls.Add((Control)this.btnReset);
      this.groupControl2.Controls.Add((Control)this.btnSearch);
      this.groupControl2.Controls.Add((Control)this.lueTaiXe);
      this.groupControl2.Controls.Add((Control)this.labelControl3);
      this.groupControl2.Controls.Add((Control)this.labelControl2);
      this.groupControl2.Controls.Add((Control)this.datToDate);
      this.groupControl2.Controls.Add((Control)this.datFromDate);
      this.groupControl2.Controls.Add((Control)this.labelControl1);
      this.groupControl2.Controls.Add((Control)this.lblFromDate);
      this.groupControl2.Dock = DockStyle.Right;
      this.groupControl2.Location = new Point(1105, 2);
      this.groupControl2.Name = "groupControl2";
      this.groupControl2.Size = new Size(280, 835);
      this.groupControl2.TabIndex = 1;
      this.groupControl2.Text = "Tìm kiếm";
      this.txtMaPhieuTron.Location = new Point(117, 126);
      this.txtMaPhieuTron.Name = "txtMaPhieuTron";
      this.txtMaPhieuTron.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtMaPhieuTron.Properties.Appearance.Options.UseFont = true;
      this.txtMaPhieuTron.Size = new Size(150, 22);
      this.txtMaPhieuTron.TabIndex = 48;
      this.lueCheDo.Location = new Point(117, 415);
      this.lueCheDo.Name = "lueCheDo";
      this.lueCheDo.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
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
      this.lueCheDo.TabIndex = 47;
      this.labelControl11.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl11.Appearance.Options.UseFont = true;
      this.labelControl11.Location = new Point(49, 418);
      this.labelControl11.Name = "labelControl11";
      this.labelControl11.Size = new Size(40, 16);
      this.labelControl11.TabIndex = 46;
      this.labelControl11.Text = "Chế độ";
      this.lueNhanVien.Location = new Point(117, 378);
      this.lueNhanVien.Name = "lueNhanVien";
      this.lueNhanVien.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lueNhanVien.Properties.Appearance.Options.UseFont = true;
      this.lueNhanVien.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueNhanVien.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("NhanVienID", "NhanVienID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("TenNhanVien", "Tên Nhân viên")
      });
      this.lueNhanVien.Properties.DisplayMember = "TenNhanVien";
      this.lueNhanVien.Properties.NullText = "";
      this.lueNhanVien.Properties.ValueMember = "NhanVienID";
      this.lueNhanVien.Size = new Size(150, 22);
      this.lueNhanVien.TabIndex = 45;
      this.labelControl10.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl10.Appearance.Options.UseFont = true;
      this.labelControl10.Location = new Point(34, 381);
      this.labelControl10.Name = "labelControl10";
      this.labelControl10.Size = new Size(56, 16);
      this.labelControl10.TabIndex = 44;
      this.labelControl10.Text = "Nhân viên";
      this.lueMAC.Location = new Point(117, 340);
      this.lueMAC.Name = "lueMAC";
      this.lueMAC.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lueMAC.Properties.Appearance.Options.UseFont = true;
      this.lueMAC.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueMAC.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("MACID", "MACID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("TenMAC", "Tên MAC")
      });
      this.lueMAC.Properties.DisplayMember = "TenMAC";
      this.lueMAC.Properties.NullText = "";
      this.lueMAC.Properties.ValueMember = "MACID";
      this.lueMAC.Size = new Size(150, 22);
      this.lueMAC.TabIndex = 43;
      this.labelControl9.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl9.Appearance.Options.UseFont = true;
      this.labelControl9.Location = new Point(38, 343);
      this.labelControl9.Name = "labelControl9";
      this.labelControl9.Size = new Size(52, 16);
      this.labelControl9.TabIndex = 42;
      this.labelControl9.Text = "Tên MAC";
      this.lueBienSo.Location = new Point(117, 301);
      this.lueBienSo.Name = "lueBienSo";
      this.lueBienSo.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lueBienSo.Properties.Appearance.Options.UseFont = true;
      this.lueBienSo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueBienSo.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("XeID", "XeID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("BienSo", "Biển số")
      });
      this.lueBienSo.Properties.DisplayMember = "BienSo";
      this.lueBienSo.Properties.NullText = "";
      this.lueBienSo.Properties.ValueMember = "XeID";
      this.lueBienSo.Size = new Size(150, 22);
      this.lueBienSo.TabIndex = 41;
      this.labelControl7.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl7.Appearance.Options.UseFont = true;
      this.labelControl7.Location = new Point(49, 304);
      this.labelControl7.Name = "labelControl7";
      this.labelControl7.Size = new Size(41, 16);
      this.labelControl7.TabIndex = 40;
      this.labelControl7.Text = "Biển số";
      this.lueHangMuc.Location = new Point(117, 230);
      this.lueHangMuc.Name = "lueHangMuc";
      this.lueHangMuc.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lueHangMuc.Properties.Appearance.Options.UseFont = true;
      this.lueHangMuc.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueHangMuc.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("HangMucID", "HangMucID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("TenHangMuc", "Tên Hạng mục")
      });
      this.lueHangMuc.Properties.DisplayMember = "TenHangMuc";
      this.lueHangMuc.Properties.NullText = "";
      this.lueHangMuc.Properties.ValueMember = "HangMucID";
      this.lueHangMuc.Size = new Size(150, 22);
      this.lueHangMuc.TabIndex = 39;
      this.labelControl6.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl6.Appearance.Options.UseFont = true;
      this.labelControl6.Location = new Point(33, 233);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new Size(57, 16);
      this.labelControl6.TabIndex = 38;
      this.labelControl6.Text = "Hạng mục";
      this.lueKhachHang.Location = new Point(117, 164);
      this.lueKhachHang.Name = "lueKhachHang";
      this.lueKhachHang.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lueKhachHang.Properties.Appearance.Options.UseFont = true;
      this.lueKhachHang.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueKhachHang.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("KhachHangID", "KhachHangID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("TenKhachHang", "Tên Khách hàng")
      });
      this.lueKhachHang.Properties.DisplayMember = "TenKhachHang";
      this.lueKhachHang.Properties.NullText = "";
      this.lueKhachHang.Properties.ValueMember = "KhachHangID";
      this.lueKhachHang.Size = new Size(150, 22);
      this.lueKhachHang.TabIndex = 37;
      this.labelControl5.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl5.Appearance.Options.UseFont = true;
      this.labelControl5.Location = new Point(27, 167);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new Size(66, 16);
      this.labelControl5.TabIndex = 36;
      this.labelControl5.Text = "Khách hàng";
      this.lueCongTruong.Location = new Point(117, 195);
      this.lueCongTruong.Name = "lueCongTruong";
      this.lueCongTruong.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lueCongTruong.Properties.Appearance.Options.UseFont = true;
      this.lueCongTruong.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueCongTruong.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("CongTruongID", "CongTruongID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.True),
        new LookUpColumnInfo("TenCongTruong", "Tên Công trường")
      });
      this.lueCongTruong.Properties.DisplayMember = "TenCongTruong";
      this.lueCongTruong.Properties.NullText = "";
      this.lueCongTruong.Properties.ValueMember = "CongTruongID";
      this.lueCongTruong.Size = new Size(150, 22);
      this.lueCongTruong.TabIndex = 35;
      this.labelControl4.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl4.Appearance.Options.UseFont = true;
      this.labelControl4.Location = new Point(19, 198);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new Size(71, 16);
      this.labelControl4.TabIndex = 34;
      this.labelControl4.Text = "Công trường";
      this.btnReset.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnReset.Appearance.Options.UseFont = true;
      this.btnReset.Location = new Point(159, 467);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new Size(108, 32);
      this.btnReset.TabIndex = 33;
      this.btnReset.Text = "Làm mới";
      this.btnReset.Click += new EventHandler(this.btnReset_Click);
      this.btnSearch.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnSearch.Appearance.Options.UseFont = true;
      this.btnSearch.Location = new Point(26, 467);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new Size(108, 32);
      this.btnSearch.TabIndex = 32;
      this.btnSearch.Text = "Tìm";
      this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
      this.lueTaiXe.Location = new Point(117, 265);
      this.lueTaiXe.Name = "lueTaiXe";
      this.lueTaiXe.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lueTaiXe.Properties.Appearance.Options.UseFont = true;
      this.lueTaiXe.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueTaiXe.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("TaiXeID", "TaiXeID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("TenTaiXe", "Tên Tài xế")
      });
      this.lueTaiXe.Properties.DisplayMember = "TenTaiXe";
      this.lueTaiXe.Properties.NullText = "";
      this.lueTaiXe.Properties.ValueMember = "TaiXeID";
      this.lueTaiXe.Size = new Size(150, 22);
      this.lueTaiXe.TabIndex = 31;
      this.labelControl3.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Location = new Point(55, 268);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new Size(35, 16);
      this.labelControl3.TabIndex = 30;
      this.labelControl3.Text = "Tài xế";
      this.labelControl2.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new Point(14, 131);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(79, 16);
      this.labelControl2.TabIndex = 29;
      this.labelControl2.Text = "Mã phiếu trộn";
      this.datToDate.EditValue = (object)null;
      this.datToDate.Location = new Point(117, 92);
      this.datToDate.Name = "datToDate";
      this.datToDate.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.datToDate.Properties.Appearance.Options.UseFont = true;
      this.datToDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datToDate.Size = new Size(150, 22);
      this.datToDate.TabIndex = 28;
      this.datFromDate.EditValue = (object)null;
      this.datFromDate.Location = new Point(117, 56);
      this.datFromDate.Name = "datFromDate";
      this.datFromDate.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.datFromDate.Properties.Appearance.Options.UseFont = true;
      this.datFromDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datFromDate.Size = new Size(150, 22);
      this.datFromDate.TabIndex = 27;
      this.labelControl1.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(39, 95);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(54, 16);
      this.labelControl1.TabIndex = 26;
      this.labelControl1.Text = "Đến ngày";
      this.lblFromDate.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblFromDate.Appearance.Options.UseFont = true;
      this.lblFromDate.Location = new Point(24, 59);
      this.lblFromDate.Name = "lblFromDate";
      this.lblFromDate.Size = new Size(69, 16);
      this.lblFromDate.TabIndex = 25;
      this.lblFromDate.Text = "Tạo từ ngày";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control)this.panelControl1);
      this.Name = "RptChiTietMeTron";
      this.Size = new Size(1387, 839);
      this.panelControl1.EndInit();
      this.panelControl1.ResumeLayout(false);
      this.groupControl3.EndInit();
      this.groupControl3.ResumeLayout(false);
      this.gridControl1.EndInit();
      this.bandedGridView1.EndInit();
      this.repositoryItemCheckEdit1.EndInit();
      this.groupControl2.EndInit();
      this.groupControl2.ResumeLayout(false);
      this.groupControl2.PerformLayout();
      this.txtMaPhieuTron.Properties.EndInit();
      this.lueCheDo.Properties.EndInit();
      this.lueNhanVien.Properties.EndInit();
      this.lueMAC.Properties.EndInit();
      this.lueBienSo.Properties.EndInit();
      this.lueHangMuc.Properties.EndInit();
      this.lueKhachHang.Properties.EndInit();
      this.lueCongTruong.Properties.EndInit();
      this.lueTaiXe.Properties.EndInit();
      this.datToDate.Properties.CalendarTimeProperties.EndInit();
      this.datToDate.Properties.EndInit();
      this.datFromDate.Properties.CalendarTimeProperties.EndInit();
      this.datFromDate.Properties.EndInit();
      this.ResumeLayout(false);
    }
  }
}
