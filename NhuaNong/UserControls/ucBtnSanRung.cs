// Decompiled with JetBrains decompiler
// Type: NhuaNong.UserControls.ucBtnSanRung
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
  public class ucBtnSanRung : UserControl
  {
    private bool _isOn;
    private IContainer components;

    public event ucBtnSanRung.ButtonEventHandler ButtonMouseDown;

    public event ucBtnSanRung.ButtonEventHandler ButtonMouseUp;

    public bool IsOn
    {
      get => this._isOn;
      set => this._isOn = value;
    }

    public ucBtnSanRung() => this.InitializeComponent();

    private void ucBtnSanRung_MouseDown(object sender, MouseEventArgs e)
    {
      if (this.ButtonMouseDown == null)
        return;
      this.ButtonMouseDown((object) this, new EventArgs());
      this.IsOn = true;
    }

    private void ucBtnSanRung_MouseUp(object sender, MouseEventArgs e)
    {
      if (this.ButtonMouseUp == null)
        return;
      this.ButtonMouseUp((object) this, new EventArgs());
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
      this.BackgroundImage = (Image) ResourceNhua._btnBatSanRung;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.DoubleBuffered = true;
      this.Name = nameof (ucBtnSanRung);
      this.Size = new Size(76, 45);
      this.MouseDown += new MouseEventHandler(this.ucBtnSanRung_MouseDown);
      this.MouseUp += new MouseEventHandler(this.ucBtnSanRung_MouseUp);
      this.ResumeLayout(false);
    }

    public delegate void ButtonEventHandler(object sender, EventArgs e);
  }
}
