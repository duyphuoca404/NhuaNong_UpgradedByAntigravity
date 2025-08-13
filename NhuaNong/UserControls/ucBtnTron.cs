// Decompiled with JetBrains decompiler
// Type: NhuaNong.UserControls.ucBtnTron
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
  public class ucBtnTron : UserControl
  {
    private Bitmap _bg_Click;
    private Bitmap _bg_NoClick;
    private bool _isOn;
    private IContainer components;

    public event ucBtnTron.DelButtonEventHandler ButtonClick;

    public event ucBtnTron.DelButtonEventHandler ButtonMouseDown;

    public event ucBtnTron.DelButtonEventHandler ButtonMouseUp;

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

    public ucBtnTron() => this.InitializeComponent();

    private void ucBtnTron_Click(object sender, EventArgs e)
    {
      if (this.ButtonClick == null)
        return;
      this.ButtonClick((object) this, new EventArgs());
    }

    private void ucBtnTron_MouseDown(object sender, MouseEventArgs e)
    {
      if (this.ButtonMouseDown == null)
        return;
      this.ButtonMouseDown((object) this, new EventArgs());
      this.BackgroundImage = (Image) this.Bg_Click;
      this.IsOn = true;
    }

    private void ucBtnTron_MouseUp(object sender, MouseEventArgs e)
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
      this.BackColor = Color.Silver;
      this.BackgroundImage = (Image) ResourceNhua._btnTron;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.DoubleBuffered = true;
      this.Name = nameof (ucBtnTron);
      this.Size = new Size(20, 20);
      this.Click += new EventHandler(this.ucBtnTron_Click);
      this.MouseDown += new MouseEventHandler(this.ucBtnTron_MouseDown);
      this.MouseUp += new MouseEventHandler(this.ucBtnTron_MouseUp);
      this.ResumeLayout(false);
    }

    public delegate void DelButtonEventHandler(object sender, EventArgs e);
  }
}
