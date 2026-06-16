using HospitalManagement.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Infrastructure.Configurations
{
    public class PatientConfiguration:IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable("Patients");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(x => x.Email)
                .HasMaxLength(150)
                .IsRequired();

            builder.HasIndex(x => x.Email)
                .IsUnique();

            builder.Property(x => x.PasswordHash)
                .IsRequired();

            builder.OwnsOne(x => x.Address, address =>
            {
                address.Property(a => a.Area)
                .HasMaxLength(100);

                address.Property(a => a.City)
                .HasMaxLength(100);

                address.Property(a => a.PostalCode)
                .HasMaxLength(20);

            });

            builder.HasOne(x => x.Room)
                .WithOne(x => x.Patient)
                .HasForeignKey<Patient>(x => x.RoomId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(x => x.Bill)
                .WithOne(x => x.Patient)
                .HasForeignKey<Bill>(x => x.PatientId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.RowVersion)
                .IsRowVersion();

        }
    }
}
