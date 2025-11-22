// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.UcBaseSilo2
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
namespace NhuaNong.MasterData
{
  public partial class UcBaseSilo2 : XtraUserControl
  {
    private Decimal _doHut;
    private Decimal _klSaveThucTe;
    private Decimal _klTemp;
    

    public UcBaseSilo2()
    {
      this.InitializeComponent();
      this.Name = nameof(UcBaseSilo2);
    }
    private void lblCaption_Click(object sender, EventArgs e)
    {
      if (this.CaptionClick == null)
        return;
      this.CaptionClick((object) this, new EventArgs());
    }

    private void picBackground_Click(object sender, EventArgs e)
    {
      if (this.CaptionClick == null)
        return;
      this.CaptionClick((object) this, new EventArgs());
    }

    public event UcBaseSilo2.DelCaptionEventHandler CaptionClick;

    public event UcBaseSilo2.DelCaptionEventHandler SiloTankClick;

    public event UcBaseSilo2.EditDoAmChange UpdateDoAm;

    public int? MaterialID { get; set; }

    public bool ShowSiloDesc
    {
      get => this.lblDesc.Visible;
      set => this.ShowDesc(value);
    }

    public string SiloDesc
    {
      get => this.lblDesc.Text;
      set => this.lblDesc.Text = value;
    }

    public string SiloCaption
    {
      get => this.lblCaption.Text;
      set => this.lblCaption.Text = value;
    }

    public string MaSilo { get; set; }

    public Decimal DoAm
    {
      get => Convert.ToDecimal(this.spn0.EditValue);
      set => this.spn0.EditValue = (object) value;
    }

    public Decimal DoHut
    {
      get => this._doHut;
      set => this._doHut = value;
    }

    public Decimal KLCaiDat
    {
      get => Convert.ToDecimal(this.spn1.EditValue);
      set => this.spn1.EditValue = (object) value;
    }

    public Decimal KLCanCan
    {
      get => Convert.ToDecimal(this.spn2.EditValue);
      set => this.spn2.EditValue = (object) value;
    }

    public Decimal KLCanCan_Origin { get; set; }

    public Decimal KLThucTe
    {
      get => Convert.ToDecimal(this.spn3.EditValue);
      set => this.SetSpn3Value(value);
    }

    public Decimal KLSaveThucTe
    {
      get => this._klSaveThucTe;
      set => this._klSaveThucTe = value;
    }

    public Decimal KLTemp
    {
      get => this._klTemp;
      set => this._klTemp = value;
    }

    public SiloOnline SiloOnline
    {
      get
      {
        return new SiloOnline()
        {
          MaSilo = this.MaSilo,
          DoAm = this.DoAm,
          KLThucTe = this.KLThucTe,
          KLSaveThucTe = this.KLSaveThucTe,
          KLTemp = this.KLTemp,
          KLCaiDat = this.KLCaiDat,
          KLCanCan = this.KLCanCan
        };
      }
    }

    public void SetupNumberFormat(string numericFormat)
    {
      this.spn0.Properties.DisplayFormat.FormatString = numericFormat;
      this.spn0.Properties.EditFormat.FormatString = numericFormat;
      this.spn0.Properties.Mask.EditMask = numericFormat;
      this.spn1.Properties.DisplayFormat.FormatString = numericFormat;
      this.spn1.Properties.EditFormat.FormatString = numericFormat;
      this.spn1.Properties.Mask.EditMask = numericFormat;
      this.spn2.Properties.DisplayFormat.FormatString = numericFormat;
      this.spn2.Properties.EditFormat.FormatString = numericFormat;
      this.spn2.Properties.Mask.EditMask = numericFormat;
      this.spn3.Properties.DisplayFormat.FormatString = numericFormat;
      this.spn3.Properties.EditFormat.FormatString = numericFormat;
      this.spn3.Properties.Mask.EditMask = numericFormat;
    }

    private void ShowDesc(bool visible)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) (() => this.ShowDesc(visible)));
      else
        this.lblDesc.Visible = visible;
    }

    private void SetSpn3Value(Decimal value)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) (() => this.SetSpn3Value(value)));
      else
        this.spn3.EditValue = (object) value;
    }

    private void lblCaption_TextChanged(object sender, EventArgs e)
    {
      this.lblCaption.Text = this.lblCaption.Text.ToUpper();
    }

    private void lblDesc_MouseHover(object sender, EventArgs e)
    {
      this.lblDesc.ToolTip = this.SiloDesc;
    }

    private void spn1_Click(object sender, EventArgs e)
    {
      if (this.CaptionClick == null)
        return;
      this.CaptionClick((object) this, new EventArgs());
    }

    private void spn2_Click(object sender, EventArgs e)
    {
      if (this.CaptionClick == null)
        return;
      this.CaptionClick((object) this, new EventArgs());
    }

    private void spn3_Click(object sender, EventArgs e)
    {
      if (this.CaptionClick == null)
        return;
      this.CaptionClick((object) this, new EventArgs());
    }

    private void spn0_EditValueChanged(object sender, EventArgs e)
    {
      if (this.spn0.Value < 0M)
        this.spn0.Value = 0M;
      this.DoAm = Convert.ToDecimal(this.spn0.Value);
      if (this.UpdateDoAm == null)
        return;
      this.UpdateDoAm((object) this, new EventArgs());
    }

    

    public delegate void DelCaptionEventHandler(object sender, EventArgs e);

    public delegate void EditDoAmChange(object sender, EventArgs e);
  }
}
