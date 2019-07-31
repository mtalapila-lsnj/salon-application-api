using Salon.Data.Repositories.Interfaces;
using Salon.Domain;
using Salon.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public IEnumerable<CustomerViewModel> GetAllCustomers()
        {
            return _customerRepository.GetCustomers();
        }
        public CustomerViewModel GetCustomerById(int id)
        {
            var customer = _customerRepository.GetCustomerById(id);
            if (customer != null)
                return customer;
            return null;
        }
        public CustomerViewModel AddNewCustomer(CustomerViewModel customerViewModel)
        {
            return _customerRepository.AddNewCustomer(customerViewModel);
        }
    }
}
