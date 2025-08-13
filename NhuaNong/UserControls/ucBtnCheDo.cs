// Decompiled with JetBrains decompiler
// Type: NhuaNong.UserControls.ucBtnCheDo
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
  public class ucBtnCheDo : UserControl
  {
    private Bitmap _bg_Click;
    private Bitmap _bg_NoClick;
    private bool _isOn;
    private ucBtnCheDo.TrangThai _trangThai;
    private IContainer components;

    public event ucBtnCheDo.DelButtonEventHandler ButtonClick;

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

    public ucBtnCheDo.TrangThai IsTrangThai
    {
      get => this._trangThai;
      set
      {
        this._trangThai = value;
        switch (this._trangThai)
        {
          case ucBtnCheDo.TrangThai.Run:
            this.BackgroundImage = (Image) this.Bg_Click;
            this.IsOn = false;
            break;
          case ucBtnCheDo.TrangThai.Stop:
            this.BackgroundImage = (Image) this.Bg_NoClick;
            this.IsOn = true;
            break;
        }
      }
    }

    public ucBtnCheDo()
    {
      this.InitializeComponent();
      this.IsTrangThai = ucBtnCheDo.TrangThai.Stop;
    }

    private void ucBtnCheDo_Click(object sender, EventArgs e)
    {
      if (this.ButtonClick == null)
        return;
      this.ButtonClick((object) this, new EventArgs());
      if (this.IsTrangThai == ucBtnCheDo.TrangThai.Run)
      {
        this.IsTrangThai = ucBtnCheDo.TrangThai.Stop;
      }
      else
      {
        if (this.IsTrangThai != ucBtnCheDo.TrangThai.Stop)
          return;
        this.IsTrangThai = ucBtnCheDo.TrangThai.Run;
      }
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
      this.BackgroundImage = (Image) ResourceNhua._btnMAN;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.DoubleBuffered = true;
      this.Name = nameof (ucBtnCheDo);
      this.Size = new Size(100, 40);
      this.Click += new EventHandler(this.ucBtnCheDo_Click);
      this.ResumeLayout(false);
    }

    public delegate void DelButtonEventHandler(object sender, EventArgs e);

    public enum TrangThai
    {
      Run,
      Stop,
    }
  }
}
