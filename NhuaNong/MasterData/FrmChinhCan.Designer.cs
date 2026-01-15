namespace NhuaNong.MasterData
{
	// Token: 0x02000095 RID: 149
	public partial class FrmChinhCan : global::NhuaNong.DialogViewBase, global::NhuaNong.MasterData.IFrmKiemDinhCan, global::NhuaNong.IBase
	{
		// Token: 0x0600092C RID: 2348 RVA: 0x00056865 File Offset: 0x00054A65
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00056884 File Offset: 0x00054A84
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.xtraTabControl1 = new global::DevExpress.XtraTab.XtraTabControl();
			this.tabCotLieu = new global::DevExpress.XtraTab.XtraTabPage();
			this.tabPheuCanKhac = new global::DevExpress.XtraTab.XtraTabPage();
			this.tabNhietDo = new global::DevExpress.XtraTab.XtraTabPage();
			this.ucCanFD = new global::NhuaNong.UserControls.ucNhomChinhCan();
			this.ucCanAG = new global::NhuaNong.UserControls.ucNhomChinhCan();
			this.ucCanAG2 = new global::NhuaNong.UserControls.ucNhomChinhCan();
			this.ucCanAG3 = new global::NhuaNong.UserControls.ucNhomChinhCan();
			this.ucCanAG4 = new global::NhuaNong.UserControls.ucNhomChinhCan();
			this.ucCanAG5 = new global::NhuaNong.UserControls.ucNhomChinhCan();
			this.ucCanAP = new global::NhuaNong.UserControls.ucNhomChinhCan();
			this.ucCanSB = new global::NhuaNong.UserControls.ucNhomChinhCan();
			this.ucNhietTS = new global::NhuaNong.UserControls.ucNhomChinhNhietDo();
			this.ucNhietAG = new global::NhuaNong.UserControls.ucNhomChinhNhietDo();
			this.ucNhietAP = new global::NhuaNong.UserControls.ucNhomChinhNhietDo();
			this.ucNhietTL = new global::NhuaNong.UserControls.ucNhomChinhNhietDo();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			((global::System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			this.xtraTabControl1.SuspendLayout();
			this.tabCotLieu.SuspendLayout();
			this.tabPheuCanKhac.SuspendLayout();
			this.tabNhietDo.SuspendLayout();
			base.SuspendLayout();
			
			// 
			// xtraTabControl1
			// 
			this.xtraTabControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.xtraTabControl1.Location = new global::System.Drawing.Point(0, 0);
			this.xtraTabControl1.Name = "xtraTabControl1";
			this.xtraTabControl1.SelectedTabPage = this.tabCotLieu;
			this.xtraTabControl1.Size = new global::System.Drawing.Size(791, 818);
			this.xtraTabControl1.TabIndex = 0;
			this.xtraTabControl1.TabPages.AddRange(new global::DevExpress.XtraTab.XtraTabPage[] {
			this.tabCotLieu,
			this.tabPheuCanKhac,
			this.tabNhietDo});
			
			// 
			// tabCotLieu
			// 
			this.tabCotLieu.Controls.Add(this.ucCanAG);
			this.tabCotLieu.Controls.Add(this.ucCanAG2);
			this.tabCotLieu.Controls.Add(this.ucCanAG3);
			this.tabCotLieu.Controls.Add(this.ucCanAG4);
			this.tabCotLieu.Controls.Add(this.ucCanAG5);
			this.tabCotLieu.AutoScroll = true;
			this.tabCotLieu.Name = "tabCotLieu";
			this.tabCotLieu.Size = new global::System.Drawing.Size(789, 793);
			this.tabCotLieu.Text = "Cốt Liệu";
            // 
			// tabPheuCanKhac
			// 
			this.tabPheuCanKhac.Controls.Add(this.ucCanFD);
			this.tabPheuCanKhac.Controls.Add(this.ucCanAP);
			this.tabPheuCanKhac.Controls.Add(this.ucCanSB);
			this.tabPheuCanKhac.Name = "tabPheuCanKhac";
			this.tabPheuCanKhac.Size = new global::System.Drawing.Size(789, 793);
			this.tabPheuCanKhac.Text = "Phễu Cân Khác";
			// 
			// tabNhietDo
			// 
			this.tabNhietDo.Controls.Add(this.ucNhietTS);
			this.tabNhietDo.Controls.Add(this.ucNhietAG);
			this.tabNhietDo.Controls.Add(this.ucNhietAP);
			this.tabNhietDo.Controls.Add(this.ucNhietTL);
			this.tabNhietDo.Name = "tabNhietDo";
			this.tabNhietDo.Size = new global::System.Drawing.Size(789, 793);
			this.tabNhietDo.Text = "Nhiệt Độ";

			// ucCanFD
			this.ucCanFD.GiaTri_KLThucTe = "1";
			this.ucCanFD.GiaTri_Nhap0 = "1";
			this.ucCanFD.GiaTri_NhapHeSo = "1";
			this.ucCanFD.GiaTri_NhapTai = "1";
			this.ucCanFD.GiaTri_Xung = "1";
			this.ucCanFD.Location = new global::System.Drawing.Point(12, 12);
			this.ucCanFD.Name = "ucCanFD";
			this.ucCanFD.NameGroup = "Khối lượng FD";
			this.ucCanFD.Size = new global::System.Drawing.Size(370, 196);
			this.ucCanFD.TabIndex = 0;
			this.ucCanFD.ButtonChinh0_Down += new global::NhuaNong.UserControls.ucNhomChinhCan.ButtonEventHandler(this.ucCanFD_ButtonChinh0_Down);
			this.ucCanFD.ButtonChinh0_Up += new global::NhuaNong.UserControls.ucNhomChinhCan.ButtonEventHandler(this.ucCanFD_ButtonChinh0_Up);
			this.ucCanFD.ButtonChinhTai_Down += new global::NhuaNong.UserControls.ucNhomChinhCan.ButtonEventHandler(this.ucCanFD_ButtonChinhTai_Down);
			this.ucCanFD.ButtonChinhTai_Up += new global::NhuaNong.UserControls.ucNhomChinhCan.ButtonEventHandler(this.ucCanFD_ButtonChinhTai_Up);
			this.ucCanFD.Enter_Down_Nhap0 += new global::NhuaNong.UserControls.ucNhomChinhCan.EnterKey(this.ucCanFD_Enter_Down_Nhap0);
			this.ucCanFD.Enter_Down_NhapTai += new global::NhuaNong.UserControls.ucNhomChinhCan.EnterKey(this.ucCanFD_Enter_Down_NhapTai);
			this.ucCanFD.Enter_Down_NhapHeSo += new global::NhuaNong.UserControls.ucNhomChinhCan.EnterKey(this.ucCanFD_Enter_Down_NhapHeSo);

			// ucCanAG (AGG1)
			this.ucCanAG.GiaTri_KLThucTe = "1";
			this.ucCanAG.GiaTri_Nhap0 = "1";
			this.ucCanAG.GiaTri_NhapHeSo = "1";
			this.ucCanAG.GiaTri_NhapTai = "1";
			this.ucCanAG.GiaTri_Xung = "1";
			this.ucCanAG.Location = new global::System.Drawing.Point(12, 12);
			this.ucCanAG.Name = "ucCanAG";
			this.ucCanAG.NameGroup = "Khối lượng AGG1";
			this.ucCanAG.Size = new global::System.Drawing.Size(370, 196);
			this.ucCanAG.TabIndex = 1;
			this.ucCanAG.ButtonChinh0_Down += new global::NhuaNong.UserControls.ucNhomChinhCan.ButtonEventHandler(this.ucCanAG_ButtonChinh0_Down);
			this.ucCanAG.ButtonChinh0_Up += new global::NhuaNong.UserControls.ucNhomChinhCan.ButtonEventHandler(this.ucCanAG_ButtonChinh0_Up);
			this.ucCanAG.ButtonChinhTai_Down += new global::NhuaNong.UserControls.ucNhomChinhCan.ButtonEventHandler(this.ucCanAG_ButtonChinhTai_Down);
			this.ucCanAG.ButtonChinhTai_Up += new global::NhuaNong.UserControls.ucNhomChinhCan.ButtonEventHandler(this.ucCanAG_ButtonChinhTai_Up);
			this.ucCanAG.Enter_Down_Nhap0 += new global::NhuaNong.UserControls.ucNhomChinhCan.EnterKey(this.ucCanAG_Enter_Down_Nhap0);
			this.ucCanAG.Enter_Down_NhapTai += new global::NhuaNong.UserControls.ucNhomChinhCan.EnterKey(this.ucCanAG_Enter_Down_NhapTai);
			this.ucCanAG.Enter_Down_NhapHeSo += new global::NhuaNong.UserControls.ucNhomChinhCan.EnterKey(this.ucCanAG_Enter_Down_NhapHeSo);

			// ucCanAG2
			this.ucCanAG2.GiaTri_KLThucTe = "1";
			this.ucCanAG2.GiaTri_Nhap0 = "1";
			this.ucCanAG2.GiaTri_NhapHeSo = "1";
			this.ucCanAG2.GiaTri_NhapTai = "1";
			this.ucCanAG2.GiaTri_Xung = "1";
			this.ucCanAG2.Location = new global::System.Drawing.Point(400, 12);
			this.ucCanAG2.Name = "ucCanAG2";
			this.ucCanAG2.NameGroup = "Khối lượng AGG2";
			this.ucCanAG2.Size = new global::System.Drawing.Size(370, 196);
			this.ucCanAG2.TabIndex = 20;

			// ucCanAG3
			this.ucCanAG3.GiaTri_KLThucTe = "1";
			this.ucCanAG3.GiaTri_Nhap0 = "1";
			this.ucCanAG3.GiaTri_NhapHeSo = "1";
			this.ucCanAG3.GiaTri_NhapTai = "1";
			this.ucCanAG3.GiaTri_Xung = "1";
			this.ucCanAG3.Location = new global::System.Drawing.Point(12, 214);
			this.ucCanAG3.Name = "ucCanAG3";
			this.ucCanAG3.NameGroup = "Khối lượng AGG3";
			this.ucCanAG3.Size = new global::System.Drawing.Size(370, 196);
			this.ucCanAG3.TabIndex = 21;

			// ucCanAG4
			this.ucCanAG4.GiaTri_KLThucTe = "1";
			this.ucCanAG4.GiaTri_Nhap0 = "1";
			this.ucCanAG4.GiaTri_NhapHeSo = "1";
			this.ucCanAG4.GiaTri_NhapTai = "1";
			this.ucCanAG4.GiaTri_Xung = "1";
			this.ucCanAG4.Location = new global::System.Drawing.Point(400, 214);
			this.ucCanAG4.Name = "ucCanAG4";
			this.ucCanAG4.NameGroup = "Khối lượng AGG4";
			this.ucCanAG4.Size = new global::System.Drawing.Size(370, 196);
			this.ucCanAG4.TabIndex = 22;

			// ucCanAG5
			this.ucCanAG5.GiaTri_KLThucTe = "1";
			this.ucCanAG5.GiaTri_Nhap0 = "1";
			this.ucCanAG5.GiaTri_NhapHeSo = "1";
			this.ucCanAG5.GiaTri_NhapTai = "1";
			this.ucCanAG5.GiaTri_Xung = "1";
			this.ucCanAG5.Location = new global::System.Drawing.Point(12, 416);
			this.ucCanAG5.Name = "ucCanAG5";
			this.ucCanAG5.NameGroup = "Khối lượng AGG5";
			this.ucCanAG5.Size = new global::System.Drawing.Size(370, 196);
			this.ucCanAG5.TabIndex = 23;

			// ucCanAP
			this.ucCanAP.GiaTri_KLThucTe = "1";
			this.ucCanAP.GiaTri_Nhap0 = "1";
			this.ucCanAP.GiaTri_NhapHeSo = "1";
			this.ucCanAP.GiaTri_NhapTai = "1";
			this.ucCanAP.GiaTri_Xung = "1";
			this.ucCanAP.Location = new global::System.Drawing.Point(400, 12);
			this.ucCanAP.Name = "ucCanAP";
			this.ucCanAP.NameGroup = "Khối lượng AP";
			this.ucCanAP.Size = new global::System.Drawing.Size(370, 196);
			this.ucCanAP.TabIndex = 2;
			this.ucCanAP.ButtonChinh0_Down += new global::NhuaNong.UserControls.ucNhomChinhCan.ButtonEventHandler(this.ucCanAP_ButtonChinh0_Down);
			this.ucCanAP.ButtonChinh0_Up += new global::NhuaNong.UserControls.ucNhomChinhCan.ButtonEventHandler(this.ucCanAP_ButtonChinh0_Up);
			this.ucCanAP.ButtonChinhTai_Down += new global::NhuaNong.UserControls.ucNhomChinhCan.ButtonEventHandler(this.ucCanAP_ButtonChinhTai_Down);
			this.ucCanAP.ButtonChinhTai_Up += new global::NhuaNong.UserControls.ucNhomChinhCan.ButtonEventHandler(this.ucCanAP_ButtonChinhTai_Up);
			this.ucCanAP.Enter_Down_Nhap0 += new global::NhuaNong.UserControls.ucNhomChinhCan.EnterKey(this.ucCanAP_Enter_Down_Nhap0);
			this.ucCanAP.Enter_Down_NhapTai += new global::NhuaNong.UserControls.ucNhomChinhCan.EnterKey(this.ucCanAP_Enter_Down_NhapTai);
			this.ucCanAP.Enter_Down_NhapHeSo += new global::NhuaNong.UserControls.ucNhomChinhCan.EnterKey(this.ucCanAP_Enter_Down_NhapHeSo);

			// ucCanSB
			this.ucCanSB.GiaTri_KLThucTe = "1";
			this.ucCanSB.GiaTri_Nhap0 = "1";
			this.ucCanSB.GiaTri_NhapHeSo = "1";
			this.ucCanSB.GiaTri_NhapTai = "1";
			this.ucCanSB.GiaTri_Xung = "1";
			this.ucCanSB.Location = new global::System.Drawing.Point(12, 214);
			this.ucCanSB.Name = "ucCanSB";
			this.ucCanSB.NameGroup = "Khối lượng SB";
			this.ucCanSB.Size = new global::System.Drawing.Size(370, 196);
			this.ucCanSB.TabIndex = 3;
			this.ucCanSB.ButtonChinh0_Down += new global::NhuaNong.UserControls.ucNhomChinhCan.ButtonEventHandler(this.ucCanSB_ButtonChinh0_Down);
			this.ucCanSB.ButtonChinh0_Up += new global::NhuaNong.UserControls.ucNhomChinhCan.ButtonEventHandler(this.ucCanSB_ButtonChinh0_Up);
			this.ucCanSB.ButtonChinhTai_Down += new global::NhuaNong.UserControls.ucNhomChinhCan.ButtonEventHandler(this.ucCanSB_ButtonChinhTai_Down);
			this.ucCanSB.ButtonChinhTai_Up += new global::NhuaNong.UserControls.ucNhomChinhCan.ButtonEventHandler(this.ucCanSB_ButtonChinhTai_Up);
			this.ucCanSB.Enter_Down_Nhap0 += new global::NhuaNong.UserControls.ucNhomChinhCan.EnterKey(this.ucCanSB_Enter_Down_Nhap0);
			this.ucCanSB.Enter_Down_NhapTai += new global::NhuaNong.UserControls.ucNhomChinhCan.EnterKey(this.ucCanSB_Enter_Down_NhapTai);
			this.ucCanSB.Enter_Down_NhapHeSo += new global::NhuaNong.UserControls.ucNhomChinhCan.EnterKey(this.ucCanSB_Enter_Down_NhapHeSo);

			// ucNhietTS
			this.ucNhietTS.GiaTri_KLThucTe = null;
			this.ucNhietTS.GiaTri_NhapHeSo = "";
			this.ucNhietTS.GiaTri_NhapT1 = null;
			this.ucNhietTS.GiaTri_NhapT2 = null;
			this.ucNhietTS.GiaTri_Xung = "";
			this.ucNhietTS.Location = new global::System.Drawing.Point(12, 12);
			this.ucNhietTS.Name = "ucNhietTS";
			this.ucNhietTS.NameGroup = "Nhiệt độ Tan sấy";
			this.ucNhietTS.Size = new global::System.Drawing.Size(370, 196);
			this.ucNhietTS.TabIndex = 4;
			this.ucNhietTS.ButtonChinhT1_Down += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTS_ButtonChinhT1_Down);
			this.ucNhietTS.ButtonChinhT1_Up += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTS_ButtonChinhT1_Up);
			this.ucNhietTS.ButtonChinhT2_Down += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTS_ButtonChinhT2_Down);
			this.ucNhietTS.ButtonChinhT2_Up += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTS_ButtonChinhT2_Up);
			this.ucNhietTS.Enter_Down_Nhap0 += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.EnterKey(this.ucNhietTS_Enter_Down_Nhap0);
			this.ucNhietTS.Enter_Down_NhapTai += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.EnterKey(this.ucNhietTS_Enter_Down_NhapTai);
			this.ucNhietTS.Enter_Down_NhapHeSo += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.EnterKey(this.ucNhietTS_Enter_Down_NhapHeSo);

			// ucNhietAG
			this.ucNhietAG.GiaTri_KLThucTe = null;
			this.ucNhietAG.GiaTri_NhapHeSo = "";
			this.ucNhietAG.GiaTri_NhapT1 = null;
			this.ucNhietAG.GiaTri_NhapT2 = null;
			this.ucNhietAG.GiaTri_Xung = "";
			this.ucNhietAG.Location = new global::System.Drawing.Point(400, 12);
			this.ucNhietAG.Name = "ucNhietAG";
			this.ucNhietAG.NameGroup = "Nhiệt độ AG";
			this.ucNhietAG.Size = new global::System.Drawing.Size(370, 196);
			this.ucNhietAG.TabIndex = 5;
			this.ucNhietAG.ButtonChinhT1_Down += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAG_ButtonChinhT1_Down);
			this.ucNhietAG.ButtonChinhT1_Up += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAG_ButtonChinhT1_Up);
			this.ucNhietAG.ButtonChinhT2_Down += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAG_ButtonChinhT2_Down);
			this.ucNhietAG.ButtonChinhT2_Up += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAG_ButtonChinhT2_Up);
			this.ucNhietAG.Enter_Down_Nhap0 += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.EnterKey(this.ucNhietAG_Enter_Down_Nhap0);
			this.ucNhietAG.Enter_Down_NhapTai += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.EnterKey(this.ucNhietAG_Enter_Down_NhapTai);
			this.ucNhietAG.Enter_Down_NhapHeSo += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.EnterKey(this.ucNhietAG_Enter_Down_NhapHeSo);

			// ucNhietAP
			this.ucNhietAP.GiaTri_KLThucTe = null;
			this.ucNhietAP.GiaTri_NhapHeSo = "";
			this.ucNhietAP.GiaTri_NhapT1 = null;
			this.ucNhietAP.GiaTri_NhapT2 = null;
			this.ucNhietAP.GiaTri_Xung = "";
			this.ucNhietAP.Location = new global::System.Drawing.Point(12, 214);
			this.ucNhietAP.Name = "ucNhietAP";
			this.ucNhietAP.NameGroup = "Nhiệt độ Nhựa";
			this.ucNhietAP.Size = new global::System.Drawing.Size(370, 196);
			this.ucNhietAP.TabIndex = 6;
			this.ucNhietAP.ButtonChinhT1_Down += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAP_ButtonChinhT1_Down);
			this.ucNhietAP.ButtonChinhT1_Up += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAP_ButtonChinhT1_Up);
			this.ucNhietAP.ButtonChinhT2_Down += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAP_ButtonChinhT2_Down);
			this.ucNhietAP.ButtonChinhT2_Up += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAP_ButtonChinhT2_Up);
			this.ucNhietAP.Enter_Down_Nhap0 += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.EnterKey(this.ucNhietAP_Enter_Down_Nhap0);
			this.ucNhietAP.Enter_Down_NhapTai += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.EnterKey(this.ucNhietAP_Enter_Down_NhapTai);
			this.ucNhietAP.Enter_Down_NhapHeSo += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.EnterKey(this.ucNhietAP_Enter_Down_NhapHeSo);

			// ucNhietTL
			this.ucNhietTL.GiaTri_KLThucTe = null;
			this.ucNhietTL.GiaTri_NhapHeSo = "";
			this.ucNhietTL.GiaTri_NhapT1 = null;
			this.ucNhietTL.GiaTri_NhapT2 = null;
			this.ucNhietTL.GiaTri_Xung = "";
			this.ucNhietTL.Location = new global::System.Drawing.Point(400, 214);
			this.ucNhietTL.Name = "ucNhietTL";
			this.ucNhietTL.NameGroup = "Nhiệt độ Túi lọc";
			this.ucNhietTL.Size = new global::System.Drawing.Size(370, 196);
			this.ucNhietTL.TabIndex = 7;
			this.ucNhietTL.ButtonChinhT1_Down += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTL_ButtonChinhT1_Down);
			this.ucNhietTL.ButtonChinhT1_Up += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTL_ButtonChinhT1_Up);
			this.ucNhietTL.ButtonChinhT2_Down += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTL_ButtonChinhT2_Down);
			this.ucNhietTL.ButtonChinhT2_Up += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTL_ButtonChinhT2_Up);
			this.ucNhietTL.Enter_Down_Nhap0 += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.EnterKey(this.ucNhietTL_Enter_Down_Nhap0);
			this.ucNhietTL.Enter_Down_NhapTai += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.EnterKey(this.ucNhietTL_Enter_Down_NhapTai);
			this.ucNhietTL.Enter_Down_NhapHeSo += new global::NhuaNong.UserControls.ucNhomChinhNhietDo.EnterKey(this.ucNhietTL_Enter_Down_NhapHeSo);

			// timer1
			this.timer1.Enabled = true;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			
			// FrmChinhCan
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(791, 818);
			base.Controls.Add(this.xtraTabControl1);
			base.IconOptions.Image = global::NhuaNong.ResourceNhua.logoV_64;
			this.Name = "FrmChinhCan";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kiểm định cân";
			base.Load += new global::System.EventHandler(this.FrmChinhCan_Load);
			((global::System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			this.xtraTabControl1.ResumeLayout(false);
			this.tabCotLieu.ResumeLayout(false);
			this.tabPheuCanKhac.ResumeLayout(false);
			this.tabNhietDo.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040006DC RID: 1756
		private global::System.ComponentModel.IContainer components;
		
		private global::DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private global::DevExpress.XtraTab.XtraTabPage tabCotLieu;
		private global::DevExpress.XtraTab.XtraTabPage tabPheuCanKhac;
		private global::DevExpress.XtraTab.XtraTabPage tabNhietDo;

		private global::NhuaNong.UserControls.ucNhomChinhCan ucCanFD;
		private global::NhuaNong.UserControls.ucNhomChinhCan ucCanAG;
		private global::NhuaNong.UserControls.ucNhomChinhCan ucCanAG2;
		private global::NhuaNong.UserControls.ucNhomChinhCan ucCanAG3;
		private global::NhuaNong.UserControls.ucNhomChinhCan ucCanAG4;
		private global::NhuaNong.UserControls.ucNhomChinhCan ucCanAG5;
		private global::NhuaNong.UserControls.ucNhomChinhCan ucCanAP;
		private global::NhuaNong.UserControls.ucNhomChinhCan ucCanSB;

		private global::NhuaNong.UserControls.ucNhomChinhNhietDo ucNhietTS;
		private global::NhuaNong.UserControls.ucNhomChinhNhietDo ucNhietAG;
		private global::NhuaNong.UserControls.ucNhomChinhNhietDo ucNhietAP;
		private global::NhuaNong.UserControls.ucNhomChinhNhietDo ucNhietTL;

		// Token: 0x040006E5 RID: 1765
		private global::System.Windows.Forms.Timer timer1;
	}
}
