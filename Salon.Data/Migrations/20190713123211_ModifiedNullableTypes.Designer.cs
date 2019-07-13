﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Salon.Data;

namespace Salon.Data.Migrations
{
    [DbContext(typeof(SalonContext))]
    [Migration("20190713123211_ModifiedNullableTypes")]
    partial class ModifiedNullableTypes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Salon.Data.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Confirmation");

                    b.Property<int?>("CustomerId");

                    b.Property<int>("Duration");

                    b.Property<int?>("EmployeeId");

                    b.Property<int?>("GroupPartyId");

                    b.Property<bool>("IsPaid");

                    b.Property<bool?>("IsPrimaryRequest");

                    b.Property<bool?>("IsSecondaryRequest");

                    b.Property<string>("Name");

                    b.Property<string>("Remarks");

                    b.Property<int?>("ServiceId");

                    b.Property<DateTime>("Start");

                    b.Property<int?>("VisitId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("GroupPartyId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("VisitId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Salon.Data.Entities.AppointmentDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AppointmentId");

                    b.Property<int?>("Duration");

                    b.Property<int?>("EmployeeId");

                    b.Property<int?>("ServiceStepId");

                    b.Property<DateTime?>("Start");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ServiceStepId");

                    b.ToTable("AppointmentDetails");
                });

            modelBuilder.Entity("Salon.Data.Entities.AppointmentProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AppointmentId");

                    b.Property<int?>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("ProductId");

                    b.ToTable("AppointmentProducts");
                });

            modelBuilder.Entity("Salon.Data.Entities.AppointmentTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AmountPaid");

                    b.Property<int>("AppointmentId");

                    b.Property<DateTime?>("TransactionDate");

                    b.Property<string>("TransactionNote");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.ToTable("AppointmentTransactions");
                });

            modelBuilder.Entity("Salon.Data.Entities.ContactAcceptance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AcceptedOn");

                    b.Property<int?>("CustomerId");

                    b.Property<DateTime?>("DeletedOn");

                    b.Property<bool?>("IsDeleted");

                    b.Property<bool?>("IsOkToCotact");

                    b.Property<int?>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TypeId");

                    b.ToTable("ContactAcceptances");
                });

            modelBuilder.Entity("Salon.Data.Entities.ContactType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("ContactTypes");
                });

            modelBuilder.Entity("Salon.Data.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<int?>("GenderId");

                    b.Property<string>("LastName");

                    b.Property<string>("Notes");

                    b.Property<string>("PrimaryEmail");

                    b.Property<string>("PrimaryPhoneNumber");

                    b.Property<string>("SecondaryEmail");

                    b.Property<string>("SecondaryPhoneNumber");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Salon.Data.Entities.CustomerContactPreference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContactTypeId");

                    b.Property<int?>("CustomerId");

                    b.Property<bool?>("IsDeleted");

                    b.Property<string>("Notes");

                    b.Property<bool?>("OkToContact");

                    b.Property<bool?>("OkToContactOnHolidays");

                    b.Property<bool?>("OkToContactOnWeekends");

                    b.HasKey("Id");

                    b.HasIndex("ContactTypeId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerContactPreferences");
                });

            modelBuilder.Entity("Salon.Data.Entities.CustomerProductPreference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId");

                    b.Property<int?>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("CustomerProductPreferences");
                });

            modelBuilder.Entity("Salon.Data.Entities.CustomerServicePreference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId");

                    b.Property<int?>("Order");

                    b.Property<int?>("QualificationId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("QualificationId");

                    b.ToTable("CustomerServicePreferences");
                });

            modelBuilder.Entity("Salon.Data.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("AlternatePhoneNumber");

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<int?>("GenderId");

                    b.Property<DateTime?>("HireDate");

                    b.Property<string>("ImageSource");

                    b.Property<bool?>("IsActive");

                    b.Property<string>("LastInitial");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Remarks");

                    b.Property<int?>("TitleId");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.HasIndex("TitleId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Salon.Data.Entities.EmployeeSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeeId");

                    b.Property<int?>("TimeSlotId");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TimeSlotId");

                    b.ToTable("EmployeeSchedules");
                });

            modelBuilder.Entity("Salon.Data.Entities.EmployeeTitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("EmployeeTitles");
                });

            modelBuilder.Entity("Salon.Data.Entities.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("Salon.Data.Entities.GiftCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<int?>("CustomerId");

                    b.Property<DateTime?>("DateExpired");

                    b.Property<DateTime?>("DateSold");

                    b.Property<string>("From");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Note");

                    b.Property<string>("To");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("GiftCards");
                });

            modelBuilder.Entity("Salon.Data.Entities.GiftCardTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AmountUsed");

                    b.Property<int>("GiftCardId");

                    b.Property<DateTime?>("TransactionDate");

                    b.Property<string>("TransactionNote");

                    b.HasKey("Id");

                    b.HasIndex("GiftCardId");

                    b.ToTable("GiftCardTransactions");
                });

            modelBuilder.Entity("Salon.Data.Entities.GroupParty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Note");

                    b.Property<int?>("ParticipantsQuantity");

                    b.Property<DateTime>("Start");

                    b.HasKey("Id");

                    b.ToTable("GroupParties");
                });

            modelBuilder.Entity("Salon.Data.Entities.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active");

                    b.Property<bool?>("Completed");

                    b.Property<DateTime?>("CompletedOn");

                    b.Property<int?>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("NoteDescription");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("Salon.Data.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<int?>("GenderId");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Salon.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("ImageSource");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Salon.Data.Entities.Qualification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeeId");

                    b.Property<int?>("ServiceId");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Qualifications");
                });

            modelBuilder.Entity("Salon.Data.Entities.SalonSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Duration");

                    b.Property<DateTime?>("Start");

                    b.HasKey("Id");

                    b.ToTable("SalonSchedules");
                });

            modelBuilder.Entity("Salon.Data.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("ImageSource");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<int?>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Salon.Data.Entities.ServiceStep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Note");

                    b.Property<int?>("ServiceId");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.ToTable("ServiceSteps");
                });

            modelBuilder.Entity("Salon.Data.Entities.ServiceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ServiceTypes");
                });

            modelBuilder.Entity("Salon.Data.Entities.TimeSlot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Duration");

                    b.Property<DateTime?>("Start");

                    b.HasKey("Id");

                    b.ToTable("TimeSlots");
                });

            modelBuilder.Entity("Salon.Data.Entities.Visit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<DateTime?>("Start");

                    b.HasKey("Id");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("Salon.Data.Entities.Appointment", b =>
                {
                    b.HasOne("Salon.Data.Entities.Customer", "Customer")
                        .WithMany("Appointments")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Salon.Data.Entities.Employee", "Employee")
                        .WithMany("EmployeeAppointments")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Salon.Data.Entities.GroupParty", "GroupParty")
                        .WithMany()
                        .HasForeignKey("GroupPartyId");

                    b.HasOne("Salon.Data.Entities.Service", "Service")
                        .WithMany("Appointments")
                        .HasForeignKey("ServiceId");

                    b.HasOne("Salon.Data.Entities.Visit", "Visit")
                        .WithMany()
                        .HasForeignKey("VisitId");
                });

            modelBuilder.Entity("Salon.Data.Entities.AppointmentDetail", b =>
                {
                    b.HasOne("Salon.Data.Entities.Appointment", "Appointment")
                        .WithMany("AppointmentDetails")
                        .HasForeignKey("AppointmentId");

                    b.HasOne("Salon.Data.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Salon.Data.Entities.ServiceStep", "ServiceStep")
                        .WithMany()
                        .HasForeignKey("ServiceStepId");
                });

            modelBuilder.Entity("Salon.Data.Entities.AppointmentProduct", b =>
                {
                    b.HasOne("Salon.Data.Entities.Appointment", "Appointment")
                        .WithMany("AppointmentUsedProducts")
                        .HasForeignKey("AppointmentId");

                    b.HasOne("Salon.Data.Entities.Product", "Product")
                        .WithMany("AppointmentProducts")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Salon.Data.Entities.AppointmentTransaction", b =>
                {
                    b.HasOne("Salon.Data.Entities.Appointment", "Appointment")
                        .WithMany("AppointmentTransactions")
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Salon.Data.Entities.ContactAcceptance", b =>
                {
                    b.HasOne("Salon.Data.Entities.Customer", "Customer")
                        .WithMany("ContactAcceptances")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Salon.Data.Entities.ContactType", "ContactType")
                        .WithMany("ContactAcceptances")
                        .HasForeignKey("TypeId");
                });

            modelBuilder.Entity("Salon.Data.Entities.Customer", b =>
                {
                    b.HasOne("Salon.Data.Entities.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId");
                });

            modelBuilder.Entity("Salon.Data.Entities.CustomerContactPreference", b =>
                {
                    b.HasOne("Salon.Data.Entities.ContactType", "ContactType")
                        .WithMany("ContactPreferences")
                        .HasForeignKey("ContactTypeId");

                    b.HasOne("Salon.Data.Entities.Customer", "Customer")
                        .WithMany("ContactPreferences")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("Salon.Data.Entities.CustomerProductPreference", b =>
                {
                    b.HasOne("Salon.Data.Entities.Customer", "Customer")
                        .WithMany("ProductPreferences")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Salon.Data.Entities.Product", "Product")
                        .WithMany("ProductPreferences")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Salon.Data.Entities.CustomerServicePreference", b =>
                {
                    b.HasOne("Salon.Data.Entities.Customer", "Customer")
                        .WithMany("ServicePreferences")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Salon.Data.Entities.Qualification", "Qualification")
                        .WithMany("CustomerPreferences")
                        .HasForeignKey("QualificationId");
                });

            modelBuilder.Entity("Salon.Data.Entities.Employee", b =>
                {
                    b.HasOne("Salon.Data.Entities.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId");

                    b.HasOne("Salon.Data.Entities.EmployeeTitle", "CurrentTitle")
                        .WithMany("Employees")
                        .HasForeignKey("TitleId");
                });

            modelBuilder.Entity("Salon.Data.Entities.EmployeeSchedule", b =>
                {
                    b.HasOne("Salon.Data.Entities.Employee", "Employee")
                        .WithMany("EmployeeSchedules")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Salon.Data.Entities.TimeSlot", "TimeSlot")
                        .WithMany("EmployeeSchedules")
                        .HasForeignKey("TimeSlotId");
                });

            modelBuilder.Entity("Salon.Data.Entities.GiftCard", b =>
                {
                    b.HasOne("Salon.Data.Entities.Customer", "Customer")
                        .WithMany("GiftCards")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("Salon.Data.Entities.GiftCardTransaction", b =>
                {
                    b.HasOne("Salon.Data.Entities.GiftCard", "GiftCard")
                        .WithMany("GiftCardTransactions")
                        .HasForeignKey("GiftCardId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Salon.Data.Entities.Note", b =>
                {
                    b.HasOne("Salon.Data.Entities.Employee", "CreatedByEmployee")
                        .WithMany("Notes")
                        .HasForeignKey("CreatedBy");
                });

            modelBuilder.Entity("Salon.Data.Entities.Person", b =>
                {
                    b.HasOne("Salon.Data.Entities.Gender", "Gender")
                        .WithMany("People")
                        .HasForeignKey("GenderId");
                });

            modelBuilder.Entity("Salon.Data.Entities.Qualification", b =>
                {
                    b.HasOne("Salon.Data.Entities.Employee", "Employee")
                        .WithMany("EmployeeQualifications")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Salon.Data.Entities.Service", "Service")
                        .WithMany("Qualifications")
                        .HasForeignKey("ServiceId");
                });

            modelBuilder.Entity("Salon.Data.Entities.Service", b =>
                {
                    b.HasOne("Salon.Data.Entities.ServiceType", "ServiceType")
                        .WithMany("Services")
                        .HasForeignKey("TypeId");
                });

            modelBuilder.Entity("Salon.Data.Entities.ServiceStep", b =>
                {
                    b.HasOne("Salon.Data.Entities.Service", "Service")
                        .WithMany("ServiceSteps")
                        .HasForeignKey("ServiceId");
                });
#pragma warning restore 612, 618
        }
    }
}
