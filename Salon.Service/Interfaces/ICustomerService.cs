using Salon.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Service.Interfaces
{
    public interface ICustomerService
    {
        IEnumerable<CustomerViewModel> GetAllCustomers();
        CustomerViewModel GetCustomerById(int id);
        CustomerViewModel AddNewCustomer(CustomerViewModel customerViewModel);
        CustomerViewModel UpdateCustomer(CustomerViewModel customer);
        CustomerViewModel DeleteCustomer(CustomerViewModel customer);
    }
}
