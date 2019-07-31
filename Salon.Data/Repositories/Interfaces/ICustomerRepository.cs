using Salon.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Data.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<CustomerViewModel> GetCustomers();
        CustomerViewModel GetCustomerById(int id);
        CustomerViewModel AddNewCustomer(CustomerViewModel customerViewModel);
    }
}
