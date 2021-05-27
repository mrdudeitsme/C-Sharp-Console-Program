// using System;
// namespace calc
// {
//     class Program
//     {
//         public static void Add(int a, int b)
//         {
//             int result = a + b;
//             Console.WriteLine("Addition is : {0}",result);

//         }
//         public static void Sub(int a, int b)
//         {
//             int result = a - b;
//             Console.WriteLine("Subtraction is : {0}",result);

//         }
//         public static void Div(int a, int b)
//         {
//             int result = a / b;
//             Console.WriteLine("Division is : {0}",result);

//         }
//         public static void Mul(int a, int b)
//         {
//             int result = a * b;
//             Console.WriteLine("MUltiplication is : {0}",result);

//         }
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter First Number");
//             int num1 = int.Parse(Console.ReadLine());

//             Console.WriteLine("Enter your second number");
//             int num2 = int.Parse(Console.ReadLine());

//             Console.WriteLine("Select Operation +,-,*,/");
//             string op = Console.ReadLine();

//             switch (op)
//             {
//                 case "+" :

//                 Program.Add(num1,num2);
//                 break;

//                 case "-" :
//                 Program.Sub(num1,num2);
//                 break;

//                 case "*" :
//                 Program.Mul(num1,num2);
//                 break;

//                 case "/" :
//                 Program.Div(num1,num2);
//                 break;

//                 default:
//                 Console.WriteLine("Invalid Operator");
//                 break;
//             }
//         }
//     }
// }

// using System;
// namespace Calc
// {
//     class Calculator
//     {
//         public static void Add(int a , int b)
//         {
//             int result = a+b;
//             Console.WriteLine("Addition is:{0}",result);
//         }
//         public static void Sub(int a, int b)
//         {
//             int result = a - b;
//             Console.WriteLine("Subtraction is:{0}",result);
//         }
//         public static void Mul(int a , int b)
//         {
//             int result = a*b;
//             Console.WriteLine("Multiplication is:{0}",result);
//         }
//         public static void Div(int a,int b)
//         {
//             int result = a/b;
//             Console.WriteLine("Division is:{0}",result);
//         }
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter fisrt number:");
//             int num1 = int.Parse(Console.ReadLine());

//             Console.WriteLine("Enter second number:");
//             int num2 = int.Parse(Console.ReadLine());

//             Console.WriteLine("Enter Operator - +,-,*,/:");
//             string op = Console.ReadLine();

//             if (op=="+")
//             {
//                 Calculator.Add(num1,num2);
//             }
//             else if(op=="-")
//             {
//                 Calculator.Sub(num1,num2);
//             }
//             else if(op=="*")
//             {
//                 Calculator.Mul(num1,num2);
//             }
//             else if(op=="/")
//             {
//                 Calculator.Div(num1,num2);
//             }
//             else
//             {
//                 Console.WriteLine("Invalid operator");
//             }
//         }
//     }
// }
using System;

namespace Calc
{
    class Calculator
    {
        public static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition is : {0}", result);
        }
        public static void Sub(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction is : {0}", result);
        }
        public static void Mul(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication is : {0}", result);
        }
        public static void Div(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division is : {0}", result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Fnumber: ");
            int fnum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Snumber: ");
            int snum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter operator /,*,+,-,+: ");
            string op = Console.ReadLine();

            if (op == "+")
            {
                Calculator.Add(fnum, snum);
            }
            else if (op == "-")
            {
                Calculator.Sub(fnum, snum);
            }
            else if (op == "*")
            {
                Calculator.Mul(fnum, snum);
            }
            else if (op == "/")
            {
                Calculator.Div(fnum, snum);
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }
        }
    }
}