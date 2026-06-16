using HospitalManagement.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace HospitalManagement.Infrastructure.Data
{
    public class HospitalDbContext:DbContext
    {
        public HospitalDbContext(DbContextOptions <HospitalDbContext> options) : base(options)
        {

        }
        public DbSet<Patient> Patients => Set<Patient>();

        public DbSet<Doctor> Doctors => Set<Doctor>();

        public DbSet<Department> Departments => Set<Department>();

        public DbSet<Appointment> Appointments => Set<Appointment>();

        public DbSet<Prescription> Prescriptions => Set<Prescription>();

        public DbSet<Medicine> Medicines => Set<Medicine>();

        public DbSet<PrescriptionMedicine> PrescriptionMedicines
            => Set<PrescriptionMedicine>();

        public DbSet<Room> Rooms => Set<Room>();

        public DbSet<Bill> Bills => Set<Bill>();

        public DbSet<Payment> Payments => Set<Payment>();

        public DbSet<CardPayment> CardPayments => Set<CardPayment>();

        public DbSet<CashPayment> CashPayments => Set<CashPayment>();

        public DbSet<Nurse> Nurses => Set<Nurse>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly()
                );
        }



    }
}
