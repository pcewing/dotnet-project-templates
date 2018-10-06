namespace WpfTrayApp462
{
    using System;
    using System.Windows;
    using Hardcodet.Wpf.TaskbarNotification;
    using GalaSoft.MvvmLight.Threading;
    using ViewModels;

    public partial class App
    {
        private TaskbarIcon _taskbarIcon;
        
        static App()
        {
            DispatcherHelper.Initialize();
        }

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            _taskbarIcon = (TaskbarIcon) FindResource("TrayIcon");
            
            if (_taskbarIcon == null)
            {
                throw new Exception("Failed to find the taskbar icon resource");
            }
            
            var viewModelLocator = new ViewModelLocator();
            _taskbarIcon.DataContext = viewModelLocator.TrayIcon;
        }
    }
}
