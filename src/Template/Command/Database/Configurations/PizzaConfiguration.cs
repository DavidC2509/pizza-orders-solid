using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Template.Domain.OrderAggregate;

namespace Template.Command.Database.Configurations
{
    public class PizzaConfiguration : IEntityTypeConfiguration<Pizza>
    {
        public void Configure(EntityTypeBuilder<Pizza> builder)
        {
            builder.ToTable("Pizza");

            // Configure the Id property to use the database default value for new entities
            builder.Property(e => e.Id)
            .HasDefaultValueSql("gen_random_uuid()");
            builder.HasKey(e => e.Id);

            builder
             .Property(p => p.AmountBase)
            .HasColumnType("decimal(18,2)");

        }
    }
}