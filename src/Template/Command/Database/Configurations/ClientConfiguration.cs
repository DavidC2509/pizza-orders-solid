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

            builder.HasKey(e => e.Id);

            builder
            .HasMany(e => e.Orders)
              .WithOne(e => e.Client)
              .HasForeignKey("ClientId");

            var client = Client.CreateClient("David", "davidFernando@gmil.com", "75324397");

            builder.HasData(client);
        }
    }
}