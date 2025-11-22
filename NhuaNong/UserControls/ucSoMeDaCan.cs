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
  public partial class ucSoMeDaCan : UserControl
  {
    private Decimal _tongSoMe;
    private Decimal _soMeDaTron;
    

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

    public ucSoMeDaCan()
    {
      this.InitializeComponent();
      this.Name = nameof(ucSoMeDaCan);
    }


  }
}
