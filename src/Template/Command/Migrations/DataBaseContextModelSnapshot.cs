﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Template.Command.Database;

#nullable disable

namespace Template.Command.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("IngredientPizza", b =>
                {
                    b.Property<Guid>("IngredientsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PizzasId")
                        .HasColumnType("uuid");

                    b.HasKey("IngredientsId", "PizzasId");

                    b.HasIndex("PizzasId");

                    b.ToTable("IngredientPizza");
                });

            modelBuilder.Entity("OrderPizzas", b =>
                {
                    b.Property<Guid>("OrdersId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PizzasId")
                        .HasColumnType("uuid");

                    b.HasKey("OrdersId", "PizzasId");

                    b.HasIndex("PizzasId");

                    b.ToTable("OrderPizzas");
                });

            modelBuilder.Entity("RecipePizzaIngredient", b =>
                {
                    b.Property<Guid>("IngredientsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RecipePizzasId")
                        .HasColumnType("uuid");

                    b.HasKey("IngredientsId", "RecipePizzasId");

                    b.HasIndex("RecipePizzasId");

                    b.ToTable("RecipePizzaIngredient");
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
                });

            modelBuilder.Entity("Template.Domain.OrderAggregate.DeliveryOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

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

            modelBuilder.Entity("Template.Domain.PizzaAggregate.Pizza", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<decimal>("AmountBase")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("BorderIds")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsPersonalizate")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("RecipePizzaId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("BorderIds");

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
                });

            modelBuilder.Entity("IngredientPizza", b =>
                {
                    b.HasOne("Template.Domain.IngredientsAggregate.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Template.Domain.PizzaAggregate.Pizza", null)
                        .WithMany()
                        .HasForeignKey("PizzasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrderPizzas", b =>
                {
                    b.HasOne("Template.Domain.OrderAggregate.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Template.Domain.PizzaAggregate.Pizza", null)
                        .WithMany()
                        .HasForeignKey("PizzasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RecipePizzaIngredient", b =>
                {
                    b.HasOne("Template.Domain.IngredientsAggregate.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Template.Domain.RecipePizzaAggregate.RecipePizza", null)
                        .WithMany()
                        .HasForeignKey("RecipePizzasId")
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

            modelBuilder.Entity("Template.Domain.PizzaAggregate.Pizza", b =>
                {
                    b.HasOne("Template.Domain.BorderAggregate.Border", "Borders")
                        .WithMany("Pizzas")
                        .HasForeignKey("BorderIds")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Template.Domain.RecipePizzaAggregate.RecipePizza", "RecipePizza")
                        .WithMany("Pizzas")
                        .HasForeignKey("RecipePizzaId");

                    b.Navigation("Borders");

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
                });

            modelBuilder.Entity("Template.Domain.RecipePizzaAggregate.RecipePizza", b =>
                {
                    b.Navigation("Pizzas");
                });
#pragma warning restore 612, 618
        }
    }
}
