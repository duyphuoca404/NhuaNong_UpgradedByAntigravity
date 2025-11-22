using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.UserControls
{
  public partial class ucNoiTron : UserControl
  {
    public Decimal KL_TRON
    {
      get => Convert.ToDecimal(this.lblKL.Text);
      set => this.lblKL.Text = value.ToString(this.Text);
    }

    public Decimal TG_TRON
    {
      get => Convert.ToDecimal(this.lblTG_ThucTron.Text);
      set => this.lblTG_ThucTron.Text = value.ToString(this.Text);
    }

    public Decimal TG_THỰC_XA
    {
      get => Convert.ToDecimal(this.lblTG_ThucXa.Text);
      set => this.lblTG_ThucXa.Text = value.ToString(this.Text);
    }

    public ucNoiTron()
    {
      InitializeComponent();
      this.Name = nameof(ucNoiTron);
    }


  }
}
