﻿using ECommerce.Api.Customers.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ECommerce.Api.Customers.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersProvider customersProvider;

        public CustomersController(ICustomersProvider customersProvider)
        {
            this.customersProvider = customersProvider;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductAsync()
        {
            var result = await customersProvider.GetCustomersAsync();
            if (result.IsSucess)
                return Ok(result.Customers);

            return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductAsync(int id)
        {
            var result = await customersProvider.GetCustomerAsync(id);
            if (result.IsSucess)
                return Ok(result.Customer);

            return NotFound();
        }
    }
}
