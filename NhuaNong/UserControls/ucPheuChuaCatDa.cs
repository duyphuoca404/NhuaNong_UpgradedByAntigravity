using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.UserControls
{
  public partial class ucPheuChuaCatDa : UserControl
  {
    public ucPheuChuaCatDa()
    {
      InitializeComponent();
      this.Name = nameof(ucPheuChuaCatDa);
    }

    public string WeighName
    {
      get => this.lblName.Text;
      set => this.lblName.Text = value;
    }

    
  }
}
