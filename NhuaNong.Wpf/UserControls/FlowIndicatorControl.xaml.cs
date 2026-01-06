using System.Windows;
using System.Windows.Controls;

namespace NhuaNong.Wpf.UserControls
{
    public partial class FlowIndicatorControl : UserControl
    {
        public FlowIndicatorControl()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty IsActiveProperty =
            DependencyProperty.Register("IsActive", typeof(bool), typeof(FlowIndicatorControl), new PropertyMetadata(false, OnIsActiveChanged));

        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }

        private static void OnIsActiveChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (FlowIndicatorControl)d;
            control.Visibility = (bool)e.NewValue ? Visibility.Visible : Visibility.Hidden;
        }
    }
}
