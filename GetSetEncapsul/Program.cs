using System;

namespace GetSetEncapsul
{
    class Student 
    {
        private int _StdId;
        private string _Name;
        private string _lname;

        public int StdId
        {
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("Do not Enter 0 or negative value");
                }
                else
                {
                    this._StdId = value;
                } 
            }
            get
            {
                return this._StdId;
            }
        }
        public string Name
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    System.Console.WriteLine("Please Enter your correct name");
                }
                else
                {
                    this._Name = value;
                }
            }
            get
            {
                return this._Name;
            }
        }
        public string Lname
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Enter correct Last name");
                }
                else
                {
                this._lname = value;
                }
            }
            get 
            {
                return this._lname;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.StdId = 26;
            Console.WriteLine("Student id is :{0}",s.StdId);
            s.Name = "Sahil";
            Console.WriteLine("Student Name is :{0}",s.Name);
            s.Lname = "Dudwadkar";
            Console.WriteLine("Last name is :{0}",s.Lname);
        }
    }
}
