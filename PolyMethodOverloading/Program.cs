using System;

namespace PolyMethodOverloading
{
    // Polymorphism Method Overloading --- Same Function or Method but different signature or parameters  
    class Addition 
    {
        public void Add()
        {
           int a = 20;
           int b = 30;
           int c = a + b;
           Console.WriteLine(c);
        }
        public void Add(int a , int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        public void Add(string a, string b)
        {
            string c = a + " " + b;
            Console.WriteLine(c);
        }
        public void Add(float a , float b)
        {
            float c = a + b;
            Console.WriteLine(c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Addition p = new Addition();  //And access those method using object instatiation 
            p.Add(2.5f,3.25f);
        }
    }
}
