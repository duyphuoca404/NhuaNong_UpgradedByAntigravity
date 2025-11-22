using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using NhuaNong.Data;
using NhuaNong.Utils;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NhuaNong.MasterData
{
  public partial class NewPhieuTronView
  {
    private IContainer components;
    private PanelControl pnlMain;
    private LabelControl lblMaPhieuTron;
    private LabelControl lblKLConLaiTrenLyThuyet;
    private LabelControl lblMaHopDong;
    private PanelControl pnlCommand;
    private LabelControl lblGhiChu;
    private LabelControl lblXe;
    private LabelControl lblTaiXe;
    private LabelControl lblNgayTao;
    private LabelControl lblKLTronDuTinh;
    private LabelControl lblKLXeChoLonNhat;
    private LabelControl lblKLTronLonNhat;
    private LabelControl lblKLTronNhoNhat;
    private TextEdit txtMoTa;
    private LookUpEdit lueXe;
    private LookUpEdit lueTaiXe;
    private DateEdit datNgayPhieuTron;
    private TextEdit txtMaPhieuTron;
    private ButtonEdit bteMaHopDong;
    private LabelControl lblSLMeDaTron;
    private LabelControl lblSLMeHIeuChinh;
    private LabelControl lblSLMeDuTinh;
    private LabelControl lblKLDTTMM;
    private SpinEdit spnMaxKLTron;
    private SpinEdit spnMinKLTron;
    private SpinEdit spnKLLyThuyetCL;
    private SpinEdit spnMTCommitedQty;
    private SpinEdit spnMTHieuChinhQty;
    private SpinEdit spnMTQty;
    private SpinEdit spnKLDTMeTron;
    private SpinEdit spnKLDTPhieuTron;
    private SpinEdit spnMaxKLXeCho;
    private SimpleButton btnClose;
    private SimpleButton btnSave;
    private SimpleButton btnSaveNew;
    private SpinEdit spnKLTTPhieuTron;
    private LabelControl labelControl1;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.pnlMain = new PanelControl();
      this.spnKLTTPhieuTron = new SpinEdit();
      this.labelControl1 = new LabelControl();
      this.spnMTCommitedQty = new SpinEdit();
      this.spnMTHieuChinhQty = new SpinEdit();
      this.spnMTQty = new SpinEdit();
      this.spnKLDTMeTron = new SpinEdit();
      this.spnKLDTPhieuTron = new SpinEdit();
      this.spnMaxKLXeCho = new SpinEdit();
      this.spnMaxKLTron = new SpinEdit();
      this.spnMinKLTron = new SpinEdit();
      this.spnKLLyThuyetCL = new SpinEdit();
      this.txtMoTa = new TextEdit();
      this.lueXe = new LookUpEdit();
      this.lueTaiXe = new LookUpEdit();
      this.datNgayPhieuTron = new DateEdit();
      this.txtMaPhieuTron = new TextEdit();
      this.bteMaHopDong = new ButtonEdit();
      this.lblSLMeDaTron = new LabelControl();
      this.lblSLMeHIeuChinh = new LabelControl();
      this.lblSLMeDuTinh = new LabelControl();
      this.lblKLDTTMM = new LabelControl();
      this.lblKLTronDuTinh = new LabelControl();
      this.lblKLXeChoLonNhat = new LabelControl();
      this.lblKLTronLonNhat = new LabelControl();
      this.lblKLTronNhoNhat = new LabelControl();
      this.lblGhiChu = new LabelControl();
      this.lblXe = new LabelControl();
      this.lblTaiXe = new LabelControl();
      this.lblNgayTao = new LabelControl();
      this.lblMaPhieuTron = new LabelControl();
      this.lblKLConLaiTrenLyThuyet = new LabelControl();
      this.lblMaHopDong = new LabelControl();
      this.pnlCommand = new PanelControl();
      this.btnClose = new SimpleButton();
      this.btnSave = new SimpleButton();
      this.btnSaveNew = new SimpleButton();
      this.pnlMain.BeginInit();
      this.pnlMain.SuspendLayout();
      this.spnKLTTPhieuTron.Properties.BeginInit();
      this.spnMTCommitedQty.Properties.BeginInit();
      this.spnMTHieuChinhQty.Properties.BeginInit();
      this.spnMTQty.Properties.BeginInit();
      this.spnKLDTMeTron.Properties.BeginInit();
      this.spnKLDTPhieuTron.Properties.BeginInit();
      this.spnMaxKLXeCho.Properties.BeginInit();
      this.spnMaxKLTron.Properties.BeginInit();
      this.spnMinKLTron.Properties.BeginInit();
      this.spnKLLyThuyetCL.Properties.BeginInit();
      this.txtMoTa.Properties.BeginInit();
      this.lueXe.Properties.BeginInit();
      this.lueTaiXe.Properties.BeginInit();
      this.datNgayPhieuTron.Properties.CalendarTimeProperties.BeginInit();
      this.datNgayPhieuTron.Properties.BeginInit();
      this.txtMaPhieuTron.Properties.BeginInit();
      this.bteMaHopDong.Properties.BeginInit();
      this.pnlCommand.BeginInit();
      this.pnlCommand.SuspendLayout();
      this.SuspendLayout();
      this.pnlMain.Controls.Add((Control)this.spnKLTTPhieuTron);
      this.pnlMain.Controls.Add((Control)this.labelControl1);
      this.pnlMain.Controls.Add((Control)this.spnMTCommitedQty);
      this.pnlMain.Controls.Add((Control)this.spnMTHieuChinhQty);
      this.pnlMain.Controls.Add((Control)this.spnMTQty);
      this.pnlMain.Controls.Add((Control)this.spnKLDTMeTron);
      this.pnlMain.Controls.Add((Control)this.spnKLDTPhieuTron);
      this.pnlMain.Controls.Add((Control)this.spnMaxKLXeCho);
      this.pnlMain.Controls.Add((Control)this.spnMaxKLTron);
      this.pnlMain.Controls.Add((Control)this.spnMinKLTron);
      this.pnlMain.Controls.Add((Control)this.spnKLLyThuyetCL);
      this.pnlMain.Controls.Add((Control)this.txtMoTa);
      this.pnlMain.Controls.Add((Control)this.lueXe);
      this.pnlMain.Controls.Add((Control)this.lueTaiXe);
      this.pnlMain.Controls.Add((Control)this.datNgayPhieuTron);
      this.pnlMain.Controls.Add((Control)this.txtMaPhieuTron);
      this.pnlMain.Controls.Add((Control)this.bteMaHopDong);
      this.pnlMain.Controls.Add((Control)this.lblSLMeDaTron);
      this.pnlMain.Controls.Add((Control)this.lblSLMeHIeuChinh);
      this.pnlMain.Controls.Add((Control)this.lblSLMeDuTinh);
      this.pnlMain.Controls.Add((Control)this.lblKLDTTMM);
      this.pnlMain.Controls.Add((Control)this.lblKLTronDuTinh);
      this.pnlMain.Controls.Add((Control)this.lblKLXeChoLonNhat);
      this.pnlMain.Controls.Add((Control)this.lblKLTronLonNhat);
      this.pnlMain.Controls.Add((Control)this.lblKLTronNhoNhat);
      this.pnlMain.Controls.Add((Control)this.lblGhiChu);
      this.pnlMain.Controls.Add((Control)this.lblXe);
      this.pnlMain.Controls.Add((Control)this.lblTaiXe);
      this.pnlMain.Controls.Add((Control)this.lblNgayTao);
      this.pnlMain.Controls.Add((Control)this.lblMaPhieuTron);
      this.pnlMain.Controls.Add((Control)this.lblKLConLaiTrenLyThuyet);
      this.pnlMain.Controls.Add((Control)this.lblMaHopDong);
      this.pnlMain.Dock = DockStyle.Fill;
      this.pnlMain.Location = new Point(0, 0);
      this.pnlMain.Margin = new Padding(2);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new Size(907, 315);
      this.pnlMain.TabIndex = 0;
      this.spnKLTTPhieuTron.EditValue = (object)new Decimal(new int[4]);
      this.spnKLTTPhieuTron.Location = new Point(736, 33);
      this.spnKLTTPhieuTron.Margin = new Padding(2);
      this.spnKLTTPhieuTron.Name = "spnKLTTPhieuTron";
      this.spnKLTTPhieuTron.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.spnKLTTPhieuTron.Properties.Appearance.Options.UseFont = true;
      this.spnKLTTPhieuTron.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnKLTTPhieuTron.Size = new Size(133, 22);
      this.spnKLTTPhieuTron.TabIndex = 31;
      this.labelControl1.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(686, 37);
      this.labelControl1.Margin = new Padding(2);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(36, 16);
      this.labelControl1.TabIndex = 30;
      this.labelControl1.Text = "Luỹ kế";
      this.spnMTCommitedQty.EditValue = (object)new Decimal(new int[4]);
      this.spnMTCommitedQty.Location = new Point(736, 176);
      this.spnMTCommitedQty.Margin = new Padding(2);
      this.spnMTCommitedQty.Name = "spnMTCommitedQty";
      this.spnMTCommitedQty.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.spnMTCommitedQty.Properties.Appearance.Options.UseFont = true;
      this.spnMTCommitedQty.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnMTCommitedQty.Size = new Size(132, 22);
      this.spnMTCommitedQty.TabIndex = 29;
      this.spnMTHieuChinhQty.EditValue = (object)new Decimal(new int[4]);
      this.spnMTHieuChinhQty.Location = new Point(734, 141);
      this.spnMTHieuChinhQty.Margin = new Padding(2);
      this.spnMTHieuChinhQty.Name = "spnMTHieuChinhQty";
      this.spnMTHieuChinhQty.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.spnMTHieuChinhQty.Properties.Appearance.Options.UseFont = true;
      this.spnMTHieuChinhQty.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnMTHieuChinhQty.Size = new Size(132, 22);
      this.spnMTHieuChinhQty.TabIndex = 28;
      this.spnMTQty.EditValue = (object)new Decimal(new int[4]);
      this.spnMTQty.Location = new Point(734, 108);
      this.spnMTQty.Margin = new Padding(2);
      this.spnMTQty.Name = "spnMTQty";
      this.spnMTQty.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.spnMTQty.Properties.Appearance.Options.UseFont = true;
      this.spnMTQty.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnMTQty.Size = new Size(132, 22);
      this.spnMTQty.TabIndex = 27;
      this.spnKLDTMeTron.EditValue = (object)new Decimal(new int[4]);
      this.spnKLDTMeTron.Location = new Point(734, 72);
      this.spnKLDTMeTron.Margin = new Padding(2);
      this.spnKLDTMeTron.Name = "spnKLDTMeTron";
      this.spnKLDTMeTron.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.spnKLDTMeTron.Properties.Appearance.Options.UseFont = true;
      this.spnKLDTMeTron.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnKLDTMeTron.Size = new Size(132, 22);
      this.spnKLDTMeTron.TabIndex = 26;
      this.spnKLDTPhieuTron.EditValue = (object)new Decimal(new int[4]);
      this.spnKLDTPhieuTron.Location = new Point(413, 176);
      this.spnKLDTPhieuTron.Margin = new Padding(2);
      this.spnKLDTPhieuTron.Name = "spnKLDTPhieuTron";
      this.spnKLDTPhieuTron.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.spnKLDTPhieuTron.Properties.Appearance.Options.UseFont = true;
      this.spnKLDTPhieuTron.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnKLDTPhieuTron.Size = new Size(132, 22);
      this.spnKLDTPhieuTron.TabIndex = 25;
      this.spnMaxKLXeCho.EditValue = (object)new Decimal(new int[4]);
      this.spnMaxKLXeCho.Location = new Point(412, 141);
      this.spnMaxKLXeCho.Margin = new Padding(2);
      this.spnMaxKLXeCho.Name = "spnMaxKLXeCho";
      this.spnMaxKLXeCho.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.spnMaxKLXeCho.Properties.Appearance.Options.UseFont = true;
      this.spnMaxKLXeCho.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnMaxKLXeCho.Size = new Size(132, 22);
      this.spnMaxKLXeCho.TabIndex = 24;
      this.spnMaxKLTron.EditValue = (object)new Decimal(new int[4]);
      this.spnMaxKLTron.Location = new Point(413, 109);
      this.spnMaxKLTron.Margin = new Padding(2);
      this.spnMaxKLTron.Name = "spnMaxKLTron";
      this.spnMaxKLTron.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.spnMaxKLTron.Properties.Appearance.Options.UseFont = true;
      this.spnMaxKLTron.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnMaxKLTron.Size = new Size(134, 22);
      this.spnMaxKLTron.TabIndex = 23;
      this.spnMinKLTron.EditValue = (object)new Decimal(new int[4]);
      this.spnMinKLTron.Location = new Point(413, 75);
      this.spnMinKLTron.Margin = new Padding(2);
      this.spnMinKLTron.Name = "spnMinKLTron";
      this.spnMinKLTron.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.spnMinKLTron.Properties.Appearance.Options.UseFont = true;
      this.spnMinKLTron.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnMinKLTron.Size = new Size(133, 22);
      this.spnMinKLTron.TabIndex = 22;
      this.spnKLLyThuyetCL.EditValue = (object)new Decimal(new int[4]);
      this.spnKLLyThuyetCL.Location = new Point(413, 34);
      this.spnKLLyThuyetCL.Margin = new Padding(2);
      this.spnKLLyThuyetCL.Name = "spnKLLyThuyetCL";
      this.spnKLLyThuyetCL.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.spnKLLyThuyetCL.Properties.Appearance.Options.UseFont = true;
      this.spnKLLyThuyetCL.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnKLLyThuyetCL.Size = new Size(133, 22);
      this.spnKLLyThuyetCL.TabIndex = 21;
      this.txtMoTa.Location = new Point(125, 210);
      this.txtMoTa.Margin = new Padding(2);
      this.txtMoTa.Name = "txtMoTa";
      this.txtMoTa.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtMoTa.Properties.Appearance.Options.UseFont = true;
      this.txtMoTa.Size = new Size(422, 22);
      this.txtMoTa.TabIndex = 20;
      this.lueXe.Location = new Point(125, 176);
      this.lueXe.Margin = new Padding(2);
      this.lueXe.Name = "lueXe";
      this.lueXe.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lueXe.Properties.Appearance.Options.UseFont = true;
      this.lueXe.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueXe.Properties.Columns.AddRange(new LookUpColumnInfo[3]
      {
        new LookUpColumnInfo("XeID", "ID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("BienSo", "Biển Số"),
        new LookUpColumnInfo("KhoiLuong", "KL Chở")
      });
      this.lueXe.Properties.DisplayMember = "BienSo";
      this.lueXe.Properties.NullText = "";
      this.lueXe.Properties.ValueMember = "XeID";
      this.lueXe.Size = new Size(133, 22);
      this.lueXe.TabIndex = 19;
      this.lueXe.EditValueChanged += new EventHandler(this.lueXe_EditValueChanged);
      this.lueTaiXe.Location = new Point(125, 142);
      this.lueTaiXe.Margin = new Padding(2);
      this.lueTaiXe.Name = "lueTaiXe";
      this.lueTaiXe.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lueTaiXe.Properties.Appearance.Options.UseFont = true;
      this.lueTaiXe.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueTaiXe.Properties.Columns.AddRange(new LookUpColumnInfo[3]
      {
        new LookUpColumnInfo("TaiXeID", "ID"),
        new LookUpColumnInfo("MaTaiXe", "Mã Tài xế"),
        new LookUpColumnInfo("TenTaiXe", "Tên Tài xế")
      });
      this.lueTaiXe.Properties.DisplayMember = "TenTaiXe";
      this.lueTaiXe.Properties.NullText = "";
      this.lueTaiXe.Properties.ShowFooter = false;
      this.lueTaiXe.Properties.ValueMember = "TaiXeID";
      this.lueTaiXe.Size = new Size(133, 22);
      this.lueTaiXe.TabIndex = 18;
      this.lueTaiXe.EditValueChanged += new EventHandler(this.lueTaiXe_EditValueChanged);
      this.datNgayPhieuTron.EditValue = (object)null;
      this.datNgayPhieuTron.Location = new Point(125, 109);
      this.datNgayPhieuTron.Margin = new Padding(2);
      this.datNgayPhieuTron.Name = "datNgayPhieuTron";
      this.datNgayPhieuTron.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.datNgayPhieuTron.Properties.Appearance.Options.UseFont = true;
      this.datNgayPhieuTron.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datNgayPhieuTron.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datNgayPhieuTron.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
      this.datNgayPhieuTron.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.datNgayPhieuTron.Properties.EditFormat.FormatString = "dd/MM/yyyy";
      this.datNgayPhieuTron.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.datNgayPhieuTron.Properties.Mask.EditMask = "dd/MM/yyyy";
      this.datNgayPhieuTron.Size = new Size(133, 22);
      this.datNgayPhieuTron.TabIndex = 17;
      this.txtMaPhieuTron.Location = new Point(125, 76);
      this.txtMaPhieuTron.Margin = new Padding(2);
      this.txtMaPhieuTron.Name = "txtMaPhieuTron";
      this.txtMaPhieuTron.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtMaPhieuTron.Properties.Appearance.Options.UseFont = true;
      this.txtMaPhieuTron.Size = new Size(133, 22);
      this.txtMaPhieuTron.TabIndex = 16;
      this.bteMaHopDong.Location = new Point(125, 34);
      this.bteMaHopDong.Margin = new Padding(2);
      this.bteMaHopDong.Name = "bteMaHopDong";
      this.bteMaHopDong.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.bteMaHopDong.Properties.Appearance.Options.UseFont = true;
      this.bteMaHopDong.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton()
      });
      this.bteMaHopDong.Size = new Size(133, 22);
      this.bteMaHopDong.TabIndex = 15;
      this.bteMaHopDong.ButtonPressed += new ButtonPressedEventHandler(this.bteMaHopDong_ButtonPressed);
      this.lblSLMeDaTron.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblSLMeDaTron.Appearance.Options.UseFont = true;
      this.lblSLMeDaTron.Location = new Point(640, 178);
      this.lblSLMeDaTron.Margin = new Padding(2);
      this.lblSLMeDaTron.Name = "lblSLMeDaTron";
      this.lblSLMeDaTron.Size = new Size(80, 16);
      this.lblSLMeDaTron.TabIndex = 14;
      this.lblSLMeDaTron.Text = "SL Mẻ đã trộn";
      this.lblSLMeHIeuChinh.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblSLMeHIeuChinh.Appearance.Options.UseFont = true;
      this.lblSLMeHIeuChinh.Location = new Point(626, 145);
      this.lblSLMeHIeuChinh.Margin = new Padding(2);
      this.lblSLMeHIeuChinh.Name = "lblSLMeHIeuChinh";
      this.lblSLMeHIeuChinh.Size = new Size(97, 16);
      this.lblSLMeHIeuChinh.TabIndex = 13;
      this.lblSLMeHIeuChinh.Text = "SL Mẻ hiệu chỉnh";
      this.lblSLMeDuTinh.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblSLMeDuTinh.Appearance.Options.UseFont = true;
      this.lblSLMeDuTinh.Location = new Point(641, 111);
      this.lblSLMeDuTinh.Margin = new Padding(2);
      this.lblSLMeDuTinh.Name = "lblSLMeDuTinh";
      this.lblSLMeDuTinh.Size = new Size(79, 16);
      this.lblSLMeDuTinh.TabIndex = 12;
      this.lblSLMeDuTinh.Text = "SL Mẻ dự tính";
      this.lblKLDTTMM.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblKLDTTMM.Appearance.Options.UseFont = true;
      this.lblKLDTTMM.Location = new Point(564, 78);
      this.lblKLDTTMM.Margin = new Padding(2);
      this.lblKLDTTMM.Name = "lblKLDTTMM";
      this.lblKLDTTMM.Size = new Size(162, 16);
      this.lblKLDTTMM.TabIndex = 11;
      this.lblKLDTTMM.Text = "KL Trộn dự tính trên mỗi mẻ";
      this.lblKLTronDuTinh.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblKLTronDuTinh.Appearance.Options.UseFont = true;
      this.lblKLTronDuTinh.Location = new Point(304, 178);
      this.lblKLTronDuTinh.Margin = new Padding(2);
      this.lblKLTronDuTinh.Name = "lblKLTronDuTinh";
      this.lblKLTronDuTinh.Size = new Size(88, 16);
      this.lblKLTronDuTinh.TabIndex = 10;
      this.lblKLTronDuTinh.Text = "KL Trộn dự tính";
      this.lblKLXeChoLonNhat.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblKLXeChoLonNhat.Appearance.Options.UseFont = true;
      this.lblKLXeChoLonNhat.Location = new Point(287, 144);
      this.lblKLXeChoLonNhat.Margin = new Padding(2);
      this.lblKLXeChoLonNhat.Name = "lblKLXeChoLonNhat";
      this.lblKLXeChoLonNhat.Size = new Size(106, 16);
      this.lblKLXeChoLonNhat.TabIndex = 9;
      this.lblKLXeChoLonNhat.Text = "KL Xe chở lớn nhất";
      this.lblKLTronLonNhat.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblKLTronLonNhat.Appearance.Options.UseFont = true;
      this.lblKLTronLonNhat.Location = new Point(299, 110);
      this.lblKLTronLonNhat.Margin = new Padding(2);
      this.lblKLTronLonNhat.Name = "lblKLTronLonNhat";
      this.lblKLTronLonNhat.Size = new Size(94, 16);
      this.lblKLTronLonNhat.TabIndex = 8;
      this.lblKLTronLonNhat.Text = "KL Trộn lớn nhất";
      this.lblKLTronNhoNhat.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblKLTronNhoNhat.Appearance.Options.UseFont = true;
      this.lblKLTronNhoNhat.Location = new Point(293, 77);
      this.lblKLTronNhoNhat.Margin = new Padding(2);
      this.lblKLTronNhoNhat.Name = "lblKLTronNhoNhat";
      this.lblKLTronNhoNhat.Size = new Size(98, 16);
      this.lblKLTronNhoNhat.TabIndex = 7;
      this.lblKLTronNhoNhat.Text = "KL Trộn nhỏ nhất";
      this.lblGhiChu.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblGhiChu.Appearance.Options.UseFont = true;
      this.lblGhiChu.Location = new Point(37, 213);
      this.lblGhiChu.Margin = new Padding(2);
      this.lblGhiChu.Name = "lblGhiChu";
      this.lblGhiChu.Size = new Size(49, 16);
      this.lblGhiChu.TabIndex = 6;
      this.lblGhiChu.Text = "Niêm chì";
      this.lblXe.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblXe.Appearance.Options.UseFont = true;
      this.lblXe.Location = new Point(37, 178);
      this.lblXe.Margin = new Padding(2);
      this.lblXe.Name = "lblXe";
      this.lblXe.Size = new Size(15, 16);
      this.lblXe.TabIndex = 5;
      this.lblXe.Text = "Xe";
      this.lblTaiXe.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblTaiXe.Appearance.Options.UseFont = true;
      this.lblTaiXe.Location = new Point(37, 144);
      this.lblTaiXe.Margin = new Padding(2);
      this.lblTaiXe.Name = "lblTaiXe";
      this.lblTaiXe.Size = new Size(35, 16);
      this.lblTaiXe.TabIndex = 4;
      this.lblTaiXe.Text = "Tài xế";
      this.lblNgayTao.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblNgayTao.Appearance.Options.UseFont = true;
      this.lblNgayTao.Location = new Point(37, 111);
      this.lblNgayTao.Margin = new Padding(2);
      this.lblNgayTao.Name = "lblNgayTao";
      this.lblNgayTao.Size = new Size(50, 16);
      this.lblNgayTao.TabIndex = 3;
      this.lblNgayTao.Text = "Ngày tạo";
      this.lblMaPhieuTron.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblMaPhieuTron.Appearance.Options.UseFont = true;
      this.lblMaPhieuTron.Location = new Point(37, 78);
      this.lblMaPhieuTron.Margin = new Padding(2);
      this.lblMaPhieuTron.Name = "lblMaPhieuTron";
      this.lblMaPhieuTron.Size = new Size(79, 16);
      this.lblMaPhieuTron.TabIndex = 2;
      this.lblMaPhieuTron.Text = "Mã Phiếu trộn";
      this.lblKLConLaiTrenLyThuyet.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblKLConLaiTrenLyThuyet.Appearance.Options.UseFont = true;
      this.lblKLConLaiTrenLyThuyet.Location = new Point(271, 36);
      this.lblKLConLaiTrenLyThuyet.Margin = new Padding(2);
      this.lblKLConLaiTrenLyThuyet.Name = "lblKLConLaiTrenLyThuyet";
      this.lblKLConLaiTrenLyThuyet.Size = new Size(135, 16);
      this.lblKLConLaiTrenLyThuyet.TabIndex = 1;
      this.lblKLConLaiTrenLyThuyet.Text = "KL Còn lại trên lý thuyết";
      this.lblMaHopDong.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblMaHopDong.Appearance.Options.UseFont = true;
      this.lblMaHopDong.Location = new Point(37, 36);
      this.lblMaHopDong.Margin = new Padding(2);
      this.lblMaHopDong.Name = "lblMaHopDong";
      this.lblMaHopDong.Size = new Size(75, 16);
      this.lblMaHopDong.TabIndex = 0;
      this.lblMaHopDong.Text = "Mã Hợp đồng";
      this.pnlCommand.Controls.Add((Control)this.btnClose);
      this.pnlCommand.Controls.Add((Control)this.btnSave);
      this.pnlCommand.Controls.Add((Control)this.btnSaveNew);
      this.pnlCommand.Dock = DockStyle.Bottom;
      this.pnlCommand.Location = new Point(0, 268);
      this.pnlCommand.Margin = new Padding(2);
      this.pnlCommand.Name = "pnlCommand";
      this.pnlCommand.Size = new Size(907, 47);
      this.pnlCommand.TabIndex = 1;
      this.btnClose.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnClose.Appearance.Options.UseFont = true;
      this.btnClose.Location = new Point(517, 9);
      this.btnClose.Margin = new Padding(2);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(98, 30);
      this.btnClose.TabIndex = 5;
      this.btnClose.Text = "Đóng";
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnSave.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnSave.Appearance.Options.UseFont = true;
      this.btnSave.Location = new Point(395, 9);
      this.btnSave.Margin = new Padding(2);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(98, 30);
      this.btnSave.TabIndex = 4;
      this.btnSave.Text = "Lưu";
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.btnSaveNew.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnSaveNew.Appearance.Options.UseFont = true;
      this.btnSaveNew.Location = new Point(245, 9);
      this.btnSaveNew.Margin = new Padding(2);
      this.btnSaveNew.Name = "btnSaveNew";
      this.btnSaveNew.Size = new Size(126, 30);
      this.btnSaveNew.TabIndex = 3;
      this.btnSaveNew.Text = "Lưu và Thêm Mới";
      this.btnSaveNew.Click += new EventHandler(this.btnSaveNew_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control)this.pnlCommand);
      this.Controls.Add((Control)this.pnlMain);
      this.Name = "NewPhieuTronView";
      this.Size = new Size(907, 315);
      this.pnlMain.EndInit();
      this.pnlMain.ResumeLayout(false);
      this.pnlMain.PerformLayout();
      this.spnKLTTPhieuTron.Properties.EndInit();
      this.spnMTCommitedQty.Properties.EndInit();
      this.spnMTHieuChinhQty.Properties.EndInit();
      this.spnMTQty.Properties.EndInit();
      this.spnKLDTMeTron.Properties.EndInit();
      this.spnKLDTPhieuTron.Properties.EndInit();
      this.spnMaxKLXeCho.Properties.EndInit();
      this.spnMaxKLTron.Properties.EndInit();
      this.spnMinKLTron.Properties.EndInit();
      this.spnKLLyThuyetCL.Properties.EndInit();
      this.txtMoTa.Properties.EndInit();
      this.lueXe.Properties.EndInit();
      this.lueTaiXe.Properties.EndInit();
      this.datNgayPhieuTron.Properties.CalendarTimeProperties.EndInit();
      this.datNgayPhieuTron.Properties.EndInit();
      this.txtMaPhieuTron.Properties.EndInit();
      this.bteMaHopDong.Properties.EndInit();
      this.pnlCommand.EndInit();
      this.pnlCommand.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
