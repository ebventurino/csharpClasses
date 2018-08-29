using System;
using System.Collections.Generic;

namespace classes
{
    // creating a public class
    public class Employee
    {
        // getting and setting shorthand, setting up for code below?
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

    }
    // creating class company
    public class Company
    {

        // getting and setting shorthand, setting up for code below??
        public DateTime FoundingDate { get; set; }
        public string CompanyName { get; set; }
        public List<Employee> Employees = new List<Employee>();
        public void ListEmployees()
        {

            // looping through employee list, console logging their info
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.Title}");
            }
        }


    }

    // creating class program
    class Program
    {
        // this is rendering the main code 
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

            // adding all employees to the employee class
            EmilyInc.Employees.Add(Asa);
            EmilyInc.Employees.Add(Tim);
            EmilyInc.Employees.Add(Alexa);

            EmilyInc.ListEmployees();
        }
    }
}