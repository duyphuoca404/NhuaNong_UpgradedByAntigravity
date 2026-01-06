using System.Windows;
using System.Windows.Controls;

namespace NhuaNong.Wpf.UserControls
{
    public partial class HopperControl : UserControl
    {
        public string HopperType
        {
            get { return (string)GetValue(HopperTypeProperty); }
            set { SetValue(HopperTypeProperty, value); }
        }

        public static readonly DependencyProperty HopperTypeProperty =
            DependencyProperty.Register("HopperType", typeof(string), typeof(HopperControl), new PropertyMetadata("Type1"));

        public HopperControl()
        {
            InitializeComponent();
        }
    }
}
