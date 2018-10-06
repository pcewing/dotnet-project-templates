namespace WpfTrayApp462.Services.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    // ReSharper disable once ClassNeverInstantiated.Global
    public class EmployeeService : IEmployeeService
    {
        private static readonly IEnumerable<string> EmployeeNames = new List<string>
        {
            "Verdell Wanke", "Yoko Kincade", "Eustolia Oliva", "Janeen Colbert",
            "Reina Libbey", "Sharmaine Willcox", "Marianna Palka", "Lurlene Heiss",
            "Edyth Alles", "Eddy Sizemore", "Shanti Dagley", "Peggy Ulmer",
            "Leighann Poindexter", "Margarete Cebula", "Eleanor Belanger", "Caroll Tsang",
            "Robbi Hoglund", "Kum Naquin", "Vivien Chau", "Tova Maye",
            "George Berns", "Laurena Ardis", "Queen Manser", "Eli Alcott",
            "Alexandra Futral", "Doretta Ethier", "Else Amezquita", "Antoine Cowling",
            "Vincenzo Zeller", "Theola Heater"
        };

        public IEnumerable<Employee> GetEmployees()
        {
            var random = new Random(DateTime.Now.Millisecond);

            return EmployeeNames.Select(name => new Employee
            {
                Name = name,
                Age = random.Next(20, 50)
            });
        }
    }
}
