namespace NhuaNong
{
	// Token: 0x0200000F RID: 15
	public partial class FrmConfig : global::NhuaNong.DialogViewBase
	{
		// Token: 0x06000079 RID: 121 RVA: 0x00006078 File Offset: 0x00004278
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00006098 File Offset: 0x00004298
		private void InitializeComponent()
		{
			this.panelControl1 = new global::DevExpress.XtraEditors.PanelControl();
			this.btnCancel = new global::DevExpress.XtraEditors.SimpleButton();
			this.btnOk = new global::DevExpress.XtraEditors.SimpleButton();
			this.tabConfig = new global::DevExpress.XtraTab.XtraTabControl();
			this.tpgCompanyInfo = new global::DevExpress.XtraTab.XtraTabPage();
			this.bteLogoPath = new global::DevExpress.XtraEditors.ButtonEdit();
			this.labelControl3 = new global::DevExpress.XtraEditors.LabelControl();
			this.simpleButton1 = new global::DevExpress.XtraEditors.SimpleButton();
			this.labelControl2 = new global::DevExpress.XtraEditors.LabelControl();
			this.btnLoadImage = new global::DevExpress.XtraEditors.SimpleButton();
			this.pictureEdit1 = new global::DevExpress.XtraEditors.PictureEdit();
			this.txtDienThoaiCty = new global::DevExpress.XtraEditors.TextEdit();
			this.txtDiaChiCty = new global::DevExpress.XtraEditors.TextEdit();
			this.txtTenCty = new global::DevExpress.XtraEditors.TextEdit();
			this.lblPhone = new global::DevExpress.XtraEditors.LabelControl();
			this.lblAddress = new global::DevExpress.XtraEditors.LabelControl();
			this.lblCompanyName = new global::DevExpress.XtraEditors.LabelControl();
			this.tpgRunningMode = new global::DevExpress.XtraTab.XtraTabPage();
			this.txtPassword = new global::DevExpress.XtraEditors.TextEdit();
			this.txtUsername = new global::DevExpress.XtraEditors.TextEdit();
			this.txtDatabase = new global::DevExpress.XtraEditors.TextEdit();
			this.txtServer = new global::DevExpress.XtraEditors.TextEdit();
			this.lblPassword = new global::DevExpress.XtraEditors.LabelControl();
			this.lblUsername = new global::DevExpress.XtraEditors.LabelControl();
			this.lblDatabase = new global::DevExpress.XtraEditors.LabelControl();
			this.lblServerName = new global::DevExpress.XtraEditors.LabelControl();
			this.grpStandAlone = new global::DevExpress.XtraEditors.GroupControl();
			this.grpService = new global::DevExpress.XtraEditors.GroupControl();
			this.txtServerIP = new global::DevExpress.XtraEditors.TextEdit();
			this.lblEndpointAddress = new global::DevExpress.XtraEditors.LabelControl();
			this.lblRunningMode = new global::DevExpress.XtraEditors.LabelControl();
			this.lueRunningMode = new global::DevExpress.XtraEditors.LookUpEdit();
			this.tpgOptions = new global::DevExpress.XtraTab.XtraTabPage();
			this.xtraTabControl1 = new global::DevExpress.XtraTab.XtraTabControl();
			this.tpgRange = new global::DevExpress.XtraTab.XtraTabPage();
			this.spnKLTronLonNhat = new global::DevExpress.XtraEditors.SpinEdit();
			this.spnKLTronNhoNhat = new global::DevExpress.XtraEditors.SpinEdit();
			this.spnKLChoLonNhat = new global::DevExpress.XtraEditors.SpinEdit();
			this.lblKLTronLonNhat = new global::DevExpress.XtraEditors.LabelControl();
			this.lblKLTronNhoNhat = new global::DevExpress.XtraEditors.LabelControl();
			this.lblKLChoLonNhat = new global::DevExpress.XtraEditors.LabelControl();
			this.tpgFilter = new global::DevExpress.XtraTab.XtraTabPage();
			this.spnLatestBaoCaoDays = new global::DevExpress.XtraEditors.SpinEdit();
			this.labelControl5 = new global::DevExpress.XtraEditors.LabelControl();
			this.labelControl6 = new global::DevExpress.XtraEditors.LabelControl();
			this.spnLatestHopDongDays = new global::DevExpress.XtraEditors.SpinEdit();
			this.spnLatestPhieuTronDays = new global::DevExpress.XtraEditors.SpinEdit();
			this.lblLatestDay2 = new global::DevExpress.XtraEditors.LabelControl();
			this.lblLatestDay = new global::DevExpress.XtraEditors.LabelControl();
			this.lblPhieuTron = new global::DevExpress.XtraEditors.LabelControl();
			this.lblContract = new global::DevExpress.XtraEditors.LabelControl();
			this.tpgOthers = new global::DevExpress.XtraTab.XtraTabPage();
			this.bteImportPath_CT = new global::DevExpress.XtraEditors.ButtonEdit();
			this.btePdfReaderPath = new global::DevExpress.XtraEditors.ButtonEdit();
			this.labelControl9 = new global::DevExpress.XtraEditors.LabelControl();
			this.bteImportPath_GH = new global::DevExpress.XtraEditors.ButtonEdit();
			this.bteExportPath = new global::DevExpress.XtraEditors.ButtonEdit();
			this.chkDev = new global::DevExpress.XtraEditors.CheckEdit();
			this.labelControl7 = new global::DevExpress.XtraEditors.LabelControl();
			this.chkTronOnline = new global::DevExpress.XtraEditors.CheckEdit();
			this.chkTinhBuTru = new global::DevExpress.XtraEditors.CheckEdit();
			this.btnReportPathBrowse = new global::DevExpress.XtraEditors.SimpleButton();
			this.btnTestReportPath = new global::DevExpress.XtraEditors.SimpleButton();
			this.lblReportPath = new global::DevExpress.XtraEditors.LabelControl();
			this.xtraTabPage1 = new global::DevExpress.XtraTab.XtraTabPage();
			this.labelControl8 = new global::DevExpress.XtraEditors.LabelControl();
			this.beFilePathPLC = new global::DevExpress.XtraEditors.ButtonEdit();
			this.btnUploadToPLC = new global::DevExpress.XtraEditors.SimpleButton();
			this.tpgGeneral = new global::DevExpress.XtraTab.XtraTabPage();
			this.lueLanguages = new global::DevExpress.XtraEditors.LookUpEdit();
			this.txtLANPort = new global::DevExpress.XtraEditors.TextEdit();
			this.txtLANIP = new global::DevExpress.XtraEditors.TextEdit();
			this.labelControl4 = new global::DevExpress.XtraEditors.LabelControl();
			this.lblIP = new global::DevExpress.XtraEditors.LabelControl();
			this.txtPLCPort = new global::DevExpress.XtraEditors.TextEdit();
			this.btnTestPort = new global::DevExpress.XtraEditors.SimpleButton();
			this.btnChangePLCPort = new global::DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new global::DevExpress.XtraEditors.LabelControl();
			this.rdgLanguageRes = new global::DevExpress.XtraEditors.RadioGroup();
			this.lblLanguage = new global::DevExpress.XtraEditors.LabelControl();
			this.simpleButton2 = new global::DevExpress.XtraEditors.SimpleButton();
			this.simpleButton3 = new global::DevExpress.XtraEditors.SimpleButton();
			((global::System.ComponentModel.ISupportInitialize)this.panelControl1).BeginInit();
			this.panelControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.tabConfig).BeginInit();
			this.tabConfig.SuspendLayout();
			this.tpgCompanyInfo.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.bteLogoPath.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureEdit1.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtDienThoaiCty.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtDiaChiCty.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtTenCty.Properties).BeginInit();
			this.tpgRunningMode.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.txtPassword.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtUsername.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtDatabase.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtServer.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.grpStandAlone).BeginInit();
			this.grpStandAlone.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.grpService).BeginInit();
			this.grpService.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.txtServerIP.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lueRunningMode.Properties).BeginInit();
			this.tpgOptions.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.xtraTabControl1).BeginInit();
			this.xtraTabControl1.SuspendLayout();
			this.tpgRange.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.spnKLTronLonNhat.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.spnKLTronNhoNhat.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.spnKLChoLonNhat.Properties).BeginInit();
			this.tpgFilter.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.spnLatestBaoCaoDays.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.spnLatestHopDongDays.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.spnLatestPhieuTronDays.Properties).BeginInit();
			this.tpgOthers.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.bteImportPath_CT.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.btePdfReaderPath.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bteImportPath_GH.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bteExportPath.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkDev.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkTronOnline.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkTinhBuTru.Properties).BeginInit();
			this.xtraTabPage1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.beFilePathPLC.Properties).BeginInit();
			this.tpgGeneral.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lueLanguages.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtLANPort.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtLANIP.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtPLCPort.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.rdgLanguageRes.Properties).BeginInit();
			base.SuspendLayout();
			this.panelControl1.Controls.Add(this.simpleButton3);
			this.panelControl1.Controls.Add(this.simpleButton2);
			this.panelControl1.Controls.Add(this.btnCancel);
			this.panelControl1.Controls.Add(this.btnOk);
			this.panelControl1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panelControl1.Location = new global::System.Drawing.Point(0, 312);
			this.panelControl1.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new global::System.Drawing.Size(691, 40);
			this.panelControl1.TabIndex = 0;
			this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnCancel.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.Appearance.Options.UseFont = true;
			this.btnCancel.Location = new global::System.Drawing.Point(1045, 6);
			this.btnCancel.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(98, 30);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Huỷ Bỏ";
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.btnOk.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnOk.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnOk.Appearance.Options.UseFont = true;
			this.btnOk.Location = new global::System.Drawing.Point(931, 6);
			this.btnOk.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new global::System.Drawing.Size(98, 30);
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "Lưu";
			this.btnOk.Click += new global::System.EventHandler(this.btnOk_Click);
			this.tabConfig.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tabConfig.Location = new global::System.Drawing.Point(0, 0);
			this.tabConfig.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabConfig.Name = "tabConfig";
			this.tabConfig.SelectedTabPage = this.tpgCompanyInfo;
			this.tabConfig.Size = new global::System.Drawing.Size(691, 312);
			this.tabConfig.TabIndex = 0;
			this.tabConfig.TabPages.AddRange(new global::DevExpress.XtraTab.XtraTabPage[]
			{
				this.tpgRunningMode,
				this.tpgCompanyInfo,
				this.tpgOptions,
				this.tpgGeneral
			});
			this.tpgCompanyInfo.Controls.Add(this.bteLogoPath);
			this.tpgCompanyInfo.Controls.Add(this.labelControl3);
			this.tpgCompanyInfo.Controls.Add(this.simpleButton1);
			this.tpgCompanyInfo.Controls.Add(this.labelControl2);
			this.tpgCompanyInfo.Controls.Add(this.btnLoadImage);
			this.tpgCompanyInfo.Controls.Add(this.pictureEdit1);
			this.tpgCompanyInfo.Controls.Add(this.txtDienThoaiCty);
			this.tpgCompanyInfo.Controls.Add(this.txtDiaChiCty);
			this.tpgCompanyInfo.Controls.Add(this.txtTenCty);
			this.tpgCompanyInfo.Controls.Add(this.lblPhone);
			this.tpgCompanyInfo.Controls.Add(this.lblAddress);
			this.tpgCompanyInfo.Controls.Add(this.lblCompanyName);
			this.tpgCompanyInfo.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tpgCompanyInfo.Name = "tpgCompanyInfo";
			this.tpgCompanyInfo.Size = new global::System.Drawing.Size(689, 287);
			this.tpgCompanyInfo.Text = "Thông Tin Cty";
			this.bteLogoPath.Location = new global::System.Drawing.Point(167, 115);
			this.bteLogoPath.Name = "bteLogoPath";
			this.bteLogoPath.Properties.Buttons.AddRange(new global::DevExpress.XtraEditors.Controls.EditorButton[]
			{
				new global::DevExpress.XtraEditors.Controls.EditorButton()
			});
			this.bteLogoPath.Size = new global::System.Drawing.Size(304, 20);
			this.bteLogoPath.TabIndex = 12;
			this.bteLogoPath.ButtonClick += new global::DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
			this.bteLogoPath.EditValueChanged += new global::System.EventHandler(this.bteLogoPath_EditValueChanged);
			this.labelControl3.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Appearance.Options.UseTextOptions = true;
			this.labelControl3.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.labelControl3.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl3.Location = new global::System.Drawing.Point(49, 116);
			this.labelControl3.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new global::System.Drawing.Size(96, 16);
			this.labelControl3.TabIndex = 11;
			this.labelControl3.Text = "Đường dẫn logo";
			this.simpleButton1.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.simpleButton1.Appearance.Options.UseFont = true;
			this.simpleButton1.Location = new global::System.Drawing.Point(280, 144);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new global::System.Drawing.Size(98, 30);
			this.simpleButton1.TabIndex = 10;
			this.simpleButton1.Text = "Load Logo";
			this.simpleButton1.Visible = false;
			this.simpleButton1.Click += new global::System.EventHandler(this.simpleButton1_Click);
			this.labelControl2.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new global::System.Drawing.Point(509, 134);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new global::System.Drawing.Size(74, 16);
			this.labelControl2.TabIndex = 9;
			this.labelControl2.Text = "Logo Công ty";
			this.btnLoadImage.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnLoadImage.Appearance.Options.UseFont = true;
			this.btnLoadImage.Location = new global::System.Drawing.Point(167, 144);
			this.btnLoadImage.Name = "btnLoadImage";
			this.btnLoadImage.Size = new global::System.Drawing.Size(98, 30);
			this.btnLoadImage.TabIndex = 7;
			this.btnLoadImage.Text = "Thay đổi";
			this.btnLoadImage.Visible = false;
			this.btnLoadImage.Click += new global::System.EventHandler(this.btnLoadImage_Click);
			this.pictureEdit1.Location = new global::System.Drawing.Point(498, 28);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.NullText = " ";
			this.pictureEdit1.Properties.ShowCameraMenuItem = global::DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit1.Size = new global::System.Drawing.Size(100, 100);
			this.pictureEdit1.TabIndex = 6;
			this.pictureEdit1.LoadCompleted += new global::System.EventHandler(this.pictureEdit1_LoadCompleted);
			this.pictureEdit1.TextChanged += new global::System.EventHandler(this.pictureEdit1_TextChanged);
			this.txtDienThoaiCty.Location = new global::System.Drawing.Point(167, 85);
			this.txtDienThoaiCty.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDienThoaiCty.Name = "txtDienThoaiCty";
			this.txtDienThoaiCty.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtDienThoaiCty.Properties.Appearance.Options.UseFont = true;
			this.txtDienThoaiCty.Size = new global::System.Drawing.Size(304, 22);
			this.txtDienThoaiCty.TabIndex = 5;
			this.txtDiaChiCty.Location = new global::System.Drawing.Point(167, 55);
			this.txtDiaChiCty.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDiaChiCty.Name = "txtDiaChiCty";
			this.txtDiaChiCty.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtDiaChiCty.Properties.Appearance.Options.UseFont = true;
			this.txtDiaChiCty.Size = new global::System.Drawing.Size(304, 22);
			this.txtDiaChiCty.TabIndex = 4;
			this.txtTenCty.Location = new global::System.Drawing.Point(167, 25);
			this.txtTenCty.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTenCty.Name = "txtTenCty";
			this.txtTenCty.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtTenCty.Properties.Appearance.Options.UseFont = true;
			this.txtTenCty.Size = new global::System.Drawing.Size(304, 22);
			this.txtTenCty.TabIndex = 3;
			this.lblPhone.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblPhone.Appearance.Options.UseFont = true;
			this.lblPhone.Appearance.Options.UseTextOptions = true;
			this.lblPhone.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.lblPhone.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblPhone.Location = new global::System.Drawing.Point(49, 88);
			this.lblPhone.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new global::System.Drawing.Size(96, 16);
			this.lblPhone.TabIndex = 2;
			this.lblPhone.Text = "Số Điện Thoại";
			this.lblAddress.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblAddress.Appearance.Options.UseFont = true;
			this.lblAddress.Appearance.Options.UseTextOptions = true;
			this.lblAddress.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.lblAddress.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblAddress.Location = new global::System.Drawing.Point(49, 58);
			this.lblAddress.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new global::System.Drawing.Size(96, 16);
			this.lblAddress.TabIndex = 1;
			this.lblAddress.Text = "Địa Chỉ";
			this.lblCompanyName.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblCompanyName.Appearance.Options.UseFont = true;
			this.lblCompanyName.Appearance.Options.UseTextOptions = true;
			this.lblCompanyName.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.lblCompanyName.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblCompanyName.Location = new global::System.Drawing.Point(49, 28);
			this.lblCompanyName.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblCompanyName.Name = "lblCompanyName";
			this.lblCompanyName.Size = new global::System.Drawing.Size(96, 16);
			this.lblCompanyName.TabIndex = 0;
			this.lblCompanyName.Text = "Tên Công Ty";
			this.tpgRunningMode.Controls.Add(this.txtPassword);
			this.tpgRunningMode.Controls.Add(this.txtUsername);
			this.tpgRunningMode.Controls.Add(this.txtDatabase);
			this.tpgRunningMode.Controls.Add(this.txtServer);
			this.tpgRunningMode.Controls.Add(this.lblPassword);
			this.tpgRunningMode.Controls.Add(this.lblUsername);
			this.tpgRunningMode.Controls.Add(this.lblDatabase);
			this.tpgRunningMode.Controls.Add(this.lblServerName);
			this.tpgRunningMode.Controls.Add(this.grpStandAlone);
			this.tpgRunningMode.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tpgRunningMode.Name = "tpgRunningMode";
			this.tpgRunningMode.Size = new global::System.Drawing.Size(689, 287);
			this.tpgRunningMode.Text = "Running Mode";
			this.txtPassword.Location = new global::System.Drawing.Point(167, 115);
			this.txtPassword.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtPassword.Properties.Appearance.Options.UseFont = true;
			this.txtPassword.Properties.MaxLength = 20;
			this.txtPassword.Properties.PasswordChar = '*';
			this.txtPassword.Size = new global::System.Drawing.Size(189, 22);
			this.txtPassword.TabIndex = 15;
			this.txtUsername.Location = new global::System.Drawing.Point(167, 85);
			this.txtUsername.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtUsername.Properties.Appearance.Options.UseFont = true;
			this.txtUsername.Size = new global::System.Drawing.Size(189, 22);
			this.txtUsername.TabIndex = 14;
			this.txtDatabase.Location = new global::System.Drawing.Point(167, 55);
			this.txtDatabase.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDatabase.Name = "txtDatabase";
			this.txtDatabase.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtDatabase.Properties.Appearance.Options.UseFont = true;
			this.txtDatabase.Size = new global::System.Drawing.Size(189, 22);
			this.txtDatabase.TabIndex = 13;
			this.txtServer.Location = new global::System.Drawing.Point(167, 25);
			this.txtServer.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtServer.Name = "txtServer";
			this.txtServer.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtServer.Properties.Appearance.Options.UseFont = true;
			this.txtServer.Size = new global::System.Drawing.Size(189, 22);
			this.txtServer.TabIndex = 12;
			this.lblPassword.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblPassword.Appearance.Options.UseFont = true;
			this.lblPassword.Appearance.Options.UseTextOptions = true;
			this.lblPassword.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.lblPassword.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblPassword.Location = new global::System.Drawing.Point(49, 118);
			this.lblPassword.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new global::System.Drawing.Size(93, 16);
			this.lblPassword.TabIndex = 11;
			this.lblPassword.Text = "Password";
			this.lblUsername.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblUsername.Appearance.Options.UseFont = true;
			this.lblUsername.Appearance.Options.UseTextOptions = true;
			this.lblUsername.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.lblUsername.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblUsername.Location = new global::System.Drawing.Point(48, 88);
			this.lblUsername.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new global::System.Drawing.Size(94, 16);
			this.lblUsername.TabIndex = 10;
			this.lblUsername.Text = "Username";
			this.lblDatabase.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblDatabase.Appearance.Options.UseFont = true;
			this.lblDatabase.Appearance.Options.UseTextOptions = true;
			this.lblDatabase.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.lblDatabase.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblDatabase.Location = new global::System.Drawing.Point(49, 58);
			this.lblDatabase.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblDatabase.Name = "lblDatabase";
			this.lblDatabase.Size = new global::System.Drawing.Size(93, 16);
			this.lblDatabase.TabIndex = 9;
			this.lblDatabase.Text = "Database";
			this.lblServerName.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblServerName.Appearance.Options.UseFont = true;
			this.lblServerName.Appearance.Options.UseTextOptions = true;
			this.lblServerName.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.lblServerName.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblServerName.Location = new global::System.Drawing.Point(49, 28);
			this.lblServerName.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblServerName.Name = "lblServerName";
			this.lblServerName.Size = new global::System.Drawing.Size(93, 16);
			this.lblServerName.TabIndex = 8;
			this.lblServerName.Text = "Server Name";
			this.grpStandAlone.Controls.Add(this.grpService);
			this.grpStandAlone.Controls.Add(this.lblRunningMode);
			this.grpStandAlone.Controls.Add(this.lueRunningMode);
			this.grpStandAlone.Location = new global::System.Drawing.Point(1, 215);
			this.grpStandAlone.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.grpStandAlone.Name = "grpStandAlone";
			this.grpStandAlone.Size = new global::System.Drawing.Size(689, 69);
			this.grpStandAlone.TabIndex = 0;
			this.grpStandAlone.Text = "Cấu hình cơ sở dữ liệu";
			this.grpStandAlone.Visible = false;
			this.grpService.Controls.Add(this.txtServerIP);
			this.grpService.Controls.Add(this.lblEndpointAddress);
			this.grpService.Location = new global::System.Drawing.Point(63, 164);
			this.grpService.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.grpService.Name = "grpService";
			this.grpService.Size = new global::System.Drawing.Size(501, 62);
			this.grpService.TabIndex = 1;
			this.grpService.Text = "Service";
			this.grpService.Visible = false;
			this.txtServerIP.Location = new global::System.Drawing.Point(154, 30);
			this.txtServerIP.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtServerIP.Name = "txtServerIP";
			this.txtServerIP.Size = new global::System.Drawing.Size(315, 20);
			this.txtServerIP.TabIndex = 1;
			this.txtServerIP.Visible = false;
			this.lblEndpointAddress.Location = new global::System.Drawing.Point(81, 32);
			this.lblEndpointAddress.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblEndpointAddress.Name = "lblEndpointAddress";
			this.lblEndpointAddress.Size = new global::System.Drawing.Size(39, 13);
			this.lblEndpointAddress.TabIndex = 0;
			this.lblEndpointAddress.Text = "Address";
			this.lblEndpointAddress.Visible = false;
			this.lblRunningMode.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblRunningMode.Appearance.Options.UseFont = true;
			this.lblRunningMode.Appearance.Options.UseTextOptions = true;
			this.lblRunningMode.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.lblRunningMode.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblRunningMode.Location = new global::System.Drawing.Point(219, 233);
			this.lblRunningMode.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblRunningMode.Name = "lblRunningMode";
			this.lblRunningMode.Size = new global::System.Drawing.Size(107, 16);
			this.lblRunningMode.TabIndex = 3;
			this.lblRunningMode.Text = "Running Mode";
			this.lblRunningMode.Visible = false;
			this.lueRunningMode.Location = new global::System.Drawing.Point(333, 230);
			this.lueRunningMode.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lueRunningMode.Name = "lueRunningMode";
			this.lueRunningMode.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lueRunningMode.Properties.Appearance.Options.UseFont = true;
			this.lueRunningMode.Properties.Buttons.AddRange(new global::DevExpress.XtraEditors.Controls.EditorButton[]
			{
				new global::DevExpress.XtraEditors.Controls.EditorButton(global::DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
			});
			this.lueRunningMode.Properties.Columns.AddRange(new global::DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new global::DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, global::DevExpress.Utils.FormatType.None, "", false, global::DevExpress.Utils.HorzAlignment.Default, global::DevExpress.Data.ColumnSortOrder.None, global::DevExpress.Utils.DefaultBoolean.Default),
				new global::DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Running Mode")
			});
			this.lueRunningMode.Properties.DisplayMember = "Code";
			this.lueRunningMode.Properties.DropDownRows = 2;
			this.lueRunningMode.Properties.NullText = "";
			this.lueRunningMode.Properties.PopupWidth = 60;
			this.lueRunningMode.Properties.ShowFooter = false;
			this.lueRunningMode.Properties.ValueMember = "ID";
			this.lueRunningMode.Size = new global::System.Drawing.Size(189, 22);
			this.lueRunningMode.TabIndex = 2;
			this.lueRunningMode.Visible = false;
			this.tpgOptions.Controls.Add(this.xtraTabControl1);
			this.tpgOptions.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tpgOptions.Name = "tpgOptions";
			this.tpgOptions.Size = new global::System.Drawing.Size(689, 287);
			this.tpgOptions.Text = "Hệ Thống";
			this.xtraTabControl1.Location = new global::System.Drawing.Point(3, 2);
			this.xtraTabControl1.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.xtraTabControl1.Name = "xtraTabControl1";
			this.xtraTabControl1.SelectedTabPage = this.tpgRange;
			this.xtraTabControl1.Size = new global::System.Drawing.Size(683, 282);
			this.xtraTabControl1.TabIndex = 0;
			this.xtraTabControl1.TabPages.AddRange(new global::DevExpress.XtraTab.XtraTabPage[]
			{
				this.tpgRange,
				this.tpgFilter,
				this.tpgOthers,
				this.xtraTabPage1
			});
			this.tpgRange.Controls.Add(this.spnKLTronLonNhat);
			this.tpgRange.Controls.Add(this.spnKLTronNhoNhat);
			this.tpgRange.Controls.Add(this.spnKLChoLonNhat);
			this.tpgRange.Controls.Add(this.lblKLTronLonNhat);
			this.tpgRange.Controls.Add(this.lblKLTronNhoNhat);
			this.tpgRange.Controls.Add(this.lblKLChoLonNhat);
			this.tpgRange.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tpgRange.Name = "tpgRange";
			this.tpgRange.Size = new global::System.Drawing.Size(681, 257);
			this.tpgRange.Text = "Ràng Buộc";
			this.spnKLTronLonNhat.EditValue = new decimal(new int[4]);
			this.spnKLTronLonNhat.Location = new global::System.Drawing.Point(232, 90);
			this.spnKLTronLonNhat.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.spnKLTronLonNhat.Name = "spnKLTronLonNhat";
			this.spnKLTronLonNhat.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.spnKLTronLonNhat.Properties.Appearance.Options.UseFont = true;
			this.spnKLTronLonNhat.Properties.Buttons.AddRange(new global::DevExpress.XtraEditors.Controls.EditorButton[]
			{
				new global::DevExpress.XtraEditors.Controls.EditorButton(global::DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
			});
			this.spnKLTronLonNhat.Properties.DisplayFormat.FormatType = global::DevExpress.Utils.FormatType.Numeric;
			this.spnKLTronLonNhat.Properties.EditFormat.FormatString = "n1";
			this.spnKLTronLonNhat.Properties.EditFormat.FormatType = global::DevExpress.Utils.FormatType.Numeric;
			this.spnKLTronLonNhat.Properties.Mask.EditMask = "n1";
			this.spnKLTronLonNhat.Size = new global::System.Drawing.Size(107, 22);
			this.spnKLTronLonNhat.TabIndex = 5;
			this.spnKLTronNhoNhat.EditValue = new decimal(new int[4]);
			this.spnKLTronNhoNhat.Location = new global::System.Drawing.Point(232, 60);
			this.spnKLTronNhoNhat.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.spnKLTronNhoNhat.Name = "spnKLTronNhoNhat";
			this.spnKLTronNhoNhat.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.spnKLTronNhoNhat.Properties.Appearance.Options.UseFont = true;
			this.spnKLTronNhoNhat.Properties.Buttons.AddRange(new global::DevExpress.XtraEditors.Controls.EditorButton[]
			{
				new global::DevExpress.XtraEditors.Controls.EditorButton(global::DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
			});
			this.spnKLTronNhoNhat.Properties.DisplayFormat.FormatString = "n1";
			this.spnKLTronNhoNhat.Properties.DisplayFormat.FormatType = global::DevExpress.Utils.FormatType.Numeric;
			this.spnKLTronNhoNhat.Properties.EditFormat.FormatString = "n1";
			this.spnKLTronNhoNhat.Properties.EditFormat.FormatType = global::DevExpress.Utils.FormatType.Numeric;
			this.spnKLTronNhoNhat.Properties.Mask.EditMask = "n1";
			this.spnKLTronNhoNhat.Size = new global::System.Drawing.Size(107, 22);
			this.spnKLTronNhoNhat.TabIndex = 4;
			this.spnKLChoLonNhat.EditValue = new decimal(new int[4]);
			this.spnKLChoLonNhat.Location = new global::System.Drawing.Point(232, 30);
			this.spnKLChoLonNhat.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.spnKLChoLonNhat.Name = "spnKLChoLonNhat";
			this.spnKLChoLonNhat.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.spnKLChoLonNhat.Properties.Appearance.Options.UseFont = true;
			this.spnKLChoLonNhat.Properties.Buttons.AddRange(new global::DevExpress.XtraEditors.Controls.EditorButton[]
			{
				new global::DevExpress.XtraEditors.Controls.EditorButton(global::DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
			});
			this.spnKLChoLonNhat.Properties.DisplayFormat.FormatString = "n1";
			this.spnKLChoLonNhat.Properties.DisplayFormat.FormatType = global::DevExpress.Utils.FormatType.Numeric;
			this.spnKLChoLonNhat.Properties.EditFormat.FormatString = "n1";
			this.spnKLChoLonNhat.Properties.EditFormat.FormatType = global::DevExpress.Utils.FormatType.Numeric;
			this.spnKLChoLonNhat.Properties.Mask.EditMask = "n1";
			this.spnKLChoLonNhat.Size = new global::System.Drawing.Size(107, 22);
			this.spnKLChoLonNhat.TabIndex = 3;
			this.lblKLTronLonNhat.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblKLTronLonNhat.Appearance.Options.UseFont = true;
			this.lblKLTronLonNhat.Appearance.Options.UseTextOptions = true;
			this.lblKLTronLonNhat.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.lblKLTronLonNhat.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblKLTronLonNhat.Location = new global::System.Drawing.Point(41, 93);
			this.lblKLTronLonNhat.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblKLTronLonNhat.Name = "lblKLTronLonNhat";
			this.lblKLTronLonNhat.Size = new global::System.Drawing.Size(160, 16);
			this.lblKLTronLonNhat.TabIndex = 2;
			this.lblKLTronLonNhat.Text = "Số khối trộn lớn nhất";
			this.lblKLTronNhoNhat.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblKLTronNhoNhat.Appearance.Options.UseFont = true;
			this.lblKLTronNhoNhat.Appearance.Options.UseTextOptions = true;
			this.lblKLTronNhoNhat.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.lblKLTronNhoNhat.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblKLTronNhoNhat.Location = new global::System.Drawing.Point(41, 63);
			this.lblKLTronNhoNhat.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblKLTronNhoNhat.Name = "lblKLTronNhoNhat";
			this.lblKLTronNhoNhat.Size = new global::System.Drawing.Size(160, 16);
			this.lblKLTronNhoNhat.TabIndex = 1;
			this.lblKLTronNhoNhat.Text = "Số khối trộn nhỏ nhất";
			this.lblKLChoLonNhat.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblKLChoLonNhat.Appearance.Options.UseFont = true;
			this.lblKLChoLonNhat.Appearance.Options.UseTextOptions = true;
			this.lblKLChoLonNhat.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.lblKLChoLonNhat.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblKLChoLonNhat.Location = new global::System.Drawing.Point(41, 33);
			this.lblKLChoLonNhat.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblKLChoLonNhat.Name = "lblKLChoLonNhat";
			this.lblKLChoLonNhat.Size = new global::System.Drawing.Size(160, 16);
			this.lblKLChoLonNhat.TabIndex = 0;
			this.lblKLChoLonNhat.Text = "Số khối lớn nhất mà xe chở";
			this.tpgFilter.Controls.Add(this.spnLatestBaoCaoDays);
			this.tpgFilter.Controls.Add(this.labelControl5);
			this.tpgFilter.Controls.Add(this.labelControl6);
			this.tpgFilter.Controls.Add(this.spnLatestHopDongDays);
			this.tpgFilter.Controls.Add(this.spnLatestPhieuTronDays);
			this.tpgFilter.Controls.Add(this.lblLatestDay2);
			this.tpgFilter.Controls.Add(this.lblLatestDay);
			this.tpgFilter.Controls.Add(this.lblPhieuTron);
			this.tpgFilter.Controls.Add(this.lblContract);
			this.tpgFilter.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tpgFilter.Name = "tpgFilter";
			this.tpgFilter.Size = new global::System.Drawing.Size(681, 257);
			this.tpgFilter.Text = "Bộ Lọc";
			this.spnLatestBaoCaoDays.EditValue = new decimal(new int[4]);
			this.spnLatestBaoCaoDays.Location = new global::System.Drawing.Point(121, 90);
			this.spnLatestBaoCaoDays.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.spnLatestBaoCaoDays.Name = "spnLatestBaoCaoDays";
			this.spnLatestBaoCaoDays.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.spnLatestBaoCaoDays.Properties.Appearance.Options.UseFont = true;
			this.spnLatestBaoCaoDays.Properties.Buttons.AddRange(new global::DevExpress.XtraEditors.Controls.EditorButton[]
			{
				new global::DevExpress.XtraEditors.Controls.EditorButton(global::DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
			});
			this.spnLatestBaoCaoDays.Size = new global::System.Drawing.Size(107, 22);
			this.spnLatestBaoCaoDays.TabIndex = 8;
			this.labelControl5.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelControl5.Appearance.Options.UseFont = true;
			this.labelControl5.Appearance.Options.UseTextOptions = true;
			this.labelControl5.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Near;
			this.labelControl5.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl5.Location = new global::System.Drawing.Point(240, 90);
			this.labelControl5.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new global::System.Drawing.Size(154, 16);
			this.labelControl5.TabIndex = 7;
			this.labelControl5.Text = "ngày gần đây nhất";
			this.labelControl6.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelControl6.Appearance.Options.UseFont = true;
			this.labelControl6.Appearance.Options.UseTextOptions = true;
			this.labelControl6.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.labelControl6.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl6.Location = new global::System.Drawing.Point(26, 90);
			this.labelControl6.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new global::System.Drawing.Size(75, 16);
			this.labelControl6.TabIndex = 6;
			this.labelControl6.Text = "Báo cáo";
			this.spnLatestHopDongDays.EditValue = new decimal(new int[4]);
			this.spnLatestHopDongDays.Location = new global::System.Drawing.Point(121, 30);
			this.spnLatestHopDongDays.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.spnLatestHopDongDays.Name = "spnLatestHopDongDays";
			this.spnLatestHopDongDays.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.spnLatestHopDongDays.Properties.Appearance.Options.UseFont = true;
			this.spnLatestHopDongDays.Properties.Buttons.AddRange(new global::DevExpress.XtraEditors.Controls.EditorButton[]
			{
				new global::DevExpress.XtraEditors.Controls.EditorButton(global::DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
			});
			this.spnLatestHopDongDays.Size = new global::System.Drawing.Size(107, 22);
			this.spnLatestHopDongDays.TabIndex = 5;
			this.spnLatestPhieuTronDays.EditValue = new decimal(new int[4]);
			this.spnLatestPhieuTronDays.Location = new global::System.Drawing.Point(121, 60);
			this.spnLatestPhieuTronDays.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.spnLatestPhieuTronDays.Name = "spnLatestPhieuTronDays";
			this.spnLatestPhieuTronDays.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.spnLatestPhieuTronDays.Properties.Appearance.Options.UseFont = true;
			this.spnLatestPhieuTronDays.Properties.Buttons.AddRange(new global::DevExpress.XtraEditors.Controls.EditorButton[]
			{
				new global::DevExpress.XtraEditors.Controls.EditorButton(global::DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
			});
			this.spnLatestPhieuTronDays.Size = new global::System.Drawing.Size(107, 22);
			this.spnLatestPhieuTronDays.TabIndex = 4;
			this.lblLatestDay2.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblLatestDay2.Appearance.Options.UseFont = true;
			this.lblLatestDay2.Appearance.Options.UseTextOptions = true;
			this.lblLatestDay2.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Near;
			this.lblLatestDay2.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblLatestDay2.Location = new global::System.Drawing.Point(240, 63);
			this.lblLatestDay2.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblLatestDay2.Name = "lblLatestDay2";
			this.lblLatestDay2.Size = new global::System.Drawing.Size(154, 16);
			this.lblLatestDay2.TabIndex = 3;
			this.lblLatestDay2.Text = "ngày gần đây nhất";
			this.lblLatestDay.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblLatestDay.Appearance.Options.UseFont = true;
			this.lblLatestDay.Appearance.Options.UseTextOptions = true;
			this.lblLatestDay.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Near;
			this.lblLatestDay.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblLatestDay.Location = new global::System.Drawing.Point(240, 33);
			this.lblLatestDay.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblLatestDay.Name = "lblLatestDay";
			this.lblLatestDay.Size = new global::System.Drawing.Size(154, 16);
			this.lblLatestDay.TabIndex = 2;
			this.lblLatestDay.Text = "ngày gần đây nhất";
			this.lblPhieuTron.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblPhieuTron.Appearance.Options.UseFont = true;
			this.lblPhieuTron.Appearance.Options.UseTextOptions = true;
			this.lblPhieuTron.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.lblPhieuTron.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblPhieuTron.Location = new global::System.Drawing.Point(26, 63);
			this.lblPhieuTron.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblPhieuTron.Name = "lblPhieuTron";
			this.lblPhieuTron.Size = new global::System.Drawing.Size(75, 16);
			this.lblPhieuTron.TabIndex = 1;
			this.lblPhieuTron.Text = "Phiếu Trộn";
			this.lblContract.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblContract.Appearance.Options.UseFont = true;
			this.lblContract.Appearance.Options.UseTextOptions = true;
			this.lblContract.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.lblContract.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblContract.Location = new global::System.Drawing.Point(26, 33);
			this.lblContract.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblContract.Name = "lblContract";
			this.lblContract.Size = new global::System.Drawing.Size(75, 16);
			this.lblContract.TabIndex = 0;
			this.lblContract.Text = "Hợp Đồng";
			this.tpgOthers.Controls.Add(this.bteImportPath_CT);
			this.tpgOthers.Controls.Add(this.btePdfReaderPath);
			this.tpgOthers.Controls.Add(this.labelControl9);
			this.tpgOthers.Controls.Add(this.bteImportPath_GH);
			this.tpgOthers.Controls.Add(this.bteExportPath);
			this.tpgOthers.Controls.Add(this.chkDev);
			this.tpgOthers.Controls.Add(this.labelControl7);
			this.tpgOthers.Controls.Add(this.chkTronOnline);
			this.tpgOthers.Controls.Add(this.chkTinhBuTru);
			this.tpgOthers.Controls.Add(this.btnReportPathBrowse);
			this.tpgOthers.Controls.Add(this.btnTestReportPath);
			this.tpgOthers.Controls.Add(this.lblReportPath);
			this.tpgOthers.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tpgOthers.Name = "tpgOthers";
			this.tpgOthers.Size = new global::System.Drawing.Size(681, 257);
			this.tpgOthers.Text = "Khác";
			this.bteImportPath_CT.Location = new global::System.Drawing.Point(135, 100);
			this.bteImportPath_CT.Name = "bteImportPath_CT";
			this.bteImportPath_CT.Properties.Buttons.AddRange(new global::DevExpress.XtraEditors.Controls.EditorButton[]
			{
				new global::DevExpress.XtraEditors.Controls.EditorButton()
			});
			this.bteImportPath_CT.Size = new global::System.Drawing.Size(460, 20);
			this.bteImportPath_CT.TabIndex = 16;
			this.bteImportPath_CT.ButtonClick += new global::DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteImportPath_CT_ButtonClick);
			this.btePdfReaderPath.Location = new global::System.Drawing.Point(135, 135);
			this.btePdfReaderPath.Name = "btePdfReaderPath";
			this.btePdfReaderPath.Properties.Buttons.AddRange(new global::DevExpress.XtraEditors.Controls.EditorButton[]
			{
				new global::DevExpress.XtraEditors.Controls.EditorButton()
			});
			this.btePdfReaderPath.Size = new global::System.Drawing.Size(460, 20);
			this.btePdfReaderPath.TabIndex = 16;
			this.btePdfReaderPath.Click += new global::System.EventHandler(this.btePdfReaderPath_Click);
			this.labelControl9.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelControl9.Appearance.Options.UseFont = true;
			this.labelControl9.Appearance.Options.UseTextOptions = true;
			this.labelControl9.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.labelControl9.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl9.Location = new global::System.Drawing.Point(7, 94);
			this.labelControl9.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.labelControl9.Name = "labelControl9";
			this.labelControl9.Size = new global::System.Drawing.Size(117, 29);
			this.labelControl9.TabIndex = 15;
			this.labelControl9.Text = "Nhập File In Chi Tiết";
			this.bteImportPath_GH.Location = new global::System.Drawing.Point(135, 65);
			this.bteImportPath_GH.Name = "bteImportPath_GH";
			this.bteImportPath_GH.Properties.Buttons.AddRange(new global::DevExpress.XtraEditors.Controls.EditorButton[]
			{
				new global::DevExpress.XtraEditors.Controls.EditorButton()
			});
			this.bteImportPath_GH.Size = new global::System.Drawing.Size(460, 20);
			this.bteImportPath_GH.TabIndex = 14;
			this.bteImportPath_GH.ButtonClick += new global::DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteImportPath_ButtonClick);
			this.bteExportPath.Location = new global::System.Drawing.Point(135, 32);
			this.bteExportPath.Name = "bteExportPath";
			this.bteExportPath.Properties.Buttons.AddRange(new global::DevExpress.XtraEditors.Controls.EditorButton[]
			{
				new global::DevExpress.XtraEditors.Controls.EditorButton()
			});
			this.bteExportPath.Size = new global::System.Drawing.Size(460, 20);
			this.bteExportPath.TabIndex = 13;
			this.bteExportPath.ButtonClick += new global::DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteExportPath_ButtonClick);
			this.chkDev.Location = new global::System.Drawing.Point(42, 225);
			this.chkDev.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkDev.Name = "chkDev";
			this.chkDev.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.chkDev.Properties.Appearance.Options.UseFont = true;
			this.chkDev.Properties.Caption = "Dev";
			this.chkDev.Size = new global::System.Drawing.Size(278, 20);
			this.chkDev.TabIndex = 10;
			this.chkDev.Visible = false;
			this.labelControl7.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelControl7.Appearance.Options.UseFont = true;
			this.labelControl7.Appearance.Options.UseTextOptions = true;
			this.labelControl7.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.labelControl7.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl7.Location = new global::System.Drawing.Point(17, 59);
			this.labelControl7.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new global::System.Drawing.Size(107, 29);
			this.labelControl7.TabIndex = 6;
			this.labelControl7.Text = "Nhập File In Nhanh";
			this.chkTronOnline.Location = new global::System.Drawing.Point(42, 176);
			this.chkTronOnline.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkTronOnline.Name = "chkTronOnline";
			this.chkTronOnline.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.chkTronOnline.Properties.Appearance.Options.UseFont = true;
			this.chkTronOnline.Properties.Caption = "Hiển thị màn hình Vận Hành lúc khởi động";
			this.chkTronOnline.Size = new global::System.Drawing.Size(278, 20);
			this.chkTronOnline.TabIndex = 5;
			this.chkTinhBuTru.Location = new global::System.Drawing.Point(42, 201);
			this.chkTinhBuTru.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkTinhBuTru.Name = "chkTinhBuTru";
			this.chkTinhBuTru.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.chkTinhBuTru.Properties.Appearance.Options.UseFont = true;
			this.chkTinhBuTru.Properties.Caption = "Tính khối lượng bù trừ";
			this.chkTinhBuTru.Size = new global::System.Drawing.Size(278, 20);
			this.chkTinhBuTru.TabIndex = 4;
			this.chkTinhBuTru.Visible = false;
			this.btnReportPathBrowse.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnReportPathBrowse.Appearance.Options.UseFont = true;
			this.btnReportPathBrowse.Location = new global::System.Drawing.Point(465, 141);
			this.btnReportPathBrowse.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnReportPathBrowse.Name = "btnReportPathBrowse";
			this.btnReportPathBrowse.Size = new global::System.Drawing.Size(130, 30);
			this.btnReportPathBrowse.TabIndex = 3;
			this.btnReportPathBrowse.Text = "Tìm Đường Dẫn";
			this.btnReportPathBrowse.Visible = false;
			this.btnReportPathBrowse.Click += new global::System.EventHandler(this.btnReportPathBrowse_Click);
			this.btnTestReportPath.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnTestReportPath.Appearance.Options.UseFont = true;
			this.btnTestReportPath.Location = new global::System.Drawing.Point(465, 178);
			this.btnTestReportPath.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnTestReportPath.Name = "btnTestReportPath";
			this.btnTestReportPath.Size = new global::System.Drawing.Size(130, 30);
			this.btnTestReportPath.TabIndex = 2;
			this.btnTestReportPath.Text = "Lưu Đường Dẫn";
			this.btnTestReportPath.Visible = false;
			this.btnTestReportPath.Click += new global::System.EventHandler(this.btnTestReportPath_Click);
			this.lblReportPath.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblReportPath.Appearance.Options.UseFont = true;
			this.lblReportPath.Appearance.Options.UseTextOptions = true;
			this.lblReportPath.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.lblReportPath.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblReportPath.Location = new global::System.Drawing.Point(7, 26);
			this.lblReportPath.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblReportPath.Name = "lblReportPath";
			this.lblReportPath.Size = new global::System.Drawing.Size(117, 29);
			this.lblReportPath.TabIndex = 0;
			this.lblReportPath.Text = "Xuất File BC";
			this.xtraTabPage1.Controls.Add(this.labelControl8);
			this.xtraTabPage1.Controls.Add(this.beFilePathPLC);
			this.xtraTabPage1.Controls.Add(this.btnUploadToPLC);
			this.xtraTabPage1.Name = "xtraTabPage1";
			this.xtraTabPage1.PageVisible = false;
			this.xtraTabPage1.Size = new global::System.Drawing.Size(681, 257);
			this.xtraTabPage1.Text = "Upload Program PLC";
			this.labelControl8.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelControl8.Appearance.Options.UseFont = true;
			this.labelControl8.Appearance.Options.UseTextOptions = true;
			this.labelControl8.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.labelControl8.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl8.Location = new global::System.Drawing.Point(12, 26);
			this.labelControl8.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new global::System.Drawing.Size(117, 29);
			this.labelControl8.TabIndex = 592;
			this.labelControl8.Text = "Đường dẫn File nạp";
			this.beFilePathPLC.Location = new global::System.Drawing.Point(135, 30);
			this.beFilePathPLC.Name = "beFilePathPLC";
			this.beFilePathPLC.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.beFilePathPLC.Properties.Appearance.Options.UseFont = true;
			this.beFilePathPLC.Properties.Buttons.AddRange(new global::DevExpress.XtraEditors.Controls.EditorButton[]
			{
				new global::DevExpress.XtraEditors.Controls.EditorButton()
			});
			this.beFilePathPLC.Size = new global::System.Drawing.Size(304, 22);
			this.beFilePathPLC.TabIndex = 591;
			this.beFilePathPLC.ButtonClick += new global::DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beFilePath_ButtonClick);
			this.btnUploadToPLC.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnUploadToPLC.Appearance.Options.UseFont = true;
			this.btnUploadToPLC.Location = new global::System.Drawing.Point(457, 26);
			this.btnUploadToPLC.Name = "btnUploadToPLC";
			this.btnUploadToPLC.Size = new global::System.Drawing.Size(130, 30);
			this.btnUploadToPLC.TabIndex = 590;
			this.btnUploadToPLC.Text = "Upload";
			this.btnUploadToPLC.Click += new global::System.EventHandler(this.btnUploadToPLC_Click);
			this.tpgGeneral.Controls.Add(this.lueLanguages);
			this.tpgGeneral.Controls.Add(this.txtLANPort);
			this.tpgGeneral.Controls.Add(this.txtLANIP);
			this.tpgGeneral.Controls.Add(this.labelControl4);
			this.tpgGeneral.Controls.Add(this.lblIP);
			this.tpgGeneral.Controls.Add(this.txtPLCPort);
			this.tpgGeneral.Controls.Add(this.btnTestPort);
			this.tpgGeneral.Controls.Add(this.btnChangePLCPort);
			this.tpgGeneral.Controls.Add(this.labelControl1);
			this.tpgGeneral.Controls.Add(this.rdgLanguageRes);
			this.tpgGeneral.Controls.Add(this.lblLanguage);
			this.tpgGeneral.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tpgGeneral.Name = "tpgGeneral";
			this.tpgGeneral.Size = new global::System.Drawing.Size(689, 287);
			this.tpgGeneral.Text = "Cài Đặt Chung";
			this.lueLanguages.Location = new global::System.Drawing.Point(100, 60);
			this.lueLanguages.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lueLanguages.Name = "lueLanguages";
			this.lueLanguages.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lueLanguages.Properties.Appearance.Options.UseFont = true;
			this.lueLanguages.Properties.Buttons.AddRange(new global::DevExpress.XtraEditors.Controls.EditorButton[]
			{
				new global::DevExpress.XtraEditors.Controls.EditorButton(global::DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
			});
			this.lueLanguages.Properties.Columns.AddRange(new global::DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new global::DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, global::DevExpress.Utils.FormatType.None, "", false, global::DevExpress.Utils.HorzAlignment.Default, global::DevExpress.Data.ColumnSortOrder.None, global::DevExpress.Utils.DefaultBoolean.Default),
				new global::DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Languages")
			});
			this.lueLanguages.Properties.DisplayMember = "Code";
			this.lueLanguages.Properties.NullText = "";
			this.lueLanguages.Properties.ShowFooter = false;
			this.lueLanguages.Properties.ShowHeader = false;
			this.lueLanguages.Properties.ValueMember = "ID";
			this.lueLanguages.Size = new global::System.Drawing.Size(150, 22);
			this.lueLanguages.TabIndex = 12;
			this.txtLANPort.Location = new global::System.Drawing.Point(77, 242);
			this.txtLANPort.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtLANPort.Name = "txtLANPort";
			this.txtLANPort.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtLANPort.Properties.Appearance.Options.UseFont = true;
			this.txtLANPort.Size = new global::System.Drawing.Size(142, 22);
			this.txtLANPort.TabIndex = 11;
			this.txtLANPort.Visible = false;
			this.txtLANIP.Location = new global::System.Drawing.Point(100, 30);
			this.txtLANIP.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtLANIP.Name = "txtLANIP";
			this.txtLANIP.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtLANIP.Properties.Appearance.Options.UseFont = true;
			this.txtLANIP.Size = new global::System.Drawing.Size(150, 22);
			this.txtLANIP.TabIndex = 10;
			this.labelControl4.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Location = new global::System.Drawing.Point(19, 183);
			this.labelControl4.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new global::System.Drawing.Size(60, 16);
			this.labelControl4.TabIndex = 9;
			this.labelControl4.Text = "Serial Port";
			this.labelControl4.Visible = false;
			this.lblIP.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblIP.Appearance.Options.UseFont = true;
			this.lblIP.Location = new global::System.Drawing.Point(43, 33);
			this.lblIP.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblIP.Name = "lblIP";
			this.lblIP.Size = new global::System.Drawing.Size(36, 16);
			this.lblIP.TabIndex = 8;
			this.lblIP.Text = "IP PLC";
			this.txtPLCPort.Location = new global::System.Drawing.Point(53, 206);
			this.txtPLCPort.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPLCPort.Name = "txtPLCPort";
			this.txtPLCPort.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtPLCPort.Properties.Appearance.Options.UseFont = true;
			this.txtPLCPort.Size = new global::System.Drawing.Size(195, 22);
			this.txtPLCPort.TabIndex = 7;
			this.txtPLCPort.Visible = false;
			this.btnTestPort.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnTestPort.Appearance.Options.UseFont = true;
			this.btnTestPort.Location = new global::System.Drawing.Point(380, 203);
			this.btnTestPort.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnTestPort.Name = "btnTestPort";
			this.btnTestPort.Size = new global::System.Drawing.Size(81, 24);
			this.btnTestPort.TabIndex = 6;
			this.btnTestPort.Text = "Test Port";
			this.btnTestPort.Visible = false;
			this.btnTestPort.Click += new global::System.EventHandler(this.btnTestPort_Click);
			this.btnChangePLCPort.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnChangePLCPort.Appearance.Options.UseFont = true;
			this.btnChangePLCPort.Location = new global::System.Drawing.Point(288, 203);
			this.btnChangePLCPort.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnChangePLCPort.Name = "btnChangePLCPort";
			this.btnChangePLCPort.Size = new global::System.Drawing.Size(81, 24);
			this.btnChangePLCPort.TabIndex = 5;
			this.btnChangePLCPort.Text = "Change";
			this.btnChangePLCPort.Visible = false;
			this.btnChangePLCPort.Click += new global::System.EventHandler(this.btnChangePLCPort_Click);
			this.labelControl1.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new global::System.Drawing.Point(33, 244);
			this.labelControl1.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new global::System.Drawing.Size(23, 16);
			this.labelControl1.TabIndex = 2;
			this.labelControl1.Text = "Port";
			this.labelControl1.Visible = false;
			this.rdgLanguageRes.Location = new global::System.Drawing.Point(364, 32);
			this.rdgLanguageRes.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdgLanguageRes.Name = "rdgLanguageRes";
			this.rdgLanguageRes.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rdgLanguageRes.Properties.Appearance.Options.UseFont = true;
			this.rdgLanguageRes.Properties.BorderStyle = global::DevExpress.XtraEditors.Controls.BorderStyles.Flat;
			this.rdgLanguageRes.Size = new global::System.Drawing.Size(195, 52);
			this.rdgLanguageRes.TabIndex = 1;
			this.rdgLanguageRes.Visible = false;
			this.rdgLanguageRes.EditValueChanging += new global::DevExpress.XtraEditors.Controls.ChangingEventHandler(this.rdgLanguageRes_EditValueChanging);
			this.lblLanguage.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblLanguage.Appearance.Options.UseFont = true;
			this.lblLanguage.Location = new global::System.Drawing.Point(23, 63);
			this.lblLanguage.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblLanguage.Name = "lblLanguage";
			this.lblLanguage.Size = new global::System.Drawing.Size(56, 16);
			this.lblLanguage.TabIndex = 0;
			this.lblLanguage.Text = "Ngôn Ngữ";
			this.simpleButton2.Location = new global::System.Drawing.Point(208, 5);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new global::System.Drawing.Size(94, 30);
			this.simpleButton2.TabIndex = 2;
			this.simpleButton2.Text = "Lưu";
			this.simpleButton2.Click += new global::System.EventHandler(this.btnOk_Click);
			this.simpleButton3.Location = new global::System.Drawing.Point(327, 5);
			this.simpleButton3.Name = "simpleButton3";
			this.simpleButton3.Size = new global::System.Drawing.Size(94, 30);
			this.simpleButton3.TabIndex = 3;
			this.simpleButton3.Text = "Đóng";
			this.simpleButton3.Click += new global::System.EventHandler(this.btnCancel_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(691, 352);
			base.Controls.Add(this.tabConfig);
			base.Controls.Add(this.panelControl1);
			base.IconOptions.Image = global::NhuaNong.ResourceNhua.logoV_64;
			base.Name = "FrmConfig";
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "FrmConfig";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.FrmConfig_FormClosing);
			base.Load += new global::System.EventHandler(this.FrmConfig_Load);
			((global::System.ComponentModel.ISupportInitialize)this.panelControl1).EndInit();
			this.panelControl1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.tabConfig).EndInit();
			this.tabConfig.ResumeLayout(false);
			this.tpgCompanyInfo.ResumeLayout(false);
			this.tpgCompanyInfo.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.bteLogoPath.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureEdit1.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtDienThoaiCty.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtDiaChiCty.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtTenCty.Properties).EndInit();
			this.tpgRunningMode.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.txtPassword.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtUsername.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtDatabase.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtServer.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.grpStandAlone).EndInit();
			this.grpStandAlone.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.grpService).EndInit();
			this.grpService.ResumeLayout(false);
			this.grpService.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.txtServerIP.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lueRunningMode.Properties).EndInit();
			this.tpgOptions.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.xtraTabControl1).EndInit();
			this.xtraTabControl1.ResumeLayout(false);
			this.tpgRange.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.spnKLTronLonNhat.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.spnKLTronNhoNhat.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.spnKLChoLonNhat.Properties).EndInit();
			this.tpgFilter.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.spnLatestBaoCaoDays.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.spnLatestHopDongDays.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.spnLatestPhieuTronDays.Properties).EndInit();
			this.tpgOthers.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.bteImportPath_CT.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.btePdfReaderPath.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bteImportPath_GH.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bteExportPath.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkDev.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkTronOnline.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkTinhBuTru.Properties).EndInit();
			this.xtraTabPage1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.beFilePathPLC.Properties).EndInit();
			this.tpgGeneral.ResumeLayout(false);
			this.tpgGeneral.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lueLanguages.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtLANPort.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtLANIP.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtPLCPort.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.rdgLanguageRes.Properties).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000047 RID: 71
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000048 RID: 72
		private global::DevExpress.XtraEditors.PanelControl panelControl1;

		// Token: 0x04000049 RID: 73
		private global::DevExpress.XtraEditors.SimpleButton btnCancel;

		// Token: 0x0400004A RID: 74
		private global::DevExpress.XtraEditors.SimpleButton btnOk;

		// Token: 0x0400004B RID: 75
		private global::DevExpress.XtraTab.XtraTabControl tabConfig;

		// Token: 0x0400004C RID: 76
		private global::DevExpress.XtraTab.XtraTabPage tpgCompanyInfo;

		// Token: 0x0400004D RID: 77
		private global::DevExpress.XtraTab.XtraTabPage tpgRunningMode;

		// Token: 0x0400004E RID: 78
		private global::DevExpress.XtraEditors.GroupControl grpStandAlone;

		// Token: 0x0400004F RID: 79
		private global::DevExpress.XtraTab.XtraTabPage tpgOptions;

		// Token: 0x04000050 RID: 80
		private global::DevExpress.XtraTab.XtraTabPage tpgGeneral;

		// Token: 0x04000051 RID: 81
		private global::DevExpress.XtraEditors.LookUpEdit lueRunningMode;

		// Token: 0x04000052 RID: 82
		private global::DevExpress.XtraEditors.GroupControl grpService;

		// Token: 0x04000053 RID: 83
		private global::DevExpress.XtraEditors.TextEdit txtServerIP;

		// Token: 0x04000054 RID: 84
		private global::DevExpress.XtraEditors.LabelControl lblEndpointAddress;

		// Token: 0x04000055 RID: 85
		private global::DevExpress.XtraEditors.LabelControl lblRunningMode;

		// Token: 0x04000056 RID: 86
		private global::DevExpress.XtraEditors.LabelControl lblAddress;

		// Token: 0x04000057 RID: 87
		private global::DevExpress.XtraEditors.LabelControl lblCompanyName;

		// Token: 0x04000058 RID: 88
		private global::DevExpress.XtraEditors.TextEdit txtDienThoaiCty;

		// Token: 0x04000059 RID: 89
		private global::DevExpress.XtraEditors.TextEdit txtDiaChiCty;

		// Token: 0x0400005A RID: 90
		private global::DevExpress.XtraEditors.TextEdit txtTenCty;

		// Token: 0x0400005B RID: 91
		private global::DevExpress.XtraEditors.LabelControl lblPhone;

		// Token: 0x0400005C RID: 92
		private global::DevExpress.XtraTab.XtraTabControl xtraTabControl1;

		// Token: 0x0400005D RID: 93
		private global::DevExpress.XtraTab.XtraTabPage tpgRange;

		// Token: 0x0400005E RID: 94
		private global::DevExpress.XtraTab.XtraTabPage tpgFilter;

		// Token: 0x0400005F RID: 95
		private global::DevExpress.XtraTab.XtraTabPage tpgOthers;

		// Token: 0x04000060 RID: 96
		private global::DevExpress.XtraEditors.CheckEdit chkTinhBuTru;

		// Token: 0x04000061 RID: 97
		private global::DevExpress.XtraEditors.SimpleButton btnReportPathBrowse;

		// Token: 0x04000062 RID: 98
		private global::DevExpress.XtraEditors.SimpleButton btnTestReportPath;

		// Token: 0x04000063 RID: 99
		private global::DevExpress.XtraEditors.LabelControl lblReportPath;

		// Token: 0x04000064 RID: 100
		private global::DevExpress.XtraEditors.CheckEdit chkTronOnline;

		// Token: 0x04000065 RID: 101
		private global::DevExpress.XtraEditors.SpinEdit spnLatestHopDongDays;

		// Token: 0x04000066 RID: 102
		private global::DevExpress.XtraEditors.SpinEdit spnLatestPhieuTronDays;

		// Token: 0x04000067 RID: 103
		private global::DevExpress.XtraEditors.LabelControl lblLatestDay2;

		// Token: 0x04000068 RID: 104
		private global::DevExpress.XtraEditors.LabelControl lblLatestDay;

		// Token: 0x04000069 RID: 105
		private global::DevExpress.XtraEditors.LabelControl lblPhieuTron;

		// Token: 0x0400006A RID: 106
		private global::DevExpress.XtraEditors.LabelControl lblContract;

		// Token: 0x0400006B RID: 107
		private global::DevExpress.XtraEditors.LabelControl lblKLTronLonNhat;

		// Token: 0x0400006C RID: 108
		private global::DevExpress.XtraEditors.LabelControl lblKLTronNhoNhat;

		// Token: 0x0400006D RID: 109
		private global::DevExpress.XtraEditors.LabelControl lblKLChoLonNhat;

		// Token: 0x0400006E RID: 110
		private global::DevExpress.XtraEditors.SpinEdit spnKLTronLonNhat;

		// Token: 0x0400006F RID: 111
		private global::DevExpress.XtraEditors.SpinEdit spnKLTronNhoNhat;

		// Token: 0x04000070 RID: 112
		private global::DevExpress.XtraEditors.SpinEdit spnKLChoLonNhat;

		// Token: 0x04000071 RID: 113
		private global::DevExpress.XtraEditors.RadioGroup rdgLanguageRes;

		// Token: 0x04000072 RID: 114
		private global::DevExpress.XtraEditors.LabelControl lblLanguage;

		// Token: 0x04000073 RID: 115
		private global::DevExpress.XtraEditors.TextEdit txtLANPort;

		// Token: 0x04000074 RID: 116
		private global::DevExpress.XtraEditors.TextEdit txtLANIP;

		// Token: 0x04000075 RID: 117
		private global::DevExpress.XtraEditors.LabelControl labelControl4;

		// Token: 0x04000076 RID: 118
		private global::DevExpress.XtraEditors.LabelControl lblIP;

		// Token: 0x04000077 RID: 119
		private global::DevExpress.XtraEditors.TextEdit txtPLCPort;

		// Token: 0x04000078 RID: 120
		private global::DevExpress.XtraEditors.SimpleButton btnTestPort;

		// Token: 0x04000079 RID: 121
		private global::DevExpress.XtraEditors.SimpleButton btnChangePLCPort;

		// Token: 0x0400007A RID: 122
		private global::DevExpress.XtraEditors.LabelControl labelControl1;

		// Token: 0x0400007B RID: 123
		private global::DevExpress.XtraEditors.LookUpEdit lueLanguages;

		// Token: 0x0400007C RID: 124
		private global::DevExpress.XtraEditors.LabelControl labelControl2;

		// Token: 0x0400007D RID: 125
		private global::DevExpress.XtraEditors.SimpleButton btnLoadImage;

		// Token: 0x0400007E RID: 126
		private global::DevExpress.XtraEditors.PictureEdit pictureEdit1;

		// Token: 0x0400007F RID: 127
		private global::DevExpress.XtraEditors.LabelControl labelControl3;

		// Token: 0x04000080 RID: 128
		private global::DevExpress.XtraEditors.SimpleButton simpleButton1;

		// Token: 0x04000081 RID: 129
		private global::DevExpress.XtraEditors.ButtonEdit bteLogoPath;

		// Token: 0x04000082 RID: 130
		private global::DevExpress.XtraEditors.TextEdit txtPassword;

		// Token: 0x04000083 RID: 131
		private global::DevExpress.XtraEditors.TextEdit txtUsername;

		// Token: 0x04000084 RID: 132
		private global::DevExpress.XtraEditors.TextEdit txtDatabase;

		// Token: 0x04000085 RID: 133
		private global::DevExpress.XtraEditors.TextEdit txtServer;

		// Token: 0x04000086 RID: 134
		private global::DevExpress.XtraEditors.LabelControl lblPassword;

		// Token: 0x04000087 RID: 135
		private global::DevExpress.XtraEditors.LabelControl lblUsername;

		// Token: 0x04000088 RID: 136
		private global::DevExpress.XtraEditors.LabelControl lblDatabase;

		// Token: 0x04000089 RID: 137
		private global::DevExpress.XtraEditors.LabelControl lblServerName;

		// Token: 0x0400008A RID: 138
		private global::DevExpress.XtraEditors.SpinEdit spnLatestBaoCaoDays;

		// Token: 0x0400008B RID: 139
		private global::DevExpress.XtraEditors.LabelControl labelControl5;

		// Token: 0x0400008C RID: 140
		private global::DevExpress.XtraEditors.LabelControl labelControl6;

		// Token: 0x0400008D RID: 141
		private global::DevExpress.XtraEditors.LabelControl labelControl7;

		// Token: 0x0400008E RID: 142
		private global::DevExpress.XtraEditors.CheckEdit chkDev;

		// Token: 0x0400008F RID: 143
		private global::DevExpress.XtraTab.XtraTabPage xtraTabPage1;

		// Token: 0x04000090 RID: 144
		private global::DevExpress.XtraEditors.LabelControl labelControl8;

		// Token: 0x04000091 RID: 145
		private global::DevExpress.XtraEditors.ButtonEdit beFilePathPLC;

		// Token: 0x04000092 RID: 146
		private global::DevExpress.XtraEditors.SimpleButton btnUploadToPLC;

		// Token: 0x04000093 RID: 147
		private global::DevExpress.XtraEditors.ButtonEdit bteImportPath_GH;

		// Token: 0x04000094 RID: 148
		private global::DevExpress.XtraEditors.ButtonEdit bteExportPath;

		// Token: 0x04000095 RID: 149
		private global::DevExpress.XtraEditors.ButtonEdit bteImportPath_CT;

		// Token: 0x04000096 RID: 150
		private global::DevExpress.XtraEditors.ButtonEdit btePdfReaderPath;

		// Token: 0x04000097 RID: 151
		private global::DevExpress.XtraEditors.LabelControl labelControl9;

		// Token: 0x04000098 RID: 152
		private global::DevExpress.XtraEditors.SimpleButton simpleButton2;

		// Token: 0x04000099 RID: 153
		private global::DevExpress.XtraEditors.SimpleButton simpleButton3;
	}
}
