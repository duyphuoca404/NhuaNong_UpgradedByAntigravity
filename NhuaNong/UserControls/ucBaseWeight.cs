// Decompiled with JetBrains decompiler
// Type: NhuaNong.UserControls.ucBaseWeight
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
  public partial class ucBaseWeight : XtraUserControl
  {
    private Decimal _weight;
    

    public event ucBaseWeight.DelCaptionEventHandler WeightClick;

    public Decimal Weight
    {
      get => this.spinEdit1.Value;
      set => this.spinEdit1.Value = value;
    }

    public ucBaseWeight()
    {
      InitializeComponent();
      this.Name = nameof(ucBaseWeight);
    }

    public Decimal GiaTriWeight
    {
      get => Convert.ToDecimal(this.spinEdit1.EditValue);
      set => this.spinEdit1.EditValue = (object) value;
    }

    private void picWeigh_Click(object sender, EventArgs e)
    {
      if (this.WeightClick == null)
        return;
      this.WeightClick((object) this, new EventArgs());
    }

    private void spinEdit1_Click(object sender, EventArgs e)
    {
      if (this.WeightClick == null)
        return;
      this.WeightClick((object) this, new EventArgs());
    }

    

    public delegate void DelCaptionEventHandler(object sender, EventArgs e);
  }
}
