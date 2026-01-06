using System.Windows;
using System.Windows.Controls;

namespace NhuaNong.Wpf.Base
{
    public class WpfControlViewBase : UserControl
    {
        public WpfControlViewBase()
        {
            this.Loaded += WpfControlViewBase_Loaded;
            this.Unloaded += WpfControlViewBase_Unloaded;
        }

        private void WpfControlViewBase_Loaded(object sender, RoutedEventArgs e)
        {
            OnLoad();
        }

        private void WpfControlViewBase_Unloaded(object sender, RoutedEventArgs e)
        {
            OnClose();
        }

        public virtual void OnLoad()
        {
            // Override in derived classes
        }

        public virtual void OnClose()
        {
            // Override in derived classes
        }

        public virtual void ProcessData(object data)
        {
            // Override in derived classes
        }

        #region Dependency Properties

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(WpfControlViewBase), new PropertyMetadata(string.Empty));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty IsLoadingProperty =
            DependencyProperty.Register("IsLoading", typeof(bool), typeof(WpfControlViewBase), new PropertyMetadata(false));

        public bool IsLoading
        {
            get { return (bool)GetValue(IsLoadingProperty); }
            set { SetValue(IsLoadingProperty, value); }
        }

        #endregion
    }
}
