using Microsoft.EntityFrameworkCore;
using Salon.Data.Entities;
using System;

namespace Salon.Data
{
    public class SalonContext: DbContext
    {
        public SalonContext(DbContextOptions options): base(options) {}
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<AppointmentTransaction> AppointmentTransactions { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeSchedule> EmployeeSchedules { get; set; }
        public virtual DbSet<EmployeeTitle> EmployeeTitles { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<GiftCard> GiftCards { get; set; }
        public virtual DbSet<GiftCardTransaction> GiftCardTransactions { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }
        public virtual DbSet<SalonSchedule> SalonSchedules { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceType> ServiceTypes { get; set; }
        public virtual DbSet<TimeSlot> TimeSlots { get; set; }
    }
}
