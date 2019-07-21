using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Salon.Data.Base;
using Salon.Data.Entities;
using Salon.Data.Repositories.Interfaces;
using Salon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Salon.Data.Repositories
{
    public class CustomerRepository : EntityMappingRepository<Customer, CustomerViewModel>, ICustomerRepository
    {
        public CustomerRepository(SalonContext salonContext, IMapper mapper) : base(salonContext, mapper) { }
        public IEnumerable<CustomerViewModel> GetCustomers()
        {
            return _context.Set<Customer>()
                        .Include(x => x.GiftCards)
                        .Include(x => x.Appointments)
                        .Select(x => MapFrom(x));
        }
        public CustomerViewModel GetCustomerById(int id)
        {
            var customerEntity = _context.Set<Customer>().Where(x => x.Id == id).FirstOrDefault();
            if (customerEntity != null)
            {
                return MapFrom(customerEntity);
            }
            return null;
        }
    }
}
