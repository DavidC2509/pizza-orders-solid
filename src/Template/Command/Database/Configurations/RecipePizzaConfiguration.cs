using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Template.Domain.IngredientsAggregate;
using Template.Domain.RecipePizzaAggregate;

namespace Template.Command.Database.Configurations
{
    public class RecipePizzaConfiguration : IEntityTypeConfiguration<RecipePizza>
    {
        public void Configure(EntityTypeBuilder<RecipePizza> builder)
        {
            builder.ToTable("RecipePizza");

            builder.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()");
            builder.HasKey(e => e.Id);

            builder
                .HasMany(e => e.Pizzas)
                .WithOne(e => e.RecipePizza)
                .HasForeignKey("RecipePizzaId")
                .IsRequired(false);

            // Datos iniciales de recetas
            var margarita = RecipePizza.CreateRecipePizza("Margarita", "Pizza clásica con salsa de tomate, mozzarella y albahaca fresca.", 8.5m);
            var pepperoni = RecipePizza.CreateRecipePizza("Pepperoni", "Pizza con pepperoni y queso mozzarella.", 10.0m);

            builder.HasData(margarita, pepperoni);

            // Asociación implícita de recetas con ingredientes
            builder.HasMany(e => e.Ingredients)
                .WithMany(e => e.RecipePizzas)
                .UsingEntity<Dictionary<string, object>>(
                    "RecipePizzaIngredient",
                    right => right.HasOne<Ingredient>().WithMany().HasForeignKey("IngredientId"),
                    left => left.HasOne<RecipePizza>().WithMany().HasForeignKey("RecipePizzaId"),
                    join =>
                    {
                        join.Property<Guid>("RecipePizzaId"); // Cambia a Guid
                        join.Property<Guid>("IngredientId"); // Cambia a Guid
                        join.ToTable("RecipePizzaIngredient");
                        join.HasData(
                            new { RecipePizzaId = margarita.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Queso"] },
                            new { RecipePizzaId = margarita.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Salsa de Tomate"] },
                            new { RecipePizzaId = pepperoni.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Queso"] },
                            new { RecipePizzaId = pepperoni.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Pepperoni"] }
                        );
                    }
                );
        }
    }

}
