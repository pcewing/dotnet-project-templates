namespace WpfTrayApp462.ViewModels
{
    using GalaSoft.MvvmLight.Ioc;
    using CommonServiceLocator;
    using Services;
    using Services.Concrete;

    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<IEmployeeService, EmployeeService>();

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<TrayIconViewModel>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public TrayIconViewModel TrayIcon => ServiceLocator.Current.GetInstance<TrayIconViewModel>();

        public static void Cleanup()
        {
        }
    }
}