﻿using AutoMapper;
using ECommerce.Api.Products.Db;
using ECommerce.Api.Products.Models;

namespace ECommerce.Api.Products.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductEntity, Product>();
            CreateMap<Product, ProductEntity>();
        }
    }
}
