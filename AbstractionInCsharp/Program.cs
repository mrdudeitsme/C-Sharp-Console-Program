// using System;

// namespace AbstractionInCsharp
// {
//     class Employee
//     {
//         member veriable
//         public int EmpId;
//         public string EmpName;
//         public double GrossSalary;
//         double TaxDeduction = 0.1;
//         double NetSalary;

//         set members in constructor 
//         public Employee(int empId, string empName, double grossSalary)
//         {
//             this.EmpId = empId;
//             this.EmpName = empName;
//             this.GrossSalary = grossSalary;
//         }
//         void SalaryCalculate()
//         {
//             if (GrossSalary >= 100000)
//             {
//                 NetSalary = GrossSalary - (TaxDeduction * GrossSalary);
//                 Console.WriteLine("Your Net Salary is :{0}",NetSalary);
//             }
//             else
//             {
//                 Console.WriteLine("Your Net Salary is :{0}",GrossSalary);
//             }
//         }
//         public void ShowEmpDetails()
//         {
//             this.SalaryCalculate();
//             Console.WriteLine("Employee ID is :{0}",this.EmpId);
//             Console.WriteLine("Employee Name is :{0}",this.EmpName);
//             Console.WriteLine("Employee Gross Salary is :{0}",this.GrossSalary);
//             Console.WriteLine("Your Net Salary is :{0}",NetSalary);


//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Employee Sahil = new Employee(7008, "Sahil Dudwadkar", 200000);
//             Sahil.ShowEmpDetails();
//         }
//     }
// }


using System;

namespace AbstractionInCsharp
{
    class Employee
    {
       public int EmpID;
       public string EmpName;
       public double GrossSalary;
       double TaxDeduction = 0.5;
       double NetSalary;

       public Employee(int empId, string empName, double grossSalary)
       {
           this.EmpID = empId;
           this.EmpName = empName;
           this.GrossSalary = grossSalary;
       }
       void CalculateSalary()
       {
           if(GrossSalary >= 100000)
           {
               NetSalary = GrossSalary - (TaxDeduction * GrossSalary);
               Console.WriteLine("Your Net Salary is :{0}",NetSalary);
           }
           else
           {
               
           }
       }
       public void EmployeeNetSalary()
       {
           this.CalculateSalary();
           Console.WriteLine("Employee Id is :{0}",this.EmpID);
           Console.WriteLine("Employee Name is :{0}",this.EmpName);
           Console.WriteLine("Your Gross Salary is :{0}",this.GrossSalary);
       }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Employee Sahil = new Employee(33, "Sahil Dudwadkar",20000);
           Sahil.EmployeeNetSalary();
        }
    }
}
