using System;

namespace Task_6_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var department = GetCurrentDepartment();
        }
        static Department GetCurrentDepartment()
        {
            Department new_dep = new Department { Company = new Company { Type = "Банк"}, City = new City { Name = "Санкт-Петербург" } };
            Console.WriteLine("У банка {0} есть отделение в {1}е", new_dep.Company.Name ?? "Неизвестный", new_dep.City.Name );
            return new_dep;
        }
        class Company
        {
            public string Type;
            public string Name;
        }

        class Department
        {
            public Company Company;
            public City City;
        }

        class City
        {
            public string Name;
        }
    }
    
}
