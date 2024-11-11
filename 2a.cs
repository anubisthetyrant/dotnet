using System;

namespace EmployeeRecord
{
    abstract class Employee
    {
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        public DateTime HireDate { get; set; }
        public abstract void DisplayEmployeeDetails();
    }

    class FullTimeEmployee : Employee
    {
        public double Salary { get; set; }
        public override void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Hire Date: {HireDate.ToShortDateString()}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }

    class PartTimeEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }
        public override void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Hire Date: {HireDate.ToShortDateString()}");
            Console.WriteLine($"Hourly Rate: {HourlyRate}");
            Console.WriteLine($"Hours Worked: {HoursWorked}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the type of employee:");
            Console.WriteLine("1. Full-time Employee");
            Console.WriteLine("2. Part-time Employee");
            Console.Write("Enter your choice (1-2): ");
            int choice = (int)Convert.ToInt64(Console.ReadLine());

            Employee employee;

            switch (choice)
            {
                case 1:
                    employee = new FullTimeEmployee();
                    Console.Write("Enter the name of the full-time employee: ");
                    employee.Name = Console.ReadLine();
                    Console.Write("Enter the employee ID of the full-time employee: ");
                    employee.EmployeeId = (int) Convert.ToInt64(Console.ReadLine());
                    Console.Write("Enter the hire date of the full-time employee (yyyy-mm-dd): ");
                    employee.HireDate = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Enter the salary of the full-time employee: ");
                    ((FullTimeEmployee)employee).Salary = Convert.ToDouble(Console.ReadLine());
                    break;

                case 2:
                    employee = new PartTimeEmployee();
                    Console.Write("Enter the name of the part-time employee: ");
                    employee.Name = Console.ReadLine();
                    Console.Write("Enter the employee ID of the part-time employee: ");
                    employee.EmployeeId = (int) Convert.ToInt64(Console.ReadLine());
                    Console.Write("Enter the hire date of the part-time employee (yyyy-mm-dd): ");
                    employee.HireDate = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Enter the hourly rate of the part-time employee: ");
                    ((PartTimeEmployee)employee).HourlyRate = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the hours worked by the part-time employee: ");
                    ((PartTimeEmployee)employee).HoursWorked = (int)Convert.ToInt64(Console.ReadLine());
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            Console.WriteLine("\nEmployee Details:");
            employee.DisplayEmployeeDetails();
        }
    }
}
