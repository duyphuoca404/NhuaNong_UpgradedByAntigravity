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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using NhuaNong.Data;
using NhuaNong.Utils;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NhuaNong.MasterData
{
  public partial class NewMACView
  {
    private IContainer components;
    private PanelControl pnlTop;
    private PanelControl pnlCommand;
    private SimpleButton btnClose;
    private SimpleButton btnSave;
    private SimpleButton btnSaveNew;
    private TextEdit txtMaMAC;
    private LabelControl lblMaMAC;
    private TextEdit txtTenMAC;
    private LabelControl lblTenMAC;
    private TextEdit txtDoSut;
    private LabelControl lblDoSut;
    private LabelControl labelControl1;
    private CheckEdit chkActive;
    private SpinEdit spnThemBotNuoc1;
    private LabelControl lblThemBotNuoc1;
    private SpinEdit spnThemBotNuoc2;
    private LabelControl lblThemBotNuoc2;
    private LabelControl lblGhiChu;
    private MemoEdit memGhiChu;
    private GroupControl grpSiloValue;
    private GridControl grcMACSilo;
    private GridView grvMACSilo;
    private GridColumn gcMaSilo;
    private GridColumn gcSiloValue;
    private RepositoryItemSpinEdit spnSiloValue;
    private GridColumn gcMaterialName;
    private RepositoryItemMemoEdit imemGhiChu;
    private TextEdit txtCuongDo;
    private SimpleButton simpleButton1;
    private GridColumn gcTenSilo;
    private GridColumn gcTenVatTu;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.pnlTop = new PanelControl();
      this.simpleButton1 = new SimpleButton();
      this.txtCuongDo = new TextEdit();
      this.memGhiChu = new MemoEdit();
      this.lblGhiChu = new LabelControl();
      this.lblThemBotNuoc2 = new LabelControl();
      this.spnThemBotNuoc2 = new SpinEdit();
      this.spnThemBotNuoc1 = new SpinEdit();
      this.lblThemBotNuoc1 = new LabelControl();
      this.txtDoSut = new TextEdit();
      this.lblDoSut = new LabelControl();
      this.labelControl1 = new LabelControl();
      this.chkActive = new CheckEdit();
      this.txtTenMAC = new TextEdit();
      this.lblTenMAC = new LabelControl();
      this.txtMaMAC = new TextEdit();
      this.lblMaMAC = new LabelControl();
      this.pnlCommand = new PanelControl();
      this.btnClose = new SimpleButton();
      this.btnSave = new SimpleButton();
      this.btnSaveNew = new SimpleButton();
      this.grpSiloValue = new GroupControl();
      this.grcMACSilo = new GridControl();
      this.grvMACSilo = new GridView();
      this.gcMaSilo = new GridColumn();
      this.gcTenSilo = new GridColumn();
      this.gcTenVatTu = new GridColumn();
      this.gcSiloValue = new GridColumn();
      this.spnSiloValue = new RepositoryItemSpinEdit();
      this.gcMaterialName = new GridColumn();
      this.imemGhiChu = new RepositoryItemMemoEdit();
      this.pnlTop.BeginInit();
      this.pnlTop.SuspendLayout();
      this.txtCuongDo.Properties.BeginInit();
      this.memGhiChu.Properties.BeginInit();
      this.spnThemBotNuoc2.Properties.BeginInit();
      this.spnThemBotNuoc1.Properties.BeginInit();
      this.txtDoSut.Properties.BeginInit();
      this.chkActive.Properties.BeginInit();
      this.txtTenMAC.Properties.BeginInit();
      this.txtMaMAC.Properties.BeginInit();
      this.pnlCommand.BeginInit();
      this.pnlCommand.SuspendLayout();
      this.grpSiloValue.BeginInit();
      this.grpSiloValue.SuspendLayout();
      this.grcMACSilo.BeginInit();
      this.grvMACSilo.BeginInit();
      this.spnSiloValue.BeginInit();
      this.imemGhiChu.BeginInit();
      this.SuspendLayout();
      this.pnlTop.Controls.Add((Control)this.simpleButton1);
      this.pnlTop.Controls.Add((Control)this.txtCuongDo);
      this.pnlTop.Controls.Add((Control)this.memGhiChu);
      this.pnlTop.Controls.Add((Control)this.lblGhiChu);
      this.pnlTop.Controls.Add((Control)this.lblThemBotNuoc2);
      this.pnlTop.Controls.Add((Control)this.spnThemBotNuoc2);
      this.pnlTop.Controls.Add((Control)this.spnThemBotNuoc1);
      this.pnlTop.Controls.Add((Control)this.lblThemBotNuoc1);
      this.pnlTop.Controls.Add((Control)this.txtDoSut);
      this.pnlTop.Controls.Add((Control)this.lblDoSut);
      this.pnlTop.Controls.Add((Control)this.labelControl1);
      this.pnlTop.Controls.Add((Control)this.chkActive);
      this.pnlTop.Controls.Add((Control)this.txtTenMAC);
      this.pnlTop.Controls.Add((Control)this.lblTenMAC);
      this.pnlTop.Controls.Add((Control)this.txtMaMAC);
      this.pnlTop.Controls.Add((Control)this.lblMaMAC);
      this.pnlTop.Dock = DockStyle.Top;
      this.pnlTop.Location = new Point(0, 0);
      this.pnlTop.Margin = new Padding(2);
      this.pnlTop.Name = "pnlTop";
      this.pnlTop.Size = new Size(840, 104);
      this.pnlTop.TabIndex = 0;
      this.simpleButton1.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.simpleButton1.Appearance.Options.UseFont = true;
      this.simpleButton1.Appearance.Options.UseTextOptions = true;
      this.simpleButton1.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.simpleButton1.Appearance.TextOptions.VAlignment = VertAlignment.Center;
      this.simpleButton1.Location = new Point(548, 26);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new Size(37, 22);
      this.simpleButton1.TabIndex = 25;
      this.simpleButton1.Text = "±";
      this.simpleButton1.Visible = false;
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click);
      this.txtCuongDo.Location = new Point(663, 26);
      this.txtCuongDo.Margin = new Padding(2);
      this.txtCuongDo.Name = "txtCuongDo";
      this.txtCuongDo.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.txtCuongDo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtCuongDo.Properties.Appearance.Options.UseBackColor = true;
      this.txtCuongDo.Properties.Appearance.Options.UseFont = true;
      this.txtCuongDo.Size = new Size(150, 22);
      this.txtCuongDo.TabIndex = 24;
      this.txtCuongDo.Visible = false;
      this.memGhiChu.Location = new Point(603, 80);
      this.memGhiChu.Margin = new Padding(2);
      this.memGhiChu.Name = "memGhiChu";
      this.memGhiChu.Size = new Size(194, 18);
      this.memGhiChu.TabIndex = 23;
      this.memGhiChu.Visible = false;
      this.lblGhiChu.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblGhiChu.Appearance.Options.UseFont = true;
      this.lblGhiChu.Location = new Point(598, 29);
      this.lblGhiChu.Margin = new Padding(2);
      this.lblGhiChu.Name = "lblGhiChu";
      this.lblGhiChu.Size = new Size(58, 16);
      this.lblGhiChu.TabIndex = 22;
      this.lblGhiChu.Text = "Cường độ";
      this.lblGhiChu.Visible = false;
      this.lblThemBotNuoc2.Location = new Point(274, 80);
      this.lblThemBotNuoc2.Margin = new Padding(2);
      this.lblThemBotNuoc2.Name = "lblThemBotNuoc2";
      this.lblThemBotNuoc2.Size = new Size(81, 13);
      this.lblThemBotNuoc2.TabIndex = 21;
      this.lblThemBotNuoc2.Text = "Thêm bớt nước 1";
      this.lblThemBotNuoc2.Visible = false;
      this.spnThemBotNuoc2.EditValue = (object)new Decimal(new int[4]);
      this.spnThemBotNuoc2.Location = new Point(389, 77);
      this.spnThemBotNuoc2.Margin = new Padding(2);
      this.spnThemBotNuoc2.Name = "spnThemBotNuoc2";
      this.spnThemBotNuoc2.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnThemBotNuoc2.Size = new Size(107, 20);
      this.spnThemBotNuoc2.TabIndex = 20;
      this.spnThemBotNuoc2.Visible = false;
      this.spnThemBotNuoc1.EditValue = (object)new Decimal(new int[4]);
      this.spnThemBotNuoc1.Location = new Point(389, 52);
      this.spnThemBotNuoc1.Margin = new Padding(2);
      this.spnThemBotNuoc1.Name = "spnThemBotNuoc1";
      this.spnThemBotNuoc1.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.spnThemBotNuoc1.Properties.Appearance.Options.UseFont = true;
      this.spnThemBotNuoc1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnThemBotNuoc1.Size = new Size(107, 22);
      this.spnThemBotNuoc1.TabIndex = 19;
      this.spnThemBotNuoc1.Visible = false;
      this.lblThemBotNuoc1.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblThemBotNuoc1.Appearance.Options.UseFont = true;
      this.lblThemBotNuoc1.Location = new Point(274, 55);
      this.lblThemBotNuoc1.Margin = new Padding(2);
      this.lblThemBotNuoc1.Name = "lblThemBotNuoc1";
      this.lblThemBotNuoc1.Size = new Size(99, 16);
      this.lblThemBotNuoc1.TabIndex = 18;
      this.lblThemBotNuoc1.Text = "Thêm bớt nước 1";
      this.lblThemBotNuoc1.Visible = false;
      this.txtDoSut.Location = new Point(389, 26);
      this.txtDoSut.Margin = new Padding(2);
      this.txtDoSut.Name = "txtDoSut";
      this.txtDoSut.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.txtDoSut.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtDoSut.Properties.Appearance.Options.UseBackColor = true;
      this.txtDoSut.Properties.Appearance.Options.UseFont = true;
      this.txtDoSut.Size = new Size(150, 22);
      this.txtDoSut.TabIndex = 17;
      this.lblDoSut.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblDoSut.Appearance.Options.UseFont = true;
      this.lblDoSut.Location = new Point(331, 27);
      this.lblDoSut.Margin = new Padding(2);
      this.lblDoSut.Name = "lblDoSut";
      this.lblDoSut.Size = new Size(39, 16);
      this.lblDoSut.TabIndex = 16;
      this.lblDoSut.Text = "Độ ẩm";
      this.labelControl1.Appearance.Font = new Font("Tahoma", 7.8f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(43, 84);
      this.labelControl1.Margin = new Padding(2);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(44, 13);
      this.labelControl1.TabIndex = 15;
      this.labelControl1.Text = "Kích hoạt";
      this.labelControl1.Visible = false;
      this.chkActive.Location = new Point(106, 81);
      this.chkActive.Margin = new Padding(2);
      this.chkActive.Name = "chkActive";
      this.chkActive.Properties.Caption = "";
      this.chkActive.Size = new Size(92, 20);
      this.chkActive.TabIndex = 14;
      this.chkActive.Visible = false;
      this.txtTenMAC.Location = new Point(106, 56);
      this.txtTenMAC.Margin = new Padding(2);
      this.txtTenMAC.Name = "txtTenMAC";
      this.txtTenMAC.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.txtTenMAC.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtTenMAC.Properties.Appearance.Options.UseBackColor = true;
      this.txtTenMAC.Properties.Appearance.Options.UseFont = true;
      this.txtTenMAC.Size = new Size(150, 22);
      this.txtTenMAC.TabIndex = 10;
      this.lblTenMAC.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblTenMAC.Appearance.Options.UseFont = true;
      this.lblTenMAC.Location = new Point(43, 59);
      this.lblTenMAC.Margin = new Padding(2);
      this.lblTenMAC.Name = "lblTenMAC";
      this.lblTenMAC.Size = new Size(56, 16);
      this.lblTenMAC.TabIndex = 9;
      this.lblTenMAC.Text = "Tên MAC";
      this.txtMaMAC.Location = new Point(106, 26);
      this.txtMaMAC.Margin = new Padding(2);
      this.txtMaMAC.Name = "txtMaMAC";
      this.txtMaMAC.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.txtMaMAC.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtMaMAC.Properties.Appearance.Options.UseBackColor = true;
      this.txtMaMAC.Properties.Appearance.Options.UseFont = true;
      this.txtMaMAC.Properties.ReadOnly = true;
      this.txtMaMAC.Size = new Size(150, 22);
      this.txtMaMAC.TabIndex = 8;
      this.lblMaMAC.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblMaMAC.Appearance.Options.UseFont = true;
      this.lblMaMAC.Location = new Point(43, 29);
      this.lblMaMAC.Margin = new Padding(2);
      this.lblMaMAC.Name = "lblMaMAC";
      this.lblMaMAC.Size = new Size(51, 16);
      this.lblMaMAC.TabIndex = 7;
      this.lblMaMAC.Text = "Mã MAC";
      this.pnlCommand.Controls.Add((Control)this.btnClose);
      this.pnlCommand.Controls.Add((Control)this.btnSave);
      this.pnlCommand.Controls.Add((Control)this.btnSaveNew);
      this.pnlCommand.Dock = DockStyle.Bottom;
      this.pnlCommand.Location = new Point(0, 481);
      this.pnlCommand.Margin = new Padding(2);
      this.pnlCommand.Name = "pnlCommand";
      this.pnlCommand.Size = new Size(840, 47);
      this.pnlCommand.TabIndex = 1;
      this.btnClose.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnClose.Appearance.Options.UseFont = true;
      this.btnClose.Location = new Point(680, 9);
      this.btnClose.Margin = new Padding(2);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(98, 30);
      this.btnClose.TabIndex = 5;
      this.btnClose.Text = "Đóng";
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnSave.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnSave.Appearance.Options.UseFont = true;
      this.btnSave.Location = new Point(568, 9);
      this.btnSave.Margin = new Padding(2);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(98, 30);
      this.btnSave.TabIndex = 4;
      this.btnSave.Text = "Lưu";
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.btnSaveNew.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnSaveNew.Appearance.Options.UseFont = true;
      this.btnSaveNew.Location = new Point(428, 9);
      this.btnSaveNew.Margin = new Padding(2);
      this.btnSaveNew.Name = "btnSaveNew";
      this.btnSaveNew.Size = new Size(126, 30);
      this.btnSaveNew.TabIndex = 3;
      this.btnSaveNew.Text = "Lưu và Thêm Mới";
      this.btnSaveNew.Visible = false;
      this.btnSaveNew.Click += new EventHandler(this.btnSaveNew_Click);
      this.grpSiloValue.AppearanceCaption.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.grpSiloValue.AppearanceCaption.Options.UseFont = true;
      this.grpSiloValue.Controls.Add((Control)this.grcMACSilo);
      this.grpSiloValue.Dock = DockStyle.Fill;
      this.grpSiloValue.Location = new Point(0, 104);
      this.grpSiloValue.Margin = new Padding(2);
      this.grpSiloValue.Name = "grpSiloValue";
      this.grpSiloValue.Size = new Size(840, 377);
      this.grpSiloValue.TabIndex = 2;
      this.grpSiloValue.Text = "Giá trị Silo";
      this.grcMACSilo.Dock = DockStyle.Fill;
      this.grcMACSilo.EmbeddedNavigator.Margin = new Padding(2);
      this.grcMACSilo.Location = new Point(2, 23);
      this.grcMACSilo.MainView = (BaseView)this.grvMACSilo;
      this.grcMACSilo.Margin = new Padding(2);
      this.grcMACSilo.Name = "grcMACSilo";
      this.grcMACSilo.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.spnSiloValue,
        (RepositoryItem) this.imemGhiChu
      });
      this.grcMACSilo.Size = new Size(836, 352);
      this.grcMACSilo.TabIndex = 0;
      this.grcMACSilo.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvMACSilo
      });
      this.grvMACSilo.Appearance.Row.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.grvMACSilo.Appearance.Row.Options.UseFont = true;
      this.grvMACSilo.Columns.AddRange(new GridColumn[5]
      {
        this.gcMaSilo,
        this.gcTenSilo,
        this.gcTenVatTu,
        this.gcSiloValue,
        this.gcMaterialName
      });
      this.grvMACSilo.DetailHeight = 284;
      this.grvMACSilo.GridControl = this.grcMACSilo;
      this.grvMACSilo.Name = "grvMACSilo";
      this.grvMACSilo.OptionsView.ShowFooter = true;
      this.grvMACSilo.OptionsView.ShowGroupPanel = false;
      this.gcMaSilo.AppearanceHeader.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.gcMaSilo.AppearanceHeader.Options.UseFont = true;
      this.gcMaSilo.Caption = "Mã Silo";
      this.gcMaSilo.FieldName = "NPSiloMaSilo";
      this.gcMaSilo.MinWidth = 22;
      this.gcMaSilo.Name = "gcMaSilo";
      this.gcMaSilo.OptionsColumn.AllowFocus = false;
      this.gcMaSilo.OptionsColumn.ReadOnly = true;
      this.gcMaSilo.Visible = true;
      this.gcMaSilo.VisibleIndex = 0;
      this.gcMaSilo.Width = 80;
      this.gcTenSilo.AppearanceHeader.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.gcTenSilo.AppearanceHeader.Options.UseFont = true;
      this.gcTenSilo.Caption = "Tên Silo";
      this.gcTenSilo.FieldName = "NPSiloTenSilo";
      this.gcTenSilo.Name = "gcTenSilo";
      this.gcTenSilo.OptionsColumn.AllowFocus = false;
      this.gcTenSilo.OptionsColumn.ReadOnly = true;
      this.gcTenSilo.Visible = true;
      this.gcTenSilo.VisibleIndex = 1;
      this.gcTenVatTu.AppearanceHeader.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.gcTenVatTu.AppearanceHeader.Options.UseFont = true;
      this.gcTenVatTu.Caption = "Tên Vật tư";
      this.gcTenVatTu.FieldName = "NPSiloMaterialName";
      this.gcTenVatTu.Name = "gcTenVatTu";
      this.gcTenVatTu.OptionsColumn.AllowFocus = false;
      this.gcTenVatTu.OptionsColumn.ReadOnly = true;
      this.gcTenVatTu.Visible = true;
      this.gcTenVatTu.VisibleIndex = 2;
      this.gcSiloValue.AppearanceHeader.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.gcSiloValue.AppearanceHeader.Options.UseFont = true;
      this.gcSiloValue.Caption = "Giá Trị Silo";
      this.gcSiloValue.ColumnEdit = (RepositoryItem)this.spnSiloValue;
      this.gcSiloValue.FieldName = "SiloValue";
      this.gcSiloValue.MinWidth = 22;
      this.gcSiloValue.Name = "gcSiloValue";
      this.gcSiloValue.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "SiloValue", "{0:0.##}")
      });
      this.gcSiloValue.Visible = true;
      this.gcSiloValue.VisibleIndex = 3;
      this.gcSiloValue.Width = 80;
      this.spnSiloValue.AutoHeight = false;
      this.spnSiloValue.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnSiloValue.DisplayFormat.FormatString = "n2";
      this.spnSiloValue.DisplayFormat.FormatType = FormatType.Numeric;
      this.spnSiloValue.EditFormat.FormatString = "n2";
      this.spnSiloValue.EditFormat.FormatType = FormatType.Numeric;
      this.spnSiloValue.Mask.EditMask = "n2";
      this.spnSiloValue.MaxLength = 9;
      this.spnSiloValue.MaxValue = new Decimal(new int[4]
      {
        9999999,
        0,
        0,
        0
      });
      this.spnSiloValue.Name = "spnSiloValue";
      this.spnSiloValue.NullText = "0";
      this.gcMaterialName.AppearanceHeader.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.gcMaterialName.AppearanceHeader.Options.UseFont = true;
      this.gcMaterialName.Caption = "Tên Vật tư";
      this.gcMaterialName.ColumnEdit = (RepositoryItem)this.imemGhiChu;
      this.gcMaterialName.FieldName = "GhiChu";
      this.gcMaterialName.MinWidth = 22;
      this.gcMaterialName.Name = "gcMaterialName";
      this.gcMaterialName.Width = 80;
      this.imemGhiChu.Name = "imemGhiChu";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control)this.grpSiloValue);
      this.Controls.Add((Control)this.pnlCommand);
      this.Controls.Add((Control)this.pnlTop);
      this.Name = "NewMACView";
      this.Size = new Size(840, 528);
      this.pnlTop.EndInit();
      this.pnlTop.ResumeLayout(false);
      this.pnlTop.PerformLayout();
      this.txtCuongDo.Properties.EndInit();
      this.memGhiChu.Properties.EndInit();
      this.spnThemBotNuoc2.Properties.EndInit();
      this.spnThemBotNuoc1.Properties.EndInit();
      this.txtDoSut.Properties.EndInit();
      this.chkActive.Properties.EndInit();
      this.txtTenMAC.Properties.EndInit();
      this.txtMaMAC.Properties.EndInit();
      this.pnlCommand.EndInit();
      this.pnlCommand.ResumeLayout(false);
      this.grpSiloValue.EndInit();
      this.grpSiloValue.ResumeLayout(false);
      this.grcMACSilo.EndInit();
      this.grvMACSilo.EndInit();
      this.spnSiloValue.EndInit();
      this.imemGhiChu.EndInit();
      this.ResumeLayout(false);
    }
  }
}
