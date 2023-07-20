using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyQuickDesk.Migrations
{
    /// <inheritdoc />
    public partial class newmgr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("1039a5b6-f2aa-488e-927f-75a903efce49"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("12e449af-8949-4a7b-b873-aaff278709c0"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("33d913c0-c7cf-4caf-9792-06e0c8b002f5"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("42b42668-8ba9-4c55-8dc8-9910f5688b8c"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("4ee6bd5d-7aaa-45be-9e96-48e12f9dd9c0"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("6d76280d-703c-4bc3-a989-b754665bfb57"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("751fba6a-7a3d-43a3-81b5-b5a57a0544c8"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("a0cb6f89-5272-4ed7-b5e6-14a3c20b934e"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("a4a452c2-c6f2-4e63-a19f-cc3a331aef93"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("b9129fc1-6b2a-47f7-aeaf-4bd88b2fe134"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("cd3b1776-341b-47fe-8008-49900cef47fd"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("fb2f2723-61ea-461b-9b83-11482deebdde"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("1039a5b6-f2aa-488e-927f-75a903efce49"), null, null, null, "Room", true, 8, "Mariacka" },
                    { new Guid("12e449af-8949-4a7b-b873-aaff278709c0"), null, null, null, "Desk", true, 1, "Biurko A1" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "CreatedById1", "Description", "Discriminator", "HandicappedSpot", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("33d913c0-c7cf-4caf-9792-06e0c8b002f5"), true, null, null, null, "ParkingSpot", true, true, 1, "P1A3" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "CreatedById1", "Description", "Discriminator", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("42b42668-8ba9-4c55-8dc8-9910f5688b8c"), null, null, null, "Desk", true, 1, "Biurko B1" },
                    { new Guid("4ee6bd5d-7aaa-45be-9e96-48e12f9dd9c0"), null, null, null, "Room", true, 10, "Neptun" },
                    { new Guid("6d76280d-703c-4bc3-a989-b754665bfb57"), null, null, null, "Room", true, 12, "Polityczna" },
                    { new Guid("751fba6a-7a3d-43a3-81b5-b5a57a0544c8"), null, null, null, "Desk", true, 1, "Biurko A2" },
                    { new Guid("a0cb6f89-5272-4ed7-b5e6-14a3c20b934e"), null, null, null, "Desk", true, 1, "Biurko B2" },
                    { new Guid("a4a452c2-c6f2-4e63-a19f-cc3a331aef93"), null, null, null, "Desk", true, 1, "Biurko A3" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "CreatedById1", "Description", "Discriminator", "HandicappedSpot", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("b9129fc1-6b2a-47f7-aeaf-4bd88b2fe134"), true, null, null, null, "ParkingSpot", true, true, 1, "P1A2" },
                    { new Guid("cd3b1776-341b-47fe-8008-49900cef47fd"), true, null, null, null, "ParkingSpot", true, true, 1, "P1B1" },
                    { new Guid("fb2f2723-61ea-461b-9b83-11482deebdde"), true, null, null, null, "ParkingSpot", true, true, 1, "P1A1" }
                });
        }
    }
}
