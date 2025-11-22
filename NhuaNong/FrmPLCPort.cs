// Decompiled with JetBrains decompiler
// Type: NhuaNong.FrmPLCPort
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong
{
  public partial class FrmPLCPort : DialogViewBase
  {
    //Xóa các khai báo này vì nó không đc ở đây, nó phải ở trong file .designer.cs
    //private IContainer components;
    //private GroupControl groupControl1;
    //private LookUpEdit luePLCPort;
    //private LabelControl labelControl1;
    //private SimpleButton btnOk;
    //private SimpleButton btnCancel;

    // Thêm khai báo trường field _plcPort vào đây
    private string _plcPort = string.Empty;
    // Khai báo thuộc tính PLCPortName để lấy giá trị của _plcPort
    // từ khóa this là cần thiết để truy cập trường này trong lớp hiện tại.nó là một thuộc tính chỉ đọc, trả về giá trị của _plcPort
    // nó được gọi là một thể hiện của thuộc tính, cho phép người dùng lấy giá trị của _plcPort mà không cần phải thay đổi nó từ bên ngoài lớp.
    public string PLCPortName => this._plcPort;

    public FrmPLCPort()
    {
      this.InitializeComponent();
      this.Name = nameof(FrmPLCPort);
      this.Text = nameof(FrmPLCPort);
      this.luePLCPort.Properties.DataSource = (object) SerialPort.GetPortNames();
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      if (this.luePLCPort.ItemIndex == -1)
      {
        this.luePLCPort.ErrorText = "Please select a Port";
      }
      else
      {
        this._plcPort = this.luePLCPort.EditValue.ToString();
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
    }

    private void btnCancel_Click(object sender, EventArgs e) => this.Close();

    //Loại bỏ phần code này vì nó trùng với những khai báo có trong file .designer.cs (file này dootpeek đã không tạo ra, sử dụng file do DnySpy tạo ra)
    //protected override void Dispose(bool disposing)
    //{
    //  if (disposing && this.components != null)
    //    this.components.Dispose();
    //  base.Dispose(disposing);
    //}

    //private void InitializeComponent()
    //{
    //  this.groupControl1 = new GroupControl();
    //  this.luePLCPort = new LookUpEdit();
    //  this.labelControl1 = new LabelControl();
    //  this.btnOk = new SimpleButton();
    //  this.btnCancel = new SimpleButton();
    //  this.groupControl1.BeginInit();
    //  this.groupControl1.SuspendLayout();
    //  this.luePLCPort.Properties.BeginInit();
    //  this.SuspendLayout();
    //  this.groupControl1.Controls.Add((Control) this.luePLCPort);
    //  this.groupControl1.Controls.Add((Control) this.labelControl1);
    //  this.groupControl1.Location = new Point(1, 12);
    //  this.groupControl1.Name = "groupControl1";
    //  this.groupControl1.ShowCaption = false;
    //  this.groupControl1.Size = new Size(425, 97);
    //  this.groupControl1.TabIndex = 0;
    //  this.groupControl1.Text = "groupControl1";
    //  this.luePLCPort.Location = new Point(112, 41);
    //  this.luePLCPort.Name = "luePLCPort";
    //  this.luePLCPort.Properties.Buttons.AddRange(new EditorButton[1]
    //  {
    //    new EditorButton(ButtonPredefines.Combo)
    //  });
    //  this.luePLCPort.Properties.NullText = "";
    //  this.luePLCPort.Properties.ShowFooter = false;
    //  this.luePLCPort.Properties.ShowHeader = false;
    //  this.luePLCPort.Size = new Size(189, 22);
    //  this.luePLCPort.TabIndex = 1;
    //  this.labelControl1.Location = new Point(38, 44);
    //  this.labelControl1.Name = "labelControl1";
    //  this.labelControl1.Size = new Size(48, 16);
    //  this.labelControl1.TabIndex = 0;
    //  this.labelControl1.Text = "PLC Port";
    //  this.btnOk.Location = new Point(183, 126);
    //  this.btnOk.Name = "btnOk";
    //  this.btnOk.Size = new Size(94, 29);
    //  this.btnOk.TabIndex = 1;
    //  this.btnOk.Text = "OK";
    //  this.btnOk.Click += new EventHandler(this.btnOk_Click);
    //  this.btnCancel.Location = new Point(298, 126);
    //  this.btnCancel.Name = "btnCancel";
    //  this.btnCancel.Size = new Size(94, 29);
    //  this.btnCancel.TabIndex = 2;
    //  this.btnCancel.Text = "Cancel";
    //  this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    //  this.AutoScaleDimensions = new SizeF(7f, 16f);
    //  this.AutoScaleMode = AutoScaleMode.Font;
    //  this.ClientSize = new Size(428, 186);
    //  this.Controls.Add((Control) this.btnCancel);
    //  this.Controls.Add((Control) this.btnOk);
    //  this.Controls.Add((Control) this.groupControl1);
    //  this.Name = nameof (FrmPLCPort);
    //  this.Text = nameof (FrmPLCPort);
    //  this.groupControl1.EndInit();
    //  this.groupControl1.ResumeLayout(false);
    //  this.groupControl1.PerformLayout();
    //  this.luePLCPort.Properties.EndInit();
    //  this.ResumeLayout(false);
    //}
  }
}
