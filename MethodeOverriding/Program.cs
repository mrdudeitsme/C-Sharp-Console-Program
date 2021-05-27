using System;

//Method Methode Overriding with virtual and override method

namespace MethodeOverriding
{
    class Parent 
    {
        public virtual void show()
        {
            Console.WriteLine("Parent class method");
        }
    }
    class Child : Parent
    {
        public override void show()
        {
            Console.WriteLine("Child class method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        Parent p  = new Child();
        p.show();
        }
    }
}
