using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyQuickDesk.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("0cc00292-c015-4b24-bb77-d7bad4a3fcb7"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("2fe76b3f-ff43-40b9-a79e-c321f1b1ade4"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("35cfdfca-b023-4d64-8135-ff68229b6eb0"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("87bb5725-407b-4188-8297-b2e3ce534de8"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("8b106deb-1431-47ea-ad0f-8fd26e0b6071"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("96d3c4ca-42b8-4dd2-a1c3-d81d9d5527ca"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("b8ec10a0-820d-4f45-8358-cb5de7957a35"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("c1dfdf79-e8c3-4dd2-a451-325b7b6f9b95"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("dda55015-f727-4466-8a6f-9ac4e148754f"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("e3f93642-e707-442a-ab43-2bb85f2134de"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("ec4713c8-7a31-4c6d-be34-b686961de3c3"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("ed8a62a0-0f6d-4a50-ac6d-db4ba52feeda"));

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("23ef8370-ed6a-48a2-8e1c-8e301536f3ab"), null, null, "Desk", true, 1, "Biurko B1" },
                    { new Guid("330dfa66-e09a-4e2b-a9a8-f41c2368bf72"), null, null, "Room", true, 12, "Polityczna" },
                    { new Guid("39f7d4b7-29a9-45cf-a8c5-cec9a59d5a33"), null, null, "Desk", true, 1, "Biurko A2" },
                    { new Guid("575362ee-7aec-4be7-9f15-0b90a833e6e3"), null, null, "Desk", true, 1, "Biurko B2" },
                    { new Guid("5754c2df-1aab-44c7-8479-d645dfa434b9"), null, null, "Room", true, 10, "Neptun" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("98ea85e5-5317-4a81-849f-2b7ac905edb9"), true, null, null, "ParkingSpot", true, true, 1, "P1B1" },
                    { new Guid("b0615891-a933-42c5-b6bf-62b354818510"), true, null, null, "ParkingSpot", true, true, 1, "P1A1" },
                    { new Guid("bf7990b4-539a-484a-a369-ceffb44abcc7"), true, null, null, "ParkingSpot", true, true, 1, "P1A2" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("d0339ca5-e28c-447f-ad03-02c147f2ff72"), null, null, "Desk", true, 1, "Biurko A3" },
                    { new Guid("d819ceb7-f031-41fd-95e1-f81e67212a2c"), null, null, "Room", true, 8, "Mariacka" },
                    { new Guid("e9f4be37-e9c5-4c7c-8920-d8eff63f28c4"), null, null, "Desk", true, 1, "Biurko A1" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("f8d8f7de-cb55-4ce2-8e48-7efa6407c72f"), true, null, null, "ParkingSpot", true, true, 1, "P1A3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("23ef8370-ed6a-48a2-8e1c-8e301536f3ab"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("330dfa66-e09a-4e2b-a9a8-f41c2368bf72"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("39f7d4b7-29a9-45cf-a8c5-cec9a59d5a33"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("575362ee-7aec-4be7-9f15-0b90a833e6e3"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("5754c2df-1aab-44c7-8479-d645dfa434b9"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("98ea85e5-5317-4a81-849f-2b7ac905edb9"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("b0615891-a933-42c5-b6bf-62b354818510"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("bf7990b4-539a-484a-a369-ceffb44abcc7"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("d0339ca5-e28c-447f-ad03-02c147f2ff72"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("d819ceb7-f031-41fd-95e1-f81e67212a2c"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("e9f4be37-e9c5-4c7c-8920-d8eff63f28c4"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("f8d8f7de-cb55-4ce2-8e48-7efa6407c72f"));

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("0cc00292-c015-4b24-bb77-d7bad4a3fcb7"), null, null, "Room", true, 10, "Neptun" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("2fe76b3f-ff43-40b9-a79e-c321f1b1ade4"), true, null, null, "ParkingSpot", true, true, 1, "P1A1" },
                    { new Guid("35cfdfca-b023-4d64-8135-ff68229b6eb0"), true, null, null, "ParkingSpot", true, true, 1, "P1A3" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("87bb5725-407b-4188-8297-b2e3ce534de8"), null, null, "Desk", true, 1, "Biurko A2" },
                    { new Guid("8b106deb-1431-47ea-ad0f-8fd26e0b6071"), null, null, "Desk", true, 1, "Biurko B2" },
                    { new Guid("96d3c4ca-42b8-4dd2-a1c3-d81d9d5527ca"), null, null, "Desk", true, 1, "Biurko A3" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("b8ec10a0-820d-4f45-8358-cb5de7957a35"), true, null, null, "ParkingSpot", true, true, 1, "P1A2" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("c1dfdf79-e8c3-4dd2-a451-325b7b6f9b95"), null, null, "Room", true, 12, "Polityczna" },
                    { new Guid("dda55015-f727-4466-8a6f-9ac4e148754f"), null, null, "Desk", true, 1, "Biurko A1" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[] { new Guid("e3f93642-e707-442a-ab43-2bb85f2134de"), true, null, null, "ParkingSpot", true, true, 1, "P1B1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaiable", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("ec4713c8-7a31-4c6d-be34-b686961de3c3"), null, null, "Desk", true, 1, "Biurko B1" },
                    { new Guid("ed8a62a0-0f6d-4a50-ac6d-db4ba52feeda"), null, null, "Room", true, 8, "Mariacka" }
                });
        }
    }
}
