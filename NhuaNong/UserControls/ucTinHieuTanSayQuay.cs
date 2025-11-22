using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.UserControls
{
  public partial class ucTinHieuTanSayQuay : UserControl
  {
    private bool _isOn;
    private ucTinHieuTanSayQuay.TrangThai _trangThai;
    private Bitmap _bg_Click;
    private Bitmap _bg_NoClick;


    public event ucTinHieuTanSayQuay.ButtonEventHandler ButtonClick;

    public event ucTinHieuTanSayQuay.ButtonEventHandler ButtonMouseDown;

    public event ucTinHieuTanSayQuay.ButtonEventHandler ButtonMouseUp;

    public bool IsOn
    {
      get => this._isOn;
      set => this._isOn = value;
    }

    public ucTinHieuTanSayQuay.TrangThai IsTrangThai
    {
      get => this._trangThai;
      set
      {
        this._trangThai = value;
        switch (this._trangThai)
        {
          case ucTinHieuTanSayQuay.TrangThai.Run:
            this.BackgroundImage = (Image) this.Bg_Click;
            this.IsOn = false;
            break;
          case ucTinHieuTanSayQuay.TrangThai.Stop:
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

    public ucTinHieuTanSayQuay()
    {
      this.InitializeComponent();
      this.Name = nameof(ucTinHieuTanSayQuay);
      this.IsTrangThai = ucTinHieuTanSayQuay.TrangThai.Stop;
    }

    private void ucTinHieuTanSayQuay_Click(object sender, EventArgs e)
    {
      if (this.ButtonClick == null)
        return;
      this.ButtonClick((object) this, new EventArgs());
    }

    private void ucTinHieuTanSayQuay_MouseDown(object sender, MouseEventArgs e)
    {
      if (this.ButtonMouseDown == null)
        return;
      this.ButtonMouseDown((object) this, new EventArgs());
      this.BackgroundImage = (Image) this.Bg_Click;
      this.IsOn = true;
    }

    private void ucTinHieuTanSayQuay_MouseUp(object sender, MouseEventArgs e)
    {
      if (this.ButtonMouseUp == null)
        return;
      this.ButtonMouseUp((object) this, new EventArgs());
      this.BackgroundImage = (Image) this.Bg_NoClick;
      this.IsOn = false;
    }



    public delegate void ButtonEventHandler(object sender, EventArgs e);

    public enum TrangThai
    {
      Run,
      Stop,
    }
  }
}
