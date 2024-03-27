using OrdersManagement;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            string? readResult;
            string menuSelection = "";
            //添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户、订单金额等进行查询功能
            do
            {
                Console.Clear();

                Console.WriteLine("Welcome! Your main menu options are:");
                Console.WriteLine(" 1. Add new Order.");
                Console.WriteLine(" 2. Delete a Order.");
                Console.WriteLine(" 3. Update a Order.");
                Console.WriteLine(" 4. Query Orders.");
                Console.WriteLine(" 5. Sort Orders.");
                Console.WriteLine();
                Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

                readResult = Console.ReadLine();

                if (readResult != null)
                {
                    menuSelection = readResult.ToLower();
                }

                switch (menuSelection)
                {
                    //添加订单, 订单号为随机生成的五位整数
                    case "1":
                        bool isValidQuantity = false;
                        bool isValidCostomerName = false;
                        bool isValidMerchandiseName = false;
                        bool isValidUnitPrice = false;
                        int quantity = 0;
                        string? customer = "";
                        string? nameOfMerchandise = "";
                        decimal unitPrice = 0;

                        do
                        {
                            Console.WriteLine("Enter the Quantity:");
                            quantity = Convert.ToInt32(Console.ReadLine());
                            if (quantity < 0)
                            {
                                Console.WriteLine("Quantity cannot be negative.");
                                Console.WriteLine("Please enter a valid quantity.");
                            }
                            else
                            {
                                isValidQuantity = true;
                            }
                        } while (!isValidQuantity);

                        do
                        {
                            Console.WriteLine("Enter the Customer:");
                            customer = Console.ReadLine();
                            if (string.IsNullOrEmpty(customer))
                            {
                                Console.WriteLine("Customer cannot be empty.");
                                Console.WriteLine("Please enter a valid customer name.");
                            }
                            else
                            {
                                isValidCostomerName = true;
                            }
                        } while (!isValidCostomerName);

                        do
                        {
                            Console.WriteLine("Enter the Name of Merchandise:");
                            nameOfMerchandise = Console.ReadLine();
                            if (string.IsNullOrEmpty(nameOfMerchandise))
                            {
                                Console.WriteLine("Name of Merchandise cannot be empty.");
                                Console.WriteLine("Please enter a valid name of merchandise.");
                            }
                            else
                            {
                                isValidMerchandiseName = true;
                            }
                        } while (!isValidMerchandiseName);

                        do
                        {
                            Console.WriteLine("Enter the Unit Price:");
                            unitPrice = Convert.ToDecimal(Console.ReadLine());
                            if (unitPrice < 0)
                            {
                                Console.WriteLine("Unit Price cannot be negative.");
                                Console.WriteLine("Please enter a valid unit price.");
                            }
                            else
                            {
                                isValidUnitPrice = true;
                            }
                        } while (!isValidUnitPrice);

                        int randomID = new Random().Next(10000, 99999);
                        int orderId = randomID;
                        Console.WriteLine("The orderID has been generated as: " + orderId);
/*                        OrderDetails OrderDetail = new(quantity, customer, nameOfMerchandise, unitPrice);*/

                        break;
                    case "2":
                        Console.WriteLine("Enter the Order ID:");
                        int orderIdToRemove = Convert.ToInt32(Console.ReadLine());
                        orderService.RemoveOrder(orderIdToRemove);
                        break;
                    case "3":
                        Console.WriteLine("Enter the Order ID:");
                        int orderIdToUpdate = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Quantity:");
                        int quantityToUpdate = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Customer:");
                        string customerToUpdate = Console.ReadLine();
                        Console.WriteLine("Enter the Name of Merchandise:");
                        string nameOfMerchandiseToUpdate = Console.ReadLine();
                        Console.WriteLine("Enter the Unit Price:");
                        decimal unitPriceToUpdate = Convert.ToDecimal(Console.ReadLine());
                        //orderService.UpdateOrder(new Order(orderIdToUpdate, new OrderDetails(quantityToUpdate, customerToUpdate, nameOfMerchandiseToUpdate, unitPriceToUpdate)));
                        break;
                    case "4":
                        Console.WriteLine("Enter the Customer:");
                        string customerToQuery = Console.ReadLine();
                        var orders = orderService.QueryOrders(o => o.OrderDetails.Customer == customerToQuery);
                        foreach (var order in orders)
                        {
                            Console.WriteLine(order);
                        }
                        break;
                    case "5":
                        orderService.SortOrders(o => o.OrderId);
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }

            } while (menuSelection != "exit");

            

            // 示例：添加订单
            // orderService.AddOrder(new Order { ... });

            // 示例：删除订单
            // orderService.RemoveOrder(orderId);

            // 示例：修改订单
            // orderService.UpdateOrder(new Order { ... });

            // 示例：查询订单
            // var orders = orderService.QueryOrders(o => o.Customer == "CustomerName");

            // 示例：排序订单
            // orderService.SortOrders(o => o.TotalAmount);
        }
    }
}
