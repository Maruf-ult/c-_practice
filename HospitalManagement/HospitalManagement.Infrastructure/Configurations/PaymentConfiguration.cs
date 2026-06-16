
using HospitalManagement.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagement.Infrastructure.Configurations
{
    public class PaymentConfiguration
        : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("Payments");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Amount)
                .HasColumnType("decimal(18,2)");

            builder.Property(x => x.Status)
                .HasConversion<string>();

            builder.HasDiscriminator<string>("PaymentType")
                .HasValue<CardPayment>("Card")
                .HasValue<CashPayment>("Cash");

            builder.HasOne(x => x.Bill)
                .WithOne(x => x.Payment)
                .HasForeignKey<Payment>(x => x.BillId);

            builder.Property(x => x.RowVersion)
                .IsRowVersion();
        }
    }
}