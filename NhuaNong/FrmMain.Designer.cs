namespace NhuaNong
{
	// Token: 0x02000010 RID: 16
	public partial class FrmMain : global::DevExpress.XtraEditors.XtraForm
	{
		// Token: 0x060000BF RID: 191 RVA: 0x0000BED7 File Offset: 0x0000A0D7
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barMenu = new DevExpress.XtraBars.Bar();
            this.bsiSystem = new DevExpress.XtraBars.BarSubItem();
            this.bbiLogin = new DevExpress.XtraBars.BarButtonItem();
            this.bbiLogoff = new DevExpress.XtraBars.BarButtonItem();
            this.bbiChangePass = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCloseTabs = new DevExpress.XtraBars.BarButtonItem();
            this.bbiConfig = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExit = new DevExpress.XtraBars.BarButtonItem();
            this.bsiTool = new DevExpress.XtraBars.BarSubItem();
            this.bbiVanHanh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiConfigPrint = new DevExpress.XtraBars.BarButtonItem();
            this.bsiReports = new DevExpress.XtraBars.BarSubItem();
            this.bbiChiTietMeTron = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTongKhoiLuongBeTong = new DevExpress.XtraBars.BarButtonItem();
            this.bbiChiTietTongKhoiLuongBeTong = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTongVatTu = new DevExpress.XtraBars.BarButtonItem();
            this.bbiChiTietChuyenXe = new DevExpress.XtraBars.BarButtonItem();
            this.bbiChiTietTaiXe = new DevExpress.XtraBars.BarButtonItem();
            this.bsiManage = new DevExpress.XtraBars.BarSubItem();
            this.bbiContract = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPhieuTron = new DevExpress.XtraBars.BarButtonItem();
            this.bsiMasterData = new DevExpress.XtraBars.BarSubItem();
            this.bbiCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.bbiJobSite = new DevExpress.XtraBars.BarButtonItem();
            this.bbiHangMuc = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMac = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGroupSilo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMaterial = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDriver = new DevExpress.XtraBars.BarButtonItem();
            this.bbiXe = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.bsiThongSo = new DevExpress.XtraBars.BarSubItem();
            this.bbiSilo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiWeigh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTimerPara = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDoAmAgg = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCongThucDoHutNuoc = new DevExpress.XtraBars.BarButtonItem();
            this.bbiKiemDinhCan = new DevExpress.XtraBars.BarButtonItem();
            this.bsiAdmin = new DevExpress.XtraBars.BarSubItem();
            this.bbiUser = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRole = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRoleAssign = new DevExpress.XtraBars.BarButtonItem();
            this.bbiFunctionAssign = new DevExpress.XtraBars.BarButtonItem();
            this.sbsTheme = new DevExpress.XtraBars.SkinBarSubItem();
            this.bsiHelp = new DevExpress.XtraBars.BarSubItem();
            this.bbiAbout = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUserGuide = new DevExpress.XtraBars.BarButtonItem();
            this.bbiConfigUI = new DevExpress.XtraBars.BarButtonItem();
            this.bbiConfigPrint1 = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRemind = new DevExpress.XtraBars.BarStaticItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bbiLogoProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiConnectPLC = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbiReport = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.bsiWebProduct = new DevExpress.XtraBars.BarStaticItem();
            this.bsiPhoneProduct = new DevExpress.XtraBars.BarStaticItem();
            this.bsiNameProduct = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barLinkContainerItem1 = new DevExpress.XtraBars.BarLinkContainerItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.repositoryItemPictureEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barMenu,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bsiSystem,
            this.bsiManage,
            this.bsiThongSo,
            this.bsiMasterData,
            this.bsiTool,
            this.bsiAdmin,
            this.bsiHelp,
            this.sbsTheme,
            this.bbiLogin,
            this.bbiLogoff,
            this.bbiChangePass,
            this.bbiCloseTabs,
            this.bbiConfig,
            this.bbiExit,
            this.bbiContract,
            this.bbiPhieuTron,
            this.bbiSilo,
            this.bbiDoAmAgg,
            this.bbiCongThucDoHutNuoc,
            this.bbiKiemDinhCan,
            this.bbiCustomer,
            this.bbiJobSite,
            this.bbiDriver,
            this.bbiXe,
            this.bbiMac,
            this.bbiGroupSilo,
            this.bbiMaterial,
            this.bbiVanHanh,
            this.bbiReport,
            this.bbiUser,
            this.bbiRole,
            this.bbiRoleAssign,
            this.bbiFunctionAssign,
            this.bbiAbout,
            this.bbiUserGuide,
            this.bbiWeigh,
            this.bbiTimerPara,
            this.barSubItem1,
            this.bsiWebProduct,
            this.bsiPhoneProduct,
            this.bsiNameProduct,
            this.barEditItem1,
            this.barEditItem2,
            this.barEditItem3,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.bbiConnectPLC,
            this.bbiLogoProduct,
            this.barLinkContainerItem1,
            this.bbiConfigUI,
            this.bsiReports,
            this.barButtonItem7,
            this.barButtonItem8,
            this.bbiConfigPrint1,
            this.bbiTongVatTu,
            this.bbiTongKhoiLuongBeTong,
            this.bbiChiTietChuyenXe,
            this.bbiChiTietMeTron,
            this.bbiChiTietTongKhoiLuongBeTong,
            this.barButtonItem9,
            this.barButtonItem10,
            this.bbiNhanVien,
            this.bbiHangMuc,
            this.barButtonItem13,
            this.barButtonItem14,
            this.bbiChiTietTaiXe,
            this.barHeaderItem1,
            this.barStaticItem4,
            this.bsiRemind,
            this.barSubItem2,
            this.bbiConfigPrint});
            this.barManager1.MainMenu = this.barMenu;
            this.barManager1.MaxItemId = 79;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit2});
            this.barManager1.StatusBar = this.bar3;
            // 
            // barMenu
            // 
            this.barMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.barMenu.BarAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barMenu.BarAppearance.Disabled.Options.UseFont = true;
            this.barMenu.BarAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barMenu.BarAppearance.Hovered.Options.UseFont = true;
            this.barMenu.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barMenu.BarAppearance.Normal.Options.UseFont = true;
            this.barMenu.BarName = "Main menu";
            this.barMenu.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.barMenu.DockCol = 0;
            this.barMenu.DockRow = 0;
            this.barMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiSystem),
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiTool),
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiReports),
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiManage),
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiMasterData),
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiThongSo),
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiAdmin),
            new DevExpress.XtraBars.LinkPersistInfo(this.sbsTheme),
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiHelp),
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiRemind)});
            this.barMenu.OptionsBar.UseWholeRow = true;
            this.barMenu.Text = "Main menu";
            // 
            // bsiSystem
            // 
            this.bsiSystem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiSystem.Caption = "Hệ Thống";
            this.bsiSystem.Id = 0;
            this.bsiSystem.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsiSystem.ItemAppearance.Normal.Options.UseFont = true;
            this.bsiSystem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiLogin),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiLogoff),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiChangePass),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiCloseTabs),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiConfig),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExit)});
            this.bsiSystem.Name = "bsiSystem";
            // 
            // bbiLogin
            // 
            this.bbiLogin.Caption = "Đăng Nhập";
            this.bbiLogin.Id = 8;
            this.bbiLogin.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiLogin.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiLogin.Name = "bbiLogin";
            this.bbiLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiLogin_ItemClick);
            // 
            // bbiLogoff
            // 
            this.bbiLogoff.Caption = "Đăng Xuất";
            this.bbiLogoff.Id = 9;
            this.bbiLogoff.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiLogoff.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiLogoff.Name = "bbiLogoff";
            this.bbiLogoff.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiLogoff_ItemClick);
            // 
            // bbiChangePass
            // 
            this.bbiChangePass.Caption = "Thay Đổi Mật Khẩu";
            this.bbiChangePass.Id = 10;
            this.bbiChangePass.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiChangePass.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiChangePass.Name = "bbiChangePass";
            this.bbiChangePass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiChangePass_ItemClick);
            // 
            // bbiCloseTabs
            // 
            this.bbiCloseTabs.Caption = "Đóng Tất Cả Các Tab";
            this.bbiCloseTabs.Id = 11;
            this.bbiCloseTabs.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiCloseTabs.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiCloseTabs.Name = "bbiCloseTabs";
            this.bbiCloseTabs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCloseTabs_ItemClick);
            // 
            // bbiConfig
            // 
            this.bbiConfig.Caption = "Cấu Hình";
            this.bbiConfig.Id = 12;
            this.bbiConfig.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiConfig.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiConfig.Name = "bbiConfig";
            this.bbiConfig.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiConfig_ItemClick);
            // 
            // bbiExit
            // 
            this.bbiExit.Caption = "Thoát";
            this.bbiExit.Id = 13;
            this.bbiExit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiExit.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiExit.Name = "bbiExit";
            this.bbiExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExit_ItemClick);
            // 
            // bsiTool
            // 
            this.bsiTool.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiTool.Caption = "VACM";
            this.bsiTool.Id = 4;
            this.bsiTool.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.bsiTool.ItemAppearance.Normal.Options.UseFont = true;
            this.bsiTool.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiVanHanh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiConfigPrint)});
            this.bsiTool.Name = "bsiTool";
            // 
            // bbiVanHanh
            // 
            this.bbiVanHanh.Caption = "Màn Hình Vận Hành";
            this.bbiVanHanh.Id = 27;
            this.bbiVanHanh.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiVanHanh.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiVanHanh.Name = "bbiVanHanh";
            this.bbiVanHanh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTronOnline_ItemClick);
            // 
            // bbiConfigPrint
            // 
            this.bbiConfigPrint.Caption = "Phiếu In";
            this.bbiConfigPrint.Id = 78;
            this.bbiConfigPrint.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiConfigPrint.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiConfigPrint.Name = "bbiConfigPrint";
            this.bbiConfigPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPhieuIn_ItemClick);
            // 
            // bsiReports
            // 
            this.bsiReports.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiReports.Caption = "Báo Cáo";
            this.bsiReports.Id = 58;
            this.bsiReports.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.bsiReports.ItemAppearance.Normal.Options.UseFont = true;
            this.bsiReports.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiChiTietMeTron),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiTongKhoiLuongBeTong),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiChiTietTongKhoiLuongBeTong),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiTongVatTu),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiChiTietChuyenXe),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiChiTietTaiXe)});
            this.bsiReports.Name = "bsiReports";
            // 
            // bbiChiTietMeTron
            // 
            this.bbiChiTietMeTron.Caption = "Chi tiết mẻ trộn";
            this.bbiChiTietMeTron.Id = 65;
            this.bbiChiTietMeTron.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiChiTietMeTron.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiChiTietMeTron.Name = "bbiChiTietMeTron";
            this.bbiChiTietMeTron.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiChiTietMeTron_ItemClick);
            // 
            // bbiTongKhoiLuongBeTong
            // 
            this.bbiTongKhoiLuongBeTong.Caption = "Tổng khối lương bê tông";
            this.bbiTongKhoiLuongBeTong.Id = 63;
            this.bbiTongKhoiLuongBeTong.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiTongKhoiLuongBeTong.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiTongKhoiLuongBeTong.Name = "bbiTongKhoiLuongBeTong";
            this.bbiTongKhoiLuongBeTong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTongKhoiLuongBeTong_ItemClick);
            // 
            // bbiChiTietTongKhoiLuongBeTong
            // 
            this.bbiChiTietTongKhoiLuongBeTong.Caption = "Chi tiết khối lượng bê tông";
            this.bbiChiTietTongKhoiLuongBeTong.Id = 66;
            this.bbiChiTietTongKhoiLuongBeTong.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiChiTietTongKhoiLuongBeTong.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiChiTietTongKhoiLuongBeTong.Name = "bbiChiTietTongKhoiLuongBeTong";
            this.bbiChiTietTongKhoiLuongBeTong.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiChiTietTongKhoiLuongBeTong.VisibleInSearchMenu = false;
            this.bbiChiTietTongKhoiLuongBeTong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiChiTietTongKhoiLuongBeTong_ItemClick);
            // 
            // bbiTongVatTu
            // 
            this.bbiTongVatTu.Caption = "Tổng vật tư";
            this.bbiTongVatTu.Id = 62;
            this.bbiTongVatTu.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiTongVatTu.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiTongVatTu.Name = "bbiTongVatTu";
            this.bbiTongVatTu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiTongVatTu.VisibleInSearchMenu = false;
            this.bbiTongVatTu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTongVatTu_ItemClick);
            // 
            // bbiChiTietChuyenXe
            // 
            this.bbiChiTietChuyenXe.Caption = "Tổng chuyến xe";
            this.bbiChiTietChuyenXe.Id = 64;
            this.bbiChiTietChuyenXe.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiChiTietChuyenXe.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiChiTietChuyenXe.Name = "bbiChiTietChuyenXe";
            this.bbiChiTietChuyenXe.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiChiTietChuyenXe.VisibleInSearchMenu = false;
            this.bbiChiTietChuyenXe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiChiTietChuyenXe_ItemClick);
            // 
            // bbiChiTietTaiXe
            // 
            this.bbiChiTietTaiXe.Caption = "Chi tiết tài xế";
            this.bbiChiTietTaiXe.Id = 73;
            this.bbiChiTietTaiXe.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiChiTietTaiXe.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiChiTietTaiXe.Name = "bbiChiTietTaiXe";
            this.bbiChiTietTaiXe.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiChiTietTaiXe.VisibleInSearchMenu = false;
            this.bbiChiTietTaiXe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiChiTietTaiXe_ItemClick);
            // 
            // bsiManage
            // 
            this.bsiManage.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiManage.Caption = "Quản Lý";
            this.bsiManage.Id = 1;
            this.bsiManage.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.bsiManage.ItemAppearance.Normal.Options.UseFont = true;
            this.bsiManage.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiContract),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPhieuTron)});
            this.bsiManage.Name = "bsiManage";
            // 
            // bbiContract
            // 
            this.bbiContract.Caption = "Hợp Đồng";
            this.bbiContract.Id = 14;
            this.bbiContract.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiContract.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiContract.Name = "bbiContract";
            this.bbiContract.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiContract_ItemClick);
            // 
            // bbiPhieuTron
            // 
            this.bbiPhieuTron.Caption = "Phiếu Trộn";
            this.bbiPhieuTron.Id = 15;
            this.bbiPhieuTron.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiPhieuTron.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiPhieuTron.Name = "bbiPhieuTron";
            this.bbiPhieuTron.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPhieuTron_ItemClick);
            // 
            // bsiMasterData
            // 
            this.bsiMasterData.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiMasterData.Caption = "Danh Mục";
            this.bsiMasterData.Id = 3;
            this.bsiMasterData.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsiMasterData.ItemAppearance.Normal.Options.UseFont = true;
            this.bsiMasterData.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiCustomer),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiJobSite),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiHangMuc),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiMac),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiGroupSilo),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiMaterial),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDriver),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiXe),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiNhanVien)});
            this.bsiMasterData.Name = "bsiMasterData";
            // 
            // bbiCustomer
            // 
            this.bbiCustomer.Caption = "Khách Hàng";
            this.bbiCustomer.Id = 20;
            this.bbiCustomer.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiCustomer.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiCustomer.Name = "bbiCustomer";
            this.bbiCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCustomer_ItemClick);
            // 
            // bbiJobSite
            // 
            this.bbiJobSite.Caption = "Công Trường";
            this.bbiJobSite.Id = 21;
            this.bbiJobSite.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiJobSite.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiJobSite.Name = "bbiJobSite";
            this.bbiJobSite.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiJobSite_ItemClick);
            // 
            // bbiHangMuc
            // 
            this.bbiHangMuc.Caption = "Hạng Mục";
            this.bbiHangMuc.Id = 70;
            this.bbiHangMuc.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiHangMuc.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiHangMuc.Name = "bbiHangMuc";
            this.bbiHangMuc.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiHangMuc.VisibleInSearchMenu = false;
            this.bbiHangMuc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiHangMuc_ItemClick);
            // 
            // bbiMac
            // 
            this.bbiMac.Caption = "MAC";
            this.bbiMac.Id = 24;
            this.bbiMac.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiMac.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiMac.Name = "bbiMac";
            this.bbiMac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiMac_ItemClick);
            // 
            // bbiGroupSilo
            // 
            this.bbiGroupSilo.Caption = "Nhóm Silo";
            this.bbiGroupSilo.Id = 25;
            this.bbiGroupSilo.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiGroupSilo.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiGroupSilo.Name = "bbiGroupSilo";
            this.bbiGroupSilo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiGroupSilo.VisibleInSearchMenu = false;
            this.bbiGroupSilo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGroupSilo_ItemClick);
            // 
            // bbiMaterial
            // 
            this.bbiMaterial.Caption = "Vật Tư";
            this.bbiMaterial.Id = 26;
            this.bbiMaterial.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiMaterial.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiMaterial.Name = "bbiMaterial";
            this.bbiMaterial.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiMaterial_ItemClick);
            // 
            // bbiDriver
            // 
            this.bbiDriver.Caption = "Tài Xế";
            this.bbiDriver.Id = 22;
            this.bbiDriver.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiDriver.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiDriver.Name = "bbiDriver";
            this.bbiDriver.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDriver_ItemClick);
            // 
            // bbiXe
            // 
            this.bbiXe.Caption = "Xe";
            this.bbiXe.Id = 23;
            this.bbiXe.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiXe.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiXe.Name = "bbiXe";
            this.bbiXe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiXe_ItemClick);
            // 
            // bbiNhanVien
            // 
            this.bbiNhanVien.Caption = "Nhân Viên";
            this.bbiNhanVien.Id = 69;
            this.bbiNhanVien.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiNhanVien.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiNhanVien.Name = "bbiNhanVien";
            this.bbiNhanVien.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNhanVien_ItemClick);
            // 
            // bsiThongSo
            // 
            this.bsiThongSo.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiThongSo.Caption = "Thông Số";
            this.bsiThongSo.Id = 2;
            this.bsiThongSo.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.bsiThongSo.ItemAppearance.Normal.Options.UseFont = true;
            this.bsiThongSo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSilo),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiWeigh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiTimerPara),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDoAmAgg),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiCongThucDoHutNuoc),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiKiemDinhCan)});
            this.bsiThongSo.Name = "bsiThongSo";
            // 
            // bbiSilo
            // 
            this.bbiSilo.Caption = "Thông Số Silo";
            this.bbiSilo.Id = 16;
            this.bbiSilo.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiSilo.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiSilo.Name = "bbiSilo";
            this.bbiSilo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSilo_ItemClick);
            // 
            // bbiWeigh
            // 
            this.bbiWeigh.Caption = "Thông Số Cân";
            this.bbiWeigh.Id = 35;
            this.bbiWeigh.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiWeigh.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiWeigh.Name = "bbiWeigh";
            this.bbiWeigh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiWeigh_ItemClick);
            // 
            // bbiTimerPara
            // 
            this.bbiTimerPara.Caption = "Thông Số Thời Gian";
            this.bbiTimerPara.Id = 36;
            this.bbiTimerPara.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiTimerPara.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiTimerPara.Name = "bbiTimerPara";
            this.bbiTimerPara.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTimerPara_ItemClick);
            // 
            // bbiDoAmAgg
            // 
            this.bbiDoAmAgg.Caption = "Độ Hút Nước";
            this.bbiDoAmAgg.Id = 17;
            this.bbiDoAmAgg.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiDoAmAgg.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiDoAmAgg.Name = "bbiDoAmAgg";
            this.bbiDoAmAgg.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiDoAmAgg.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDoAmAgg_ItemClick);
            // 
            // bbiCongThucDoHutNuoc
            // 
            this.bbiCongThucDoHutNuoc.Caption = "Công Thức Tính Độ Hút Nước";
            this.bbiCongThucDoHutNuoc.Id = 18;
            this.bbiCongThucDoHutNuoc.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiCongThucDoHutNuoc.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiCongThucDoHutNuoc.Name = "bbiCongThucDoHutNuoc";
            this.bbiCongThucDoHutNuoc.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiCongThucDoHutNuoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCongThucDoHutNuoc_ItemClick);
            // 
            // bbiKiemDinhCan
            // 
            this.bbiKiemDinhCan.Caption = "Kiểm Định Cân";
            this.bbiKiemDinhCan.Id = 19;
            this.bbiKiemDinhCan.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiKiemDinhCan.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiKiemDinhCan.Name = "bbiKiemDinhCan";
            this.bbiKiemDinhCan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiKiemDinhCan_ItemClick);
            // 
            // bsiAdmin
            // 
            this.bsiAdmin.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiAdmin.Caption = "Phân Quyền";
            this.bsiAdmin.Id = 5;
            this.bsiAdmin.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.bsiAdmin.ItemAppearance.Normal.Options.UseFont = true;
            this.bsiAdmin.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiUser),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRole),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRoleAssign),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiFunctionAssign)});
            this.bsiAdmin.Name = "bsiAdmin";
            // 
            // bbiUser
            // 
            this.bbiUser.Caption = "Người Dùng";
            this.bbiUser.Id = 29;
            this.bbiUser.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.bbiUser.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiUser.Name = "bbiUser";
            this.bbiUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiUser_ItemClick);
            // 
            // bbiRole
            // 
            this.bbiRole.Caption = "Vai Trò";
            this.bbiRole.Id = 30;
            this.bbiRole.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.bbiRole.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiRole.Name = "bbiRole";
            this.bbiRole.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRole_ItemClick);
            // 
            // bbiRoleAssign
            // 
            this.bbiRoleAssign.Caption = "Gán Vai Trò";
            this.bbiRoleAssign.Id = 31;
            this.bbiRoleAssign.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.bbiRoleAssign.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiRoleAssign.Name = "bbiRoleAssign";
            this.bbiRoleAssign.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRoleAssign_ItemClick);
            // 
            // bbiFunctionAssign
            // 
            this.bbiFunctionAssign.Caption = "Gán Chức Năng";
            this.bbiFunctionAssign.Id = 32;
            this.bbiFunctionAssign.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.bbiFunctionAssign.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiFunctionAssign.Name = "bbiFunctionAssign";
            this.bbiFunctionAssign.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFunctionAssign_ItemClick);
            // 
            // sbsTheme
            // 
            this.sbsTheme.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.sbsTheme.Caption = "Giao Diện";
            this.sbsTheme.Id = 7;
            this.sbsTheme.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.sbsTheme.ItemAppearance.Normal.Options.UseFont = true;
            this.sbsTheme.Name = "sbsTheme";
            this.sbsTheme.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.sbsTheme.VisibleInSearchMenu = false;
            // 
            // bsiHelp
            // 
            this.bsiHelp.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiHelp.Caption = "Trợ Giúp";
            this.bsiHelp.Id = 6;
            this.bsiHelp.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.bsiHelp.ItemAppearance.Normal.Options.UseFont = true;
            this.bsiHelp.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAbout),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiUserGuide),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiConfigUI),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiConfigPrint1)});
            this.bsiHelp.Name = "bsiHelp";
            this.bsiHelp.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bsiHelp.VisibleInSearchMenu = false;
            // 
            // bbiAbout
            // 
            this.bbiAbout.Caption = "Về Chúng Tôi";
            this.bbiAbout.Id = 33;
            this.bbiAbout.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.bbiAbout.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiAbout.Name = "bbiAbout";
            // 
            // bbiUserGuide
            // 
            this.bbiUserGuide.Caption = "Hướng Dẫn";
            this.bbiUserGuide.Id = 34;
            this.bbiUserGuide.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.bbiUserGuide.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiUserGuide.Name = "bbiUserGuide";
            // 
            // bbiConfigUI
            // 
            this.bbiConfigUI.Caption = "Tuỳ Chỉnh Giao Diện";
            this.bbiConfigUI.Id = 57;
            this.bbiConfigUI.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.bbiConfigUI.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiConfigUI.Name = "bbiConfigUI";
            this.bbiConfigUI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiConfigUI_ItemClick);
            // 
            // bbiConfigPrint1
            // 
            this.bbiConfigPrint1.Caption = "Tuỳ Chỉnh Phiếu In";
            this.bbiConfigPrint1.Id = 61;
            this.bbiConfigPrint1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiConfigPrint1.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiConfigPrint1.Name = "bbiConfigPrint1";
            this.bbiConfigPrint1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrint_ItemClick);
            // 
            // bsiRemind
            // 
            this.bsiRemind.Caption = ".";
            this.bsiRemind.Id = 76;
            this.bsiRemind.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsiRemind.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red;
            this.bsiRemind.ItemAppearance.Normal.Options.UseFont = true;
            this.bsiRemind.ItemAppearance.Normal.Options.UseForeColor = true;
            this.bsiRemind.Name = "bsiRemind";
            this.bsiRemind.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bsiRemind.VisibleInSearchMenu = false;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiLogoProduct),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiConnectPLC),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem4)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bbiLogoProduct
            // 
            this.bbiLogoProduct.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.bbiLogoProduct.AllowRightClickInMenu = false;
            this.bbiLogoProduct.Caption = "bbiLogo";
            this.bbiLogoProduct.Id = 55;
            this.bbiLogoProduct.Name = "bbiLogoProduct";
            this.bbiLogoProduct.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            this.bbiLogoProduct.Size = new System.Drawing.Size(0, 30);
            this.bbiLogoProduct.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiLogoProduct.VisibleInSearchMenu = false;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 53;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // bbiConnectPLC
            // 
            this.bbiConnectPLC.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiConnectPLC.Caption = "PLC";
            this.bbiConnectPLC.Id = 54;
            this.bbiConnectPLC.ImageOptions.Image = global::NhuaNong.ResourceNhua.DisCoPLC;
            this.bbiConnectPLC.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiConnectPLC.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiConnectPLC.Name = "bbiConnectPLC";
            this.bbiConnectPLC.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiConnectPLC.Size = new System.Drawing.Size(0, 32);
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Caption = ".";
            this.barStaticItem4.Id = 75;
            this.barStaticItem4.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barStaticItem4.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem4.Name = "barStaticItem4";
            this.barStaticItem4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1429, 35);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 671);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1429, 43);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 35);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 636);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1429, 35);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 636);
            // 
            // bbiReport
            // 
            this.bbiReport.Caption = "Báo Cáo";
            this.bbiReport.Id = 28;
            this.bbiReport.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiReport.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiReport.Name = "bbiReport";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Công ty TNHH Kỹ Thuật và Công Nghệ Nam Đại Phát";
            this.barSubItem1.Id = 37;
            this.barSubItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barSubItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // bsiWebProduct
            // 
            this.bsiWebProduct.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.bsiWebProduct.Caption = "namdaiphat.vn";
            this.bsiWebProduct.Id = 38;
            this.bsiWebProduct.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsiWebProduct.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Blue;
            this.bsiWebProduct.ItemAppearance.Normal.Options.UseFont = true;
            this.bsiWebProduct.ItemAppearance.Normal.Options.UseForeColor = true;
            this.bsiWebProduct.Name = "bsiWebProduct";
            // 
            // bsiPhoneProduct
            // 
            this.bsiPhoneProduct.Caption = "Liên hệ: 0901.922.262 - 0902.300.072\r\n";
            this.bsiPhoneProduct.Id = 39;
            this.bsiPhoneProduct.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsiPhoneProduct.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red;
            this.bsiPhoneProduct.ItemAppearance.Normal.Options.UseFont = true;
            this.bsiPhoneProduct.ItemAppearance.Normal.Options.UseForeColor = true;
            this.bsiPhoneProduct.Name = "bsiPhoneProduct";
            // 
            // bsiNameProduct
            // 
            this.bsiNameProduct.Caption = "CÔNG TY TNHH CƠ ĐIỆN , XÂY DỰNG VÀ CẢNH QUAN  157";
            this.bsiNameProduct.Id = 40;
            this.bsiNameProduct.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsiNameProduct.ItemAppearance.Normal.Options.UseFont = true;
            this.bsiNameProduct.Name = "bsiNameProduct";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Edit = null;
            this.barEditItem1.Id = 50;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Edit = null;
            this.barEditItem2.Id = 51;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // barEditItem3
            // 
            this.barEditItem3.Edit = null;
            this.barEditItem3.Id = 52;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem1.Caption = "Đã kết nối";
            this.barButtonItem1.ContentHorizontalAlignment = DevExpress.XtraBars.BarItemContentAlignment.Near;
            this.barButtonItem1.Id = 45;
            this.barButtonItem1.ImageOptions.Image = global::NhuaNong.ResourceNhua.CoPLC;
            this.barButtonItem1.ImageToTextAlignment = DevExpress.XtraBars.BarItemImageToTextAlignment.AfterText;
            this.barButtonItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.Size = new System.Drawing.Size(0, 26);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 47;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 48;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 49;
            this.barButtonItem5.ImageOptions.Image = global::NhuaNong.ResourceNhua.CoPLC;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barLinkContainerItem1
            // 
            this.barLinkContainerItem1.Caption = "barLinkContainerItem1";
            this.barLinkContainerItem1.Id = 56;
            this.barLinkContainerItem1.Name = "barLinkContainerItem1";
            this.barLinkContainerItem1.ShortcutKeyDisplayString = "https://namdaiphat.vn/";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Dữ liệu trộn";
            this.barButtonItem7.Id = 59;
            this.barButtonItem7.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.barButtonItem7.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Chi tiết phiếu trộn";
            this.barButtonItem8.Id = 60;
            this.barButtonItem8.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem8.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Phiếu In";
            this.barButtonItem9.Id = 67;
            this.barButtonItem9.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem9.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Sample";
            this.barButtonItem10.Id = 68;
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItem10.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem10_ItemClick);
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Templ";
            this.barButtonItem13.Id = 71;
            this.barButtonItem13.Name = "barButtonItem13";
            this.barButtonItem13.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItem13.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem13_ItemClick);
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "Chi tiết tài xế";
            this.barButtonItem14.Id = 72;
            this.barButtonItem14.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem14.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem14.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem14.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.barButtonItem14.Name = "barButtonItem14";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = ".";
            this.barHeaderItem1.Id = 74;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Phiếu In";
            this.barSubItem2.Id = 77;
            this.barSubItem2.Name = "barSubItem2";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // repositoryItemPictureEdit2
            // 
            this.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 714);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::NhuaNong.ResourceNhua.logoV_64;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VACM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x040000A6 RID: 166
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000A7 RID: 167
		private global::DevExpress.XtraBars.BarManager barManager1;

		// Token: 0x040000A8 RID: 168
		private global::DevExpress.XtraBars.Bar bar3;

		// Token: 0x040000A9 RID: 169
		private global::DevExpress.XtraBars.BarDockControl barDockControlTop;

		// Token: 0x040000AA RID: 170
		private global::DevExpress.XtraBars.BarDockControl barDockControlBottom;

		// Token: 0x040000AB RID: 171
		private global::DevExpress.XtraBars.BarDockControl barDockControlLeft;

		// Token: 0x040000AC RID: 172
		private global::DevExpress.XtraBars.BarDockControl barDockControlRight;

		// Token: 0x040000AD RID: 173
		private global::DevExpress.XtraBars.BarSubItem bsiSystem;

		// Token: 0x040000AE RID: 174
		private global::DevExpress.XtraBars.BarSubItem bsiManage;

		// Token: 0x040000AF RID: 175
		private global::DevExpress.XtraBars.BarSubItem bsiThongSo;

		// Token: 0x040000B0 RID: 176
		private global::DevExpress.XtraBars.BarSubItem bsiMasterData;

		// Token: 0x040000B1 RID: 177
		private global::DevExpress.XtraBars.BarSubItem bsiTool;

		// Token: 0x040000B2 RID: 178
		private global::DevExpress.XtraBars.BarSubItem bsiAdmin;

		// Token: 0x040000B3 RID: 179
		private global::DevExpress.XtraBars.BarSubItem bsiHelp;

		// Token: 0x040000B4 RID: 180
		private global::DevExpress.XtraBars.SkinBarSubItem sbsTheme;

		// Token: 0x040000B5 RID: 181
		private global::DevExpress.XtraBars.BarButtonItem bbiLogin;

		// Token: 0x040000B6 RID: 182
		private global::DevExpress.XtraBars.BarButtonItem bbiLogoff;

		// Token: 0x040000B7 RID: 183
		private global::DevExpress.XtraBars.BarButtonItem bbiChangePass;

		// Token: 0x040000B8 RID: 184
		private global::DevExpress.XtraBars.BarButtonItem bbiCloseTabs;

		// Token: 0x040000B9 RID: 185
		private global::DevExpress.XtraBars.BarButtonItem bbiConfig;

		// Token: 0x040000BA RID: 186
		private global::DevExpress.XtraBars.BarButtonItem bbiExit;

		// Token: 0x040000BB RID: 187
		private global::DevExpress.XtraBars.BarButtonItem bbiContract;

		// Token: 0x040000BC RID: 188
		private global::DevExpress.XtraBars.BarButtonItem bbiPhieuTron;

		// Token: 0x040000BD RID: 189
		private global::DevExpress.XtraBars.BarButtonItem bbiSilo;

		// Token: 0x040000BE RID: 190
		private global::DevExpress.XtraBars.BarButtonItem bbiDoAmAgg;

		// Token: 0x040000BF RID: 191
		private global::DevExpress.XtraBars.BarButtonItem bbiCongThucDoHutNuoc;

		// Token: 0x040000C0 RID: 192
		private global::DevExpress.XtraBars.BarButtonItem bbiKiemDinhCan;

		// Token: 0x040000C1 RID: 193
		private global::DevExpress.XtraBars.BarButtonItem bbiCustomer;

		// Token: 0x040000C2 RID: 194
		private global::DevExpress.XtraBars.BarButtonItem bbiJobSite;

		// Token: 0x040000C3 RID: 195
		private global::DevExpress.XtraBars.BarButtonItem bbiDriver;

		// Token: 0x040000C4 RID: 196
		private global::DevExpress.XtraBars.BarButtonItem bbiXe;

		// Token: 0x040000C5 RID: 197
		private global::DevExpress.XtraBars.BarButtonItem bbiMac;

		// Token: 0x040000C6 RID: 198
		private global::DevExpress.XtraBars.BarButtonItem bbiGroupSilo;

		// Token: 0x040000C7 RID: 199
		private global::DevExpress.XtraBars.BarButtonItem bbiMaterial;

		// Token: 0x040000C8 RID: 200
		private global::DevExpress.XtraBars.BarButtonItem bbiVanHanh;

		// Token: 0x040000C9 RID: 201
		private global::DevExpress.XtraBars.BarButtonItem bbiReport;

		// Token: 0x040000CA RID: 202
		private global::DevExpress.XtraBars.BarButtonItem bbiUser;

		// Token: 0x040000CB RID: 203
		private global::DevExpress.XtraBars.BarButtonItem bbiRole;

		// Token: 0x040000CC RID: 204
		private global::DevExpress.XtraBars.BarButtonItem bbiRoleAssign;

		// Token: 0x040000CD RID: 205
		private global::DevExpress.XtraBars.BarButtonItem bbiFunctionAssign;

		// Token: 0x040000CE RID: 206
		private global::DevExpress.XtraBars.BarButtonItem bbiAbout;

		// Token: 0x040000CF RID: 207
		private global::DevExpress.XtraBars.BarButtonItem bbiUserGuide;

		// Token: 0x040000D0 RID: 208
		private global::DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;

		// Token: 0x040000D1 RID: 209
		private global::DevExpress.XtraBars.BarButtonItem bbiWeigh;

		// Token: 0x040000D2 RID: 210
		private global::DevExpress.XtraBars.BarButtonItem bbiTimerPara;

		// Token: 0x040000D3 RID: 211
		private global::DevExpress.XtraBars.BarSubItem barSubItem1;

		// Token: 0x040000D4 RID: 212
		private global::DevExpress.XtraBars.BarStaticItem bsiWebProduct;

		// Token: 0x040000D5 RID: 213
		private global::DevExpress.XtraBars.BarStaticItem bsiPhoneProduct;

		// Token: 0x040000D6 RID: 214
		private global::DevExpress.XtraBars.BarStaticItem bsiNameProduct;

		// Token: 0x040000D7 RID: 215
		private global::DevExpress.XtraBars.BarEditItem barEditItem1;

		// Token: 0x040000D8 RID: 216
		private global::DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;

		// Token: 0x040000D9 RID: 217
		private global::DevExpress.XtraBars.BarEditItem barEditItem2;

		// Token: 0x040000DA RID: 218
		private global::DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;

		// Token: 0x040000DB RID: 219
		private global::DevExpress.XtraBars.BarEditItem barEditItem3;

		// Token: 0x040000DC RID: 220
		private global::DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit2;

		// Token: 0x040000DD RID: 221
		private global::DevExpress.XtraBars.BarButtonItem barButtonItem1;

		// Token: 0x040000DE RID: 222
		private global::DevExpress.XtraBars.BarButtonItem barButtonItem2;

		// Token: 0x040000DF RID: 223
		private global::DevExpress.XtraBars.BarButtonItem barButtonItem3;

		// Token: 0x040000E0 RID: 224
		private global::DevExpress.XtraBars.BarButtonItem barButtonItem4;

		// Token: 0x040000E1 RID: 225
		private global::DevExpress.XtraBars.BarButtonItem barButtonItem5;

		// Token: 0x040000E2 RID: 226
		private global::DevExpress.XtraBars.BarButtonItem bbiConnectPLC;

		// Token: 0x040000E3 RID: 227
		private global::System.Windows.Forms.Timer timer;

		// Token: 0x040000E4 RID: 228
		private global::DevExpress.XtraBars.BarButtonItem bbiLogoProduct;

		// Token: 0x040000E5 RID: 229
		private global::DevExpress.XtraBars.BarLinkContainerItem barLinkContainerItem1;

		// Token: 0x040000E6 RID: 230
		private global::DevExpress.XtraBars.BarButtonItem bbiConfigUI;

		// Token: 0x040000E7 RID: 231
		private global::DevExpress.XtraBars.BarSubItem bsiReports;

		// Token: 0x040000E8 RID: 232
		private global::DevExpress.XtraBars.BarButtonItem barButtonItem7;

		// Token: 0x040000E9 RID: 233
		private global::DevExpress.XtraBars.BarButtonItem barButtonItem8;

		// Token: 0x040000EA RID: 234
		private global::DevExpress.XtraBars.BarButtonItem bbiConfigPrint1;

		// Token: 0x040000EB RID: 235
		private global::DevExpress.XtraBars.BarButtonItem bbiTongVatTu;

		// Token: 0x040000EC RID: 236
		private global::DevExpress.XtraBars.BarButtonItem bbiTongKhoiLuongBeTong;

		// Token: 0x040000ED RID: 237
		private global::DevExpress.XtraBars.BarButtonItem bbiChiTietMeTron;

		// Token: 0x040000EE RID: 238
		private global::DevExpress.XtraBars.BarButtonItem bbiChiTietChuyenXe;

		// Token: 0x040000EF RID: 239
		private global::DevExpress.XtraBars.BarButtonItem bbiChiTietTongKhoiLuongBeTong;

		// Token: 0x040000F0 RID: 240
		private global::DevExpress.XtraBars.BarButtonItem barButtonItem9;

		// Token: 0x040000F1 RID: 241
		private global::DevExpress.XtraBars.BarButtonItem barButtonItem10;

		// Token: 0x040000F2 RID: 242
		private global::DevExpress.XtraBars.BarButtonItem bbiNhanVien;

		// Token: 0x040000F3 RID: 243
		private global::DevExpress.XtraBars.BarButtonItem bbiHangMuc;

		// Token: 0x040000F4 RID: 244
		private global::DevExpress.XtraBars.BarButtonItem barButtonItem13;

		// Token: 0x040000F5 RID: 245
		private global::DevExpress.XtraBars.BarButtonItem barButtonItem14;

		// Token: 0x040000F6 RID: 246
		private global::DevExpress.XtraBars.BarButtonItem bbiChiTietTaiXe;

		// Token: 0x040000F7 RID: 247
		private global::DevExpress.XtraBars.BarStaticItem barStaticItem4;

		// Token: 0x040000F8 RID: 248
		private global::DevExpress.XtraBars.BarHeaderItem barHeaderItem1;

		// Token: 0x040000F9 RID: 249
		private global::DevExpress.XtraBars.BarStaticItem bsiRemind;

		// Token: 0x040000FA RID: 250
		private global::DevExpress.XtraBars.Bar barMenu;

		// Token: 0x040000FB RID: 251
		private global::DevExpress.XtraBars.BarButtonItem bbiConfigPrint;

		// Token: 0x040000FC RID: 252
		private global::DevExpress.XtraBars.BarSubItem barSubItem2;
	}
}
