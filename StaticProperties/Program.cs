using System;

namespace StaticProperties
{
    class University
    {
        private static string UniversityName;
        private static string DepartmentName;

        public static string _UniversityName //first propert for setting and getting University name 
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please Enter Correct Name Don't Enter null value");
                }
                else
                {
                UniversityName = value;
                }
            }
            get
            {
                return UniversityName;
            }
        }
        //Second propert for setting and getting University name 

        public static string _DepartmentName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Enter Correct Department Name");
                }
                else
                {
                DepartmentName = value;
                }
            }
            get
            {
                return DepartmentName;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            University._UniversityName = "Mumbai University";
            Console.WriteLine("University Name is :{0}",University._UniversityName);
            University._DepartmentName = "Msc Department";
            Console.WriteLine("Department Name is :{0}",University._DepartmentName);
        }
    }
}
