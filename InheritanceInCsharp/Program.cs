using System;

namespace InheritanceInCsharp
{
    class VisitingEmployee : Employee
    {
        public long VisitingEmployeeSalary;
        public int VisitingEmployeeHours;   
    }
    class PermanantEmployee : Employee
    {
        public long PermanantEmployeeSalary;
        public int PermanantEmployeeHours;
    }
    class Employee
    {
        public int EmpID;
        public string EmpName;
        public string EmpAddress;
        public long EmpContact;
        public string EmpEmailID;
    }
    class Program
    {
        static void Main(string[] args)
        {
            VisitingEmployee Emp = new VisitingEmployee();
            Emp.EmpID = 12;
            Emp.EmpName = "Sahil";
            Emp.EmpAddress = "943, Lords mentions";
            Emp.EmpContact = 9876543210;
            Emp.EmpEmailID = "sahil.dudwadkar46@gmail.com";
            Emp.VisitingEmployeeHours = 10;
            Emp.VisitingEmployeeSalary = 30000;

            Console.WriteLine(Emp.EmpID);
            Console.WriteLine(Emp.EmpName);
            Console.WriteLine(Emp.EmpAddress);
            Console.WriteLine(Emp.EmpContact);
            Console.WriteLine(Emp.EmpEmailID);
            Console.WriteLine(Emp.VisitingEmployeeHours);
            Console.WriteLine(Emp.VisitingEmployeeSalary);

            Console.WriteLine("---------------------------------------");

            PermanantEmployee Emp2 = new PermanantEmployee();
            Emp2.EmpID = 15;
            Emp2.EmpName = "Sidd";
            Emp2.EmpAddress = "913, Lord5555s mentions";
            Emp2.EmpContact = 9876543212;
            Emp2.EmpEmailID = "sidd.tale@live.com";
            Emp2.PermanantEmployeeHours = 10;
            Emp2.PermanantEmployeeSalary = 50000;

            Console.WriteLine("Employee ID is :{0}",Emp2.EmpID);
            Console.WriteLine("Employee Name is :{0}",Emp2.EmpName);
            Console.WriteLine("Employee Address is :{0}",Emp2.EmpAddress);
            Console.WriteLine("Employee Contact number is :{0}",Emp2.EmpContact);
            Console.WriteLine("Employee EmailID is :{0}",Emp2.EmpEmailID);
            Console.WriteLine("Permanant employee hourse is :{0}",Emp2.PermanantEmployeeHours);
            Console.WriteLine("Permanant employee salary is :{0}",Emp2.PermanantEmployeeSalary);
        }
    }
}
