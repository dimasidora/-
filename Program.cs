using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
     class Program
    {
        static void Main(string[] args)
        {
            Storage storage = new Storage();
            bool running = true;

            while (running)
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Add Supply");
                Console.WriteLine("3. View Products");
                Console.WriteLine("4. View Supplies");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter product name: ");
                        var name = Console.ReadLine();
                        Console.Write("Enter product price: ");
                        var price = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter product quantity: ");
                        var quantity = int.Parse(Console.ReadLine());
                        storage.AddProduct(name, price, quantity);
                        Console.WriteLine("Product added.");
                        break;

                    case "2":
                        Console.Write("Enter product ID for supply: ");
                        var productId = int.Parse(Console.ReadLine());
                        Console.Write("Enter quantity supplied: ");
                        var quantitySupplied = int.Parse(Console.ReadLine());
                        storage.AddSupply(productId, quantitySupplied);
                        Console.WriteLine("Supply added.");
                        break;

                    case "3":
                        Console.WriteLine("Products:");
                        foreach (var product in storage.GetProducts())
                        {
                            Console.WriteLine(product);
                        }
                        break;

                    case "4":
                        Console.WriteLine("Supplies:");
                        foreach (var supply in storage.GetSupplies())
                        {
                            Console.WriteLine(supply);
                        }
                        break;

                    case "5":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
