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
                    Price = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Addres = table.Column<string>(type: "text", nullable: false)
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
                name: "Pizza",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsPersonalizate = table.Column<bool>(type: "boolean", nullable: false),
                    AmountBase = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    RecipePizzaId = table.Column<Guid>(type: "uuid", nullable: true),
                    BorderIds = table.Column<Guid>(type: "uuid", nullable: true),
                    CountPizza = table.Column<int>(type: "integer", nullable: false),
                    OrderIds = table.Column<Guid>(type: "uuid", nullable: false)
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
                        name: "FK_Pizza_Order_OrderIds",
                        column: x => x.OrderIds,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pizza_RecipePizza_RecipePizzaId",
                        column: x => x.RecipePizzaId,
                        principalTable: "RecipePizza",
                        principalColumn: "Id");
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

            migrationBuilder.InsertData(
                table: "Border",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { new Guid("1ef9c581-bd5d-451c-a244-951efec08571"), "Borde con orégano y aceite de oliva" },
                    { new Guid("479f31ff-01f1-43af-83a0-613334bf7cd6"), "Borde relleno de pepperoni" },
                    { new Guid("4c6dc9c0-6815-455d-9926-4f7975c14e99"), "Borde relleno de jalapeños" },
                    { new Guid("4dd4f15b-5941-45dd-af60-8454d9dd8501"), "Borde con especias italianas" },
                    { new Guid("56970674-45a3-435b-9091-a3522270564c"), "Borde de ajo y mantequilla" },
                    { new Guid("58de5407-766a-45a7-8493-198bf726ac74"), "Borde relleno de queso cheddar" },
                    { new Guid("79cdbd1a-afc5-40b9-9c8d-abde59a2e1b1"), "Borde con parmesano" },
                    { new Guid("7bd0c1e5-06c8-4fb3-bb29-d78e430c6426"), "Borde tradicional" },
                    { new Guid("8ae7e6c1-f669-4876-ba14-9499c5e8e208"), "Borde de queso" },
                    { new Guid("b8cff44f-47d9-477c-a19c-884010caa200"), "Borde crujiente" },
                    { new Guid("bf658193-4602-41df-b0fb-cba8a9b8ebb9"), "Borde extra crujiente" },
                    { new Guid("bfae8279-4963-4135-af85-9236b5cd3b33"), "Sin Borde" },
                    { new Guid("c4cb884f-0fc4-47be-9fb0-3ac576fffc11"), "Borde relleno de salchicha" },
                    { new Guid("c9c7114a-da6c-4706-8fa6-26bd852c736d"), "Borde sin gluten" },
                    { new Guid("e21110e7-8295-47a3-8bec-9958ed1b8aae"), "Borde de pan de ajo" },
                    { new Guid("ed3a9f00-2674-49b0-9102-b74712a63c36"), "Borde de masa fina" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "Name" },
                values: new object[,]
                {
                    { new Guid("0046619f-4168-410d-a0ee-c418f2214e4a"), 2.0m, "Queso" },
                    { new Guid("02ed3593-31c2-4d3a-85fa-8c45bd457bf6"), 1.5m, "Salsa de Tomate" },
                    { new Guid("1f5fb29c-2373-4468-af49-efda6adb3122"), 1.5m, "Queso Parmesano" },
                    { new Guid("2de173f9-9ccc-438a-b20c-e385e6ce05bf"), 2.5m, "Tocino" },
                    { new Guid("380c18ff-76b7-4498-8c69-94e342c76953"), 1.0m, "Champiñones" },
                    { new Guid("4783de6f-1270-41f5-bf00-6615cf7c22b5"), 0.8m, "Cebolla" },
                    { new Guid("50954a8c-e0c2-4ede-9655-fea3b84a1ed8"), 1.2m, "Aceitunas Negras" },
                    { new Guid("63f1afea-7706-43c6-bc87-5b35a0e5485b"), 1.0m, "Jalapeños" },
                    { new Guid("74fa2993-a6fe-4bc8-aeee-fdd6fffc29c1"), 2.0m, "Anchoas" },
                    { new Guid("852686c2-4a67-4750-901d-e36f811323d0"), 0.7m, "Albahaca Fresca" },
                    { new Guid("8928edb4-9f68-4576-9f97-72f48e88bbe6"), 2.5m, "Pollo" },
                    { new Guid("91ff1bec-3bc3-4d6d-a239-8a5be4ea04d5"), 1.0m, "Tomates Cherry" },
                    { new Guid("a0632a81-2282-4bd5-a359-8553416be456"), 2.8m, "Chorizo" },
                    { new Guid("acc22e08-c701-4202-80c7-577d07ecd42e"), 2.5m, "Pepperoni" },
                    { new Guid("afa850c3-798c-4bdc-aa97-98676435544c"), 2.0m, "Jamón" },
                    { new Guid("cc6e81a7-ab99-48da-a27a-18567e610319"), 1.5m, "Salsa Alfredo" },
                    { new Guid("cc8ce24c-e369-410f-ad52-ab6b8cb4f9bf"), 1.8m, "Salsa BBQ" },
                    { new Guid("cf8138b3-9655-4575-83ad-7beb4bd2a2da"), 1.5m, "Piña" },
                    { new Guid("e6a79ab3-8267-4b16-b839-56bba798c856"), 2.0m, "Queso Mozzarella" },
                    { new Guid("f47af8d8-b9fb-442e-b03d-959b47c511c0"), 3.0m, "Carne de Res" }
                });

            migrationBuilder.InsertData(
                table: "RecipePizza",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("6f491d54-96bd-48e1-a46a-612cbc77e152"), "Pizza con pepperoni y queso mozzarella.", "Pizza Pepperoni", 10.0m },
                    { new Guid("8181b572-2d65-49fb-a726-722bb66fcba7"), "Pizza con jamón, piña y queso mozzarella.", "Pizza Hawaiian", 11.0m },
                    { new Guid("967bb814-adef-4b52-874f-0ed7310fc7bb"), "Pizza con pepperoni, tocino, carne de res y chorizo.", "Pizza Meat Lovers", 14.0m },
                    { new Guid("9b18b54b-6e30-454b-b840-01e36c9efab9"), "Pizza vegetariana con champiñones, pimientos, cebolla y aceitunas negras.", "Pizza Veggie Lovers", 10.0m },
                    { new Guid("ab758b64-6c21-4ee8-918b-16214e39304f"), "Pizza clásica con salsa de tomate, mozzarella y albahaca fresca.", "Pizza Margarita", 8.5m },
                    { new Guid("edb52c01-e497-43a3-9542-34df6d5df6b2"), "Pizza con salsa BBQ, pollo, cebolla y queso mozzarella.", "Pizza BBQ Chicken", 12.0m }
                });

            migrationBuilder.InsertData(
                table: "RecipePizzaIngredient",
                columns: new[] { "IngredientId", "RecipePizzaId" },
                values: new object[,]
                {
                    { new Guid("0046619f-4168-410d-a0ee-c418f2214e4a"), new Guid("6f491d54-96bd-48e1-a46a-612cbc77e152") },
                    { new Guid("0046619f-4168-410d-a0ee-c418f2214e4a"), new Guid("ab758b64-6c21-4ee8-918b-16214e39304f") },
                    { new Guid("02ed3593-31c2-4d3a-85fa-8c45bd457bf6"), new Guid("ab758b64-6c21-4ee8-918b-16214e39304f") },
                    { new Guid("2de173f9-9ccc-438a-b20c-e385e6ce05bf"), new Guid("967bb814-adef-4b52-874f-0ed7310fc7bb") },
                    { new Guid("380c18ff-76b7-4498-8c69-94e342c76953"), new Guid("9b18b54b-6e30-454b-b840-01e36c9efab9") },
                    { new Guid("4783de6f-1270-41f5-bf00-6615cf7c22b5"), new Guid("9b18b54b-6e30-454b-b840-01e36c9efab9") },
                    { new Guid("4783de6f-1270-41f5-bf00-6615cf7c22b5"), new Guid("edb52c01-e497-43a3-9542-34df6d5df6b2") },
                    { new Guid("50954a8c-e0c2-4ede-9655-fea3b84a1ed8"), new Guid("9b18b54b-6e30-454b-b840-01e36c9efab9") },
                    { new Guid("852686c2-4a67-4750-901d-e36f811323d0"), new Guid("ab758b64-6c21-4ee8-918b-16214e39304f") },
                    { new Guid("8928edb4-9f68-4576-9f97-72f48e88bbe6"), new Guid("edb52c01-e497-43a3-9542-34df6d5df6b2") },
                    { new Guid("91ff1bec-3bc3-4d6d-a239-8a5be4ea04d5"), new Guid("9b18b54b-6e30-454b-b840-01e36c9efab9") },
                    { new Guid("a0632a81-2282-4bd5-a359-8553416be456"), new Guid("967bb814-adef-4b52-874f-0ed7310fc7bb") },
                    { new Guid("acc22e08-c701-4202-80c7-577d07ecd42e"), new Guid("6f491d54-96bd-48e1-a46a-612cbc77e152") },
                    { new Guid("acc22e08-c701-4202-80c7-577d07ecd42e"), new Guid("967bb814-adef-4b52-874f-0ed7310fc7bb") },
                    { new Guid("afa850c3-798c-4bdc-aa97-98676435544c"), new Guid("8181b572-2d65-49fb-a726-722bb66fcba7") },
                    { new Guid("cc8ce24c-e369-410f-ad52-ab6b8cb4f9bf"), new Guid("edb52c01-e497-43a3-9542-34df6d5df6b2") },
                    { new Guid("cf8138b3-9655-4575-83ad-7beb4bd2a2da"), new Guid("8181b572-2d65-49fb-a726-722bb66fcba7") },
                    { new Guid("e6a79ab3-8267-4b16-b839-56bba798c856"), new Guid("8181b572-2d65-49fb-a726-722bb66fcba7") },
                    { new Guid("e6a79ab3-8267-4b16-b839-56bba798c856"), new Guid("edb52c01-e497-43a3-9542-34df6d5df6b2") },
                    { new Guid("f47af8d8-b9fb-442e-b03d-959b47c511c0"), new Guid("967bb814-adef-4b52-874f-0ed7310fc7bb") }
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
                name: "IX_Pizza_BorderIds",
                table: "Pizza",
                column: "BorderIds");

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_OrderIds",
                table: "Pizza",
                column: "OrderIds");

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
                name: "RecipePizzaIngredient");

            migrationBuilder.DropTable(
                name: "Pizza");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Border");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "RecipePizza");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
