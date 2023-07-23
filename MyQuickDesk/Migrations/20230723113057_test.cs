using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyQuickDesk.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("04fecc9b-3f79-4529-843c-847b84c276be"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("05f9f9b4-af86-44a6-b3f1-6523d6372291"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("1c926b8c-acd3-4d8e-b6e7-c9e0902aee1e"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("3d84fc43-91aa-4e2d-90d6-25a6d5aacb5a"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("48dfbc8e-a779-4588-a48a-bc2d5a9e5420"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("6f85a73a-d56a-476a-bac0-8445d56d0f37"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("711381aa-85ae-4c38-ba06-7268c77a15dc"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("763cc096-6762-4ff8-a0a8-9cb7464a723e"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("7f698cf0-e92d-444d-b184-4290ff17266f"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("8f067289-45b3-4923-a082-6e9ff4b47d3e"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("debd8e78-70f8-44e4-8387-58f9ba0f879d"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("f3b3e9d0-8426-4bec-b8e8-f69d4f554ba5"));

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("1d19bb25-9419-4418-8f86-9078858cac97"), null, null, "Room", true, 10, "Neptun" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("254582e2-58ba-430f-9fa8-3d79cc58f704"), true, null, null, "ParkingSpot", true, true, 1, "P1B1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("36496ec0-9cdd-4034-8c6b-7e7754f5c856"), null, null, "Desk", true, 1, "Biurko B2" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("4a455b2b-8ab4-432f-a7ac-4bb0097306f7"), true, null, null, "ParkingSpot", true, true, 1, "P1A1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("4d81eb53-822d-4e3d-a3de-b6097ab76daa"), null, null, "Room", true, 12, "Polityczna" },
                    { new Guid("6a4a3eea-7dc0-4ab0-a758-8f88bbc4c5d7"), null, null, "Desk", true, 1, "Biurko A2" },
                    { new Guid("9d9e2f40-f5f5-4eec-8b9e-1d056406422a"), null, null, "Desk", true, 1, "Biurko B1" },
                    { new Guid("add79558-d591-481f-8cf5-b9b6b048f5a1"), null, null, "Desk", true, 1, "Biurko A1" },
                    { new Guid("ca52c343-62df-429b-a2ff-dbe66db6c028"), null, null, "Room", true, 8, "Mariacka" },
                    { new Guid("cfb98b07-5799-4bc9-a728-0bbc9cae4c1a"), null, null, "Desk", true, 1, "Biurko A3" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("d55c4bef-4e54-4926-a0a0-23bfa28f8cfd"), true, null, null, "ParkingSpot", true, true, 1, "P1A3" },
                    { new Guid("d68f639d-ccf6-4e6f-99a6-0be10524ad65"), true, null, null, "ParkingSpot", true, true, 1, "P1A2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("1d19bb25-9419-4418-8f86-9078858cac97"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("254582e2-58ba-430f-9fa8-3d79cc58f704"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("36496ec0-9cdd-4034-8c6b-7e7754f5c856"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("4a455b2b-8ab4-432f-a7ac-4bb0097306f7"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("4d81eb53-822d-4e3d-a3de-b6097ab76daa"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("6a4a3eea-7dc0-4ab0-a758-8f88bbc4c5d7"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("9d9e2f40-f5f5-4eec-8b9e-1d056406422a"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("add79558-d591-481f-8cf5-b9b6b048f5a1"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("ca52c343-62df-429b-a2ff-dbe66db6c028"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("cfb98b07-5799-4bc9-a728-0bbc9cae4c1a"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("d55c4bef-4e54-4926-a0a0-23bfa28f8cfd"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("d68f639d-ccf6-4e6f-99a6-0be10524ad65"));

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("04fecc9b-3f79-4529-843c-847b84c276be"), null, null, "Room", true, 8, "Mariacka" },
                    { new Guid("05f9f9b4-af86-44a6-b3f1-6523d6372291"), null, null, "Desk", true, 1, "Biurko A1" },
                    { new Guid("1c926b8c-acd3-4d8e-b6e7-c9e0902aee1e"), null, null, "Desk", true, 1, "Biurko B2" },
                    { new Guid("3d84fc43-91aa-4e2d-90d6-25a6d5aacb5a"), null, null, "Desk", true, 1, "Biurko A3" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("48dfbc8e-a779-4588-a48a-bc2d5a9e5420"), true, null, null, "ParkingSpot", true, true, 1, "P1A1" },
                    { new Guid("6f85a73a-d56a-476a-bac0-8445d56d0f37"), true, null, null, "ParkingSpot", true, true, 1, "P1A3" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("711381aa-85ae-4c38-ba06-7268c77a15dc"), null, null, "Room", true, 10, "Neptun" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("763cc096-6762-4ff8-a0a8-9cb7464a723e"), true, null, null, "ParkingSpot", true, true, 1, "P1A2" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("7f698cf0-e92d-444d-b184-4290ff17266f"), null, null, "Desk", true, 1, "Biurko A2" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("8f067289-45b3-4923-a082-6e9ff4b47d3e"), true, null, null, "ParkingSpot", true, true, 1, "P1B1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("debd8e78-70f8-44e4-8387-58f9ba0f879d"), null, null, "Desk", true, 1, "Biurko B1" },
                    { new Guid("f3b3e9d0-8426-4bec-b8e8-f69d4f554ba5"), null, null, "Room", true, 12, "Polityczna" }
                });
        }
    }
}
