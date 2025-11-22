// Decompiled with JetBrains decompiler
// Type: NhuaNong.UserControls.ucBtnBatDau
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
  public partial class ucBtnBatDau : UserControl
  {
    private Bitmap _bg_Click;
    private Bitmap _bg_NoClick;
    private bool _isOn;
    

    public event ucBtnBatDau.DelButtonEventHandler ButtonClick;

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

    public ucBtnBatDau()
    {
      InitializeComponent();
      this.Name = nameof(ucBtnBatDau);
    }

    private void ucBtnBatDau_Click(object sender, EventArgs e)
    {
      if (this.ButtonClick == null)
        return;
      this.ButtonClick((object) this, new EventArgs());
      this.IsOn = true;
    }

    private void ucBtnBatDau_MouseDown(object sender, MouseEventArgs e)
    {
      this.BackgroundImage = (Image) this.Bg_Click;
    }

    private void ucBtnBatDau_MouseUp(object sender, MouseEventArgs e)
    {
      this.BackgroundImage = (Image) this.Bg_NoClick;
    }

    

    public delegate void DelButtonEventHandler(object sender, EventArgs e);
  }
}
