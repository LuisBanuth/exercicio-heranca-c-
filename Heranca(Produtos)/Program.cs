using Heranca_Produtos_.Entities;
using System;

namespace Heranca_Produtos_
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("Iphone XI", 5000);
            Product p2 = new ImportedProduct("Iphone XI", 4000, 20);
            Product p3 = new UsedProduct("Iphone 6", 800, new DateTime(2016, 06, 01));

            Console.WriteLine(p1.PriceTag());
            Console.WriteLine(p2.PriceTag());
            Console.WriteLine(p3.PriceTag());

        }
    }
}
