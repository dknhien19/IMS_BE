using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class change_field_name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StopDate",
                table: "Collocations",
                newName: "DateStop");

            migrationBuilder.RenameColumn(
                name: "AllocateDate",
                table: "Collocations",
                newName: "DateAllocate");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0de018cb-b77c-4233-b4c6-e480f42b0db2", "AQAAAAIAAYagAAAAEBQhoqZBmgIezMR2JubboKKS5xUxZAJMZBkzfaWXFNoQSvEl4IbfA4L6/SR7xZ+8uQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16a23ec6-bd9b-4dd8-803a-acb11fc83e0e", "AQAAAAIAAYagAAAAECaNTiJqR9yZaR8zZwkZAU737iSRtTK0W9h4hOo2THDljX/bAKvxEfKr9AU7ftva6A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a0b2a9c8-7acc-4882-abc8-9f5bbcb8075c", "AQAAAAIAAYagAAAAELdo/VL2j4EKOYB66dITfov0OF8DKjEQ5zTzOn+Pcc29pHc0ujiYkQ/YL/5YEuXHgQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2c811333-30a4-4aa8-bccc-c7cacbeb9256", "AQAAAAIAAYagAAAAEFR9ypVs28mre25rVu+UepEZoz38wgOQIf+dZEcU/FCAelCjacXEqDxVv8SwNA4zpg==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 21, 26, 43, 922, DateTimeKind.Local).AddTicks(8295), new DateTime(2023, 10, 10, 21, 26, 43, 922, DateTimeKind.Local).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 21, 26, 43, 922, DateTimeKind.Local).AddTicks(8348), new DateTime(2023, 10, 10, 21, 26, 43, 922, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 21, 26, 43, 922, DateTimeKind.Local).AddTicks(8362), new DateTime(2023, 10, 10, 21, 26, 43, 922, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 21, 26, 43, 922, DateTimeKind.Local).AddTicks(8373), new DateTime(2023, 10, 10, 21, 26, 43, 922, DateTimeKind.Local).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 21, 26, 43, 922, DateTimeKind.Local).AddTicks(8385), new DateTime(2023, 10, 10, 21, 26, 43, 922, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 21, 26, 43, 922, DateTimeKind.Local).AddTicks(8408), new DateTime(2023, 10, 10, 21, 26, 43, 922, DateTimeKind.Local).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 21, 26, 43, 922, DateTimeKind.Local).AddTicks(8425), new DateTime(2023, 10, 10, 21, 26, 43, 922, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 21, 26, 43, 922, DateTimeKind.Local).AddTicks(8444), new DateTime(2023, 10, 10, 21, 26, 43, 922, DateTimeKind.Local).AddTicks(8444) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateStop",
                table: "Collocations",
                newName: "StopDate");

            migrationBuilder.RenameColumn(
                name: "DateAllocate",
                table: "Collocations",
                newName: "AllocateDate");

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

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9962), new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9979), new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9993), new DateTime(2023, 10, 10, 20, 28, 29, 99, DateTimeKind.Local).AddTicks(9993) });
        }
    }
}
