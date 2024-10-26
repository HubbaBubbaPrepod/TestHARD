using Xunit;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    public class ShoppingCartTests
    {
        [Fact]
        public void Test_OrderProcessed_AfterProcessingOrder()
        {
            var cart = new ShoppingCart();

            cart.AddItem("Laptop");
            cart.AddItem("Mouse");
            cart.ProcessOrder();
            Assert.Contains("Laptop", cart.Items);
            Assert.Contains("Mouse", cart.Items);
            Assert.True(cart.OrderProcessed, "Заказ должен быть обработан.");
            Assert.True(cart.PaymentSuccess, "Оплата должна пройти успешно.");
        }

        [Fact]
        public void Test_ProcessOrder_ThrowsException_WhenCartIsEmpty()
        {
            var cart = new ShoppingCart();
            var exception = Assert.Throws<InvalidOperationException>(() => cart.ProcessOrder());
            Assert.Equal("Cart is empty. Cannot process order.", exception.Message);
        }
    }
}