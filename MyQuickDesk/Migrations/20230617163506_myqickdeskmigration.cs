using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyQuickDesk.Migrations
{
    /// <inheritdoc />
    public partial class myqickdeskmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("19328ccf-690b-4f43-be45-d28c90f9be7c"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("4203740d-3af7-42ca-98e2-dcfb501d07ad"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("511ff5e6-9264-4c2f-bbc1-672d03362afe"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("5bc65284-560c-4263-9f31-515eab5cb3cf"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("78f2237e-fdf8-4443-84a7-7166cde52ecb"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("cdc0eb1f-190f-4c45-bc8d-03d4449261f6"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("d02470db-5d97-47e8-a515-546b9caea3f3"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("d189cbff-414b-4733-b87a-37b76a33dcc7"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("d9838898-9f95-47e8-9b2d-a36b427905f2"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("f428a5a8-b6a8-411e-9a30-53cbaee5f635"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("fc6814c2-2c4f-4c95-826e-a1d31f45ba0e"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("fd4f0127-0f09-4ad2-a852-2b6194662d87"));

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "CreatedById1", "Description", "Discriminator", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("25f049eb-d2f2-4ccb-b6a9-36c8ce01f65a"), null, null, null, "Desk", true, 1, "Biurko B2" },
                    { new Guid("26c25d2b-7fd9-439f-bfe6-e6d8593bce13"), null, null, null, "Desk", true, 1, "Biurko A3" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "CreatedById1", "Description", "Discriminator", "HandicappedSpot", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("391b8096-4a6d-4ebc-b610-b4e2d1ce5144"), true, null, null, null, "ParkingSpot", true, true, 1, "P1A2" },
                    { new Guid("3cc7a0a7-f1cf-421b-bd06-e8ffa2269ebb"), true, null, null, null, "ParkingSpot", true, true, 1, "P1A1" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "CreatedById1", "Description", "Discriminator", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("45dc48f3-232c-43cf-8b6c-e41fd929adab"), null, null, null, "Desk", true, 1, "Biurko B1" },
                    { new Guid("5f88ab90-1ff8-44b4-9b3d-3a9b469b24ca"), null, null, null, "Desk", true, 1, "Biurko A1" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "CreatedById1", "Description", "Discriminator", "HandicappedSpot", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("6afd3d23-db73-4f2d-a1bf-8161b34e32dd"), true, null, null, null, "ParkingSpot", true, true, 1, "P1B1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "CreatedById1", "Description", "Discriminator", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("923becf5-dc51-434b-ade0-fe06b6f5640c"), null, null, null, "Desk", true, 1, "Biurko A2" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "CreatedById1", "Description", "Discriminator", "HandicappedSpot", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("b005a4ea-dc85-416d-9e26-8aacc74aa4ad"), true, null, null, null, "ParkingSpot", true, true, 1, "P1A3" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "CreatedById1", "Description", "Discriminator", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("bb3a80b7-8de2-47f1-b1de-2659221798fb"), null, null, null, "Room", true, 8, "Mariacka" },
                    { new Guid("d3090ea1-cf17-4ec8-87c9-60df9a9f7e17"), null, null, null, "Room", true, 12, "Polityczna" },
                    { new Guid("d7eed9d5-0bb3-4e92-be24-fc5cc4067a29"), null, null, null, "Room", true, 10, "Neptun" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("25f049eb-d2f2-4ccb-b6a9-36c8ce01f65a"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("26c25d2b-7fd9-439f-bfe6-e6d8593bce13"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("391b8096-4a6d-4ebc-b610-b4e2d1ce5144"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("3cc7a0a7-f1cf-421b-bd06-e8ffa2269ebb"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("45dc48f3-232c-43cf-8b6c-e41fd929adab"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("5f88ab90-1ff8-44b4-9b3d-3a9b469b24ca"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("6afd3d23-db73-4f2d-a1bf-8161b34e32dd"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("923becf5-dc51-434b-ade0-fe06b6f5640c"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("b005a4ea-dc85-416d-9e26-8aacc74aa4ad"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("bb3a80b7-8de2-47f1-b1de-2659221798fb"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("d3090ea1-cf17-4ec8-87c9-60df9a9f7e17"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("d7eed9d5-0bb3-4e92-be24-fc5cc4067a29"));

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "CreatedById1", "Description", "Discriminator", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("19328ccf-690b-4f43-be45-d28c90f9be7c"), null, null, null, "Room", true, 8, "Mariacka" },
                    { new Guid("4203740d-3af7-42ca-98e2-dcfb501d07ad"), null, null, null, "Desk", true, 1, "Biurko A3" },
                    { new Guid("511ff5e6-9264-4c2f-bbc1-672d03362afe"), null, null, null, "Desk", true, 1, "Biurko A2" },
                    { new Guid("5bc65284-560c-4263-9f31-515eab5cb3cf"), null, null, null, "Room", true, 12, "Polityczna" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "CreatedById1", "Description", "Discriminator", "HandicappedSpot", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("78f2237e-fdf8-4443-84a7-7166cde52ecb"), true, null, null, null, "ParkingSpot", true, true, 1, "P1B1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "CreatedById1", "Description", "Discriminator", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("cdc0eb1f-190f-4c45-bc8d-03d4449261f6"), null, null, null, "Desk", true, 1, "Biurko B1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "CreatedById1", "Description", "Discriminator", "HandicappedSpot", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("d02470db-5d97-47e8-a515-546b9caea3f3"), true, null, null, null, "ParkingSpot", true, true, 1, "P1A2" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "CreatedById1", "Description", "Discriminator", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("d189cbff-414b-4733-b87a-37b76a33dcc7"), null, null, null, "Desk", true, 1, "Biurko B2" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "CreatedById1", "Description", "Discriminator", "HandicappedSpot", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("d9838898-9f95-47e8-9b2d-a36b427905f2"), true, null, null, null, "ParkingSpot", true, true, 1, "P1A3" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "CreatedById1", "Description", "Discriminator", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("f428a5a8-b6a8-411e-9a30-53cbaee5f635"), null, null, null, "Desk", true, 1, "Biurko A1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "CreatedById1", "Description", "Discriminator", "HandicappedSpot", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("fc6814c2-2c4f-4c95-826e-a1d31f45ba0e"), true, null, null, null, "ParkingSpot", true, true, 1, "P1A1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "CreatedById1", "Description", "Discriminator", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("fd4f0127-0f09-4ad2-a852-2b6194662d87"), null, null, null, "Room", true, 10, "Neptun" });
        }
    }
}
