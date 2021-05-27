using System;

namespace RestartProgram
{
    class Program
    {

        static void Main(string[] args)
        {

// -------------------- Using do...while loop--------------//

            string confirm;
            do
            {
                Console.WriteLine("Enter a number");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a number");
                int num2 = int.Parse(Console.ReadLine());

                int add = num1 + num2;
                Console.WriteLine("Your addition is :" + add);

                Console.WriteLine("Do you wants to repeat ur program");
                confirm = Console.ReadLine().ToLower();
            }
            while(confirm == "yes");

// -------------------using while loop--------------------//

//             string confirm;
//             while(true)
//             {
//                 Console.WriteLine("Enter a number");
//                 int num1 = int.Parse(Console.ReadLine());

//                 Console.WriteLine("Enter a number");
//                 int num2 = int.Parse(Console.ReadLine());

//                 int add = num1 + num2;
//                 Console.WriteLine("Your addition is :" + add);

//                 Console.WriteLine("Do you wants to repeat ur program");
//                 confirm = Console.ReadLine().ToLower();

//                 if(confirm == "yes")
//                 {
//                     continue;
//                 }
//                 else
//                 {
//                     break;
//                 }
//             }


        }
    }
}
