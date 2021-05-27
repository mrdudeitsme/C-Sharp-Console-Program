// using System;
// namespace InterfacesInCsharp
// {
//     interface IEmployee

//     {
//      void show();

//     }
//     class PartTimeEmp : IEmployee
//     {
//         public void show()
//         {
//             Console.WriteLine("This is Interface Method");
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             PartTimeEmp Emp = new PartTimeEmp();
//             Emp.show();
//         }
//     }
// }
//---------------------------Inheritance of interface  -----------------------------------
// using System;

// namespace InterfacesInCsharp
// {
//     interface IPerson
//     {
//         void ShowName();
//     }

//     interface IPerson1
//     {
//         void ShowName1();
//     }

//     interface IPerson2 : IPerson, IPerson1
//     {
//         void ShowName2();
//     }

//     class ShowPName : IPerson2
//     {
//         void ShowName()
//         {
//             Console.WriteLine("This is Show Method");
//         }

//         void ShowName1()
//         {
//             Console.WriteLine("This is Show 1 method");
//         }

//         void ShowName2()
//         {
//             Console.WriteLine("This is Show 2 method");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Instantiate object using Child Class
//             ShowPName Emp = new ShowPName();
//             Emp.ShowName();
//             Emp.ShowName1();
//             Emp.ShowName2();

//             Instantiate object using interface parent class
//             IPerson2 myInterface = new ShowPName();
//             myInterface.ShowName1();
//         }
//     }
// }

//-------------------- Implicit and Explicit Conversion --------------------------------------


using System;

namespace InterfacesInCsharp
{
    interface IPerson1
    {
        void ShowName1();
    }

    class ShowPName : IPerson1 //Inherit both interface
    {
        public void ShowName() //Implicit Interface method
        {
            Console.WriteLine("This is 1st method");
        }

        void IPerson1.ShowName1() //Explicit Interface method
        {
            Console.WriteLine("This is Method 2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ShowPName Emp = new ShowPName();//Implicit Interface
            Emp.ShowName();

            ((IPerson1)Emp).ShowName1(); //Explicit Interface Call by casting Parent class refrence variable with interface
        }
    }
}




