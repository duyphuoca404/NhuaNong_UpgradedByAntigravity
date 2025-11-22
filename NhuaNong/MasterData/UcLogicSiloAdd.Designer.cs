using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NhuaNong.MasterData
{
  public partial class UcLogicSiloAdd
  {
    private IContainer components;

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
      this.lueWeigh2.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lueWeigh2.Properties.Appearance.Options.UseFont = true;
      this.lueWeigh1.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lueWeigh1.Properties.Appearance.Options.UseFont = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Name = "UcLogicSiloAdd";
      this.NhomSilo = UcLogicBase.NhomSiloEnum.ADD;
      this.lueWeigh2.Properties.EndInit();
      this.lueWeigh1.Properties.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
