using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyQuickDesk.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spaces_Favorites_FavoritesUserId",
                table: "Spaces");

            migrationBuilder.DropIndex(
                name: "IX_Spaces_FavoritesUserId",
                table: "Spaces");

            migrationBuilder.DropPrimaryKey(
                name: "PrimaryKey_UserId",
                table: "Favorites");

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("006a33b0-2f21-410e-a01f-35ae247f2225"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("0662526c-beb1-4f15-81c9-f3c7e27c437c"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("0e222fc0-4629-4c7e-a170-87e711afb11c"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("590d18e7-1a81-442d-be33-fd4a8fd0c694"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("76cfc033-3105-4434-b03d-bbc19acdf3c7"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("7cfd01f9-2517-44a3-a0ce-ffe1dc19b462"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("8d9b520a-401d-461a-8644-dcf234d27375"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("a4d7a8ab-f8d3-4a36-a5fd-4b7ec73b0230"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("ade3df51-aa8e-4c37-94d4-faf1b4a413d3"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("dfbab7e7-4ec0-44a2-99c3-d4412df72260"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("e111e1c9-99d4-4547-a883-af1568f4a4c4"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("f3dae7e3-d82b-4b31-9356-34156ebcd28e"));

            migrationBuilder.AddColumn<Guid>(
                name: "FavoritesParkingId",
                table: "Spaces",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ParkingId",
                table: "Favorites",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Favorites",
                table: "Favorites",
                columns: new[] { "UserId", "ParkingId" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "FavoritesParkingId", "FavoritesUserId", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("1222e91a-d040-4e80-8172-91fe1b1755ea"), true, null, null, "ParkingSpot", null, null, true, true, 1, "P1B1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("16b4424a-9d19-4e29-bf38-071dd3b91b73"), null, null, "Room", true, 10, "Neptun" },
                    { new Guid("227967f7-c17f-4ed0-aa08-d6e2d039fbc9"), null, null, "Desk", true, 1, "Biurko A3" },
                    { new Guid("27be763d-f699-41e4-bf3e-1409b534e5fb"), null, null, "Desk", true, 1, "Biurko B1" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "FavoritesParkingId", "FavoritesUserId", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("3bb88691-1350-4ccb-9a65-8d35c76a9bcb"), true, null, null, "ParkingSpot", null, null, true, true, 1, "P1A3" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("3f09c2d0-9247-4924-bbe5-755b6c2d75bf"), null, null, "Room", true, 8, "Mariacka" },
                    { new Guid("4c7a1637-3276-442f-b8af-1245ee70cdde"), null, null, "Desk", true, 1, "Biurko A2" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "FavoritesParkingId", "FavoritesUserId", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("5fe5908c-9f4c-4c8c-8746-553c93223fc6"), true, null, null, "ParkingSpot", null, null, true, true, 1, "P1A1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("a54134c7-f0ef-4989-b46b-9768e00434a9"), null, null, "Room", true, 12, "Polityczna" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "FavoritesParkingId", "FavoritesUserId", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("be25bada-9011-49fd-ae6f-10572f72698c"), true, null, null, "ParkingSpot", null, null, true, true, 1, "P1A2" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("d149bd84-7fa1-4a3e-8fd7-690614e0f189"), null, null, "Desk", true, 1, "Biurko B2" },
                    { new Guid("dd5bb4ed-dd5e-4114-a426-b8b26487b154"), null, null, "Desk", true, 1, "Biurko A1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Spaces_FavoritesUserId_FavoritesParkingId",
                table: "Spaces",
                columns: new[] { "FavoritesUserId", "FavoritesParkingId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Users_UserId",
                table: "Favorites",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Spaces_Favorites_FavoritesUserId_FavoritesParkingId",
                table: "Spaces",
                columns: new[] { "FavoritesUserId", "FavoritesParkingId" },
                principalTable: "Favorites",
                principalColumns: new[] { "UserId", "ParkingId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Users_UserId",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_Spaces_Favorites_FavoritesUserId_FavoritesParkingId",
                table: "Spaces");

            migrationBuilder.DropIndex(
                name: "IX_Spaces_FavoritesUserId_FavoritesParkingId",
                table: "Spaces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Favorites",
                table: "Favorites");

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("1222e91a-d040-4e80-8172-91fe1b1755ea"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("16b4424a-9d19-4e29-bf38-071dd3b91b73"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("227967f7-c17f-4ed0-aa08-d6e2d039fbc9"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("27be763d-f699-41e4-bf3e-1409b534e5fb"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("3bb88691-1350-4ccb-9a65-8d35c76a9bcb"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("3f09c2d0-9247-4924-bbe5-755b6c2d75bf"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("4c7a1637-3276-442f-b8af-1245ee70cdde"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("5fe5908c-9f4c-4c8c-8746-553c93223fc6"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("a54134c7-f0ef-4989-b46b-9768e00434a9"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("be25bada-9011-49fd-ae6f-10572f72698c"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("d149bd84-7fa1-4a3e-8fd7-690614e0f189"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("dd5bb4ed-dd5e-4114-a426-b8b26487b154"));

            migrationBuilder.DropColumn(
                name: "FavoritesParkingId",
                table: "Spaces");

            migrationBuilder.DropColumn(
                name: "ParkingId",
                table: "Favorites");

            migrationBuilder.AddPrimaryKey(
                name: "PrimaryKey_UserId",
                table: "Favorites",
                column: "UserId");

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "FavoritesUserId", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("006a33b0-2f21-410e-a01f-35ae247f2225"), true, null, null, "ParkingSpot", null, true, true, 1, "P1A3" },
                    { new Guid("0662526c-beb1-4f15-81c9-f3c7e27c437c"), true, null, null, "ParkingSpot", null, true, true, 1, "P1B1" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("0e222fc0-4629-4c7e-a170-87e711afb11c"), null, null, "Room", true, 8, "Mariacka" },
                    { new Guid("590d18e7-1a81-442d-be33-fd4a8fd0c694"), null, null, "Desk", true, 1, "Biurko A1" },
                    { new Guid("76cfc033-3105-4434-b03d-bbc19acdf3c7"), null, null, "Room", true, 12, "Polityczna" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "FavoritesUserId", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("7cfd01f9-2517-44a3-a0ce-ffe1dc19b462"), true, null, null, "ParkingSpot", null, true, true, 1, "P1A2" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[,]
                {
                    { new Guid("8d9b520a-401d-461a-8644-dcf234d27375"), null, null, "Desk", true, 1, "Biurko A2" },
                    { new Guid("a4d7a8ab-f8d3-4a36-a5fd-4b7ec73b0230"), null, null, "Room", true, 10, "Neptun" },
                    { new Guid("ade3df51-aa8e-4c37-94d4-faf1b4a413d3"), null, null, "Desk", true, 1, "Biurko B1" },
                    { new Guid("dfbab7e7-4ec0-44a2-99c3-d4412df72260"), null, null, "Desk", true, 1, "Biurko B2" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Charger", "CreatedById", "Description", "Discriminator", "FavoritesUserId", "HandicappedSpot", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("e111e1c9-99d4-4547-a883-af1568f4a4c4"), true, null, null, "ParkingSpot", null, true, true, 1, "P1A1" });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "CreatedById", "Description", "Discriminator", "IsAvaible", "MaxCapacity", "Name" },
                values: new object[] { new Guid("f3dae7e3-d82b-4b31-9356-34156ebcd28e"), null, null, "Desk", true, 1, "Biurko A3" });

            migrationBuilder.CreateIndex(
                name: "IX_Spaces_FavoritesUserId",
                table: "Spaces",
                column: "FavoritesUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Spaces_Favorites_FavoritesUserId",
                table: "Spaces",
                column: "FavoritesUserId",
                principalTable: "Favorites",
                principalColumn: "UserId");
        }
    }
}
