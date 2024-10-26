using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    public class ShoppingCart
    {
        public List<string> Items { get; private set; } = new List<string>();
        public bool OrderProcessed { get; private set; } = false;
        public bool PaymentSuccess { get; private set; } = false;

        public void AddItem(string item)
        {
            Items.Add(item);
            Console.WriteLine($"Item '{item}' added to cart.");
           
        }

        public void ProcessOrder()
        {
            if (Items.Count == 0)
            {
                throw new InvalidOperationException("Cart is empty. Cannot process order.");
            }


            PaymentSuccess = ProcessPayment();

            if (PaymentSuccess)
            {
                OrderProcessed = true;
                Console.WriteLine("Order processed successfully.");
            }
            else
            {
                Console.WriteLine("Payment failed. Order cannot be processed.");
            }
        }

        private bool ProcessPayment()
        {
            // Simple simulation of a payment process
            Console.WriteLine("Processing payment...");
            return true; // Payment is successful for this example
        }
    }
}