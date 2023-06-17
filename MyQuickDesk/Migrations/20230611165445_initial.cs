using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyQuickDesk.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("08fa6d82-7705-4a36-a8a2-d93b2c72b5b0"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("1181c881-dc78-4d37-9f67-e6e87c94ccc6"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("30e202c2-0a29-48a6-ab27-f5b2b006db79"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("5a6b2856-078e-4977-b31c-2035c5be1c13"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("71286cce-3a8a-4761-8f99-3241994c52e5"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("8a977b4a-6945-40a2-968f-23cde452aa76"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("8db753a8-5975-4a28-a09e-43e0d14e8639"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("94772cfd-de17-4e5f-9ece-0f2752eb55bb"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("97ac94bc-81d2-4f48-9e0f-ff806e975e6a"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("a1179c99-57af-42b2-a568-df4434a84e18"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("d2338cf4-d76d-4147-ae53-af9b8e66ebbf"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("df9af4d7-31be-495e-b0b2-9761c8612dd9"));

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("38abf647-b05f-4769-8fe2-ec58f037730f"), true, null, null, "ParkingSpot", true, true, 1, "P1A3" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("40991d3c-e221-4c94-8d68-68fba1249abf"), null, null, "Desk", true, 1, "Biurko A1" },
                    { new Guid("4e37895c-7c29-4be4-a2af-88c3f9fbde6b"), null, null, "Room", true, 12, "Polityczna" },
                    { new Guid("5e2ce314-6150-49c9-985b-b2d923de187c"), null, null, "Room", true, 8, "Mariacka" },
                    { new Guid("65bcff2e-de75-47ba-b47c-54a6bdf91fca"), null, null, "Desk", true, 1, "Biurko A3" },
                    { new Guid("78b726f7-8a69-41ba-8409-4acedb800f46"), null, null, "Desk", true, 1, "Biurko B2" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("8147505b-73e6-4ea1-8d44-573420b64eff"), true, null, null, "ParkingSpot", true, true, 1, "P1A2" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("cb2c212b-f00e-4617-b2fb-df93f024201c"), null, null, "Desk", true, 1, "Biurko B1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("dabd8dcf-b5fd-4d38-bbb1-327871e04a65"), true, null, null, "ParkingSpot", true, true, 1, "P1A1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("de704863-b600-4024-a371-b91bc4fd9bac"), null, null, "Room", true, 10, "Neptun" },
                    { new Guid("e8672eb6-9c20-43f4-8fcf-64dd943498d0"), null, null, "Desk", true, 1, "Biurko A2" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("f4e68b48-bcb2-45e2-98fd-64faff25add5"), true, null, null, "ParkingSpot", true, true, 1, "P1B1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("38abf647-b05f-4769-8fe2-ec58f037730f"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("40991d3c-e221-4c94-8d68-68fba1249abf"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("4e37895c-7c29-4be4-a2af-88c3f9fbde6b"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("5e2ce314-6150-49c9-985b-b2d923de187c"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("65bcff2e-de75-47ba-b47c-54a6bdf91fca"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("78b726f7-8a69-41ba-8409-4acedb800f46"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("8147505b-73e6-4ea1-8d44-573420b64eff"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("cb2c212b-f00e-4617-b2fb-df93f024201c"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("dabd8dcf-b5fd-4d38-bbb1-327871e04a65"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("de704863-b600-4024-a371-b91bc4fd9bac"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("e8672eb6-9c20-43f4-8fcf-64dd943498d0"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("f4e68b48-bcb2-45e2-98fd-64faff25add5"));

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("08fa6d82-7705-4a36-a8a2-d93b2c72b5b0"), null, null, "Room", true, 10, "Neptun" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("1181c881-dc78-4d37-9f67-e6e87c94ccc6"), true, null, null, "ParkingSpot", true, true, 1, "P1A1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("30e202c2-0a29-48a6-ab27-f5b2b006db79"), null, null, "Desk", true, 1, "Biurko B1" },
                    { new Guid("5a6b2856-078e-4977-b31c-2035c5be1c13"), null, null, "Room", true, 8, "Mariacka" },
                    { new Guid("71286cce-3a8a-4761-8f99-3241994c52e5"), null, null, "Room", true, 12, "Polityczna" },
                    { new Guid("8a977b4a-6945-40a2-968f-23cde452aa76"), null, null, "Desk", true, 1, "Biurko A2" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("8db753a8-5975-4a28-a09e-43e0d14e8639"), true, null, null, "ParkingSpot", true, true, 1, "P1A3" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("94772cfd-de17-4e5f-9ece-0f2752eb55bb"), null, null, "Desk", true, 1, "Biurko A3" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("97ac94bc-81d2-4f48-9e0f-ff806e975e6a"), true, null, null, "ParkingSpot", true, true, 1, "P1B1" },
                    { new Guid("a1179c99-57af-42b2-a568-df4434a84e18"), true, null, null, "ParkingSpot", true, true, 1, "P1A2" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("d2338cf4-d76d-4147-ae53-af9b8e66ebbf"), null, null, "Desk", true, 1, "Biurko B2" },
                    { new Guid("df9af4d7-31be-495e-b0b2-9761c8612dd9"), null, null, "Desk", true, 1, "Biurko A1" }
                });
        }
    }
}
