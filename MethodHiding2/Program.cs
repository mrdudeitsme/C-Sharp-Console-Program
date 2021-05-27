using System;

namespace MethodHidings
{
    class Employee
    {
        public string fName;
        public string lName;

        public void PrintFullName()
        {
            Console.WriteLine(fName +  " " + lName);
        }
    }
    class PartTimeEmp : Employee
    {
        public new void PrintFullName()
        {
            //base.PrintFullName();
            Console.WriteLine(fName + " " + lName + " PTE");
        }

    }
    class FullTimeEmp : Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine(fName + " " + lName + "FTE");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Employee Emp = new PartTimeEmp();

            PartTimeEmp PTE = new PartTimeEmp();
            PTE.fName = "Sahil";
            PTE.lName = "Dudwadkar";
            // Emp.fName = "Sahil";
            // Emp.lName = "Dudwadkar";
            // Emp.PrintFullName();

            //((Employee)PTE).PrintFullName();
            PTE.PrintFullName();
        }
    }
}
