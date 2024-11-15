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

            // Agregar tipos de bordes predefinidos
            builder.HasData(
                Border.CreateBorder("Sin Borde"),
                Border.CreateBorder("Borde de queso"),
                Border.CreateBorder("Borde relleno de pepperoni"),
                Border.CreateBorder("Borde de ajo y mantequilla"),
                Border.CreateBorder("Borde crujiente"),
                Border.CreateBorder("Borde de masa fina"),
                Border.CreateBorder("Borde con parmesano"),
                Border.CreateBorder("Borde relleno de jalapeños"),
                Border.CreateBorder("Borde relleno de queso cheddar"),
                Border.CreateBorder("Borde de pan de ajo"),
                Border.CreateBorder("Borde sin gluten"),
                Border.CreateBorder("Borde tradicional"),
                Border.CreateBorder("Borde relleno de salchicha"),
                Border.CreateBorder("Borde extra crujiente"),
                Border.CreateBorder("Borde con especias italianas"),
                Border.CreateBorder("Borde con orégano y aceite de oliva")
            );

        }
    }
}