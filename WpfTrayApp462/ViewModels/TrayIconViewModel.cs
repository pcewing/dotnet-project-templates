namespace WpfTrayApp462.ViewModels
{
    using System.Windows.Input;
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Command;
    using Services;

    // ReSharper disable once ClassNeverInstantiated.Global
    public class TrayIconViewModel : ViewModelBase
    {
        private readonly IWindowService _windowService;
        
        public TrayIconViewModel(IWindowService windowService)
        {
            _windowService = windowService;
        }
        
        public ICommand ShowWindowCommand => new RelayCommand(ShowWindow);

        private void ShowWindow()
        {
            _windowService.ShowMainWindow();
        }
    }
}