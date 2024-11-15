using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Template.Domain.IngredientsAggregate;
using Template.Domain.PizzaAggregate;
using Template.Domain.RecipePizzaAggregate;

namespace Template.Command.Database.Configurations
{
    public class IngredientsConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public static readonly Dictionary<string, Guid> IngredientGuids = new();

        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.ToTable("Ingredients");

            builder.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()");
            builder.HasKey(e => e.Id);

            // Relación con Pizza
            builder
                .HasMany(e => e.Pizzas)
                .WithMany(e => e.Ingredients)
                .UsingEntity<Dictionary<string, object>>(
                    "IngredientPizza",
                    right => right.HasOne<Pizza>().WithMany().HasForeignKey("PizzaId"),
                    left => left.HasOne<Ingredient>().WithMany().HasForeignKey("IngredientId"),
                    join =>
                    {
                        join.Property<Guid>("PizzaId");
                        join.Property<Guid>("IngredientId"); // Cambia a Guid
                        join.ToTable("IngredientPizza");
                    }
                );

            // Relación con RecipePizza
            builder
                .HasMany(e => e.RecipePizzas)
                .WithMany(e => e.Ingredients)
                .UsingEntity<Dictionary<string, object>>(
                    "RecipePizzaIngredient",
                    right => right.HasOne<RecipePizza>().WithMany().HasForeignKey("RecipePizzaId"),
                    left => left.HasOne<Ingredient>().WithMany().HasForeignKey("IngredientId"),
                    join =>
                    {
                        join.Property<Guid>("RecipePizzaId");
                        join.Property<Guid>("IngredientId"); // Cambia a Guid
                        join.ToTable("RecipePizzaIngredient");
                    }
                );

            builder.Property(p => p.Amount)
                .HasColumnType("decimal(18,2)");

            // Datos iniciales
            var ingredients = new[]
            {
            CreateIngredient("Queso", 2.0m),
            CreateIngredient("Salsa de Tomate", 1.5m),
            CreateIngredient("Pepperoni", 2.5m),
            CreateIngredient("Champiñones", 1.0m)
        };

            builder.HasData(ingredients);
        }

        private Ingredient CreateIngredient(string name, decimal amount)
        {
            var guid = Guid.NewGuid();
            IngredientGuids[name] = guid;
            return Ingredient.CreateIngredients(name, amount, guid);
        }
    }

}