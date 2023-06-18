using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyQuickDesk.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("1568bd34-2cec-4291-8285-3f8f64d51b2f"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("18d398b3-639f-49b9-a416-95aaac734e3d"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("299a800e-9065-411c-93ef-d4fcb5b85600"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("500139e8-c00a-446d-bc30-b1c0dfe672b2"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("5abb973c-b2d1-4b31-9733-f179ac7ca7ce"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("6cf5baaf-d98c-489f-89e3-907cf08dc1dd"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("703bb591-0a91-4e0a-8d01-90967207edcc"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("79192301-bcd5-4dc3-ae4a-d5407a1e52b8"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("89a25011-30b6-41c1-a772-184fe5a41a39"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("90eb2e9a-62dd-4307-976c-3bd4df720837"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("afba9b8b-f402-41a8-8fe8-70fc8d547bfe"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("e4a9fffa-7a2a-45a6-98d8-c5b3d71cbfcf"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("1568bd34-2cec-4291-8285-3f8f64d51b2f"), null, null, "Desk", true, 1, "Biurko B1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("18d398b3-639f-49b9-a416-95aaac734e3d"), true, null, null, "ParkingSpot", true, true, 1, "P1A1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("299a800e-9065-411c-93ef-d4fcb5b85600"), null, null, "Room", true, 12, "Polityczna" },
                    { new Guid("500139e8-c00a-446d-bc30-b1c0dfe672b2"), null, null, "Desk", true, 1, "Biurko A1" },
                    { new Guid("5abb973c-b2d1-4b31-9733-f179ac7ca7ce"), null, null, "Room", true, 10, "Neptun" },
                    { new Guid("6cf5baaf-d98c-489f-89e3-907cf08dc1dd"), null, null, "Desk", true, 1, "Biurko B2" },
                    { new Guid("703bb591-0a91-4e0a-8d01-90967207edcc"), null, null, "Room", true, 8, "Mariacka" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("79192301-bcd5-4dc3-ae4a-d5407a1e52b8"), true, null, null, "ParkingSpot", true, true, 1, "P1B1" },
                    { new Guid("89a25011-30b6-41c1-a772-184fe5a41a39"), true, null, null, "ParkingSpot", true, true, 1, "P1A2" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("90eb2e9a-62dd-4307-976c-3bd4df720837"), null, null, "Desk", true, 1, "Biurko A2" },
                    { new Guid("afba9b8b-f402-41a8-8fe8-70fc8d547bfe"), null, null, "Desk", true, 1, "Biurko A3" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("e4a9fffa-7a2a-45a6-98d8-c5b3d71cbfcf"), true, null, null, "ParkingSpot", true, true, 1, "P1A3" });
        }
    }
}
