using Microsoft.EntityFrameworkCore;
using Salon.Data.Entities;
using System;

namespace Salon.Data
{
    public class SalonContext: DbContext
    {
        public SalonContext(DbContextOptions options): base(options) {}
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<EmployeeTitle> EmployeeTitles { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
    }
}
