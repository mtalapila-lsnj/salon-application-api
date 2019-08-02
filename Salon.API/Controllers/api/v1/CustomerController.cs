using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Salon.Domain;
using Salon.Service.Interfaces;

namespace Salon.API.Controllers.api.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<CustomerViewModel>> Get()
        {
            var customers = _customerService.GetAllCustomers();
            return Ok(customers);
        }
        [HttpGet("{id}")]
        public ActionResult<CustomerViewModel> GetById(int id)
        {
            var customer = _customerService.GetCustomerById(id);
            if (customer != null)
                return Ok(customer);
            return BadRequest();
        }
        [HttpPost]
        public ActionResult<CustomerViewModel> Post(CustomerViewModel customerViewModel)
        {
            if (customerViewModel == null)
            {
                return BadRequest();
            }
            try
            {
                var customer = _customerService.AddNewCustomer(customerViewModel);
                return Ok(customer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpPut]
        public ActionResult<CustomerViewModel> Put(CustomerViewModel customer)
        {
            if (customer == null)
            {
                return BadRequest();
            }
            try
            {
                var cust = _customerService.UpdateCustomer(customer);
                return Ok(cust);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpDelete]
        public ActionResult<CustomerViewModel> Delete(CustomerViewModel customer)
        {
            if (customer == null)
                return BadRequest();
            try
            {
                var cust = _customerService.DeleteCustomer(customer);
                return Ok(cust);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}