﻿using AutoMapper;
using ECommerce.Api.Orders.Db;
using ECommerce.Api.Orders.Models;

namespace ECommerce.Api.Orders.Profiles
{
    public class OrdersProfile: Profile
    {
        public OrdersProfile()
        {
            CreateMap<OrderEntity, Order>();
            CreateMap<OrderItemEntity, OrderItem>();
        }
    }
}
