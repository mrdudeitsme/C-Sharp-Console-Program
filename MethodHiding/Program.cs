using System;

namespace MethodHiding
{
    class Parent
    {
        public void show()
        {
            Console.WriteLine("Parent class method");
        }
    }
    class Child : Parent
    {
        public new void show() //if hiding was intended then used "new" keyword in derived / child class then u will not get warning but your program will run correctly..
        {
            //base.show(); //1st way to hide child class method and invoke parent class method by using "base" keyword....

            Console.WriteLine("Child class Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Child(); // instantiate object with new keyword and child class constructor...
            p.show();
        //Child cd = new Child();
         //cd.show();   
         // ((Parent)cd).show(); //2nd way for invoking parent class method and hide child class method --- casting parent to child and hide the method of child class.
        }
    }
}
