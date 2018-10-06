namespace WpfTrayApp462.ViewModels
{
    using System.Diagnostics.CodeAnalysis;
    using GalaSoft.MvvmLight.Ioc;
    using CommonServiceLocator;
    using Services;
    using Services.Concrete;

    [SuppressMessage("ReSharper", "MemberCanBeMadeStatic.Global")]
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<IEmployeeService, EmployeeService>();
            SimpleIoc.Default.Register<IWindowService, WindowService>();

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<TrayIconViewModel>();
        }

        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();
        
        public TrayIconViewModel TrayIcon => ServiceLocator.Current.GetInstance<TrayIconViewModel>();

        public static void Cleanup()
        {
        }
    }
}