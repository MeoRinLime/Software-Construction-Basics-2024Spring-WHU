﻿using System;

namespace OrderManage
{

    public class Goods
    {
        public int GoodsId { get; set; }
        public string GoodsName { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

        private float price;

        public float Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("the price must >= 0!");
                price = value;
            }
        }

        public Goods(){}

        public Goods(int id, string name, float price)
        {
            this.GoodsId = id;
            this.GoodsName = name;
            this.Price = price;
        }

        public override bool Equals(object obj)
        {
            var goods = obj as Goods;
            return goods != null && GoodsId == goods.GoodsId;
        }

        public override int GetHashCode()
        {
            return 2108858624 + GoodsId.GetHashCode();
        }

        public override string ToString()
        {
            return $"Id:{GoodsId}, Name:{GoodsName}, Value:{Price}";
        }

    }
}