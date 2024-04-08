using NUnit.Framework;
using OrdersManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace OrdersManagementTests
{
    [TestFixture]
    public class OrderTests
    {
        [Test]
        public void Order_Creation_TotalAmountIsCalculatedCorrectly()
        {
            // Arrange
            var orderDetails = new OrderDetails(2, "Customer A", "Widget", 10.00m);
            var order = new Order(1, orderDetails);

            // Act & Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(20.00m, order.TotalAmount);
        }

        [Test]
        public void Order_Equals_ReturnsTrueForSameOrderId()
        {
            // Arrange
            var orderDetails = new OrderDetails(2, "Customer A", "Widget", 10.00m);
            var order1 = new Order(1, orderDetails);
            var order2 = new Order(1, orderDetails);

            // Act & Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(order1.Equals(order2));
        }

        // Additional tests for Order class...
    }

    [TestFixture]
    public class OrderDetailsServiceTests
    {
        [Test]
        public void OrderDetails_Creation_PropertiesAreSetCorrectly()
        {
            // Arrange & Act
            var orderDetails = new OrderDetails(2, "Customer A", "Widget", 10.00m);

            // Assert
            Assert.AreEqual("Customer A", orderDetails.Customer);
            Assert.AreEqual("Widget", orderDetails.NameOfMerchandise);
            Assert.AreEqual(10.00m, orderDetails.UnitPrice);
            Assert.AreEqual(2, orderDetails.Quantity);
        }

        // Additional tests for OrderDetails class...
    }

    [TestFixture]
    public class OrderServiceTests
    {
        private OrderService _orderService;
        private Order _order;
        private OrderDetails _orderDetails;

        [SetUp]
        public void Setup()
        {
            _orderService = new OrderService();
            _orderDetails = new OrderDetails(2, "Customer A", "Widget", 10.00m);
            _order = new Order(1, _orderDetails);
            _orderService.AddOrder(_order);
        }

        [Test]
        public void AddOrder_ThrowsException_WhenOrderAlreadyExists()
        {
            // Act & Assert
            var ex = Assert.ThrowsException<Exception>(() => _orderService.AddOrder(_order));
        }

        [Test]
        public void RemoveOrder_RemovesOrder_WhenOrderExists()
        {
            // Act
            _orderService.RemoveOrder(1);

            // Assert
            Assert.IsFalse(_orderService.isValidOrderId(1));
        }

        // Additional tests for OrderService class...
    }
}
