using System;

namespace Classes_And_Objects
{
    class Student
    {
        string name;
        int roll;
        int age;
        int standerd;

        public void SetStudent(string name, int roll, int age, int standerd) // set student method with parameters
        {
            this.name = name;
            this.roll = roll;
            this.age = age;
            this.standerd = standerd;
        }
        public void GetStudent() // Get Student
        {
            Console.WriteLine("Student name:{0}",this.name);
            Console.WriteLine("Student rollno:{0}",this.roll);
            Console.WriteLine("Student age:{0}",this.age);
            Console.WriteLine("Student standerd:{0}",this.standerd);           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student Name :");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Student Roll Number :");
            int roll = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter student age :");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter student standerd :");
            int standerd = int.Parse(Console.ReadLine());

            Student info = new Student(); //Object Instantiate
            info.SetStudent(name,roll,age,standerd); //Pass Aurguments
            info.GetStudent();
        }
    }
}
