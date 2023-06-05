using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyQuickDesk.Migrations
{
    /// <inheritdoc />
    public partial class addRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("0c94d970-0e08-47ad-9476-9dc38ebbba4a"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("5cea36e4-8cbb-45ca-9eba-4e0d3a4ec669"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("6db2b0d1-c17e-415e-ab3b-7dd829f43b1d"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("70041e24-1358-4886-ade7-25e4f6a69926"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("702e253d-6bb3-4fed-ae3a-3917af4002c6"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("81011733-6338-4909-aed6-c1945fdc2eb6"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("84ff339a-373a-402a-93cf-de4707a5c57c"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("90af7801-0efc-41dc-bfb4-efb36a60aa3f"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("a96b1895-b7e5-405d-851c-daa51229fc42"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("ade30f3a-bd58-4af9-9616-d935ac148302"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("b096f91a-e304-46d6-b004-57e33a2394c7"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("ebe5b001-6ea0-4d51-a30f-1474a57ff30f"));

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Spaces");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Spaces");

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("0b454b18-64f8-43f5-9615-1caa2c601b97"), true, null, "ParkingSpot", true, true, 1, "P1A2" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("2841960c-e376-4c07-9fc3-1d96ebc6c34d"), null, "Desk", true, 1, "Biurko B1" },
                    { new Guid("2eae355b-9a7c-4c4d-b0db-94d6b4832858"), null, "Desk", true, 1, "Biurko A3" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("3e93e578-06b8-446c-bd05-d430ae107e3f"), true, null, "ParkingSpot", true, true, 1, "P1B1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("3eb0f9e8-e0c7-48cd-a513-e196c6e531e5"), null, "Room", true, 10, "Neptun" },
                    { new Guid("4100f2a8-5414-4cc8-8912-612c93da8784"), null, "Desk", true, 1, "Biurko B2" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("43c19f19-7864-48c4-8aaa-96160c99fcd7"), true, null, "ParkingSpot", true, true, 1, "P1A1" },
                    { new Guid("75783f97-67a6-4849-a249-988dee99e674"), true, null, "ParkingSpot", true, true, 1, "P1A3" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("8593436a-c985-42f8-8e3b-bfeb96c0b826"), null, "Desk", true, 1, "Biurko A2" },
                    { new Guid("b0d7b0e3-240e-4153-9328-2f958b81f761"), null, "Room", true, 8, "Mariacka" },
                    { new Guid("bfbc2872-4523-43a8-a7a0-c37f43e18cde"), null, "Desk", true, 1, "Biurko A1" },
                    { new Guid("d6cdce25-eede-4db5-97cd-5c37e692d416"), null, "Room", true, 12, "Polityczna" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("0b454b18-64f8-43f5-9615-1caa2c601b97"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("2841960c-e376-4c07-9fc3-1d96ebc6c34d"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("2eae355b-9a7c-4c4d-b0db-94d6b4832858"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("3e93e578-06b8-446c-bd05-d430ae107e3f"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("3eb0f9e8-e0c7-48cd-a513-e196c6e531e5"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("4100f2a8-5414-4cc8-8912-612c93da8784"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("43c19f19-7864-48c4-8aaa-96160c99fcd7"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("75783f97-67a6-4849-a249-988dee99e674"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("8593436a-c985-42f8-8e3b-bfeb96c0b826"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("b0d7b0e3-240e-4153-9328-2f958b81f761"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("bfbc2872-4523-43a8-a7a0-c37f43e18cde"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("d6cdce25-eede-4db5-97cd-5c37e692d416"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                table: "Spaces",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Spaces",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAdmin", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("0c94d970-0e08-47ad-9476-9dc38ebbba4a"), null, null, "Desk", false, true, 1, "Biurko A3" },
                    { new Guid("5cea36e4-8cbb-45ca-9eba-4e0d3a4ec669"), null, null, "Room", false, true, 8, "Mariacka" },
                    { new Guid("6db2b0d1-c17e-415e-ab3b-7dd829f43b1d"), null, null, "Desk", false, true, 1, "Biurko B2" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAdmin", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("70041e24-1358-4886-ade7-25e4f6a69926"), true, null, null, "ParkingSpot", true, false, true, 1, "P1B1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAdmin", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("702e253d-6bb3-4fed-ae3a-3917af4002c6"), null, null, "Desk", false, true, 1, "Biurko A2" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAdmin", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("81011733-6338-4909-aed6-c1945fdc2eb6"), true, null, null, "ParkingSpot", true, false, true, 1, "P1A1" },
                    { new Guid("84ff339a-373a-402a-93cf-de4707a5c57c"), true, null, null, "ParkingSpot", true, false, true, 1, "P1A2" },
                    { new Guid("90af7801-0efc-41dc-bfb4-efb36a60aa3f"), true, null, null, "ParkingSpot", true, false, true, 1, "P1A3" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAdmin", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("a96b1895-b7e5-405d-851c-daa51229fc42"), null, null, "Room", false, true, 10, "Neptun" },
                    { new Guid("ade30f3a-bd58-4af9-9616-d935ac148302"), null, null, "Room", false, true, 12, "Polityczna" },
                    { new Guid("b096f91a-e304-46d6-b004-57e33a2394c7"), null, null, "Desk", false, true, 1, "Biurko A1" },
                    { new Guid("ebe5b001-6ea0-4d51-a30f-1474a57ff30f"), null, null, "Desk", false, true, 1, "Biurko B1" }
                });
        }
    }
}
