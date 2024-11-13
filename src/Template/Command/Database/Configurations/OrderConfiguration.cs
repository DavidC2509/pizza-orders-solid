using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Template.Domain.OrderAggregate;

namespace Template.Command.Database.Configurations
{
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");

            // Configure the Id property to use the database default value for new entities
            builder.Property(e => e.Id)
            .HasDefaultValueSql("gen_random_uuid()");
            builder.HasKey(e => e.Id);
            builder
             .HasOne(e => e.DeliveryOrders)
              .WithOne(e => e.Order)
              .HasForeignKey<DeliveryOrder>();

            builder
            .Property(p => p.Total)
            .HasColumnType("decimal(18,2)");
        }
    }
}