namespace WpfTrayApp462.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Windows.Input;
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.CommandWpf;
    using Services;

    // ReSharper disable once ClassNeverInstantiated.Global
    public class MainViewModel : ViewModelBase
    {
        private readonly IEmployeeService _employeeService;

        private ObservableCollection<EmployeeViewModel> _employees;

        public MainViewModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public ObservableCollection<EmployeeViewModel> Employees
        {
            get => _employees;
            set => Set(ref _employees, value);
        }
        
        public ICommand LoadedCommand => new RelayCommand(Loaded);

        private void Loaded()
        {
            var employees = _employeeService
                .GetEmployees()
                .Select(employee => new EmployeeViewModel
                {
                    Name = employee.Name,
                    Age = employee.Age
                });

            Employees = new ObservableCollection<EmployeeViewModel>(employees);
        }
    }
}