using System;
using System.Collections.Generic;

namespace ECommerce.Api.Orders.Db
{
    public class OrderEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public List<OrderItemEntity> Items { get; set; }
    }
}
