// Decompiled with JetBrains decompiler
// Type: NhuaNong.UserControls.ucTinHieuSanRung
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.UserControls
{
  public class ucTinHieuSanRung : UserControl
  {
    private bool _isOn;
    private ucTinHieuSanRung.TrangThai _trangThai;
    private Bitmap _bg_Click;
    private Bitmap _bg_NoClick;
    private IContainer components;

    public bool IsOn
    {
      get => this._isOn;
      set => this._isOn = value;
    }

    public ucTinHieuSanRung.TrangThai IsTrangThai
    {
      get => this._trangThai;
      set
      {
        this._trangThai = value;
        switch (this._trangThai)
        {
          case ucTinHieuSanRung.TrangThai.Run:
            this.BackgroundImage = (Image) this.Bg_Click;
            this.IsOn = false;
            break;
          case ucTinHieuSanRung.TrangThai.Stop:
            this.BackgroundImage = (Image) this.Bg_NoClick;
            this.IsOn = true;
            break;
        }
      }
    }

    public Bitmap Bg_Click
    {
      get => this._bg_Click;
      set => this._bg_Click = value;
    }

    public Bitmap Bg_NoClick
    {
      get => this._bg_NoClick;
      set => this._bg_NoClick = value;
    }

    public ucTinHieuSanRung()
    {
      this.InitializeComponent();
      this.IsTrangThai = ucTinHieuSanRung.TrangThai.Stop;
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
      this.BackColor = Color.Transparent;
      this.BackgroundImage = (Image) ResourceNhua._tinhieu_SanRung;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.DoubleBuffered = true;
      this.Name = nameof (ucTinHieuSanRung);
      this.Size = new Size(72, 64);
      this.ResumeLayout(false);
    }

    public enum TrangThai
    {
      Run,
      Stop,
    }
  }
}
