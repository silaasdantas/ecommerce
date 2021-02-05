﻿using ECommerce.Api.Products.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.Api.Products.Interfaces
{
    public interface IProductsProvider
    {
        Task<(bool IsSucess, IEnumerable<Product> Products, string ErrorMessage)> GetProductsAsync();
        Task<(bool IsSucess, Product Product, string ErrorMessage)> GetProductAsync(int id);
    }
}
