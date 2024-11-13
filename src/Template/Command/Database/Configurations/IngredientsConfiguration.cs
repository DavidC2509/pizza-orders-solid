using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Template.Domain.IngredientsAggregate;

namespace Template.Command.Database.Configurations
{
    public class IngredientsConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.ToTable("Ingredients");

            // Configure the Id property to use the database default value for new entities
            builder.Property(e => e.Id)
            .HasDefaultValueSql("gen_random_uuid()");

            builder
               .HasMany(e => e.Pizzas)
              .WithMany(e => e.Ingredients)
              .UsingEntity("IngredientPizza");

            builder
              .HasMany(e => e.RecipePizzas)
             .WithMany(e => e.Ingredients)
             .UsingEntity("RecipePizzaIngredient");

            builder
     .Property(p => p.Amount)
    .HasColumnType("decimal(18,2)");
        }
    }
}