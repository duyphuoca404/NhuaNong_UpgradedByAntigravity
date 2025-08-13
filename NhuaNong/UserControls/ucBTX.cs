// Decompiled with JetBrains decompiler
// Type: NhuaNong.UserControls.ucBTX
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
  public class ucBTX : UserControl
  {
    public ucBTX.Action _action;
    private Bitmap _bg_Click;
    private Bitmap _bg_NoClick;
    private IContainer components;

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

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.SuspendLayout();
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Transparent;
      this.BackgroundImage = (Image) ResourceNhua._btx;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.DoubleBuffered = true;
      this.Name = nameof (ucBTX);
      this.Size = new Size(180, 184);
      this.Click += new EventHandler(this.ucBTX_Click);
      this.MouseDown += new MouseEventHandler(this.ucBTX_MouseDown);
      this.MouseUp += new MouseEventHandler(this.ucBTX_MouseUp);
      this.ResumeLayout(false);
    }

    public delegate void ButtonEventHandler(object sender, EventArgs e);

    public enum Action
    {
      Start,
      Pause,
    }
  }
}
