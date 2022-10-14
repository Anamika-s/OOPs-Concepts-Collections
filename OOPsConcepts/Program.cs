using System;
using System.Collections.Generic;
namespace OOPsConcepts
{
    class Program
    {
        static void Main(string[] args)
        {// Declaration
         //Employee employee;
         //employee = new Employee();

            //Employee employee = new Employee();
            //employee.GetDetails();
            //employee.DisplayDetails();
            //Employee employee1 = new Employee();
            //employee1.GetDetails();
            //employee1.DisplayDetails();
            //Employee employee2 = new Employee();
            //employee2.GetDetails();
            //employee2.DisplayDetails();
            //Employee employee3 = new Employee();
            //employee3.GetDetails();
            //employee3.DisplayDetails();

            // Array of Objects
            Employee[] employees = new Employee[10];



            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"ENter Details of Employee No {i + 1}");
                employees[i] = new Employee();
                employees[i].GetDetails();
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Details of Employee No {i + 1}");
                employees[i].DisplayDetails();
            }

        }
        // List of Employee Objects




    }
    }

