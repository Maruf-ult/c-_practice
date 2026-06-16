using HospitalManagement.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagement.Infrastructure.Configurations
{
    public class PrescriptionMedicineConfiguration
        : IEntityTypeConfiguration<PrescriptionMedicine>
    {
        public void Configure(
            EntityTypeBuilder<PrescriptionMedicine> builder)
        {
            builder.ToTable("PrescriptionMedicines");

            // Composite Primary Key
            builder.HasKey(x =>
                new { x.PrescriptionId, x.MedicineId });

            // Dose
            builder.Property(x => x.Dose)
                .IsRequired();

            // Duration
            builder.Property(x => x.DurationInDays)
                .IsRequired();

            // Prescription Relationship
            builder.HasOne(x => x.Prescription)
                .WithMany(x => x.PrescriptionMedicines)
                .HasForeignKey(x => x.PrescriptionId)
                .OnDelete(DeleteBehavior.Cascade);

            // Medicine Relationship
            builder.HasOne(x => x.Medicine)
                .WithMany(x => x.PrescriptionMedicines)
                .HasForeignKey(x => x.MedicineId)
                .OnDelete(DeleteBehavior.Restrict);

            // Optional Index
            builder.HasIndex(x => x.MedicineId);
        }
    }
}