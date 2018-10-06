namespace WpfTrayApp462.Services.Concrete
{
    using System;
    using System.Windows;

    // ReSharper disable once ClassNeverInstantiated.Global
    public class WindowService : IWindowService
    {
        private static MainWindow _mainWindow;
        
        public void ShowMainWindow()
        {
            if (_mainWindow == null)
            {
                _mainWindow = Application.Current.MainWindow as MainWindow;
            }

            if (_mainWindow == null)
            {
                throw new Exception("Failed to obtain main window handle");
            }

            Application.Current.Dispatcher.Invoke(() => { _mainWindow.Visibility = Visibility.Visible; });
        }
    }
}