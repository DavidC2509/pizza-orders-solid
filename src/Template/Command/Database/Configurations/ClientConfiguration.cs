using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Template.Domain.ClientAggregate;

namespace Template.Command.Database.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client");

            // Configure the Id property to use the database default value for new entities
            builder.Property(e => e.Id)
            .HasDefaultValueSql("gen_random_uuid()");

            builder
            .HasMany(e => e.Orders)
              .WithOne(e => e.Client)
              .HasForeignKey("ClientId");
        }
    }
}