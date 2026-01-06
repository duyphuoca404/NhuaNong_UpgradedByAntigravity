using System.Windows;
using System.Windows.Controls;

namespace NhuaNong.Wpf.UserControls
{
    public partial class MixerControl : UserControl
    {
        public MixerControl()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty MixingTimeProperty =
            DependencyProperty.Register("MixingTime", typeof(double), typeof(MixerControl), new PropertyMetadata(0.0));

        public double MixingTime
        {
            get { return (double)GetValue(MixingTimeProperty); }
            set { SetValue(MixingTimeProperty, value); }
        }

        public static readonly DependencyProperty DischargingTimeProperty =
            DependencyProperty.Register("DischargingTime", typeof(double), typeof(MixerControl), new PropertyMetadata(0.0));

        public double DischargingTime
        {
            get { return (double)GetValue(DischargingTimeProperty); }
            set { SetValue(DischargingTimeProperty, value); }
        }
    }
}
