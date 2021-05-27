// using System;
// namespace IndexersInCsharp
// {
//     class Employee
//     {
//         private int[] Age = new int[3]
//         public int this[int index]
//         {
//             set
//             {
//                 if (index >= 0 && index < Age.Length)
//                 {
//                     if (value > 0)
//                     {
//                         Age[index] = value;
//                     }
//                     else
//                     {
//                         Console.WriteLine("Invalid Age");
//                     }
//                 }
//                 else
//                 {
//                     Console.WriteLine("You did not enter proper index");
//                 }
//             }
//             get
//             {
//                 return Age[index];
//             }
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Employee emp = new Employee();
//             this keyword replace with object refrence variable..
//             emp[0] = 10;
//             Console.WriteLine(emp[0]);
//         }
//     }
// }
//-----------------------------------Indexer Overloading
using System;

namespace IndexersInCsharp
{
    class Employee
    {
        private int[] Age = new int[3];

        public int this[int index, int i]
        {
            set
            {
                {
                    Age[index] = value + i;
                }
            }
            get
            {
                return Age[index];
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            //this keyword replace with object refrence variable..
            emp[0, 1] = 10;
            Console.WriteLine(emp[0]);
        }
    }
    
}
