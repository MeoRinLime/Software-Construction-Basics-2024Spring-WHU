using OrderApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    public static class GlobalVariables
    {
        //预设商品
        public static List<Goods> AllGoods = new List<Goods>
            {
                new Goods(1, "apple", 5),
                new Goods(2, "egg", 1),
                new Goods(3, "milk", 10),
                new Goods(4, "bread", 4),
                new Goods(5, "cake", 50),
                new Goods(6, "computer", 10000),
                new Goods(7, "phone", 5000),
                new Goods(8, "book", 20)
            };
        public static OrderService OrderService = new OrderService();

        public static List<int> ordersID = new List<int>();
    }
}
