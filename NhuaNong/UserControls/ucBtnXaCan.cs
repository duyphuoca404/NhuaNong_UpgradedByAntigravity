using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.UserControls
{
  public partial class ucBtnXaCan : UserControl
  {
    private bool _isOn;
    private bool _isRun;
    private ucBtnXaCan.BGColorEnum _bgColor;
    private ucBtnXaCan.TrangThai _trangThai;
    

    public event ucBtnXaCan.DelButtonEventHandler ButtonClick;

    public bool IsOn
    {
      get => this._isOn;
      set => this._isOn = value;
    }

    public bool IsRun
    {
      get => this._isRun;
      set => this._isRun = value;
    }

    public ucBtnXaCan.TrangThai IsTrangThai
    {
      get => this._trangThai;
      set
      {
        this._trangThai = value;
        switch (this._trangThai)
        {
          case ucBtnXaCan.TrangThai.Run:
            this.BGColor = ucBtnXaCan.BGColorEnum.Red;
            this.IsOn = false;
            this.IsRun = true;
            break;
          case ucBtnXaCan.TrangThai.Stop:
            this.BGColor = ucBtnXaCan.BGColorEnum.Gray;
            this.IsOn = true;
            this.IsRun = false;
            break;
        }
      }
    }

    public ucBtnXaCan.BGColorEnum BGColor
    {
      get => this._bgColor;
      set
      {
        this._bgColor = value;
        switch (this._bgColor)
        {
          case ucBtnXaCan.BGColorEnum.Red:
            this.BackColor = Color.Blue;
            break;
          case ucBtnXaCan.BGColorEnum.Gray:
            this.BackColor = Color.DarkGray;
            break;
        }
      }
    }

    public ucBtnXaCan()
    {
      this.InitializeComponent();
      this.Name = nameof(ucBtnXaCan);
      this.IsTrangThai = ucBtnXaCan.TrangThai.Run;
    }

    private void ucBtnXaCan_Click(object sender, EventArgs e)
    {
      if (this.ButtonClick == null)
        return;
      this.ButtonClick((object) this, new EventArgs());
      if (this.IsTrangThai == ucBtnXaCan.TrangThai.Run)
      {
        this.IsTrangThai = ucBtnXaCan.TrangThai.Stop;
      }
      else
      {
        if (this.IsTrangThai != ucBtnXaCan.TrangThai.Stop)
          return;
        this.IsTrangThai = ucBtnXaCan.TrangThai.Run;
      }
    }

    

    public delegate void DelButtonEventHandler(object sender, EventArgs e);

    public enum TrangThai
    {
      Run,
      Stop,
    }

    public enum BGColorEnum
    {
      Red,
      Gray,
    }
  }
}
