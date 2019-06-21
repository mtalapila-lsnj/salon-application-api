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
    public class EmployeeRepository : EntityMappingRepository<Employee, EmployeeViewModel>, IEmployeeRepository
    {
        public EmployeeRepository(SalonContext context, IMapper mapper) : base(context, mapper) { }
        public IEnumerable<EmployeeViewModel> GetEmployees()
        {
            return _context.Set<Employee>().Include(x => x.Gender)
                                           .Include(x => x.CurrentTitle)
                                           .Include(x => x.EmployeeAppointments)
                                           .Include(x => x.EmployeeQualifications)
                                           .Include(x => x.EmployeeSchedules).Select(x => MapFrom(x));
        }
    }
}
