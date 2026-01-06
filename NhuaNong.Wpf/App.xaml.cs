using System.Configuration;
using System.Data;
using System.Windows;
using System;

namespace NhuaNong.Wpf;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public App()
    {
        this.DispatcherUnhandledException += App_DispatcherUnhandledException;
        AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
    }

    private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
    {
        MessageBox.Show($"Unhandled Dispatcher Exception: {e.Exception.Message}\n\nStack Trace:\n{e.Exception.StackTrace}", "Application Error", MessageBoxButton.OK, MessageBoxImage.Error);
        e.Handled = true;
    }

    private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        var ex = e.ExceptionObject as Exception;
        MessageBox.Show($"Unhandled AppDomain Exception: {ex?.Message}\n\nStack Trace:\n{ex?.StackTrace}", "Critical Error", MessageBoxButton.OK, MessageBoxImage.Error);
    }
}

