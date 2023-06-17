using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyQuickDesk.Migrations
{
    /// <inheritdoc />
    public partial class newmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Spaces_SpaceId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Spaces_AspNetUsers_CreatedById",
                table: "Spaces");

            migrationBuilder.DropIndex(
                name: "IX_Spaces_CreatedById",
                table: "Spaces");

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

            migrationBuilder.RenameColumn(
                name: "IsAvaible",
                table: "Spaces",
                newName: "IsAvaiable");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "Spaces",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById1",
                table: "Spaces",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "SpaceId",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

            migrationBuilder.CreateIndex(
                name: "IX_Spaces_CreatedById1",
                table: "Spaces",
                column: "CreatedById1");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Spaces_SpaceId",
                table: "Reservations",
                column: "SpaceId",
                principalTable: "Spaces",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Spaces_Users_CreatedById1",
                table: "Spaces",
                column: "CreatedById1",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Spaces_SpaceId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Spaces_Users_CreatedById1",
                table: "Spaces");

            migrationBuilder.DropIndex(
                name: "IX_Spaces_CreatedById1",
                table: "Spaces");

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

            migrationBuilder.DropColumn(
                name: "CreatedById1",
                table: "Spaces");

            migrationBuilder.RenameColumn(
                name: "IsAvaiable",
                table: "Spaces",
                newName: "IsAvaible");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "Spaces",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "SpaceId",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Spaces_CreatedById",
                table: "Spaces",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Spaces_SpaceId",
                table: "Reservations",
                column: "SpaceId",
                principalTable: "Spaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Spaces_AspNetUsers_CreatedById",
                table: "Spaces",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
