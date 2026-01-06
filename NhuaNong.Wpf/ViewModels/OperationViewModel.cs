using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media;

namespace NhuaNong.Wpf.ViewModels
{
    public partial class OperationViewModel : ObservableObject
    {
        private System.Windows.Threading.DispatcherTimer _timer;

        public OperationViewModel()
        {
            // Initialize Timer
            _timer = new System.Windows.Threading.DispatcherTimer();
            _timer.Interval = TimeSpan.FromMilliseconds(100);
            _timer.Tick += Timer_Tick;

            // Initialize Dummy Data
            SiloAGG1_Level = 0;
            SiloAGG1_Setpoint = 1500;
            SiloAGG1_Required = 1200;
            
            WeighAGG_Value = 0;
            Mixer_MixingTime = 0;
            Mixer_DischargingTime = 0;
        }

        public void StartTimer()
        {
            _timer.Start();
        }

        public void StopTimer()
        {
            _timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Simulation Logic (Replace with PLC Read later)
            // Simulate Silo Level changing
            SiloAGG1_Level += 10;
            if (SiloAGG1_Level > 5000) SiloAGG1_Level = 0;

            // Simulate Weigh Value
            WeighAGG_Value += 5;
            if (WeighAGG_Value > 2000) WeighAGG_Value = 0;

            // Simulate Mixer Timer
            Mixer_MixingTime += 1;
            if (Mixer_MixingTime > 60) Mixer_MixingTime = 0;
        }

        #region Silo AGG1
        [ObservableProperty]
        private double _siloAGG1_Level;

        [ObservableProperty]
        private double _siloAGG1_Setpoint;

        [ObservableProperty]
        private double _siloAGG1_Required;

        [ObservableProperty]
        private double _siloAGG1_Moisture;
        #endregion

        #region Weigh AGG
        [ObservableProperty]
        private double _weighAGG_Value;

        [ObservableProperty]
        private Brush _weighAGG_Status;
        #endregion

        #region Mixer
        [ObservableProperty]
        private double _mixer_MixingTime;

        [ObservableProperty]
        private double _mixer_DischargingTime;
        #endregion

        #region Motor Status
        [ObservableProperty]
        private bool _motorGauTaiFD_IsRunning;
        #endregion
    }
}
