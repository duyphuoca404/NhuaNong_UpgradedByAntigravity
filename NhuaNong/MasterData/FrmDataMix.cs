// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.FrmDataMix
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using NhuaNong.Data;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public partial class FrmDataMix : DialogViewBase, IDataMixMngView, IBase, IPermission
  {
    private DataMixMngDataPresenter _presenter;
    public BindingList<Objvw_DataMix> _blstDataMix = new BindingList<Objvw_DataMix>();
    //private IContainer components;
    //private GroupControl groupControl1;
    //private GridControl grcDataMix;
    //private GridView grvDataMix;
    //private GridColumn gcMaPhieuTron;
    //private GridColumn gcDate;
    //private GridColumn gcTime;
    //private GridColumn gcKhachHang;
    //private GridColumn gcCongTruong;
    //private GridColumn gcTaiXe;
    //private GridColumn gcMAC;
    //private GridColumn gcKLMe;
    //private GridColumn gcAgg1;
    //private GridColumn gridColumn5;
    //private GroupBox groupBox1;
    //private SimpleButton simpleButton1;
    //private GroupBox groupBox3;
    //private TextEdit txtMaPT;
    //private LabelControl labelControl3;
    //private GroupBox groupBox2;
    //private DateEdit datToDate;
    //private DateEdit datFromData;
    //private LabelControl labelControl2;
    //private LabelControl labelControl1;
    //private GroupBox groupBox4;
    //private PanelControl panelControl1;
    //private LabelControl labelControl4;

    public BindingList<Objvw_DataMix> BLstDataMix
    {
      set
      {
        this._blstDataMix = value;
        this.grcDataMix.DataSource = (object) this._blstDataMix;
      }
    }

    public BindingList<ObjKhachHang> BLstKhachHang
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjCongTruong> BLstCongTruong
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjHangMuc> BLstHangMuc
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjMAC> BLstMAC
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjXe> BLstXe
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjTaiXe> BLstTaiXe
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjNhanVien> BLstNhanVien
    {
      set => throw new NotImplementedException();
    }

    public List<FieldCode> LstDataMixStatus
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjSilo> BLstSilo
    {
      set => throw new NotImplementedException();
    }

    public FrmDataMix()
    {
      this.InitializeComponent();
      this._presenter = new DataMixMngDataPresenter((IDataMixMngView) this);
      this.Name = nameof(FrmDataMix);
    }

    protected override void PopulateStaticData() => this._presenter.ListDataMix();

    //protected override void Dispose(bool disposing)
    //{
    //  if (disposing && this.components != null)
    //    this.components.Dispose();
    //  base.Dispose(disposing);
    //}

    //private void InitializeComponent()
    //{
    //  this.groupControl1 = new GroupControl();
    //  this.grcDataMix = new GridControl();
    //  this.grvDataMix = new GridView();
    //  this.gcMaPhieuTron = new GridColumn();
    //  this.gcDate = new GridColumn();
    //  this.gcTime = new GridColumn();
    //  this.gcKhachHang = new GridColumn();
    //  this.gcCongTruong = new GridColumn();
    //  this.gcTaiXe = new GridColumn();
    //  this.gcMAC = new GridColumn();
    //  this.gcKLMe = new GridColumn();
    //  this.gcAgg1 = new GridColumn();
    //  this.gridColumn5 = new GridColumn();
    //  this.groupBox1 = new GroupBox();
    //  this.simpleButton1 = new SimpleButton();
    //  this.groupBox3 = new GroupBox();
    //  this.txtMaPT = new TextEdit();
    //  this.labelControl3 = new LabelControl();
    //  this.groupBox2 = new GroupBox();
    //  this.datToDate = new DateEdit();
    //  this.datFromData = new DateEdit();
    //  this.labelControl2 = new LabelControl();
    //  this.labelControl1 = new LabelControl();
    //  this.groupBox4 = new GroupBox();
    //  this.panelControl1 = new PanelControl();
    //  this.labelControl4 = new LabelControl();
    //  this.groupControl1.BeginInit();
    //  this.groupControl1.SuspendLayout();
    //  this.grcDataMix.BeginInit();
    //  this.grvDataMix.BeginInit();
    //  this.groupBox1.SuspendLayout();
    //  this.groupBox3.SuspendLayout();
    //  this.txtMaPT.Properties.BeginInit();
    //  this.groupBox2.SuspendLayout();
    //  this.datToDate.Properties.CalendarTimeProperties.BeginInit();
    //  this.datToDate.Properties.BeginInit();
    //  this.datFromData.Properties.CalendarTimeProperties.BeginInit();
    //  this.datFromData.Properties.BeginInit();
    //  this.groupBox4.SuspendLayout();
    //  this.panelControl1.BeginInit();
    //  this.panelControl1.SuspendLayout();
    //  this.SuspendLayout();
    //  this.groupControl1.Controls.Add((Control) this.grcDataMix);
    //  this.groupControl1.Dock = DockStyle.Bottom;
    //  this.groupControl1.Location = new Point(3, 82);
    //  this.groupControl1.Name = "groupControl1";
    //  this.groupControl1.Size = new Size(878, 530);
    //  this.groupControl1.TabIndex = 3;
    //  this.groupControl1.Text = "Dữ liệu";
    //  this.grcDataMix.Dock = DockStyle.Fill;
    //  this.grcDataMix.Location = new Point(2, 23);
    //  this.grcDataMix.MainView = (BaseView) this.grvDataMix;
    //  this.grcDataMix.Name = "grcDataMix";
    //  this.grcDataMix.Size = new Size(874, 505);
    //  this.grcDataMix.TabIndex = 0;
    //  this.grcDataMix.ViewCollection.AddRange(new BaseView[1]
    //  {
    //    (BaseView) this.grvDataMix
    //  });
    //  this.grvDataMix.Columns.AddRange(new GridColumn[10]
    //  {
    //    this.gcMaPhieuTron,
    //    this.gcDate,
    //    this.gcTime,
    //    this.gcKhachHang,
    //    this.gcCongTruong,
    //    this.gcTaiXe,
    //    this.gcMAC,
    //    this.gcKLMe,
    //    this.gcAgg1,
    //    this.gridColumn5
    //  });
    //  this.grvDataMix.GridControl = this.grcDataMix;
    //  this.grvDataMix.Name = "grvDataMix";
    //  this.grvDataMix.OptionsView.ShowFooter = true;
    //  this.gcMaPhieuTron.Caption = "Mã Phiếu trộn";
    //  this.gcMaPhieuTron.FieldName = "MaPhieuTron";
    //  this.gcMaPhieuTron.Name = "gcMaPhieuTron";
    //  this.gcMaPhieuTron.Visible = true;
    //  this.gcMaPhieuTron.VisibleIndex = 0;
    //  this.gcDate.Caption = "Ngày trộn";
    //  this.gcDate.FieldName = "Ngay";
    //  this.gcDate.Name = "gcDate";
    //  this.gcDate.Visible = true;
    //  this.gcDate.VisibleIndex = 1;
    //  this.gcTime.Caption = "Giờ";
    //  this.gcTime.FieldName = "Gio";
    //  this.gcTime.Name = "gcTime";
    //  this.gcTime.Visible = true;
    //  this.gcTime.VisibleIndex = 2;
    //  this.gcKhachHang.Caption = "Khách hàng";
    //  this.gcKhachHang.FieldName = "KH";
    //  this.gcKhachHang.Name = "gcKhachHang";
    //  this.gcKhachHang.Visible = true;
    //  this.gcKhachHang.VisibleIndex = 3;
    //  this.gcCongTruong.Caption = "Công trường";
    //  this.gcCongTruong.FieldName = "CT";
    //  this.gcCongTruong.Name = "gcCongTruong";
    //  this.gcCongTruong.Visible = true;
    //  this.gcCongTruong.VisibleIndex = 4;
    //  this.gcTaiXe.Caption = "Tài xế";
    //  this.gcTaiXe.FieldName = "Name";
    //  this.gcTaiXe.Name = "gcTaiXe";
    //  this.gcTaiXe.Visible = true;
    //  this.gcTaiXe.VisibleIndex = 5;
    //  this.gcMAC.Caption = "MAC";
    //  this.gcMAC.FieldName = "MAC";
    //  this.gcMAC.Name = "gcMAC";
    //  this.gcMAC.Visible = true;
    //  this.gcMAC.VisibleIndex = 6;
    //  this.gcKLMe.Caption = "KL Mẻ";
    //  this.gcKLMe.FieldName = "KLMe";
    //  this.gcKLMe.Name = "gcKLMe";
    //  this.gcKLMe.Visible = true;
    //  this.gcKLMe.VisibleIndex = 7;
    //  this.gcAgg1.Caption = "Agg 1";
    //  this.gcAgg1.FieldName = "Agg1";
    //  this.gcAgg1.Name = "gcAgg1";
    //  this.gcAgg1.Visible = true;
    //  this.gcAgg1.VisibleIndex = 8;
    //  this.gridColumn5.Caption = "gridColumn5";
    //  this.gridColumn5.Name = "gridColumn5";
    //  this.gridColumn5.Visible = true;
    //  this.gridColumn5.VisibleIndex = 9;
    //  this.groupBox1.Controls.Add((Control) this.simpleButton1);
    //  this.groupBox1.Controls.Add((Control) this.groupBox3);
    //  this.groupBox1.Controls.Add((Control) this.groupBox2);
    //  this.groupBox1.Dock = DockStyle.Left;
    //  this.groupBox1.Location = new Point(0, 0);
    //  this.groupBox1.Name = "groupBox1";
    //  this.groupBox1.Size = new Size(253, 615);
    //  this.groupBox1.TabIndex = 2;
    //  this.groupBox1.TabStop = false;
    //  this.groupBox1.Text = "Lựa chọn";
    //  this.simpleButton1.Location = new Point(61, 361);
    //  this.simpleButton1.Name = "simpleButton1";
    //  this.simpleButton1.Size = new Size(112, 32);
    //  this.simpleButton1.TabIndex = 2;
    //  this.simpleButton1.Text = "Tìm kiếm";
    //  this.groupBox3.Controls.Add((Control) this.txtMaPT);
    //  this.groupBox3.Controls.Add((Control) this.labelControl3);
    //  this.groupBox3.Location = new Point(19, 134);
    //  this.groupBox3.Name = "groupBox3";
    //  this.groupBox3.Size = new Size(228, 182);
    //  this.groupBox3.TabIndex = 1;
    //  this.groupBox3.TabStop = false;
    //  this.groupBox3.Text = "Bộ lọc";
    //  this.txtMaPT.Location = new Point(107, 30);
    //  this.txtMaPT.Name = "txtMaPT";
    //  this.txtMaPT.Size = new Size(115, 20);
    //  this.txtMaPT.TabIndex = 2;
    //  this.labelControl3.Location = new Point(22, 33);
    //  this.labelControl3.Name = "labelControl3";
    //  this.labelControl3.Size = new Size(66, 13);
    //  this.labelControl3.TabIndex = 1;
    //  this.labelControl3.Text = "Mã phiếu trộn";
    //  this.groupBox2.Controls.Add((Control) this.datToDate);
    //  this.groupBox2.Controls.Add((Control) this.datFromData);
    //  this.groupBox2.Controls.Add((Control) this.labelControl2);
    //  this.groupBox2.Controls.Add((Control) this.labelControl1);
    //  this.groupBox2.Location = new Point(19, 34);
    //  this.groupBox2.Name = "groupBox2";
    //  this.groupBox2.Size = new Size(228, 88);
    //  this.groupBox2.TabIndex = 0;
    //  this.groupBox2.TabStop = false;
    //  this.groupBox2.Text = "Khoảng thời gian";
    //  this.datToDate.EditValue = (object) null;
    //  this.datToDate.Location = new Point(62, 54);
    //  this.datToDate.Name = "datToDate";
    //  this.datToDate.Properties.Buttons.AddRange(new EditorButton[1]
    //  {
    //    new EditorButton(ButtonPredefines.Combo)
    //  });
    //  this.datToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
    //  {
    //    new EditorButton(ButtonPredefines.Combo)
    //  });
    //  this.datToDate.Size = new Size(160, 20);
    //  this.datToDate.TabIndex = 3;
    //  this.datFromData.EditValue = (object) null;
    //  this.datFromData.Location = new Point(62, 22);
    //  this.datFromData.Name = "datFromData";
    //  this.datFromData.Properties.Buttons.AddRange(new EditorButton[1]
    //  {
    //    new EditorButton(ButtonPredefines.Combo)
    //  });
    //  this.datFromData.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
    //  {
    //    new EditorButton(ButtonPredefines.Combo)
    //  });
    //  this.datFromData.Size = new Size(160, 20);
    //  this.datFromData.TabIndex = 2;
    //  this.labelControl2.Location = new Point(22, 57);
    //  this.labelControl2.Name = "labelControl2";
    //  this.labelControl2.Size = new Size(20, 13);
    //  this.labelControl2.TabIndex = 1;
    //  this.labelControl2.Text = "Đến";
    //  this.labelControl1.Location = new Point(22, 25);
    //  this.labelControl1.Name = "labelControl1";
    //  this.labelControl1.Size = new Size(13, 13);
    //  this.labelControl1.TabIndex = 0;
    //  this.labelControl1.Text = "Từ";
    //  this.groupBox4.Controls.Add((Control) this.panelControl1);
    //  this.groupBox4.Controls.Add((Control) this.groupControl1);
    //  this.groupBox4.Dock = DockStyle.Fill;
    //  this.groupBox4.Location = new Point(253, 0);
    //  this.groupBox4.Name = "groupBox4";
    //  this.groupBox4.Size = new Size(884, 615);
    //  this.groupBox4.TabIndex = 4;
    //  this.groupBox4.TabStop = false;
    //  this.panelControl1.BorderStyle = BorderStyles.NoBorder;
    //  this.panelControl1.Controls.Add((Control) this.labelControl4);
    //  this.panelControl1.Dock = DockStyle.Top;
    //  this.panelControl1.Location = new Point(3, 17);
    //  this.panelControl1.Name = "panelControl1";
    //  this.panelControl1.Size = new Size(878, 59);
    //  this.panelControl1.TabIndex = 4;
    //  this.labelControl4.Appearance.Font = new Font("Tahoma", 27.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    //  this.labelControl4.Appearance.Options.UseFont = true;
    //  this.labelControl4.Appearance.Options.UseTextOptions = true;
    //  this.labelControl4.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
    //  this.labelControl4.Appearance.TextOptions.VAlignment = VertAlignment.Center;
    //  this.labelControl4.Location = new Point(158, 10);
    //  this.labelControl4.Name = "labelControl4";
    //  this.labelControl4.Size = new Size(532, 45);
    //  this.labelControl4.TabIndex = 0;
    //  this.labelControl4.Text = "BÁO CÁO CHI TIẾT MẺ TRỘN";
    //  this.AutoScaleDimensions = new SizeF(6f, 13f);
    //  this.AutoScaleMode = AutoScaleMode.Font;
    //  this.ClientSize = new Size(1137, 615);
    //  this.Controls.Add((Control) this.groupBox4);
    //  this.Controls.Add((Control) this.groupBox1);
    //  this.Name = nameof (FrmDataMix);
    //  this.Text = nameof (FrmDataMix);
    //  this.groupControl1.EndInit();
    //  this.groupControl1.ResumeLayout(false);
    //  this.grcDataMix.EndInit();
    //  this.grvDataMix.EndInit();
    //  this.groupBox1.ResumeLayout(false);
    //  this.groupBox3.ResumeLayout(false);
    //  this.groupBox3.PerformLayout();
    //  this.txtMaPT.Properties.EndInit();
    //  this.groupBox2.ResumeLayout(false);
    //  this.groupBox2.PerformLayout();
    //  this.datToDate.Properties.CalendarTimeProperties.EndInit();
    //  this.datToDate.Properties.EndInit();
    //  this.datFromData.Properties.CalendarTimeProperties.EndInit();
    //  this.datFromData.Properties.EndInit();
    //  this.groupBox4.ResumeLayout(false);
    //  this.panelControl1.EndInit();
    //  this.panelControl1.ResumeLayout(false);
    //  this.panelControl1.PerformLayout();
    //  this.ResumeLayout(false);
    //}
  }
}
