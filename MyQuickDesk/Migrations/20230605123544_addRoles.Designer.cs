﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyQuickDesk.DatabaseContext;

#nullable disable

namespace MyQuickDesk.Migrations
{
    [DbContext(typeof(MyQuickDeskContext))]
<<<<<<<< HEAD:MyQuickDesk/Migrations/20230605123544_addRoles.Designer.cs
    [Migration("20230605123544_addRoles")]
    partial class addRoles
========
    [Migration("20230630162941_init")]
    partial class init
>>>>>>>> s2-Diana-Kosel-2:MyQuickDesk/Migrations/20230630162941_init.Designer.cs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MyQuickDesk.Entities.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DeskId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ParkingSpotId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("RoomId")
                        .HasColumnType("uniqueidentifier");

<<<<<<<< HEAD:MyQuickDesk/Migrations/20230605123544_addRoles.Designer.cs
                    b.Property<Guid>("SpaceId")
========
                    b.Property<Guid?>("SpaceId")
>>>>>>>> s2-Diana-Kosel-2:MyQuickDesk/Migrations/20230630162941_init.Designer.cs
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

<<<<<<<< HEAD:MyQuickDesk/Migrations/20230605123544_addRoles.Designer.cs
                    b.Property<Guid>("UserId")
========
                    b.Property<Guid?>("UserId")
>>>>>>>> s2-Diana-Kosel-2:MyQuickDesk/Migrations/20230630162941_init.Designer.cs
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DeskId");

                    b.HasIndex("ParkingSpotId");

                    b.HasIndex("RoomId");

                    b.HasIndex("SpaceId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("MyQuickDesk.Entities.Space", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");
<<<<<<<< HEAD:MyQuickDesk/Migrations/20230605123544_addRoles.Designer.cs
========

                    b.Property<string>("CreatedById")
                        .HasColumnType("nvarchar(450)");
>>>>>>>> s2-Diana-Kosel-2:MyQuickDesk/Migrations/20230630162941_init.Designer.cs

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvaiable")
                        .HasColumnType("bit");

                    b.Property<int>("MaxCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Spaces");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Space");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("MyQuickDesk.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Owner")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MyQuickDesk.Entities.Desk", b =>
                {
                    b.HasBaseType("MyQuickDesk.Entities.Space");

                    b.HasDiscriminator().HasValue("Desk");

                    b.HasData(
                        new
                        {
<<<<<<<< HEAD:MyQuickDesk/Migrations/20230605123544_addRoles.Designer.cs
                            Id = new Guid("bfbc2872-4523-43a8-a7a0-c37f43e18cde"),
                            IsAvaible = true,
========
                            Id = new Guid("524e05b2-2fd1-4069-b899-1aa757ec0859"),
                            IsAvaiable = true,
>>>>>>>> s2-Diana-Kosel-2:MyQuickDesk/Migrations/20230630162941_init.Designer.cs
                            MaxCapacity = 1,
                            Name = "Biurko A1"
                        },
                        new
                        {
<<<<<<<< HEAD:MyQuickDesk/Migrations/20230605123544_addRoles.Designer.cs
                            Id = new Guid("8593436a-c985-42f8-8e3b-bfeb96c0b826"),
                            IsAvaible = true,
========
                            Id = new Guid("7fa5fe9e-a81c-4df4-a8f0-cb79a4787c07"),
                            IsAvaiable = true,
>>>>>>>> s2-Diana-Kosel-2:MyQuickDesk/Migrations/20230630162941_init.Designer.cs
                            MaxCapacity = 1,
                            Name = "Biurko A2"
                        },
                        new
                        {
<<<<<<<< HEAD:MyQuickDesk/Migrations/20230605123544_addRoles.Designer.cs
                            Id = new Guid("2eae355b-9a7c-4c4d-b0db-94d6b4832858"),
                            IsAvaible = true,
========
                            Id = new Guid("7fe6273b-11a2-4916-942b-10a71ff2b4d7"),
                            IsAvaiable = true,
>>>>>>>> s2-Diana-Kosel-2:MyQuickDesk/Migrations/20230630162941_init.Designer.cs
                            MaxCapacity = 1,
                            Name = "Biurko A3"
                        },
                        new
                        {
<<<<<<<< HEAD:MyQuickDesk/Migrations/20230605123544_addRoles.Designer.cs
                            Id = new Guid("2841960c-e376-4c07-9fc3-1d96ebc6c34d"),
                            IsAvaible = true,
========
                            Id = new Guid("f8b87b86-60cf-4861-9a1c-09eb7fe91032"),
                            IsAvaiable = true,
>>>>>>>> s2-Diana-Kosel-2:MyQuickDesk/Migrations/20230630162941_init.Designer.cs
                            MaxCapacity = 1,
                            Name = "Biurko B1"
                        },
                        new
                        {
<<<<<<<< HEAD:MyQuickDesk/Migrations/20230605123544_addRoles.Designer.cs
                            Id = new Guid("4100f2a8-5414-4cc8-8912-612c93da8784"),
                            IsAvaible = true,
========
                            Id = new Guid("9c90335b-2da0-45a0-8a68-14a7f9ce61ce"),
                            IsAvaiable = true,
>>>>>>>> s2-Diana-Kosel-2:MyQuickDesk/Migrations/20230630162941_init.Designer.cs
                            MaxCapacity = 1,
                            Name = "Biurko B2"
                        });
                });

            modelBuilder.Entity("MyQuickDesk.Entities.ParkingSpot", b =>
                {
                    b.HasBaseType("MyQuickDesk.Entities.Space");

                    b.Property<bool>("Charger")
                        .HasColumnType("bit");

                    b.Property<bool>("HandicappedSpot")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("ParkingSpot");

                    b.HasData(
                        new
                        {
<<<<<<<< HEAD:MyQuickDesk/Migrations/20230605123544_addRoles.Designer.cs
                            Id = new Guid("43c19f19-7864-48c4-8aaa-96160c99fcd7"),
                            IsAvaible = true,
========
                            Id = new Guid("1e35e810-5309-4a89-8caa-1f7914516b4e"),
                            IsAvaiable = true,
>>>>>>>> s2-Diana-Kosel-2:MyQuickDesk/Migrations/20230630162941_init.Designer.cs
                            MaxCapacity = 1,
                            Name = "P1A1",
                            Charger = true,
                            HandicappedSpot = true
                        },
                        new
                        {
<<<<<<<< HEAD:MyQuickDesk/Migrations/20230605123544_addRoles.Designer.cs
                            Id = new Guid("0b454b18-64f8-43f5-9615-1caa2c601b97"),
                            IsAvaible = true,
========
                            Id = new Guid("b084d967-9a16-442f-80b5-7735150f406a"),
                            IsAvaiable = true,
>>>>>>>> s2-Diana-Kosel-2:MyQuickDesk/Migrations/20230630162941_init.Designer.cs
                            MaxCapacity = 1,
                            Name = "P1A2",
                            Charger = true,
                            HandicappedSpot = true
                        },
                        new
                        {
<<<<<<<< HEAD:MyQuickDesk/Migrations/20230605123544_addRoles.Designer.cs
                            Id = new Guid("75783f97-67a6-4849-a249-988dee99e674"),
                            IsAvaible = true,
========
                            Id = new Guid("33a087ba-1d69-4218-9c52-6b84b3333ea3"),
                            IsAvaiable = true,
>>>>>>>> s2-Diana-Kosel-2:MyQuickDesk/Migrations/20230630162941_init.Designer.cs
                            MaxCapacity = 1,
                            Name = "P1A3",
                            Charger = true,
                            HandicappedSpot = true
                        },
                        new
                        {
<<<<<<<< HEAD:MyQuickDesk/Migrations/20230605123544_addRoles.Designer.cs
                            Id = new Guid("3e93e578-06b8-446c-bd05-d430ae107e3f"),
                            IsAvaible = true,
========
                            Id = new Guid("b91008db-7de8-4cee-9023-8e27398d2cda"),
                            IsAvaiable = true,
>>>>>>>> s2-Diana-Kosel-2:MyQuickDesk/Migrations/20230630162941_init.Designer.cs
                            MaxCapacity = 1,
                            Name = "P1B1",
                            Charger = true,
                            HandicappedSpot = true
                        });
                });

            modelBuilder.Entity("MyQuickDesk.Entities.Room", b =>
                {
                    b.HasBaseType("MyQuickDesk.Entities.Space");

                    b.HasDiscriminator().HasValue("Room");

                    b.HasData(
                        new
                        {
<<<<<<<< HEAD:MyQuickDesk/Migrations/20230605123544_addRoles.Designer.cs
                            Id = new Guid("b0d7b0e3-240e-4153-9328-2f958b81f761"),
                            IsAvaible = true,
========
                            Id = new Guid("25d022d0-a572-4d65-a6fe-6a1ee1f70734"),
                            IsAvaiable = true,
>>>>>>>> s2-Diana-Kosel-2:MyQuickDesk/Migrations/20230630162941_init.Designer.cs
                            MaxCapacity = 8,
                            Name = "Mariacka"
                        },
                        new
                        {
<<<<<<<< HEAD:MyQuickDesk/Migrations/20230605123544_addRoles.Designer.cs
                            Id = new Guid("3eb0f9e8-e0c7-48cd-a513-e196c6e531e5"),
                            IsAvaible = true,
========
                            Id = new Guid("0075bff7-7529-496a-a426-4e5b0af658a2"),
                            IsAvaiable = true,
>>>>>>>> s2-Diana-Kosel-2:MyQuickDesk/Migrations/20230630162941_init.Designer.cs
                            MaxCapacity = 10,
                            Name = "Neptun"
                        },
                        new
                        {
<<<<<<<< HEAD:MyQuickDesk/Migrations/20230605123544_addRoles.Designer.cs
                            Id = new Guid("d6cdce25-eede-4db5-97cd-5c37e692d416"),
                            IsAvaible = true,
========
                            Id = new Guid("76aaa782-7004-41c2-b498-540fb09021f8"),
                            IsAvaiable = true,
>>>>>>>> s2-Diana-Kosel-2:MyQuickDesk/Migrations/20230630162941_init.Designer.cs
                            MaxCapacity = 12,
                            Name = "Polityczna"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyQuickDesk.Entities.Reservation", b =>
                {
                    b.HasOne("MyQuickDesk.Entities.Desk", "Desk")
                        .WithMany("Reservations")
                        .HasForeignKey("DeskId");

                    b.HasOne("MyQuickDesk.Entities.ParkingSpot", "ParkingSpot")
                        .WithMany("Reservations")
                        .HasForeignKey("ParkingSpotId");

                    b.HasOne("MyQuickDesk.Entities.Room", "Room")
                        .WithMany("Reservations")
                        .HasForeignKey("RoomId");

                    b.HasOne("MyQuickDesk.Entities.Space", "Space")
                        .WithMany()
                        .HasForeignKey("SpaceId");

                    b.HasOne("MyQuickDesk.Entities.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId");

                    b.Navigation("Desk");

                    b.Navigation("ParkingSpot");

                    b.Navigation("Room");

                    b.Navigation("Space");

                    b.Navigation("User");
                });

<<<<<<<< HEAD:MyQuickDesk/Migrations/20230605123544_addRoles.Designer.cs
========
            modelBuilder.Entity("MyQuickDesk.Entities.Space", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.Navigation("CreatedBy");
                });

>>>>>>>> s2-Diana-Kosel-2:MyQuickDesk/Migrations/20230630162941_init.Designer.cs
            modelBuilder.Entity("MyQuickDesk.Entities.User", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("MyQuickDesk.Entities.Desk", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("MyQuickDesk.Entities.ParkingSpot", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("MyQuickDesk.Entities.Room", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}