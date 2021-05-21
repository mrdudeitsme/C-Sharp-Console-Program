using System;

namespace AbstractClassInCSharo
{
    abstract class Person
    {
        public string FirstName;

        public string LastName;

        public int age;

        public long PhoneNumber;

        public abstract void PrintDetails();
    }

    class Student : Person
    {
        public int RollNumber;

        public int Fees;

        public override void PrintDetails()
        {
            string name = this.FirstName + " " + this.LastName;
            Console.WriteLine("Student Name is :{0}", name);
            Console.WriteLine("Student Age is :{0}", this.age);
            Console.WriteLine("Student Phone Number is :{0}", this.PhoneNumber);
            Console.WriteLine("Student Roll Number is:{0}", this.RollNumber);
            Console.WriteLine("Student Fees is :{0}", this.Fees);
        }
    }

    class Teacher : Person
    {
        public string Qualification;

        public int Salary;

        public override void PrintDetails()
        {
            string Tname = this.FirstName + " " + this.LastName;
            Console.WriteLine("Teacher name is :{0}", Tname);

            Console.WriteLine("Teacher Age is:{0}", this.age);
            Console.WriteLine("Teacher Phone Number is:{0}", this.PhoneNumber);
            Console
                .WriteLine("Teacher ROll Number is :{0}", this.Qualification);
            Console.WriteLine("Teacher Salary is :{0}", this.Salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student Sahil = new Student();
            Sahil.FirstName = "Sahil";
            Sahil.LastName = "Dudwadkar";
            Sahil.age = 25;
            Sahil.PhoneNumber = 7302444110;
            Sahil.RollNumber = 222;
            Sahil.Fees = 30000;
            Sahil.PrintDetails();

            Teacher Sahild = new Teacher();
            Sahild.FirstName = "Sahild";
            Sahild.LastName = "Dude";
            Sahild.age = 25;
            Sahild.PhoneNumber = 9867146314;
            Sahild.Qualification = "MSCIT";
            Sahild.Salary = 50000;
            Sahild.PrintDetails();
        }
    }
}
