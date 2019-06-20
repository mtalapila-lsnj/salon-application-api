using Salon.Data.Entities;
using Salon.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Data.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<EmployeeViewModel> GetEmployees();

    }
}
