﻿// <auto-generated />
using System;
using IdentityOgreniyorum.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IdentityOgreniyorum.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IdentityOgreniyorum.Models.Authentication.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "9a8b6642-92f1-4aa3-8d9c-8767037ea6cb",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "7bfaf077-6f8b-4109-8337-8a0128497c6b",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "f78a1f1c-49e6-461d-9967-0de4706d348d",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("IdentityOgreniyorum.Models.Authentication.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FiredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<DateTime>("HiredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdentificationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "491e66e4-dd8c-48b9-8a4d-5c4f983a1942",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "be1da62e-ed34-46d9-98c1-e9d9a6c85048",
                            DateOfBirth = new DateTime(2023, 4, 9, 3, 53, 37, 945, DateTimeKind.Local).AddTicks(8948),
                            Email = "admin@admin.com",
                            EmailConfirmed = false,
                            FiredDate = new DateTime(2023, 4, 9, 3, 53, 37, 945, DateTimeKind.Local).AddTicks(8972),
                            FirstName = "Admin",
                            Gender = 0,
                            HiredDate = new DateTime(2023, 4, 9, 3, 53, 37, 945, DateTimeKind.Local).AddTicks(8971),
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEAv7SxXWvAt9fUrekkV/yhzgn7nfKaeOUO/Ecc560sOfpkz5SzK0N2Jp4HqP01DRTA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c2e3bffc-25e4-4464-86ad-0616d640f086",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = "a0221549-e98e-4269-a5e3-f20069da9334",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b30ce742-f009-4fad-a6a8-12f1a31e360d",
                            DateOfBirth = new DateTime(2023, 4, 9, 3, 53, 37, 945, DateTimeKind.Local).AddTicks(9016),
                            Email = "manager@manager.com",
                            EmailConfirmed = false,
                            FiredDate = new DateTime(2023, 4, 9, 3, 53, 37, 945, DateTimeKind.Local).AddTicks(9018),
                            FirstName = "Manager",
                            Gender = 1,
                            HiredDate = new DateTime(2023, 4, 9, 3, 53, 37, 945, DateTimeKind.Local).AddTicks(9017),
                            LastName = "Manager",
                            LockoutEnabled = false,
                            NormalizedEmail = "MANAGER@MANAGER.COM",
                            NormalizedUserName = "MANAGER",
                            PasswordHash = "AQAAAAIAAYagAAAAEJnpObe+Kzo2p7TIHnPB0KjnC9Lg25nyZIm06gdgED4A70NV3Pir+/ijHKTMSuYc4Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4e9ecd44-4f6a-4051-8d02-4a09ffc14726",
                            TwoFactorEnabled = false,
                            UserName = "Manager"
                        },
                        new
                        {
                            Id = "2f324715-3c49-48e0-80bf-68cfa22db227",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0640898a-d947-411a-9ee4-8f9e7cdaf854",
                            DateOfBirth = new DateTime(2023, 4, 9, 3, 53, 37, 945, DateTimeKind.Local).AddTicks(9032),
                            Email = "user@user.com",
                            EmailConfirmed = false,
                            FiredDate = new DateTime(2023, 4, 9, 3, 53, 37, 945, DateTimeKind.Local).AddTicks(9034),
                            FirstName = "User",
                            Gender = 0,
                            HiredDate = new DateTime(2023, 4, 9, 3, 53, 37, 945, DateTimeKind.Local).AddTicks(9033),
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@USER.COM",
                            NormalizedUserName = "USER",
                            PasswordHash = "AQAAAAIAAYagAAAAEAXUDq7SzZaAwftHT3BXkuRRCrtPlvmckDwTSWzwdWeUWG/XIKIXZGphGqDsyZamVQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1813fb9c-4cba-4725-b14d-6e8d0f4d5859",
                            TwoFactorEnabled = false,
                            UserName = "User"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "491e66e4-dd8c-48b9-8a4d-5c4f983a1942",
                            RoleId = "9a8b6642-92f1-4aa3-8d9c-8767037ea6cb"
                        },
                        new
                        {
                            UserId = "a0221549-e98e-4269-a5e3-f20069da9334",
                            RoleId = "7bfaf077-6f8b-4109-8337-8a0128497c6b"
                        },
                        new
                        {
                            UserId = "2f324715-3c49-48e0-80bf-68cfa22db227",
                            RoleId = "f78a1f1c-49e6-461d-9967-0de4706d348d"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("IdentityOgreniyorum.Models.Authentication.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("IdentityOgreniyorum.Models.Authentication.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("IdentityOgreniyorum.Models.Authentication.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("IdentityOgreniyorum.Models.Authentication.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IdentityOgreniyorum.Models.Authentication.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("IdentityOgreniyorum.Models.Authentication.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
