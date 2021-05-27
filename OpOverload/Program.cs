// using System;

// namespace OpOverload
// {
//     class Table
//     {
//         public int TableID;
//         public string TableName;

//         public static Table operator +(Table firstTable, Table secondTable)
//         {
//             Table thirdTable = new Table();
//             thirdTable.TableID = firstTable.TableID + secondTable.TableID;
//             thirdTable.TableName = firstTable.TableName + secondTable.TableName;
//             return thirdTable;
//         }

//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Table firstTable = new Table();
//             firstTable.TableID = 20;
//             firstTable.TableName = "TableOne";

//             Table secondTable = new Table();
//             secondTable.TableID = 30;
//             secondTable.TableName = "TableTwo";

//             Table thirdTable = new Table();
//             thirdTable = firstTable + secondTable;
//             Console.WriteLine(thirdTable.TableID);
//             Console.WriteLine(thirdTable.TableName);

//         }
//     }
// }

using System;

namespace OpOverload
{
    class NewClass
    {
        //Instance Members

        public string str;
        public int num;

        //Public static method sending parameters like class name and object refrence veriable)
        public static NewClass operator + (NewClass obj1, NewClass obj2)
        {
            NewClass obj3 = new NewClass(); //Instantiate 3rd object
            obj3.str = obj1.str + " " + obj2.str; //Adding 1st and 2nd object data
            obj3.num = obj1.num + obj2.num; //Adding 1st and 2nd object dats
            return obj3; //return object data to 3rd object
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NewClass obj1 = new NewClass(); //1st Obejct
            obj1.str = "Sahil";
            obj1.num = 12;

            NewClass obj2 = new NewClass(); //2nd Obejct
            obj2.str = "Dudwadkar";
            obj2.num = 12;

            NewClass obj3 = new NewClass(); //3rd Obejct
            obj3 = obj1 + obj2;
            Console.WriteLine(obj3.str);
            Console.WriteLine(obj3.num);
        }
    }
}
