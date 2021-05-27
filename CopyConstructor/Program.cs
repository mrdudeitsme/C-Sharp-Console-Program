using System;

namespace CopyConstructor
{
    class Example 
    {
        string Name;
        int Age;

        public Example(string Name, int Age) // Parameterized Constructor
        {
            this.Name = Name; //Set Values to the Variables
            this.Age = Age;   //Set Values to the Variables
        }

        public Example(Example e)    //Copy Constructor & set parameter of class & class Object
        {
            this.Name = e.Name; // set Variable values to the class Object
            this.Age = e.Age;  // set Variable values to the class Object
        }
        public void GetData() //Getting data from Variables
        {
           Console.WriteLine("Name is : {0}",Name);
           Console.WriteLine("Age is : {0}",Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Example obj = new Example("Sahil",23);
            obj.GetData();
            Example obj1 = new Example(obj); //Another object for copy Constructor
            obj1.GetData(); //Call same method like first object 
        }
    }
}
