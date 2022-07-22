﻿using WiredBrainCoffee.StorageApp.Data;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;

namespace WiredBrainCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext());
            AddEmployees(employeeRepository);
            GetEmployeeById(employeeRepository);

            var organizationRepository = new ListRepository<Organization>();
            AddOrganizations(organizationRepository);
        }

        private static void GetEmployeeById(SqlRepository<Employee> employeeRepository)
        {
            var employee = employeeRepository.GetById(1);
            Console.WriteLine(employee.ToString());
        }

        private static void AddEmployees(SqlRepository<Employee> employeeRepository)
        {
            Console.WriteLine("\nEmployees:\n");

            employeeRepository.Add(new Employee { FirstName = "Polycarp", Id = 1 });
            employeeRepository.Add(new Employee { FirstName = "Peterson", Id = 2 });
            employeeRepository.Add(new Employee { FirstName = "Rodgers", Id = 3 });
            employeeRepository.Add(new Employee { FirstName = "Duncan", Id = 4 });
            employeeRepository.Add(new Employee { FirstName = "Shirly", Id = 5 });

            employeeRepository.Save();
        }

        private static void AddOrganizations(ListRepository<Organization> organizationRepository)
        {
            Console.WriteLine("\nOrganizations:\n");

            organizationRepository.Add(new Organization { Name = "Telemetrics", Id = 1 });
            organizationRepository.Add(new Organization { Name = "Amazon", Id = 2 });
            organizationRepository.Add(new Organization { Name = "Commenius", Id = 3 });
            organizationRepository.Add(new Organization { Name = "Ruzinovska", Id = 4 });
            organizationRepository.Add(new Organization { Name = "Financier", Id = 5 });

            organizationRepository.Save();
        }
    }
}