using System;

namespace LambdaExpressionInCsharp
{
    public delegate int MyDelegate(int num);
    class Program
    {
        // public static int Show(int a)
        // {
        //     a+=10;
        //     return a;
        //     Console.WriteLine(a);
        // }
        static void Main(string[] args)
        {
            //statement lambda

            // MyDelegate obj = (a) =>
            // {
            //     a+=10;
            //     Console.WriteLine(a);
            // };
            // obj.Invoke(5);

            //Expression lambda 
            MyDelegate obj = (a) => a * a;
            Console.WriteLine(obj.Invoke(5));

            
        }
    }
}
