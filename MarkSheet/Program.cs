using System;

namespace MarkSheet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Your Roll Number");
            int rollnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Division");
            int division = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your maths marks");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Physics marks");
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Algebra marks");
            int a = int.Parse(Console.ReadLine());


            Console.WriteLine("----------MarkSheet------------");

            int obtainMarks = m + p + a;
            int percentage = obtainMarks / 100 * 500;

            Console.WriteLine("Your name is {0} :",name);
            Console.WriteLine("Your Roll Number is {0} :",rollnumber);
            Console.WriteLine("Your Obtain Marks is {0} :", obtainMarks);
            Console.WriteLine("Your Percentage is {0} :",percentage);

            if(percentage >=80)
            {
                Console.WriteLine("A Grade -- Excellent");
            }
            else if (percentage >= 70)
            {
                Console.WriteLine("B Grade -- Good");
            }
            else if (percentage >= 35)
            {
                Console.WriteLine("C Grade -- poor");
            }
            else
            {
                Console.WriteLine("Fail -- Came with your parents to meet principle");
            }

            int KTSUb = 0;
            if (m < 30)
            {
                Console.WriteLine("You have KT In Maths");
            }
            if (p < 30)
            {
            Console.WriteLine("You have KT In Physics");
            }
            if (a < 30)
            {
                Console.WriteLine("You have KT in Algebra");
            }
        }
    }
}
