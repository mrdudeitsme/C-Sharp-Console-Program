using System;

namespace RoleOfConstInheritance
{
    class BaseClass
    {
        public BaseClass(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    class DerivedClass : BaseClass
    {
        public DerivedClass() : base("Hello C Sharp")
        {
            Console.WriteLine("This is Derived Class constructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dd = new DerivedClass();
        }
    }
}
