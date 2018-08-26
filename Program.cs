using System;
using System.Collections.Generic;

namespace classes
{
    public class Employee
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

    }
    public class Company
    {

        public DateTime FoundingDate { get; set; }
        public string CompanyName { get; set; }
        public List<Employee> Employees = new List<Employee>();
        public void ListEmployees()
        {

            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.Title}");
            }
        }


    }

    class Program
    {
        static void Main(string[] args)

        {
            Company EmilyInc = new Company()
            {
                FoundingDate = DateTime.Now,
                CompanyName = "Emily Inc"
            };

            Employee Asa = new Employee()
            {
                FirstName = "Asa",
                LastName = "Hartley",
                Title = "Head Developer",
                StartDate = DateTime.Now,
            };

            Employee Tim = new Employee()
            {
                FirstName = "Tim",
                LastName = "Edwards",
                Title = "Junior Developer",
                StartDate = DateTime.Now,
            };

            Employee Alexa = new Employee()
            {
                FirstName = "Alexa",
                LastName = "Xystra",
                Title = "Junior Developer",
                StartDate = DateTime.Now,
            };

            EmilyInc.Employees.Add(Asa);
            EmilyInc.Employees.Add(Tim);
            EmilyInc.Employees.Add(Alexa);

            EmilyInc.ListEmployees();
        }
    }
}