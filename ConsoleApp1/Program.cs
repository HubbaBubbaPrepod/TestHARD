using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cart = new ShoppingCart();
            var availableItems = new List<string> { "Laptop", "Mouse", "Keyboard", "Monitor", "Headphones" };

            Console.WriteLine("Welcome to the store! Here are the available items:");

            while (true)
            {

                for (int i = 0; i < availableItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {availableItems[i]}");
                }

                Console.Write("Select an item number to add to cart or type 'order' to process your order: ");

                var input = Console.ReadLine();

                if (input?.ToLower() == "order")
                {
                    try
                    {
                        cart.ProcessOrder();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    break;
                }

                if (int.TryParse(input, out int itemNumber) && itemNumber > 0 && itemNumber <= availableItems.Count)
                {
                    string selectedItem = availableItems[itemNumber - 1];
                    cart.AddItem(selectedItem);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid item number or type 'order'.");
                }
            }

            Console.WriteLine("Application finished. Ready to run tests.");
        }
    }
}



