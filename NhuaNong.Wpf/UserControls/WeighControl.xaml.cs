using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace NhuaNong.Wpf.UserControls
{
    public partial class WeighControl : UserControl
    {
        public WeighControl()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty WeightProperty =
            DependencyProperty.Register("Weight", typeof(double), typeof(WeighControl), new PropertyMetadata(0.0));

        public double Weight
        {
            get { return (double)GetValue(WeightProperty); }
            set { SetValue(WeightProperty, value); }
        }

        public static readonly DependencyProperty StatusColorProperty =
            DependencyProperty.Register("StatusColor", typeof(Brush), typeof(WeighControl), new PropertyMetadata(Brushes.Transparent));

        public Brush StatusColor
        {
            get { return (Brush)GetValue(StatusColorProperty); }
            set { SetValue(StatusColorProperty, value); }
        }
    }
}
