using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------Single Dimenstion Array-------------------
            // int[] num = new int[3];
            // num[0]=11;
            // num[1]=12;
            // num[2]=13;

            // Console.WriteLine(num[0]);
            //--display array elements using foreach loop-----//
            // foreach(int item in num)
            // {
            //     Console.WriteLine(item);
            // }

            //Multidimensional array - rectangular array

            int[,] num = new int[3,4]
            {
                {11,12,13,14},
                {15,16,17,18},
                {19,20,21,22}
            };
            // foreach (int item in num)
            // {
            //     Console.WriteLine(item);
            // }
            for(int i = 0; i<num.GetLength(0);i++)
            {
                for (int j=0; j<num.GetLength(1);j++)
                {
                    Console.Write(num[i,j]);
                }
                Console.WriteLine();
            }
        }

    }
}
