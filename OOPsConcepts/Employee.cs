using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsConcepts
{
    class Employee
    {
        int id;
        string name;
        string dept;
        int salary;
        public void GetDetails()
        {
            Console.WriteLine("Enter ID");
            id = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter dept");
            dept = Console.ReadLine();
            Console.WriteLine("Enter salary");
            salary = Int16.Parse(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"ID is {id}\nName is {name} \nDept is {dept}\nSalary is {salary}");
        }
    }
}
