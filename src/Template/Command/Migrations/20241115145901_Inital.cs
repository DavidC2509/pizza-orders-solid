using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

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
                    Description = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false)
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
                    BorderIds = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizza", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pizza_Border_BorderIds",
                        column: x => x.BorderIds,
                        principalTable: "Border",
                        principalColumn: "Id");
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
                    IngredientId = table.Column<Guid>(type: "uuid", nullable: false),
                    RecipePizzaId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipePizzaIngredient", x => new { x.IngredientId, x.RecipePizzaId });
                    table.ForeignKey(
                        name: "FK_RecipePizzaIngredient_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipePizzaIngredient_RecipePizza_RecipePizzaId",
                        column: x => x.RecipePizzaId,
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
                    IngredientId = table.Column<Guid>(type: "uuid", nullable: false),
                    PizzaId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientPizza", x => new { x.IngredientId, x.PizzaId });
                    table.ForeignKey(
                        name: "FK_IngredientPizza_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientPizza_Pizza_PizzaId",
                        column: x => x.PizzaId,
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

            migrationBuilder.InsertData(
                table: "Border",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { new Guid("02ba093d-96a5-4646-affe-5c51583ed790"), "Borde extra crujiente" },
                    { new Guid("1817c44f-1dae-43a2-872a-c25ae3b40b2c"), "Borde relleno de queso cheddar" },
                    { new Guid("192bbc9a-22b0-4985-a906-f91dfecd560c"), "Borde relleno de pepperoni" },
                    { new Guid("19c3a0b2-7be8-4446-8f6c-82d897f78410"), "Borde sin gluten" },
                    { new Guid("3b5ff98d-9971-41b0-908c-ec02c8d3b9ef"), "Borde tradicional" },
                    { new Guid("40cc86c0-86e1-4126-b505-d5edcb00a813"), "Borde con orégano y aceite de oliva" },
                    { new Guid("43837200-33d9-4814-b3b7-d5186fed87f6"), "Borde crujiente" },
                    { new Guid("5a1686b7-4969-456d-9936-dec6f78faf48"), "Borde de queso" },
                    { new Guid("7c822420-65e4-4776-8b04-c4b6e8db6fbb"), "Borde de ajo y mantequilla" },
                    { new Guid("8a844f4a-4b7a-4b26-834d-9610e542b6e6"), "Borde con especias italianas" },
                    { new Guid("8dfc18e2-403d-407b-965f-d993abdbea3f"), "Borde relleno de salchicha" },
                    { new Guid("a0b4a738-0479-44cd-96de-596d541052e1"), "Borde relleno de jalapeños" },
                    { new Guid("c2900aec-9ab7-4fe2-89af-b210b9bdffce"), "Borde de pan de ajo" },
                    { new Guid("ddec3709-f414-49be-a951-38ccac9ecc73"), "Borde con parmesano" },
                    { new Guid("ec82c525-9413-4d3f-bc5f-293e3692946a"), "Sin Borde" },
                    { new Guid("f712c727-ad26-4dce-a374-1d6fcf00654c"), "Borde de masa fina" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "Name" },
                values: new object[,]
                {
                    { new Guid("00455623-5fad-4c25-b023-eaa6312dccf1"), 1.5m, "Salsa de Tomate" },
                    { new Guid("4cc9d738-2f35-4e1e-9ffa-f8ab56e8b42c"), 2.5m, "Pepperoni" },
                    { new Guid("7599ceef-6ac1-4826-bd2d-c912c65108c1"), 1.0m, "Champiñones" },
                    { new Guid("d0c97a12-0442-4bf7-9cc0-36b9960df708"), 2.0m, "Queso" }
                });

            migrationBuilder.InsertData(
                table: "RecipePizza",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("e90074cd-920d-4b07-8669-722365c417cc"), "Pizza con pepperoni y queso mozzarella.", "Pepperoni", 10.0m },
                    { new Guid("f85446d5-28af-446a-b9ed-aada8c234800"), "Pizza clásica con salsa de tomate, mozzarella y albahaca fresca.", "Margarita", 8.5m }
                });

            migrationBuilder.InsertData(
                table: "RecipePizzaIngredient",
                columns: new[] { "IngredientId", "RecipePizzaId" },
                values: new object[,]
                {
                    { new Guid("00455623-5fad-4c25-b023-eaa6312dccf1"), new Guid("f85446d5-28af-446a-b9ed-aada8c234800") },
                    { new Guid("4cc9d738-2f35-4e1e-9ffa-f8ab56e8b42c"), new Guid("e90074cd-920d-4b07-8669-722365c417cc") },
                    { new Guid("d0c97a12-0442-4bf7-9cc0-36b9960df708"), new Guid("e90074cd-920d-4b07-8669-722365c417cc") },
                    { new Guid("d0c97a12-0442-4bf7-9cc0-36b9960df708"), new Guid("f85446d5-28af-446a-b9ed-aada8c234800") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientPizza_PizzaId",
                table: "IngredientPizza",
                column: "PizzaId");

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
                name: "IX_RecipePizzaIngredient_RecipePizzaId",
                table: "RecipePizzaIngredient",
                column: "RecipePizzaId");
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
