using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyQuickDesk.Migrations
{
    /// <inheritdoc />
    public partial class test1234 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("05fa9e01-9004-436f-8850-e78f64c6fe47"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("1e912b41-44b9-448c-8ca2-898949a01595"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("29de14ac-3c4e-4bf9-a407-b648f2c4d310"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("2c2a8291-4853-4426-952a-d15f6c9d4ca9"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("544bf3e5-e0bf-40bd-acd9-9ce7d3f356e2"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("65a47220-56dc-4c5f-b89c-d31ccf9bfc88"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("68cf4eae-33d9-4762-abfe-2c098474ab44"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("8f7d6cb6-587a-49d3-9da4-aefad43600df"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("9e19e5ef-39ff-4292-a8d1-93a77ef99ffa"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("db99f971-a447-4b28-93dd-175074df1007"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("e2fb5bb5-2da1-4bd5-98bf-9d688651989c"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("f0f01c1c-aead-4dc6-86e2-4efdd9968356"));

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("1ddf8dbb-0c0e-4a9e-9232-e63a81656d60"), null, null, "Desk", true, 1, "Biurko B1" },
                    { new Guid("2da879fb-76cf-45cd-b303-cbf917881609"), null, null, "Desk", true, 1, "Biurko A2" },
                    { new Guid("4599156c-74b6-46d5-9807-2260c69f59ed"), null, null, "Room", true, 8, "Mariacka" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("51f41dcf-f985-43ae-9be4-ecd4c61cb642"), true, null, null, "ParkingSpot", true, true, 1, "P1A1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("62b43bdd-e089-42dc-a9af-486909d27394"), null, null, "Desk", true, 1, "Biurko A3" },
                    { new Guid("7544db47-5a06-4549-9a32-8960efce088f"), null, null, "Desk", true, 1, "Biurko B2" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("87d91610-f790-4cc8-821d-33b141a8e689"), true, null, null, "ParkingSpot", true, true, 1, "P1B1" },
                    { new Guid("bd89e0de-9430-45d1-90d1-84cc99ffc6c0"), true, null, null, "ParkingSpot", true, true, 1, "P1A3" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("d0884b5b-5b19-4bdb-8194-497ca97d70df"), null, null, "Room", true, 12, "Polityczna" },
                    { new Guid("dac2a944-9326-4525-b00f-5a8efd12f5f0"), null, null, "Room", true, 10, "Neptun" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("e346139d-77f3-4359-875e-feb2dbaa38b6"), true, null, null, "ParkingSpot", true, true, 1, "P1A2" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("e505ac39-ea3e-4fe4-b390-94c3e6a3fb71"), null, null, "Desk", true, 1, "Biurko A1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("1ddf8dbb-0c0e-4a9e-9232-e63a81656d60"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("2da879fb-76cf-45cd-b303-cbf917881609"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("4599156c-74b6-46d5-9807-2260c69f59ed"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("51f41dcf-f985-43ae-9be4-ecd4c61cb642"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("62b43bdd-e089-42dc-a9af-486909d27394"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("7544db47-5a06-4549-9a32-8960efce088f"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("87d91610-f790-4cc8-821d-33b141a8e689"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("bd89e0de-9430-45d1-90d1-84cc99ffc6c0"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("d0884b5b-5b19-4bdb-8194-497ca97d70df"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("dac2a944-9326-4525-b00f-5a8efd12f5f0"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("e346139d-77f3-4359-875e-feb2dbaa38b6"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("e505ac39-ea3e-4fe4-b390-94c3e6a3fb71"));

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("05fa9e01-9004-436f-8850-e78f64c6fe47"), null, null, "Desk", true, 1, "Biurko A3" },
                    { new Guid("1e912b41-44b9-448c-8ca2-898949a01595"), null, null, "Room", true, 10, "Neptun" },
                    { new Guid("29de14ac-3c4e-4bf9-a407-b648f2c4d310"), null, null, "Desk", true, 1, "Biurko A2" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("2c2a8291-4853-4426-952a-d15f6c9d4ca9"), true, null, null, "ParkingSpot", true, true, 1, "P1B1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("544bf3e5-e0bf-40bd-acd9-9ce7d3f356e2"), null, null, "Desk", true, 1, "Biurko B1" },
                    { new Guid("65a47220-56dc-4c5f-b89c-d31ccf9bfc88"), null, null, "Room", true, 12, "Polityczna" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("68cf4eae-33d9-4762-abfe-2c098474ab44"), true, null, null, "ParkingSpot", true, true, 1, "P1A3" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("8f7d6cb6-587a-49d3-9da4-aefad43600df"), null, null, "Room", true, 8, "Mariacka" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("9e19e5ef-39ff-4292-a8d1-93a77ef99ffa"), true, null, null, "ParkingSpot", true, true, 1, "P1A1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("db99f971-a447-4b28-93dd-175074df1007"), null, null, "Desk", true, 1, "Biurko A1" },
                    { new Guid("e2fb5bb5-2da1-4bd5-98bf-9d688651989c"), null, null, "Desk", true, 1, "Biurko B2" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("f0f01c1c-aead-4dc6-86e2-4efdd9968356"), true, null, null, "ParkingSpot", true, true, 1, "P1A2" });
        }
    }
}
