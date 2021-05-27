using System;

namespace StaticClass
{
    static class Product 
    {
        public static int ProductID;
        public static string ProductName;
        public static int ProductPrice;

        static Product()
        {
            ProductID = 101;
            ProductName = "Whiteboard";
            ProductPrice = 2000;
        }
        
        public static void GetProducts()
        {
            Console.WriteLine("Product ID is :{0}",ProductID);
            Console.WriteLine("Product Name is :{0}",ProductName);
            Console.WriteLine("Product Price is :{0}",ProductPrice);
        }
        public static void GetDiscount()
        {
            int d_amount = ProductPrice / 10;
            Console.WriteLine("Discount on product is 10% :{0}",d_amount);
            Console.WriteLine("Total Amount After discount :{0}",ProductPrice - d_amount);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Product.GetProducts();
            Product.GetDiscount();
        }
    }
}
