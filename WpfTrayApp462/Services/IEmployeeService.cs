namespace WpfTrayApp462.Services
{
    using System.Collections.Generic;
    using Models;

    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();
    }
}
