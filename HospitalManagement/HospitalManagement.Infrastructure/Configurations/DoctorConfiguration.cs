using HospitalManagement.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Infrastructure.Configurations
{
    public class DoctorConfiguration:IEntityTypeConfiguration<Doctor>
    {

        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.ToTable("Doctos");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(150)
                .IsRequired();

            builder.HasIndex(x => x.Email)
               .IsUnique();

            builder.Property(x => x.PasswordHash)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(x => x.Speciality)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.VisitingFee)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.VisitingFee)
                .HasPrecision(100)
                .IsRequired();

            builder.HasOne(x => x.Department)
                .WithMany(x => x.Doctors)
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Supervisor)
                .WithMany(x => x.Subordinates)
                .HasForeignKey(x => x.SupervisorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.RowVersion)
                .IsRowVersion();

        }

    }
}
