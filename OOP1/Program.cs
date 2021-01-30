using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 3;
            product1.ProductName = "Skirt";
            product1.UnitPrice = 55;
            product1.UnitsInStock = 15;

            Product product2 = new Product();
            product2.Id = 2;
            product2.CategoryId = 5;
            product2.ProductName = "jean";
            product2.UnitPrice = 79.99;
            product2.UnitsInStock = 40;

            ProductManager productManager = new ProductManager();

            productManager.Add(product2);

            Console.WriteLine("---------------------");

            productManager.Update(product1);




        }
    }
}
