using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddEmployee
{
    public class Employee
    {
        public string id;
        public string name;

        public Employee()
        {
        }

        public Employee(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        public static int employeeCounter;

        public static int AddEmployee()
        {
            return ++employeeCounter;
        }
    }

    class EmployeeMainClass : Employee
    {
        public static void EmployeeMain()
        {
            Console.Write("Enter the current number of employees: ");
            string n = Console.ReadLine();
            Employee.employeeCounter = Int32.Parse(n);

            Console.Write("Enter the new employee name : ");
            string name = Console.ReadLine();
            Console.Write("Enter the new employee ID   : ");
            string id = Console.ReadLine();
            
            // Create the employee object:
            Employee e = new Employee(name, id);
            Employee.AddEmployee();
            
            // Display the new information:
            Console.WriteLine("Name: {0}", e.name);
            Console.WriteLine("ID:   {0}", e.id);
            Console.WriteLine("New Number of Employees: {0}",
                               Employee.employeeCounter);
            Console.Write("Press the Enter key: ");
            Console.ReadLine();
        }
    }
}
