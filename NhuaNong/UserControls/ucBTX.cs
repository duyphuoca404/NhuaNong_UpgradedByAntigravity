using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.UserControls
{
  public partial class ucBTX : UserControl
  {
    public ucBTX.Action _action;
    private Bitmap _bg_Click;
    private Bitmap _bg_NoClick;
    

    public event ucBTX.ButtonEventHandler Button_Click;

    public event ucBTX.ButtonEventHandler ButtonMouseDown;

    public event ucBTX.ButtonEventHandler ButtonMouseUp;

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

    public ucBTX.Action CheDo
    {
      get => this._action;
      set
      {
        this._action = value;
        switch (this._action)
        {
          case ucBTX.Action.Start:
            this.BackgroundImage = (Image) this.Bg_Click;
            break;
          case ucBTX.Action.Pause:
            this.BackgroundImage = (Image) this.Bg_NoClick;
            break;
        }
      }
    }

    public ucBTX()
    {
      this.InitializeComponent();
      this.Name = nameof(ucBTX);
      this.BackgroundImage = (Image) this.Bg_NoClick;
    }

    private void ucBTX_Click(object sender, EventArgs e)
    {
      if (this.Button_Click == null)
        return;
      this.Button_Click((object) this, new EventArgs());
    }

    private void ucBTX_MouseDown(object sender, MouseEventArgs e)
    {
      if (this.ButtonMouseDown == null)
        return;
      this.ButtonMouseDown((object) this, new EventArgs());
    }

    private void ucBTX_MouseUp(object sender, MouseEventArgs e)
    {
      if (this.ButtonMouseUp == null)
        return;
      this.ButtonMouseUp((object) this, new EventArgs());
    }

    

    public delegate void ButtonEventHandler(object sender, EventArgs e);

    public enum Action
    {
      Start,
      Pause,
    }
  }
}
