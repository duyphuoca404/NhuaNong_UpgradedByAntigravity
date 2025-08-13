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
  public class UcLogicSiloAgg : UcLogicBase
  {
    public int numSelected;
    public BindingList<ObjSilo> _blstSiloLogicAgg = new BindingList<ObjSilo>();
    public BindingList<ObjSilo> _blstSiloLogicAggSelected1 = new BindingList<ObjSilo>();
    public BindingList<ObjSilo> _blstSiloLogicAggSelected2 = new BindingList<ObjSilo>();
    private IContainer components;

    public UcLogicSiloAgg() => this.InitializeComponent();

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

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.lueWeigh2.Properties.BeginInit();
      this.lueWeigh1.Properties.BeginInit();
      this.SuspendLayout();
      this.lueWeigh2.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueWeigh2.Properties.Appearance.Options.UseFont = true;
      this.lueWeigh1.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueWeigh1.Properties.Appearance.Options.UseFont = true;
      this.lueWeigh1.Properties.Name = "";
      this.lueWeigh1.Properties.ValueMember = "MaSilo";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Name = nameof (UcLogicSiloAgg);
      this.lueWeigh2.Properties.EndInit();
      this.lueWeigh1.Properties.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
