// Decompiled with JetBrains decompiler
// Type: NhuaNong.UserControls.ucSoMeDaCan
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.UserControls
{
  public class ucSoMeDaCan : UserControl
  {
    private Decimal _tongSoMe;
    private Decimal _soMeDaTron;
    private IContainer components;
    private LabelControl labelControl1;

    public Decimal SoLuongMeCanTron
    {
      get => this._tongSoMe;
      set
      {
        this._tongSoMe = value;
        this.ShowValue();
      }
    }

    public Decimal SoLuongMeDaTron
    {
      get => this._soMeDaTron;
      set
      {
        this._soMeDaTron = value;
        this.ShowValue();
      }
    }

    private void ShowValue()
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) new MethodInvoker(this.ShowValue));
      else
        this.labelControl1.Text = string.Format("{0}/{1}", (object) this._soMeDaTron.ToString(), (object) this._tongSoMe.ToString());
    }

    public ucSoMeDaCan() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.labelControl1 = new LabelControl();
      this.SuspendLayout();
      this.labelControl1.Appearance.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Appearance.Options.UseTextOptions = true;
      this.labelControl1.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.labelControl1.Appearance.TextOptions.VAlignment = VertAlignment.Center;
      this.labelControl1.AutoSizeMode = LabelAutoSizeMode.None;
      this.labelControl1.BorderStyle = BorderStyles.Simple;
      this.labelControl1.Dock = DockStyle.Fill;
      this.labelControl1.Location = new Point(0, 0);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(65, 20);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "01/01";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.labelControl1);
      this.Name = nameof (ucSoMeDaCan);
      this.Size = new Size(65, 20);
      this.ResumeLayout(false);
    }
  }
}
