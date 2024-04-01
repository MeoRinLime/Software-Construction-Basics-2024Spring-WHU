using OrdersManagement;
using System;
using System.Collections.Generic;
using System.Linq;

OrderService orderService = new OrderService();
string? readResult;
string menuSelection = "";

//测试数据

Order order1 = new Order(10001, new OrderDetails(10, "Alice", "Apple", 5.0m));
Order order2 = new Order(10002, new OrderDetails(20, "Bob", "Banana", 3.0m));
Order order3 = new Order(10003, new OrderDetails(30, "Cathy", "Cherry", 4.0m));
Order order4 = new Order(10004, new OrderDetails(40, "David", "Dorian", 6.0m));
Order order5 = new Order(10005, new OrderDetails(50, "Eve", "Elderberry", 7.0m));
orderService.AddOrder(order1);
orderService.AddOrder(order2);
orderService.AddOrder(order3);
orderService.AddOrder(order4);
orderService.AddOrder(order5);

// TODO 添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户、订单金额等进行查询功能
do
{
    Console.Clear();

    Console.WriteLine("Welcome! Your main menu options are:");
    Console.WriteLine(" 1. Add new Order.");
    Console.WriteLine(" 2. Delete a Order.");
    Console.WriteLine(" 3. Update a Order.");
    Console.WriteLine(" 4. Query Orders.");
    Console.WriteLine(" 5. Sort Orders.");
    Console.WriteLine(" 6. Display Orders");
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
            decimal unitPrice = 0.0m;

            do
            {
                Console.WriteLine("Enter the Quantity:");
                quantity = Convert.ToInt32(Console.ReadLine());
                if (isValidQuantityInput(quantity))
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
                if (isValidUnitPriceInput(unitPrice))
                {
                    isValidUnitPrice = true;
                }
            } while (!isValidUnitPrice);

            int randomID = new Random().Next(10000, 99999);
            int orderId = randomID;
            Order order = new Order(orderId, new OrderDetails(quantity, customer, nameOfMerchandise, unitPrice));
            orderService.AddOrder(order);
            Console.WriteLine($"Added new order {orderId} successfully.");
            Console.WriteLine("Press enter to return.");
            Console.ReadLine();
            break;

        //删除订单，根据订单号
        case "2":
            int orderIdToRemove = 0;
            bool isValidOrderId = false;
            bool isExit = false;
            Console.WriteLine("Enter the Order ID:");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out orderIdToRemove))
                {
                    Console.WriteLine("Invalid Order ID. Please enter a valid Order ID.");
                }
                if (isValidOrderIdInput(orderIdToRemove))
                {
                    isValidOrderId = true;
                }
            }while (!isValidOrderId);
            if (isExit)
            {
                break;
            }
            orderService.RemoveOrder(orderIdToRemove);
            Console.WriteLine($"Removed order {orderIdToRemove} successfully.");
            Console.WriteLine("Press enter to return.");
            Console.ReadLine();
            break;

        //修改订单，根据订单号确定订单
        case "3":
            string? UpdataMenuSelection = ""; 
            string? readResultUpdate = "";
            int orderIdToUpdate = 0;
            do
            {
                isValidOrderId = false;
                isExit = false;
                Console.Clear();

                Console.WriteLine("Which order would you like to update? Enter the Order ID:");
                do
                {
                    if (!int.TryParse(Console.ReadLine(), out orderIdToUpdate))
                    {
                        Console.WriteLine("Invalid Order ID. Please enter a valid Order ID.");
                    }
                    if (isValidOrderIdInput(orderIdToUpdate))
                    {
                        isValidOrderId = true;
                    }
                } while (!isValidOrderId);

                //没输入订单号就退出
                if (!isValidOrderId)
                {
                    break;
                }

                List<Order> orderToUpdate = orderService.QueryOrders(o => o.OrderId == orderIdToUpdate).ToList();
                orderToUpdate.ForEach(o => Console.WriteLine(o.ToString() + "\r\n" + o.OrderDetails.ToString() + "\r\n"));


                Console.WriteLine("What would you like to update?");
                Console.WriteLine(" 1. Update Quantity.");
                Console.WriteLine(" 2. Update Customer.");
                Console.WriteLine(" 3. Update Name of Merchandise.");
                Console.WriteLine(" 4. Update Unit Price.");
                Console.WriteLine(" 5. Exit.");

                readResultUpdate = Console.ReadLine();

                if (readResultUpdate != null)
                {
                    UpdataMenuSelection = readResultUpdate.ToLower();
                }

                switch (UpdataMenuSelection)
                {
                    case "1":
                        bool isValidQuantityUpdate = false;
                        int quantityUpdate = 0;
                        do
                        {
                            Console.WriteLine("Enter the Quantity:");
                            quantityUpdate = Convert.ToInt32(Console.ReadLine());
                            if (isValidQuantityInput(quantityUpdate))
                            {
                                isValidQuantityUpdate = true;
                            }
                        } while (!isValidQuantityUpdate && UpdataMenuSelection != "exit");
                        var orderToUpdate1 = orderService.QueryOrders(o => o.OrderId == orderIdToUpdate).FirstOrDefault();
                        orderToUpdate1.OrderDetails.Quantity = quantityUpdate;
                        Console.WriteLine($"Updated order {orderIdToUpdate} successfully.");
                        break;

                    case "2":
                        bool isValidCostomerNameUpdate = false;
                        string? customerUpdate = "";
                        do
                        {
                            Console.WriteLine("Enter the Customer:");
                            customerUpdate = Console.ReadLine();
                            if (string.IsNullOrEmpty(customerUpdate))
                            {
                                Console.WriteLine("Customer cannot be empty.");
                                Console.WriteLine("Please enter a valid customer name.");
                            }
                            else
                            {
                                isValidCostomerNameUpdate = true;
                            }
                        } while (!isValidCostomerNameUpdate && UpdataMenuSelection != "exit");
                        var orderToUpdate2 = orderService.QueryOrders(o => o.OrderId == orderIdToUpdate).FirstOrDefault();
                        orderToUpdate2.OrderDetails.Customer = customerUpdate;
                        Console.WriteLine($"Updated order {orderIdToUpdate} successfully.");
                        break;

                    case "3":
                        bool isValidMerchandiseNameUpdate = false;
                        string? nameOfMerchandiseUpdate = "";
                        do
                        {
                            Console.WriteLine("Enter the Name of Merchandise:");
                            nameOfMerchandiseUpdate = Console.ReadLine();
                            if (string.IsNullOrEmpty(nameOfMerchandiseUpdate))
                            {
                                Console.WriteLine("Name of Merchandise cannot be empty.");
                                Console.WriteLine("Please enter a valid name of merchandise.");
                            }
                            else
                            {
                                isValidMerchandiseNameUpdate = true;
                            }
                        } while (!isValidMerchandiseNameUpdate && UpdataMenuSelection != "exit");
                        var orderToUpdate3 = orderService.QueryOrders(o => o.OrderId == orderIdToUpdate).FirstOrDefault();
                        orderToUpdate3.OrderDetails.NameOfMerchandise = nameOfMerchandiseUpdate;
                        Console.WriteLine($"Updated order {orderIdToUpdate} successfully.");
                        break;

                    case "4":
                        bool isValidUnitPriceUpdate = false;
                        decimal unitPriceUpdate = 0.0m;
                        do
                        {
                            Console.WriteLine("Enter the Unit Price:");
                            unitPriceUpdate = Convert.ToDecimal(Console.ReadLine());
                            if (isValidUnitPriceInput(unitPriceUpdate))
                            {
                                isValidUnitPriceUpdate = true;
                            }
                        } while (!isValidUnitPriceUpdate && UpdataMenuSelection != "exit");
                        var orderToUpdate4 = orderService.QueryOrders(o => o.OrderId == orderIdToUpdate).FirstOrDefault();
                        orderToUpdate4.OrderDetails.UnitPrice = unitPriceUpdate;
                        Console.WriteLine($"Updated order {orderIdToUpdate} successfully.");
                        break;

                    case "5":
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }
            } while (UpdataMenuSelection != "exit" && !isValidOrderId);
            Console.WriteLine("Press enter to return.");
            Console.ReadLine();
            break;

        //查询订单，根据订单号、商品名称、客户、订单金额等进行查询功能
        case "4":
            string? QueryMenuSelection = "";
            string? readResultQuery = "";

            Console.Clear();
            Console.WriteLine("What information do you want to query orders? ");
            Console.WriteLine(" 1. Query by Order ID.");
            Console.WriteLine(" 2. Query by Customer.");
            Console.WriteLine(" 3. Query by Name of Merchandise.");
            Console.WriteLine(" 4. Query by Unit Price.");
            Console.WriteLine(" 5. Exit.");

            readResultQuery = Console.ReadLine();
            
            if (readResultQuery != null)
            {
                QueryMenuSelection = readResultQuery.ToLower();
            }

            switch (QueryMenuSelection)
            {

                case "1":
                    List<Order> QueryOrders;
                    int orderIdToQuery = 0;
                    bool isValidOrderIdToQuery = false;
                    do
                    {
                        Console.WriteLine("Enter the Order ID:");
                        orderIdToQuery = Convert.ToInt32(Console.ReadLine());
                        if (isValidOrderIdInput(orderIdToQuery))
                        {
                            isValidOrderIdToQuery = true;
                        }
                    } while (!isValidOrderIdToQuery);
                    QueryOrders = orderService.QueryOrders(o => o.OrderId == orderIdToQuery).ToList();
                    displayAllOrders(QueryOrders);
                    Console.WriteLine("Press enter to return.");
                    Console.ReadLine();
                    break;

                case "2":
                    string? customerToQuery = "";
                    bool isValidCustomerToQuery = false;
                    do
                    {
                        Console.WriteLine("Enter the Customer:");
                        customerToQuery = Console.ReadLine();
                        if (string.IsNullOrEmpty(customerToQuery))
                        {
                            Console.WriteLine("Customer cannot be empty.");
                            Console.WriteLine("Please enter a valid customer name.");
                        }
                        else
                        {
                            isValidCustomerToQuery = true;
                        }
                    } while (!isValidCustomerToQuery);
                    QueryOrders = orderService.QueryOrders(o => o.OrderDetails.Customer == customerToQuery).ToList();
                    displayAllOrders(QueryOrders);
                    Console.WriteLine("Press enter to return.");
                    Console.ReadLine();
                    break;

                case "3":
                    string? nameOfMerchandiseToQuery = "";
                    bool isValidNameOfMerchandiseToQuery = false;
                    do
                    {
                        Console.WriteLine("Enter the Name of Merchandise:");
                        nameOfMerchandiseToQuery = Console.ReadLine();
                        if (string.IsNullOrEmpty(nameOfMerchandiseToQuery))
                        {
                            Console.WriteLine("Name of Merchandise cannot be empty.");
                            Console.WriteLine("Please enter a valid name of merchandise.");
                        }
                        else
                        {
                            isValidNameOfMerchandiseToQuery = true;
                        }
                    } while (!isValidNameOfMerchandiseToQuery);
                    QueryOrders = orderService.QueryOrders(o => o.OrderDetails.NameOfMerchandise == nameOfMerchandiseToQuery).ToList();
                    displayAllOrders(QueryOrders);
                    Console.WriteLine("Press enter to return.");
                    Console.ReadLine();
                    break;

                case "4":
                    decimal unitPriceToQuery = 0.0m;
                    bool isValidUnitPriceToQuery = false;
                    do
                    {
                        Console.WriteLine("Enter the Unit Price:");
                        unitPriceToQuery = Convert.ToDecimal(Console.ReadLine());
                        if (isValidUnitPriceInput(unitPriceToQuery))
                        {
                            isValidUnitPriceToQuery = true;
                        }
                    } while (!isValidUnitPriceToQuery);
                    QueryOrders = orderService.QueryOrders(o => o.OrderDetails.UnitPrice == unitPriceToQuery).ToList();
                    displayAllOrders(QueryOrders);
                    Console.WriteLine("Press enter to return.");
                    Console.ReadLine();
                    break;

                case "5":
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    Console.WriteLine("Press enter to return.");
                    Console.ReadLine();
                    break;
            }

            break;

        //排序订单，可以按照订单号、商品名称、客户、订单金额等进行排序
        case "5":
            string? SortMenuSelection = "";
            string? readResultSort = "";
            string? readWaySort = "";

            Console.Clear();
            Console.WriteLine("Which is the base element you want to sort orders? ");
            Console.WriteLine(" 1. Sort by Order ID.");
            Console.WriteLine(" 2. Sort by Customer.");
            Console.WriteLine(" 3. Sort by Name of Merchandise.");
            Console.WriteLine(" 4. Sort by Unit Price.");
            Console.WriteLine(" 5. Exit.\n");

            readResultSort = Console.ReadLine();

            if (readResultSort != null)
            {
                SortMenuSelection = readResultSort.ToLower();
            }

            Console.WriteLine("What kind of ways do you want to sort orders? ");

            Console.WriteLine(" 1. Ascending.");
            Console.WriteLine(" 2. Descending.");
            Console.WriteLine(" 3. Exit.\n");

            readWaySort = Console.ReadLine();

            if (readWaySort != null)
            {
                SortMenuSelection += readWaySort;
            }

            List<Order> SortedOrders = new List<Order>();

            switch (SortMenuSelection)
            {
                case "1":
                    SortedOrders = orderService.QueryOrders(o => o.OrderId > 0).ToList();
                    orderService.SortOrders(o => o.OrderId);
                    displayAllOrders(SortedOrders);
                    break;

                case "2":
                    SortedOrders = orderService.QueryOrders(o => o.OrderId > 0).ToList();
                    orderService.SortOrders(o => o.OrderDetails.Customer);
                    displayAllOrders(SortedOrders);
                    break;

                case "3":
                    SortedOrders = orderService.QueryOrders(o => o.OrderId > 0).ToList();
                    orderService.SortOrders(o => o.OrderDetails.NameOfMerchandise);
                    displayAllOrders(SortedOrders);
                    break;

                case "4":
                    SortedOrders = orderService.QueryOrders(o => o.OrderId > 0).ToList();
                    orderService.SortOrders(o => o.OrderDetails.UnitPrice);
                    displayAllOrders(SortedOrders);
                    break;

                case "11":
                    SortedOrders = orderService.QueryOrders(o => o.OrderId > 0).ToList();
                    orderService.SortOrders(o => o.OrderId);
                    displayAllOrders(SortedOrders);
                    break;

                case "21":
                    SortedOrders = orderService.QueryOrders(o => o.OrderId > 0).ToList();
                    orderService.SortOrders(o => o.OrderDetails.Customer);
                    displayAllOrders(SortedOrders);
                    break;

                case "31":
                    SortedOrders = orderService.QueryOrders(o => o.OrderId > 0).ToList();
                    orderService.SortOrders(o => o.OrderDetails.NameOfMerchandise);
                    displayAllOrders(SortedOrders);
                    break;

                case "41":
                    SortedOrders = orderService.QueryOrders(o => o.OrderId > 0).ToList();
                    orderService.SortOrders(o => o.OrderDetails.UnitPrice);
                    displayAllOrders(SortedOrders);
                    break;

                case "12":
                    SortedOrders = orderService.QueryOrders(o => o.OrderId > 0).ToList();
                    orderService.SortOrders(o => o.OrderId);
                    SortedOrders.Reverse();
                    displayAllOrders(SortedOrders);
                    break;

                case "22":
                    SortedOrders = orderService.QueryOrders(o => o.OrderId > 0).ToList();
                    orderService.SortOrders(o => o.OrderDetails.Customer);
                    SortedOrders.Reverse();
                    displayAllOrders(SortedOrders);
                    break;

                case "32":
                    SortedOrders = orderService.QueryOrders(o => o.OrderId > 0).ToList();
                    orderService.SortOrders(o => o.OrderDetails.NameOfMerchandise);
                    SortedOrders.Reverse();
                    displayAllOrders(SortedOrders);
                    break;

                case "42":
                    SortedOrders = orderService.QueryOrders(o => o.OrderId > 0).ToList();
                    orderService.SortOrders(o => o.OrderDetails.UnitPrice);
                    SortedOrders.Reverse();
                    displayAllOrders(SortedOrders);
                    break;

                case "5":
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }

            Console.WriteLine("Press enter to return.");
            Console.ReadLine();
            break;

        //显示所有订单
        case "6":
            orderService.DisplayOrdersWithAllDetails();
            Console.WriteLine("Press enter to return.");
            Console.ReadLine();
            break;

        case "exit":
            break;

        default:
            Console.WriteLine("Invalid selection. Please try again.");
            break;
    }

} while (menuSelection != "exit");

bool isValidQuantityInput(int quantity)
{
    if (quantity < 0)
    {
        Console.WriteLine("Quantity cannot be negative.");
        Console.WriteLine("Please enter a valid quantity.\r\n");
        return false;
    }
    return true;
}

bool isValidUnitPriceInput(decimal unitPrice)
{
    if (unitPrice < 0)
    {
        Console.WriteLine("Unit Price cannot be negative.");
        Console.WriteLine("Please enter a valid unit price.\r\n");
        return false;
    }
    return true;
}

bool isValidOrderIdInput(int orderId)
{
    if (orderId < 0)
    {
        Console.WriteLine("Order ID cannot be negative.");
        Console.WriteLine("Please enter a valid Order ID.\r\n");
        return false;
    }
    if (orderId.ToString().Length != 5)
    {
        Console.WriteLine("Order ID must be a 5-digit number.");
        Console.WriteLine("Please enter a valid Order ID.\r\n");
        return false;
    }
    if (!orderService.isValidOrderId(orderId))
    {
        Console.WriteLine("Order ID does not exist.");
        Console.WriteLine("Please enter a valid Order ID.\r\n");
        return false;
    }
    return true;
}

void displayAllOrders(List<Order> orders)
{
    if (orders.Count == 0)
    {
        Console.WriteLine("No orders found.");
        return;
    }
    foreach (var order in orders)
    {
        Console.WriteLine(order.ToString() + "\r\n" + order.OrderDetails.ToString() + "\r\n");
    }
}


