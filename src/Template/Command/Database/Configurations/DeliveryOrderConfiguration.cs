using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Template.Domain.OrderAggregate;

namespace Template.Command.Database.Configurations
{
    public class DeliveryOrderConfiguration : IEntityTypeConfiguration<DeliveryOrder>
    {
        public void Configure(EntityTypeBuilder<DeliveryOrder> builder)
        {
            builder.ToTable("DeliveryOrder");

            // Configure the Id property to use the database default value for new entities
            builder.Property(e => e.Id)
            .HasDefaultValueSql("gen_random_uuid()");

            builder
             .Property(p => p.Price)
            .HasColumnType("decimal(18,2)");
        }
    }
}