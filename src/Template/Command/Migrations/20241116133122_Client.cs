using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Template.Command.Migrations
{
    /// <inheritdoc />
    public partial class Client : Migration
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
                    { new Guid("00703883-1d97-44a1-8f0d-a9e105549723"), "Borde con parmesano" },
                    { new Guid("09854117-8297-4e39-9712-b158d9ff146d"), "Borde sin gluten" },
                    { new Guid("0da62c40-ab3c-419f-9ff2-993d902ce5b4"), "Borde extra crujiente" },
                    { new Guid("1949adc8-6567-41f0-b791-eb54137764c5"), "Borde con especias italianas" },
                    { new Guid("2c2549e9-06b2-471c-a3ca-7a854b9de0ee"), "Borde relleno de pepperoni" },
                    { new Guid("4a4731dc-c1ef-4231-a555-e9c986bc6e25"), "Borde de ajo y mantequilla" },
                    { new Guid("506892bb-0b3f-409e-b91c-15e3ec750fe6"), "Borde de pan de ajo" },
                    { new Guid("7285db60-d1f4-4fa6-a960-9e7fac32c146"), "Borde relleno de salchicha" },
                    { new Guid("7d953028-4493-4a90-83c6-425a2b44eb36"), "Borde tradicional" },
                    { new Guid("81f2b649-eab2-491c-b27b-42ebe1fc2026"), "Borde de queso" },
                    { new Guid("83fd4bbe-f9cf-4411-9683-3f7b4e548fbc"), "Borde crujiente" },
                    { new Guid("93ef8f1e-fdb4-4d5b-a582-ea442e1948cd"), "Sin Borde" },
                    { new Guid("99978b8a-a4d5-4176-9072-fcadaa8cd67b"), "Borde relleno de jalapeños" },
                    { new Guid("b3f53797-5a52-4a18-a071-93e73c66bec9"), "Borde con orégano y aceite de oliva" },
                    { new Guid("dbb11233-1041-4bb9-8522-9be490e1f99c"), "Borde relleno de queso cheddar" },
                    { new Guid("e071459b-a95c-4fb1-ac92-6bf3ccee555f"), "Borde de masa fina" }
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "CellPhone", "Email", "Name" },
                values: new object[] { new Guid("806b8e1d-8de5-4884-a53d-eac49a8a241b"), "75324397", "davidFernando@gmil.com", "David" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "Name" },
                values: new object[,]
                {
                    { new Guid("0489f895-910f-413c-936a-417afddbfad3"), 2.5m, "Pepperoni" },
                    { new Guid("0657ff4a-84bf-4b0a-ab54-06fbb875af8a"), 1.0m, "Champiñones" },
                    { new Guid("06a2162e-a3ef-4a9b-9b59-efe558cb3b98"), 2.0m, "Queso" },
                    { new Guid("0e9216cf-e85c-4bf5-a057-f10a4b389ec5"), 1.5m, "Queso Parmesano" },
                    { new Guid("135a8ae8-e779-40aa-8713-006670352c08"), 1.5m, "Piña" },
                    { new Guid("4209713e-aa77-43f7-b8b1-eca4c0ad8ee9"), 0.8m, "Cebolla" },
                    { new Guid("5d3e0af6-07d2-4396-8a9d-9362ecb1cedb"), 2.5m, "Pollo" },
                    { new Guid("6226d057-efd4-4b0d-a03a-ac2633fb52cb"), 1.2m, "Aceitunas Negras" },
                    { new Guid("7f4b8d20-ebaa-47bf-a527-aff38b9a7a18"), 2.0m, "Queso Mozzarella" },
                    { new Guid("81e7fdbd-715a-41fb-a450-c49bcff1c0be"), 1.8m, "Salsa BBQ" },
                    { new Guid("ae13fcb3-c066-46d6-881b-ccf1bcdddc5b"), 1.0m, "Tomates Cherry" },
                    { new Guid("bb7d0566-48ff-4387-a0bc-aae579e8394c"), 2.8m, "Chorizo" },
                    { new Guid("bb8ead18-a0fc-4d64-a006-70d3e7657c73"), 1.5m, "Salsa de Tomate" },
                    { new Guid("c1acc73c-205c-442e-beb0-cd1ecdc895ee"), 0.7m, "Albahaca Fresca" },
                    { new Guid("c83d7c12-6143-47e8-b28b-bb4c83451718"), 1.0m, "Jalapeños" },
                    { new Guid("d1c0ece3-ac34-45d1-bba3-d8a9428b4bcf"), 1.5m, "Salsa Alfredo" },
                    { new Guid("ea7ff681-d972-4ac9-a6de-a62c0727e1df"), 2.0m, "Anchoas" },
                    { new Guid("f03d8891-170e-4e51-b5b9-8c9533b6e7b9"), 2.0m, "Jamón" },
                    { new Guid("f5d80e36-05ba-4b66-88ca-1e6116a22de5"), 3.0m, "Carne de Res" },
                    { new Guid("faf7f0ad-25b0-415b-8912-aaed1a4dd950"), 2.5m, "Tocino" }
                });

            migrationBuilder.InsertData(
                table: "RecipePizza",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("289b34c2-bcdf-45a0-8b5a-4f02068210b2"), "Pizza con jamón, piña y queso mozzarella.", "Pizza Hawaiian", 11.0m },
                    { new Guid("3e7c4ca0-def6-4330-b183-a9c9aff98ed1"), "Pizza con pepperoni, tocino, carne de res y chorizo.", "Pizza Meat Lovers", 14.0m },
                    { new Guid("9b29438f-528b-4d43-bdcc-ea8201b88ef1"), "Pizza con pepperoni y queso mozzarella.", "Pizza Pepperoni", 10.0m },
                    { new Guid("a5969e99-f699-49c6-aa35-59915579b5ce"), "Pizza clásica con salsa de tomate, mozzarella y albahaca fresca.", "Pizza Margarita", 8.5m },
                    { new Guid("be80bb47-1ef4-467d-8c7f-e77ed692b0fe"), "Pizza vegetariana con champiñones, pimientos, cebolla y aceitunas negras.", "Pizza Veggie Lovers", 10.0m },
                    { new Guid("caed479b-1e3c-42b3-b284-bd18b1f8c0d6"), "Pizza con salsa BBQ, pollo, cebolla y queso mozzarella.", "Pizza BBQ Chicken", 12.0m }
                });

            migrationBuilder.InsertData(
                table: "RecipePizzaIngredient",
                columns: new[] { "IngredientId", "RecipePizzaId" },
                values: new object[,]
                {
                    { new Guid("0489f895-910f-413c-936a-417afddbfad3"), new Guid("3e7c4ca0-def6-4330-b183-a9c9aff98ed1") },
                    { new Guid("0489f895-910f-413c-936a-417afddbfad3"), new Guid("9b29438f-528b-4d43-bdcc-ea8201b88ef1") },
                    { new Guid("0657ff4a-84bf-4b0a-ab54-06fbb875af8a"), new Guid("be80bb47-1ef4-467d-8c7f-e77ed692b0fe") },
                    { new Guid("06a2162e-a3ef-4a9b-9b59-efe558cb3b98"), new Guid("9b29438f-528b-4d43-bdcc-ea8201b88ef1") },
                    { new Guid("06a2162e-a3ef-4a9b-9b59-efe558cb3b98"), new Guid("a5969e99-f699-49c6-aa35-59915579b5ce") },
                    { new Guid("135a8ae8-e779-40aa-8713-006670352c08"), new Guid("289b34c2-bcdf-45a0-8b5a-4f02068210b2") },
                    { new Guid("4209713e-aa77-43f7-b8b1-eca4c0ad8ee9"), new Guid("be80bb47-1ef4-467d-8c7f-e77ed692b0fe") },
                    { new Guid("4209713e-aa77-43f7-b8b1-eca4c0ad8ee9"), new Guid("caed479b-1e3c-42b3-b284-bd18b1f8c0d6") },
                    { new Guid("5d3e0af6-07d2-4396-8a9d-9362ecb1cedb"), new Guid("caed479b-1e3c-42b3-b284-bd18b1f8c0d6") },
                    { new Guid("6226d057-efd4-4b0d-a03a-ac2633fb52cb"), new Guid("be80bb47-1ef4-467d-8c7f-e77ed692b0fe") },
                    { new Guid("7f4b8d20-ebaa-47bf-a527-aff38b9a7a18"), new Guid("289b34c2-bcdf-45a0-8b5a-4f02068210b2") },
                    { new Guid("7f4b8d20-ebaa-47bf-a527-aff38b9a7a18"), new Guid("caed479b-1e3c-42b3-b284-bd18b1f8c0d6") },
                    { new Guid("81e7fdbd-715a-41fb-a450-c49bcff1c0be"), new Guid("caed479b-1e3c-42b3-b284-bd18b1f8c0d6") },
                    { new Guid("ae13fcb3-c066-46d6-881b-ccf1bcdddc5b"), new Guid("be80bb47-1ef4-467d-8c7f-e77ed692b0fe") },
                    { new Guid("bb7d0566-48ff-4387-a0bc-aae579e8394c"), new Guid("3e7c4ca0-def6-4330-b183-a9c9aff98ed1") },
                    { new Guid("bb8ead18-a0fc-4d64-a006-70d3e7657c73"), new Guid("a5969e99-f699-49c6-aa35-59915579b5ce") },
                    { new Guid("c1acc73c-205c-442e-beb0-cd1ecdc895ee"), new Guid("a5969e99-f699-49c6-aa35-59915579b5ce") },
                    { new Guid("f03d8891-170e-4e51-b5b9-8c9533b6e7b9"), new Guid("289b34c2-bcdf-45a0-8b5a-4f02068210b2") },
                    { new Guid("f5d80e36-05ba-4b66-88ca-1e6116a22de5"), new Guid("3e7c4ca0-def6-4330-b183-a9c9aff98ed1") },
                    { new Guid("faf7f0ad-25b0-415b-8912-aaed1a4dd950"), new Guid("3e7c4ca0-def6-4330-b183-a9c9aff98ed1") }
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
