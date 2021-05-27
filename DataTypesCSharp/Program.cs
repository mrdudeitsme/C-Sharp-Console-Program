using System;

namespace DataTypesCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Console.WriteLine(float.MaxValue);
            // // Console.WriteLine(float.MinValue);
            // // Console.ReadLine(); 
            // int a = 50;
            // int b = 30;

            // bool c = a < b;
            // Console.WriteLine(c);
            // Console.ReadLine();
            // Console.WriteLine(float.MaxValue);
            // Console.WriteLine(float.MinValue);

            // string x = @"D:\Sahil\dude\";
            // // char b = 'S';

            // Console.WriteLine(x);
            // // Console.WriteLine(b);

            //Implicite Conversion 

            // int a = 20;
            // float b = a;
            // Console.WriteLine(b);

            //Explicit Conversion
            // float a = 20.234f;
            // int b = Convert.ToInt32(a);
            // Console.WriteLine(a);

            //addition of String Explicit Conversion
            // string a = "25";
            // string b = "92";

            // int z = Convert.ToInt32(a) + Convert.ToInt32(b);

            // Console.WriteLine(z);

            //Parse Funtion 
            const string a = "25";
            const strineg b = "92";

            int z = Convert.ToInt32(a) + Convert.ToInt32(b);

            Console.WriteLine(z);
        }
    }
}
