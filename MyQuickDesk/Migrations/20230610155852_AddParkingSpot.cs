using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyQuickDesk.Migrations
{
    /// <inheritdoc />
    public partial class AddParkingSpot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("13f3768c-a1ae-430a-afb5-515b52033eef"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("35f3df14-73d2-4feb-bb1b-791fea1e106a"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("49bc182c-d2a6-4616-b0bf-75760b814447"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("85ae60af-9711-4f6d-8592-a6f53c5cae23"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("917ce128-cba8-4a80-97b3-86c8a8c4e62c"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("a8e998af-4836-4e5f-ab7a-044ebd77f80b"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("bdee39f6-cb5d-4d65-8af9-adc3b902c40f"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("d844ca9e-da11-4a80-9590-c357437b2bce"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("e60abb8e-6ffb-4af7-aad5-5576d2ab23e6"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("ec50f408-9a4b-4433-9e99-278c726ab5f9"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("f77ac16c-21af-42e7-98fa-59d569b57b67"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("f92b4f68-5187-4e75-a6df-cc446fa926d4"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("13f3768c-a1ae-430a-afb5-515b52033eef"), null, null, "Desk", true, 1, "Biurko A2" },
                    { new Guid("35f3df14-73d2-4feb-bb1b-791fea1e106a"), null, null, "Room", true, 12, "Polityczna" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("49bc182c-d2a6-4616-b0bf-75760b814447"), true, null, null, "ParkingSpot", true, true, 1, "P1A2" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("85ae60af-9711-4f6d-8592-a6f53c5cae23"), null, null, "Room", true, 10, "Neptun" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("917ce128-cba8-4a80-97b3-86c8a8c4e62c"), true, null, null, "ParkingSpot", true, true, 1, "P1A3" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("a8e998af-4836-4e5f-ab7a-044ebd77f80b"), null, null, "Desk", true, 1, "Biurko B2" },
                    { new Guid("bdee39f6-cb5d-4d65-8af9-adc3b902c40f"), null, null, "Desk", true, 1, "Biurko B1" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("d844ca9e-da11-4a80-9590-c357437b2bce"), true, null, null, "ParkingSpot", true, true, 1, "P1B1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("e60abb8e-6ffb-4af7-aad5-5576d2ab23e6"), null, null, "Desk", true, 1, "Biurko A1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("ec50f408-9a4b-4433-9e99-278c726ab5f9"), true, null, null, "ParkingSpot", true, true, 1, "P1A1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("f77ac16c-21af-42e7-98fa-59d569b57b67"), null, null, "Room", true, 8, "Mariacka" },
                    { new Guid("f92b4f68-5187-4e75-a6df-cc446fa926d4"), null, null, "Desk", true, 1, "Biurko A3" }
                });
        }
    }
}
