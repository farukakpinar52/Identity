using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IdentityOgreniyorum.Migrations
{
    /// <inheritdoc />
    public partial class mig_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "7bfaf077-6f8b-4109-8337-8a0128497c6b", null, null, "Manager", "MANAGER" },
                    { "9a8b6642-92f1-4aa3-8d9c-8767037ea6cb", null, null, "Admin", "ADMIN" },
                    { "f78a1f1c-49e6-461d-9967-0de4706d348d", null, null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adress", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FiredDate", "FirstName", "Gender", "HiredDate", "IdentificationNumber", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2f324715-3c49-48e0-80bf-68cfa22db227", 0, null, "0640898a-d947-411a-9ee4-8f9e7cdaf854", new DateTime(2023, 4, 9, 3, 53, 37, 945, DateTimeKind.Local).AddTicks(9032), "user@user.com", false, new DateTime(2023, 4, 9, 3, 53, 37, 945, DateTimeKind.Local).AddTicks(9034), "User", 0, new DateTime(2023, 4, 9, 3, 53, 37, 945, DateTimeKind.Local).AddTicks(9033), null, "User", false, null, "USER@USER.COM", "USER", "AQAAAAIAAYagAAAAEAXUDq7SzZaAwftHT3BXkuRRCrtPlvmckDwTSWzwdWeUWG/XIKIXZGphGqDsyZamVQ==", null, false, "1813fb9c-4cba-4725-b14d-6e8d0f4d5859", false, "User" },
                    { "491e66e4-dd8c-48b9-8a4d-5c4f983a1942", 0, null, "be1da62e-ed34-46d9-98c1-e9d9a6c85048", new DateTime(2023, 4, 9, 3, 53, 37, 945, DateTimeKind.Local).AddTicks(8948), "admin@admin.com", false, new DateTime(2023, 4, 9, 3, 53, 37, 945, DateTimeKind.Local).AddTicks(8972), "Admin", 0, new DateTime(2023, 4, 9, 3, 53, 37, 945, DateTimeKind.Local).AddTicks(8971), null, "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAIAAYagAAAAEAv7SxXWvAt9fUrekkV/yhzgn7nfKaeOUO/Ecc560sOfpkz5SzK0N2Jp4HqP01DRTA==", null, false, "c2e3bffc-25e4-4464-86ad-0616d640f086", false, "Admin" },
                    { "a0221549-e98e-4269-a5e3-f20069da9334", 0, null, "b30ce742-f009-4fad-a6a8-12f1a31e360d", new DateTime(2023, 4, 9, 3, 53, 37, 945, DateTimeKind.Local).AddTicks(9016), "manager@manager.com", false, new DateTime(2023, 4, 9, 3, 53, 37, 945, DateTimeKind.Local).AddTicks(9018), "Manager", 1, new DateTime(2023, 4, 9, 3, 53, 37, 945, DateTimeKind.Local).AddTicks(9017), null, "Manager", false, null, "MANAGER@MANAGER.COM", "MANAGER", "AQAAAAIAAYagAAAAEJnpObe+Kzo2p7TIHnPB0KjnC9Lg25nyZIm06gdgED4A70NV3Pir+/ijHKTMSuYc4Q==", null, false, "4e9ecd44-4f6a-4051-8d02-4a09ffc14726", false, "Manager" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f78a1f1c-49e6-461d-9967-0de4706d348d", "2f324715-3c49-48e0-80bf-68cfa22db227" },
                    { "9a8b6642-92f1-4aa3-8d9c-8767037ea6cb", "491e66e4-dd8c-48b9-8a4d-5c4f983a1942" },
                    { "7bfaf077-6f8b-4109-8337-8a0128497c6b", "a0221549-e98e-4269-a5e3-f20069da9334" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f78a1f1c-49e6-461d-9967-0de4706d348d", "2f324715-3c49-48e0-80bf-68cfa22db227" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a8b6642-92f1-4aa3-8d9c-8767037ea6cb", "491e66e4-dd8c-48b9-8a4d-5c4f983a1942" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7bfaf077-6f8b-4109-8337-8a0128497c6b", "a0221549-e98e-4269-a5e3-f20069da9334" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bfaf077-6f8b-4109-8337-8a0128497c6b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a8b6642-92f1-4aa3-8d9c-8767037ea6cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f78a1f1c-49e6-461d-9967-0de4706d348d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f324715-3c49-48e0-80bf-68cfa22db227");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "491e66e4-dd8c-48b9-8a4d-5c4f983a1942");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0221549-e98e-4269-a5e3-f20069da9334");

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
    }
}
