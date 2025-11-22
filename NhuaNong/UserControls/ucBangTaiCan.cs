// Decompiled with JetBrains decompiler
// Type: NhuaNong.UserControls.ucBangTaiCan
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
  public partial class ucBangTaiCan : UserControl
  {
    public ucBangTaiCan.Action _action;
    private Bitmap _bg_Click;
    private Bitmap _bg_NoClick;
    

    public event ucBangTaiCan.ButtonEventHandler Button_Click;

    public event ucBangTaiCan.ButtonEventHandler ButtonMouseDown;

    public event ucBangTaiCan.ButtonEventHandler ButtonMouseUp;

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

    public ucBangTaiCan.Action CheDo
    {
      get => this._action;
      set
      {
        this._action = value;
        switch (this._action)
        {
          case ucBangTaiCan.Action.Start:
            this.BackgroundImage = (Image) this.Bg_Click;
            break;
          case ucBangTaiCan.Action.Pause:
            this.BackgroundImage = (Image) this.Bg_NoClick;
            break;
        }
      }
    }

    public ucBangTaiCan()
    {
      this.InitializeComponent();
      this.Name = nameof(ucBangTaiCan);
      this.BackgroundImage = (Image) this.Bg_NoClick;
    }

    private void ucBangTaiCan_Click(object sender, EventArgs e)
    {
      if (this.Button_Click == null)
        return;
      this.Button_Click((object) this, new EventArgs());
    }

    private void ucBangTaiCan_MouseDown(object sender, MouseEventArgs e)
    {
      if (this.ButtonMouseDown == null)
        return;
      this.ButtonMouseDown((object) this, new EventArgs());
    }

    private void ucBangTaiCan_MouseUp(object sender, MouseEventArgs e)
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
