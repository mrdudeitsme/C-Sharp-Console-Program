// using System;

// namespace DelegatesInCsharp
// {
//     public delegate void Calculation(int a, int b);
//     class Calculator
//     {
//         public static void Addition(int a, int b)
//         {
//             int result = a + b;
//             Console.WriteLine("Addition is:{0}",result);
//         }
//         public static void Sub(int a, int b)
//         {
//             int result = a - b;
//             Console.WriteLine("Sub is:{0}",result);
//         }
//         public static void Multiplication(int a, int b)
//         {
//             int result = a * b;
//             Console.WriteLine("Multiplication is:{0}",result);
//         }
//         public static void Division(int a, int b)
//         {
//             int result = a / b;
//             Console.WriteLine("Division is:{0}",result);
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Calculation obj = new Calculation(Calculator.Addition);
//             obj.Invoke(10,20);

//             Calculation obj1 = new Calculation(Calculator.Sub);
//             obj1.Invoke(20,10);

//             Calculation obj2 = new Calculation(Calculator.Multiplication);
//             obj2.Invoke(20,10);

//             Calculation obj3 = new Calculation(Calculator.Division);
//             obj3.Invoke(20,10);







//         }
//     }
// }

//-----------------------------Multiple Delegate-----------------------

// using System;

// namespace DelegatesInCsharp
// using System;
// {
//     Multiple Delegates
//     public delegate void Calculation(int a, int b);
//     public delegate void Show_Delegate();
//     public delegate void SquareCube(int num);

//     class Calculator
//     {
//         public static void Addition(int a, int b)
//         {
//             int result = a + b;
//             Console.WriteLine("Addition is:{0}",result);
//         }
//         public static void Show()
//         {
//             Console.WriteLine("This is show method");
//         }
//         public static void Square(int num)
//         {
//             int square = num * num;
//             Console.WriteLine("Square is :{0},{1}",num,square);
//         }
//         public static void Cube(int num)
//         {
//             int cube = num * num * num;
//             Console.WriteLine("Cube is:{0},{1}",num,cube);
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Calculation obj1 = new Calculation(Calculator.Addition);
//             obj1.Invoke(10,20);

//             Show_Delegate obj2 = new Show_Delegate(Calculator.Show);
//             obj2.Invoke();

//             SquareCube obj3 = new SquareCube(Calculator.Square);
//             obj3.Invoke(2);
//             obj3 = Calculator.Cube;
//             obj3.Invoke(3);
//         }
//     }
// }

//-----------------Single Cast Delegate---------------

// using System;
// namespace DelegatesInCsharp
// {
    //Single Cast Delegates
//     public delegate void Calculation(int a, int b);
//     class Calculator
//     {
//         public static void Addition(int a, int b)
//         {
//             int result = a + b;
//             Console.WriteLine("Addition is:{0}",result);
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Calculation obj1 = new Calculation(Calculator.Addition);
//             obj1.Invoke(10,20);
//         }
//     }
// }

//----------------------Multi Cast Delegate----------------------------------

using System;

namespace DelegatesInCsharp
{
    public delegate void Calculation(int a, int b);
    class Calculator
    {
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition is:{0}",result);
        }
        public static void Sub(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Sub is:{0}",result);
        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication is:{0}",result);
        }
        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division is:{0}",result);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Calculator.Addition);
            
//---------------Using += Asingment Operator-------------------

            obj += Calculator.Sub;
            obj += Calculator.Multiplication;
            obj += Calculator.Division;
            obj.Invoke(4,2);

//---------------Using -= Asingment Operator-------------------
            obj -= Calculator.Sub;
            obj -= Calculator.Multiplication;
            obj -= Calculator.Division;
            obj.Invoke(4,2);

//---------------Single object refrence varible invokes all methods presents in main method----------
            // obj = Calculator.Sub;
            // obj.Invoke(20,10);
            // obj = Calculator.Multiplication;
            // obj.Invoke(5,2);
            // obj = Calculator.Division;
            // obj.Invoke(10,5);
        }
    }
}
