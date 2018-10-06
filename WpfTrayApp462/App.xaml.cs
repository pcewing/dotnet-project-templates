using System.Windows;

namespace WpfTrayApp462
{
    using System;
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

        public void InitApplication()
        {
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
