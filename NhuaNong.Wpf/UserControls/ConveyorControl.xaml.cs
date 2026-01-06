using System.Windows;
using System.Windows.Controls;

namespace NhuaNong.Wpf.UserControls
{
    public partial class ConveyorControl : UserControl
    {
        public ConveyorControl()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty IsRunningProperty =
            DependencyProperty.Register("IsRunning", typeof(bool), typeof(ConveyorControl), new PropertyMetadata(false));

        public string ConveyorType
        {
            get { return (string)GetValue(ConveyorTypeProperty); }
            set { SetValue(ConveyorTypeProperty, value); }
        }

        public static readonly DependencyProperty ConveyorTypeProperty =
            DependencyProperty.Register("ConveyorType", typeof(string), typeof(ConveyorControl), new PropertyMetadata("BTC"));

        public bool IsRunning
        {
            get { return (bool)GetValue(IsRunningProperty); }
            set { SetValue(IsRunningProperty, value); }
        }
    }
}
