namespace MvvmLightNet462.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Linq;

    using GalaSoft.MvvmLight;

    using Services;

    public class MainViewModel : ViewModelBase
    {
        private readonly IEmployeeService _employeeService;

        public MainViewModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;

            var employees = _employeeService
                .GetEmployees()
                .Select(employee => new EmployeeViewModel
                {
                    Name = employee.Name,
                    Age = employee.Age
                });

            Employees = new ObservableCollection<EmployeeViewModel>(employees);
        }

        public ObservableCollection<EmployeeViewModel> Employees { get; set; }
    }
}