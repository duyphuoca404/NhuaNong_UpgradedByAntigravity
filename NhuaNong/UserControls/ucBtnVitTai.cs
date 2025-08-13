// Decompiled with JetBrains decompiler
// Type: NhuaNong.UserControls.ucBtnVitTai
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
  public class ucBtnVitTai : UserControl
  {
    private Bitmap _bg_Click;
    private Bitmap _bg_NoClick;
    private bool _isOn;
    private IContainer components;

    public event ucBtnVitTai.ButtonEventHandler ButtonClick;

    public event ucBtnVitTai.ButtonEventHandler ButtonMouseDown;

    public event ucBtnVitTai.ButtonEventHandler ButtonMouseUp;

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

    public ucBtnVitTai() => this.InitializeComponent();

    private void ucBtnVitTai_Click(object sender, EventArgs e)
    {
      if (this.ButtonClick == null)
        return;
      this.ButtonClick((object) this, new EventArgs());
    }

    private void ucBtnVitTai_MouseDown(object sender, MouseEventArgs e)
    {
      if (this.ButtonMouseDown == null)
        return;
      this.ButtonMouseDown((object) this, new EventArgs());
      this.BackgroundImage = (Image) this.Bg_Click;
      this.IsOn = true;
    }

    private void ucBtnVitTai_MouseUp(object sender, MouseEventArgs e)
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
      this.BackColor = Color.Transparent;
      this.BackgroundImage = (Image) ResourceNhua._btnVuong;
      this.Name = nameof (ucBtnVitTai);
      this.Size = new Size(35, 15);
      this.Click += new EventHandler(this.ucBtnVitTai_Click);
      this.MouseDown += new MouseEventHandler(this.ucBtnVitTai_MouseDown);
      this.MouseUp += new MouseEventHandler(this.ucBtnVitTai_MouseUp);
      this.ResumeLayout(false);
    }

    public delegate void ButtonEventHandler(object sender, EventArgs e);
  }
}
