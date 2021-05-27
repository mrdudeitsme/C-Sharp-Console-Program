// // Parameterized Constructor

// using System;
// namespace CSharpConstructor 
// {
//     class Employee
//     {
//         int Empid;
//         string Empname;
//         int Empage;

//         public Employee (int Empid, string Empname, int Empage)
//         {
//             this.Empid = Empid;
//             this.Empname = Empname;
//             this.Empage = Empage;
//         }

//         public int GetEmpid()
//         {
//             return this.Empid;
//         }
//         public string GetEmpname()
//         {
//             return this.Empname;
//         }
//         public int GetEmpage()
//         {
//             return this.Empage;
//         }
//         static void Main(string[] args)
//         {
//             Employee Sahil = new Employee(11,"Sahil",25);
//             Console.WriteLine("Employee id is:{0}",Sahil.GetEmpid());
//             Console.WriteLine("Employee name is:{0}",Sahil.GetEmpname());
//             Console.WriteLine("Employee age is:{0}",Sahil.GetEmpage());
//         }
//     }
// }

//----------------------- Parameterized Constructor with user input---------------------------//

// using System;
// namespace ConstructorInCsharp
// {
//     class Employees
//     {
//         int Empid;
//         string EmpName;
//         int EmpAge;

//         public Employees(int Empid, string EmpName,int EmpAge)
//         {
//             this.Empid = Empid;
//             this.EmpName = EmpName;
//             this.EmpAge = EmpAge;
//         }
//         public void GetEmp()
//         {
//             Console.WriteLine("Employee id is: {0}",this.Empid);
//             Console.WriteLine("Employee name is: {0}",this.EmpName);
//             Console.WriteLine("Employee age is: {0}",this.EmpAge);
//         }
        
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter Employee id :");
//             int Empid = int.Parse(Console.ReadLine());

//             Console.WriteLine("Enter Employee Name :");
//             string EmpName = Console.ReadLine();

//             Console.WriteLine("Enter Employee Age :");
//             int EmpAge = int.Parse(Console.ReadLine());

//             Employees Sahil = new Employees(Empid,EmpName,EmpAge);
//             Sahil.GetEmp();
//         }
//     }
// }

// <<------------------- Constructor Overlading ------------------------------>>

// using System;
// namespace ConstructorOverloads
// {
//     class Example
//     {
//         public Example()
//         {
//             Console.WriteLine("First Constructor");
//         }
//         public Example(int a, int b)
//         {
//             Console.WriteLine("Second Constructor: {0}",(a+b));
//         }
//         public Example(int a, int b, int c)
//         {
//             Console.WriteLine("Third Constructor: {0}", (a+b+c));
//         }
//         static void Main(string[] args)
//         {
//             Example obj = new Example(10,20,40);
//         }
//     }
// }

//Static and Instance Members of class

