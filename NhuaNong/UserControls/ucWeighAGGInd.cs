using DevExpress.Utils;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.UserControls
{
  /// <summary>
  /// UserControl phễu cân AGG mini dùng cho chế độ cân độc lập.
  /// Kích thước đề xuất: ~80x80 (nhỏ hơn ucWeighAGG gốc 416x78)
  /// </summary>
  public partial class ucWeighAGGInd : ucBaseWeight
  {
    public ucWeighAGGInd()
    {
      InitializeComponent();
      this.Name = nameof(ucWeighAGGInd);
    }
  }
}
