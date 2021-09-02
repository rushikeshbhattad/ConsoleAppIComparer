using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleAppIComparer
{
    class EmployeeComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Salary-y.Salary;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            int n, empSalary;
            string empName;
            List<Employee> lst = new List<Employee>();
            Console.WriteLine("Enter number of employees");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter name of employee {0}: ", i + 1);
                empName = Console.ReadLine();
                Console.Write("Enter Salary of employee {0}: ", i + 1);
                empSalary = Convert.ToInt32(Console.ReadLine());
                lst.Add(new Employee { Name = empName, Salary = empSalary });
            }
            lst.Sort(new EmployeeComparer());
            foreach (var i in lst)
            {
                Console.WriteLine(i);
            }
                Console.ReadKey();
        }
                
    }

    internal class Employee
    {
        public string Name { get; set; }

        public int Salary { get; set; }

        public override string ToString()
        {
            return this.Name + "\t" + this.Salary;
        }
    }
}
