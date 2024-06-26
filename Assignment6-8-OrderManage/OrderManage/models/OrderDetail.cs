﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace OrderManage
{
    public class OrderDetail
    {
        public int OrderId { get; set; }  // 作为外键的一部分，也是复合主键的一部分
        public int GoodsId { get; set; }  // 同上

        public int Quantity { get; set; }

        //[NotMapped]
        //[JsonIgnore]
        //public float TotalPrice => Goods != null ? Goods.Price * Quantity : 0;

        [JsonIgnore]
        public virtual Goods Goods { get; set; }
        public virtual Order Order { get; set; }

        public OrderDetail() { }

        public OrderDetail(Goods goods, int quantity)
        {
            this.Goods = goods;
            this.Quantity = quantity;
        }

        public override bool Equals(object obj)
        {
            var detail = obj as OrderDetail;
            return detail != null && OrderId == detail.OrderId && GoodsId == detail.GoodsId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(OrderId, GoodsId);
        }

        public override string ToString()
        {
            return $"GoodsId={GoodsId}";
        }
    }

}
