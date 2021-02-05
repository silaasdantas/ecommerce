﻿using ECommerce.Api.Search.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.Api.Search.Interfaces
{
    public interface IOrdersService
    {
        Task<(bool IsSucess, IEnumerable<Order> Orders, string ErrorMessage)> 
            GetOrdersAsync(int customerId);
    }
}
