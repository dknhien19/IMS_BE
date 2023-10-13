using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class make_allocation_server_nullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collocations_Servers_ServerId",
                table: "Collocations");

            migrationBuilder.AlterColumn<int>(
                name: "ServerId",
                table: "Collocations",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "91ea0a0e-d0bc-42aa-8aaa-c07160093fa7", "AQAAAAIAAYagAAAAEJCa7nlu0zSsj9ftVxBM1PYLvfqnDpixuXcA+GnsQPTlgVokODV9nPjA8rcbcyPBbA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "706a293f-573d-4d7f-af74-b1470a2ddff1", "AQAAAAIAAYagAAAAEOsuOPPD4IYMSXfp0Q+ANdaFWq/oFrVL0IMA+wy+RHwUWjST73vUZ1/3g6TUL2v9sQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2eb1daa5-b596-4741-b8e4-223d4ccfe05f", "AQAAAAIAAYagAAAAEHvp/bMbLWBhUyC3GjbSsYZn1UIilKO8VBxgP754ybjQ0sDufit/hU/8Sl1rNeh6QA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "835f46c4-f5f8-457c-8a73-ef0f342b6515", "AQAAAAIAAYagAAAAEHBzD4zKktPgzJrhIVyXwB6j8n7IZ9KsQuHbJ3xgQwpsuFLymLQ8JBLSzGHWhIjb1Q==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8136), new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8193), new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8207), new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8219), new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8232), new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8253), new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8272), new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8272) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8291), new DateTime(2023, 10, 10, 21, 31, 20, 654, DateTimeKind.Local).AddTicks(8292) });

            migrationBuilder.AddForeignKey(
                name: "FK_Collocations_Servers_ServerId",
                table: "Collocations",
                column: "ServerId",
                principalTable: "Servers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collocations_Servers_ServerId",
                table: "Collocations");

            migrationBuilder.AlterColumn<int>(
                name: "ServerId",
                table: "Collocations",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Collocations_Servers_ServerId",
                table: "Collocations",
                column: "ServerId",
                principalTable: "Servers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
