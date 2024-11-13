using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Template.Command.Migrations
{
    /// <inheritdoc />
    public partial class Inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Border",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Border", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    CellPhone = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecipePizza",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipePizza", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Total = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    IsFreeDeviliry = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pizza",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsPersonalizate = table.Column<bool>(type: "boolean", nullable: false),
                    AmountBase = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    RecipePizzaId = table.Column<Guid>(type: "uuid", nullable: true),
                    BorderIds = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizza", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pizza_Border_BorderIds",
                        column: x => x.BorderIds,
                        principalTable: "Border",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pizza_RecipePizza_RecipePizzaId",
                        column: x => x.RecipePizzaId,
                        principalTable: "RecipePizza",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RecipePizzaIngredient",
                columns: table => new
                {
                    IngredientsId = table.Column<Guid>(type: "uuid", nullable: false),
                    RecipePizzasId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipePizzaIngredient", x => new { x.IngredientsId, x.RecipePizzasId });
                    table.ForeignKey(
                        name: "FK_RecipePizzaIngredient_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipePizzaIngredient_RecipePizza_RecipePizzasId",
                        column: x => x.RecipePizzasId,
                        principalTable: "RecipePizza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryOrder",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    IsFree = table.Column<bool>(type: "boolean", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryOrder_Order_Id",
                        column: x => x.Id,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngredientPizza",
                columns: table => new
                {
                    IngredientsId = table.Column<Guid>(type: "uuid", nullable: false),
                    PizzasId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientPizza", x => new { x.IngredientsId, x.PizzasId });
                    table.ForeignKey(
                        name: "FK_IngredientPizza_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientPizza_Pizza_PizzasId",
                        column: x => x.PizzasId,
                        principalTable: "Pizza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderPizzas",
                columns: table => new
                {
                    OrdersId = table.Column<Guid>(type: "uuid", nullable: false),
                    PizzasId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPizzas", x => new { x.OrdersId, x.PizzasId });
                    table.ForeignKey(
                        name: "FK_OrderPizzas_Order_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderPizzas_Pizza_PizzasId",
                        column: x => x.PizzasId,
                        principalTable: "Pizza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientPizza_PizzasId",
                table: "IngredientPizza",
                column: "PizzasId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ClientId",
                table: "Order",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPizzas_PizzasId",
                table: "OrderPizzas",
                column: "PizzasId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_BorderIds",
                table: "Pizza",
                column: "BorderIds");

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_RecipePizzaId",
                table: "Pizza",
                column: "RecipePizzaId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipePizzaIngredient_RecipePizzasId",
                table: "RecipePizzaIngredient",
                column: "RecipePizzasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeliveryOrder");

            migrationBuilder.DropTable(
                name: "IngredientPizza");

            migrationBuilder.DropTable(
                name: "OrderPizzas");

            migrationBuilder.DropTable(
                name: "RecipePizzaIngredient");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Pizza");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Border");

            migrationBuilder.DropTable(
                name: "RecipePizza");
        }
    }
}
