namespace MvvmLightNet462.ViewModels
{
    using GalaSoft.MvvmLight;

    public class EmployeeViewModel : ViewModelBase
    {
        private string _name;
        private int _age;

        public string Name
        {
            get { return _name; }
            set { Set(ref _name, value); }
        }

        public int Age
        {
            get { return _age; }
            set { Set(ref _age, value); }
        }
    }
}
