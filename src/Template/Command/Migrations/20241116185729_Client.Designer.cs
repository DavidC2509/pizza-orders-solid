﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Template.Command.Database;

#nullable disable

namespace Template.Command.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20241116185729_Client")]
    partial class Client
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("IngredientPizza", b =>
                {
                    b.Property<Guid>("IngredientId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PizzaId")
                        .HasColumnType("uuid");

                    b.HasKey("IngredientId", "PizzaId");

                    b.HasIndex("PizzaId");

                    b.ToTable("IngredientPizza", (string)null);
                });

            modelBuilder.Entity("RecipePizzaIngredient", b =>
                {
                    b.Property<Guid>("IngredientId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RecipePizzaId")
                        .HasColumnType("uuid");

                    b.HasKey("IngredientId", "RecipePizzaId");

                    b.HasIndex("RecipePizzaId");

                    b.ToTable("RecipePizzaIngredient", (string)null);

                    b.HasData(
                        new
                        {
                            IngredientId = new Guid("25fd06d3-ec4a-425b-a6ab-7e9873b1903b"),
                            RecipePizzaId = new Guid("295322ec-2295-4032-abda-2286dd622e45")
                        },
                        new
                        {
                            IngredientId = new Guid("bfa4f04e-9c6b-4aca-b95e-284d349db2fb"),
                            RecipePizzaId = new Guid("295322ec-2295-4032-abda-2286dd622e45")
                        },
                        new
                        {
                            IngredientId = new Guid("6c0cb6da-ffe8-473e-abd0-fccf2d8cd932"),
                            RecipePizzaId = new Guid("295322ec-2295-4032-abda-2286dd622e45")
                        },
                        new
                        {
                            IngredientId = new Guid("25fd06d3-ec4a-425b-a6ab-7e9873b1903b"),
                            RecipePizzaId = new Guid("93bb7506-42d7-40e2-9a91-f7da469eada1")
                        },
                        new
                        {
                            IngredientId = new Guid("a13d58a7-9b05-40f4-aa72-da86782552c2"),
                            RecipePizzaId = new Guid("93bb7506-42d7-40e2-9a91-f7da469eada1")
                        },
                        new
                        {
                            IngredientId = new Guid("2149f625-bf01-494a-a988-fba3d8fe45d1"),
                            RecipePizzaId = new Guid("a1ac40ba-ad85-45dc-8f6c-9b226d8d8faf")
                        },
                        new
                        {
                            IngredientId = new Guid("b9cf9bfa-f173-409c-a2db-9b50837120cd"),
                            RecipePizzaId = new Guid("a1ac40ba-ad85-45dc-8f6c-9b226d8d8faf")
                        },
                        new
                        {
                            IngredientId = new Guid("b206eaee-629e-439f-8658-e84c8d6fe300"),
                            RecipePizzaId = new Guid("a1ac40ba-ad85-45dc-8f6c-9b226d8d8faf")
                        },
                        new
                        {
                            IngredientId = new Guid("a36dcc7e-f8a2-4cbb-ba57-3c37dc7247b2"),
                            RecipePizzaId = new Guid("a1ac40ba-ad85-45dc-8f6c-9b226d8d8faf")
                        },
                        new
                        {
                            IngredientId = new Guid("3315bf2d-4d4b-45be-bbf1-3c7a395fb6bb"),
                            RecipePizzaId = new Guid("7e8de948-afa8-4f10-97f2-a3bb0cb9cb19")
                        },
                        new
                        {
                            IngredientId = new Guid("d41441e0-a6f2-42f3-9718-d233e0cbf0b4"),
                            RecipePizzaId = new Guid("7e8de948-afa8-4f10-97f2-a3bb0cb9cb19")
                        },
                        new
                        {
                            IngredientId = new Guid("a36dcc7e-f8a2-4cbb-ba57-3c37dc7247b2"),
                            RecipePizzaId = new Guid("7e8de948-afa8-4f10-97f2-a3bb0cb9cb19")
                        },
                        new
                        {
                            IngredientId = new Guid("6db90ecb-080b-409f-8047-8cc75e0ec860"),
                            RecipePizzaId = new Guid("97e55f1e-3d3b-4d34-a1f1-48b84171eb9e")
                        },
                        new
                        {
                            IngredientId = new Guid("b206eaee-629e-439f-8658-e84c8d6fe300"),
                            RecipePizzaId = new Guid("97e55f1e-3d3b-4d34-a1f1-48b84171eb9e")
                        },
                        new
                        {
                            IngredientId = new Guid("0c89840f-7a39-47db-a5e0-eedefecc55c0"),
                            RecipePizzaId = new Guid("97e55f1e-3d3b-4d34-a1f1-48b84171eb9e")
                        },
                        new
                        {
                            IngredientId = new Guid("da7fe135-a41a-4a9e-859b-f25e3f3cf3b0"),
                            RecipePizzaId = new Guid("97e55f1e-3d3b-4d34-a1f1-48b84171eb9e")
                        },
                        new
                        {
                            IngredientId = new Guid("a13d58a7-9b05-40f4-aa72-da86782552c2"),
                            RecipePizzaId = new Guid("0b6bfa6a-524e-439e-b4ff-4e1ffd9789da")
                        },
                        new
                        {
                            IngredientId = new Guid("9a5262ee-d21e-439a-97e9-cb7b2bc7bd56"),
                            RecipePizzaId = new Guid("0b6bfa6a-524e-439e-b4ff-4e1ffd9789da")
                        },
                        new
                        {
                            IngredientId = new Guid("e8dbde95-9da9-4e12-a7cb-37f0fcbedd8d"),
                            RecipePizzaId = new Guid("0b6bfa6a-524e-439e-b4ff-4e1ffd9789da")
                        },
                        new
                        {
                            IngredientId = new Guid("cdf21b5f-6d6e-4cea-8f31-30495698be50"),
                            RecipePizzaId = new Guid("0b6bfa6a-524e-439e-b4ff-4e1ffd9789da")
                        });
                });

            modelBuilder.Entity("Template.Domain.BorderAggregate.Border", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Border", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("4b2dba3a-4c26-4128-ab4c-7d9a582d190e"),
                            Description = "Sin Borde"
                        },
                        new
                        {
                            Id = new Guid("d455b7d7-500e-495b-abf1-101e79f86828"),
                            Description = "Borde de queso"
                        },
                        new
                        {
                            Id = new Guid("178383be-a7ea-4ba9-ac23-4c0e988a4517"),
                            Description = "Borde relleno de pepperoni"
                        },
                        new
                        {
                            Id = new Guid("856a7715-233f-481d-bb30-4f04733fcb97"),
                            Description = "Borde de ajo y mantequilla"
                        },
                        new
                        {
                            Id = new Guid("0dc798cd-4eeb-4fbe-8e3c-a8230d094178"),
                            Description = "Borde crujiente"
                        },
                        new
                        {
                            Id = new Guid("ceb959eb-490e-43cd-977f-6d2694821a7d"),
                            Description = "Borde de masa fina"
                        },
                        new
                        {
                            Id = new Guid("e6388a2f-cd62-40ae-b277-932230fa4d26"),
                            Description = "Borde con parmesano"
                        },
                        new
                        {
                            Id = new Guid("03eba4e3-41e7-42a2-aa2e-4ff9d41ad765"),
                            Description = "Borde relleno de jalapeños"
                        },
                        new
                        {
                            Id = new Guid("1732894f-d900-4c66-a055-c262769fdefd"),
                            Description = "Borde relleno de queso cheddar"
                        },
                        new
                        {
                            Id = new Guid("03eaa2ae-93f1-401c-a4c7-9d1702ffecfa"),
                            Description = "Borde de pan de ajo"
                        },
                        new
                        {
                            Id = new Guid("5b680a4d-6bb9-471a-b439-8974897c6abb"),
                            Description = "Borde sin gluten"
                        },
                        new
                        {
                            Id = new Guid("169689dd-a62c-4a52-bb3f-d595f953fd18"),
                            Description = "Borde tradicional"
                        },
                        new
                        {
                            Id = new Guid("b4d8eed6-c7fc-46b3-8006-4d29276ae8b4"),
                            Description = "Borde relleno de salchicha"
                        },
                        new
                        {
                            Id = new Guid("f66987ef-6e0c-459c-afa1-7d7d4126001d"),
                            Description = "Borde extra crujiente"
                        },
                        new
                        {
                            Id = new Guid("e3ff1608-1d08-4124-901a-5fd362a4bdb3"),
                            Description = "Borde con especias italianas"
                        },
                        new
                        {
                            Id = new Guid("ed53fc75-ce37-4fe0-aafe-82c226a8c7e8"),
                            Description = "Borde con orégano y aceite de oliva"
                        });
                });

            modelBuilder.Entity("Template.Domain.ClientAggregate.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("CellPhone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Client", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("889c9cea-e6d0-4db0-94a0-c11b6e3b979a"),
                            CellPhone = "75324397",
                            Email = "davidFernando@gmil.com",
                            Name = "David"
                        });
                });

            modelBuilder.Entity("Template.Domain.IngredientsAggregate.Ingredient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Ingredients", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("25fd06d3-ec4a-425b-a6ab-7e9873b1903b"),
                            Amount = 2.0m,
                            Name = "Queso"
                        },
                        new
                        {
                            Id = new Guid("bfa4f04e-9c6b-4aca-b95e-284d349db2fb"),
                            Amount = 1.5m,
                            Name = "Salsa de Tomate"
                        },
                        new
                        {
                            Id = new Guid("a13d58a7-9b05-40f4-aa72-da86782552c2"),
                            Amount = 2.5m,
                            Name = "Pepperoni"
                        },
                        new
                        {
                            Id = new Guid("6db90ecb-080b-409f-8047-8cc75e0ec860"),
                            Amount = 1.0m,
                            Name = "Champiñones"
                        },
                        new
                        {
                            Id = new Guid("b206eaee-629e-439f-8658-e84c8d6fe300"),
                            Amount = 0.8m,
                            Name = "Cebolla"
                        },
                        new
                        {
                            Id = new Guid("0c89840f-7a39-47db-a5e0-eedefecc55c0"),
                            Amount = 1.2m,
                            Name = "Aceitunas Negras"
                        },
                        new
                        {
                            Id = new Guid("3315bf2d-4d4b-45be-bbf1-3c7a395fb6bb"),
                            Amount = 2.0m,
                            Name = "Jamón"
                        },
                        new
                        {
                            Id = new Guid("d41441e0-a6f2-42f3-9718-d233e0cbf0b4"),
                            Amount = 1.5m,
                            Name = "Piña"
                        },
                        new
                        {
                            Id = new Guid("9a5262ee-d21e-439a-97e9-cb7b2bc7bd56"),
                            Amount = 2.5m,
                            Name = "Tocino"
                        },
                        new
                        {
                            Id = new Guid("b9cf9bfa-f173-409c-a2db-9b50837120cd"),
                            Amount = 2.5m,
                            Name = "Pollo"
                        },
                        new
                        {
                            Id = new Guid("e8dbde95-9da9-4e12-a7cb-37f0fcbedd8d"),
                            Amount = 3.0m,
                            Name = "Carne de Res"
                        },
                        new
                        {
                            Id = new Guid("2149f625-bf01-494a-a988-fba3d8fe45d1"),
                            Amount = 1.8m,
                            Name = "Salsa BBQ"
                        },
                        new
                        {
                            Id = new Guid("a36dcc7e-f8a2-4cbb-ba57-3c37dc7247b2"),
                            Amount = 2.0m,
                            Name = "Queso Mozzarella"
                        },
                        new
                        {
                            Id = new Guid("a425ebbc-3bdb-45d0-8de6-eaeb8df03442"),
                            Amount = 1.5m,
                            Name = "Queso Parmesano"
                        },
                        new
                        {
                            Id = new Guid("91ad4938-f113-4b54-93ff-c56415e90277"),
                            Amount = 1.5m,
                            Name = "Salsa Alfredo"
                        },
                        new
                        {
                            Id = new Guid("6c0cb6da-ffe8-473e-abd0-fccf2d8cd932"),
                            Amount = 0.7m,
                            Name = "Albahaca Fresca"
                        },
                        new
                        {
                            Id = new Guid("da7fe135-a41a-4a9e-859b-f25e3f3cf3b0"),
                            Amount = 1.0m,
                            Name = "Tomates Cherry"
                        },
                        new
                        {
                            Id = new Guid("cdf21b5f-6d6e-4cea-8f31-30495698be50"),
                            Amount = 2.8m,
                            Name = "Chorizo"
                        },
                        new
                        {
                            Id = new Guid("b38e49ad-149d-4c18-a717-9e6da504eb3d"),
                            Amount = 1.0m,
                            Name = "Jalapeños"
                        },
                        new
                        {
                            Id = new Guid("2257c4e3-d38d-454e-bf04-592463f2b6cc"),
                            Amount = 2.0m,
                            Name = "Anchoas"
                        });
                });

            modelBuilder.Entity("Template.Domain.OrderAggregate.DeliveryOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("Addres")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsFree")
                        .HasColumnType("boolean");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("DeliveryOrder", (string)null);
                });

            modelBuilder.Entity("Template.Domain.OrderAggregate.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsFreeDeviliry")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("Template.Domain.OrderAggregate.Pizza", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<decimal>("AmountBase")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("BorderIds")
                        .HasColumnType("uuid");

                    b.Property<int>("CountPizza")
                        .HasColumnType("integer");

                    b.Property<bool>("IsPersonalizate")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("OrderIds")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("RecipePizzaId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("BorderIds");

                    b.HasIndex("OrderIds");

                    b.HasIndex("RecipePizzaId");

                    b.ToTable("Pizza", (string)null);
                });

            modelBuilder.Entity("Template.Domain.RecipePizzaAggregate.RecipePizza", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("RecipePizza", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("295322ec-2295-4032-abda-2286dd622e45"),
                            Description = "Pizza clásica con salsa de tomate, mozzarella y albahaca fresca.",
                            Name = "Pizza Margarita"
                        },
                        new
                        {
                            Id = new Guid("93bb7506-42d7-40e2-9a91-f7da469eada1"),
                            Description = "Pizza con pepperoni y queso mozzarella.",
                            Name = "Pizza Pepperoni"
                        },
                        new
                        {
                            Id = new Guid("a1ac40ba-ad85-45dc-8f6c-9b226d8d8faf"),
                            Description = "Pizza con salsa BBQ, pollo, cebolla y queso mozzarella.",
                            Name = "Pizza BBQ Chicken"
                        },
                        new
                        {
                            Id = new Guid("7e8de948-afa8-4f10-97f2-a3bb0cb9cb19"),
                            Description = "Pizza con jamón, piña y queso mozzarella.",
                            Name = "Pizza Hawaiian"
                        },
                        new
                        {
                            Id = new Guid("97e55f1e-3d3b-4d34-a1f1-48b84171eb9e"),
                            Description = "Pizza vegetariana con champiñones, pimientos, cebolla y aceitunas negras.",
                            Name = "Pizza Veggie Lovers"
                        },
                        new
                        {
                            Id = new Guid("0b6bfa6a-524e-439e-b4ff-4e1ffd9789da"),
                            Description = "Pizza con pepperoni, tocino, carne de res y chorizo.",
                            Name = "Pizza Meat Lovers"
                        });
                });

            modelBuilder.Entity("IngredientPizza", b =>
                {
                    b.HasOne("Template.Domain.IngredientsAggregate.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Template.Domain.OrderAggregate.Pizza", null)
                        .WithMany()
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RecipePizzaIngredient", b =>
                {
                    b.HasOne("Template.Domain.IngredientsAggregate.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Template.Domain.RecipePizzaAggregate.RecipePizza", null)
                        .WithMany()
                        .HasForeignKey("RecipePizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Template.Domain.OrderAggregate.DeliveryOrder", b =>
                {
                    b.HasOne("Template.Domain.OrderAggregate.Order", "Order")
                        .WithOne("DeliveryOrders")
                        .HasForeignKey("Template.Domain.OrderAggregate.DeliveryOrder", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Template.Domain.OrderAggregate.Order", b =>
                {
                    b.HasOne("Template.Domain.ClientAggregate.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Template.Domain.OrderAggregate.Pizza", b =>
                {
                    b.HasOne("Template.Domain.BorderAggregate.Border", "Borders")
                        .WithMany("Pizzas")
                        .HasForeignKey("BorderIds");

                    b.HasOne("Template.Domain.OrderAggregate.Order", "Order")
                        .WithMany("Pizzas")
                        .HasForeignKey("OrderIds")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Template.Domain.RecipePizzaAggregate.RecipePizza", "RecipePizza")
                        .WithMany("Pizzas")
                        .HasForeignKey("RecipePizzaId");

                    b.Navigation("Borders");

                    b.Navigation("Order");

                    b.Navigation("RecipePizza");
                });

            modelBuilder.Entity("Template.Domain.BorderAggregate.Border", b =>
                {
                    b.Navigation("Pizzas");
                });

            modelBuilder.Entity("Template.Domain.ClientAggregate.Client", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Template.Domain.OrderAggregate.Order", b =>
                {
                    b.Navigation("DeliveryOrders");

                    b.Navigation("Pizzas");
                });

            modelBuilder.Entity("Template.Domain.RecipePizzaAggregate.RecipePizza", b =>
                {
                    b.Navigation("Pizzas");
                });
#pragma warning restore 612, 618
        }
    }
}
