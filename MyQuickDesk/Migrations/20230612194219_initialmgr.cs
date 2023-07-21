using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyQuickDesk.Migrations
{
    /// <inheritdoc />
    public partial class initialmgr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { new Guid("04c4b650-c713-4623-a57e-7db702742372"), null, null, "Desk", true, 1, "Biurko A2" },
                    { new Guid("06ac2060-b1dd-425f-80ac-90c111fccf79"), null, null, "Desk", true, 1, "Biurko A3" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("28a22f9b-33b3-45e5-a3b6-8b9d8448c3ef"), true, null, null, "ParkingSpot", true, true, 1, "P1A3" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("3900c447-011f-4165-825b-237d60b7b289"), null, null, "Room", true, 10, "Neptun" },
                    { new Guid("44d1133a-64c1-4c3f-bbaa-bd626de3cf0a"), null, null, "Room", true, 8, "Mariacka" },
                    { new Guid("548db3b2-949e-4a08-8595-3d817e2e525b"), null, null, "Desk", true, 1, "Biurko B2" },
                    { new Guid("74132b9e-cae1-4bec-a468-7cd06b74313d"), null, null, "Room", true, 12, "Polityczna" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("ad1058ce-5c99-451a-8435-2d2954bf126e"), true, null, null, "ParkingSpot", true, true, 1, "P1B1" },
                    { new Guid("b1067a95-0d49-49fb-ae1a-d42eac09c6ba"), true, null, null, "ParkingSpot", true, true, 1, "P1A1" },
                    { new Guid("d751964b-773f-4ded-9e8a-f078434ad1c0"), true, null, null, "ParkingSpot", true, true, 1, "P1A2" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("ea8d4a89-1313-4be7-a9d2-328406cbddac"), null, null, "Desk", true, 1, "Biurko B1" },
                    { new Guid("eb09dab4-0b8e-4635-bfb3-c33f314ef142"), null, null, "Desk", true, 1, "Biurko A1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("04c4b650-c713-4623-a57e-7db702742372"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("06ac2060-b1dd-425f-80ac-90c111fccf79"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("28a22f9b-33b3-45e5-a3b6-8b9d8448c3ef"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("3900c447-011f-4165-825b-237d60b7b289"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("44d1133a-64c1-4c3f-bbaa-bd626de3cf0a"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("548db3b2-949e-4a08-8595-3d817e2e525b"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("74132b9e-cae1-4bec-a468-7cd06b74313d"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("ad1058ce-5c99-451a-8435-2d2954bf126e"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("b1067a95-0d49-49fb-ae1a-d42eac09c6ba"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("d751964b-773f-4ded-9e8a-f078434ad1c0"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("ea8d4a89-1313-4be7-a9d2-328406cbddac"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("eb09dab4-0b8e-4635-bfb3-c33f314ef142"));

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
    }
}
