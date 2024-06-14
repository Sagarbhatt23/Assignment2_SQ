using System;
namespace Assignemnt2
{
    public class Product
    {
        // Porperties
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        //Constructor
        public Product(int productID, string productName, double price, int stock)
        {
            ProductID = productID;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        //methods
        //Increase Method

        public void IncreaseStock(int qty)
        {
            if (qty > 0)
            {
                Stock = Stock + qty;
                Console.WriteLine("Stock is increased by {0} quantity to the {1}", qty, Stock);
            }
            else
            {
                Console.WriteLine("Quantity can not be less than 0");
            }
        }

        // decrease method
        public void DecreaseStock(int qty)
        {
            if (qty > 0)
            {
                if (Stock >= qty)
                {
                    Stock = Stock - qty;
                    Console.WriteLine("Stock is decreased by {0} quantity to the {1}", qty, Stock);
                }
                else
                {
                    Console.WriteLine("No enough stock available!");
                }
            }
            else
            {
                Console.WriteLine("Quantity can not be less than 0");
            }
        }

    }
}

