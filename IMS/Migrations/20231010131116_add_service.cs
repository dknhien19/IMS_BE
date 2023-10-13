using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class add_service : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AllocateDate",
                table: "Collocations",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InspectorNote",
                table: "Collocations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StopDate",
                table: "Collocations",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CollocationId = table.Column<int>(type: "integer", nullable: false),
                    ServiceId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalServices_Collocations_CollocationId",
                        column: x => x.CollocationId,
                        principalTable: "Collocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdditionalServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5a5f6aac-e54e-40d0-83bf-9108f9f5d876", "AQAAAAIAAYagAAAAEIwRQkxwsmMbr9lKF8JiLVc7WBmnRGfCrIUcTXuDzdFUkjofaz71KO6TYxC7BODQGA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b78f1c25-939b-43e3-9463-b38f8adb95f4", "AQAAAAIAAYagAAAAEC0tZh1Fds04s61ZL0PM2lx/5L/gnFoMqrwAH8COmoSNMOD0QnwKjJknTSim+a76lQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d18d33d-5b59-4f9a-b130-31583cb8ba72", "AQAAAAIAAYagAAAAEO/kHHo8XHAvNrBY4BF0tg5zuOq0qFwUXG5An/mc4cDQda3op46wyGyIxMIm3CH+ug==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9d293c2f-0776-446c-b080-718c88beb051", "AQAAAAIAAYagAAAAEB6lkJdDbr2cta4h/cacnIwHvaLKDUj+VrrKLdIkOoD5KqDUBbvyDaRmf4fZ7aBoQg==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 11, 15, 627, DateTimeKind.Local).AddTicks(4001), new DateTime(2023, 10, 10, 20, 11, 15, 627, DateTimeKind.Local).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 11, 15, 627, DateTimeKind.Local).AddTicks(4053), new DateTime(2023, 10, 10, 20, 11, 15, 627, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 11, 15, 627, DateTimeKind.Local).AddTicks(4065), new DateTime(2023, 10, 10, 20, 11, 15, 627, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 11, 15, 627, DateTimeKind.Local).AddTicks(4076), new DateTime(2023, 10, 10, 20, 11, 15, 627, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 11, 15, 627, DateTimeKind.Local).AddTicks(4132), new DateTime(2023, 10, 10, 20, 11, 15, 627, DateTimeKind.Local).AddTicks(4132) });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalServices_CollocationId",
                table: "AdditionalServices",
                column: "CollocationId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalServices_ServiceId",
                table: "AdditionalServices",
                column: "ServiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalServices");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropColumn(
                name: "AllocateDate",
                table: "Collocations");

            migrationBuilder.DropColumn(
                name: "InspectorNote",
                table: "Collocations");

            migrationBuilder.DropColumn(
                name: "StopDate",
                table: "Collocations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1a722328-bfca-4162-91fd-6ab6a0cc4f77", "AQAAAAIAAYagAAAAEJcaGUNf0iUKfOei69GQYHm9aHDeN08u05+73jkOFO2nJPf4uVgC8sZKHHbJhKPFug==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d5610279-ee00-4b7d-9d88-1c8622573280", "AQAAAAIAAYagAAAAEFaO3qa4/NRwsT183gsowwV8mJgbaDp2g7TKLtYWCmwfF+rn0VJK2Pi4B4DthoxZjw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5f0ff865-4047-4053-9797-da1d2e6f719f", "AQAAAAIAAYagAAAAEBxB/X2Dho8yxgAQ5zNxaN06kWKJfcUlPxcdg/i7feCAXrejwc7Bb39LNgRMLC+V+w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "468b2f1e-2a7f-4480-90cb-84f1cd207edc", "AQAAAAIAAYagAAAAEOhoOWXDjK2roPufBcfg+5z6iiIFxGbtWvgYGHPR456CN6UR7HBvQPF/G0T2aHYUrQ==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 9, 21, 54, 0, 161, DateTimeKind.Local).AddTicks(5654), new DateTime(2023, 10, 9, 21, 54, 0, 161, DateTimeKind.Local).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 9, 21, 54, 0, 161, DateTimeKind.Local).AddTicks(5717), new DateTime(2023, 10, 9, 21, 54, 0, 161, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 9, 21, 54, 0, 161, DateTimeKind.Local).AddTicks(5733), new DateTime(2023, 10, 9, 21, 54, 0, 161, DateTimeKind.Local).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 9, 21, 54, 0, 161, DateTimeKind.Local).AddTicks(5747), new DateTime(2023, 10, 9, 21, 54, 0, 161, DateTimeKind.Local).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 9, 21, 54, 0, 161, DateTimeKind.Local).AddTicks(5760), new DateTime(2023, 10, 9, 21, 54, 0, 161, DateTimeKind.Local).AddTicks(5760) });
        }
    }
}
