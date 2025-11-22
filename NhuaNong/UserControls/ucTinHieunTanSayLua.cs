using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.UserControls
{
  public partial class ucTinHieunTanSayLua : UserControl
  {
    private bool _isOn;
    private ucTinHieunTanSayLua.TrangThai _trangThai;
    private Bitmap _bg_Click;
    private Bitmap _bg_NoClick;


    public bool IsOn
    {
      get => this._isOn;
      set => this._isOn = value;
    }

    public ucTinHieunTanSayLua.TrangThai IsTrangThai
    {
      get => this._trangThai;
      set
      {
        this._trangThai = value;
        switch (this._trangThai)
        {
          case ucTinHieunTanSayLua.TrangThai.Run:
            this.BackgroundImage = (Image) this.Bg_Click;
            this.IsOn = false;
            break;
          case ucTinHieunTanSayLua.TrangThai.Stop:
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

    public ucTinHieunTanSayLua()
    {
      this.InitializeComponent();
      this.Name = nameof(ucTinHieunTanSayLua);
      this.IsTrangThai = ucTinHieunTanSayLua.TrangThai.Stop;
    }



    public enum TrangThai
    {
      Run,
      Stop,
    }
  }
}
