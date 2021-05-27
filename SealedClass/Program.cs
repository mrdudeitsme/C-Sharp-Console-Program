//Sealed class

// using System;

// namespace SealedClass
// {
//     class parent
//     {
//         public void show1()
//         {
//             Console.WriteLine("Parent Method");
//         }
//     }
//     class derived : parent
//     {
//         public void show2()
//         {
//             Console.WriteLine("Child Method");
//         }
//     }
        
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             derived dc = new derived();
//             dc.show1();
//         }
//     }
// }

//Sealed Method 

using System;

namespace Sealed 
{
    class A
    {
        public virtual void show()
        {
            Console.WriteLine("Parent Class Method");
        }
    }
    class B : A
    {
        public sealed override void show() // we cannot override inherited member because it is sealed...
        {
            Console.WriteLine("Child class method");
        }
    }
    class C : B
    {
        public override void show()
        {
            Console.WriteLine("2nd Child class Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C dd = new C();
            dd.show();
        }
    }
}
