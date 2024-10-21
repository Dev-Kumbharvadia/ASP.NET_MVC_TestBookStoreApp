using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreApp.Migrations
{
    /// <inheritdoc />
    public partial class sm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("18ee33fe-4685-40ab-975c-001a9f41e76d"), new Guid("ce416a95-9221-4759-9985-7e41f120419a") });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("21fb38b1-58b5-49f9-9132-c47450eb892a"), new Guid("366fd383-c235-4eb5-933e-249411960cd2") });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("18ee33fe-4685-40ab-975c-001a9f41e76d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("21fb38b1-58b5-49f9-9132-c47450eb892a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("366fd383-c235-4eb5-933e-249411960cd2"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ce416a95-9221-4759-9985-7e41f120419a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5cb62989-8a16-42d0-8eb0-c4f3d66d17f9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c12c9341-3bdb-4f25-98ca-c386b7ab34a0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("18fb0b55-ccae-4522-a77f-415d3cc1ee52"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("abc39ab5-c9ed-4b6b-a070-ba9badf4f2d6"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("4c958310-5440-4560-b606-d22e59dad394"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("7be11046-32bb-4544-9b6a-bcaf28604fbc"));

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b7c26f49-b1d2-4335-9521-0b8248e36c49"), "Robert Caro" },
                    { new Guid("f4cf37ae-4b48-49bf-9f66-04ef7328ca47"), "Frank Herbert" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b28cab58-d821-4012-bbd9-dfddcfbac417"), "Fiction" },
                    { new Guid("dd780687-f37f-4296-a50a-66f5b0489d3a"), "Non-Fiction" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("014c5e28-1f52-44ec-84b8-4e384fc1066f"), "HarperCollins" },
                    { new Guid("a5422972-ec06-4eb2-8fe7-8cda9cc5c546"), "Penguin Random House" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5cbf9458-1c33-4d4b-8cd3-251764d3c57c"), "Biography" },
                    { new Guid("a3af2ca4-81b8-4fd2-ba6b-3b2e309bca43"), "Science Fiction" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CategoryId", "ImageUrl", "PublisherId", "Title" },
                values: new object[,]
                {
                    { new Guid("a885fc06-94d9-47af-8669-3ade83d2f4f9"), new Guid("f4cf37ae-4b48-49bf-9f66-04ef7328ca47"), new Guid("b28cab58-d821-4012-bbd9-dfddcfbac417"), "default-image-dune.jpg", new Guid("a5422972-ec06-4eb2-8fe7-8cda9cc5c546"), "Dune" },
                    { new Guid("efbdc304-b522-4861-ac11-ba0be6fd54b7"), new Guid("b7c26f49-b1d2-4335-9521-0b8248e36c49"), new Guid("dd780687-f37f-4296-a50a-66f5b0489d3a"), "default-image-power-broker.jpg", new Guid("014c5e28-1f52-44ec-84b8-4e384fc1066f"), "The Power Broker" }
                });

            migrationBuilder.InsertData(
                table: "BookTags",
                columns: new[] { "BookId", "TagId" },
                values: new object[,]
                {
                    { new Guid("a885fc06-94d9-47af-8669-3ade83d2f4f9"), new Guid("a3af2ca4-81b8-4fd2-ba6b-3b2e309bca43") },
                    { new Guid("efbdc304-b522-4861-ac11-ba0be6fd54b7"), new Guid("5cbf9458-1c33-4d4b-8cd3-251764d3c57c") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("a885fc06-94d9-47af-8669-3ade83d2f4f9"), new Guid("a3af2ca4-81b8-4fd2-ba6b-3b2e309bca43") });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("efbdc304-b522-4861-ac11-ba0be6fd54b7"), new Guid("5cbf9458-1c33-4d4b-8cd3-251764d3c57c") });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a885fc06-94d9-47af-8669-3ade83d2f4f9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("efbdc304-b522-4861-ac11-ba0be6fd54b7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5cbf9458-1c33-4d4b-8cd3-251764d3c57c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a3af2ca4-81b8-4fd2-ba6b-3b2e309bca43"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b7c26f49-b1d2-4335-9521-0b8248e36c49"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f4cf37ae-4b48-49bf-9f66-04ef7328ca47"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b28cab58-d821-4012-bbd9-dfddcfbac417"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dd780687-f37f-4296-a50a-66f5b0489d3a"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("014c5e28-1f52-44ec-84b8-4e384fc1066f"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("a5422972-ec06-4eb2-8fe7-8cda9cc5c546"));

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5cb62989-8a16-42d0-8eb0-c4f3d66d17f9"), "Robert Caro" },
                    { new Guid("c12c9341-3bdb-4f25-98ca-c386b7ab34a0"), "Frank Herbert" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("18fb0b55-ccae-4522-a77f-415d3cc1ee52"), "Non-Fiction" },
                    { new Guid("abc39ab5-c9ed-4b6b-a070-ba9badf4f2d6"), "Fiction" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4c958310-5440-4560-b606-d22e59dad394"), "HarperCollins" },
                    { new Guid("7be11046-32bb-4544-9b6a-bcaf28604fbc"), "Penguin Random House" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("366fd383-c235-4eb5-933e-249411960cd2"), "Biography" },
                    { new Guid("ce416a95-9221-4759-9985-7e41f120419a"), "Science Fiction" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CategoryId", "ImageUrl", "PublisherId", "Title" },
                values: new object[,]
                {
                    { new Guid("18ee33fe-4685-40ab-975c-001a9f41e76d"), new Guid("c12c9341-3bdb-4f25-98ca-c386b7ab34a0"), new Guid("abc39ab5-c9ed-4b6b-a070-ba9badf4f2d6"), "default-image-dune.jpg", new Guid("7be11046-32bb-4544-9b6a-bcaf28604fbc"), "Dune" },
                    { new Guid("21fb38b1-58b5-49f9-9132-c47450eb892a"), new Guid("5cb62989-8a16-42d0-8eb0-c4f3d66d17f9"), new Guid("18fb0b55-ccae-4522-a77f-415d3cc1ee52"), "default-image-power-broker.jpg", new Guid("4c958310-5440-4560-b606-d22e59dad394"), "The Power Broker" }
                });

            migrationBuilder.InsertData(
                table: "BookTags",
                columns: new[] { "BookId", "TagId" },
                values: new object[,]
                {
                    { new Guid("18ee33fe-4685-40ab-975c-001a9f41e76d"), new Guid("ce416a95-9221-4759-9985-7e41f120419a") },
                    { new Guid("21fb38b1-58b5-49f9-9132-c47450eb892a"), new Guid("366fd383-c235-4eb5-933e-249411960cd2") }
                });
        }
    }
}
