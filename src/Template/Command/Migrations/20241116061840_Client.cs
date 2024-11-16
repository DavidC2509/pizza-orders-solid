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
            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("1ef9c581-bd5d-451c-a244-951efec08571"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("479f31ff-01f1-43af-83a0-613334bf7cd6"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("4c6dc9c0-6815-455d-9926-4f7975c14e99"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("4dd4f15b-5941-45dd-af60-8454d9dd8501"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("56970674-45a3-435b-9091-a3522270564c"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("58de5407-766a-45a7-8493-198bf726ac74"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("79cdbd1a-afc5-40b9-9c8d-abde59a2e1b1"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("7bd0c1e5-06c8-4fb3-bb29-d78e430c6426"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("8ae7e6c1-f669-4876-ba14-9499c5e8e208"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("b8cff44f-47d9-477c-a19c-884010caa200"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("bf658193-4602-41df-b0fb-cba8a9b8ebb9"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("bfae8279-4963-4135-af85-9236b5cd3b33"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("c4cb884f-0fc4-47be-9fb0-3ac576fffc11"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("c9c7114a-da6c-4706-8fa6-26bd852c736d"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("e21110e7-8295-47a3-8bec-9958ed1b8aae"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("ed3a9f00-2674-49b0-9102-b74712a63c36"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("1f5fb29c-2373-4468-af49-efda6adb3122"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("63f1afea-7706-43c6-bc87-5b35a0e5485b"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("74fa2993-a6fe-4bc8-aeee-fdd6fffc29c1"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("cc6e81a7-ab99-48da-a27a-18567e610319"));

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("0046619f-4168-410d-a0ee-c418f2214e4a"), new Guid("6f491d54-96bd-48e1-a46a-612cbc77e152") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("0046619f-4168-410d-a0ee-c418f2214e4a"), new Guid("ab758b64-6c21-4ee8-918b-16214e39304f") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("02ed3593-31c2-4d3a-85fa-8c45bd457bf6"), new Guid("ab758b64-6c21-4ee8-918b-16214e39304f") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("2de173f9-9ccc-438a-b20c-e385e6ce05bf"), new Guid("967bb814-adef-4b52-874f-0ed7310fc7bb") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("380c18ff-76b7-4498-8c69-94e342c76953"), new Guid("9b18b54b-6e30-454b-b840-01e36c9efab9") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("4783de6f-1270-41f5-bf00-6615cf7c22b5"), new Guid("9b18b54b-6e30-454b-b840-01e36c9efab9") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("4783de6f-1270-41f5-bf00-6615cf7c22b5"), new Guid("edb52c01-e497-43a3-9542-34df6d5df6b2") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("50954a8c-e0c2-4ede-9655-fea3b84a1ed8"), new Guid("9b18b54b-6e30-454b-b840-01e36c9efab9") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("852686c2-4a67-4750-901d-e36f811323d0"), new Guid("ab758b64-6c21-4ee8-918b-16214e39304f") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("8928edb4-9f68-4576-9f97-72f48e88bbe6"), new Guid("edb52c01-e497-43a3-9542-34df6d5df6b2") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("91ff1bec-3bc3-4d6d-a239-8a5be4ea04d5"), new Guid("9b18b54b-6e30-454b-b840-01e36c9efab9") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("a0632a81-2282-4bd5-a359-8553416be456"), new Guid("967bb814-adef-4b52-874f-0ed7310fc7bb") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("acc22e08-c701-4202-80c7-577d07ecd42e"), new Guid("6f491d54-96bd-48e1-a46a-612cbc77e152") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("acc22e08-c701-4202-80c7-577d07ecd42e"), new Guid("967bb814-adef-4b52-874f-0ed7310fc7bb") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("afa850c3-798c-4bdc-aa97-98676435544c"), new Guid("8181b572-2d65-49fb-a726-722bb66fcba7") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("cc8ce24c-e369-410f-ad52-ab6b8cb4f9bf"), new Guid("edb52c01-e497-43a3-9542-34df6d5df6b2") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("cf8138b3-9655-4575-83ad-7beb4bd2a2da"), new Guid("8181b572-2d65-49fb-a726-722bb66fcba7") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("e6a79ab3-8267-4b16-b839-56bba798c856"), new Guid("8181b572-2d65-49fb-a726-722bb66fcba7") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("e6a79ab3-8267-4b16-b839-56bba798c856"), new Guid("edb52c01-e497-43a3-9542-34df6d5df6b2") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("f47af8d8-b9fb-442e-b03d-959b47c511c0"), new Guid("967bb814-adef-4b52-874f-0ed7310fc7bb") });

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("0046619f-4168-410d-a0ee-c418f2214e4a"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("02ed3593-31c2-4d3a-85fa-8c45bd457bf6"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("2de173f9-9ccc-438a-b20c-e385e6ce05bf"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("380c18ff-76b7-4498-8c69-94e342c76953"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("4783de6f-1270-41f5-bf00-6615cf7c22b5"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("50954a8c-e0c2-4ede-9655-fea3b84a1ed8"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("852686c2-4a67-4750-901d-e36f811323d0"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("8928edb4-9f68-4576-9f97-72f48e88bbe6"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("91ff1bec-3bc3-4d6d-a239-8a5be4ea04d5"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("a0632a81-2282-4bd5-a359-8553416be456"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("acc22e08-c701-4202-80c7-577d07ecd42e"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("afa850c3-798c-4bdc-aa97-98676435544c"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("cc8ce24c-e369-410f-ad52-ab6b8cb4f9bf"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("cf8138b3-9655-4575-83ad-7beb4bd2a2da"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("e6a79ab3-8267-4b16-b839-56bba798c856"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("f47af8d8-b9fb-442e-b03d-959b47c511c0"));

            migrationBuilder.DeleteData(
                table: "RecipePizza",
                keyColumn: "Id",
                keyValue: new Guid("6f491d54-96bd-48e1-a46a-612cbc77e152"));

            migrationBuilder.DeleteData(
                table: "RecipePizza",
                keyColumn: "Id",
                keyValue: new Guid("8181b572-2d65-49fb-a726-722bb66fcba7"));

            migrationBuilder.DeleteData(
                table: "RecipePizza",
                keyColumn: "Id",
                keyValue: new Guid("967bb814-adef-4b52-874f-0ed7310fc7bb"));

            migrationBuilder.DeleteData(
                table: "RecipePizza",
                keyColumn: "Id",
                keyValue: new Guid("9b18b54b-6e30-454b-b840-01e36c9efab9"));

            migrationBuilder.DeleteData(
                table: "RecipePizza",
                keyColumn: "Id",
                keyValue: new Guid("ab758b64-6c21-4ee8-918b-16214e39304f"));

            migrationBuilder.DeleteData(
                table: "RecipePizza",
                keyColumn: "Id",
                keyValue: new Guid("edb52c01-e497-43a3-9542-34df6d5df6b2"));

            migrationBuilder.InsertData(
                table: "Border",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { new Guid("003f2dc0-b273-486c-b952-76d0e8786ebd"), "Sin Borde" },
                    { new Guid("0cef82d9-b8d6-4a1d-94ae-08aefcbcadf7"), "Borde relleno de queso cheddar" },
                    { new Guid("0e3054f7-7f66-4540-ac6e-3d57c140d930"), "Borde extra crujiente" },
                    { new Guid("1464dd9d-4448-4344-9350-c6a5be5bdd84"), "Borde de queso" },
                    { new Guid("16ea2589-4bd3-4a06-972c-6d8eb9490a3d"), "Borde tradicional" },
                    { new Guid("1840bad6-3f22-4761-b95e-92e032ea0581"), "Borde relleno de salchicha" },
                    { new Guid("29b3e47e-3eb9-4c5e-be9a-7f71b4e14f09"), "Borde relleno de jalapeños" },
                    { new Guid("42f20f20-4328-4f4e-a4f1-1472dcff201e"), "Borde de ajo y mantequilla" },
                    { new Guid("4809532b-d38c-4ace-b05a-47b06325c161"), "Borde sin gluten" },
                    { new Guid("58fbc043-4776-4af8-b398-0d77404f075d"), "Borde de masa fina" },
                    { new Guid("6b4f140d-37b8-4732-9760-1c160c05ed8d"), "Borde con especias italianas" },
                    { new Guid("c96ac994-c02a-4b59-af0f-4561718de601"), "Borde de pan de ajo" },
                    { new Guid("dd9f9761-699f-4ae8-bb48-adbecdda1c44"), "Borde relleno de pepperoni" },
                    { new Guid("eae6ff13-f7fa-46eb-808e-9b006e698488"), "Borde crujiente" },
                    { new Guid("ef52ceb3-4ad8-45ce-ad65-fe164a02b8f6"), "Borde con orégano y aceite de oliva" },
                    { new Guid("fa8b702b-203f-4de2-9aec-3291cc1bf9a8"), "Borde con parmesano" }
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "CellPhone", "Email", "Name" },
                values: new object[] { new Guid("28f1aa92-81d0-47f8-9bee-3464466b9b31"), "75324397", "davidFernando@gmil.com", "David" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Amount", "Name" },
                values: new object[,]
                {
                    { new Guid("12d9836a-0c9e-41b6-acff-53b35aa5c3c9"), 1.0m, "Jalapeños" },
                    { new Guid("14a02fdf-8de4-49ef-98df-59d8e8d308b3"), 0.8m, "Cebolla" },
                    { new Guid("26590268-5b95-4336-bf14-b9db1c6534ce"), 2.0m, "Jamón" },
                    { new Guid("33cadc7e-f861-490f-b3ec-d4ebc4c7cf21"), 2.5m, "Tocino" },
                    { new Guid("40d0560c-c3c6-4553-b297-0d2b024cf249"), 1.8m, "Salsa BBQ" },
                    { new Guid("4b28cdfa-0f5c-4820-98ed-4acc132c3299"), 2.0m, "Anchoas" },
                    { new Guid("4dac0e72-010b-4a6c-ae9b-e4d20c7664e5"), 2.5m, "Pollo" },
                    { new Guid("5402502d-04c5-4939-a9c9-2928f7c5a18f"), 1.5m, "Salsa de Tomate" },
                    { new Guid("58a3defc-5963-4bdf-b3fe-7cbd61d681e4"), 3.0m, "Carne de Res" },
                    { new Guid("5fd6e567-eab7-4af2-99cb-1a2a688e4128"), 1.0m, "Champiñones" },
                    { new Guid("6573c568-d0f8-41e1-9658-bff0935a36e4"), 0.7m, "Albahaca Fresca" },
                    { new Guid("750730bb-597c-49d3-9979-aa3afa9ab97e"), 1.0m, "Tomates Cherry" },
                    { new Guid("85dc4e31-3661-4f42-a552-f4e829cd765f"), 2.5m, "Pepperoni" },
                    { new Guid("8bec8b77-a1be-4596-9b7d-e1874edf5fa7"), 1.5m, "Salsa Alfredo" },
                    { new Guid("a9248381-23db-4de3-8d47-7ad2c2f9bd95"), 2.0m, "Queso Mozzarella" },
                    { new Guid("b5a0e248-2398-4908-a597-0e0318fda2b2"), 1.5m, "Queso Parmesano" },
                    { new Guid("ba523c79-b2f1-41d7-a58d-a36c9616532f"), 2.0m, "Queso" },
                    { new Guid("ccc0f882-51f1-4ea1-bc3e-681bd6ba8b96"), 2.8m, "Chorizo" },
                    { new Guid("d25d38ec-bec5-4554-9220-7f0a7e2cf8c3"), 1.5m, "Piña" },
                    { new Guid("d409fcab-4dd9-4f8c-a149-8cf4ca420897"), 1.2m, "Aceitunas Negras" }
                });

            migrationBuilder.InsertData(
                table: "RecipePizza",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("37470a01-52f0-4552-b62b-4d6d4fb93fb8"), "Pizza con pepperoni, tocino, carne de res y chorizo.", "Pizza Meat Lovers", 14.0m },
                    { new Guid("513015e2-ed64-4990-8f4e-136a1115959d"), "Pizza con pepperoni y queso mozzarella.", "Pizza Pepperoni", 10.0m },
                    { new Guid("ca207b5f-28ef-4156-a4e2-7baebca48748"), "Pizza vegetariana con champiñones, pimientos, cebolla y aceitunas negras.", "Pizza Veggie Lovers", 10.0m },
                    { new Guid("e0cd7c0d-36b7-4b70-b172-64b9f9c031d4"), "Pizza con salsa BBQ, pollo, cebolla y queso mozzarella.", "Pizza BBQ Chicken", 12.0m },
                    { new Guid("e4f3b841-7e6d-45b4-9b7b-a2fd5506b5c8"), "Pizza clásica con salsa de tomate, mozzarella y albahaca fresca.", "Pizza Margarita", 8.5m },
                    { new Guid("fab5a4fb-8964-40a9-83b1-a11ac5737499"), "Pizza con jamón, piña y queso mozzarella.", "Pizza Hawaiian", 11.0m }
                });

            migrationBuilder.InsertData(
                table: "RecipePizzaIngredient",
                columns: new[] { "IngredientId", "RecipePizzaId" },
                values: new object[,]
                {
                    { new Guid("14a02fdf-8de4-49ef-98df-59d8e8d308b3"), new Guid("ca207b5f-28ef-4156-a4e2-7baebca48748") },
                    { new Guid("14a02fdf-8de4-49ef-98df-59d8e8d308b3"), new Guid("e0cd7c0d-36b7-4b70-b172-64b9f9c031d4") },
                    { new Guid("26590268-5b95-4336-bf14-b9db1c6534ce"), new Guid("fab5a4fb-8964-40a9-83b1-a11ac5737499") },
                    { new Guid("33cadc7e-f861-490f-b3ec-d4ebc4c7cf21"), new Guid("37470a01-52f0-4552-b62b-4d6d4fb93fb8") },
                    { new Guid("40d0560c-c3c6-4553-b297-0d2b024cf249"), new Guid("e0cd7c0d-36b7-4b70-b172-64b9f9c031d4") },
                    { new Guid("4dac0e72-010b-4a6c-ae9b-e4d20c7664e5"), new Guid("e0cd7c0d-36b7-4b70-b172-64b9f9c031d4") },
                    { new Guid("5402502d-04c5-4939-a9c9-2928f7c5a18f"), new Guid("e4f3b841-7e6d-45b4-9b7b-a2fd5506b5c8") },
                    { new Guid("58a3defc-5963-4bdf-b3fe-7cbd61d681e4"), new Guid("37470a01-52f0-4552-b62b-4d6d4fb93fb8") },
                    { new Guid("5fd6e567-eab7-4af2-99cb-1a2a688e4128"), new Guid("ca207b5f-28ef-4156-a4e2-7baebca48748") },
                    { new Guid("6573c568-d0f8-41e1-9658-bff0935a36e4"), new Guid("e4f3b841-7e6d-45b4-9b7b-a2fd5506b5c8") },
                    { new Guid("750730bb-597c-49d3-9979-aa3afa9ab97e"), new Guid("ca207b5f-28ef-4156-a4e2-7baebca48748") },
                    { new Guid("85dc4e31-3661-4f42-a552-f4e829cd765f"), new Guid("37470a01-52f0-4552-b62b-4d6d4fb93fb8") },
                    { new Guid("85dc4e31-3661-4f42-a552-f4e829cd765f"), new Guid("513015e2-ed64-4990-8f4e-136a1115959d") },
                    { new Guid("a9248381-23db-4de3-8d47-7ad2c2f9bd95"), new Guid("e0cd7c0d-36b7-4b70-b172-64b9f9c031d4") },
                    { new Guid("a9248381-23db-4de3-8d47-7ad2c2f9bd95"), new Guid("fab5a4fb-8964-40a9-83b1-a11ac5737499") },
                    { new Guid("ba523c79-b2f1-41d7-a58d-a36c9616532f"), new Guid("513015e2-ed64-4990-8f4e-136a1115959d") },
                    { new Guid("ba523c79-b2f1-41d7-a58d-a36c9616532f"), new Guid("e4f3b841-7e6d-45b4-9b7b-a2fd5506b5c8") },
                    { new Guid("ccc0f882-51f1-4ea1-bc3e-681bd6ba8b96"), new Guid("37470a01-52f0-4552-b62b-4d6d4fb93fb8") },
                    { new Guid("d25d38ec-bec5-4554-9220-7f0a7e2cf8c3"), new Guid("fab5a4fb-8964-40a9-83b1-a11ac5737499") },
                    { new Guid("d409fcab-4dd9-4f8c-a149-8cf4ca420897"), new Guid("ca207b5f-28ef-4156-a4e2-7baebca48748") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("003f2dc0-b273-486c-b952-76d0e8786ebd"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("0cef82d9-b8d6-4a1d-94ae-08aefcbcadf7"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("0e3054f7-7f66-4540-ac6e-3d57c140d930"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("1464dd9d-4448-4344-9350-c6a5be5bdd84"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("16ea2589-4bd3-4a06-972c-6d8eb9490a3d"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("1840bad6-3f22-4761-b95e-92e032ea0581"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("29b3e47e-3eb9-4c5e-be9a-7f71b4e14f09"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("42f20f20-4328-4f4e-a4f1-1472dcff201e"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("4809532b-d38c-4ace-b05a-47b06325c161"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("58fbc043-4776-4af8-b398-0d77404f075d"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("6b4f140d-37b8-4732-9760-1c160c05ed8d"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("c96ac994-c02a-4b59-af0f-4561718de601"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("dd9f9761-699f-4ae8-bb48-adbecdda1c44"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("eae6ff13-f7fa-46eb-808e-9b006e698488"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("ef52ceb3-4ad8-45ce-ad65-fe164a02b8f6"));

            migrationBuilder.DeleteData(
                table: "Border",
                keyColumn: "Id",
                keyValue: new Guid("fa8b702b-203f-4de2-9aec-3291cc1bf9a8"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "Id",
                keyValue: new Guid("28f1aa92-81d0-47f8-9bee-3464466b9b31"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("12d9836a-0c9e-41b6-acff-53b35aa5c3c9"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("4b28cdfa-0f5c-4820-98ed-4acc132c3299"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("8bec8b77-a1be-4596-9b7d-e1874edf5fa7"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("b5a0e248-2398-4908-a597-0e0318fda2b2"));

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("14a02fdf-8de4-49ef-98df-59d8e8d308b3"), new Guid("ca207b5f-28ef-4156-a4e2-7baebca48748") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("14a02fdf-8de4-49ef-98df-59d8e8d308b3"), new Guid("e0cd7c0d-36b7-4b70-b172-64b9f9c031d4") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("26590268-5b95-4336-bf14-b9db1c6534ce"), new Guid("fab5a4fb-8964-40a9-83b1-a11ac5737499") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("33cadc7e-f861-490f-b3ec-d4ebc4c7cf21"), new Guid("37470a01-52f0-4552-b62b-4d6d4fb93fb8") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("40d0560c-c3c6-4553-b297-0d2b024cf249"), new Guid("e0cd7c0d-36b7-4b70-b172-64b9f9c031d4") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("4dac0e72-010b-4a6c-ae9b-e4d20c7664e5"), new Guid("e0cd7c0d-36b7-4b70-b172-64b9f9c031d4") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("5402502d-04c5-4939-a9c9-2928f7c5a18f"), new Guid("e4f3b841-7e6d-45b4-9b7b-a2fd5506b5c8") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("58a3defc-5963-4bdf-b3fe-7cbd61d681e4"), new Guid("37470a01-52f0-4552-b62b-4d6d4fb93fb8") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("5fd6e567-eab7-4af2-99cb-1a2a688e4128"), new Guid("ca207b5f-28ef-4156-a4e2-7baebca48748") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("6573c568-d0f8-41e1-9658-bff0935a36e4"), new Guid("e4f3b841-7e6d-45b4-9b7b-a2fd5506b5c8") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("750730bb-597c-49d3-9979-aa3afa9ab97e"), new Guid("ca207b5f-28ef-4156-a4e2-7baebca48748") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("85dc4e31-3661-4f42-a552-f4e829cd765f"), new Guid("37470a01-52f0-4552-b62b-4d6d4fb93fb8") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("85dc4e31-3661-4f42-a552-f4e829cd765f"), new Guid("513015e2-ed64-4990-8f4e-136a1115959d") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("a9248381-23db-4de3-8d47-7ad2c2f9bd95"), new Guid("e0cd7c0d-36b7-4b70-b172-64b9f9c031d4") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("a9248381-23db-4de3-8d47-7ad2c2f9bd95"), new Guid("fab5a4fb-8964-40a9-83b1-a11ac5737499") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("ba523c79-b2f1-41d7-a58d-a36c9616532f"), new Guid("513015e2-ed64-4990-8f4e-136a1115959d") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("ba523c79-b2f1-41d7-a58d-a36c9616532f"), new Guid("e4f3b841-7e6d-45b4-9b7b-a2fd5506b5c8") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("ccc0f882-51f1-4ea1-bc3e-681bd6ba8b96"), new Guid("37470a01-52f0-4552-b62b-4d6d4fb93fb8") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("d25d38ec-bec5-4554-9220-7f0a7e2cf8c3"), new Guid("fab5a4fb-8964-40a9-83b1-a11ac5737499") });

            migrationBuilder.DeleteData(
                table: "RecipePizzaIngredient",
                keyColumns: new[] { "IngredientId", "RecipePizzaId" },
                keyValues: new object[] { new Guid("d409fcab-4dd9-4f8c-a149-8cf4ca420897"), new Guid("ca207b5f-28ef-4156-a4e2-7baebca48748") });

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("14a02fdf-8de4-49ef-98df-59d8e8d308b3"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("26590268-5b95-4336-bf14-b9db1c6534ce"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("33cadc7e-f861-490f-b3ec-d4ebc4c7cf21"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("40d0560c-c3c6-4553-b297-0d2b024cf249"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("4dac0e72-010b-4a6c-ae9b-e4d20c7664e5"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("5402502d-04c5-4939-a9c9-2928f7c5a18f"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("58a3defc-5963-4bdf-b3fe-7cbd61d681e4"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("5fd6e567-eab7-4af2-99cb-1a2a688e4128"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("6573c568-d0f8-41e1-9658-bff0935a36e4"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("750730bb-597c-49d3-9979-aa3afa9ab97e"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("85dc4e31-3661-4f42-a552-f4e829cd765f"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("a9248381-23db-4de3-8d47-7ad2c2f9bd95"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("ba523c79-b2f1-41d7-a58d-a36c9616532f"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("ccc0f882-51f1-4ea1-bc3e-681bd6ba8b96"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("d25d38ec-bec5-4554-9220-7f0a7e2cf8c3"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("d409fcab-4dd9-4f8c-a149-8cf4ca420897"));

            migrationBuilder.DeleteData(
                table: "RecipePizza",
                keyColumn: "Id",
                keyValue: new Guid("37470a01-52f0-4552-b62b-4d6d4fb93fb8"));

            migrationBuilder.DeleteData(
                table: "RecipePizza",
                keyColumn: "Id",
                keyValue: new Guid("513015e2-ed64-4990-8f4e-136a1115959d"));

            migrationBuilder.DeleteData(
                table: "RecipePizza",
                keyColumn: "Id",
                keyValue: new Guid("ca207b5f-28ef-4156-a4e2-7baebca48748"));

            migrationBuilder.DeleteData(
                table: "RecipePizza",
                keyColumn: "Id",
                keyValue: new Guid("e0cd7c0d-36b7-4b70-b172-64b9f9c031d4"));

            migrationBuilder.DeleteData(
                table: "RecipePizza",
                keyColumn: "Id",
                keyValue: new Guid("e4f3b841-7e6d-45b4-9b7b-a2fd5506b5c8"));

            migrationBuilder.DeleteData(
                table: "RecipePizza",
                keyColumn: "Id",
                keyValue: new Guid("fab5a4fb-8964-40a9-83b1-a11ac5737499"));

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
        }
    }
}
