using System;

namespace array_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(my_array[0]);
            // Console.WriteLine(my_array[1]);
            // Console.WriteLine(my_array[2]);
            // Console.WriteLine(my_array[3]);
            // int[] my_array = new int[4];
            // my_array[0] = 11;
            // my_array[1] = 22;
            // my_array[2] = 33;
            // my_array[3] = 44;
            // // Console.WriteLine(my_array.Length);
            // foreach (int i in my_array)
            // {
            //     Console.WriteLine(i + " ");
            // }
            
            //------------string array-----------//

            // string[] my_array = new string[4];
            // my_array[0] = "sahil";
            // my_array[1] = "sahil";
            // my_array[2] = "sahil";
            // my_array[3] = "sahil";

            // Console.WriteLine(my_array[0]);
            // Console.WriteLine(my_array[1]);
            // Console.WriteLine(my_array[2]);
            // Console.WriteLine(my_array[3]);

            // Console.WriteLine(my_array.Length);

            //-----------accesing array values using foreach loop ----int data type-------------------//

            // int[] my_array = new int [4];
            // my_array[0] = 11;
            // my_array[1] = 22;
            // my_array[2] = 33;
            // my_array[3] = 44;

            // foreach(int item in my_array)
            // {
            //     Console.WriteLine(item);
            // }


            
            //-----------------accesing array values using foreach loop----string data type------------//

            // string[] name = new string[4];
            // name[0] = "sahil";
            // name[1] = "sahil";
            // name[2] = "sahil";
            // name[3] = "sahil";

            // foreach (string i in name)
            // {
            //     Console.WriteLine(i);
            // }

            //--------------Multidimensional Array------1) rectangular array 2)jagged array--------4

            //----accessing Multidimensional Rectangular array using nested for loop-----//

            // int[,] num = new int[3,4]
            // {
            //     {1,2,3,4},
            //     {5,6,7,8},
            //     {9,10,11,12}
            // };
            // for(int i=0; i < num.GetLength(0);i++)
            // {
            //     for(int j=0; j< num.GetLength(1);j++)
            //     {
            //         Console.Write(num[i,j]+ " ");
            //     }
            //     Console.WriteLine();
            // }

            //-------------accessing Multidimensional Rectangular array using nested foreach loop-----//

            // int[,] num = new int[2,3]
            // {
            //     {1,2,3},
            //     {4,5,6}
            // };
            // foreach(int item in num)
            // {
            //     Console.WriteLine(item);
            // }

            //------------accessing Multidimensional jagged array-----//
            // int[][] num = new int[3][];
            // num[0] = new[] {1,2,3};
            // num[1] = new[] {4,5,6,7};
            // num[2] = new[] {8,9,10,11,12};
            
            // Console.WriteLine(num[1][3]);

            //--------------accessing Multidimensional jagged array using nested for loop------------/

            // int[][] num = new int[3][];
            // num[0] = new[] {1,2,3};
            // num[1] = new[] {4,5,6,7};
            // num[2] = new[] {8,9,10,11,12};

            // for(int i = 0; i < num.GetLength(0); i++)
            // {
            //     for(int j = 0; j < num[i].Length; j++)
            //     {
            //         Console.Write(num[i][j]);
            //     }
            //     Console.WriteLine();
            // }
            //--------------accessing Multidimensional jagged array using nested foreach loop------------/
            // int[][] num = new int[3][];
            // num[0] = new[] {1,2,3};
            // num[1] = new[] {4,5,6,7};
            // num[2] = new[] {8,9,10,11,12};

            // foreach (int[] items in num)            
            // {
            //     foreach (int i in items)
            //     {
            //         Console.WriteLine(i + "");
            //     }
            // }
            //----------diplaying array elements---//
            // int[,] num = new int[2,3]
            // {
            //     {1,2,3},
            //     {4,5,6}
            // };
            // Console.WriteLine(num[1,2]);


//--------------Initializing array with user input------------/

            
        }
    }