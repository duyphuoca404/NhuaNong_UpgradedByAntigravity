using System.Windows;
using System.Windows.Controls;

namespace NhuaNong.Wpf.UserControls
{
    public partial class SiloControl : UserControl
    {
        public SiloControl()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty SetpointProperty =
            DependencyProperty.Register("Setpoint", typeof(double), typeof(SiloControl), new PropertyMetadata(0.0));

        public double Setpoint
        {
            get { return (double)GetValue(SetpointProperty); }
            set { SetValue(SetpointProperty, value); }
        }

        public static readonly DependencyProperty RequiredProperty =
            DependencyProperty.Register("Required", typeof(double), typeof(SiloControl), new PropertyMetadata(0.0));

        public double Required
        {
            get { return (double)GetValue(RequiredProperty); }
            set { SetValue(RequiredProperty, value); }
        }

        public static readonly DependencyProperty ActualProperty =
            DependencyProperty.Register("Actual", typeof(double), typeof(SiloControl), new PropertyMetadata(0.0));

        public double Actual
        {
            get { return (double)GetValue(ActualProperty); }
            set { SetValue(ActualProperty, value); }
        }

        public static readonly DependencyProperty MoistureProperty =
            DependencyProperty.Register("Moisture", typeof(double), typeof(SiloControl), new PropertyMetadata(0.0));

        public double Moisture
        {
            get { return (double)GetValue(MoistureProperty); }
            set { SetValue(MoistureProperty, value); }
        }

        public static readonly DependencyProperty SiloTypeProperty =
            DependencyProperty.Register("SiloType", typeof(string), typeof(SiloControl), new PropertyMetadata("Gray"));

        public string SiloType
        {
            get { return (string)GetValue(SiloTypeProperty); }
            set { SetValue(SiloTypeProperty, value); }
        }

        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register("Description", typeof(string), typeof(SiloControl), new PropertyMetadata(string.Empty));

        public string Description
        {
            get { return (string)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }

        public static readonly DependencyProperty CaptionProperty =
            DependencyProperty.Register("Caption", typeof(string), typeof(SiloControl), new PropertyMetadata("SILO"));

        public string Caption
        {
            get { return (string)GetValue(CaptionProperty); }
            set { SetValue(CaptionProperty, value); }
        }
    }
}
