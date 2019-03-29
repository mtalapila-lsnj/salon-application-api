using Salon.Data.Entities;
using Salon.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Salon.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly SalonContext _context;
        public EmployeeRepository(SalonContext context)
        {
            _context = context;
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return this._context.Set<Employee>().ToList();
        }
    }
}
