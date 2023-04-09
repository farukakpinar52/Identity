using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IdentityOgreniyorum.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "75ea1351-7d9f-459f-8b3d-008e9181d80c", null, null, "Manager", "MANAGER" },
                    { "8952f87e-683c-4663-91aa-a5f19606c077", null, null, "Admin", "ADMIN" },
                    { "b65f3ff4-b426-4610-a574-5cc9aee7a622", null, null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adress", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FiredDate", "FirstName", "Gender", "HiredDate", "IdentificationNumber", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "18092c83-4eed-48e5-a0e3-293422f0cae3", 0, null, "53c670d4-e852-4006-b529-45aea72508c9", new DateTime(2023, 2, 22, 22, 42, 24, 389, DateTimeKind.Local).AddTicks(3625), "admin@admin.com", false, new DateTime(2023, 2, 22, 22, 42, 24, 389, DateTimeKind.Local).AddTicks(3641), "Seed", 0, new DateTime(2023, 2, 22, 22, 42, 24, 389, DateTimeKind.Local).AddTicks(3640), null, "Test", false, null, "ADMIN@ADMIN.COM", "ADMİN", "AQAAAAIAAYagAAAAEL05kwATRXg5KhXf1WY72+HEQ7ia4ptXHf+HHOuH88AaSdgc/a+8AZ1DExqjdNnJTg==", null, false, "48212731-33ac-4517-875f-097046731805", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8952f87e-683c-4663-91aa-a5f19606c077", "18092c83-4eed-48e5-a0e3-293422f0cae3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75ea1351-7d9f-459f-8b3d-008e9181d80c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b65f3ff4-b426-4610-a574-5cc9aee7a622");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8952f87e-683c-4663-91aa-a5f19606c077", "18092c83-4eed-48e5-a0e3-293422f0cae3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8952f87e-683c-4663-91aa-a5f19606c077");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18092c83-4eed-48e5-a0e3-293422f0cae3");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
