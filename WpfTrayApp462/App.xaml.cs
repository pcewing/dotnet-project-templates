namespace WpfTrayApp462
{
    using GalaSoft.MvvmLight.Threading;

    public partial class App
    {
        static App()
        {
            DispatcherHelper.Initialize();
        }
    }
}
