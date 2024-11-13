using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Template.Domain.BorderAggregate;

namespace Template.Command.Database.Configurations
{
    public class BorderConfiguration : IEntityTypeConfiguration<Border>
    {
        public void Configure(EntityTypeBuilder<Border> builder)
        {
            builder.ToTable("Border");

            // Configure the Id property to use the database default value for new entities
            builder.Property(e => e.Id)
            .HasDefaultValueSql("gen_random_uuid()");

            builder.HasKey(e => e.Id);

            builder
               .HasMany(e => e.Pizzas)
                 .WithOne(e => e.Borders)
                 .HasForeignKey("BorderIds");

        }
    }
}