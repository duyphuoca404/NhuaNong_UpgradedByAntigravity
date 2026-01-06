using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace NhuaNong.Wpf.UserControls
{
    public partial class ValveControl : UserControl
    {
        public ValveControl()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register("Command", typeof(ICommand), typeof(ValveControl), new PropertyMetadata(null));

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }
    }
}
