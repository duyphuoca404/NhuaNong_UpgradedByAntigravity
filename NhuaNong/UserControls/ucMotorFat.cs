// Decompiled with JetBrains decompiler
// Type: NhuaNong.UserControls.ucMotorFat
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
  public class ucMotorFat : UserControl
  {
    private Bitmap _bg_Click;
    private Bitmap _bg_NoClick;
    private bool _isOn;
    private ucMotorFat.TrangThai _trangThai;
    private IContainer components;

    public event ucMotorFat.DelButtonEventHandler ButtonClick;

    public event ucMotorFat.DelButtonEventHandler ButtonMouseDown;

    public event ucMotorFat.DelButtonEventHandler ButtonMouseUp;

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

    public ucMotorFat.TrangThai IsTrangThai
    {
      get => this._trangThai;
      set
      {
        this._trangThai = value;
        switch (this._trangThai)
        {
          case ucMotorFat.TrangThai.Run:
            this.BackgroundImage = (Image) this.Bg_Click;
            this.IsOn = false;
            break;
          case ucMotorFat.TrangThai.Stop:
            this.BackgroundImage = (Image) this.Bg_NoClick;
            this.IsOn = true;
            break;
        }
      }
    }

    public ucMotorFat()
    {
      this.InitializeComponent();
      this.IsTrangThai = ucMotorFat.TrangThai.Stop;
    }

    private void ucMotorFat_Click(object sender, EventArgs e)
    {
      if (this.ButtonClick == null)
        return;
      this.ButtonClick((object) this, new EventArgs());
    }

    private void ucMotorFat_MouseDown(object sender, MouseEventArgs e)
    {
      if (this.ButtonMouseDown == null)
        return;
      this.ButtonMouseDown((object) this, new EventArgs());
      this.BackgroundImage = (Image) this.Bg_Click;
      this.IsOn = true;
    }

    private void ucMotorFat_MouseUp(object sender, MouseEventArgs e)
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
      this.BackgroundImage = (Image) ResourceNhua._motor_fat;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.DoubleBuffered = true;
      this.Name = nameof (ucMotorFat);
      this.Size = new Size(88, 47);
      this.Click += new EventHandler(this.ucMotorFat_Click);
      this.MouseDown += new MouseEventHandler(this.ucMotorFat_MouseDown);
      this.MouseUp += new MouseEventHandler(this.ucMotorFat_MouseUp);
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
