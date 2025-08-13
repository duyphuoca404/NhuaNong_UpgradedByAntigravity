// Decompiled with JetBrains decompiler
// Type: NhuaNong.UserControls.ucVitTaiFD
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.UserControls
{
  public class ucVitTaiFD : UserControl
  {
    public ucVitTaiFD.Action _action;
    private Bitmap _bg_Click;
    private Bitmap _bg_NoClick;
    private IContainer components;
    private PictureEdit pictureEdit1;

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

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.pictureEdit1 = new PictureEdit();
      this.pictureEdit1.Properties.BeginInit();
      this.SuspendLayout();
      this.pictureEdit1.Location = new Point(0, 86);
      this.pictureEdit1.Name = "pictureEdit1";
      this.pictureEdit1.Properties.AllowFocused = false;
      this.pictureEdit1.Properties.Appearance.BackColor = Color.Transparent;
      this.pictureEdit1.Properties.Appearance.ForeColor = Color.Transparent;
      this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
      this.pictureEdit1.Properties.Appearance.Options.UseForeColor = true;
      this.pictureEdit1.Properties.BorderStyle = BorderStyles.NoBorder;
      this.pictureEdit1.Properties.NullText = " ";
      this.pictureEdit1.Properties.ReadOnly = true;
      this.pictureEdit1.Properties.ShowCameraMenuItem = CameraMenuItemVisibility.Auto;
      this.pictureEdit1.Size = new Size(50, 50);
      this.pictureEdit1.TabIndex = 0;
      this.pictureEdit1.MouseDown += new MouseEventHandler(this.pictureEdit1_MouseDown);
      this.pictureEdit1.MouseUp += new MouseEventHandler(this.pictureEdit1_MouseUp);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Transparent;
      this.BackgroundImage = (Image) ResourceNhua._vittaiFD;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.Controls.Add((Control) this.pictureEdit1);
      this.DoubleBuffered = true;
      this.Name = nameof (ucVitTaiFD);
      this.Size = new Size(132, 136);
      this.Click += new EventHandler(this.ucVitTaiFD_Click);
      this.pictureEdit1.Properties.EndInit();
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
