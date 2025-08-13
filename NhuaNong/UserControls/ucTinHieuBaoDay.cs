// Decompiled with JetBrains decompiler
// Type: NhuaNong.UserControls.ucTinHieuBaoDay
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.UserControls
{
  public class ucTinHieuBaoDay : UserControl
  {
    private bool _isOn;
    private ucTinHieuBaoDay.TrangThai _trangThai;
    private IContainer components;

    public bool IsOn
    {
      get => this._isOn;
      set => this._isOn = value;
    }

    public ucTinHieuBaoDay.TrangThai IsTrangThai
    {
      get => this._trangThai;
      set
      {
        this._trangThai = value;
        switch (this._trangThai)
        {
          case ucTinHieuBaoDay.TrangThai.Run:
            this.BackColor = Color.Red;
            this.IsOn = false;
            break;
          case ucTinHieuBaoDay.TrangThai.Stop:
            this.BackColor = Color.DarkGray;
            this.IsOn = true;
            break;
        }
      }
    }

    public ucTinHieuBaoDay()
    {
      this.InitializeComponent();
      this.IsTrangThai = ucTinHieuBaoDay.TrangThai.Stop;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.SuspendLayout();
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Red;
      this.Name = nameof (ucTinHieuBaoDay);
      this.Size = new Size(60, 10);
      this.ResumeLayout(false);
    }

    public enum TrangThai
    {
      Run,
      Stop,
    }
  }
}
