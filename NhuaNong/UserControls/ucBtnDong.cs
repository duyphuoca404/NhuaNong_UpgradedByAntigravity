// Decompiled with JetBrains decompiler
// Type: NhuaNong.UserControls.ucBtnDong
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
  public class ucBtnDong : UserControl
  {
    private Bitmap _bg_Click;
    private Bitmap _bg_NoClick;
    private bool _isOn;
    private IContainer components;

    public event ucBtnDong.ButtonEventHandler ButtonClick;

    public event ucBtnDong.ButtonEventHandler ButtonMouseDown;

    public event ucBtnDong.ButtonEventHandler ButtonMouseUp;

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

    public ucBtnDong() => this.InitializeComponent();

    private void ucBtnDong_Click(object sender, EventArgs e)
    {
      if (this.ButtonClick == null)
        return;
      this.ButtonClick((object) this, new EventArgs());
    }

    private void ucBtnDong_MouseDown(object sender, MouseEventArgs e)
    {
      if (this.ButtonMouseDown == null)
        return;
      this.ButtonMouseDown((object) this, new EventArgs());
      this.BackgroundImage = (Image) this.Bg_Click;
      this.IsOn = true;
    }

    private void ucBtnDong_MouseUp(object sender, MouseEventArgs e)
    {
      if (this.ButtonMouseUp == null)
        return;
      this.ButtonMouseUp((object) this, new EventArgs());
      this.BackgroundImage = (Image) this.Bg_NoClick;
      this.IsOn = false;
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
      this.BackgroundImage = (Image) ResourceNhua._btnDong;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.DoubleBuffered = true;
      this.Name = nameof (ucBtnDong);
      this.Size = new Size(100, 40);
      this.Click += new EventHandler(this.ucBtnDong_Click);
      this.MouseDown += new MouseEventHandler(this.ucBtnDong_MouseDown);
      this.MouseUp += new MouseEventHandler(this.ucBtnDong_MouseUp);
      this.ResumeLayout(false);
    }

    public delegate void ButtonEventHandler(object sender, EventArgs e);
  }
}
