// using System;

// <<<<<<<<<--------Static & Instance Member Functions------------->>>>>>>>>>>

// namespace StatiAndInstance
// {
//     class Student
//     {
//         public int RollNo;
//         public string Fname;
//         public string Lname;
//         public string Standerd;
//         public static string ClgName = "Walington University";
//         public static int fees = 3000;
        
//         public void PrintFullName()
//         {
//             string fullname = this.Fname + " " + this.Lname;
//             Console.WriteLine("Your Full Name is :{0}",fullname);
//         }
//         public static int GetFees()
//         {
//             return fees;
//         }
//         public static int AnnualIncrement(int fee)
//         {
//             return fee/10;
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Student sahil = new Student();
            
//             sahil.RollNo = 23;
//             sahil.Fname = "Sahil";
//             sahil.Lname = "Dudwadkar";
//             sahil.Standerd = "MSC";

//             Student siddesh = new Student();
//             siddesh.RollNo = 24;
//             siddesh.Fname = "Siddesh";
//             siddesh.Lname = "Talekar";
//             siddesh.Standerd = "BSC&Diploma";

//             Console.WriteLine("Student Roll No - :{0}",sahil.RollNo);
//             Console.WriteLine("First Name - :{0}",sahil.Fname);
//             Console.WriteLine("Last Name - :{0}",sahil.Lname);
//             Console.WriteLine("Standard is - :{0}",sahil.Standerd);
//             sahil.PrintFullName();
//             Console.WriteLine("College Name is :{0}",Student.ClgName);
//             Console.WriteLine("Student fees is :{0}",Student.GetFees());
//             Console.WriteLine("College Anually Increment fees by 10% :{0}",Student.AnnualIncrement(3000));
            

//             Console.WriteLine("-----------------------------------");

//             Console.WriteLine("Student Roll No - :{0}",siddesh.RollNo);
//             Console.WriteLine("First Name - :{0}",siddesh.Fname);
//             Console.WriteLine("Last Name - :{0}",siddesh.Lname);
//             Console.WriteLine("Standard is - :{0}",siddesh.Standerd);
//             siddesh.PrintFullName();
//             Console.WriteLine("College Name is :{0}",Student.ClgName);
//             Console.WriteLine("Student fees is :{0}",Student.GetFees());
//             Console.WriteLine("College Anually Increment fees by 10% :{0}",Student.AnnualIncrement(5000));

//         }
//     }
// }

//<<<<<<<<<<<<<<<<<<--------------------Static Constructor ------------------>>>>>>>>>>>>>>>
// using System;
// namespace StaticConstructorInCsharp
// {
//     class Person
//     {
//         public static string PersonName;
//         public static int PersonAge;

//         static Person()
//         {
//             PersonName = "Sahil";
//             PersonAge = 23;
//             Console.WriteLine("Static Constructor Invokes");
//         }
//         public static void GetDetails()
//         {
//             Console.WriteLine("Person Name is :{0}",PersonName);
//             Console.WriteLine("Person Age is :{0}",PersonAge);
//         }
//         public Person()
//         {
//             Console.WriteLine("Default Constructor invokes");
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//          Person p = new Person();   
//         }
//     }
    
// }

//<<<<<<<<<<<<<----------------------------Copy Constructor------------------------>>>>>>>>>>>>

using System;
namespace StaticConstructorInCsharp
{
    class Example
    {
        string Name;
        int Age;

        public Example(string Name,int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public Example(Example e)
        {
            this.Name = e.Name;
            this.Age = e.Age;
        }
        public void GetData()
        {
            Console.WriteLine("Name is :{0}",Name);
            Console.WriteLine("Age is :{0}",Age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Example obj = new Example("sahil",24);
            obj.GetData();
            Example obj1 = new Example(obj);
            obj1.GetData();
        }
    }
    
}