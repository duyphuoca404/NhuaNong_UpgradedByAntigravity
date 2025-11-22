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
			this.ucCanFD = new global::NhuaNong.UserControls.ucNhomChinhCan();
			this.ucCanAG = new global::NhuaNong.UserControls.ucNhomChinhCan();
			this.ucCanAP = new global::NhuaNong.UserControls.ucNhomChinhCan();
			this.ucCanSB = new global::NhuaNong.UserControls.ucNhomChinhCan();
			this.ucNhietTS = new global::NhuaNong.UserControls.ucNhomChinhNhietDo();
			this.ucNhietAG = new global::NhuaNong.UserControls.ucNhomChinhNhietDo();
			this.ucNhietAP = new global::NhuaNong.UserControls.ucNhomChinhNhietDo();
			this.ucNhietTL = new global::NhuaNong.UserControls.ucNhomChinhNhietDo();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			base.SuspendLayout();
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
			this.ucCanAG.GiaTri_KLThucTe = "1";
			this.ucCanAG.GiaTri_Nhap0 = "1";
			this.ucCanAG.GiaTri_NhapHeSo = "1";
			this.ucCanAG.GiaTri_NhapTai = "1";
			this.ucCanAG.GiaTri_Xung = "1";
			this.ucCanAG.Location = new global::System.Drawing.Point(12, 214);
			this.ucCanAG.Name = "ucCanAG";
			this.ucCanAG.NameGroup = "Khối lượng AGG";
			this.ucCanAG.Size = new global::System.Drawing.Size(370, 196);
			this.ucCanAG.TabIndex = 1;
			this.ucCanAG.ButtonChinh0_Down += new global::NhuaNong.UserControls.ucNhomChinhCan.ButtonEventHandler(this.ucCanAG_ButtonChinh0_Down);
			this.ucCanAG.ButtonChinh0_Up += new global::NhuaNong.UserControls.ucNhomChinhCan.ButtonEventHandler(this.ucCanAG_ButtonChinh0_Up);
			this.ucCanAG.ButtonChinhTai_Down += new global::NhuaNong.UserControls.ucNhomChinhCan.ButtonEventHandler(this.ucCanAG_ButtonChinhTai_Down);
			this.ucCanAG.ButtonChinhTai_Up += new global::NhuaNong.UserControls.ucNhomChinhCan.ButtonEventHandler(this.ucCanAG_ButtonChinhTai_Up);
			this.ucCanAG.Enter_Down_Nhap0 += new global::NhuaNong.UserControls.ucNhomChinhCan.EnterKey(this.ucCanAG_Enter_Down_Nhap0);
			this.ucCanAG.Enter_Down_NhapTai += new global::NhuaNong.UserControls.ucNhomChinhCan.EnterKey(this.ucCanAG_Enter_Down_NhapTai);
			this.ucCanAG.Enter_Down_NhapHeSo += new global::NhuaNong.UserControls.ucNhomChinhCan.EnterKey(this.ucCanAG_Enter_Down_NhapHeSo);
			this.ucCanAP.GiaTri_KLThucTe = "1";
			this.ucCanAP.GiaTri_Nhap0 = "1";
			this.ucCanAP.GiaTri_NhapHeSo = "1";
			this.ucCanAP.GiaTri_NhapTai = "1";
			this.ucCanAP.GiaTri_Xung = "1";
			this.ucCanAP.Location = new global::System.Drawing.Point(12, 416);
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
			this.ucCanSB.GiaTri_KLThucTe = "1";
			this.ucCanSB.GiaTri_Nhap0 = "1";
			this.ucCanSB.GiaTri_NhapHeSo = "1";
			this.ucCanSB.GiaTri_NhapTai = "1";
			this.ucCanSB.GiaTri_Xung = "1";
			this.ucCanSB.Location = new global::System.Drawing.Point(12, 618);
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
			this.ucNhietTS.GiaTri_KLThucTe = null;
			this.ucNhietTS.GiaTri_NhapHeSo = "";
			this.ucNhietTS.GiaTri_NhapT1 = null;
			this.ucNhietTS.GiaTri_NhapT2 = null;
			this.ucNhietTS.GiaTri_Xung = "";
			this.ucNhietTS.Location = new global::System.Drawing.Point(413, 12);
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
			this.ucNhietAG.GiaTri_KLThucTe = null;
			this.ucNhietAG.GiaTri_NhapHeSo = "";
			this.ucNhietAG.GiaTri_NhapT1 = null;
			this.ucNhietAG.GiaTri_NhapT2 = null;
			this.ucNhietAG.GiaTri_Xung = "";
			this.ucNhietAG.Location = new global::System.Drawing.Point(409, 214);
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
			this.ucNhietAP.GiaTri_KLThucTe = null;
			this.ucNhietAP.GiaTri_NhapHeSo = "";
			this.ucNhietAP.GiaTri_NhapT1 = null;
			this.ucNhietAP.GiaTri_NhapT2 = null;
			this.ucNhietAP.GiaTri_Xung = "";
			this.ucNhietAP.Location = new global::System.Drawing.Point(409, 416);
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
			this.ucNhietTL.GiaTri_KLThucTe = null;
			this.ucNhietTL.GiaTri_NhapHeSo = "";
			this.ucNhietTL.GiaTri_NhapT1 = null;
			this.ucNhietTL.GiaTri_NhapT2 = null;
			this.ucNhietTL.GiaTri_Xung = "";
			this.ucNhietTL.Location = new global::System.Drawing.Point(409, 618);
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
			this.timer1.Enabled = true;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(791, 818);
			base.Controls.Add(this.ucNhietTL);
			base.Controls.Add(this.ucNhietAP);
			base.Controls.Add(this.ucNhietAG);
			base.Controls.Add(this.ucNhietTS);
			base.Controls.Add(this.ucCanSB);
			base.Controls.Add(this.ucCanAP);
			base.Controls.Add(this.ucCanAG);
			base.Controls.Add(this.ucCanFD);
			base.IconOptions.Image = global::NhuaNong.ResourceNhua.logoV_64;
			base.Name = "FrmChinhCan";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chỉnh cân";
			base.Load += new global::System.EventHandler(this.FrmChinhCan_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x040006DC RID: 1756
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040006DD RID: 1757
		private global::NhuaNong.UserControls.ucNhomChinhCan ucCanFD;

		// Token: 0x040006DE RID: 1758
		private global::NhuaNong.UserControls.ucNhomChinhCan ucCanAG;

		// Token: 0x040006DF RID: 1759
		private global::NhuaNong.UserControls.ucNhomChinhCan ucCanAP;

		// Token: 0x040006E0 RID: 1760
		private global::NhuaNong.UserControls.ucNhomChinhCan ucCanSB;

		// Token: 0x040006E1 RID: 1761
		private global::NhuaNong.UserControls.ucNhomChinhNhietDo ucNhietTS;

		// Token: 0x040006E2 RID: 1762
		private global::NhuaNong.UserControls.ucNhomChinhNhietDo ucNhietAG;

		// Token: 0x040006E3 RID: 1763
		private global::NhuaNong.UserControls.ucNhomChinhNhietDo ucNhietAP;

		// Token: 0x040006E4 RID: 1764
		private global::NhuaNong.UserControls.ucNhomChinhNhietDo ucNhietTL;

		// Token: 0x040006E5 RID: 1765
		private global::System.Windows.Forms.Timer timer1;
	}
}
