using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using NhuaNong.ServiceLibrary;
using NhuaNong.Data;
using NhuaNong.PLCMapping;
using NhuaNong.PLCModule;
using NhuaNong.UserControls;
using NhuaNong.Utils;
using S7.Net;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace NhuaNong.MasterData
{
  public partial class VanHanhInd
  {
    private IContainer components;
    private ucSiloFD siloFD;
    private ucSiloAGG siloAgg1;
    private ucSiloAGG siloAgg2;
    private ucSiloAGG siloAgg3;
    private ucSiloAGG siloAgg4;
    private ucSiloAGG siloAgg5;
    private ucBtnTron btnVanCanFD;
    private ucBtnTron btnVanCanAGG1;
    private ucBtnTron btnVanCanAGG2;
    private ucBtnTron btnVanCanAGG3;
    private ucBtnTron btnVanCanAGG4;
    private ucBtnTron btnVanCanAGG5;
    private ucTinHieuDo tinHieuCanSiloFD;
    private ucTinHieuDo tinHieuCanSiloAGG1;
    private ucTinHieuDo tinHieuCanSiloAGG2;
    private ucTinHieuDo tinHieuCanSiloAGG3;
    private ucTinHieuDo tinHieuCanSiloAGG4;
    private ucTinHieuDo tinHieuCanSiloAGG5;
    private ucTinHieuDo tinHieuCanSiloAP;
    private ucTinHieuDo tinHieuCanSiloSBS;
    private ucTinHieuBaoDay barFullSiloAGG1;
    private ucTinHieuBaoDay barFullSiloAGG2;
    private ucTinHieuBaoDay barFullSiloAGG3;
    private ucTinHieuBaoDay barFullSiloAGG4;
    private ucTinHieuBaoDay barFullSiloAGG5;
    private ucWeighFD weighFD;
    private ucWeighAGGInd weighAGG1;
    private ucWeighAGGInd weighAGG2;
    private ucWeighAGGInd weighAGG3;
    private ucWeighAGGInd weighAGG4;
    private ucWeighAGGInd weighAGG5;
    private ucWeighAP weighAP;
    private ucWeighSBS weighSBS;
    private ucBtnXaCan btnXaCanFD;
    private ucBtnXaCan btnXaCanAP;
    private ucBtnXaCan btnXaCanAGG;
    private ucBtnXaCan btnXaCanSBS;
    private ucBtnMo btnMoCuaNoi;
    private ucBtnDong btnDongCuaNoi;
    private ucBtnBatDau btnBatDau;
    private ucBtnDung btnDung;
    private ucBtnHuy btnHuy;
    private ucBtnSIM btnSIM;
    private ucBtnCheDo btnCheDoHeThong;
    private ucBtnCheDo btnCheDoNapLieu;
    private ucBtnCheDo btnCheDoCuaNoi;
    private Label lblHeThong;
    private Label label1;
    private Label label2;
    private ucBonChuaKhi ucBonChuaKhi1;
    private ucSanRung sanRung;
    private ucMotorMini motorGauTaiFD;
    private ucTinHieunTanSayLua tinHieuTanSayLua;
    private ucMotorFat motorBomDau;
    private ucMotorExtra ucMotorExtra1;
    private ucPheuChua02 ucPheuChua021;
    private ucPheuChua03 ucPheuChua031;
    private ucMotorFat motorPheuChua02;
    private GroupBox groupBox1;
    private Label label4;
    private Label label3;
    private TextBox txtNhietDoTanSay;
    private TextBox txtNhietDoAGG;
    private TextBox txtNhietDoTuiLocKho;
    private Label label6;
    private Label label5;
    private TextBox txtNhietDoNhua;
    private ucPheuChuaCatDa ucPheuChuaCatDa1;
    private ucPheuChuaCatDa ucPheuChuaCatDa2;
    private ucPheuChuaCatDa ucPheuChuaCatDa3;
    private ucPheuChuaCatDa ucPheuChuaCatDa4;
    private ucPheuChuaCatDa ucPheuChuaCatDa5;
    private ucBtnXaCan btnXaCanAGG1;
    private ucBtnXaCan btnXaCanAGG2;
    private ucBtnXaCan btnXaCanAGG3;
    private ucBtnXaCan btnXaCanAGG4;
    private ucBtnXaCan btnXaCanAGG5;
    private ucTinHieuXanh tinHieuXaCanAGG1;
    private ucTinHieuXanh tinHieuXaCanAGG2;
    private ucTinHieuXanh tinHieuXaCanAGG3;
    private ucTinHieuXanh tinHieuXaCanAGG4;
    private ucTinHieuXanh tinHieuXaCanAGG5;
    private ucBangTaiCan bangTaiCan;
    private ucBTX bangTaiXien;
    private System.Windows.Forms.Timer timer1;
    private Label connectStus;
    private ucOngTanSay ucOngTanSay1;
    private ucOngBonChuaKhi ucOngBonChuaKhi1;
    private ucOngPheuChua03 ucOngPheuChua031;
    private ucOngPheuChua04 ucOngPheuChua041;
    private ucBomNgam bomNgamPheuChua;
    private ucPheuChua04 ucPheuChua041;
    private ucBonChuaTanSay ucBonChuaTanSay1;
    private ucOngMotor ucOngMotor1;
    private ucOngAP ucOngAP1;
    private ucMotorFat motorPheuChua01;
    private ucPheuChua01 ucPheuChua011;
    private ucBtnTron btnVanCanAP;
    private ucSiloAP siloAP;
    private ucOngSBS ucOngSBS1;
    private ucBtnTron btnVanCanSBS;
    private ucSiloSBS siloSBS;
    private ucTinHieuBaoDay barFullSiloSBS;
    private Label label7;
    private TextEdit textEdit1;
    private TextEdit textEdit3;
    private Label label8;
    private TextEdit txtTG_BomTuoiNhua;
    private Label label11;
    private ucBomKhi ucBomKhi1;
    private ucBtnBomKhi btnMayNenKhi;
    private MemoEdit memoEdit1;
    private Label label12;
    private ucVitTaiFD tinHIeuVitTaiFD;
    private ucTinHieuBaoDay tinHieuBaoMucThapFD;
    private ucTinHieuBaoDay tinHieuBaoMucCaoFD;
    private Label label10;
    private TextEdit textEdit4;
    private Label label9;
    private TextEdit textEdit2;
    private ucSiloFDFat siloFDFat;
    private ucSoMeDaCan slMeDaCanFD;
    private ucSoMeDaCan slMeDaCanAGG;
    private ucSoMeDaCan slMeDaCanAP;
    private ucSoMeDaCan slMeDaCanSBS;
    private ucBangGauTaiXiMangNhanh ucBangGauTaiXiMangNhanh1;
    private ucTinHieuBaoDay barFullSiloFD;
    private ucBtnFU btnFU_FD;
    private ucBtnFU btnFU_AG1;
    private ucBtnFU btnFU_AGG2;
    private ucBtnFU btnFU_AGG3;
    private ucBtnFU btnFU_AGG4;
    private ucBtnFU btnFU_AGG5;
    private ucBtnFU btnFU_AP;
    private ucBtnFU btnFU_SBS;
    private ucBangGauTaiXiMang ucBangGauTaiXiMang2;
    private ucBeTiep ucBeTiep1;
    private ucBtnTron btnRungCL1;
    private ucBtnTron btnRungCL2;
    private ucBtnTron btnRungCL3;
    private ucMotorMiniN motorGauTaiAGG1;
    private ucBangGauTaiCatDa ucBangGauTaiCatDa1;
    private ucBangGauTauCatDaNhanh ucBangGauTauCatDaNhanh1;
    private Label lblMAC;
    private Label checkDaat;
    private ucTinHieuSanRung tinHieuSanRung;
    private ucTinHieuDongCuaNoi tinHieuDongCuaNoi;
    private ucTinHieuMoCuaNoi tinHieuMoCuaNoi;
    private ucBtnSanRung btnSanRung;
    private ucBtnVitTai ucBtnVitTai1;
    private LabelControl lblNameCty;
    private LabelControl lblDec;
    private ucTinHieuTanSayQuay btnTanSay;
    private Label label13;
    private ucBtnCheDo btnCheDoXaCan;
    private GridLookUpEdit gluHopDong;
    private GridView glueHopDong;
    private GridColumn grcDuLieuTronID;
    private GridColumn grcMaHopDong;
    private GridColumn grcTenHopDong;
    private LabelControl lblDLT;
    private LabelControl labelControl3;
    private GridLookUpEdit gluTaiXe;
    private GridView gridView1;
    private GridColumn grcTaiXeID;
    private GridColumn grcMaTaiXe;
    private GridColumn grcTenTaiXe;
    private GridLookUpEdit glueBienSo;
    private GridView gridView2;
    private GridColumn grcXeID;
    private GridColumn grcBienSo;
    private LabelControl labelControl4;
    private GroupControl groupControl1;
    private TextEdit txtMAC;
    private LabelControl labelControl5;
    private TextEdit txtKhoiLuong;
    private LabelControl labelControl6;
    private TextEdit txtKhachHang;
    private LabelControl labelControl7;
    private TextEdit txtCongTruong;
    private LabelControl labelControl8;
    private TextEdit txtMaPhieuTron;
    private LabelControl labelControl9;
    private GroupControl VAA;
    private ucOngDanFD ucOngDanFD1;
    private ucTinHieuXaCan tinHieuXaCanAGG;
    private ucTinHieuXaCan tinHieuXaCanFD;
    private ucSoMeDaCan slMeDaCanNoiTron;
    private ucBtnNoiTron btnNoiTronR;
    private ucBtnNoiTron btnNoiTronL;
    private ucNoiTron ucNoiTron1;
    private GridControl grcMeTronCur;
    private GridView grvMeTronCur;
    private GridColumn gcMaPhieuTron;
    private GridColumn gcSTTMeTron;
    private GridColumn ggcNgayTron;
    private GridColumn gcGioTron;
    private GridColumn gcKhachHang;
    private GridColumn gcCongTruong;
    private GridColumn gcTenMAC;
    private GridColumn gcKhoiLuong;
    private ucMotorMini motorBomTuoiNhua;
    private ucOngDanSB ucOngDanSB2;
    private ucBtnXAHETAGG btnXaHetAGG;
    private ucTinHieuXaCan tinHieuBomTuoiNhua;
    private ucTinHieuXaCan tinHieuXaCanSBS;
    private ucTinHieuMoCuaNoi tinHieuCuaNoiMo;
    private ucTinHieuDongCuaNoi tinHieuCuaNoiDong;
    private ucTinHieuDo tinHieuXaCanAP;
    private ucTinHieuTanSayQuay btnDauDot;
    private ucTinHieuXaCan tinHieuCuaMo;
    private ucTinHieuXaCan tinHieuCuaDong;
    private ucBtnXaCan btnPheuSBS;
    private LabelControl lblPhone;
    private LabelControl lblGmail;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VanHanhInd));
      this.siloFD = new NhuaNong.UserControls.ucSiloFD();
      this.siloAgg1 = new NhuaNong.UserControls.ucSiloAGG();
      this.siloAgg2 = new NhuaNong.UserControls.ucSiloAGG();
      this.siloAgg3 = new NhuaNong.UserControls.ucSiloAGG();
      this.siloAgg4 = new NhuaNong.UserControls.ucSiloAGG();
      this.siloAgg5 = new NhuaNong.UserControls.ucSiloAGG();
      this.barFullSiloAGG1 = new NhuaNong.UserControls.ucTinHieuBaoDay();
      this.barFullSiloAGG2 = new NhuaNong.UserControls.ucTinHieuBaoDay();
      this.barFullSiloAGG3 = new NhuaNong.UserControls.ucTinHieuBaoDay();
      this.barFullSiloAGG4 = new NhuaNong.UserControls.ucTinHieuBaoDay();
      this.barFullSiloAGG5 = new NhuaNong.UserControls.ucTinHieuBaoDay();
      this.weighFD = new NhuaNong.UserControls.ucWeighFD();
      this.weighAGG1 = new NhuaNong.UserControls.ucWeighAGGInd();
      this.weighAGG2 = new NhuaNong.UserControls.ucWeighAGGInd();
      this.weighAGG3 = new NhuaNong.UserControls.ucWeighAGGInd();
      this.weighAGG4 = new NhuaNong.UserControls.ucWeighAGGInd();
      this.weighAGG5 = new NhuaNong.UserControls.ucWeighAGGInd();
      this.weighAP = new NhuaNong.UserControls.ucWeighAP();
      this.weighSBS = new NhuaNong.UserControls.ucWeighSBS();
      this.btnXaCanFD = new NhuaNong.UserControls.ucBtnXaCan();
      this.btnXaCanAP = new NhuaNong.UserControls.ucBtnXaCan();
      this.btnXaCanAGG = new NhuaNong.UserControls.ucBtnXaCan();
      this.btnXaCanSBS = new NhuaNong.UserControls.ucBtnXaCan();
      this.lblHeThong = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtNhietDoNhua = new System.Windows.Forms.TextBox();
      this.txtNhietDoTanSay = new System.Windows.Forms.TextBox();
      this.txtNhietDoAGG = new System.Windows.Forms.TextBox();
      this.txtNhietDoTuiLocKho = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.btnXaCanAGG1 = new NhuaNong.UserControls.ucBtnXaCan();
      this.btnXaCanAGG2 = new NhuaNong.UserControls.ucBtnXaCan();
      this.btnXaCanAGG3 = new NhuaNong.UserControls.ucBtnXaCan();
      this.btnXaCanAGG4 = new NhuaNong.UserControls.ucBtnXaCan();
      this.btnXaCanAGG5 = new NhuaNong.UserControls.ucBtnXaCan();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.connectStus = new System.Windows.Forms.Label();
      this.siloAP = new NhuaNong.UserControls.ucSiloAP();
      this.siloSBS = new NhuaNong.UserControls.ucSiloSBS();
      this.barFullSiloSBS = new NhuaNong.UserControls.ucTinHieuBaoDay();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.tinHieuBaoMucThapFD = new NhuaNong.UserControls.ucTinHieuBaoDay();
      this.tinHieuBaoMucCaoFD = new NhuaNong.UserControls.ucTinHieuBaoDay();
      this.label10 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.slMeDaCanFD = new NhuaNong.UserControls.ucSoMeDaCan();
      this.slMeDaCanAGG = new NhuaNong.UserControls.ucSoMeDaCan();
      this.slMeDaCanAP = new NhuaNong.UserControls.ucSoMeDaCan();
      this.slMeDaCanSBS = new NhuaNong.UserControls.ucSoMeDaCan();
      this.barFullSiloFD = new NhuaNong.UserControls.ucTinHieuBaoDay();
      this.lblMAC = new System.Windows.Forms.Label();
      this.checkDaat = new System.Windows.Forms.Label();
      this.lblNameCty = new DevExpress.XtraEditors.LabelControl();
      this.lblDec = new DevExpress.XtraEditors.LabelControl();
      this.label13 = new System.Windows.Forms.Label();
      this.lblDLT = new DevExpress.XtraEditors.LabelControl();
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
      this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
      this.txtMaPhieuTron = new DevExpress.XtraEditors.TextEdit();
      this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
      this.txtCongTruong = new DevExpress.XtraEditors.TextEdit();
      this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
      this.txtKhachHang = new DevExpress.XtraEditors.TextEdit();
      this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
      this.txtKhoiLuong = new DevExpress.XtraEditors.TextEdit();
      this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
      this.txtMAC = new DevExpress.XtraEditors.TextEdit();
      this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
      this.gluHopDong = new DevExpress.XtraEditors.GridLookUpEdit();
      this.glueHopDong = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.grcDuLieuTronID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.grcMaHopDong = new DevExpress.XtraGrid.Columns.GridColumn();
      this.grcTenHopDong = new DevExpress.XtraGrid.Columns.GridColumn();
      this.glueBienSo = new DevExpress.XtraEditors.GridLookUpEdit();
      this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.grcXeID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.grcBienSo = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gluTaiXe = new DevExpress.XtraEditors.GridLookUpEdit();
      this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.grcTaiXeID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.grcMaTaiXe = new DevExpress.XtraGrid.Columns.GridColumn();
      this.grcTenTaiXe = new DevExpress.XtraGrid.Columns.GridColumn();
      this.VAA = new DevExpress.XtraEditors.GroupControl();
      this.lblPhone = new DevExpress.XtraEditors.LabelControl();
      this.lblGmail = new DevExpress.XtraEditors.LabelControl();
      this.btnCheDoXaCan = new NhuaNong.UserControls.ucBtnCheDo();
      this.btnTanSay = new NhuaNong.UserControls.ucTinHieuTanSayQuay();
      this.ucBtnVitTai1 = new NhuaNong.UserControls.ucBtnVitTai();
      this.btnSanRung = new NhuaNong.UserControls.ucBtnSanRung();
      this.tinHieuMoCuaNoi = new NhuaNong.UserControls.ucTinHieuMoCuaNoi();
      this.tinHieuDongCuaNoi = new NhuaNong.UserControls.ucTinHieuDongCuaNoi();
      this.tinHieuSanRung = new NhuaNong.UserControls.ucTinHieuSanRung();
      this.ucBangGauTauCatDaNhanh1 = new NhuaNong.UserControls.ucBangGauTauCatDaNhanh();
      this.ucBangGauTaiCatDa1 = new NhuaNong.UserControls.ucBangGauTaiCatDa();
      this.motorGauTaiAGG1 = new NhuaNong.UserControls.ucMotorMiniN();
      this.btnRungCL3 = new NhuaNong.UserControls.ucBtnTron();
      this.btnRungCL2 = new NhuaNong.UserControls.ucBtnTron();
      this.btnRungCL1 = new NhuaNong.UserControls.ucBtnTron();
      this.ucBeTiep1 = new NhuaNong.UserControls.ucBeTiep();
      this.ucBangGauTaiXiMang2 = new NhuaNong.UserControls.ucBangGauTaiXiMang();
      this.btnFU_SBS = new NhuaNong.UserControls.ucBtnFU();
      this.btnFU_AP = new NhuaNong.UserControls.ucBtnFU();
      this.btnFU_AGG5 = new NhuaNong.UserControls.ucBtnFU();
      this.btnFU_AGG4 = new NhuaNong.UserControls.ucBtnFU();
      this.btnFU_AGG3 = new NhuaNong.UserControls.ucBtnFU();
      this.btnFU_AGG2 = new NhuaNong.UserControls.ucBtnFU();
      this.btnFU_AG1 = new NhuaNong.UserControls.ucBtnFU();
      this.btnFU_FD = new NhuaNong.UserControls.ucBtnFU();
      this.ucBangGauTaiXiMangNhanh1 = new NhuaNong.UserControls.ucBangGauTaiXiMangNhanh();
      this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
      this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
      this.siloFDFat = new NhuaNong.UserControls.ucSiloFDFat();
      this.tinHIeuVitTaiFD = new NhuaNong.UserControls.ucVitTaiFD();
      this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
      this.btnMayNenKhi = new NhuaNong.UserControls.ucBtnBomKhi();
      this.ucBomKhi1 = new NhuaNong.UserControls.ucBomKhi();
      this.txtTG_BomTuoiNhua = new DevExpress.XtraEditors.TextEdit();
      this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
      this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
      this.btnVanCanSBS = new NhuaNong.UserControls.ucBtnTron();
      this.ucOngSBS1 = new NhuaNong.UserControls.ucOngSBS();
      this.btnVanCanAP = new NhuaNong.UserControls.ucBtnTron();
      this.ucPheuChua011 = new NhuaNong.UserControls.ucPheuChua01();
      this.motorPheuChua01 = new NhuaNong.UserControls.ucMotorFat();
      this.ucOngAP1 = new NhuaNong.UserControls.ucOngAP();
      this.ucOngMotor1 = new NhuaNong.UserControls.ucOngMotor();
      this.ucBonChuaTanSay1 = new NhuaNong.UserControls.ucBonChuaTanSay();
      this.bomNgamPheuChua = new NhuaNong.UserControls.ucBomNgam();
      this.ucPheuChua041 = new NhuaNong.UserControls.ucPheuChua04();
      this.ucOngPheuChua041 = new NhuaNong.UserControls.ucOngPheuChua04();
      this.ucOngPheuChua031 = new NhuaNong.UserControls.ucOngPheuChua03();
      this.ucOngBonChuaKhi1 = new NhuaNong.UserControls.ucOngBonChuaKhi();
      this.ucOngTanSay1 = new NhuaNong.UserControls.ucOngTanSay();
      this.bangTaiXien = new NhuaNong.UserControls.ucBTX();
      this.bangTaiCan = new NhuaNong.UserControls.ucBangTaiCan();
      this.tinHieuXaCanAGG5 = new NhuaNong.UserControls.ucTinHieuXanh();
      this.tinHieuXaCanAGG4 = new NhuaNong.UserControls.ucTinHieuXanh();
      this.tinHieuXaCanAGG3 = new NhuaNong.UserControls.ucTinHieuXanh();
      this.tinHieuXaCanAGG2 = new NhuaNong.UserControls.ucTinHieuXanh();
      this.tinHieuXaCanAGG1 = new NhuaNong.UserControls.ucTinHieuXanh();
      this.ucPheuChuaCatDa5 = new NhuaNong.UserControls.ucPheuChuaCatDa();
      this.ucPheuChuaCatDa4 = new NhuaNong.UserControls.ucPheuChuaCatDa();
      this.ucPheuChuaCatDa3 = new NhuaNong.UserControls.ucPheuChuaCatDa();
      this.ucPheuChuaCatDa2 = new NhuaNong.UserControls.ucPheuChuaCatDa();
      this.ucPheuChuaCatDa1 = new NhuaNong.UserControls.ucPheuChuaCatDa();
      this.motorPheuChua02 = new NhuaNong.UserControls.ucMotorFat();
      this.ucPheuChua031 = new NhuaNong.UserControls.ucPheuChua03();
      this.ucPheuChua021 = new NhuaNong.UserControls.ucPheuChua02();
      this.ucMotorExtra1 = new NhuaNong.UserControls.ucMotorExtra();
      this.motorBomDau = new NhuaNong.UserControls.ucMotorFat();
      this.tinHieuTanSayLua = new NhuaNong.UserControls.ucTinHieunTanSayLua();
      this.motorGauTaiFD = new NhuaNong.UserControls.ucMotorMini();
      this.sanRung = new NhuaNong.UserControls.ucSanRung();
      this.ucBonChuaKhi1 = new NhuaNong.UserControls.ucBonChuaKhi();
      this.btnCheDoCuaNoi = new NhuaNong.UserControls.ucBtnCheDo();
      this.btnCheDoNapLieu = new NhuaNong.UserControls.ucBtnCheDo();
      this.btnCheDoHeThong = new NhuaNong.UserControls.ucBtnCheDo();
      this.btnSIM = new NhuaNong.UserControls.ucBtnSIM();
      this.btnHuy = new NhuaNong.UserControls.ucBtnHuy();
      this.btnDung = new NhuaNong.UserControls.ucBtnDung();
      this.btnBatDau = new NhuaNong.UserControls.ucBtnBatDau();
      this.btnDongCuaNoi = new NhuaNong.UserControls.ucBtnDong();
      this.btnMoCuaNoi = new NhuaNong.UserControls.ucBtnMo();
      this.tinHieuCanSiloSBS = new NhuaNong.UserControls.ucTinHieuDo();
      this.tinHieuCanSiloAP = new NhuaNong.UserControls.ucTinHieuDo();
      this.tinHieuCanSiloAGG5 = new NhuaNong.UserControls.ucTinHieuDo();
      this.tinHieuCanSiloAGG4 = new NhuaNong.UserControls.ucTinHieuDo();
      this.tinHieuCanSiloAGG3 = new NhuaNong.UserControls.ucTinHieuDo();
      this.tinHieuCanSiloAGG2 = new NhuaNong.UserControls.ucTinHieuDo();
      this.tinHieuCanSiloAGG1 = new NhuaNong.UserControls.ucTinHieuDo();
      this.tinHieuCanSiloFD = new NhuaNong.UserControls.ucTinHieuDo();
      this.btnVanCanAGG5 = new NhuaNong.UserControls.ucBtnTron();
      this.btnVanCanAGG4 = new NhuaNong.UserControls.ucBtnTron();
      this.btnVanCanAGG3 = new NhuaNong.UserControls.ucBtnTron();
      this.btnVanCanAGG2 = new NhuaNong.UserControls.ucBtnTron();
      this.btnVanCanAGG1 = new NhuaNong.UserControls.ucBtnTron();
      this.btnVanCanFD = new NhuaNong.UserControls.ucBtnTron();
      this.ucOngDanFD1 = new NhuaNong.UserControls.ucOngDanFD();
      this.tinHieuXaCanAGG = new NhuaNong.UserControls.ucTinHieuXaCan();
      this.tinHieuXaCanFD = new NhuaNong.UserControls.ucTinHieuXaCan();
      this.slMeDaCanNoiTron = new NhuaNong.UserControls.ucSoMeDaCan();
      this.btnNoiTronR = new NhuaNong.UserControls.ucBtnNoiTron();
      this.btnNoiTronL = new NhuaNong.UserControls.ucBtnNoiTron();
      this.ucNoiTron1 = new NhuaNong.UserControls.ucNoiTron();
      this.grcMeTronCur = new DevExpress.XtraGrid.GridControl();
      this.grvMeTronCur = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.gcMaPhieuTron = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcSTTMeTron = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ggcNgayTron = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcGioTron = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcCongTruong = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcTenMAC = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcKhoiLuong = new DevExpress.XtraGrid.Columns.GridColumn();
      this.motorBomTuoiNhua = new NhuaNong.UserControls.ucMotorMini();
      this.ucOngDanSB2 = new NhuaNong.UserControls.ucOngDanSB();
      this.btnXaHetAGG = new NhuaNong.UserControls.ucBtnXAHETAGG();
      this.tinHieuBomTuoiNhua = new NhuaNong.UserControls.ucTinHieuXaCan();
      this.tinHieuXaCanSBS = new NhuaNong.UserControls.ucTinHieuXaCan();
      this.tinHieuCuaNoiMo = new NhuaNong.UserControls.ucTinHieuMoCuaNoi();
      this.tinHieuCuaNoiDong = new NhuaNong.UserControls.ucTinHieuDongCuaNoi();
      this.tinHieuXaCanAP = new NhuaNong.UserControls.ucTinHieuDo();
      this.btnDauDot = new NhuaNong.UserControls.ucTinHieuTanSayQuay();
      this.tinHieuCuaMo = new NhuaNong.UserControls.ucTinHieuXaCan();
      this.tinHieuCuaDong = new NhuaNong.UserControls.ucTinHieuXaCan();
      this.btnPheuSBS = new NhuaNong.UserControls.ucBtnXaCan();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
      this.groupControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieuTron.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtCongTruong.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtKhachHang.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtKhoiLuong.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtMAC.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gluHopDong.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.glueHopDong)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.glueBienSo.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gluTaiXe.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.VAA)).BeginInit();
      this.VAA.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTG_BomTuoiNhua.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grcMeTronCur)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grvMeTronCur)).BeginInit();
      this.SuspendLayout();
      // 
      // siloFD
      // 
      this.siloFD.DoAm = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloFD.DoHut = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloFD.KLCaiDat = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloFD.KLCanCan = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloFD.KLCanCan_Origin = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloFD.KLSaveThucTe = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloFD.KLTemp = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloFD.KLThucTe = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloFD.Location = new System.Drawing.Point(306, 192);
      this.siloFD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.siloFD.MaSilo = null;
      this.siloFD.MaterialID = null;
      this.siloFD.Name = "siloFD";
      this.siloFD.ShowSiloDesc = true;
      this.siloFD.SiloCaption = "SILO";
      this.siloFD.SiloDesc = "F/D";
      this.siloFD.Size = new System.Drawing.Size(80, 200);
      this.siloFD.TabIndex = 12;
      this.siloFD.CaptionClick += new NhuaNong.MasterData.UcBaseSilo2.DelCaptionEventHandler(this.siloFD_CaptionClick);
      // 
      // siloAgg1
      // 
      this.siloAgg1.DoAm = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg1.DoHut = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg1.KLCaiDat = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg1.KLCanCan = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg1.KLCanCan_Origin = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg1.KLSaveThucTe = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg1.KLTemp = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg1.KLThucTe = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg1.Location = new System.Drawing.Point(409, 192);
      this.siloAgg1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.siloAgg1.MaSilo = null;
      this.siloAgg1.MaterialID = null;
      this.siloAgg1.Name = "siloAgg1";
      this.siloAgg1.ShowSiloDesc = true;
      this.siloAgg1.SiloCaption = "SILO";
      this.siloAgg1.SiloDesc = "AGG1";
      this.siloAgg1.Size = new System.Drawing.Size(80, 200);
      this.siloAgg1.TabIndex = 14;
      this.siloAgg1.CaptionClick += new NhuaNong.MasterData.UcBaseSilo2.DelCaptionEventHandler(this.siloAgg1_CaptionClick);
      // 
      // siloAgg2
      // 
      this.siloAgg2.DoAm = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg2.DoHut = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg2.KLCaiDat = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg2.KLCanCan = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg2.KLCanCan_Origin = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg2.KLSaveThucTe = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg2.KLTemp = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg2.KLThucTe = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg2.Location = new System.Drawing.Point(495, 192);
      this.siloAgg2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.siloAgg2.MaSilo = null;
      this.siloAgg2.MaterialID = null;
      this.siloAgg2.Name = "siloAgg2";
      this.siloAgg2.ShowSiloDesc = true;
      this.siloAgg2.SiloCaption = "SILO";
      this.siloAgg2.SiloDesc = "AGG2";
      this.siloAgg2.Size = new System.Drawing.Size(80, 200);
      this.siloAgg2.TabIndex = 15;
      this.siloAgg2.CaptionClick += new NhuaNong.MasterData.UcBaseSilo2.DelCaptionEventHandler(this.siloAgg2_CaptionClick);
      // 
      // siloAgg3
      // 
      this.siloAgg3.DoAm = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg3.DoHut = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg3.KLCaiDat = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg3.KLCanCan = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg3.KLCanCan_Origin = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg3.KLSaveThucTe = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg3.KLTemp = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg3.KLThucTe = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg3.Location = new System.Drawing.Point(581, 192);
      this.siloAgg3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.siloAgg3.MaSilo = null;
      this.siloAgg3.MaterialID = null;
      this.siloAgg3.Name = "siloAgg3";
      this.siloAgg3.ShowSiloDesc = true;
      this.siloAgg3.SiloCaption = "SILO";
      this.siloAgg3.SiloDesc = "AGG3";
      this.siloAgg3.Size = new System.Drawing.Size(80, 200);
      this.siloAgg3.TabIndex = 16;
      this.siloAgg3.CaptionClick += new NhuaNong.MasterData.UcBaseSilo2.DelCaptionEventHandler(this.siloAgg3_CaptionClick);
      // 
      // siloAgg4
      // 
      this.siloAgg4.DoAm = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg4.DoHut = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg4.KLCaiDat = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg4.KLCanCan = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg4.KLCanCan_Origin = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg4.KLSaveThucTe = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg4.KLTemp = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg4.KLThucTe = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg4.Location = new System.Drawing.Point(667, 192);
      this.siloAgg4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.siloAgg4.MaSilo = null;
      this.siloAgg4.MaterialID = null;
      this.siloAgg4.Name = "siloAgg4";
      this.siloAgg4.ShowSiloDesc = true;
      this.siloAgg4.SiloCaption = "SILO";
      this.siloAgg4.SiloDesc = "AGG4";
      this.siloAgg4.Size = new System.Drawing.Size(80, 200);
      this.siloAgg4.TabIndex = 17;
      this.siloAgg4.CaptionClick += new NhuaNong.MasterData.UcBaseSilo2.DelCaptionEventHandler(this.siloAgg4_CaptionClick);
      // 
      // siloAgg5
      // 
      this.siloAgg5.DoAm = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg5.DoHut = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg5.KLCaiDat = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg5.KLCanCan = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg5.KLCanCan_Origin = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg5.KLSaveThucTe = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg5.KLTemp = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg5.KLThucTe = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAgg5.Location = new System.Drawing.Point(753, 192);
      this.siloAgg5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.siloAgg5.MaSilo = null;
      this.siloAgg5.MaterialID = null;
      this.siloAgg5.Name = "siloAgg5";
      this.siloAgg5.ShowSiloDesc = true;
      this.siloAgg5.SiloCaption = "SILO";
      this.siloAgg5.SiloDesc = "AGG5";
      this.siloAgg5.Size = new System.Drawing.Size(80, 200);
      this.siloAgg5.TabIndex = 18;
      this.siloAgg5.CaptionClick += new NhuaNong.MasterData.UcBaseSilo2.DelCaptionEventHandler(this.siloAgg5_CaptionClick);
      // 
      // barFullSiloAGG1
      // 
      this.barFullSiloAGG1.BackColor = System.Drawing.Color.Red;
      this.barFullSiloAGG1.IsOn = false;
      this.barFullSiloAGG1.IsTrangThai = NhuaNong.UserControls.ucTinHieuBaoDay.TrangThai.Run;
      this.barFullSiloAGG1.Location = new System.Drawing.Point(420, 196);
      this.barFullSiloAGG1.Name = "barFullSiloAGG1";
      this.barFullSiloAGG1.Size = new System.Drawing.Size(60, 10);
      this.barFullSiloAGG1.TabIndex = 38;
      // 
      // barFullSiloAGG2
      // 
      this.barFullSiloAGG2.BackColor = System.Drawing.Color.Red;
      this.barFullSiloAGG2.IsOn = false;
      this.barFullSiloAGG2.IsTrangThai = NhuaNong.UserControls.ucTinHieuBaoDay.TrangThai.Run;
      this.barFullSiloAGG2.Location = new System.Drawing.Point(506, 196);
      this.barFullSiloAGG2.Name = "barFullSiloAGG2";
      this.barFullSiloAGG2.Size = new System.Drawing.Size(60, 10);
      this.barFullSiloAGG2.TabIndex = 39;
      // 
      // barFullSiloAGG3
      // 
      this.barFullSiloAGG3.BackColor = System.Drawing.Color.Red;
      this.barFullSiloAGG3.IsOn = false;
      this.barFullSiloAGG3.IsTrangThai = NhuaNong.UserControls.ucTinHieuBaoDay.TrangThai.Run;
      this.barFullSiloAGG3.Location = new System.Drawing.Point(590, 196);
      this.barFullSiloAGG3.Name = "barFullSiloAGG3";
      this.barFullSiloAGG3.Size = new System.Drawing.Size(60, 10);
      this.barFullSiloAGG3.TabIndex = 40;
      // 
      // barFullSiloAGG4
      // 
      this.barFullSiloAGG4.BackColor = System.Drawing.Color.Red;
      this.barFullSiloAGG4.IsOn = false;
      this.barFullSiloAGG4.IsTrangThai = NhuaNong.UserControls.ucTinHieuBaoDay.TrangThai.Run;
      this.barFullSiloAGG4.Location = new System.Drawing.Point(676, 196);
      this.barFullSiloAGG4.Name = "barFullSiloAGG4";
      this.barFullSiloAGG4.Size = new System.Drawing.Size(60, 10);
      this.barFullSiloAGG4.TabIndex = 41;
      // 
      // barFullSiloAGG5
      // 
      this.barFullSiloAGG5.BackColor = System.Drawing.Color.Red;
      this.barFullSiloAGG5.IsOn = false;
      this.barFullSiloAGG5.IsTrangThai = NhuaNong.UserControls.ucTinHieuBaoDay.TrangThai.Run;
      this.barFullSiloAGG5.Location = new System.Drawing.Point(761, 196);
      this.barFullSiloAGG5.Name = "barFullSiloAGG5";
      this.barFullSiloAGG5.Size = new System.Drawing.Size(60, 10);
      this.barFullSiloAGG5.TabIndex = 42;
      // 
      // weighFD
      // 
      this.weighFD.GiaTriWeight = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.weighFD.Location = new System.Drawing.Point(306, 428);
      this.weighFD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.weighFD.Name = "weighFD";
      this.weighFD.Size = new System.Drawing.Size(80, 78);
      this.weighFD.TabIndex = 46;
      this.weighFD.Weight = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.weighFD.WeightClick += new NhuaNong.UserControls.ucBaseWeight.DelCaptionEventHandler(this.weighFD_WeightClick);
      // 
      // weighAGG1 - Phễu cân độc lập cho AGG1
      // 
      this.weighAGG1.GiaTriWeight = new decimal(new int[] { 0, 0, 0, 0 });
      this.weighAGG1.Location = new System.Drawing.Point(409, 428);
      this.weighAGG1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.weighAGG1.Name = "weighAGG1";
      this.weighAGG1.Size = new System.Drawing.Size(80, 78);
      this.weighAGG1.TabIndex = 200;
      this.weighAGG1.Weight = new decimal(new int[] { 0, 0, 0, 0 });
      // 
      // weighAGG2 - Phễu cân độc lập cho AGG2
      // 
      this.weighAGG2.GiaTriWeight = new decimal(new int[] { 0, 0, 0, 0 });
      this.weighAGG2.Location = new System.Drawing.Point(495, 428);
      this.weighAGG2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.weighAGG2.Name = "weighAGG2";
      this.weighAGG2.Size = new System.Drawing.Size(80, 78);
      this.weighAGG2.TabIndex = 201;
      this.weighAGG2.Weight = new decimal(new int[] { 0, 0, 0, 0 });
      // 
      // weighAGG3 - Phễu cân độc lập cho AGG3
      // 
      this.weighAGG3.GiaTriWeight = new decimal(new int[] { 0, 0, 0, 0 });
      this.weighAGG3.Location = new System.Drawing.Point(581, 428);
      this.weighAGG3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.weighAGG3.Name = "weighAGG3";
      this.weighAGG3.Size = new System.Drawing.Size(80, 78);
      this.weighAGG3.TabIndex = 202;
      this.weighAGG3.Weight = new decimal(new int[] { 0, 0, 0, 0 });
      // 
      // weighAGG4 - Phễu cân độc lập cho AGG4
      // 
      this.weighAGG4.GiaTriWeight = new decimal(new int[] { 0, 0, 0, 0 });
      this.weighAGG4.Location = new System.Drawing.Point(667, 428);
      this.weighAGG4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.weighAGG4.Name = "weighAGG4";
      this.weighAGG4.Size = new System.Drawing.Size(80, 78);
      this.weighAGG4.TabIndex = 203;
      this.weighAGG4.Weight = new decimal(new int[] { 0, 0, 0, 0 });
      // 
      // weighAGG5 - Phễu cân độc lập cho AGG5
      // 
      this.weighAGG5.GiaTriWeight = new decimal(new int[] { 0, 0, 0, 0 });
      this.weighAGG5.Location = new System.Drawing.Point(753, 428);
      this.weighAGG5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.weighAGG5.Name = "weighAGG5";
      this.weighAGG5.Size = new System.Drawing.Size(80, 78);
      this.weighAGG5.TabIndex = 204;
      this.weighAGG5.Weight = new decimal(new int[] { 0, 0, 0, 0 });
      // 
      // weighAP
      // 
      this.weighAP.GiaTriWeight = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.weighAP.Location = new System.Drawing.Point(867, 428);
      this.weighAP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.weighAP.Name = "weighAP";
      this.weighAP.Size = new System.Drawing.Size(80, 78);
      this.weighAP.TabIndex = 48;
      this.weighAP.Weight = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.weighAP.WeightClick += new NhuaNong.UserControls.ucBaseWeight.DelCaptionEventHandler(this.weighAP_WeightClick);
      // 
      // weighSBS
      // 
      this.weighSBS.GiaTriWeight = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.weighSBS.Location = new System.Drawing.Point(980, 428);
      this.weighSBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.weighSBS.Name = "weighSBS";
      this.weighSBS.Size = new System.Drawing.Size(80, 78);
      this.weighSBS.TabIndex = 49;
      this.weighSBS.Weight = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.weighSBS.WeightClick += new NhuaNong.UserControls.ucBaseWeight.DelCaptionEventHandler(this.weighSBS_WeightClick);
      // 
      // btnXaCanFD
      // 
      this.btnXaCanFD.BackColor = System.Drawing.Color.DarkGray;
      this.btnXaCanFD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnXaCanFD.BGColor = NhuaNong.UserControls.ucBtnXaCan.BGColorEnum.Gray;
      this.btnXaCanFD.IsOn = true;
      this.btnXaCanFD.IsRun = false;
      this.btnXaCanFD.IsTrangThai = NhuaNong.UserControls.ucBtnXaCan.TrangThai.Stop;
      this.btnXaCanFD.Location = new System.Drawing.Point(327, 489);
      this.btnXaCanFD.Name = "btnXaCanFD";
      this.btnXaCanFD.Size = new System.Drawing.Size(40, 18);
      this.btnXaCanFD.TabIndex = 50;
      this.btnXaCanFD.ButtonClick += new NhuaNong.UserControls.ucBtnXaCan.DelButtonEventHandler(this.btnXaCanFD_ButtonClick);
      // 
      // btnXaCanAP
      // 
      this.btnXaCanAP.BackColor = System.Drawing.Color.DarkGray;
      this.btnXaCanAP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnXaCanAP.BGColor = NhuaNong.UserControls.ucBtnXaCan.BGColorEnum.Gray;
      this.btnXaCanAP.IsOn = true;
      this.btnXaCanAP.IsRun = false;
      this.btnXaCanAP.IsTrangThai = NhuaNong.UserControls.ucBtnXaCan.TrangThai.Stop;
      this.btnXaCanAP.Location = new System.Drawing.Point(889, 489);
      this.btnXaCanAP.Name = "btnXaCanAP";
      this.btnXaCanAP.Size = new System.Drawing.Size(40, 18);
      this.btnXaCanAP.TabIndex = 51;
      this.btnXaCanAP.ButtonClick += new NhuaNong.UserControls.ucBtnXaCan.DelButtonEventHandler(this.btnXaCanAP_ButtonClick);
      // 
      // btnXaCanAGG
      // 
      this.btnXaCanAGG.BackColor = System.Drawing.Color.DarkGray;
      this.btnXaCanAGG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnXaCanAGG.BGColor = NhuaNong.UserControls.ucBtnXaCan.BGColorEnum.Gray;
      this.btnXaCanAGG.IsOn = true;
      this.btnXaCanAGG.IsRun = false;
      this.btnXaCanAGG.IsTrangThai = NhuaNong.UserControls.ucBtnXaCan.TrangThai.Stop;
      this.btnXaCanAGG.Location = new System.Drawing.Point(598, 489);
      this.btnXaCanAGG.Name = "btnXaCanAGG";
      this.btnXaCanAGG.Size = new System.Drawing.Size(52, 18);
      this.btnXaCanAGG.TabIndex = 52;
      this.btnXaCanAGG.ButtonClick += new NhuaNong.UserControls.ucBtnXaCan.DelButtonEventHandler(this.btnXaCanAGG_ButtonClick);
      // 
      // btnXaCanSBS
      // 
      this.btnXaCanSBS.BackColor = System.Drawing.Color.DarkGray;
      this.btnXaCanSBS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnXaCanSBS.BGColor = NhuaNong.UserControls.ucBtnXaCan.BGColorEnum.Gray;
      this.btnXaCanSBS.IsOn = true;
      this.btnXaCanSBS.IsRun = false;
      this.btnXaCanSBS.IsTrangThai = NhuaNong.UserControls.ucBtnXaCan.TrangThai.Stop;
      this.btnXaCanSBS.Location = new System.Drawing.Point(1001, 489);
      this.btnXaCanSBS.Name = "btnXaCanSBS";
      this.btnXaCanSBS.Size = new System.Drawing.Size(40, 18);
      this.btnXaCanSBS.TabIndex = 53;
      this.btnXaCanSBS.ButtonClick += new NhuaNong.UserControls.ucBtnXaCan.DelButtonEventHandler(this.btnXaCanSBS_ButtonClick);
      // 
      // lblHeThong
      // 
      this.lblHeThong.BackColor = System.Drawing.Color.Transparent;
      this.lblHeThong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblHeThong.Location = new System.Drawing.Point(444, 793);
      this.lblHeThong.Name = "lblHeThong";
      this.lblHeThong.Size = new System.Drawing.Size(97, 23);
      this.lblHeThong.TabIndex = 68;
      this.lblHeThong.Text = "HỆ THỐNG";
      this.lblHeThong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(660, 793);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(97, 23);
      this.label1.TabIndex = 69;
      this.label1.Text = "NẠP LIỆU";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(763, 793);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(97, 23);
      this.label2.TabIndex = 70;
      this.label2.Text = "CỬA NỒI";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // groupBox1
      // 
      this.groupBox1.BackColor = System.Drawing.Color.White;
      this.groupBox1.Controls.Add(this.txtNhietDoNhua);
      this.groupBox1.Controls.Add(this.txtNhietDoTanSay);
      this.groupBox1.Controls.Add(this.txtNhietDoAGG);
      this.groupBox1.Controls.Add(this.txtNhietDoTuiLocKho);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(1650, 9);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(258, 127);
      this.groupBox1.TabIndex = 90;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "THÔNG SỐ NHIỆT ĐỘ";
      // 
      // txtNhietDoNhua
      // 
      this.txtNhietDoNhua.BackColor = System.Drawing.Color.Black;
      this.txtNhietDoNhua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtNhietDoNhua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNhietDoNhua.ForeColor = System.Drawing.Color.Red;
      this.txtNhietDoNhua.Location = new System.Drawing.Point(152, 98);
      this.txtNhietDoNhua.Name = "txtNhietDoNhua";
      this.txtNhietDoNhua.ReadOnly = true;
      this.txtNhietDoNhua.Size = new System.Drawing.Size(100, 22);
      this.txtNhietDoNhua.TabIndex = 7;
      this.txtNhietDoNhua.Text = "30";
      this.txtNhietDoNhua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // txtNhietDoTanSay
      // 
      this.txtNhietDoTanSay.BackColor = System.Drawing.Color.Black;
      this.txtNhietDoTanSay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtNhietDoTanSay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNhietDoTanSay.ForeColor = System.Drawing.Color.Red;
      this.txtNhietDoTanSay.Location = new System.Drawing.Point(152, 73);
      this.txtNhietDoTanSay.Name = "txtNhietDoTanSay";
      this.txtNhietDoTanSay.ReadOnly = true;
      this.txtNhietDoTanSay.Size = new System.Drawing.Size(100, 22);
      this.txtNhietDoTanSay.TabIndex = 6;
      this.txtNhietDoTanSay.Text = "30";
      this.txtNhietDoTanSay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // txtNhietDoAGG
      // 
      this.txtNhietDoAGG.BackColor = System.Drawing.Color.Black;
      this.txtNhietDoAGG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtNhietDoAGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNhietDoAGG.ForeColor = System.Drawing.Color.Red;
      this.txtNhietDoAGG.Location = new System.Drawing.Point(152, 48);
      this.txtNhietDoAGG.Name = "txtNhietDoAGG";
      this.txtNhietDoAGG.ReadOnly = true;
      this.txtNhietDoAGG.Size = new System.Drawing.Size(100, 22);
      this.txtNhietDoAGG.TabIndex = 5;
      this.txtNhietDoAGG.Text = "30";
      this.txtNhietDoAGG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // txtNhietDoTuiLocKho
      // 
      this.txtNhietDoTuiLocKho.BackColor = System.Drawing.Color.Black;
      this.txtNhietDoTuiLocKho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtNhietDoTuiLocKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNhietDoTuiLocKho.ForeColor = System.Drawing.Color.Red;
      this.txtNhietDoTuiLocKho.Location = new System.Drawing.Point(152, 23);
      this.txtNhietDoTuiLocKho.Name = "txtNhietDoTuiLocKho";
      this.txtNhietDoTuiLocKho.ReadOnly = true;
      this.txtNhietDoTuiLocKho.Size = new System.Drawing.Size(100, 22);
      this.txtNhietDoTuiLocKho.TabIndex = 4;
      this.txtNhietDoTuiLocKho.Text = "30";
      this.txtNhietDoTuiLocKho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(32, 100);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(50, 16);
      this.label6.TabIndex = 3;
      this.label6.Text = "NHỰA";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(32, 75);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(72, 16);
      this.label5.TabIndex = 2;
      this.label5.Text = "TAN SẤY";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(32, 50);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(39, 16);
      this.label4.TabIndex = 1;
      this.label4.Text = "AGG";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(32, 25);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(100, 16);
      this.label3.TabIndex = 0;
      this.label3.Text = "TÚI LỌC KHÔ";
      // 
      // btnXaCanAGG1
      // 
      this.btnXaCanAGG1.BackColor = System.Drawing.Color.DarkGray;
      this.btnXaCanAGG1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnXaCanAGG1.BGColor = NhuaNong.UserControls.ucBtnXaCan.BGColorEnum.Gray;
      this.btnXaCanAGG1.IsOn = true;
      this.btnXaCanAGG1.IsRun = false;
      this.btnXaCanAGG1.IsTrangThai = NhuaNong.UserControls.ucBtnXaCan.TrangThai.Stop;
      this.btnXaCanAGG1.Location = new System.Drawing.Point(1488, 686);
      this.btnXaCanAGG1.Name = "btnXaCanAGG1";
      this.btnXaCanAGG1.Size = new System.Drawing.Size(40, 18);
      this.btnXaCanAGG1.TabIndex = 96;
      this.btnXaCanAGG1.ButtonClick += new NhuaNong.UserControls.ucBtnXaCan.DelButtonEventHandler(this.btnXaCanAGG1_ButtonClick);
      // 
      // btnXaCanAGG2
      // 
      this.btnXaCanAGG2.BackColor = System.Drawing.Color.DarkGray;
      this.btnXaCanAGG2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnXaCanAGG2.BGColor = NhuaNong.UserControls.ucBtnXaCan.BGColorEnum.Gray;
      this.btnXaCanAGG2.IsOn = true;
      this.btnXaCanAGG2.IsRun = false;
      this.btnXaCanAGG2.IsTrangThai = NhuaNong.UserControls.ucBtnXaCan.TrangThai.Stop;
      this.btnXaCanAGG2.Location = new System.Drawing.Point(1568, 686);
      this.btnXaCanAGG2.Name = "btnXaCanAGG2";
      this.btnXaCanAGG2.Size = new System.Drawing.Size(40, 18);
      this.btnXaCanAGG2.TabIndex = 97;
      this.btnXaCanAGG2.ButtonClick += new NhuaNong.UserControls.ucBtnXaCan.DelButtonEventHandler(this.btnXaCanAGG2_ButtonClick);
      // 
      // btnXaCanAGG3
      // 
      this.btnXaCanAGG3.BackColor = System.Drawing.Color.DarkGray;
      this.btnXaCanAGG3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnXaCanAGG3.BGColor = NhuaNong.UserControls.ucBtnXaCan.BGColorEnum.Gray;
      this.btnXaCanAGG3.IsOn = true;
      this.btnXaCanAGG3.IsRun = false;
      this.btnXaCanAGG3.IsTrangThai = NhuaNong.UserControls.ucBtnXaCan.TrangThai.Stop;
      this.btnXaCanAGG3.Location = new System.Drawing.Point(1649, 686);
      this.btnXaCanAGG3.Name = "btnXaCanAGG3";
      this.btnXaCanAGG3.Size = new System.Drawing.Size(40, 18);
      this.btnXaCanAGG3.TabIndex = 98;
      this.btnXaCanAGG3.ButtonClick += new NhuaNong.UserControls.ucBtnXaCan.DelButtonEventHandler(this.btnXaCanAGG3_ButtonClick);
      // 
      // btnXaCanAGG4
      // 
      this.btnXaCanAGG4.BackColor = System.Drawing.Color.DarkGray;
      this.btnXaCanAGG4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnXaCanAGG4.BGColor = NhuaNong.UserControls.ucBtnXaCan.BGColorEnum.Gray;
      this.btnXaCanAGG4.IsOn = true;
      this.btnXaCanAGG4.IsRun = false;
      this.btnXaCanAGG4.IsTrangThai = NhuaNong.UserControls.ucBtnXaCan.TrangThai.Stop;
      this.btnXaCanAGG4.Location = new System.Drawing.Point(1730, 686);
      this.btnXaCanAGG4.Name = "btnXaCanAGG4";
      this.btnXaCanAGG4.Size = new System.Drawing.Size(40, 18);
      this.btnXaCanAGG4.TabIndex = 99;
      this.btnXaCanAGG4.ButtonClick += new NhuaNong.UserControls.ucBtnXaCan.DelButtonEventHandler(this.btnXaCanAGG4_ButtonClick);
      // 
      // btnXaCanAGG5
      // 
      this.btnXaCanAGG5.BackColor = System.Drawing.Color.DarkGray;
      this.btnXaCanAGG5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnXaCanAGG5.BGColor = NhuaNong.UserControls.ucBtnXaCan.BGColorEnum.Gray;
      this.btnXaCanAGG5.IsOn = true;
      this.btnXaCanAGG5.IsRun = false;
      this.btnXaCanAGG5.IsTrangThai = NhuaNong.UserControls.ucBtnXaCan.TrangThai.Stop;
      this.btnXaCanAGG5.Location = new System.Drawing.Point(1811, 686);
      this.btnXaCanAGG5.Name = "btnXaCanAGG5";
      this.btnXaCanAGG5.Size = new System.Drawing.Size(40, 18);
      this.btnXaCanAGG5.TabIndex = 100;
      this.btnXaCanAGG5.ButtonClick += new NhuaNong.UserControls.ucBtnXaCan.DelButtonEventHandler(this.btnXaCanAGG5_ButtonClick);
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // connectStus
      // 
      this.connectStus.AutoSize = true;
      this.connectStus.Location = new System.Drawing.Point(1003, 850);
      this.connectStus.Name = "connectStus";
      this.connectStus.Size = new System.Drawing.Size(35, 13);
      this.connectStus.TabIndex = 112;
      this.connectStus.Text = "label7";
      this.connectStus.Visible = false;
      // 
      // siloAP
      // 
      this.siloAP.DoAm = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAP.DoHut = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAP.KLCaiDat = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAP.KLCanCan = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAP.KLCanCan_Origin = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAP.KLSaveThucTe = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAP.KLTemp = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAP.KLThucTe = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloAP.Location = new System.Drawing.Point(867, 192);
      this.siloAP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.siloAP.MaSilo = null;
      this.siloAP.MaterialID = null;
      this.siloAP.Name = "siloAP";
      this.siloAP.ShowSiloDesc = true;
      this.siloAP.SiloCaption = "SILO";
      this.siloAP.SiloDesc = "AP";
      this.siloAP.Size = new System.Drawing.Size(80, 200);
      this.siloAP.TabIndex = 125;
      this.siloAP.CaptionClick += new NhuaNong.MasterData.UcBaseSilo2.DelCaptionEventHandler(this.siloAP_CaptionClick);
      // 
      // siloSBS
      // 
      this.siloSBS.DoAm = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloSBS.DoHut = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloSBS.KLCaiDat = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloSBS.KLCanCan = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloSBS.KLCanCan_Origin = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloSBS.KLSaveThucTe = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloSBS.KLTemp = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloSBS.KLThucTe = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.siloSBS.Location = new System.Drawing.Point(980, 192);
      this.siloSBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.siloSBS.MaSilo = null;
      this.siloSBS.MaterialID = null;
      this.siloSBS.Name = "siloSBS";
      this.siloSBS.ShowSiloDesc = true;
      this.siloSBS.SiloCaption = "SILO";
      this.siloSBS.SiloDesc = "SBS";
      this.siloSBS.Size = new System.Drawing.Size(80, 200);
      this.siloSBS.TabIndex = 128;
      this.siloSBS.CaptionClick += new NhuaNong.MasterData.UcBaseSilo2.DelCaptionEventHandler(this.siloSBS_CaptionClick);
      // 
      // barFullSiloSBS
      // 
      this.barFullSiloSBS.BackColor = System.Drawing.Color.Red;
      this.barFullSiloSBS.IsOn = false;
      this.barFullSiloSBS.IsTrangThai = NhuaNong.UserControls.ucTinHieuBaoDay.TrangThai.Run;
      this.barFullSiloSBS.Location = new System.Drawing.Point(988, 196);
      this.barFullSiloSBS.Name = "barFullSiloSBS";
      this.barFullSiloSBS.Size = new System.Drawing.Size(60, 10);
      this.barFullSiloSBS.TabIndex = 130;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(1528, 187);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(77, 20);
      this.label7.TabIndex = 134;
      this.label7.Text = "Nhập kho";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(1528, 244);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(66, 20);
      this.label8.TabIndex = 137;
      this.label8.Text = "Tồn kho";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(897, 579);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(112, 16);
      this.label11.TabIndex = 143;
      this.label11.Text = "TG BƠM NHỰA";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(25, 9);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(96, 16);
      this.label12.TabIndex = 150;
      this.label12.Text = "THÔNG BÁO";
      // 
      // tinHieuBaoMucThapFD
      // 
      this.tinHieuBaoMucThapFD.BackColor = System.Drawing.Color.Red;
      this.tinHieuBaoMucThapFD.IsOn = false;
      this.tinHieuBaoMucThapFD.IsTrangThai = NhuaNong.UserControls.ucTinHieuBaoDay.TrangThai.Run;
      this.tinHieuBaoMucThapFD.Location = new System.Drawing.Point(57, 570);
      this.tinHieuBaoMucThapFD.Name = "tinHieuBaoMucThapFD";
      this.tinHieuBaoMucThapFD.Size = new System.Drawing.Size(80, 15);
      this.tinHieuBaoMucThapFD.TabIndex = 159;
      // 
      // tinHieuBaoMucCaoFD
      // 
      this.tinHieuBaoMucCaoFD.BackColor = System.Drawing.Color.Red;
      this.tinHieuBaoMucCaoFD.IsOn = false;
      this.tinHieuBaoMucCaoFD.IsTrangThai = NhuaNong.UserControls.ucTinHieuBaoDay.TrangThai.Run;
      this.tinHieuBaoMucCaoFD.Location = new System.Drawing.Point(57, 200);
      this.tinHieuBaoMucCaoFD.Name = "tinHieuBaoMucCaoFD";
      this.tinHieuBaoMucCaoFD.Size = new System.Drawing.Size(80, 15);
      this.tinHieuBaoMucCaoFD.TabIndex = 158;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.BackColor = System.Drawing.Color.Transparent;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(61, 282);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(77, 20);
      this.label10.TabIndex = 156;
      this.label10.Text = "Nhập kho";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.BackColor = System.Drawing.Color.Transparent;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(61, 447);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(66, 20);
      this.label9.TabIndex = 154;
      this.label9.Text = "Tồn kho";
      // 
      // slMeDaCanFD
      // 
      this.slMeDaCanFD.Location = new System.Drawing.Point(268, 487);
      this.slMeDaCanFD.Name = "slMeDaCanFD";
      this.slMeDaCanFD.Size = new System.Drawing.Size(57, 20);
      this.slMeDaCanFD.SoLuongMeCanTron = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.slMeDaCanFD.SoLuongMeDaTron = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.slMeDaCanFD.TabIndex = 161;
      // 
      // slMeDaCanAGG
      // 
      this.slMeDaCanAGG.Location = new System.Drawing.Point(526, 488);
      this.slMeDaCanAGG.Name = "slMeDaCanAGG";
      this.slMeDaCanAGG.Size = new System.Drawing.Size(57, 20);
      this.slMeDaCanAGG.SoLuongMeCanTron = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.slMeDaCanAGG.SoLuongMeDaTron = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.slMeDaCanAGG.TabIndex = 162;
      // 
      // slMeDaCanAP
      // 
      this.slMeDaCanAP.Location = new System.Drawing.Point(829, 487);
      this.slMeDaCanAP.Name = "slMeDaCanAP";
      this.slMeDaCanAP.Size = new System.Drawing.Size(57, 20);
      this.slMeDaCanAP.SoLuongMeCanTron = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.slMeDaCanAP.SoLuongMeDaTron = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.slMeDaCanAP.TabIndex = 163;
      // 
      // slMeDaCanSBS
      // 
      this.slMeDaCanSBS.Location = new System.Drawing.Point(941, 488);
      this.slMeDaCanSBS.Name = "slMeDaCanSBS";
      this.slMeDaCanSBS.Size = new System.Drawing.Size(57, 20);
      this.slMeDaCanSBS.SoLuongMeCanTron = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.slMeDaCanSBS.SoLuongMeDaTron = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.slMeDaCanSBS.TabIndex = 164;
      // 
      // barFullSiloFD
      // 
      this.barFullSiloFD.BackColor = System.Drawing.Color.Red;
      this.barFullSiloFD.IsOn = false;
      this.barFullSiloFD.IsTrangThai = NhuaNong.UserControls.ucTinHieuBaoDay.TrangThai.Run;
      this.barFullSiloFD.Location = new System.Drawing.Point(317, 196);
      this.barFullSiloFD.Name = "barFullSiloFD";
      this.barFullSiloFD.Size = new System.Drawing.Size(60, 10);
      this.barFullSiloFD.TabIndex = 167;
      // 
      // lblMAC
      // 
      this.lblMAC.AutoSize = true;
      this.lblMAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblMAC.Location = new System.Drawing.Point(1372, 845);
      this.lblMAC.Name = "lblMAC";
      this.lblMAC.Size = new System.Drawing.Size(93, 20);
      this.lblMAC.TabIndex = 185;
      this.lblMAC.Text = "MACName";
      this.lblMAC.Visible = false;
      // 
      // checkDaat
      // 
      this.checkDaat.AutoSize = true;
      this.checkDaat.Location = new System.Drawing.Point(1143, 850);
      this.checkDaat.Name = "checkDaat";
      this.checkDaat.Size = new System.Drawing.Size(35, 13);
      this.checkDaat.TabIndex = 186;
      this.checkDaat.Text = "label7";
      this.checkDaat.Visible = false;
      // 
      // lblNameCty
      // 
      this.lblNameCty.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNameCty.Appearance.ForeColor = System.Drawing.Color.Red;
      this.lblNameCty.Appearance.Options.UseFont = true;
      this.lblNameCty.Appearance.Options.UseForeColor = true;
      this.lblNameCty.Appearance.Options.UseTextOptions = true;
      this.lblNameCty.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.lblNameCty.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.lblNameCty.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.lblNameCty.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
      this.lblNameCty.Location = new System.Drawing.Point(14, 5);
      this.lblNameCty.Name = "lblNameCty";
      this.lblNameCty.Size = new System.Drawing.Size(400, 24);
      this.lblNameCty.TabIndex = 192;
      this.lblNameCty.Text = "HỆ THỐNG ĐIỀU KHIỂN  SMART AP";
      // 
      // lblDec
      // 
      this.lblDec.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDec.Appearance.ForeColor = System.Drawing.Color.LightSeaGreen;
      this.lblDec.Appearance.Options.UseFont = true;
      this.lblDec.Appearance.Options.UseForeColor = true;
      this.lblDec.Appearance.Options.UseTextOptions = true;
      this.lblDec.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.lblDec.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.lblDec.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.lblDec.Location = new System.Drawing.Point(14, 30);
      this.lblDec.Name = "lblDec";
      this.lblDec.Size = new System.Drawing.Size(400, 20);
      this.lblDec.TabIndex = 193;
      this.lblDec.Text = "(DESIGNED by VIET DUC GREEN TECHNOLOGY CO., LTD)";
      // 
      // label13
      // 
      this.label13.BackColor = System.Drawing.Color.Transparent;
      this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label13.Location = new System.Drawing.Point(554, 793);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(97, 23);
      this.label13.TabIndex = 196;
      this.label13.Text = "XẢ CÂN";
      this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblDLT
      // 
      this.lblDLT.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDLT.Appearance.Options.UseFont = true;
      this.lblDLT.Location = new System.Drawing.Point(10, 34);
      this.lblDLT.Name = "lblDLT";
      this.lblDLT.Size = new System.Drawing.Size(94, 16);
      this.lblDLT.TabIndex = 198;
      this.lblDLT.Text = "DỮ LIỆU TRỘN";
      // 
      // labelControl3
      // 
      this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Location = new System.Drawing.Point(10, 338);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(45, 16);
      this.labelControl3.TabIndex = 199;
      this.labelControl3.Text = "TÀI XẾ";
      // 
      // labelControl4
      // 
      this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelControl4.Appearance.Options.UseFont = true;
      this.labelControl4.Location = new System.Drawing.Point(10, 390);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new System.Drawing.Size(57, 16);
      this.labelControl4.TabIndex = 201;
      this.labelControl4.Text = "BIỂN SỐ";
      // 
      // groupControl1
      // 
      this.groupControl1.Controls.Add(this.txtMaPhieuTron);
      this.groupControl1.Controls.Add(this.labelControl9);
      this.groupControl1.Controls.Add(this.txtCongTruong);
      this.groupControl1.Controls.Add(this.labelControl8);
      this.groupControl1.Controls.Add(this.txtKhachHang);
      this.groupControl1.Controls.Add(this.labelControl7);
      this.groupControl1.Controls.Add(this.txtKhoiLuong);
      this.groupControl1.Controls.Add(this.labelControl6);
      this.groupControl1.Controls.Add(this.txtMAC);
      this.groupControl1.Controls.Add(this.labelControl5);
      this.groupControl1.Controls.Add(this.gluHopDong);
      this.groupControl1.Controls.Add(this.glueBienSo);
      this.groupControl1.Controls.Add(this.labelControl4);
      this.groupControl1.Controls.Add(this.lblDLT);
      this.groupControl1.Controls.Add(this.gluTaiXe);
      this.groupControl1.Controls.Add(this.labelControl3);
      this.groupControl1.Location = new System.Drawing.Point(1650, 146);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.Size = new System.Drawing.Size(258, 449);
      this.groupControl1.TabIndex = 203;
      this.groupControl1.Text = "THÔNG TIN DỮ LIỆU TRỘN";
      // 
      // txtMaPhieuTron
      // 
      this.txtMaPhieuTron.Location = new System.Drawing.Point(35, 109);
      this.txtMaPhieuTron.Name = "txtMaPhieuTron";
      this.txtMaPhieuTron.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMaPhieuTron.Properties.Appearance.Options.UseFont = true;
      this.txtMaPhieuTron.Properties.ReadOnly = true;
      this.txtMaPhieuTron.Size = new System.Drawing.Size(215, 22);
      this.txtMaPhieuTron.TabIndex = 212;
      // 
      // labelControl9
      // 
      this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelControl9.Appearance.Options.UseFont = true;
      this.labelControl9.Location = new System.Drawing.Point(10, 87);
      this.labelControl9.Name = "labelControl9";
      this.labelControl9.Size = new System.Drawing.Size(106, 16);
      this.labelControl9.TabIndex = 211;
      this.labelControl9.Text = "MÃ PHIẾU TRỘN";
      // 
      // txtCongTruong
      // 
      this.txtCongTruong.Location = new System.Drawing.Point(35, 210);
      this.txtCongTruong.Name = "txtCongTruong";
      this.txtCongTruong.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtCongTruong.Properties.Appearance.Options.UseFont = true;
      this.txtCongTruong.Properties.ReadOnly = true;
      this.txtCongTruong.Size = new System.Drawing.Size(215, 22);
      this.txtCongTruong.TabIndex = 210;
      // 
      // labelControl8
      // 
      this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelControl8.Appearance.Options.UseFont = true;
      this.labelControl8.Location = new System.Drawing.Point(10, 188);
      this.labelControl8.Name = "labelControl8";
      this.labelControl8.Size = new System.Drawing.Size(101, 16);
      this.labelControl8.TabIndex = 209;
      this.labelControl8.Text = "CÔNG TRƯỜNG";
      // 
      // txtKhachHang
      // 
      this.txtKhachHang.Location = new System.Drawing.Point(35, 160);
      this.txtKhachHang.Name = "txtKhachHang";
      this.txtKhachHang.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtKhachHang.Properties.Appearance.Options.UseFont = true;
      this.txtKhachHang.Properties.ReadOnly = true;
      this.txtKhachHang.Size = new System.Drawing.Size(215, 22);
      this.txtKhachHang.TabIndex = 208;
      // 
      // labelControl7
      // 
      this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelControl7.Appearance.Options.UseFont = true;
      this.labelControl7.Location = new System.Drawing.Point(10, 138);
      this.labelControl7.Name = "labelControl7";
      this.labelControl7.Size = new System.Drawing.Size(88, 16);
      this.labelControl7.TabIndex = 207;
      this.labelControl7.Text = "KHÁCH HÀNG";
      // 
      // txtKhoiLuong
      // 
      this.txtKhoiLuong.Location = new System.Drawing.Point(36, 310);
      this.txtKhoiLuong.Name = "txtKhoiLuong";
      this.txtKhoiLuong.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtKhoiLuong.Properties.Appearance.Options.UseFont = true;
      this.txtKhoiLuong.Properties.ReadOnly = true;
      this.txtKhoiLuong.Size = new System.Drawing.Size(215, 22);
      this.txtKhoiLuong.TabIndex = 206;
      // 
      // labelControl6
      // 
      this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelControl6.Appearance.Options.UseFont = true;
      this.labelControl6.Location = new System.Drawing.Point(10, 288);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new System.Drawing.Size(81, 16);
      this.labelControl6.TabIndex = 205;
      this.labelControl6.Text = "KHỐI LƯỢNG";
      // 
      // txtMAC
      // 
      this.txtMAC.Location = new System.Drawing.Point(36, 260);
      this.txtMAC.Name = "txtMAC";
      this.txtMAC.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMAC.Properties.Appearance.Options.UseFont = true;
      this.txtMAC.Properties.ReadOnly = true;
      this.txtMAC.Size = new System.Drawing.Size(215, 22);
      this.txtMAC.TabIndex = 204;
      // 
      // labelControl5
      // 
      this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelControl5.Appearance.Options.UseFont = true;
      this.labelControl5.Location = new System.Drawing.Point(10, 238);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new System.Drawing.Size(29, 16);
      this.labelControl5.TabIndex = 203;
      this.labelControl5.Text = "MAC";
      // 
      // gluHopDong
      // 
      this.gluHopDong.EditValue = "";
      this.gluHopDong.Location = new System.Drawing.Point(36, 59);
      this.gluHopDong.Name = "gluHopDong";
      this.gluHopDong.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gluHopDong.Properties.Appearance.Options.UseFont = true;
      this.gluHopDong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, true, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Chỉnh sửa", null, null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
      this.gluHopDong.Properties.DisplayMember = "TenHopDong";
      this.gluHopDong.Properties.NullText = "";
      this.gluHopDong.Properties.PopupView = this.glueHopDong;
      this.gluHopDong.Properties.ValueMember = "DuLieuTronID";
      this.gluHopDong.Size = new System.Drawing.Size(217, 22);
      this.gluHopDong.TabIndex = 197;
      this.gluHopDong.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.gluHopDong_ButtonPressed);
      this.gluHopDong.EditValueChanged += new System.EventHandler(this.gluHopDong_EditValueChanged);
      // 
      // glueHopDong
      // 
      this.glueHopDong.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.glueHopDong.Appearance.CustomizationFormHint.Options.UseFont = true;
      this.glueHopDong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grcDuLieuTronID,
            this.grcMaHopDong,
            this.grcTenHopDong});
      this.glueHopDong.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.glueHopDong.Name = "glueHopDong";
      this.glueHopDong.OptionsEditForm.PopupEditFormWidth = 1200;
      this.glueHopDong.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.glueHopDong.OptionsView.ShowGroupPanel = false;
      this.glueHopDong.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.glueHopDong_PopupMenuShowing);
      // 
      // grcDuLieuTronID
      // 
      this.grcDuLieuTronID.Caption = "DuLieuTronID";
      this.grcDuLieuTronID.FieldName = "DuLieuTronID";
      this.grcDuLieuTronID.Name = "grcDuLieuTronID";
      // 
      // grcMaHopDong
      // 
      this.grcMaHopDong.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.grcMaHopDong.AppearanceCell.Options.UseFont = true;
      this.grcMaHopDong.Caption = "Mã Hợp Đồng";
      this.grcMaHopDong.FieldName = "MaHopDong";
      this.grcMaHopDong.MinWidth = 100;
      this.grcMaHopDong.Name = "grcMaHopDong";
      this.grcMaHopDong.Visible = true;
      this.grcMaHopDong.VisibleIndex = 0;
      this.grcMaHopDong.Width = 277;
      // 
      // grcTenHopDong
      // 
      this.grcTenHopDong.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.grcTenHopDong.AppearanceCell.Options.UseFont = true;
      this.grcTenHopDong.Caption = "Tên Hợp Đồng";
      this.grcTenHopDong.FieldName = "TenHopDong";
      this.grcTenHopDong.MinWidth = 100;
      this.grcTenHopDong.Name = "grcTenHopDong";
      this.grcTenHopDong.Visible = true;
      this.grcTenHopDong.VisibleIndex = 1;
      this.grcTenHopDong.Width = 500;
      // 
      // glueBienSo
      // 
      this.glueBienSo.EditValue = "";
      this.glueBienSo.Location = new System.Drawing.Point(35, 412);
      this.glueBienSo.Name = "glueBienSo";
      this.glueBienSo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.glueBienSo.Properties.Appearance.Options.UseFont = true;
      this.glueBienSo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.glueBienSo.Properties.DisplayMember = "BienSo";
      this.glueBienSo.Properties.NullText = "";
      this.glueBienSo.Properties.PopupView = this.gridView2;
      this.glueBienSo.Properties.ValueMember = "XeID";
      this.glueBienSo.Size = new System.Drawing.Size(216, 22);
      this.glueBienSo.TabIndex = 202;
      this.glueBienSo.EditValueChanged += new System.EventHandler(this.glueBienSo_EditValueChanged);
      // 
      // gridView2
      // 
      this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grcXeID,
            this.grcBienSo});
      this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView2.OptionsView.ShowGroupPanel = false;
      // 
      // grcXeID
      // 
      this.grcXeID.Caption = "XeID";
      this.grcXeID.FieldName = "XeID";
      this.grcXeID.Name = "grcXeID";
      // 
      // grcBienSo
      // 
      this.grcBienSo.Caption = "Biển Số";
      this.grcBienSo.FieldName = "BienSo";
      this.grcBienSo.Name = "grcBienSo";
      this.grcBienSo.Visible = true;
      this.grcBienSo.VisibleIndex = 0;
      // 
      // gluTaiXe
      // 
      this.gluTaiXe.EditValue = "";
      this.gluTaiXe.Location = new System.Drawing.Point(35, 360);
      this.gluTaiXe.Name = "gluTaiXe";
      this.gluTaiXe.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gluTaiXe.Properties.Appearance.Options.UseFont = true;
      this.gluTaiXe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.gluTaiXe.Properties.DisplayMember = "TenTaiXe";
      this.gluTaiXe.Properties.NullText = "";
      this.gluTaiXe.Properties.PopupView = this.gridView1;
      this.gluTaiXe.Properties.ValueMember = "TaiXeID";
      this.gluTaiXe.Size = new System.Drawing.Size(218, 22);
      this.gluTaiXe.TabIndex = 200;
      this.gluTaiXe.EditValueChanged += new System.EventHandler(this.gluTaiXe_EditValueChanged);
      // 
      // gridView1
      // 
      this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grcTaiXeID,
            this.grcMaTaiXe,
            this.grcTenTaiXe});
      this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView1.OptionsView.ShowGroupPanel = false;
      // 
      // grcTaiXeID
      // 
      this.grcTaiXeID.Caption = "TaiXeID";
      this.grcTaiXeID.FieldName = "TaiXeID";
      this.grcTaiXeID.Name = "grcTaiXeID";
      // 
      // grcMaTaiXe
      // 
      this.grcMaTaiXe.Caption = "Mã Tài Xế";
      this.grcMaTaiXe.FieldName = "MaTaiXe";
      this.grcMaTaiXe.Name = "grcMaTaiXe";
      this.grcMaTaiXe.Visible = true;
      this.grcMaTaiXe.VisibleIndex = 0;
      // 
      // grcTenTaiXe
      // 
      this.grcTenTaiXe.Caption = "Tên Tài Xế";
      this.grcTenTaiXe.FieldName = "TenTaiXe";
      this.grcTenTaiXe.Name = "grcTenTaiXe";
      this.grcTenTaiXe.Visible = true;
      this.grcTenTaiXe.VisibleIndex = 1;
      // 
      // VAA
      // 
      this.VAA.Appearance.BackColor = System.Drawing.Color.White;
      this.VAA.Appearance.Options.UseBackColor = true;
      this.VAA.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
      this.VAA.Controls.Add(this.lblPhone);
      this.VAA.Controls.Add(this.lblGmail);
      this.VAA.Controls.Add(this.lblNameCty);
      this.VAA.Controls.Add(this.lblDec);
      this.VAA.Location = new System.Drawing.Point(1217, 9);
      this.VAA.Name = "VAA";
      this.VAA.ShowCaption = false;
      this.VAA.Size = new System.Drawing.Size(427, 90);
      this.VAA.TabIndex = 204;
      this.VAA.Text = "groupControl2";
      // 
      // lblPhone
      // 
      this.lblPhone.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPhone.Appearance.ForeColor = System.Drawing.Color.Sienna;
      this.lblPhone.Appearance.Options.UseFont = true;
      this.lblPhone.Appearance.Options.UseForeColor = true;
      this.lblPhone.Appearance.Options.UseTextOptions = true;
      this.lblPhone.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.lblPhone.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.lblPhone.Location = new System.Drawing.Point(14, 67);
      this.lblPhone.Name = "lblPhone";
      this.lblPhone.Size = new System.Drawing.Size(400, 20);
      this.lblPhone.TabIndex = 195;
      this.lblPhone.Text = "Tel: 0913387319";
      // 
      // lblGmail
      // 
      this.lblGmail.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblGmail.Appearance.ForeColor = System.Drawing.Color.Black;
      this.lblGmail.Appearance.Options.UseFont = true;
      this.lblGmail.Appearance.Options.UseForeColor = true;
      this.lblGmail.Appearance.Options.UseTextOptions = true;
      this.lblGmail.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.lblGmail.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.lblGmail.Location = new System.Drawing.Point(14, 48);
      this.lblGmail.Name = "lblGmail";
      this.lblGmail.Size = new System.Drawing.Size(400, 20);
      this.lblGmail.TabIndex = 194;
      this.lblGmail.Text = "Email: Congnghexanhvietduc@gmail.com   ";
      // 
      // btnCheDoXaCan
      // 
      this.btnCheDoXaCan.BackColor = System.Drawing.Color.Transparent;
      this.btnCheDoXaCan.BackgroundImage = global::NhuaNong.ResourceNhua._btnMAN;
      this.btnCheDoXaCan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnCheDoXaCan.Bg_Click = global::NhuaNong.ResourceNhua._btnAUTO;
      this.btnCheDoXaCan.Bg_NoClick = global::NhuaNong.ResourceNhua._btnMAN;
      this.btnCheDoXaCan.IsOn = true;
      this.btnCheDoXaCan.IsTrangThai = NhuaNong.UserControls.ucBtnCheDo.TrangThai.Stop;
      this.btnCheDoXaCan.Location = new System.Drawing.Point(551, 816);
      this.btnCheDoXaCan.Name = "btnCheDoXaCan";
      this.btnCheDoXaCan.Size = new System.Drawing.Size(100, 40);
      this.btnCheDoXaCan.TabIndex = 195;
      this.btnCheDoXaCan.ButtonClick += new NhuaNong.UserControls.ucBtnCheDo.DelButtonEventHandler(this.btnCheDoXaCan_ButtonClick);
      // 
      // btnTanSay
      // 
      this.btnTanSay.BackColor = System.Drawing.Color.DarkGray;
      this.btnTanSay.BackgroundImage = global::NhuaNong.ResourceNhua._tinHieuLoDot;
      this.btnTanSay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnTanSay.Bg_Click = global::NhuaNong.ResourceNhua._tinHieuLoDotRun;
      this.btnTanSay.Bg_NoClick = global::NhuaNong.ResourceNhua._tinHieuLoDot;
      this.btnTanSay.IsOn = true;
      this.btnTanSay.IsTrangThai = NhuaNong.UserControls.ucTinHieuTanSayQuay.TrangThai.Stop;
      this.btnTanSay.Location = new System.Drawing.Point(1080, 673);
      this.btnTanSay.Name = "btnTanSay";
      this.btnTanSay.Size = new System.Drawing.Size(110, 32);
      this.btnTanSay.TabIndex = 194;
      this.btnTanSay.ButtonMouseDown += new NhuaNong.UserControls.ucTinHieuTanSayQuay.ButtonEventHandler(this.btnTanSay_ButtonMouseDown);
      this.btnTanSay.ButtonMouseUp += new NhuaNong.UserControls.ucTinHieuTanSayQuay.ButtonEventHandler(this.btnTanSay_ButtonMouseUp);
      // 
      // ucBtnVitTai1
      // 
      this.ucBtnVitTai1.BackColor = System.Drawing.Color.Transparent;
      this.ucBtnVitTai1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucBtnVitTai1.BackgroundImage")));
      this.ucBtnVitTai1.Bg_Click = global::NhuaNong.ResourceNhua._btnVuongRun;
      this.ucBtnVitTai1.Bg_NoClick = global::NhuaNong.ResourceNhua._btnVuong;
      this.ucBtnVitTai1.IsOn = false;
      this.ucBtnVitTai1.Location = new System.Drawing.Point(71, 604);
      this.ucBtnVitTai1.Name = "ucBtnVitTai1";
      this.ucBtnVitTai1.Size = new System.Drawing.Size(50, 20);
      this.ucBtnVitTai1.TabIndex = 191;
      this.ucBtnVitTai1.Visible = false;
      this.ucBtnVitTai1.ButtonMouseDown += new NhuaNong.UserControls.ucBtnVitTai.ButtonEventHandler(this.ucBtnVitTai1_ButtonMouseDown);
      this.ucBtnVitTai1.ButtonMouseUp += new NhuaNong.UserControls.ucBtnVitTai.ButtonEventHandler(this.ucBtnVitTai1_ButtonMouseUp);
      // 
      // btnSanRung
      // 
      this.btnSanRung.BackColor = System.Drawing.Color.MediumTurquoise;
      this.btnSanRung.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSanRung.BackgroundImage")));
      this.btnSanRung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnSanRung.IsOn = false;
      this.btnSanRung.Location = new System.Drawing.Point(705, 86);
      this.btnSanRung.Name = "btnSanRung";
      this.btnSanRung.Size = new System.Drawing.Size(76, 44);
      this.btnSanRung.TabIndex = 190;
      this.btnSanRung.ButtonMouseDown += new NhuaNong.UserControls.ucBtnSanRung.ButtonEventHandler(this.btnSanRung_ButtonMouseDown);
      this.btnSanRung.ButtonMouseUp += new NhuaNong.UserControls.ucBtnSanRung.ButtonEventHandler(this.btnSanRung_ButtonMouseUp);
      // 
      // tinHieuMoCuaNoi
      // 
      this.tinHieuMoCuaNoi.BackColor = System.Drawing.Color.Transparent;
      this.tinHieuMoCuaNoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinHieuMoCuaNoi.BackgroundImage")));
      this.tinHieuMoCuaNoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.tinHieuMoCuaNoi.Location = new System.Drawing.Point(522, 714);
      this.tinHieuMoCuaNoi.Name = "tinHieuMoCuaNoi";
      this.tinHieuMoCuaNoi.Size = new System.Drawing.Size(30, 15);
      this.tinHieuMoCuaNoi.TabIndex = 189;
      // 
      // tinHieuDongCuaNoi
      // 
      this.tinHieuDongCuaNoi.BackColor = System.Drawing.Color.Transparent;
      this.tinHieuDongCuaNoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinHieuDongCuaNoi.BackgroundImage")));
      this.tinHieuDongCuaNoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.tinHieuDongCuaNoi.Location = new System.Drawing.Point(737, 714);
      this.tinHieuDongCuaNoi.Name = "tinHieuDongCuaNoi";
      this.tinHieuDongCuaNoi.Size = new System.Drawing.Size(30, 15);
      this.tinHieuDongCuaNoi.TabIndex = 188;
      // 
      // tinHieuSanRung
      // 
      this.tinHieuSanRung.BackColor = System.Drawing.Color.DarkSlateGray;
      this.tinHieuSanRung.BackgroundImage = global::NhuaNong.ResourceNhua._tinhieu_SanRung;
      this.tinHieuSanRung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.tinHieuSanRung.Bg_Click = global::NhuaNong.ResourceNhua._tinhieu_SanRungRun;
      this.tinHieuSanRung.Bg_NoClick = global::NhuaNong.ResourceNhua._tinhieu_SanRung;
      this.tinHieuSanRung.IsOn = true;
      this.tinHieuSanRung.IsTrangThai = NhuaNong.UserControls.ucTinHieuSanRung.TrangThai.Stop;
      this.tinHieuSanRung.Location = new System.Drawing.Point(442, 94);
      this.tinHieuSanRung.Name = "tinHieuSanRung";
      this.tinHieuSanRung.Size = new System.Drawing.Size(72, 64);
      this.tinHieuSanRung.TabIndex = 187;
      // 
      // ucBangGauTauCatDaNhanh1
      // 
      this.ucBangGauTauCatDaNhanh1.BackColor = System.Drawing.Color.Transparent;
      this.ucBangGauTauCatDaNhanh1.BackgroundImage = global::NhuaNong.ResourceNhua._banggautaicatdanhanh;
      this.ucBangGauTauCatDaNhanh1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucBangGauTauCatDaNhanh1.Location = new System.Drawing.Point(941, 59);
      this.ucBangGauTauCatDaNhanh1.Name = "ucBangGauTauCatDaNhanh1";
      this.ucBangGauTauCatDaNhanh1.Size = new System.Drawing.Size(159, 32);
      this.ucBangGauTauCatDaNhanh1.TabIndex = 184;
      // 
      // ucBangGauTaiCatDa1
      // 
      this.ucBangGauTaiCatDa1.BackColor = System.Drawing.Color.Transparent;
      this.ucBangGauTaiCatDa1.BackgroundImage = global::NhuaNong.ResourceNhua._banggautaicatda;
      this.ucBangGauTaiCatDa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucBangGauTaiCatDa1.Location = new System.Drawing.Point(1092, 57);
      this.ucBangGauTaiCatDa1.Name = "ucBangGauTaiCatDa1";
      this.ucBangGauTaiCatDa1.Size = new System.Drawing.Size(40, 593);
      this.ucBangGauTaiCatDa1.TabIndex = 183;
      // 
      // motorGauTaiAGG1
      // 
      this.motorGauTaiAGG1.BackColor = System.Drawing.Color.Transparent;
      this.motorGauTaiAGG1.BackgroundImage = global::NhuaNong.ResourceNhua._motor_miniN;
      this.motorGauTaiAGG1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.motorGauTaiAGG1.Bg_Click = global::NhuaNong.ResourceNhua._motor_miniNRun;
      this.motorGauTaiAGG1.Bg_NoClick = global::NhuaNong.ResourceNhua._motor_miniN;
      this.motorGauTaiAGG1.IsOn = true;
      this.motorGauTaiAGG1.IsTrangThai = NhuaNong.UserControls.ucMotorMiniN.TrangThai.Stop;
      this.motorGauTaiAGG1.Location = new System.Drawing.Point(1120, 65);
      this.motorGauTaiAGG1.Name = "motorGauTaiAGG1";
      this.motorGauTaiAGG1.Size = new System.Drawing.Size(58, 34);
      this.motorGauTaiAGG1.TabIndex = 182;
      this.motorGauTaiAGG1.ButtonMouseDown += new NhuaNong.UserControls.ucMotorMiniN.DelButtonEventHandler(this.motorGauTaiAGG1_ButtonMouseDown);
      this.motorGauTaiAGG1.ButtonMouseUp += new NhuaNong.UserControls.ucMotorMiniN.DelButtonEventHandler(this.motorGauTaiAGG1_ButtonMouseUp);
      // 
      // btnRungCL3
      // 
      this.btnRungCL3.BackColor = System.Drawing.Color.DarkCyan;
      this.btnRungCL3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRungCL3.BackgroundImage")));
      this.btnRungCL3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnRungCL3.Bg_Click = global::NhuaNong.ResourceNhua._btnTronXRun;
      this.btnRungCL3.Bg_NoClick = null;
      this.btnRungCL3.IsOn = false;
      this.btnRungCL3.Location = new System.Drawing.Point(1660, 649);
      this.btnRungCL3.Name = "btnRungCL3";
      this.btnRungCL3.Size = new System.Drawing.Size(16, 16);
      this.btnRungCL3.TabIndex = 181;
      this.btnRungCL3.ButtonMouseDown += new NhuaNong.UserControls.ucBtnTron.DelButtonEventHandler(this.btnRungCL3_ButtonMouseDown);
      this.btnRungCL3.ButtonMouseUp += new NhuaNong.UserControls.ucBtnTron.DelButtonEventHandler(this.btnRungCL3_ButtonMouseUp);
      // 
      // btnRungCL2
      // 
      this.btnRungCL2.BackColor = System.Drawing.Color.DarkCyan;
      this.btnRungCL2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRungCL2.BackgroundImage")));
      this.btnRungCL2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnRungCL2.Bg_Click = global::NhuaNong.ResourceNhua._btnTronXRun;
      this.btnRungCL2.Bg_NoClick = null;
      this.btnRungCL2.IsOn = false;
      this.btnRungCL2.Location = new System.Drawing.Point(1581, 649);
      this.btnRungCL2.Name = "btnRungCL2";
      this.btnRungCL2.Size = new System.Drawing.Size(16, 16);
      this.btnRungCL2.TabIndex = 180;
      this.btnRungCL2.ButtonMouseDown += new NhuaNong.UserControls.ucBtnTron.DelButtonEventHandler(this.btnRungCL2_ButtonMouseDown);
      this.btnRungCL2.ButtonMouseUp += new NhuaNong.UserControls.ucBtnTron.DelButtonEventHandler(this.btnRungCL2_ButtonMouseUp);
      // 
      // btnRungCL1
      // 
      this.btnRungCL1.BackColor = System.Drawing.Color.DarkCyan;
      this.btnRungCL1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRungCL1.BackgroundImage")));
      this.btnRungCL1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnRungCL1.Bg_Click = global::NhuaNong.ResourceNhua._btnTronXRun;
      this.btnRungCL1.Bg_NoClick = null;
      this.btnRungCL1.IsOn = false;
      this.btnRungCL1.Location = new System.Drawing.Point(1500, 649);
      this.btnRungCL1.Name = "btnRungCL1";
      this.btnRungCL1.Size = new System.Drawing.Size(16, 16);
      this.btnRungCL1.TabIndex = 179;
      this.btnRungCL1.ButtonMouseDown += new NhuaNong.UserControls.ucBtnTron.DelButtonEventHandler(this.btnRungCL1_ButtonMouseDown);
      this.btnRungCL1.ButtonMouseUp += new NhuaNong.UserControls.ucBtnTron.DelButtonEventHandler(this.btnRungCL1_ButtonMouseUp);
      // 
      // ucBeTiep1
      // 
      this.ucBeTiep1.BackColor = System.Drawing.Color.Transparent;
      this.ucBeTiep1.BackgroundImage = global::NhuaNong.ResourceNhua._betiep;
      this.ucBeTiep1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucBeTiep1.Location = new System.Drawing.Point(161, 714);
      this.ucBeTiep1.Name = "ucBeTiep1";
      this.ucBeTiep1.Size = new System.Drawing.Size(80, 30);
      this.ucBeTiep1.TabIndex = 178;
      // 
      // ucBangGauTaiXiMang2
      // 
      this.ucBangGauTaiXiMang2.BackColor = System.Drawing.Color.Transparent;
      this.ucBangGauTaiXiMang2.BackgroundImage = global::NhuaNong.ResourceNhua._banggautaiximang;
      this.ucBangGauTaiXiMang2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucBangGauTaiXiMang2.Location = new System.Drawing.Point(199, 129);
      this.ucBangGauTaiXiMang2.Name = "ucBangGauTaiXiMang2";
      this.ucBangGauTaiXiMang2.Size = new System.Drawing.Size(42, 586);
      this.ucBangGauTaiXiMang2.TabIndex = 177;
      // 
      // btnFU_SBS
      // 
      this.btnFU_SBS.BackColor = System.Drawing.Color.Transparent;
      this.btnFU_SBS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFU_SBS.BackgroundImage")));
      this.btnFU_SBS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnFU_SBS.Bg_Click = global::NhuaNong.ResourceNhua._btnFURun;
      this.btnFU_SBS.Bg_NoClick = global::NhuaNong.ResourceNhua._btnFU;
      this.btnFU_SBS.IsOn = false;
      this.btnFU_SBS.Location = new System.Drawing.Point(1007, 349);
      this.btnFU_SBS.Name = "btnFU_SBS";
      this.btnFU_SBS.Size = new System.Drawing.Size(30, 15);
      this.btnFU_SBS.TabIndex = 176;
      this.btnFU_SBS.ButtonMouseDown += new NhuaNong.UserControls.ucBtnFU.ButtonEventHandler(this.btnFU_SBS_ButtonMouseDown);
      this.btnFU_SBS.ButtonMouseUp += new NhuaNong.UserControls.ucBtnFU.ButtonEventHandler(this.btnFU_SBS_ButtonMouseUp);
      // 
      // btnFU_AP
      // 
      this.btnFU_AP.BackColor = System.Drawing.Color.Transparent;
      this.btnFU_AP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFU_AP.BackgroundImage")));
      this.btnFU_AP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnFU_AP.Bg_Click = global::NhuaNong.ResourceNhua._btnFURun;
      this.btnFU_AP.Bg_NoClick = global::NhuaNong.ResourceNhua._btnFU;
      this.btnFU_AP.IsOn = false;
      this.btnFU_AP.Location = new System.Drawing.Point(893, 349);
      this.btnFU_AP.Name = "btnFU_AP";
      this.btnFU_AP.Size = new System.Drawing.Size(30, 15);
      this.btnFU_AP.TabIndex = 175;
      this.btnFU_AP.ButtonMouseDown += new NhuaNong.UserControls.ucBtnFU.ButtonEventHandler(this.btnFU_AP_ButtonMouseDown);
      this.btnFU_AP.ButtonMouseUp += new NhuaNong.UserControls.ucBtnFU.ButtonEventHandler(this.btnFU_AP_ButtonMouseUp);
      // 
      // btnFU_AGG5
      // 
      this.btnFU_AGG5.BackColor = System.Drawing.Color.Transparent;
      this.btnFU_AGG5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFU_AGG5.BackgroundImage")));
      this.btnFU_AGG5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnFU_AGG5.Bg_Click = global::NhuaNong.ResourceNhua._btnFURun;
      this.btnFU_AGG5.Bg_NoClick = global::NhuaNong.ResourceNhua._btnFU;
      this.btnFU_AGG5.IsOn = false;
      this.btnFU_AGG5.Location = new System.Drawing.Point(778, 349);
      this.btnFU_AGG5.Name = "btnFU_AGG5";
      this.btnFU_AGG5.Size = new System.Drawing.Size(30, 15);
      this.btnFU_AGG5.TabIndex = 174;
      this.btnFU_AGG5.ButtonMouseDown += new NhuaNong.UserControls.ucBtnFU.ButtonEventHandler(this.btnFU_AGG5_ButtonMouseDown);
      this.btnFU_AGG5.ButtonMouseUp += new NhuaNong.UserControls.ucBtnFU.ButtonEventHandler(this.btnFU_AGG5_ButtonMouseUp);
      // 
      // btnFU_AGG4
      // 
      this.btnFU_AGG4.BackColor = System.Drawing.Color.Transparent;
      this.btnFU_AGG4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFU_AGG4.BackgroundImage")));
      this.btnFU_AGG4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnFU_AGG4.Bg_Click = global::NhuaNong.ResourceNhua._btnFURun;
      this.btnFU_AGG4.Bg_NoClick = global::NhuaNong.ResourceNhua._btnFU;
      this.btnFU_AGG4.IsOn = false;
      this.btnFU_AGG4.Location = new System.Drawing.Point(691, 349);
      this.btnFU_AGG4.Name = "btnFU_AGG4";
      this.btnFU_AGG4.Size = new System.Drawing.Size(30, 15);
      this.btnFU_AGG4.TabIndex = 173;
      this.btnFU_AGG4.ButtonMouseDown += new NhuaNong.UserControls.ucBtnFU.ButtonEventHandler(this.btnFU_AGG4_ButtonMouseDown);
      this.btnFU_AGG4.ButtonMouseUp += new NhuaNong.UserControls.ucBtnFU.ButtonEventHandler(this.btnFU_AGG4_ButtonMouseUp);
      // 
      // btnFU_AGG3
      // 
      this.btnFU_AGG3.BackColor = System.Drawing.Color.Transparent;
      this.btnFU_AGG3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFU_AGG3.BackgroundImage")));
      this.btnFU_AGG3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnFU_AGG3.Bg_Click = global::NhuaNong.ResourceNhua._btnFURun;
      this.btnFU_AGG3.Bg_NoClick = global::NhuaNong.ResourceNhua._btnFU;
      this.btnFU_AGG3.IsOn = false;
      this.btnFU_AGG3.Location = new System.Drawing.Point(606, 349);
      this.btnFU_AGG3.Name = "btnFU_AGG3";
      this.btnFU_AGG3.Size = new System.Drawing.Size(30, 15);
      this.btnFU_AGG3.TabIndex = 172;
      this.btnFU_AGG3.ButtonMouseDown += new NhuaNong.UserControls.ucBtnFU.ButtonEventHandler(this.btnFU_AGG3_ButtonMouseDown);
      this.btnFU_AGG3.ButtonMouseUp += new NhuaNong.UserControls.ucBtnFU.ButtonEventHandler(this.btnFU_AGG3_ButtonMouseUp);
      // 
      // btnFU_AGG2
      // 
      this.btnFU_AGG2.BackColor = System.Drawing.Color.Transparent;
      this.btnFU_AGG2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFU_AGG2.BackgroundImage")));
      this.btnFU_AGG2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnFU_AGG2.Bg_Click = global::NhuaNong.ResourceNhua._btnFURun;
      this.btnFU_AGG2.Bg_NoClick = global::NhuaNong.ResourceNhua._btnFU;
      this.btnFU_AGG2.IsOn = false;
      this.btnFU_AGG2.Location = new System.Drawing.Point(519, 349);
      this.btnFU_AGG2.Name = "btnFU_AGG2";
      this.btnFU_AGG2.Size = new System.Drawing.Size(30, 15);
      this.btnFU_AGG2.TabIndex = 171;
      this.btnFU_AGG2.ButtonMouseDown += new NhuaNong.UserControls.ucBtnFU.ButtonEventHandler(this.btnFU_AGG2_ButtonMouseDown);
      this.btnFU_AGG2.ButtonMouseUp += new NhuaNong.UserControls.ucBtnFU.ButtonEventHandler(this.btnFU_AGG2_ButtonMouseUp);
      // 
      // btnFU_AG1
      // 
      this.btnFU_AG1.BackColor = System.Drawing.Color.Transparent;
      this.btnFU_AG1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFU_AG1.BackgroundImage")));
      this.btnFU_AG1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnFU_AG1.Bg_Click = global::NhuaNong.ResourceNhua._btnFURun;
      this.btnFU_AG1.Bg_NoClick = global::NhuaNong.ResourceNhua._btnFU;
      this.btnFU_AG1.IsOn = false;
      this.btnFU_AG1.Location = new System.Drawing.Point(434, 349);
      this.btnFU_AG1.Name = "btnFU_AG1";
      this.btnFU_AG1.Size = new System.Drawing.Size(30, 15);
      this.btnFU_AG1.TabIndex = 170;
      this.btnFU_AG1.ButtonMouseDown += new NhuaNong.UserControls.ucBtnFU.ButtonEventHandler(this.btnFU_AG1_ButtonMouseDown);
      this.btnFU_AG1.ButtonMouseUp += new NhuaNong.UserControls.ucBtnFU.ButtonEventHandler(this.btnFU_AG1_ButtonMouseUp);
      // 
      // btnFU_FD
      // 
      this.btnFU_FD.BackColor = System.Drawing.Color.Transparent;
      this.btnFU_FD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFU_FD.BackgroundImage")));
      this.btnFU_FD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnFU_FD.Bg_Click = global::NhuaNong.ResourceNhua._btnFURun;
      this.btnFU_FD.Bg_NoClick = global::NhuaNong.ResourceNhua._btnFU;
      this.btnFU_FD.IsOn = false;
      this.btnFU_FD.Location = new System.Drawing.Point(331, 349);
      this.btnFU_FD.Name = "btnFU_FD";
      this.btnFU_FD.Size = new System.Drawing.Size(30, 15);
      this.btnFU_FD.TabIndex = 169;
      this.btnFU_FD.ButtonMouseDown += new NhuaNong.UserControls.ucBtnFU.ButtonEventHandler(this.btnFU_FD_ButtonMouseDown);
      this.btnFU_FD.ButtonMouseUp += new NhuaNong.UserControls.ucBtnFU.ButtonEventHandler(this.btnFU_FD_ButtonMouseUp);
      // 
      // ucBangGauTaiXiMangNhanh1
      // 
      this.ucBangGauTaiXiMangNhanh1.BackColor = System.Drawing.Color.Transparent;
      this.ucBangGauTaiXiMangNhanh1.BackgroundImage = global::NhuaNong.ResourceNhua._banggautaiximangnhanh;
      this.ucBangGauTaiXiMangNhanh1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucBangGauTaiXiMangNhanh1.Location = new System.Drawing.Point(239, 129);
      this.ucBangGauTaiXiMangNhanh1.Name = "ucBangGauTaiXiMangNhanh1";
      this.ucBangGauTaiXiMangNhanh1.Size = new System.Drawing.Size(120, 74);
      this.ucBangGauTaiXiMangNhanh1.TabIndex = 166;
      // 
      // textEdit4
      // 
      this.textEdit4.EditValue = "0";
      this.textEdit4.Location = new System.Drawing.Point(55, 305);
      this.textEdit4.Name = "textEdit4";
      this.textEdit4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textEdit4.Properties.Appearance.Options.UseFont = true;
      this.textEdit4.Properties.Appearance.Options.UseTextOptions = true;
      this.textEdit4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.textEdit4.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.textEdit4.Size = new System.Drawing.Size(86, 32);
      this.textEdit4.TabIndex = 155;
      // 
      // textEdit2
      // 
      this.textEdit2.EditValue = "0";
      this.textEdit2.Location = new System.Drawing.Point(55, 470);
      this.textEdit2.Name = "textEdit2";
      this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textEdit2.Properties.Appearance.Options.UseFont = true;
      this.textEdit2.Properties.Appearance.Options.UseTextOptions = true;
      this.textEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.textEdit2.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.textEdit2.Properties.ReadOnly = true;
      this.textEdit2.Size = new System.Drawing.Size(86, 32);
      this.textEdit2.TabIndex = 153;
      // 
      // siloFDFat
      // 
      this.siloFDFat.BackColor = System.Drawing.Color.Transparent;
      this.siloFDFat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("siloFDFat.BackgroundImage")));
      this.siloFDFat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.siloFDFat.Location = new System.Drawing.Point(49, 193);
      this.siloFDFat.Name = "siloFDFat";
      this.siloFDFat.Size = new System.Drawing.Size(97, 500);
      this.siloFDFat.TabIndex = 152;
      // 
      // tinHIeuVitTaiFD
      // 
      this.tinHIeuVitTaiFD.BackColor = System.Drawing.Color.Transparent;
      this.tinHIeuVitTaiFD.BackgroundImage = global::NhuaNong.ResourceNhua._vittaiFD;
      this.tinHIeuVitTaiFD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.tinHIeuVitTaiFD.Bg_Click = global::NhuaNong.ResourceNhua._vittaiFDRun;
      this.tinHIeuVitTaiFD.Bg_NoClick = global::NhuaNong.ResourceNhua._vittaiFD;
      this.tinHIeuVitTaiFD.CheDo = NhuaNong.UserControls.ucVitTaiFD.Action.Pause;
      this.tinHIeuVitTaiFD.Location = new System.Drawing.Point(46, 667);
      this.tinHIeuVitTaiFD.Name = "tinHIeuVitTaiFD";
      this.tinHIeuVitTaiFD.Size = new System.Drawing.Size(141, 136);
      this.tinHIeuVitTaiFD.TabIndex = 151;
      this.tinHIeuVitTaiFD.ButtonMouseDown += new NhuaNong.UserControls.ucVitTaiFD.ButtonEventHandler(this.tinHIeuVitTaiFD_ButtonMouseDown);
      this.tinHIeuVitTaiFD.ButtonMouseUp += new NhuaNong.UserControls.ucVitTaiFD.ButtonEventHandler(this.tinHIeuVitTaiFD_ButtonMouseUp);
      // 
      // memoEdit1
      // 
      this.memoEdit1.EditValue = "";
      this.memoEdit1.Location = new System.Drawing.Point(28, 32);
      this.memoEdit1.Name = "memoEdit1";
      this.memoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
      this.memoEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.memoEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
      this.memoEdit1.Properties.Appearance.Options.UseBackColor = true;
      this.memoEdit1.Properties.Appearance.Options.UseFont = true;
      this.memoEdit1.Properties.Appearance.Options.UseForeColor = true;
      this.memoEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
      this.memoEdit1.Properties.ReadOnly = true;
      this.memoEdit1.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.memoEdit1.Size = new System.Drawing.Size(326, 68);
      this.memoEdit1.TabIndex = 149;
      // 
      // btnMayNenKhi
      // 
      this.btnMayNenKhi.BackColor = System.Drawing.Color.Transparent;
      this.btnMayNenKhi.BackgroundImage = global::NhuaNong.ResourceNhua._tinhieu_BomKhi;
      this.btnMayNenKhi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnMayNenKhi.Bg_Click = global::NhuaNong.ResourceNhua._tinhieu_BomKhiRun;
      this.btnMayNenKhi.Bg_NoClick = global::NhuaNong.ResourceNhua._tinhieu_BomKhi;
      this.btnMayNenKhi.IsOn = true;
      this.btnMayNenKhi.IsTrangThai = NhuaNong.UserControls.ucBtnBomKhi.TrangThai.Stop;
      this.btnMayNenKhi.Location = new System.Drawing.Point(302, 666);
      this.btnMayNenKhi.Name = "btnMayNenKhi";
      this.btnMayNenKhi.Size = new System.Drawing.Size(32, 24);
      this.btnMayNenKhi.TabIndex = 148;
      this.btnMayNenKhi.ButtonMouseDown += new NhuaNong.UserControls.ucBtnBomKhi.DelButtonEventHandler(this.btnMayNenKhi_ButtonMouseDown);
      this.btnMayNenKhi.ButtonMouseUp += new NhuaNong.UserControls.ucBtnBomKhi.DelButtonEventHandler(this.btnMayNenKhi_ButtonMouseUp);
      // 
      // ucBomKhi1
      // 
      this.ucBomKhi1.BackColor = System.Drawing.Color.Transparent;
      this.ucBomKhi1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucBomKhi1.BackgroundImage")));
      this.ucBomKhi1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucBomKhi1.Location = new System.Drawing.Point(273, 658);
      this.ucBomKhi1.Name = "ucBomKhi1";
      this.ucBomKhi1.Size = new System.Drawing.Size(114, 90);
      this.ucBomKhi1.TabIndex = 147;
      // 
      // txtTG_BomTuoiNhua
      // 
      this.txtTG_BomTuoiNhua.EditValue = "0";
      this.txtTG_BomTuoiNhua.Location = new System.Drawing.Point(900, 601);
      this.txtTG_BomTuoiNhua.Name = "txtTG_BomTuoiNhua";
      this.txtTG_BomTuoiNhua.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTG_BomTuoiNhua.Properties.Appearance.Options.UseFont = true;
      this.txtTG_BomTuoiNhua.Properties.Appearance.Options.UseTextOptions = true;
      this.txtTG_BomTuoiNhua.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.txtTG_BomTuoiNhua.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.txtTG_BomTuoiNhua.Size = new System.Drawing.Size(109, 32);
      this.txtTG_BomTuoiNhua.TabIndex = 142;
      this.txtTG_BomTuoiNhua.EditValueChanged += new System.EventHandler(this.txtTG_BomTuoiNhua_EditValueChanged);
      this.txtTG_BomTuoiNhua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTG_BomTuoiNhua_KeyPress);
      // 
      // textEdit3
      // 
      this.textEdit3.EditValue = "0";
      this.textEdit3.Location = new System.Drawing.Point(1525, 267);
      this.textEdit3.Name = "textEdit3";
      this.textEdit3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textEdit3.Properties.Appearance.Options.UseFont = true;
      this.textEdit3.Properties.Appearance.Options.UseTextOptions = true;
      this.textEdit3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.textEdit3.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.textEdit3.Properties.ReadOnly = true;
      this.textEdit3.Size = new System.Drawing.Size(86, 32);
      this.textEdit3.TabIndex = 138;
      // 
      // textEdit1
      // 
      this.textEdit1.EditValue = "0";
      this.textEdit1.Location = new System.Drawing.Point(1525, 210);
      this.textEdit1.Name = "textEdit1";
      this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textEdit1.Properties.Appearance.Options.UseFont = true;
      this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
      this.textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.textEdit1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.textEdit1.Size = new System.Drawing.Size(86, 32);
      this.textEdit1.TabIndex = 136;
      // 
      // btnVanCanSBS
      // 
      this.btnVanCanSBS.BackColor = System.Drawing.Color.Silver;
      this.btnVanCanSBS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVanCanSBS.BackgroundImage")));
      this.btnVanCanSBS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnVanCanSBS.Bg_Click = null;
      this.btnVanCanSBS.Bg_NoClick = null;
      this.btnVanCanSBS.IsOn = false;
      this.btnVanCanSBS.Location = new System.Drawing.Point(1013, 371);
      this.btnVanCanSBS.Name = "btnVanCanSBS";
      this.btnVanCanSBS.Size = new System.Drawing.Size(16, 16);
      this.btnVanCanSBS.TabIndex = 129;
      this.btnVanCanSBS.ButtonMouseDown += new NhuaNong.UserControls.ucBtnTron.DelButtonEventHandler(this.btnVanCanSBS_ButtonMouseDown);
      this.btnVanCanSBS.ButtonMouseUp += new NhuaNong.UserControls.ucBtnTron.DelButtonEventHandler(this.btnVanCanSBS_ButtonMouseUp);
      // 
      // ucOngSBS1
      // 
      this.ucOngSBS1.BackColor = System.Drawing.Color.Transparent;
      this.ucOngSBS1.BackgroundImage = global::NhuaNong.ResourceNhua._ongSBS;
      this.ucOngSBS1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucOngSBS1.Location = new System.Drawing.Point(996, 161);
      this.ucOngSBS1.Name = "ucOngSBS1";
      this.ucOngSBS1.Size = new System.Drawing.Size(226, 99);
      this.ucOngSBS1.TabIndex = 127;
      // 
      // btnVanCanAP
      // 
      this.btnVanCanAP.BackColor = System.Drawing.Color.Silver;
      this.btnVanCanAP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVanCanAP.BackgroundImage")));
      this.btnVanCanAP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnVanCanAP.Bg_Click = null;
      this.btnVanCanAP.Bg_NoClick = null;
      this.btnVanCanAP.IsOn = false;
      this.btnVanCanAP.Location = new System.Drawing.Point(900, 371);
      this.btnVanCanAP.Name = "btnVanCanAP";
      this.btnVanCanAP.Size = new System.Drawing.Size(16, 16);
      this.btnVanCanAP.TabIndex = 126;
      this.btnVanCanAP.ButtonMouseDown += new NhuaNong.UserControls.ucBtnTron.DelButtonEventHandler(this.btnVanCanAP_ButtonMouseDown);
      this.btnVanCanAP.ButtonMouseUp += new NhuaNong.UserControls.ucBtnTron.DelButtonEventHandler(this.btnVanCanAP_ButtonMouseUp);
      // 
      // ucPheuChua011
      // 
      this.ucPheuChua011.BackColor = System.Drawing.Color.Transparent;
      this.ucPheuChua011.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucPheuChua011.BackgroundImage")));
      this.ucPheuChua011.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucPheuChua011.Location = new System.Drawing.Point(1231, 109);
      this.ucPheuChua011.Name = "ucPheuChua011";
      this.ucPheuChua011.Size = new System.Drawing.Size(170, 212);
      this.ucPheuChua011.TabIndex = 124;
      // 
      // motorPheuChua01
      // 
      this.motorPheuChua01.BackColor = System.Drawing.Color.Transparent;
      this.motorPheuChua01.BackgroundImage = global::NhuaNong.ResourceNhua._motor_fat;
      this.motorPheuChua01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.motorPheuChua01.Bg_Click = global::NhuaNong.ResourceNhua._motor_fatRun;
      this.motorPheuChua01.Bg_NoClick = global::NhuaNong.ResourceNhua._motor_fat;
      this.motorPheuChua01.IsOn = true;
      this.motorPheuChua01.IsTrangThai = NhuaNong.UserControls.ucMotorFat.TrangThai.Stop;
      this.motorPheuChua01.Location = new System.Drawing.Point(1143, 259);
      this.motorPheuChua01.Name = "motorPheuChua01";
      this.motorPheuChua01.Size = new System.Drawing.Size(88, 47);
      this.motorPheuChua01.TabIndex = 123;
      this.motorPheuChua01.ButtonMouseDown += new NhuaNong.UserControls.ucMotorFat.DelButtonEventHandler(this.motorPheuChua01_ButtonMouseDown);
      this.motorPheuChua01.ButtonMouseUp += new NhuaNong.UserControls.ucMotorFat.DelButtonEventHandler(this.motorPheuChua01_ButtonMouseUp);
      // 
      // ucOngAP1
      // 
      this.ucOngAP1.BackColor = System.Drawing.Color.Transparent;
      this.ucOngAP1.BackgroundImage = global::NhuaNong.ResourceNhua._ongAP;
      this.ucOngAP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucOngAP1.Location = new System.Drawing.Point(901, 146);
      this.ucOngAP1.Name = "ucOngAP1";
      this.ucOngAP1.Size = new System.Drawing.Size(584, 115);
      this.ucOngAP1.TabIndex = 122;
      // 
      // ucOngMotor1
      // 
      this.ucOngMotor1.BackColor = System.Drawing.Color.Transparent;
      this.ucOngMotor1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucOngMotor1.BackgroundImage")));
      this.ucOngMotor1.Location = new System.Drawing.Point(1157, 480);
      this.ucOngMotor1.Name = "ucOngMotor1";
      this.ucOngMotor1.Size = new System.Drawing.Size(40, 170);
      this.ucOngMotor1.TabIndex = 121;
      // 
      // ucBonChuaTanSay1
      // 
      this.ucBonChuaTanSay1.BackColor = System.Drawing.Color.Transparent;
      this.ucBonChuaTanSay1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucBonChuaTanSay1.BackgroundImage")));
      this.ucBonChuaTanSay1.Location = new System.Drawing.Point(1077, 646);
      this.ucBonChuaTanSay1.Name = "ucBonChuaTanSay1";
      this.ucBonChuaTanSay1.Size = new System.Drawing.Size(203, 90);
      this.ucBonChuaTanSay1.TabIndex = 120;
      // 
      // bomNgamPheuChua
      // 
      this.bomNgamPheuChua.BackColor = System.Drawing.Color.DarkGray;
      this.bomNgamPheuChua.BackgroundImage = global::NhuaNong.ResourceNhua._bom_ngam;
      this.bomNgamPheuChua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.bomNgamPheuChua.Bg_Click = global::NhuaNong.ResourceNhua._bom_ngamRun;
      this.bomNgamPheuChua.Bg_NoClick = global::NhuaNong.ResourceNhua._bom_ngam;
      this.bomNgamPheuChua.IsOn = true;
      this.bomNgamPheuChua.IsTrangThai = NhuaNong.UserControls.ucBomNgam.TrangThai.Stop;
      this.bomNgamPheuChua.Location = new System.Drawing.Point(1387, 409);
      this.bomNgamPheuChua.Name = "bomNgamPheuChua";
      this.bomNgamPheuChua.Size = new System.Drawing.Size(45, 70);
      this.bomNgamPheuChua.TabIndex = 118;
      this.bomNgamPheuChua.ButtonMouseDown += new NhuaNong.UserControls.ucBomNgam.DelButtonEventHandler(this.bomNgamPheuChua_ButtonMouseDown);
      this.bomNgamPheuChua.ButtonMouseUp += new NhuaNong.UserControls.ucBomNgam.DelButtonEventHandler(this.bomNgamPheuChua_ButtonMouseUp);
      // 
      // ucPheuChua041
      // 
      this.ucPheuChua041.BackColor = System.Drawing.Color.Transparent;
      this.ucPheuChua041.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucPheuChua041.BackgroundImage")));
      this.ucPheuChua041.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucPheuChua041.Location = new System.Drawing.Point(1374, 349);
      this.ucPheuChua041.Name = "ucPheuChua041";
      this.ucPheuChua041.Size = new System.Drawing.Size(72, 147);
      this.ucPheuChua041.TabIndex = 117;
      // 
      // ucOngPheuChua041
      // 
      this.ucOngPheuChua041.BackColor = System.Drawing.Color.Transparent;
      this.ucOngPheuChua041.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucOngPheuChua041.BackgroundImage")));
      this.ucOngPheuChua041.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucOngPheuChua041.Location = new System.Drawing.Point(1298, 375);
      this.ucOngPheuChua041.Name = "ucOngPheuChua041";
      this.ucOngPheuChua041.Size = new System.Drawing.Size(145, 52);
      this.ucOngPheuChua041.TabIndex = 116;
      // 
      // ucOngPheuChua031
      // 
      this.ucOngPheuChua031.BackColor = System.Drawing.Color.Transparent;
      this.ucOngPheuChua031.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucOngPheuChua031.BackgroundImage")));
      this.ucOngPheuChua031.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucOngPheuChua031.Location = new System.Drawing.Point(1436, 459);
      this.ucOngPheuChua031.Name = "ucOngPheuChua031";
      this.ucOngPheuChua031.Size = new System.Drawing.Size(51, 18);
      this.ucOngPheuChua031.TabIndex = 115;
      // 
      // ucOngBonChuaKhi1
      // 
      this.ucOngBonChuaKhi1.BackColor = System.Drawing.Color.Transparent;
      this.ucOngBonChuaKhi1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucOngBonChuaKhi1.BackgroundImage")));
      this.ucOngBonChuaKhi1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucOngBonChuaKhi1.Location = new System.Drawing.Point(1031, 782);
      this.ucOngBonChuaKhi1.Name = "ucOngBonChuaKhi1";
      this.ucOngBonChuaKhi1.Size = new System.Drawing.Size(46, 27);
      this.ucOngBonChuaKhi1.TabIndex = 114;
      // 
      // ucOngTanSay1
      // 
      this.ucOngTanSay1.BackColor = System.Drawing.Color.Transparent;
      this.ucOngTanSay1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucOngTanSay1.BackgroundImage")));
      this.ucOngTanSay1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucOngTanSay1.Location = new System.Drawing.Point(1006, 714);
      this.ucOngTanSay1.Name = "ucOngTanSay1";
      this.ucOngTanSay1.Size = new System.Drawing.Size(24, 58);
      this.ucOngTanSay1.TabIndex = 113;
      // 
      // bangTaiXien
      // 
      this.bangTaiXien.BackColor = System.Drawing.Color.Transparent;
      this.bangTaiXien.BackgroundImage = global::NhuaNong.ResourceNhua._btx;
      this.bangTaiXien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.bangTaiXien.Bg_Click = global::NhuaNong.ResourceNhua._btxRun___Copy;
      this.bangTaiXien.Bg_NoClick = global::NhuaNong.ResourceNhua._btx;
      this.bangTaiXien.CheDo = NhuaNong.UserControls.ucBTX.Action.Pause;
      this.bangTaiXien.Location = new System.Drawing.Point(1285, 622);
      this.bangTaiXien.Name = "bangTaiXien";
      this.bangTaiXien.Size = new System.Drawing.Size(180, 184);
      this.bangTaiXien.TabIndex = 108;
      this.bangTaiXien.ButtonMouseDown += new NhuaNong.UserControls.ucBTX.ButtonEventHandler(this.bangTaiXien_ButtonMouseDown);
      this.bangTaiXien.ButtonMouseUp += new NhuaNong.UserControls.ucBTX.ButtonEventHandler(this.bangTaiXien_ButtonMouseUp);
      // 
      // bangTaiCan
      // 
      this.bangTaiCan.BackColor = System.Drawing.Color.Transparent;
      this.bangTaiCan.BackgroundImage = global::NhuaNong.ResourceNhua._btc;
      this.bangTaiCan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.bangTaiCan.Bg_Click = global::NhuaNong.ResourceNhua._btcRun___Copy;
      this.bangTaiCan.Bg_NoClick = global::NhuaNong.ResourceNhua._btc;
      this.bangTaiCan.CheDo = NhuaNong.UserControls.ucBangTaiCan.Action.Pause;
      this.bangTaiCan.Location = new System.Drawing.Point(1483, 769);
      this.bangTaiCan.Name = "bangTaiCan";
      this.bangTaiCan.Size = new System.Drawing.Size(360, 30);
      this.bangTaiCan.TabIndex = 107;
      this.bangTaiCan.ButtonMouseDown += new NhuaNong.UserControls.ucBangTaiCan.ButtonEventHandler(this.bangTaiCan_ButtonMouseDown);
      this.bangTaiCan.ButtonMouseUp += new NhuaNong.UserControls.ucBangTaiCan.ButtonEventHandler(this.bangTaiCan_ButtonMouseUp);
      // 
      // tinHieuXaCanAGG5
      // 
      this.tinHieuXaCanAGG5.BackColor = System.Drawing.Color.Transparent;
      this.tinHieuXaCanAGG5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinHieuXaCanAGG5.BackgroundImage")));
      this.tinHieuXaCanAGG5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.tinHieuXaCanAGG5.Location = new System.Drawing.Point(1819, 714);
      this.tinHieuXaCanAGG5.Name = "tinHieuXaCanAGG5";
      this.tinHieuXaCanAGG5.Size = new System.Drawing.Size(24, 24);
      this.tinHieuXaCanAGG5.TabIndex = 105;
      this.tinHieuXaCanAGG5.Visible = false;
      // 
      // tinHieuXaCanAGG4
      // 
      this.tinHieuXaCanAGG4.BackColor = System.Drawing.Color.Transparent;
      this.tinHieuXaCanAGG4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinHieuXaCanAGG4.BackgroundImage")));
      this.tinHieuXaCanAGG4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.tinHieuXaCanAGG4.Location = new System.Drawing.Point(1738, 714);
      this.tinHieuXaCanAGG4.Name = "tinHieuXaCanAGG4";
      this.tinHieuXaCanAGG4.Size = new System.Drawing.Size(24, 24);
      this.tinHieuXaCanAGG4.TabIndex = 104;
      this.tinHieuXaCanAGG4.Visible = false;
      // 
      // tinHieuXaCanAGG3
      // 
      this.tinHieuXaCanAGG3.BackColor = System.Drawing.Color.Transparent;
      this.tinHieuXaCanAGG3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinHieuXaCanAGG3.BackgroundImage")));
      this.tinHieuXaCanAGG3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.tinHieuXaCanAGG3.Location = new System.Drawing.Point(1657, 714);
      this.tinHieuXaCanAGG3.Name = "tinHieuXaCanAGG3";
      this.tinHieuXaCanAGG3.Size = new System.Drawing.Size(24, 24);
      this.tinHieuXaCanAGG3.TabIndex = 103;
      this.tinHieuXaCanAGG3.Visible = false;
      // 
      // tinHieuXaCanAGG2
      // 
      this.tinHieuXaCanAGG2.BackColor = System.Drawing.Color.Transparent;
      this.tinHieuXaCanAGG2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinHieuXaCanAGG2.BackgroundImage")));
      this.tinHieuXaCanAGG2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.tinHieuXaCanAGG2.Location = new System.Drawing.Point(1576, 714);
      this.tinHieuXaCanAGG2.Name = "tinHieuXaCanAGG2";
      this.tinHieuXaCanAGG2.Size = new System.Drawing.Size(24, 24);
      this.tinHieuXaCanAGG2.TabIndex = 102;
      this.tinHieuXaCanAGG2.Visible = false;
      // 
      // tinHieuXaCanAGG1
      // 
      this.tinHieuXaCanAGG1.BackColor = System.Drawing.Color.Transparent;
      this.tinHieuXaCanAGG1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinHieuXaCanAGG1.BackgroundImage")));
      this.tinHieuXaCanAGG1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.tinHieuXaCanAGG1.Location = new System.Drawing.Point(1495, 714);
      this.tinHieuXaCanAGG1.Name = "tinHieuXaCanAGG1";
      this.tinHieuXaCanAGG1.Size = new System.Drawing.Size(24, 24);
      this.tinHieuXaCanAGG1.TabIndex = 101;
      this.tinHieuXaCanAGG1.Visible = false;
      // 
      // ucPheuChuaCatDa5
      // 
      this.ucPheuChuaCatDa5.BackColor = System.Drawing.Color.Transparent;
      this.ucPheuChuaCatDa5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucPheuChuaCatDa5.BackgroundImage")));
      this.ucPheuChuaCatDa5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucPheuChuaCatDa5.Location = new System.Drawing.Point(1794, 609);
      this.ucPheuChuaCatDa5.Name = "ucPheuChuaCatDa5";
      this.ucPheuChuaCatDa5.Size = new System.Drawing.Size(75, 75);
      this.ucPheuChuaCatDa5.TabIndex = 95;
      this.ucPheuChuaCatDa5.WeighName = "AGG5";
      // 
      // ucPheuChuaCatDa4
      // 
      this.ucPheuChuaCatDa4.BackColor = System.Drawing.Color.Transparent;
      this.ucPheuChuaCatDa4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucPheuChuaCatDa4.BackgroundImage")));
      this.ucPheuChuaCatDa4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucPheuChuaCatDa4.Location = new System.Drawing.Point(1713, 609);
      this.ucPheuChuaCatDa4.Name = "ucPheuChuaCatDa4";
      this.ucPheuChuaCatDa4.Size = new System.Drawing.Size(75, 75);
      this.ucPheuChuaCatDa4.TabIndex = 94;
      this.ucPheuChuaCatDa4.WeighName = "AGG4";
      // 
      // ucPheuChuaCatDa3
      // 
      this.ucPheuChuaCatDa3.BackColor = System.Drawing.Color.Transparent;
      this.ucPheuChuaCatDa3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucPheuChuaCatDa3.BackgroundImage")));
      this.ucPheuChuaCatDa3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucPheuChuaCatDa3.Location = new System.Drawing.Point(1632, 609);
      this.ucPheuChuaCatDa3.Name = "ucPheuChuaCatDa3";
      this.ucPheuChuaCatDa3.Size = new System.Drawing.Size(75, 75);
      this.ucPheuChuaCatDa3.TabIndex = 93;
      this.ucPheuChuaCatDa3.WeighName = "AGG3";
      // 
      // ucPheuChuaCatDa2
      // 
      this.ucPheuChuaCatDa2.BackColor = System.Drawing.Color.Transparent;
      this.ucPheuChuaCatDa2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucPheuChuaCatDa2.BackgroundImage")));
      this.ucPheuChuaCatDa2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucPheuChuaCatDa2.Location = new System.Drawing.Point(1551, 609);
      this.ucPheuChuaCatDa2.Name = "ucPheuChuaCatDa2";
      this.ucPheuChuaCatDa2.Size = new System.Drawing.Size(75, 75);
      this.ucPheuChuaCatDa2.TabIndex = 92;
      this.ucPheuChuaCatDa2.WeighName = "AGG2";
      // 
      // ucPheuChuaCatDa1
      // 
      this.ucPheuChuaCatDa1.BackColor = System.Drawing.Color.Transparent;
      this.ucPheuChuaCatDa1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucPheuChuaCatDa1.BackgroundImage")));
      this.ucPheuChuaCatDa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucPheuChuaCatDa1.Location = new System.Drawing.Point(1470, 609);
      this.ucPheuChuaCatDa1.Name = "ucPheuChuaCatDa1";
      this.ucPheuChuaCatDa1.Size = new System.Drawing.Size(75, 75);
      this.ucPheuChuaCatDa1.TabIndex = 91;
      this.ucPheuChuaCatDa1.WeighName = "AGG1";
      // 
      // motorPheuChua02
      // 
      this.motorPheuChua02.BackColor = System.Drawing.Color.Transparent;
      this.motorPheuChua02.BackgroundImage = global::NhuaNong.ResourceNhua._motor_fat;
      this.motorPheuChua02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.motorPheuChua02.Bg_Click = global::NhuaNong.ResourceNhua._motor_fatRun;
      this.motorPheuChua02.Bg_NoClick = global::NhuaNong.ResourceNhua._motor_fat;
      this.motorPheuChua02.IsOn = true;
      this.motorPheuChua02.IsTrangThai = NhuaNong.UserControls.ucMotorFat.TrangThai.Stop;
      this.motorPheuChua02.Location = new System.Drawing.Point(1406, 259);
      this.motorPheuChua02.Name = "motorPheuChua02";
      this.motorPheuChua02.Size = new System.Drawing.Size(88, 47);
      this.motorPheuChua02.TabIndex = 88;
      this.motorPheuChua02.ButtonMouseDown += new NhuaNong.UserControls.ucMotorFat.DelButtonEventHandler(this.motorPheuChua02_ButtonMouseDown);
      this.motorPheuChua02.ButtonMouseUp += new NhuaNong.UserControls.ucMotorFat.DelButtonEventHandler(this.motorPheuChua02_ButtonMouseUp);
      // 
      // ucPheuChua031
      // 
      this.ucPheuChua031.BackColor = System.Drawing.Color.Transparent;
      this.ucPheuChua031.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucPheuChua031.BackgroundImage")));
      this.ucPheuChua031.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucPheuChua031.Location = new System.Drawing.Point(1485, 337);
      this.ucPheuChua031.Name = "ucPheuChua031";
      this.ucPheuChua031.Size = new System.Drawing.Size(92, 157);
      this.ucPheuChua031.TabIndex = 85;
      // 
      // ucPheuChua021
      // 
      this.ucPheuChua021.BackColor = System.Drawing.Color.Transparent;
      this.ucPheuChua021.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucPheuChua021.BackgroundImage")));
      this.ucPheuChua021.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucPheuChua021.Location = new System.Drawing.Point(1491, 142);
      this.ucPheuChua021.Name = "ucPheuChua021";
      this.ucPheuChua021.Size = new System.Drawing.Size(150, 175);
      this.ucPheuChua021.TabIndex = 83;
      // 
      // ucMotorExtra1
      // 
      this.ucMotorExtra1.BackColor = System.Drawing.Color.Transparent;
      this.ucMotorExtra1.BackgroundImage = global::NhuaNong.ResourceNhua._motor_extra;
      this.ucMotorExtra1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucMotorExtra1.Bg_Click = global::NhuaNong.ResourceNhua._motor_extraRun;
      this.ucMotorExtra1.Bg_NoClick = global::NhuaNong.ResourceNhua._motor_extra;
      this.ucMotorExtra1.IsOn = true;
      this.ucMotorExtra1.IsTrangThai = NhuaNong.UserControls.ucMotorExtra.TrangThai.Stop;
      this.ucMotorExtra1.Location = new System.Drawing.Point(1200, 428);
      this.ucMotorExtra1.Name = "ucMotorExtra1";
      this.ucMotorExtra1.Size = new System.Drawing.Size(120, 102);
      this.ucMotorExtra1.TabIndex = 82;
      this.ucMotorExtra1.ButtonMouseDown += new NhuaNong.UserControls.ucMotorExtra.DelButtonEventHandler(this.ucMotorExtra1_ButtonMouseDown);
      this.ucMotorExtra1.ButtonMouseUp += new NhuaNong.UserControls.ucMotorExtra.DelButtonEventHandler(this.ucMotorExtra1_ButtonMouseUp);
      // 
      // motorBomDau
      // 
      this.motorBomDau.BackColor = System.Drawing.Color.Transparent;
      this.motorBomDau.BackgroundImage = global::NhuaNong.ResourceNhua._motor_fat;
      this.motorBomDau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.motorBomDau.Bg_Click = global::NhuaNong.ResourceNhua._motor_fatRun;
      this.motorBomDau.Bg_NoClick = global::NhuaNong.ResourceNhua._motor_fat;
      this.motorBomDau.IsOn = true;
      this.motorBomDau.IsTrangThai = NhuaNong.UserControls.ucMotorFat.TrangThai.Stop;
      this.motorBomDau.Location = new System.Drawing.Point(944, 769);
      this.motorBomDau.Name = "motorBomDau";
      this.motorBomDau.Size = new System.Drawing.Size(88, 47);
      this.motorBomDau.TabIndex = 81;
      this.motorBomDau.ButtonMouseDown += new NhuaNong.UserControls.ucMotorFat.DelButtonEventHandler(this.motorBomDau_ButtonMouseDown);
      this.motorBomDau.ButtonMouseUp += new NhuaNong.UserControls.ucMotorFat.DelButtonEventHandler(this.motorBomDau_ButtonMouseUp);
      // 
      // tinHieuTanSayLua
      // 
      this.tinHieuTanSayLua.BackColor = System.Drawing.Color.Transparent;
      this.tinHieuTanSayLua.BackgroundImage = global::NhuaNong.ResourceNhua._tinhieutansayluaRun;
      this.tinHieuTanSayLua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.tinHieuTanSayLua.Bg_Click = global::NhuaNong.ResourceNhua._tinhieutansayluaRun;
      this.tinHieuTanSayLua.Bg_NoClick = global::NhuaNong.ResourceNhua._tinhieutansaylua;
      this.tinHieuTanSayLua.IsOn = false;
      this.tinHieuTanSayLua.IsTrangThai = NhuaNong.UserControls.ucTinHieunTanSayLua.TrangThai.Run;
      this.tinHieuTanSayLua.Location = new System.Drawing.Point(1004, 659);
      this.tinHieuTanSayLua.Name = "tinHieuTanSayLua";
      this.tinHieuTanSayLua.Size = new System.Drawing.Size(72, 56);
      this.tinHieuTanSayLua.TabIndex = 79;
      // 
      // motorGauTaiFD
      // 
      this.motorGauTaiFD.BackColor = System.Drawing.Color.Transparent;
      this.motorGauTaiFD.BackgroundImage = global::NhuaNong.ResourceNhua._motor_mini;
      this.motorGauTaiFD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.motorGauTaiFD.Bg_Click = global::NhuaNong.ResourceNhua._motor_miniRun;
      this.motorGauTaiFD.Bg_NoClick = global::NhuaNong.ResourceNhua._motor_mini;
      this.motorGauTaiFD.IsOn = true;
      this.motorGauTaiFD.IsTrangThai = NhuaNong.UserControls.ucMotorMini.TrangThai.Stop;
      this.motorGauTaiFD.Location = new System.Drawing.Point(150, 129);
      this.motorGauTaiFD.Name = "motorGauTaiFD";
      this.motorGauTaiFD.Size = new System.Drawing.Size(60, 36);
      this.motorGauTaiFD.TabIndex = 77;
      this.motorGauTaiFD.ButtonMouseDown += new NhuaNong.UserControls.ucMotorMini.DelButtonEventHandler(this.motorGauTaiFD_ButtonMouseDown);
      this.motorGauTaiFD.ButtonMouseUp += new NhuaNong.UserControls.ucMotorMini.DelButtonEventHandler(this.motorGauTaiFD_ButtonMouseUp);
      // 
      // sanRung
      // 
      this.sanRung.BackColor = System.Drawing.Color.Transparent;
      this.sanRung.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sanRung.BackgroundImage")));
      this.sanRung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.sanRung.Location = new System.Drawing.Point(365, 9);
      this.sanRung.Name = "sanRung";
      this.sanRung.Size = new System.Drawing.Size(577, 184);
      this.sanRung.TabIndex = 75;
      // 
      // ucBonChuaKhi1
      // 
      this.ucBonChuaKhi1.BackColor = System.Drawing.Color.Transparent;
      this.ucBonChuaKhi1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucBonChuaKhi1.BackgroundImage")));
      this.ucBonChuaKhi1.Location = new System.Drawing.Point(1077, 745);
      this.ucBonChuaKhi1.Name = "ucBonChuaKhi1";
      this.ucBonChuaKhi1.Size = new System.Drawing.Size(202, 91);
      this.ucBonChuaKhi1.TabIndex = 71;
      // 
      // btnCheDoCuaNoi
      // 
      this.btnCheDoCuaNoi.BackColor = System.Drawing.Color.Transparent;
      this.btnCheDoCuaNoi.BackgroundImage = global::NhuaNong.ResourceNhua._btnMAN;
      this.btnCheDoCuaNoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnCheDoCuaNoi.Bg_Click = global::NhuaNong.ResourceNhua._btnAUTO;
      this.btnCheDoCuaNoi.Bg_NoClick = global::NhuaNong.ResourceNhua._btnMAN;
      this.btnCheDoCuaNoi.IsOn = true;
      this.btnCheDoCuaNoi.IsTrangThai = NhuaNong.UserControls.ucBtnCheDo.TrangThai.Stop;
      this.btnCheDoCuaNoi.Location = new System.Drawing.Point(763, 816);
      this.btnCheDoCuaNoi.Name = "btnCheDoCuaNoi";
      this.btnCheDoCuaNoi.Size = new System.Drawing.Size(100, 40);
      this.btnCheDoCuaNoi.TabIndex = 67;
      this.btnCheDoCuaNoi.ButtonClick += new NhuaNong.UserControls.ucBtnCheDo.DelButtonEventHandler(this.btnCheDoCuaNoi_ButtonClick);
      // 
      // btnCheDoNapLieu
      // 
      this.btnCheDoNapLieu.BackColor = System.Drawing.Color.Transparent;
      this.btnCheDoNapLieu.BackgroundImage = global::NhuaNong.ResourceNhua._btnMAN;
      this.btnCheDoNapLieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnCheDoNapLieu.Bg_Click = global::NhuaNong.ResourceNhua._btnAUTO;
      this.btnCheDoNapLieu.Bg_NoClick = global::NhuaNong.ResourceNhua._btnMAN;
      this.btnCheDoNapLieu.IsOn = true;
      this.btnCheDoNapLieu.IsTrangThai = NhuaNong.UserControls.ucBtnCheDo.TrangThai.Stop;
      this.btnCheDoNapLieu.Location = new System.Drawing.Point(657, 816);
      this.btnCheDoNapLieu.Name = "btnCheDoNapLieu";
      this.btnCheDoNapLieu.Size = new System.Drawing.Size(100, 40);
      this.btnCheDoNapLieu.TabIndex = 66;
      this.btnCheDoNapLieu.ButtonClick += new NhuaNong.UserControls.ucBtnCheDo.DelButtonEventHandler(this.btnCheDoNapLieu_ButtonClick);
      // 
      // btnCheDoHeThong
      // 
      this.btnCheDoHeThong.BackColor = System.Drawing.Color.Transparent;
      this.btnCheDoHeThong.BackgroundImage = global::NhuaNong.ResourceNhua._btnMAN;
      this.btnCheDoHeThong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnCheDoHeThong.Bg_Click = global::NhuaNong.ResourceNhua._btnAUTO;
      this.btnCheDoHeThong.Bg_NoClick = global::NhuaNong.ResourceNhua._btnMAN;
      this.btnCheDoHeThong.IsOn = true;
      this.btnCheDoHeThong.IsTrangThai = NhuaNong.UserControls.ucBtnCheDo.TrangThai.Stop;
      this.btnCheDoHeThong.Location = new System.Drawing.Point(445, 816);
      this.btnCheDoHeThong.Name = "btnCheDoHeThong";
      this.btnCheDoHeThong.Size = new System.Drawing.Size(100, 40);
      this.btnCheDoHeThong.TabIndex = 65;
      this.btnCheDoHeThong.ButtonClick += new NhuaNong.UserControls.ucBtnCheDo.DelButtonEventHandler(this.btnCheDoHeThong_ButtonClick);
      // 
      // btnSIM
      // 
      this.btnSIM.BackColor = System.Drawing.Color.Transparent;
      this.btnSIM.BackgroundImage = global::NhuaNong.ResourceNhua._btnSIM;
      this.btnSIM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnSIM.Bg_Click = global::NhuaNong.ResourceNhua._btnSIMRun;
      this.btnSIM.Bg_NoClick = global::NhuaNong.ResourceNhua._btnSIM;
      this.btnSIM.IsOn = true;
      this.btnSIM.IsTrangThai = NhuaNong.UserControls.ucBtnSIM.TrangThai.Stop;
      this.btnSIM.Location = new System.Drawing.Point(339, 816);
      this.btnSIM.Name = "btnSIM";
      this.btnSIM.Size = new System.Drawing.Size(100, 40);
      this.btnSIM.TabIndex = 64;
      this.btnSIM.ButtonClick += new NhuaNong.UserControls.ucBtnSIM.DelButtonEventHandler(this.btnSIM_ButtonClick);
      // 
      // btnHuy
      // 
      this.btnHuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.BackgroundImage")));
      this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnHuy.Bg_Click = global::NhuaNong.ResourceNhua._btnHuyRun;
      this.btnHuy.Bg_NoClick = global::NhuaNong.ResourceNhua._btnHuy;
      this.btnHuy.IsOn = false;
      this.btnHuy.Location = new System.Drawing.Point(233, 816);
      this.btnHuy.Name = "btnHuy";
      this.btnHuy.Size = new System.Drawing.Size(100, 40);
      this.btnHuy.TabIndex = 63;
      this.btnHuy.ButtonClick += new NhuaNong.UserControls.ucBtnHuy.DelButtonEventHandler(this.btnHuy_ButtonClick);
      // 
      // btnDung
      // 
      this.btnDung.BackColor = System.Drawing.Color.Transparent;
      this.btnDung.BackgroundImage = global::NhuaNong.ResourceNhua._btnDung;
      this.btnDung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnDung.Bg_Click = global::NhuaNong.ResourceNhua._btnTiepTuc;
      this.btnDung.Bg_NoClick = global::NhuaNong.ResourceNhua._btnDung;
      this.btnDung.IsOn = true;
      this.btnDung.IsTrangThai = NhuaNong.UserControls.ucBtnDung.TrangThai.Stop;
      this.btnDung.Location = new System.Drawing.Point(127, 816);
      this.btnDung.Name = "btnDung";
      this.btnDung.Size = new System.Drawing.Size(100, 40);
      this.btnDung.TabIndex = 62;
      this.btnDung.ButtonClick += new NhuaNong.UserControls.ucBtnDung.DelButtonEventHandler(this.btnDung_ButtonClick);
      // 
      // btnBatDau
      // 
      this.btnBatDau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBatDau.BackgroundImage")));
      this.btnBatDau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnBatDau.Bg_Click = global::NhuaNong.ResourceNhua._btnBatDau_Run;
      this.btnBatDau.Bg_NoClick = global::NhuaNong.ResourceNhua._btnBatDau;
      this.btnBatDau.IsOn = false;
      this.btnBatDau.Location = new System.Drawing.Point(21, 816);
      this.btnBatDau.Name = "btnBatDau";
      this.btnBatDau.Size = new System.Drawing.Size(100, 40);
      this.btnBatDau.TabIndex = 61;
      this.btnBatDau.ButtonClick += new NhuaNong.UserControls.ucBtnBatDau.DelButtonEventHandler(this.btnBatDau_ButtonClick);
      // 
      // btnDongCuaNoi
      // 
      this.btnDongCuaNoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDongCuaNoi.BackgroundImage")));
      this.btnDongCuaNoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnDongCuaNoi.Bg_Click = global::NhuaNong.ResourceNhua._btnDongRun;
      this.btnDongCuaNoi.Bg_NoClick = global::NhuaNong.ResourceNhua._btnDong;
      this.btnDongCuaNoi.IsOn = false;
      this.btnDongCuaNoi.Location = new System.Drawing.Point(737, 736);
      this.btnDongCuaNoi.Name = "btnDongCuaNoi";
      this.btnDongCuaNoi.Size = new System.Drawing.Size(100, 40);
      this.btnDongCuaNoi.TabIndex = 60;
      this.btnDongCuaNoi.ButtonMouseDown += new NhuaNong.UserControls.ucBtnDong.ButtonEventHandler(this.btnDongCuaNoi_ButtonMouseDown);
      this.btnDongCuaNoi.ButtonMouseUp += new NhuaNong.UserControls.ucBtnDong.ButtonEventHandler(this.btnDongCuaNoi_ButtonMouseUp);
      // 
      // btnMoCuaNoi
      // 
      this.btnMoCuaNoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoCuaNoi.BackgroundImage")));
      this.btnMoCuaNoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnMoCuaNoi.Bg_Click = global::NhuaNong.ResourceNhua._btnMoRun;
      this.btnMoCuaNoi.Bg_NoClick = global::NhuaNong.ResourceNhua._btnMo;
      this.btnMoCuaNoi.IsOn = false;
      this.btnMoCuaNoi.Location = new System.Drawing.Point(454, 736);
      this.btnMoCuaNoi.Name = "btnMoCuaNoi";
      this.btnMoCuaNoi.Size = new System.Drawing.Size(100, 40);
      this.btnMoCuaNoi.TabIndex = 59;
      this.btnMoCuaNoi.ButtonMouseDown += new NhuaNong.UserControls.ucBtnMo.ButtonEventHandler(this.btnMoCuaNoi_ButtonMouseDown);
      this.btnMoCuaNoi.ButtonMouseUp += new NhuaNong.UserControls.ucBtnMo.ButtonEventHandler(this.btnMoCuaNoi_ButtonMouseUp);
      // 
      // tinHieuCanSiloSBS
      // 
      this.tinHieuCanSiloSBS.BackColor = System.Drawing.Color.Transparent;
      this.tinHieuCanSiloSBS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinHieuCanSiloSBS.BackgroundImage")));
      this.tinHieuCanSiloSBS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.tinHieuCanSiloSBS.Location = new System.Drawing.Point(1010, 397);
      this.tinHieuCanSiloSBS.Name = "tinHieuCanSiloSBS";
      this.tinHieuCanSiloSBS.Size = new System.Drawing.Size(24, 24);
      this.tinHieuCanSiloSBS.TabIndex = 36;
      this.tinHieuCanSiloSBS.Visible = false;
      // 
      // tinHieuCanSiloAP
      // 
      this.tinHieuCanSiloAP.BackColor = System.Drawing.Color.Transparent;
      this.tinHieuCanSiloAP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinHieuCanSiloAP.BackgroundImage")));
      this.tinHieuCanSiloAP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.tinHieuCanSiloAP.Location = new System.Drawing.Point(896, 397);
      this.tinHieuCanSiloAP.Name = "tinHieuCanSiloAP";
      this.tinHieuCanSiloAP.Size = new System.Drawing.Size(24, 24);
      this.tinHieuCanSiloAP.TabIndex = 33;
      this.tinHieuCanSiloAP.Visible = false;
      // 
      // tinHieuCanSiloAGG5
      // 
      this.tinHieuCanSiloAGG5.BackColor = System.Drawing.Color.Transparent;
      this.tinHieuCanSiloAGG5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinHieuCanSiloAGG5.BackgroundImage")));
      this.tinHieuCanSiloAGG5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.tinHieuCanSiloAGG5.Location = new System.Drawing.Point(781, 397);
      this.tinHieuCanSiloAGG5.Name = "tinHieuCanSiloAGG5";
      this.tinHieuCanSiloAGG5.Size = new System.Drawing.Size(24, 24);
      this.tinHieuCanSiloAGG5.TabIndex = 30;
      this.tinHieuCanSiloAGG5.Visible = false;
      // 
      // tinHieuCanSiloAGG4
      // 
      this.tinHieuCanSiloAGG4.BackColor = System.Drawing.Color.Transparent;
      this.tinHieuCanSiloAGG4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinHieuCanSiloAGG4.BackgroundImage")));
      this.tinHieuCanSiloAGG4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.tinHieuCanSiloAGG4.Location = new System.Drawing.Point(694, 397);
      this.tinHieuCanSiloAGG4.Name = "tinHieuCanSiloAGG4";
      this.tinHieuCanSiloAGG4.Size = new System.Drawing.Size(24, 24);
      this.tinHieuCanSiloAGG4.TabIndex = 29;
      this.tinHieuCanSiloAGG4.Visible = false;
      // 
      // tinHieuCanSiloAGG3
      // 
      this.tinHieuCanSiloAGG3.BackColor = System.Drawing.Color.Transparent;
      this.tinHieuCanSiloAGG3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinHieuCanSiloAGG3.BackgroundImage")));
      this.tinHieuCanSiloAGG3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.tinHieuCanSiloAGG3.Location = new System.Drawing.Point(609, 397);
      this.tinHieuCanSiloAGG3.Name = "tinHieuCanSiloAGG3";
      this.tinHieuCanSiloAGG3.Size = new System.Drawing.Size(24, 24);
      this.tinHieuCanSiloAGG3.TabIndex = 28;
      this.tinHieuCanSiloAGG3.Visible = false;
      // 
      // tinHieuCanSiloAGG2
      // 
      this.tinHieuCanSiloAGG2.BackColor = System.Drawing.Color.Transparent;
      this.tinHieuCanSiloAGG2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinHieuCanSiloAGG2.BackgroundImage")));
      this.tinHieuCanSiloAGG2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.tinHieuCanSiloAGG2.Location = new System.Drawing.Point(522, 397);
      this.tinHieuCanSiloAGG2.Name = "tinHieuCanSiloAGG2";
      this.tinHieuCanSiloAGG2.Size = new System.Drawing.Size(24, 24);
      this.tinHieuCanSiloAGG2.TabIndex = 27;
      this.tinHieuCanSiloAGG2.Visible = false;
      // 
      // tinHieuCanSiloAGG1
      // 
      this.tinHieuCanSiloAGG1.BackColor = System.Drawing.Color.Transparent;
      this.tinHieuCanSiloAGG1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinHieuCanSiloAGG1.BackgroundImage")));
      this.tinHieuCanSiloAGG1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.tinHieuCanSiloAGG1.Location = new System.Drawing.Point(437, 397);
      this.tinHieuCanSiloAGG1.Name = "tinHieuCanSiloAGG1";
      this.tinHieuCanSiloAGG1.Size = new System.Drawing.Size(24, 24);
      this.tinHieuCanSiloAGG1.TabIndex = 26;
      this.tinHieuCanSiloAGG1.Visible = false;
      // 
      // tinHieuCanSiloFD
      // 
      this.tinHieuCanSiloFD.BackColor = System.Drawing.Color.Transparent;
      this.tinHieuCanSiloFD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinHieuCanSiloFD.BackgroundImage")));
      this.tinHieuCanSiloFD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.tinHieuCanSiloFD.Location = new System.Drawing.Point(334, 397);
      this.tinHieuCanSiloFD.Name = "tinHieuCanSiloFD";
      this.tinHieuCanSiloFD.Size = new System.Drawing.Size(24, 24);
      this.tinHieuCanSiloFD.TabIndex = 25;
      this.tinHieuCanSiloFD.Visible = false;
      // 
      // btnVanCanAGG5
      // 
      this.btnVanCanAGG5.BackColor = System.Drawing.Color.Silver;
      this.btnVanCanAGG5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVanCanAGG5.BackgroundImage")));
      this.btnVanCanAGG5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnVanCanAGG5.Bg_Click = null;
      this.btnVanCanAGG5.Bg_NoClick = null;
      this.btnVanCanAGG5.IsOn = false;
      this.btnVanCanAGG5.Location = new System.Drawing.Point(784, 371);
      this.btnVanCanAGG5.Name = "btnVanCanAGG5";
      this.btnVanCanAGG5.Size = new System.Drawing.Size(16, 16);
      this.btnVanCanAGG5.TabIndex = 24;
      this.btnVanCanAGG5.ButtonMouseDown += new NhuaNong.UserControls.ucBtnTron.DelButtonEventHandler(this.btnVanCanAGG5_ButtonMouseDown);
      this.btnVanCanAGG5.ButtonMouseUp += new NhuaNong.UserControls.ucBtnTron.DelButtonEventHandler(this.btnVanCanAGG5_ButtonMouseUp);
      // 
      // btnVanCanAGG4
      // 
      this.btnVanCanAGG4.BackColor = System.Drawing.Color.Silver;
      this.btnVanCanAGG4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVanCanAGG4.BackgroundImage")));
      this.btnVanCanAGG4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnVanCanAGG4.Bg_Click = null;
      this.btnVanCanAGG4.Bg_NoClick = null;
      this.btnVanCanAGG4.IsOn = false;
      this.btnVanCanAGG4.Location = new System.Drawing.Point(698, 371);
      this.btnVanCanAGG4.Name = "btnVanCanAGG4";
      this.btnVanCanAGG4.Size = new System.Drawing.Size(16, 16);
      this.btnVanCanAGG4.TabIndex = 23;
      this.btnVanCanAGG4.ButtonMouseDown += new NhuaNong.UserControls.ucBtnTron.DelButtonEventHandler(this.btnVanCanAGG4_ButtonMouseDown);
      this.btnVanCanAGG4.ButtonMouseUp += new NhuaNong.UserControls.ucBtnTron.DelButtonEventHandler(this.btnVanCanAGG4_ButtonMouseUp);
      // 
      // btnVanCanAGG3
      // 
      this.btnVanCanAGG3.BackColor = System.Drawing.Color.Silver;
      this.btnVanCanAGG3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVanCanAGG3.BackgroundImage")));
      this.btnVanCanAGG3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnVanCanAGG3.Bg_Click = null;
      this.btnVanCanAGG3.Bg_NoClick = null;
      this.btnVanCanAGG3.IsOn = false;
      this.btnVanCanAGG3.Location = new System.Drawing.Point(612, 371);
      this.btnVanCanAGG3.Name = "btnVanCanAGG3";
      this.btnVanCanAGG3.Size = new System.Drawing.Size(16, 16);
      this.btnVanCanAGG3.TabIndex = 22;
      this.btnVanCanAGG3.ButtonMouseDown += new NhuaNong.UserControls.ucBtnTron.DelButtonEventHandler(this.btnVanCanAGG3_ButtonMouseDown);
      this.btnVanCanAGG3.ButtonMouseUp += new NhuaNong.UserControls.ucBtnTron.DelButtonEventHandler(this.btnVanCanAGG3_ButtonMouseUp);
      // 
      // btnVanCanAGG2
      // 
      this.btnVanCanAGG2.BackColor = System.Drawing.Color.Silver;
      this.btnVanCanAGG2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVanCanAGG2.BackgroundImage")));
      this.btnVanCanAGG2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnVanCanAGG2.Bg_Click = null;
      this.btnVanCanAGG2.Bg_NoClick = null;
      this.btnVanCanAGG2.IsOn = false;
      this.btnVanCanAGG2.Location = new System.Drawing.Point(526, 371);
      this.btnVanCanAGG2.Name = "btnVanCanAGG2";
      this.btnVanCanAGG2.Size = new System.Drawing.Size(16, 16);
      this.btnVanCanAGG2.TabIndex = 21;
      this.btnVanCanAGG2.ButtonMouseDown += new NhuaNong.UserControls.ucBtnTron.DelButtonEventHandler(this.btnVanCanAGG2_ButtonMouseDown);
      this.btnVanCanAGG2.ButtonMouseUp += new NhuaNong.UserControls.ucBtnTron.DelButtonEventHandler(this.btnVanCanAGG2_ButtonMouseUp);
      // 
      // btnVanCanAGG1
      // 
      this.btnVanCanAGG1.BackColor = System.Drawing.Color.Silver;
      this.btnVanCanAGG1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVanCanAGG1.BackgroundImage")));
      this.btnVanCanAGG1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnVanCanAGG1.Bg_Click = null;
      this.btnVanCanAGG1.Bg_NoClick = null;
      this.btnVanCanAGG1.IsOn = false;
      this.btnVanCanAGG1.Location = new System.Drawing.Point(441, 371);
      this.btnVanCanAGG1.Name = "btnVanCanAGG1";
      this.btnVanCanAGG1.Size = new System.Drawing.Size(16, 16);
      this.btnVanCanAGG1.TabIndex = 20;
      this.btnVanCanAGG1.ButtonMouseDown += new NhuaNong.UserControls.ucBtnTron.DelButtonEventHandler(this.btnVanCanAGG1_ButtonMouseDown);
      this.btnVanCanAGG1.ButtonMouseUp += new NhuaNong.UserControls.ucBtnTron.DelButtonEventHandler(this.btnVanCanAGG1_ButtonMouseUp);
      // 
      // btnVanCanFD
      // 
      this.btnVanCanFD.BackColor = System.Drawing.Color.Silver;
      this.btnVanCanFD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVanCanFD.BackgroundImage")));
      this.btnVanCanFD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnVanCanFD.Bg_Click = global::NhuaNong.ResourceNhua._btnTronRun;
      this.btnVanCanFD.Bg_NoClick = global::NhuaNong.ResourceNhua._btnTron;
      this.btnVanCanFD.IsOn = false;
      this.btnVanCanFD.Location = new System.Drawing.Point(338, 371);
      this.btnVanCanFD.Name = "btnVanCanFD";
      this.btnVanCanFD.Size = new System.Drawing.Size(16, 16);
      this.btnVanCanFD.TabIndex = 19;
      this.btnVanCanFD.ButtonMouseDown += new NhuaNong.UserControls.ucBtnTron.DelButtonEventHandler(this.btnVanCanFD_ButtonMouseDown);
      this.btnVanCanFD.ButtonMouseUp += new NhuaNong.UserControls.ucBtnTron.DelButtonEventHandler(this.btnVanCanFD_ButtonMouseUp);
      // 
      // ucOngDanFD1
      // 
      this.ucOngDanFD1.BackColor = System.Drawing.Color.Transparent;
      this.ucOngDanFD1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucOngDanFD1.BackgroundImage")));
      this.ucOngDanFD1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucOngDanFD1.Location = new System.Drawing.Point(333, 508);
      this.ucOngDanFD1.Name = "ucOngDanFD1";
      this.ucOngDanFD1.Size = new System.Drawing.Size(130, 65);
      this.ucOngDanFD1.TabIndex = 213;
      // 
      // tinHieuXaCanAGG
      // 
      this.tinHieuXaCanAGG.BackColor = System.Drawing.Color.Transparent;
      this.tinHieuXaCanAGG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinHieuXaCanAGG.BackgroundImage")));
      this.tinHieuXaCanAGG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.tinHieuXaCanAGG.Location = new System.Drawing.Point(615, 540);
      this.tinHieuXaCanAGG.Name = "tinHieuXaCanAGG";
      this.tinHieuXaCanAGG.Size = new System.Drawing.Size(20, 30);
      this.tinHieuXaCanAGG.TabIndex = 55;
      this.tinHieuXaCanAGG.Visible = false;
      // 
      // tinHieuXaCanFD
      // 
      this.tinHieuXaCanFD.BackColor = System.Drawing.Color.LightSalmon;
      this.tinHieuXaCanFD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinHieuXaCanFD.BackgroundImage")));
      this.tinHieuXaCanFD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.tinHieuXaCanFD.Location = new System.Drawing.Point(439, 540);
      this.tinHieuXaCanFD.Name = "tinHieuXaCanFD";
      this.tinHieuXaCanFD.Size = new System.Drawing.Size(20, 30);
      this.tinHieuXaCanFD.TabIndex = 217;
      this.tinHieuXaCanFD.Visible = false;
      // 
      // slMeDaCanNoiTron
      // 
      this.slMeDaCanNoiTron.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.slMeDaCanNoiTron.Location = new System.Drawing.Point(539, 621);
      this.slMeDaCanNoiTron.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.slMeDaCanNoiTron.Name = "slMeDaCanNoiTron";
      this.slMeDaCanNoiTron.Size = new System.Drawing.Size(81, 31);
      this.slMeDaCanNoiTron.SoLuongMeCanTron = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.slMeDaCanNoiTron.SoLuongMeDaTron = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.slMeDaCanNoiTron.TabIndex = 221;
      // 
      // btnNoiTronR
      // 
      this.btnNoiTronR.BackColor = System.Drawing.Color.White;
      this.btnNoiTronR.BackgroundImage = global::NhuaNong.ResourceNhua._btnNoiTron;
      this.btnNoiTronR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnNoiTronR.Bg_Click = global::NhuaNong.ResourceNhua._btnNoiTronRun;
      this.btnNoiTronR.Bg_NoClick = global::NhuaNong.ResourceNhua._btnNoiTron;
      this.btnNoiTronR.IsOn = true;
      this.btnNoiTronR.IsTrangThai = NhuaNong.UserControls.ucBtnNoiTron.TrangThai.Stop;
      this.btnNoiTronR.Location = new System.Drawing.Point(784, 648);
      this.btnNoiTronR.Name = "btnNoiTronR";
      this.btnNoiTronR.Size = new System.Drawing.Size(32, 32);
      this.btnNoiTronR.TabIndex = 220;
      this.btnNoiTronR.ButtonMouseDown += new NhuaNong.UserControls.ucBtnNoiTron.DelButtonEventHandler(this.btnNoiTronR_ButtonMouseDown);
      this.btnNoiTronR.ButtonMouseUp += new NhuaNong.UserControls.ucBtnNoiTron.DelButtonEventHandler(this.btnNoiTronR_ButtonMouseUp);
      // 
      // btnNoiTronL
      // 
      this.btnNoiTronL.BackColor = System.Drawing.Color.White;
      this.btnNoiTronL.BackgroundImage = global::NhuaNong.ResourceNhua._btnNoiTron;
      this.btnNoiTronL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnNoiTronL.Bg_Click = global::NhuaNong.ResourceNhua._btnNoiTronRun;
      this.btnNoiTronL.Bg_NoClick = global::NhuaNong.ResourceNhua._btnNoiTron;
      this.btnNoiTronL.IsOn = true;
      this.btnNoiTronL.IsTrangThai = NhuaNong.UserControls.ucBtnNoiTron.TrangThai.Stop;
      this.btnNoiTronL.Location = new System.Drawing.Point(475, 648);
      this.btnNoiTronL.Name = "btnNoiTronL";
      this.btnNoiTronL.Size = new System.Drawing.Size(32, 32);
      this.btnNoiTronL.TabIndex = 219;
      this.btnNoiTronL.ButtonMouseDown += new NhuaNong.UserControls.ucBtnNoiTron.DelButtonEventHandler(this.btnNoiTronL_ButtonMouseDown);
      this.btnNoiTronL.ButtonMouseUp += new NhuaNong.UserControls.ucBtnNoiTron.DelButtonEventHandler(this.btnNoiTronL_ButtonMouseUp);
      // 
      // ucNoiTron1
      // 
      this.ucNoiTron1.BackColor = System.Drawing.Color.Transparent;
      this.ucNoiTron1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucNoiTron1.BackgroundImage")));
      this.ucNoiTron1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucNoiTron1.KL_TRON = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.ucNoiTron1.Location = new System.Drawing.Point(410, 572);
      this.ucNoiTron1.Name = "ucNoiTron1";
      this.ucNoiTron1.Size = new System.Drawing.Size(470, 160);
      this.ucNoiTron1.TabIndex = 218;
      this.ucNoiTron1.TG_THỰC_XA = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.ucNoiTron1.TG_TRON = new decimal(new int[] {
            0,
            0,
            0,
            0});
      // 
      // grcMeTronCur
      // 
      this.grcMeTronCur.Location = new System.Drawing.Point(21, 861);
      this.grcMeTronCur.MainView = this.grvMeTronCur;
      this.grcMeTronCur.Name = "grcMeTronCur";
      this.grcMeTronCur.Size = new System.Drawing.Size(1858, 50);
      this.grcMeTronCur.TabIndex = 224;
      this.grcMeTronCur.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvMeTronCur});
      // 
      // grvMeTronCur
      // 
      this.grvMeTronCur.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMaPhieuTron,
            this.gcSTTMeTron,
            this.ggcNgayTron,
            this.gcGioTron,
            this.gcKhachHang,
            this.gcCongTruong,
            this.gcTenMAC,
            this.gcKhoiLuong});
      this.grvMeTronCur.GridControl = this.grcMeTronCur;
      this.grvMeTronCur.Name = "grvMeTronCur";
      this.grvMeTronCur.OptionsFilter.ShowInHeaderSearchResults = DevExpress.XtraGrid.Views.Grid.ShowInHeaderSearchResultsMode.None;
      this.grvMeTronCur.OptionsFind.AllowFindPanel = false;
      this.grvMeTronCur.OptionsFind.ShowFindButton = false;
      this.grvMeTronCur.OptionsFind.ShowSearchNavButtons = false;
      this.grvMeTronCur.OptionsView.ShowGroupPanel = false;
      // 
      // gcMaPhieuTron
      // 
      this.gcMaPhieuTron.Caption = "Mã phiếu trộn";
      this.gcMaPhieuTron.FieldName = "MaPhieuTron";
      this.gcMaPhieuTron.Name = "gcMaPhieuTron";
      this.gcMaPhieuTron.OptionsColumn.AllowFocus = false;
      this.gcMaPhieuTron.OptionsColumn.ReadOnly = true;
      this.gcMaPhieuTron.Visible = true;
      this.gcMaPhieuTron.VisibleIndex = 0;
      // 
      // gcSTTMeTron
      // 
      this.gcSTTMeTron.Caption = "STT Mẻ";
      this.gcSTTMeTron.FieldName = "LnNo";
      this.gcSTTMeTron.Name = "gcSTTMeTron";
      this.gcSTTMeTron.OptionsColumn.AllowFocus = false;
      this.gcSTTMeTron.OptionsColumn.ReadOnly = true;
      this.gcSTTMeTron.Visible = true;
      this.gcSTTMeTron.VisibleIndex = 1;
      // 
      // ggcNgayTron
      // 
      this.ggcNgayTron.Caption = "Ngày trộn";
      this.ggcNgayTron.FieldName = "NgayMeTron";
      this.ggcNgayTron.Name = "ggcNgayTron";
      this.ggcNgayTron.OptionsColumn.AllowFocus = false;
      this.ggcNgayTron.OptionsColumn.ReadOnly = true;
      this.ggcNgayTron.Visible = true;
      this.ggcNgayTron.VisibleIndex = 2;
      // 
      // gcGioTron
      // 
      this.gcGioTron.Caption = "Giờ trộn";
      this.gcGioTron.FieldName = "Gio";
      this.gcGioTron.Name = "gcGioTron";
      this.gcGioTron.OptionsColumn.AllowFocus = false;
      this.gcGioTron.OptionsColumn.ReadOnly = true;
      this.gcGioTron.Visible = true;
      this.gcGioTron.VisibleIndex = 3;
      // 
      // gcKhachHang
      // 
      this.gcKhachHang.Caption = "Khách hàng";
      this.gcKhachHang.FieldName = "KH";
      this.gcKhachHang.Name = "gcKhachHang";
      this.gcKhachHang.OptionsColumn.AllowFocus = false;
      this.gcKhachHang.OptionsColumn.ReadOnly = true;
      this.gcKhachHang.Visible = true;
      this.gcKhachHang.VisibleIndex = 4;
      // 
      // gcCongTruong
      // 
      this.gcCongTruong.Caption = "Công trường";
      this.gcCongTruong.FieldName = "CT";
      this.gcCongTruong.Name = "gcCongTruong";
      this.gcCongTruong.OptionsColumn.AllowFocus = false;
      this.gcCongTruong.OptionsColumn.ReadOnly = true;
      this.gcCongTruong.Visible = true;
      this.gcCongTruong.VisibleIndex = 5;
      // 
      // gcTenMAC
      // 
      this.gcTenMAC.Caption = "Tên MAC";
      this.gcTenMAC.FieldName = "MAC";
      this.gcTenMAC.Name = "gcTenMAC";
      this.gcTenMAC.OptionsColumn.AllowFocus = false;
      this.gcTenMAC.OptionsColumn.ReadOnly = true;
      this.gcTenMAC.Visible = true;
      this.gcTenMAC.VisibleIndex = 6;
      // 
      // gcKhoiLuong
      // 
      this.gcKhoiLuong.Caption = "Khối lượng";
      this.gcKhoiLuong.FieldName = "KLMe";
      this.gcKhoiLuong.Name = "gcKhoiLuong";
      this.gcKhoiLuong.OptionsColumn.AllowFocus = false;
      this.gcKhoiLuong.OptionsColumn.ReadOnly = true;
      this.gcKhoiLuong.Visible = true;
      this.gcKhoiLuong.VisibleIndex = 7;
      // 
      // motorBomTuoiNhua
      // 
      this.motorBomTuoiNhua.BackColor = System.Drawing.Color.Transparent;
      this.motorBomTuoiNhua.BackgroundImage = global::NhuaNong.ResourceNhua._motor_mini;
      this.motorBomTuoiNhua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.motorBomTuoiNhua.Bg_Click = global::NhuaNong.ResourceNhua._motor_miniRun;
      this.motorBomTuoiNhua.Bg_NoClick = global::NhuaNong.ResourceNhua._motor_mini;
      this.motorBomTuoiNhua.IsOn = true;
      this.motorBomTuoiNhua.IsTrangThai = NhuaNong.UserControls.ucMotorMini.TrangThai.Stop;
      this.motorBomTuoiNhua.Location = new System.Drawing.Point(687, 528);
      this.motorBomTuoiNhua.Name = "motorBomTuoiNhua";
      this.motorBomTuoiNhua.Size = new System.Drawing.Size(43, 30);
      this.motorBomTuoiNhua.TabIndex = 225;
      this.motorBomTuoiNhua.ButtonMouseDown += new NhuaNong.UserControls.ucMotorMini.DelButtonEventHandler(this.motorBomTuoiNhua_ButtonMouseDown);
      this.motorBomTuoiNhua.ButtonMouseUp += new NhuaNong.UserControls.ucMotorMini.DelButtonEventHandler(this.motorBomTuoiNhua_ButtonMouseUp);
      // 
      // ucOngDanSB2
      // 
      this.ucOngDanSB2.BackColor = System.Drawing.Color.Transparent;
      this.ucOngDanSB2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucOngDanSB2.BackgroundImage")));
      this.ucOngDanSB2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ucOngDanSB2.Location = new System.Drawing.Point(721, 508);
      this.ucOngDanSB2.Name = "ucOngDanSB2";
      this.ucOngDanSB2.Size = new System.Drawing.Size(315, 65);
      this.ucOngDanSB2.TabIndex = 226;
      // 
      // btnXaHetAGG
      // 
      this.btnXaHetAGG.BackColor = System.Drawing.Color.Transparent;
      this.btnXaHetAGG.BackgroundImage = global::NhuaNong.ResourceNhua._btnVeSinhPheuAGG;
      this.btnXaHetAGG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnXaHetAGG.Bg_Click = global::NhuaNong.ResourceNhua._btnVeSinhPheuAGGRUN;
      this.btnXaHetAGG.Bg_NoClick = global::NhuaNong.ResourceNhua._btnVeSinhPheuAGG;
      this.btnXaHetAGG.IsOn = true;
      this.btnXaHetAGG.IsTrangThai = NhuaNong.UserControls.ucBtnXAHETAGG.TrangThai.Stop;
      this.btnXaHetAGG.Location = new System.Drawing.Point(869, 808);
      this.btnXaHetAGG.Name = "btnXaHetAGG";
      this.btnXaHetAGG.Size = new System.Drawing.Size(85, 47);
      this.btnXaHetAGG.TabIndex = 229;
      this.btnXaHetAGG.ButtonMouseDown += new NhuaNong.UserControls.ucBtnXAHETAGG.DelButtonEventHandler(this.btnXaHetAGG_ButtonMouseDown);
      this.btnXaHetAGG.ButtonMouseUp += new NhuaNong.UserControls.ucBtnXAHETAGG.DelButtonEventHandler(this.btnXaHetAGG_ButtonMouseUp);
      this.btnXaHetAGG.ButtonClick += new NhuaNong.UserControls.ucBtnXAHETAGG.DelButtonEventHandler(this.btnXaHetAGG_ButtonClick);
      // 
      // tinHieuBomTuoiNhua
      // 
      this.tinHieuBomTuoiNhua.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.tinHieuBomTuoiNhua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinHieuBomTuoiNhua.BackgroundImage")));
      this.tinHieuBomTuoiNhua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.tinHieuBomTuoiNhua.Location = new System.Drawing.Point(725, 540);
      this.tinHieuBomTuoiNhua.Name = "tinHieuBomTuoiNhua";
      this.tinHieuBomTuoiNhua.Size = new System.Drawing.Size(20, 30);
      this.tinHieuBomTuoiNhua.TabIndex = 230;
      this.tinHieuBomTuoiNhua.Visible = false;
      // 
      // tinHieuXaCanSBS
      // 
      this.tinHieuXaCanSBS.BackColor = System.Drawing.Color.LightCoral;
      this.tinHieuXaCanSBS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinHieuXaCanSBS.BackgroundImage")));
      this.tinHieuXaCanSBS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.tinHieuXaCanSBS.Location = new System.Drawing.Point(835, 540);
      this.tinHieuXaCanSBS.Name = "tinHieuXaCanSBS";
      this.tinHieuXaCanSBS.Size = new System.Drawing.Size(20, 30);
      this.tinHieuXaCanSBS.TabIndex = 231;
      this.tinHieuXaCanSBS.Visible = false;
      // 
      // tinHieuCuaNoiMo
      // 
      this.tinHieuCuaNoiMo.BackColor = System.Drawing.Color.Transparent;
      this.tinHieuCuaNoiMo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinHieuCuaNoiMo.BackgroundImage")));
      this.tinHieuCuaNoiMo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.tinHieuCuaNoiMo.Location = new System.Drawing.Point(506, 714);
      this.tinHieuCuaNoiMo.Name = "tinHieuCuaNoiMo";
      this.tinHieuCuaNoiMo.Size = new System.Drawing.Size(30, 15);
      this.tinHieuCuaNoiMo.TabIndex = 232;
      this.tinHieuCuaNoiMo.Visible = false;
      // 
      // tinHieuCuaNoiDong
      // 
      this.tinHieuCuaNoiDong.BackColor = System.Drawing.Color.Transparent;
      this.tinHieuCuaNoiDong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinHieuCuaNoiDong.BackgroundImage")));
      this.tinHieuCuaNoiDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.tinHieuCuaNoiDong.Location = new System.Drawing.Point(751, 714);
      this.tinHieuCuaNoiDong.Name = "tinHieuCuaNoiDong";
      this.tinHieuCuaNoiDong.Size = new System.Drawing.Size(30, 15);
      this.tinHieuCuaNoiDong.TabIndex = 233;
      this.tinHieuCuaNoiDong.Visible = false;
      // 
      // tinHieuXaCanAP
      // 
      this.tinHieuXaCanAP.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.tinHieuXaCanAP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinHieuXaCanAP.BackgroundImage")));
      this.tinHieuXaCanAP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.tinHieuXaCanAP.Location = new System.Drawing.Point(896, 511);
      this.tinHieuXaCanAP.Name = "tinHieuXaCanAP";
      this.tinHieuXaCanAP.Size = new System.Drawing.Size(20, 20);
      this.tinHieuXaCanAP.TabIndex = 234;
      this.tinHieuXaCanAP.Visible = false;
      // 
      // btnDauDot
      // 
      this.btnDauDot.BackColor = System.Drawing.Color.Transparent;
      this.btnDauDot.BackgroundImage = global::NhuaNong.ResourceNhua._tinhieutansayquay;
      this.btnDauDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnDauDot.Bg_Click = global::NhuaNong.ResourceNhua._tinhieutansayquayRun;
      this.btnDauDot.Bg_NoClick = global::NhuaNong.ResourceNhua._tinhieutansayquay;
      this.btnDauDot.IsOn = true;
      this.btnDauDot.IsTrangThai = NhuaNong.UserControls.ucTinHieuTanSayQuay.TrangThai.Stop;
      this.btnDauDot.Location = new System.Drawing.Point(956, 656);
      this.btnDauDot.Name = "btnDauDot";
      this.btnDauDot.Size = new System.Drawing.Size(48, 48);
      this.btnDauDot.TabIndex = 235;
      this.btnDauDot.ButtonMouseDown += new NhuaNong.UserControls.ucTinHieuTanSayQuay.ButtonEventHandler(this.btnDauDot_ButtonMouseDown);
      this.btnDauDot.ButtonMouseUp += new NhuaNong.UserControls.ucTinHieuTanSayQuay.ButtonEventHandler(this.btnDauDot_ButtonMouseUp);
      // 
      // tinHieuCuaMo
      // 
      this.tinHieuCuaMo.BackColor = System.Drawing.Color.Transparent;
      this.tinHieuCuaMo.BackgroundImage = global::NhuaNong.ResourceNhua._tinHieuCuaMo;
      this.tinHieuCuaMo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.tinHieuCuaMo.Location = new System.Drawing.Point(605, 745);
      this.tinHieuCuaMo.Name = "tinHieuCuaMo";
      this.tinHieuCuaMo.Size = new System.Drawing.Size(35, 25);
      this.tinHieuCuaMo.TabIndex = 236;
      this.tinHieuCuaMo.Visible = false;
      // 
      // tinHieuCuaDong
      // 
      this.tinHieuCuaDong.BackColor = System.Drawing.Color.Transparent;
      this.tinHieuCuaDong.BackgroundImage = global::NhuaNong.ResourceNhua._tinHieuCuaDong;
      this.tinHieuCuaDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.tinHieuCuaDong.Location = new System.Drawing.Point(646, 745);
      this.tinHieuCuaDong.Name = "tinHieuCuaDong";
      this.tinHieuCuaDong.Size = new System.Drawing.Size(35, 25);
      this.tinHieuCuaDong.TabIndex = 237;
      this.tinHieuCuaDong.Visible = false;
      // 
      // btnPheuSBS
      // 
      this.btnPheuSBS.BackColor = System.Drawing.Color.DarkGray;
      this.btnPheuSBS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnPheuSBS.BGColor = NhuaNong.UserControls.ucBtnXaCan.BGColorEnum.Gray;
      this.btnPheuSBS.IsOn = true;
      this.btnPheuSBS.IsRun = false;
      this.btnPheuSBS.IsTrangThai = NhuaNong.UserControls.ucBtnXaCan.TrangThai.Stop;
      this.btnPheuSBS.Location = new System.Drawing.Point(1302, 256);
      this.btnPheuSBS.Name = "btnPheuSBS";
      this.btnPheuSBS.Size = new System.Drawing.Size(36, 41);
      this.btnPheuSBS.TabIndex = 238;
      this.btnPheuSBS.ButtonClick += new NhuaNong.UserControls.ucBtnXaCan.DelButtonEventHandler(this.btnPheuSBS_ButtonClick);
      // 
      // VanHanh
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Gainsboro;
      this.Controls.Add(this.btnPheuSBS);
      this.Controls.Add(this.tinHieuCuaDong);
      this.Controls.Add(this.tinHieuCuaMo);
      this.Controls.Add(this.btnDauDot);
      this.Controls.Add(this.tinHieuXaCanAP);
      this.Controls.Add(this.tinHieuCuaNoiDong);
      this.Controls.Add(this.tinHieuCuaNoiMo);
      this.Controls.Add(this.tinHieuXaCanSBS);
      this.Controls.Add(this.tinHieuBomTuoiNhua);
      this.Controls.Add(this.btnXaHetAGG);
      this.Controls.Add(this.ucOngDanSB2);
      this.Controls.Add(this.motorBomTuoiNhua);
      this.Controls.Add(this.grcMeTronCur);
      this.Controls.Add(this.slMeDaCanNoiTron);
      this.Controls.Add(this.btnNoiTronR);
      this.Controls.Add(this.btnNoiTronL);
      this.Controls.Add(this.ucNoiTron1);
      this.Controls.Add(this.tinHieuXaCanFD);
      this.Controls.Add(this.ucOngDanFD1);
      this.Controls.Add(this.VAA);
      this.Controls.Add(this.groupControl1);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.btnCheDoXaCan);
      this.Controls.Add(this.btnTanSay);
      this.Controls.Add(this.ucBtnVitTai1);
      this.Controls.Add(this.btnSanRung);
      this.Controls.Add(this.tinHieuMoCuaNoi);
      this.Controls.Add(this.tinHieuDongCuaNoi);
      this.Controls.Add(this.tinHieuSanRung);
      this.Controls.Add(this.checkDaat);
      this.Controls.Add(this.lblMAC);
      this.Controls.Add(this.ucBangGauTauCatDaNhanh1);
      this.Controls.Add(this.ucBangGauTaiCatDa1);
      this.Controls.Add(this.motorGauTaiAGG1);
      this.Controls.Add(this.btnRungCL3);
      this.Controls.Add(this.btnRungCL2);
      this.Controls.Add(this.btnRungCL1);
      this.Controls.Add(this.ucBeTiep1);
      this.Controls.Add(this.ucBangGauTaiXiMang2);
      this.Controls.Add(this.btnFU_SBS);
      this.Controls.Add(this.btnFU_AP);
      this.Controls.Add(this.btnFU_AGG5);
      this.Controls.Add(this.btnFU_AGG4);
      this.Controls.Add(this.btnFU_AGG3);
      this.Controls.Add(this.btnFU_AGG2);
      this.Controls.Add(this.btnFU_AG1);
      this.Controls.Add(this.btnFU_FD);
      this.Controls.Add(this.barFullSiloFD);
      this.Controls.Add(this.ucBangGauTaiXiMangNhanh1);
      this.Controls.Add(this.slMeDaCanSBS);
      this.Controls.Add(this.slMeDaCanAP);
      this.Controls.Add(this.slMeDaCanAGG);
      this.Controls.Add(this.slMeDaCanFD);
      this.Controls.Add(this.tinHieuBaoMucThapFD);
      this.Controls.Add(this.tinHieuBaoMucCaoFD);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.textEdit4);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.textEdit2);
      this.Controls.Add(this.siloFDFat);
      this.Controls.Add(this.tinHIeuVitTaiFD);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.memoEdit1);
      this.Controls.Add(this.btnMayNenKhi);
      this.Controls.Add(this.ucBomKhi1);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.txtTG_BomTuoiNhua);
      this.Controls.Add(this.textEdit3);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.textEdit1);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.barFullSiloSBS);
      this.Controls.Add(this.btnVanCanSBS);
      this.Controls.Add(this.siloSBS);
      this.Controls.Add(this.ucOngSBS1);
      this.Controls.Add(this.btnVanCanAP);
      this.Controls.Add(this.siloAP);
      this.Controls.Add(this.ucPheuChua011);
      this.Controls.Add(this.motorPheuChua01);
      this.Controls.Add(this.ucOngAP1);
      this.Controls.Add(this.ucOngMotor1);
      this.Controls.Add(this.ucBonChuaTanSay1);
      this.Controls.Add(this.bomNgamPheuChua);
      this.Controls.Add(this.ucPheuChua041);
      this.Controls.Add(this.ucOngPheuChua041);
      this.Controls.Add(this.ucOngPheuChua031);
      this.Controls.Add(this.ucOngBonChuaKhi1);
      this.Controls.Add(this.ucOngTanSay1);
      this.Controls.Add(this.connectStus);
      this.Controls.Add(this.bangTaiXien);
      this.Controls.Add(this.bangTaiCan);
      this.Controls.Add(this.tinHieuXaCanAGG5);
      this.Controls.Add(this.tinHieuXaCanAGG4);
      this.Controls.Add(this.tinHieuXaCanAGG3);
      this.Controls.Add(this.tinHieuXaCanAGG2);
      this.Controls.Add(this.tinHieuXaCanAGG1);
      this.Controls.Add(this.btnXaCanAGG5);
      this.Controls.Add(this.btnXaCanAGG4);
      this.Controls.Add(this.btnXaCanAGG3);
      this.Controls.Add(this.btnXaCanAGG2);
      this.Controls.Add(this.btnXaCanAGG1);
      this.Controls.Add(this.ucPheuChuaCatDa5);
      this.Controls.Add(this.ucPheuChuaCatDa4);
      this.Controls.Add(this.ucPheuChuaCatDa3);
      this.Controls.Add(this.ucPheuChuaCatDa2);
      this.Controls.Add(this.ucPheuChuaCatDa1);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.motorPheuChua02);
      this.Controls.Add(this.ucPheuChua031);
      this.Controls.Add(this.ucPheuChua021);
      this.Controls.Add(this.ucMotorExtra1);
      this.Controls.Add(this.motorBomDau);
      this.Controls.Add(this.tinHieuTanSayLua);
      this.Controls.Add(this.motorGauTaiFD);
      this.Controls.Add(this.sanRung);
      this.Controls.Add(this.ucBonChuaKhi1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lblHeThong);
      this.Controls.Add(this.btnCheDoCuaNoi);
      this.Controls.Add(this.btnCheDoNapLieu);
      this.Controls.Add(this.btnCheDoHeThong);
      this.Controls.Add(this.btnSIM);
      this.Controls.Add(this.btnHuy);
      this.Controls.Add(this.btnDung);
      this.Controls.Add(this.btnBatDau);
      this.Controls.Add(this.btnDongCuaNoi);
      this.Controls.Add(this.btnMoCuaNoi);
      this.Controls.Add(this.tinHieuXaCanAGG);
      this.Controls.Add(this.btnXaCanSBS);
      this.Controls.Add(this.btnXaCanAGG);
      this.Controls.Add(this.btnXaCanAP);
      this.Controls.Add(this.btnXaCanFD);
      this.Controls.Add(this.weighSBS);
      this.Controls.Add(this.weighAP);
      this.Controls.Add(this.weighAGG1);
      this.Controls.Add(this.weighAGG2);
      this.Controls.Add(this.weighAGG3);
      this.Controls.Add(this.weighAGG4);
      this.Controls.Add(this.weighAGG5);
      this.Controls.Add(this.weighFD);
      this.Controls.Add(this.barFullSiloAGG5);
      this.Controls.Add(this.barFullSiloAGG4);
      this.Controls.Add(this.barFullSiloAGG3);
      this.Controls.Add(this.barFullSiloAGG2);
      this.Controls.Add(this.barFullSiloAGG1);
      this.Controls.Add(this.tinHieuCanSiloSBS);
      this.Controls.Add(this.tinHieuCanSiloAP);
      this.Controls.Add(this.tinHieuCanSiloAGG5);
      this.Controls.Add(this.tinHieuCanSiloAGG4);
      this.Controls.Add(this.tinHieuCanSiloAGG3);
      this.Controls.Add(this.tinHieuCanSiloAGG2);
      this.Controls.Add(this.tinHieuCanSiloAGG1);
      this.Controls.Add(this.tinHieuCanSiloFD);
      this.Controls.Add(this.btnVanCanAGG5);
      this.Controls.Add(this.btnVanCanAGG4);
      this.Controls.Add(this.btnVanCanAGG3);
      this.Controls.Add(this.btnVanCanAGG2);
      this.Controls.Add(this.btnVanCanAGG1);
      this.Controls.Add(this.btnVanCanFD);
      this.Controls.Add(this.siloAgg5);
      this.Controls.Add(this.siloAgg4);
      this.Controls.Add(this.siloAgg3);
      this.Controls.Add(this.siloAgg2);
      this.Controls.Add(this.siloAgg1);
      this.Controls.Add(this.siloFD);
      this.Name = "VanHanh";
      this.Size = new System.Drawing.Size(1920, 1096);
      this.Load += new System.EventHandler(this.VanHanh_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
      this.groupControl1.ResumeLayout(false);
      this.groupControl1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieuTron.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtCongTruong.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtKhachHang.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtKhoiLuong.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtMAC.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gluHopDong.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.glueHopDong)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.glueBienSo.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gluTaiXe.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.VAA)).EndInit();
      this.VAA.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTG_BomTuoiNhua.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grcMeTronCur)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grvMeTronCur)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }
  }
}

