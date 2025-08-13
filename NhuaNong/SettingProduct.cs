// Decompiled with JetBrains decompiler
// Type: NhuaNong.SettingProduct
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using NhuaNong.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong
{
  public class SettingProduct : DialogViewBase
  {
    private IContainer components;
    private PanelControl panelControl1;
    private PanelControl panelControl2;
    private SimpleButton btnCancel;
    private SimpleButton btnOk;
    private ButtonEdit bteIconLogoPathProducer;
    private LabelControl labelControl3;
    private LabelControl labelControl2;
    private PictureEdit pictureEdit1;
    private TextEdit txtPhoneProduct;
    private TextEdit txtLocalProduct;
    private TextEdit txtNameProduct;
    private LabelControl lblPhone;
    private LabelControl lblAddress;
    private LabelControl lblCompanyName;
    private LabelControl lblTime;
    private Button button2;
    private Button button1;
    private TextEdit txtGmailProduct;
    private LabelControl lblGmail;
    private LabelControl lblCheck;

    public SettingProduct() => this.InitializeComponent();

    protected override void PopulateData()
    {
      try
      {
        this.txtNameProduct.Text = ConfigManager.TramTronConfig.NameProduct;
        this.txtLocalProduct.Text = ConfigManager.TramTronConfig.LocalProduct;
        this.txtPhoneProduct.Text = ConfigManager.TramTronConfig.PhoneProduct;
        this.txtGmailProduct.Text = ConfigManager.TramTronConfig.GmailProduct;
        this.lblTime.Text = ConfigManager.TramTronConfig.TimeLife.ToString("dd/MM/yyyy hh:mm tt");
        this.lblTime.Visible = false;
        this.lblCheck.Visible = ConfigManager.TramTronConfig.NgayTron_Stus;
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
        TramTronLogger.WriteError(ex);
      }
    }

    private void bteIconLogoPathProducer_EditValueChanged(object sender, EventArgs e)
    {
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      try
      {
        ConfigManager.TramTronConfig.NameProduct = this.txtNameProduct.Text;
        ConfigManager.TramTronConfig.LocalProduct = this.txtLocalProduct.Text;
        ConfigManager.TramTronConfig.PhoneProduct = this.txtPhoneProduct.Text;
        ConfigManager.TramTronConfig.GmailProduct = this.txtGmailProduct.Text;
        this.Close();
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

    private void btnCancel_Click(object sender, EventArgs e) => this.Close();

    private void bteIconLogoPathProducer_ButtonClick(object sender, ButtonPressedEventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
      openFileDialog.Title = "Chọn hình ảnh";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      try
      {
        this.bteIconLogoPathProducer.Text = openFileDialog.FileName;
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show("Lỗi: " + ex.Message);
      }
    }

    private void SettingProduct_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.Control && e.KeyCode == Keys.T)
        this.lblTime.Visible = true;
      if (!e.Control || e.KeyCode != Keys.D)
        return;
      ConfigManager.TramTronConfig.NgayTron_Stus = !ConfigManager.TramTronConfig.NgayTron_Stus;
      this.lblCheck.Visible = ConfigManager.TramTronConfig.NgayTron_Stus;
    }

    private void SettingProduct_Load(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.panelControl1 = new PanelControl();
      this.txtGmailProduct = new TextEdit();
      this.lblGmail = new LabelControl();
      this.bteIconLogoPathProducer = new ButtonEdit();
      this.labelControl3 = new LabelControl();
      this.labelControl2 = new LabelControl();
      this.pictureEdit1 = new PictureEdit();
      this.txtPhoneProduct = new TextEdit();
      this.txtLocalProduct = new TextEdit();
      this.txtNameProduct = new TextEdit();
      this.lblPhone = new LabelControl();
      this.lblAddress = new LabelControl();
      this.lblCompanyName = new LabelControl();
      this.panelControl2 = new PanelControl();
      this.button2 = new Button();
      this.button1 = new Button();
      this.lblTime = new LabelControl();
      this.btnCancel = new SimpleButton();
      this.btnOk = new SimpleButton();
      this.lblCheck = new LabelControl();
      this.panelControl1.BeginInit();
      this.panelControl1.SuspendLayout();
      this.txtGmailProduct.Properties.BeginInit();
      this.bteIconLogoPathProducer.Properties.BeginInit();
      this.pictureEdit1.Properties.BeginInit();
      this.txtPhoneProduct.Properties.BeginInit();
      this.txtLocalProduct.Properties.BeginInit();
      this.txtNameProduct.Properties.BeginInit();
      this.panelControl2.BeginInit();
      this.panelControl2.SuspendLayout();
      this.SuspendLayout();
      this.panelControl1.Controls.Add((Control) this.txtGmailProduct);
      this.panelControl1.Controls.Add((Control) this.lblGmail);
      this.panelControl1.Controls.Add((Control) this.bteIconLogoPathProducer);
      this.panelControl1.Controls.Add((Control) this.labelControl3);
      this.panelControl1.Controls.Add((Control) this.labelControl2);
      this.panelControl1.Controls.Add((Control) this.pictureEdit1);
      this.panelControl1.Controls.Add((Control) this.txtPhoneProduct);
      this.panelControl1.Controls.Add((Control) this.txtLocalProduct);
      this.panelControl1.Controls.Add((Control) this.txtNameProduct);
      this.panelControl1.Controls.Add((Control) this.lblPhone);
      this.panelControl1.Controls.Add((Control) this.lblAddress);
      this.panelControl1.Controls.Add((Control) this.lblCompanyName);
      this.panelControl1.Dock = DockStyle.Fill;
      this.panelControl1.Location = new Point(0, 0);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new Size(621, 226);
      this.panelControl1.TabIndex = 0;
      this.txtGmailProduct.Location = new Point(149, 125);
      this.txtGmailProduct.Margin = new Padding(3, 2, 3, 2);
      this.txtGmailProduct.Name = "txtGmailProduct";
      this.txtGmailProduct.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtGmailProduct.Properties.Appearance.Options.UseFont = true;
      this.txtGmailProduct.Size = new Size(304, 22);
      this.txtGmailProduct.TabIndex = 26;
      this.lblGmail.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblGmail.Appearance.Options.UseFont = true;
      this.lblGmail.Appearance.Options.UseTextOptions = true;
      this.lblGmail.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.lblGmail.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblGmail.Location = new Point(31, 128);
      this.lblGmail.Margin = new Padding(3, 2, 3, 2);
      this.lblGmail.Name = "lblGmail";
      this.lblGmail.Size = new Size(96, 16);
      this.lblGmail.TabIndex = 25;
      this.lblGmail.Text = "Gmail";
      this.bteIconLogoPathProducer.Location = new Point(149, 153);
      this.bteIconLogoPathProducer.Name = "bteIconLogoPathProducer";
      this.bteIconLogoPathProducer.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton()
      });
      this.bteIconLogoPathProducer.Size = new Size(304, 20);
      this.bteIconLogoPathProducer.TabIndex = 24;
      this.bteIconLogoPathProducer.Visible = false;
      this.bteIconLogoPathProducer.ButtonClick += new ButtonPressedEventHandler(this.bteIconLogoPathProducer_ButtonClick);
      this.bteIconLogoPathProducer.EditValueChanged += new EventHandler(this.bteIconLogoPathProducer_EditValueChanged);
      this.labelControl3.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Appearance.Options.UseTextOptions = true;
      this.labelControl3.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.labelControl3.AutoSizeMode = LabelAutoSizeMode.None;
      this.labelControl3.Location = new Point(31, 154);
      this.labelControl3.Margin = new Padding(3, 2, 3, 2);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new Size(96, 16);
      this.labelControl3.TabIndex = 23;
      this.labelControl3.Text = "Icon Logo Path";
      this.labelControl3.Visible = false;
      this.labelControl2.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new Point(473, 144);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(110, 16);
      this.labelControl2.TabIndex = 21;
      this.labelControl2.Text = "Icon Logo Producer";
      this.labelControl2.Visible = false;
      this.pictureEdit1.Location = new Point(480, 38);
      this.pictureEdit1.Name = "pictureEdit1";
      this.pictureEdit1.Properties.NullText = " ";
      this.pictureEdit1.Properties.ShowCameraMenuItem = CameraMenuItemVisibility.Auto;
      this.pictureEdit1.Size = new Size(100, 100);
      this.pictureEdit1.TabIndex = 19;
      this.pictureEdit1.Visible = false;
      this.txtPhoneProduct.Location = new Point(149, 95);
      this.txtPhoneProduct.Margin = new Padding(3, 2, 3, 2);
      this.txtPhoneProduct.Name = "txtPhoneProduct";
      this.txtPhoneProduct.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtPhoneProduct.Properties.Appearance.Options.UseFont = true;
      this.txtPhoneProduct.Size = new Size(304, 22);
      this.txtPhoneProduct.TabIndex = 18;
      this.txtLocalProduct.Location = new Point(149, 65);
      this.txtLocalProduct.Margin = new Padding(3, 2, 3, 2);
      this.txtLocalProduct.Name = "txtLocalProduct";
      this.txtLocalProduct.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtLocalProduct.Properties.Appearance.Options.UseFont = true;
      this.txtLocalProduct.Size = new Size(304, 22);
      this.txtLocalProduct.TabIndex = 17;
      this.txtNameProduct.Location = new Point(149, 35);
      this.txtNameProduct.Margin = new Padding(3, 2, 3, 2);
      this.txtNameProduct.Name = "txtNameProduct";
      this.txtNameProduct.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtNameProduct.Properties.Appearance.Options.UseFont = true;
      this.txtNameProduct.Size = new Size(304, 22);
      this.txtNameProduct.TabIndex = 16;
      this.lblPhone.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblPhone.Appearance.Options.UseFont = true;
      this.lblPhone.Appearance.Options.UseTextOptions = true;
      this.lblPhone.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.lblPhone.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblPhone.Location = new Point(31, 98);
      this.lblPhone.Margin = new Padding(3, 2, 3, 2);
      this.lblPhone.Name = "lblPhone";
      this.lblPhone.Size = new Size(96, 16);
      this.lblPhone.TabIndex = 15;
      this.lblPhone.Text = "Phone";
      this.lblAddress.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblAddress.Appearance.Options.UseFont = true;
      this.lblAddress.Appearance.Options.UseTextOptions = true;
      this.lblAddress.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.lblAddress.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblAddress.Location = new Point(31, 68);
      this.lblAddress.Margin = new Padding(3, 2, 3, 2);
      this.lblAddress.Name = "lblAddress";
      this.lblAddress.Size = new Size(96, 16);
      this.lblAddress.TabIndex = 14;
      this.lblAddress.Text = "Dec";
      this.lblCompanyName.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblCompanyName.Appearance.Options.UseFont = true;
      this.lblCompanyName.Appearance.Options.UseTextOptions = true;
      this.lblCompanyName.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.lblCompanyName.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblCompanyName.Location = new Point(31, 38);
      this.lblCompanyName.Margin = new Padding(3, 2, 3, 2);
      this.lblCompanyName.Name = "lblCompanyName";
      this.lblCompanyName.Size = new Size(96, 16);
      this.lblCompanyName.TabIndex = 13;
      this.lblCompanyName.Text = "Producer Name";
      this.panelControl2.Controls.Add((Control) this.lblCheck);
      this.panelControl2.Controls.Add((Control) this.button2);
      this.panelControl2.Controls.Add((Control) this.button1);
      this.panelControl2.Controls.Add((Control) this.lblTime);
      this.panelControl2.Controls.Add((Control) this.btnCancel);
      this.panelControl2.Controls.Add((Control) this.btnOk);
      this.panelControl2.Dock = DockStyle.Bottom;
      this.panelControl2.Location = new Point(0, 181);
      this.panelControl2.Name = "panelControl2";
      this.panelControl2.Size = new Size(621, 45);
      this.panelControl2.TabIndex = 1;
      this.button2.Location = new Point(297, 7);
      this.button2.Name = "button2";
      this.button2.Size = new Size(119, 31);
      this.button2.TabIndex = 8;
      this.button2.Text = "Thoát";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.btnCancel_Click);
      this.button1.Location = new Point(172, 7);
      this.button1.Name = "button1";
      this.button1.Size = new Size(119, 31);
      this.button1.TabIndex = 7;
      this.button1.Text = "Lưu";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.btnOk_Click);
      this.lblTime.Location = new Point(5, 27);
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new Size(63, 13);
      this.lblTime.TabIndex = 6;
      this.lblTime.Text = "labelControl1";
      this.btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnCancel.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnCancel.Appearance.Options.UseFont = true;
      this.btnCancel.Location = new Point(747, 7);
      this.btnCancel.Margin = new Padding(3, 2, 3, 2);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(98, 30);
      this.btnCancel.TabIndex = 5;
      this.btnCancel.Text = "Huỷ Bỏ";
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.btnOk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnOk.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnOk.Appearance.Options.UseFont = true;
      this.btnOk.Location = new Point(633, 7);
      this.btnOk.Margin = new Padding(3, 2, 3, 2);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new Size(98, 30);
      this.btnOk.TabIndex = 4;
      this.btnOk.Text = "Lưu";
      this.btnOk.Click += new EventHandler(this.btnOk_Click);
      this.lblCheck.Location = new Point(612, 27);
      this.lblCheck.Name = "lblCheck";
      this.lblCheck.Size = new Size(4, 13);
      this.lblCheck.TabIndex = 9;
      this.lblCheck.Text = ".";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(621, 226);
      this.Controls.Add((Control) this.panelControl2);
      this.Controls.Add((Control) this.panelControl1);
      this.IconOptions.Image = (Image) ResourceNhua.logoV_64;
      this.KeyPreview = true;
      this.Name = nameof (SettingProduct);
      this.Text = nameof (SettingProduct);
      this.Load += new EventHandler(this.SettingProduct_Load);
      this.KeyDown += new KeyEventHandler(this.SettingProduct_KeyDown);
      this.panelControl1.EndInit();
      this.panelControl1.ResumeLayout(false);
      this.panelControl1.PerformLayout();
      this.txtGmailProduct.Properties.EndInit();
      this.bteIconLogoPathProducer.Properties.EndInit();
      this.pictureEdit1.Properties.EndInit();
      this.txtPhoneProduct.Properties.EndInit();
      this.txtLocalProduct.Properties.EndInit();
      this.txtNameProduct.Properties.EndInit();
      this.panelControl2.EndInit();
      this.panelControl2.ResumeLayout(false);
      this.panelControl2.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
