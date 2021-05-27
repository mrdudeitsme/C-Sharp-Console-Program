using System;

namespace StaticConstructor
{
    class Person
    {
        public static string PersonName; 
        public static int PersonAge;

        static Person()         //Static Constructor Intiatiate without access modifier
        {
            PersonName = "Sahil";
            PersonAge = 20;
            Console.WriteLine("Static constructor Invoked !!");
        }
        public Person()         //Default Constructor
        {
            Console.WriteLine("Default Constructor Invoked !!");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Sahil = new Person(); // Default Constructor for first Object
            Person Sidd = new Person();  // Default Constructor for second Object
        }
    }
}
