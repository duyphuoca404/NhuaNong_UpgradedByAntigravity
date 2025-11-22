using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.UserControls
{
  public partial class ucVitTaiFD : UserControl
  {
    public ucVitTaiFD.Action _action;
    private Bitmap _bg_Click;
    private Bitmap _bg_NoClick;


    public event ucVitTaiFD.ButtonEventHandler Button_Click;

    public event ucVitTaiFD.ButtonEventHandler ButtonMouseDown;

    public event ucVitTaiFD.ButtonEventHandler ButtonMouseUp;

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

    public ucVitTaiFD.Action CheDo
    {
      get => this._action;
      set
      {
        this._action = value;
        switch (this._action)
        {
          case ucVitTaiFD.Action.Start:
            this.BackgroundImage = (Image) this.Bg_Click;
            break;
          case ucVitTaiFD.Action.Pause:
            this.BackgroundImage = (Image) this.Bg_NoClick;
            break;
        }
      }
    }

    public ucVitTaiFD()
    {
      this.InitializeComponent();
      this.Name = nameof(ucVitTaiFD);
      this.BackgroundImage = (Image) this.Bg_NoClick;
    }

    private void ucVitTaiFD_Click(object sender, EventArgs e)
    {
    }

    private void pictureEdit1_Click(object sender, EventArgs e)
    {
    }

    private void pictureEdit1_MouseDown(object sender, MouseEventArgs e)
    {
      if (this.ButtonMouseDown == null)
        return;
      this.ButtonMouseDown((object) this, new EventArgs());
    }

    private void pictureEdit1_MouseUp(object sender, MouseEventArgs e)
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
