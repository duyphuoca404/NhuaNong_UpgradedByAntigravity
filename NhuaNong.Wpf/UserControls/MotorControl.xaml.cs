using System.Windows;
using System.Windows.Controls;

namespace NhuaNong.Wpf.UserControls
{
    public partial class MotorControl : UserControl
    {
        public MotorControl()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty IsRunningProperty =
            DependencyProperty.Register("IsRunning", typeof(bool), typeof(MotorControl), new PropertyMetadata(false));

        public bool IsRunning
        {
            get { return (bool)GetValue(IsRunningProperty); }
            set { SetValue(IsRunningProperty, value); }
        }
    }
}
