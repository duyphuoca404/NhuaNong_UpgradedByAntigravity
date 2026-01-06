using NhuaNong.Wpf.Base;
using NhuaNong.Wpf.ViewModels;
using System;
using System.Windows.Forms;
using NhuaNong.Utils;
using NhuaNong.MasterData;

namespace NhuaNong.Wpf.Views
{
    public partial class OperationView : WpfControlViewBase
    {
        private OperationViewModel _viewModel;

        public OperationView()
        {
            InitializeComponent();
            _viewModel = new OperationViewModel();
            this.DataContext = _viewModel;
            this.Loaded += OperationView_Loaded;
        }

        private void OperationView_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                // Initialize Dependencies (Mimicking FrmMain_Load)
                ConfigManager.TramTronConfig.TimeLife = new DateTime(2099, 12, 31, 23, 59, 59);
                
                // Initialize WinForms Control
                var vanHanhControl = new NhuaNong.MasterData.VanHanh();
                vanHanhControl.Dock = DockStyle.Fill;
                vanHanhControl.Visible = true;

                // Embed in WindowsFormsHost
                WinFormsHost.Child = vanHanhControl;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show($"Error loading OperationView: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}", "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
            }
        }

        public override void OnLoad()
        {
            base.OnLoad();
            _viewModel.StartTimer();
        }

        public override void OnClose()
        {
            base.OnClose();
            _viewModel.StopTimer();
        }
    }
}
