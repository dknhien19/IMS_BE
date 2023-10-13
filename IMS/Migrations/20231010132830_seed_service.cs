using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class seed_service : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Services");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "AdditionalServices",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c5f7bf26-d9c8-471e-8086-450f6762dd7b", "AQAAAAIAAYagAAAAECujji592Rz7zyI5gHXMHV2/1ZFEhUN4V64BCXPn7mFlZgKhBMKT8a8HhMpRXGfA/A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5bd9a406-f60b-46ce-9c2a-ccbdfe95aeea", "AQAAAAIAAYagAAAAEJRcv1ZqXvayfIk9eL1AT//qGn172wC+v1iG8BBrsjd1GcqjOKXO2fl+fGHtjMt0MA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7972ee26-6aeb-4905-9498-15afc0ff4813", "AQAAAAIAAYagAAAAEL+IA9SZ1YE48+Gc0dftNNTowyslWf2QRC2qhWk4DUveCU583JHkjvEeMDOeKJHvWw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ebe87c6d-880c-43ac-90e8-b48d280a6715", "AQAAAAIAAYagAAAAEAARsSQt70oLXxYcMu6lIFb0lxI0e/cFWqmbshwXDflGySLnke48Gbl1XCBcazwWgw==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9827), new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9888), new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9904), new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9922), new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9936), new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9962), new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9962), "Thuê Chỗ", false, "Thuê Chỗ" },
                    { 2, new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9979), new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9979), "Thêm 1U", false, "Thêm 1U" },
                    { 3, new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9993), new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9993), "Công suất 100", false, "Công suất 100" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "AdditionalServices");

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Services",
                type: "text",
                nullable: false,
                defaultValue: "");

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
        }
    }
}
