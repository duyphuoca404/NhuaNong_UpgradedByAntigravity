// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.UcSoMeDaCan
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public partial class UcSoMeDaCan : XtraUserControl
  {
    private Decimal _tongSoMe;
    private Decimal _soMeDaTron;
    private Color _color;
    

    public Decimal SoLuongMeCanTron
    {
      get => this._tongSoMe;
      set
      {
        this._tongSoMe = value;
        this.ShowValue();
      }
    }

    public Color TextColor
    {
      get => this.labelControl1.ForeColor;
      set => this.labelControl1.ForeColor = value;
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

    public UcSoMeDaCan()
    {
      this.InitializeComponent();
      this.Name = nameof(UcSoMeDaCan);
    }

    
  }
}
