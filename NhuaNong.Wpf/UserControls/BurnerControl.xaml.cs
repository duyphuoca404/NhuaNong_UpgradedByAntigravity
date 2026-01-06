using System.Windows;
using System.Windows.Controls;

namespace NhuaNong.Wpf.UserControls
{
    public partial class BurnerControl : UserControl
    {
        public BurnerControl()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty IsActiveProperty =
            DependencyProperty.Register("IsActive", typeof(bool), typeof(BurnerControl), new PropertyMetadata(false));

        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }
    }
}
