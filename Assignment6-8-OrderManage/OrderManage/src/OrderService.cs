using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;
using OrderManage.sql;

namespace OrderManage.src
{
    public class OrderService
    {
        private readonly OrderManagementContext context;

        public OrderService(OrderManagementContext context)
        {
            this.context = context;
        }

        public OrderService()
        {

        }

        // 添加订单
        public void AddOrder(Order order)
        {
            if (context.Orders.Any(o => o.OrderId == order.OrderId))
            {
                throw new ApplicationException($"The order {order.OrderId} already exists!");
            }
            context.Orders.Add(order);
            context.SaveChanges();
        }

        // 更新订单
        public void Update(Order order)
        {
            var existingOrder = context.Orders.Find(order.OrderId);
            if (existingOrder == null)
            {
                throw new ApplicationException($"The order {order.OrderId} doesn't exist!");
            }
            context.Entry(existingOrder).CurrentValues.SetValues(order);
            context.SaveChanges();
        }

        // 根据Id查询订单
        public Order GetById(int orderId)
        {
            return context.Orders
                .Include(o => o.Details)
                .FirstOrDefault(o => o.OrderId == orderId);
        }

        // 根据Id删除订单
        public void RemoveOrder(int orderId)
        {
            var order = context.Orders.Find(orderId);
            if (order != null)
            {
                context.Orders.Remove(order);
                context.SaveChanges();
            }
        }

        // 查询所有订单
        public List<Order> QueryAll()
        {
            return context.Orders.Include(o => o.Details).ToList();
        }

        public bool testConnection()
        {
            return context.CanQueryDatabase();
        }

        //查询所有商品
        public List<Goods> QueryAllGoods()
        {
            return context.Goods.ToList();
        }

        // 根据客户名查询
        public List<Order> QueryByCustomerName(string customerName)
        {
            return context.Orders
                .Where(o => o.Customer == customerName)
                .OrderBy(o => o.TotalPrice)
                .ToList();
        }

        // 根据货物名查询
        public List<Order> QueryByGoodsName(string goodsName)
        {
            return context.Orders
                .Where(o => o.Details.Any(d => d.Goods.GoodsName == goodsName))
                .OrderBy(o => o.TotalPrice)
                .ToList();
        }

        // 根据总价查询
        public List<Order> QueryByTotalPrice(float totalPrice)
        {
            return context.Orders
                .Where(o => o.TotalPrice >= totalPrice)
                .OrderBy(o => o.TotalPrice)
                .ToList();
        }

        // 对orders中的数据进行排序
        public List<Order> Sort(Func<Order, object> keySelector)
        {
            return context.Orders.OrderBy(keySelector).ToList();
        }

        // 根据传入的条件进行查询
        public IEnumerable<Order> Query(Func<Order, bool> predicate)
        {
            return context.Orders
                .Where(predicate)
                .OrderBy(o => o.TotalPrice)
                .ToList();
        }
    }
}

