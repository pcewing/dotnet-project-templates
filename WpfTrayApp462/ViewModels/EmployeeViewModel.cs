namespace WpfTrayApp462.ViewModels
{
    using GalaSoft.MvvmLight;

    public class EmployeeViewModel : ViewModelBase
    {
        private string _name;
        private int _age;

        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        public int Age
        {
            get => _age;
            set => Set(ref _age, value);
        }
    }
}
