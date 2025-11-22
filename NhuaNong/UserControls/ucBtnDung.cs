// Decompiled with JetBrains decompiler
// Type: NhuaNong.UserControls.ucBtnDung
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.UserControls
{
  public partial class ucBtnDung : UserControl
  {
    private Bitmap _bg_Click;
    private Bitmap _bg_NoClick;
    private bool _isOn;
    private ucBtnDung.TrangThai _trangThai;
    

    public event ucBtnDung.DelButtonEventHandler ButtonClick;

    public bool IsOn
    {
      get => this._isOn;
      set => this._isOn = value;
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

    public ucBtnDung.TrangThai IsTrangThai
    {
      get => this._trangThai;
      set
      {
        this._trangThai = value;
        switch (this._trangThai)
        {
          case ucBtnDung.TrangThai.Run:
            this.BackgroundImage = (Image) this.Bg_Click;
            this.IsOn = false;
            break;
          case ucBtnDung.TrangThai.Stop:
            this.BackgroundImage = (Image) this.Bg_NoClick;
            this.IsOn = true;
            break;
        }
      }
    }

    public ucBtnDung()
    {
      this.InitializeComponent();
      this.Name = nameof(ucBtnDung);
      this.IsTrangThai = ucBtnDung.TrangThai.Stop;
    }

    private void ucBtnDung_Click(object sender, EventArgs e)
    {
      if (this.ButtonClick == null)
        return;
      this.ButtonClick((object) this, new EventArgs());
      if (this.IsTrangThai == ucBtnDung.TrangThai.Run)
      {
        this.IsTrangThai = ucBtnDung.TrangThai.Stop;
      }
      else
      {
        if (this.IsTrangThai != ucBtnDung.TrangThai.Stop)
          return;
        this.IsTrangThai = ucBtnDung.TrangThai.Run;
      }
    }

    

    public delegate void DelButtonEventHandler(object sender, EventArgs e);

    public enum TrangThai
    {
      Run,
      Stop,
    }
  }
}
