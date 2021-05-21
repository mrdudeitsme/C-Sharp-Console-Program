using System;

namespace AbstractClassProp
{
    public abstract class person
    {
        public abstract int id { get; set; }

        public abstract string name { get; set; }
    }

    class student : person
    {
        int StudentId;

        string StudentName;

        public override int id
        {
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("ID cannot be zero or null");
                }
                else
                {
                    this.StudentId = value;
                }
            }
            get
            {
                return this.StudentId;
            }
        }

        public override string name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be null or empty");
                }
                else
                {
                    this.StudentName = value;
                }
            }
            get
            {
                return this.StudentName;
            }
        }
    }

    class teacher : person
    {
        int TeacherId;

        string TeacherName;

        public override int id
        {
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("ID cannot be zero or null");
                }
                else
                {
                    this.TeacherId = value;
                }
            }
            get
            {
                return this.TeacherId;
            }
        }

        public override string name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be null or empty");
                }
                else
                {
                    this.TeacherName = value;
                }
            }
            get
            {
                return this.TeacherName;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            student Sahil = new student();
            Sahil.id = 22;
            Sahil.name = "sahil";
            Console.WriteLine(Sahil.id);
            Console.WriteLine(Sahil.name);

            teacher Sidd = new teacher();
            Sidd.id = 33;
            Sidd.name = "Sidd";
            Console.WriteLine(Sidd.id);
            Console.WriteLine(Sidd.name);
        }
    }
}
