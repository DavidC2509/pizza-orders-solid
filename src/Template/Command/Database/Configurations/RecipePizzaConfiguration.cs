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
              .HasForeignKey(e => e.RecipePizzaId);

            // Datos iniciales de recetas
            var margarita = RecipePizza.CreateRecipePizza("Pizza Margarita", "Pizza clásica con salsa de tomate, mozzarella y albahaca fresca.", 8.5m);
            var pepperoni = RecipePizza.CreateRecipePizza("Pizza Pepperoni", "Pizza con pepperoni y queso mozzarella.", 10.0m);
            var bbqChicken = RecipePizza.CreateRecipePizza("Pizza BBQ Chicken", "Pizza con salsa BBQ, pollo, cebolla y queso mozzarella.", 12.0m);
            var hawaiian = RecipePizza.CreateRecipePizza("Pizza Hawaiian", "Pizza con jamón, piña y queso mozzarella.", 11.0m);
            var veggieLovers = RecipePizza.CreateRecipePizza("Pizza Veggie Lovers", "Pizza vegetariana con champiñones, pimientos, cebolla y aceitunas negras.", 10.0m);
            var meatLovers = RecipePizza.CreateRecipePizza("Pizza Meat Lovers", "Pizza con pepperoni, tocino, carne de res y chorizo.", 14.0m);

            builder.HasData(margarita, pepperoni, bbqChicken, hawaiian, veggieLovers, meatLovers);

            // Asociación implícita de recetas con ingredientes
            builder.HasMany(e => e.Ingredients)
           .WithMany(e => e.RecipePizzas)
           .UsingEntity<Dictionary<string, object>>(
               "RecipePizzaIngredient",
               right => right.HasOne<Ingredient>().WithMany().HasForeignKey("IngredientId"),
               left => left.HasOne<RecipePizza>().WithMany().HasForeignKey("RecipePizzaId"),
               join =>
               {
                   join.Property<Guid>("RecipePizzaId");
                   join.Property<Guid>("IngredientId");
                   join.ToTable("RecipePizzaIngredient");
                   join.HasData(
                       // Margarita
                       new { RecipePizzaId = margarita.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Queso"] },
                       new { RecipePizzaId = margarita.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Salsa de Tomate"] },
                       new { RecipePizzaId = margarita.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Albahaca Fresca"] },

                       // Pepperoni
                       new { RecipePizzaId = pepperoni.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Queso"] },
                       new { RecipePizzaId = pepperoni.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Pepperoni"] },

                       // BBQ Chicken
                       new { RecipePizzaId = bbqChicken.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Salsa BBQ"] },
                       new { RecipePizzaId = bbqChicken.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Pollo"] },
                       new { RecipePizzaId = bbqChicken.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Cebolla"] },
                       new { RecipePizzaId = bbqChicken.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Queso Mozzarella"] },

                       // Hawaiian
                       new { RecipePizzaId = hawaiian.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Jamón"] },
                       new { RecipePizzaId = hawaiian.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Piña"] },
                       new { RecipePizzaId = hawaiian.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Queso Mozzarella"] },

                       // Veggie Lovers
                       new { RecipePizzaId = veggieLovers.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Champiñones"] },
                       new { RecipePizzaId = veggieLovers.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Cebolla"] },
                       new { RecipePizzaId = veggieLovers.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Aceitunas Negras"] },
                       new { RecipePizzaId = veggieLovers.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Tomates Cherry"] },

                       // Meat Lovers
                       new { RecipePizzaId = meatLovers.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Pepperoni"] },
                       new { RecipePizzaId = meatLovers.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Tocino"] },
                       new { RecipePizzaId = meatLovers.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Carne de Res"] },
                       new { RecipePizzaId = meatLovers.Id, IngredientId = IngredientsConfiguration.IngredientGuids["Chorizo"] }
                   );
               }
           );

        }
    }

}
