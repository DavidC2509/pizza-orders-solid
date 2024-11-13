using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Template.Domain.RecipePizzaAggregate;

namespace Template.Command.Database.Configurations
{
    public class RecipePizzaConfiguration : IEntityTypeConfiguration<RecipePizza>
    {
        public void Configure(EntityTypeBuilder<RecipePizza> builder)
        {
            builder.ToTable("RecipePizza");

            // Configure the Id property to use the database default value for new entities
            builder.Property(e => e.Id)
            .HasDefaultValueSql("gen_random_uuid()");

            builder
            .HasMany(e => e.Pizzas)
              .WithOne(e => e.RecipePizza)
              .HasForeignKey("RecipePizzaId")
              .IsRequired(false);
        }
    }
}