namespace NhuaNong.MasterData
{
	// Token: 0x02000096 RID: 150
	public partial class FrmDataMix : global::NhuaNong.DialogViewBase, global::NhuaNong.MasterData.IDataMixMngView, global::NhuaNong.IBase, global::NhuaNong.IPermission
	{
		// Token: 0x0600093A RID: 2362 RVA: 0x000574BF File Offset: 0x000556BF
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x000574E0 File Offset: 0x000556E0
		private void InitializeComponent()
		{
			this.groupControl1 = new global::DevExpress.XtraEditors.GroupControl();
			this.grcDataMix = new global::DevExpress.XtraGrid.GridControl();
			this.grvDataMix = new global::DevExpress.XtraGrid.Views.Grid.GridView();
			this.gcMaPhieuTron = new global::DevExpress.XtraGrid.Columns.GridColumn();
			this.gcDate = new global::DevExpress.XtraGrid.Columns.GridColumn();
			this.gcTime = new global::DevExpress.XtraGrid.Columns.GridColumn();
			this.gcKhachHang = new global::DevExpress.XtraGrid.Columns.GridColumn();
			this.gcCongTruong = new global::DevExpress.XtraGrid.Columns.GridColumn();
			this.gcTaiXe = new global::DevExpress.XtraGrid.Columns.GridColumn();
			this.gcMAC = new global::DevExpress.XtraGrid.Columns.GridColumn();
			this.gcKLMe = new global::DevExpress.XtraGrid.Columns.GridColumn();
			this.gcAgg1 = new global::DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn5 = new global::DevExpress.XtraGrid.Columns.GridColumn();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.simpleButton1 = new global::DevExpress.XtraEditors.SimpleButton();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.txtMaPT = new global::DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new global::DevExpress.XtraEditors.LabelControl();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.datToDate = new global::DevExpress.XtraEditors.DateEdit();
			this.datFromData = new global::DevExpress.XtraEditors.DateEdit();
			this.labelControl2 = new global::DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new global::DevExpress.XtraEditors.LabelControl();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.panelControl1 = new global::DevExpress.XtraEditors.PanelControl();
			this.labelControl4 = new global::DevExpress.XtraEditors.LabelControl();
			((global::System.ComponentModel.ISupportInitialize)this.groupControl1).BeginInit();
			this.groupControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.grcDataMix).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.grvDataMix).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.txtMaPT.Properties).BeginInit();
			this.groupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.datToDate.Properties.CalendarTimeProperties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.datToDate.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.datFromData.Properties.CalendarTimeProperties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.datFromData.Properties).BeginInit();
			this.groupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.panelControl1).BeginInit();
			this.panelControl1.SuspendLayout();
			base.SuspendLayout();
			this.groupControl1.Controls.Add(this.grcDataMix);
			this.groupControl1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.groupControl1.Location = new global::System.Drawing.Point(3, 82);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new global::System.Drawing.Size(878, 530);
			this.groupControl1.TabIndex = 3;
			this.groupControl1.Text = "Dữ liệu";
			this.grcDataMix.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.grcDataMix.Location = new global::System.Drawing.Point(2, 23);
			this.grcDataMix.MainView = this.grvDataMix;
			this.grcDataMix.Name = "grcDataMix";
			this.grcDataMix.Size = new global::System.Drawing.Size(874, 505);
			this.grcDataMix.TabIndex = 0;
			this.grcDataMix.ViewCollection.AddRange(new global::DevExpress.XtraGrid.Views.Base.BaseView[]
			{
				this.grvDataMix
			});
			this.grvDataMix.Columns.AddRange(new global::DevExpress.XtraGrid.Columns.GridColumn[]
			{
				this.gcMaPhieuTron,
				this.gcDate,
				this.gcTime,
				this.gcKhachHang,
				this.gcCongTruong,
				this.gcTaiXe,
				this.gcMAC,
				this.gcKLMe,
				this.gcAgg1,
				this.gridColumn5
			});
			this.grvDataMix.GridControl = this.grcDataMix;
			this.grvDataMix.Name = "grvDataMix";
			this.grvDataMix.OptionsView.ShowFooter = true;
			this.gcMaPhieuTron.Caption = "Mã Phiếu trộn";
			this.gcMaPhieuTron.FieldName = "MaPhieuTron";
			this.gcMaPhieuTron.Name = "gcMaPhieuTron";
			this.gcMaPhieuTron.Visible = true;
			this.gcMaPhieuTron.VisibleIndex = 0;
			this.gcDate.Caption = "Ngày trộn";
			this.gcDate.FieldName = "Ngay";
			this.gcDate.Name = "gcDate";
			this.gcDate.Visible = true;
			this.gcDate.VisibleIndex = 1;
			this.gcTime.Caption = "Giờ";
			this.gcTime.FieldName = "Gio";
			this.gcTime.Name = "gcTime";
			this.gcTime.Visible = true;
			this.gcTime.VisibleIndex = 2;
			this.gcKhachHang.Caption = "Khách hàng";
			this.gcKhachHang.FieldName = "KH";
			this.gcKhachHang.Name = "gcKhachHang";
			this.gcKhachHang.Visible = true;
			this.gcKhachHang.VisibleIndex = 3;
			this.gcCongTruong.Caption = "Công trường";
			this.gcCongTruong.FieldName = "CT";
			this.gcCongTruong.Name = "gcCongTruong";
			this.gcCongTruong.Visible = true;
			this.gcCongTruong.VisibleIndex = 4;
			this.gcTaiXe.Caption = "Tài xế";
			this.gcTaiXe.FieldName = "Name";
			this.gcTaiXe.Name = "gcTaiXe";
			this.gcTaiXe.Visible = true;
			this.gcTaiXe.VisibleIndex = 5;
			this.gcMAC.Caption = "MAC";
			this.gcMAC.FieldName = "MAC";
			this.gcMAC.Name = "gcMAC";
			this.gcMAC.Visible = true;
			this.gcMAC.VisibleIndex = 6;
			this.gcKLMe.Caption = "KL Mẻ";
			this.gcKLMe.FieldName = "KLMe";
			this.gcKLMe.Name = "gcKLMe";
			this.gcKLMe.Visible = true;
			this.gcKLMe.VisibleIndex = 7;
			this.gcAgg1.Caption = "Agg 1";
			this.gcAgg1.FieldName = "Agg1";
			this.gcAgg1.Name = "gcAgg1";
			this.gcAgg1.Visible = true;
			this.gcAgg1.VisibleIndex = 8;
			this.gridColumn5.Caption = "gridColumn5";
			this.gridColumn5.Name = "gridColumn5";
			this.gridColumn5.Visible = true;
			this.gridColumn5.VisibleIndex = 9;
			this.groupBox1.Controls.Add(this.simpleButton1);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.groupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(253, 615);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Lựa chọn";
			this.simpleButton1.Location = new global::System.Drawing.Point(61, 361);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new global::System.Drawing.Size(112, 32);
			this.simpleButton1.TabIndex = 2;
			this.simpleButton1.Text = "Tìm kiếm";
			this.groupBox3.Controls.Add(this.txtMaPT);
			this.groupBox3.Controls.Add(this.labelControl3);
			this.groupBox3.Location = new global::System.Drawing.Point(19, 134);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(228, 182);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Bộ lọc";
			this.txtMaPT.Location = new global::System.Drawing.Point(107, 30);
			this.txtMaPT.Name = "txtMaPT";
			this.txtMaPT.Size = new global::System.Drawing.Size(115, 20);
			this.txtMaPT.TabIndex = 2;
			this.labelControl3.Location = new global::System.Drawing.Point(22, 33);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new global::System.Drawing.Size(66, 13);
			this.labelControl3.TabIndex = 1;
			this.labelControl3.Text = "Mã phiếu trộn";
			this.groupBox2.Controls.Add(this.datToDate);
			this.groupBox2.Controls.Add(this.datFromData);
			this.groupBox2.Controls.Add(this.labelControl2);
			this.groupBox2.Controls.Add(this.labelControl1);
			this.groupBox2.Location = new global::System.Drawing.Point(19, 34);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(228, 88);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Khoảng thời gian";
			this.datToDate.EditValue = null;
			this.datToDate.Location = new global::System.Drawing.Point(62, 54);
			this.datToDate.Name = "datToDate";
			this.datToDate.Properties.Buttons.AddRange(new global::DevExpress.XtraEditors.Controls.EditorButton[]
			{
				new global::DevExpress.XtraEditors.Controls.EditorButton(global::DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
			});
			this.datToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new global::DevExpress.XtraEditors.Controls.EditorButton[]
			{
				new global::DevExpress.XtraEditors.Controls.EditorButton(global::DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
			});
			this.datToDate.Size = new global::System.Drawing.Size(160, 20);
			this.datToDate.TabIndex = 3;
			this.datFromData.EditValue = null;
			this.datFromData.Location = new global::System.Drawing.Point(62, 22);
			this.datFromData.Name = "datFromData";
			this.datFromData.Properties.Buttons.AddRange(new global::DevExpress.XtraEditors.Controls.EditorButton[]
			{
				new global::DevExpress.XtraEditors.Controls.EditorButton(global::DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
			});
			this.datFromData.Properties.CalendarTimeProperties.Buttons.AddRange(new global::DevExpress.XtraEditors.Controls.EditorButton[]
			{
				new global::DevExpress.XtraEditors.Controls.EditorButton(global::DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
			});
			this.datFromData.Size = new global::System.Drawing.Size(160, 20);
			this.datFromData.TabIndex = 2;
			this.labelControl2.Location = new global::System.Drawing.Point(22, 57);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new global::System.Drawing.Size(20, 13);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "Đến";
			this.labelControl1.Location = new global::System.Drawing.Point(22, 25);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new global::System.Drawing.Size(13, 13);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Từ";
			this.groupBox4.Controls.Add(this.panelControl1);
			this.groupBox4.Controls.Add(this.groupControl1);
			this.groupBox4.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.groupBox4.Location = new global::System.Drawing.Point(253, 0);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new global::System.Drawing.Size(884, 615);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.panelControl1.BorderStyle = global::DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.labelControl4);
			this.panelControl1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelControl1.Location = new global::System.Drawing.Point(3, 17);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new global::System.Drawing.Size(878, 59);
			this.panelControl1.TabIndex = 4;
			this.labelControl4.Appearance.Font = new global::System.Drawing.Font("Tahoma", 27.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Appearance.Options.UseTextOptions = true;
			this.labelControl4.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Center;
			this.labelControl4.Appearance.TextOptions.VAlignment = global::DevExpress.Utils.VertAlignment.Center;
			this.labelControl4.Location = new global::System.Drawing.Point(158, 10);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new global::System.Drawing.Size(532, 45);
			this.labelControl4.TabIndex = 0;
			this.labelControl4.Text = "BÁO CÁO CHI TIẾT MẺ TRỘN";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1137, 615);
			base.Controls.Add(this.groupBox4);
			base.Controls.Add(this.groupBox1);
			base.Name = "FrmDataMix";
			this.Text = "FrmDataMix";
			((global::System.ComponentModel.ISupportInitialize)this.groupControl1).EndInit();
			this.groupControl1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.grcDataMix).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.grvDataMix).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.txtMaPT.Properties).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.datToDate.Properties.CalendarTimeProperties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.datToDate.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.datFromData.Properties.CalendarTimeProperties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.datFromData.Properties).EndInit();
			this.groupBox4.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.panelControl1).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040006E8 RID: 1768
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040006E9 RID: 1769
		private global::DevExpress.XtraEditors.GroupControl groupControl1;

		// Token: 0x040006EA RID: 1770
		private global::DevExpress.XtraGrid.GridControl grcDataMix;

		// Token: 0x040006EB RID: 1771
		private global::DevExpress.XtraGrid.Views.Grid.GridView grvDataMix;

		// Token: 0x040006EC RID: 1772
		private global::DevExpress.XtraGrid.Columns.GridColumn gcMaPhieuTron;

		// Token: 0x040006ED RID: 1773
		private global::DevExpress.XtraGrid.Columns.GridColumn gcDate;

		// Token: 0x040006EE RID: 1774
		private global::DevExpress.XtraGrid.Columns.GridColumn gcTime;

		// Token: 0x040006EF RID: 1775
		private global::DevExpress.XtraGrid.Columns.GridColumn gcKhachHang;

		// Token: 0x040006F0 RID: 1776
		private global::DevExpress.XtraGrid.Columns.GridColumn gcCongTruong;

		// Token: 0x040006F1 RID: 1777
		private global::DevExpress.XtraGrid.Columns.GridColumn gcTaiXe;

		// Token: 0x040006F2 RID: 1778
		private global::DevExpress.XtraGrid.Columns.GridColumn gcMAC;

		// Token: 0x040006F3 RID: 1779
		private global::DevExpress.XtraGrid.Columns.GridColumn gcKLMe;

		// Token: 0x040006F4 RID: 1780
		private global::DevExpress.XtraGrid.Columns.GridColumn gcAgg1;

		// Token: 0x040006F5 RID: 1781
		private global::DevExpress.XtraGrid.Columns.GridColumn gridColumn5;

		// Token: 0x040006F6 RID: 1782
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040006F7 RID: 1783
		private global::DevExpress.XtraEditors.SimpleButton simpleButton1;

		// Token: 0x040006F8 RID: 1784
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x040006F9 RID: 1785
		private global::DevExpress.XtraEditors.TextEdit txtMaPT;

		// Token: 0x040006FA RID: 1786
		private global::DevExpress.XtraEditors.LabelControl labelControl3;

		// Token: 0x040006FB RID: 1787
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x040006FC RID: 1788
		private global::DevExpress.XtraEditors.DateEdit datToDate;

		// Token: 0x040006FD RID: 1789
		private global::DevExpress.XtraEditors.DateEdit datFromData;

		// Token: 0x040006FE RID: 1790
		private global::DevExpress.XtraEditors.LabelControl labelControl2;

		// Token: 0x040006FF RID: 1791
		private global::DevExpress.XtraEditors.LabelControl labelControl1;

		// Token: 0x04000700 RID: 1792
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x04000701 RID: 1793
		private global::DevExpress.XtraEditors.PanelControl panelControl1;

		// Token: 0x04000702 RID: 1794
		private global::DevExpress.XtraEditors.LabelControl labelControl4;
	}
}
