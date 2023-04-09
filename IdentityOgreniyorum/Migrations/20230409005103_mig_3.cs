using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IdentityOgreniyorum.Migrations
{
    /// <inheritdoc />
    public partial class mig_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2244fb15-4746-406d-90f4-b525293f4761", null, null, "User", "USER" },
                    { "b57fc94a-8b5a-4051-8f2c-a6fddb504975", null, null, "Admin", "ADMIN" },
                    { "de7ac373-32a2-4009-afeb-801fd2539015", null, null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adress", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FiredDate", "FirstName", "Gender", "HiredDate", "IdentificationNumber", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "52d7a40e-a953-4849-9db4-a184a43a17e9", 0, null, "9b32323b-59d2-4105-9b82-ee7bbac1967a", new DateTime(2023, 4, 9, 3, 51, 2, 906, DateTimeKind.Local).AddTicks(1840), "manager@manager.com", false, new DateTime(2023, 4, 9, 3, 51, 2, 906, DateTimeKind.Local).AddTicks(1843), "Manager", 1, new DateTime(2023, 4, 9, 3, 51, 2, 906, DateTimeKind.Local).AddTicks(1841), null, "Manager", false, null, "MANAGER@MANAGER.COM", "MANAGER", "AQAAAAIAAYagAAAAEHps+oBMNGCdRNUyelc9RJ1SaG9ksij4tK5jhB4fr38cVH4zxw6ENoS3HCyWhv8zSw==", null, false, "8f7adbdb-4436-4855-8217-9af54dde91b6", false, "Manager" },
                    { "6cded545-6b92-4eca-97c6-a67c1562f607", 0, null, "d4ff23cd-ebac-4d38-abce-7d94ed364b63", new DateTime(2023, 4, 9, 3, 51, 2, 906, DateTimeKind.Local).AddTicks(1777), "admin@admin.com", false, new DateTime(2023, 4, 9, 3, 51, 2, 906, DateTimeKind.Local).AddTicks(1798), "Admin", 0, new DateTime(2023, 4, 9, 3, 51, 2, 906, DateTimeKind.Local).AddTicks(1797), null, "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAECPvnU1J08aQLTBsOrsnnyxU9EHXa/26AzcTa1z1p6mZNaNBWakKVITILmfPUbr4gQ==", null, false, "dbc56018-72b1-422a-9198-73ee475ecff2", false, "Admin" },
                    { "b85fca3c-1cff-4a14-ac0b-3bb2f727455e", 0, null, "bafc6585-795d-48ee-866e-bee67db011fa", new DateTime(2023, 4, 9, 3, 51, 2, 906, DateTimeKind.Local).AddTicks(1857), "user@user.com", false, new DateTime(2023, 4, 9, 3, 51, 2, 906, DateTimeKind.Local).AddTicks(1858), "User", 0, new DateTime(2023, 4, 9, 3, 51, 2, 906, DateTimeKind.Local).AddTicks(1858), null, "User", false, null, "user@user.COM", "USER", "AQAAAAIAAYagAAAAEOETrW8bTjspXPU80h/T1oXFn5ZIz7fcfnUL5HEJfPe8+/wknXOG95OGPDq4qnhJXg==", null, false, "dd596ad3-7487-4581-a943-ddf45ea3a0d4", false, "User" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "de7ac373-32a2-4009-afeb-801fd2539015", "52d7a40e-a953-4849-9db4-a184a43a17e9" },
                    { "b57fc94a-8b5a-4051-8f2c-a6fddb504975", "6cded545-6b92-4eca-97c6-a67c1562f607" },
                    { "2244fb15-4746-406d-90f4-b525293f4761", "b85fca3c-1cff-4a14-ac0b-3bb2f727455e" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de7ac373-32a2-4009-afeb-801fd2539015", "52d7a40e-a953-4849-9db4-a184a43a17e9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b57fc94a-8b5a-4051-8f2c-a6fddb504975", "6cded545-6b92-4eca-97c6-a67c1562f607" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2244fb15-4746-406d-90f4-b525293f4761", "b85fca3c-1cff-4a14-ac0b-3bb2f727455e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2244fb15-4746-406d-90f4-b525293f4761");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b57fc94a-8b5a-4051-8f2c-a6fddb504975");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de7ac373-32a2-4009-afeb-801fd2539015");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52d7a40e-a953-4849-9db4-a184a43a17e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6cded545-6b92-4eca-97c6-a67c1562f607");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b85fca3c-1cff-4a14-ac0b-3bb2f727455e");

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
    }
}
