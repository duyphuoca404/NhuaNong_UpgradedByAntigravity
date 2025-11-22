// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.UcLogicSiloAgg
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using NhuaNong.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public partial class UcLogicSiloAgg : UcLogicBase
  {
    public int numSelected;
    public BindingList<ObjSilo> _blstSiloLogicAgg = new BindingList<ObjSilo>();
    public BindingList<ObjSilo> _blstSiloLogicAggSelected1 = new BindingList<ObjSilo>();
    public BindingList<ObjSilo> _blstSiloLogicAggSelected2 = new BindingList<ObjSilo>();
    

    public UcLogicSiloAgg()
    {
      this.InitializeComponent();
      this.Name = nameof(UcLogicSiloAgg);
    }

    public void SetBlistSiloLogic(BindingList<ObjSilo> _blstSilo)
    {
      Support.UpdateListSiloLogic(_blstSilo, (string) this.lueWeigh1.EditValue);
    }

    public override void GetBlstSiloLogic(BindingList<ObjSilo> _blstSilo)
    {
      if (_blstSilo == null)
        return;
      this.lueWeigh1.Properties.DataSource = (object) _blstSilo;
    }

    protected override void lueWeigh2_EditValueChanged(object sender, EventArgs e)
    {
    }

    
  }
}
