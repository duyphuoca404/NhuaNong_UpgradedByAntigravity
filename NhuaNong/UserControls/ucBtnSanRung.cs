using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.UserControls
{
  public partial class ucBtnSanRung : UserControl
  {
    private bool _isOn;
    

    public event ucBtnSanRung.ButtonEventHandler ButtonMouseDown;

    public event ucBtnSanRung.ButtonEventHandler ButtonMouseUp;

    public bool IsOn
    {
      get => this._isOn;
      set => this._isOn = value;
    }

    public ucBtnSanRung()
    {
      this.InitializeComponent();
      this.Name = nameof(ucBtnSanRung);
    }

    private void ucBtnSanRung_MouseDown(object sender, MouseEventArgs e)
    {
      if (this.ButtonMouseDown == null)
        return;
      this.ButtonMouseDown((object) this, new EventArgs());
      this.IsOn = true;
    }

    private void ucBtnSanRung_MouseUp(object sender, MouseEventArgs e)
    {
      if (this.ButtonMouseUp == null)
        return;
      this.ButtonMouseUp((object) this, new EventArgs());
      this.IsOn = false;
    }

    

    public delegate void ButtonEventHandler(object sender, EventArgs e);
  }
}
