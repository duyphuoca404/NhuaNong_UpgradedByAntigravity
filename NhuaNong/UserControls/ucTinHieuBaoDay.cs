using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.UserControls
{
  public partial class ucTinHieuBaoDay : UserControl
  {
    private bool _isOn;
    private ucTinHieuBaoDay.TrangThai _trangThai;


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
      this.Name = nameof(ucTinHieuBaoDay);
      this.IsTrangThai = ucTinHieuBaoDay.TrangThai.Stop;
    }

    

    public enum TrangThai
    {
      Run,
      Stop,
    }
  }
}
