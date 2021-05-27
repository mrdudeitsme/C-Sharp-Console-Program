using System;

namespace DestructorInCshapr
{
    class person
    {
        public string Name;
        public int Age;

        public person(string Name,int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public void GetNameAge()
        {
            Console.WriteLine("Name is:{0}",Name);
            Console.WriteLine("Age is:{0}",Age);
        }
        ~person()
        {
            Console.WriteLine("Destructor is invoke");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            person obj = new person("Sahil",24);
            obj.GetNameAge();
            //Console.ReadLine();
        }
    }
}
