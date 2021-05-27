// using System;
// namespace AnonymousFuntionCsharp
// {
//     public delegate void MyDelegate(int num);
//     class Program
//     {
      // public static void MyMethod(int a)
// {
//     a += 10;
//     Console.WriteLine(a);
// }
//         static void Main(string[] args)
//         {
//Anonymous Function

// DeleagateName Refrence Variable = Delegate Keyword (Parameter)
//             MyDelegate obj = delegate (int a)
//             {
//                 a += 10;
//                 Console.WriteLine(a);
//             };
//             obj.Invoke(5);
//         }
//     }
// }
//----------Also we can send Anonymous Function as a parameter

using System;

namespace AnonymousFuntionCsharp
{
    public delegate void MyDelegate(int num);
    class Program
    {
        public static void ShowDelegate(MyDelegate del, int a)
            {
                a += 10;
                del.Invoke(a);  
            }
        static void Main(string[] args)
        {
            Program.ShowDelegate(delegate(int b){ b += 10; Console.WriteLine (b);},5);
        }
    }
}
