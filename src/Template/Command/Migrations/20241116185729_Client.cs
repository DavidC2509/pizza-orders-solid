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
                    { new Guid("03eaa2ae-93f1-401c-a4c7-9d1702ffecfa"), "Borde de pan de ajo" },
                    { new Guid("03eba4e3-41e7-42a2-aa2e-4ff9d41ad765"), "Borde relleno de jalapeños" },
                    { new Guid("0dc798cd-4eeb-4fbe-8e3c-a8230d094178"), "Borde crujiente" },
                    { new Guid("169689dd-a62c-4a52-bb3f-d595f953fd18"), "Borde tradicional" },
                    { new Guid("1732894f-d900-4c66-a055-c262769fdefd"), "Borde relleno de queso cheddar" },
                    { new Guid("178383be-a7ea-4ba9-ac23-4c0e988a4517"), "Borde relleno de pepperoni" },
                    { new Guid("4b2dba3a-4c26-4128-ab4c-7d9a582d190e"), "Sin Borde" },
                    { new Guid("5b680a4d-6bb9-471a-b439-8974897c6abb"), "Borde sin gluten" },
                    { new Guid("856a7715-233f-481d-bb30-4f04733fcb97"), "Borde de ajo y mantequilla" },
                    { new Guid("b4d8eed6-c7fc-46b3-8006-4d29276ae8b4"), "Borde relleno de salchicha" },
                    { new Guid("ceb959eb-490e-43cd-977f-6d2694821a7d"), "Borde de masa fina" },
                    { new Guid("d455b7d7-500e-495b-abf1-101e79f86828"), "Borde de queso" },
                    { new Guid("e3ff1608-1d08-4124-901a-5fd362a4bdb3"), "Borde con especias italianas" },
                    { new Guid("e6388a2f-cd62-40ae-b277-932230fa4d26"), "Borde con parmesano" },
                    { new Guid("ed53fc75-ce37-4fe0-aafe-82c226a8c7e8"), "Borde con orégano y aceite de oliva" },
                    { new Guid("f66987ef-6e0c-459c-afa1-7d7d4126001d"), "Borde extra crujiente" }
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "CellPhone", "Email", "Name" },
                values: new object[] { new Guid("889c9cea-e6d0-4db0-94a0-c11b6e3b979a"), "75324397", "davidFernando@gmil.com", "David" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "Name" },
                values: new object[,]
                {
                    { new Guid("0c89840f-7a39-47db-a5e0-eedefecc55c0"), 1.2m, "Aceitunas Negras" },
                    { new Guid("2149f625-bf01-494a-a988-fba3d8fe45d1"), 1.8m, "Salsa BBQ" },
                    { new Guid("2257c4e3-d38d-454e-bf04-592463f2b6cc"), 2.0m, "Anchoas" },
                    { new Guid("25fd06d3-ec4a-425b-a6ab-7e9873b1903b"), 2.0m, "Queso" },
                    { new Guid("3315bf2d-4d4b-45be-bbf1-3c7a395fb6bb"), 2.0m, "Jamón" },
                    { new Guid("6c0cb6da-ffe8-473e-abd0-fccf2d8cd932"), 0.7m, "Albahaca Fresca" },
                    { new Guid("6db90ecb-080b-409f-8047-8cc75e0ec860"), 1.0m, "Champiñones" },
                    { new Guid("91ad4938-f113-4b54-93ff-c56415e90277"), 1.5m, "Salsa Alfredo" },
                    { new Guid("9a5262ee-d21e-439a-97e9-cb7b2bc7bd56"), 2.5m, "Tocino" },
                    { new Guid("a13d58a7-9b05-40f4-aa72-da86782552c2"), 2.5m, "Pepperoni" },
                    { new Guid("a36dcc7e-f8a2-4cbb-ba57-3c37dc7247b2"), 2.0m, "Queso Mozzarella" },
                    { new Guid("a425ebbc-3bdb-45d0-8de6-eaeb8df03442"), 1.5m, "Queso Parmesano" },
                    { new Guid("b206eaee-629e-439f-8658-e84c8d6fe300"), 0.8m, "Cebolla" },
                    { new Guid("b38e49ad-149d-4c18-a717-9e6da504eb3d"), 1.0m, "Jalapeños" },
                    { new Guid("b9cf9bfa-f173-409c-a2db-9b50837120cd"), 2.5m, "Pollo" },
                    { new Guid("bfa4f04e-9c6b-4aca-b95e-284d349db2fb"), 1.5m, "Salsa de Tomate" },
                    { new Guid("cdf21b5f-6d6e-4cea-8f31-30495698be50"), 2.8m, "Chorizo" },
                    { new Guid("d41441e0-a6f2-42f3-9718-d233e0cbf0b4"), 1.5m, "Piña" },
                    { new Guid("da7fe135-a41a-4a9e-859b-f25e3f3cf3b0"), 1.0m, "Tomates Cherry" },
                    { new Guid("e8dbde95-9da9-4e12-a7cb-37f0fcbedd8d"), 3.0m, "Carne de Res" }
                });

            migrationBuilder.InsertData(
                table: "RecipePizza",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0b6bfa6a-524e-439e-b4ff-4e1ffd9789da"), "Pizza con pepperoni, tocino, carne de res y chorizo.", "Pizza Meat Lovers" },
                    { new Guid("295322ec-2295-4032-abda-2286dd622e45"), "Pizza clásica con salsa de tomate, mozzarella y albahaca fresca.", "Pizza Margarita" },
                    { new Guid("7e8de948-afa8-4f10-97f2-a3bb0cb9cb19"), "Pizza con jamón, piña y queso mozzarella.", "Pizza Hawaiian" },
                    { new Guid("93bb7506-42d7-40e2-9a91-f7da469eada1"), "Pizza con pepperoni y queso mozzarella.", "Pizza Pepperoni" },
                    { new Guid("97e55f1e-3d3b-4d34-a1f1-48b84171eb9e"), "Pizza vegetariana con champiñones, pimientos, cebolla y aceitunas negras.", "Pizza Veggie Lovers" },
                    { new Guid("a1ac40ba-ad85-45dc-8f6c-9b226d8d8faf"), "Pizza con salsa BBQ, pollo, cebolla y queso mozzarella.", "Pizza BBQ Chicken" }
                });

            migrationBuilder.InsertData(
                table: "RecipePizzaIngredient",
                columns: new[] { "IngredientId", "RecipePizzaId" },
                values: new object[,]
                {
                    { new Guid("0c89840f-7a39-47db-a5e0-eedefecc55c0"), new Guid("97e55f1e-3d3b-4d34-a1f1-48b84171eb9e") },
                    { new Guid("2149f625-bf01-494a-a988-fba3d8fe45d1"), new Guid("a1ac40ba-ad85-45dc-8f6c-9b226d8d8faf") },
                    { new Guid("25fd06d3-ec4a-425b-a6ab-7e9873b1903b"), new Guid("295322ec-2295-4032-abda-2286dd622e45") },
                    { new Guid("25fd06d3-ec4a-425b-a6ab-7e9873b1903b"), new Guid("93bb7506-42d7-40e2-9a91-f7da469eada1") },
                    { new Guid("3315bf2d-4d4b-45be-bbf1-3c7a395fb6bb"), new Guid("7e8de948-afa8-4f10-97f2-a3bb0cb9cb19") },
                    { new Guid("6c0cb6da-ffe8-473e-abd0-fccf2d8cd932"), new Guid("295322ec-2295-4032-abda-2286dd622e45") },
                    { new Guid("6db90ecb-080b-409f-8047-8cc75e0ec860"), new Guid("97e55f1e-3d3b-4d34-a1f1-48b84171eb9e") },
                    { new Guid("9a5262ee-d21e-439a-97e9-cb7b2bc7bd56"), new Guid("0b6bfa6a-524e-439e-b4ff-4e1ffd9789da") },
                    { new Guid("a13d58a7-9b05-40f4-aa72-da86782552c2"), new Guid("0b6bfa6a-524e-439e-b4ff-4e1ffd9789da") },
                    { new Guid("a13d58a7-9b05-40f4-aa72-da86782552c2"), new Guid("93bb7506-42d7-40e2-9a91-f7da469eada1") },
                    { new Guid("a36dcc7e-f8a2-4cbb-ba57-3c37dc7247b2"), new Guid("7e8de948-afa8-4f10-97f2-a3bb0cb9cb19") },
                    { new Guid("a36dcc7e-f8a2-4cbb-ba57-3c37dc7247b2"), new Guid("a1ac40ba-ad85-45dc-8f6c-9b226d8d8faf") },
                    { new Guid("b206eaee-629e-439f-8658-e84c8d6fe300"), new Guid("97e55f1e-3d3b-4d34-a1f1-48b84171eb9e") },
                    { new Guid("b206eaee-629e-439f-8658-e84c8d6fe300"), new Guid("a1ac40ba-ad85-45dc-8f6c-9b226d8d8faf") },
                    { new Guid("b9cf9bfa-f173-409c-a2db-9b50837120cd"), new Guid("a1ac40ba-ad85-45dc-8f6c-9b226d8d8faf") },
                    { new Guid("bfa4f04e-9c6b-4aca-b95e-284d349db2fb"), new Guid("295322ec-2295-4032-abda-2286dd622e45") },
                    { new Guid("cdf21b5f-6d6e-4cea-8f31-30495698be50"), new Guid("0b6bfa6a-524e-439e-b4ff-4e1ffd9789da") },
                    { new Guid("d41441e0-a6f2-42f3-9718-d233e0cbf0b4"), new Guid("7e8de948-afa8-4f10-97f2-a3bb0cb9cb19") },
                    { new Guid("da7fe135-a41a-4a9e-859b-f25e3f3cf3b0"), new Guid("97e55f1e-3d3b-4d34-a1f1-48b84171eb9e") },
                    { new Guid("e8dbde95-9da9-4e12-a7cb-37f0fcbedd8d"), new Guid("0b6bfa6a-524e-439e-b4ff-4e1ffd9789da") }
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
