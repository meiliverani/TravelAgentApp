﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelAgentApp.Data;

#nullable disable

namespace TravelAgentApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231018205727_AddQtyColumntoBookingTable")]
    partial class AddQtyColumntoBookingTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TravelAgentApp.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BookingEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BookingNo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("BookingStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BookingStatusId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BookingNo")
                        .IsUnique();

                    b.HasIndex("BookingStatusId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("TravelAgentApp.Models.BookingStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookingStatuses");
                });

            modelBuilder.Entity("TravelAgentApp.Models.CategoryMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("CategoryMappings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            SubCategoryId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            SubCategoryId = 2
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            SubCategoryId = 3
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            SubCategoryId = 4
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            SubCategoryId = 5
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            SubCategoryId = 4
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            SubCategoryId = 6
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            SubCategoryId = 7
                        });
                });

            modelBuilder.Entity("TravelAgentApp.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("IdentityCard")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("TravelAgentApp.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeNo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeNo")
                        .IsUnique();

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("TravelAgentApp.Models.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("EndValidDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InventoryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InventoryNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartValidDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("InventoryNo")
                        .IsUnique();

                    b.HasIndex("ProductId");

                    b.ToTable("Inventories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndValidDate = new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            InventoryDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InventoryNo = "INV00001",
                            ProductId = 1,
                            Qty = 1,
                            StartValidDate = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Local),
                            UpdatedBy = ""
                        });
                });

            modelBuilder.Entity("TravelAgentApp.Models.Merchant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApiUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsIntegrated")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("RequestMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Merchants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "1 Maritime Square HarbourFront Centre",
                            CreatedOn = new DateTime(2023, 10, 19, 3, 57, 27, 649, DateTimeKind.Local).AddTicks(5310),
                            Email = "sindoferry@gmail.com",
                            IsIntegrated = false,
                            Name = "Sindo Ferry",
                            Password = "12345678",
                            Phone = "+65 6331 4123",
                            Username = "sindoferry"
                        });
                });

            modelBuilder.Entity("TravelAgentApp.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMethodId")
                        .HasColumnType("int");

                    b.Property<string>("VerifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VerifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PaymentMethodId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("TravelAgentApp.Models.PaymentMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PaymentMethods");
                });

            modelBuilder.Entity("TravelAgentApp.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryMappingId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MerchantId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryMappingId");

                    b.HasIndex("MerchantId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryMappingId = 4,
                            CreatedBy = "sindoferry",
                            CreatedOn = new DateTime(2023, 10, 19, 3, 57, 27, 649, DateTimeKind.Local).AddTicks(5491),
                            Description = "Single (1-way) Batam Centre to Tanah Merah Ferry Terminal",
                            MerchantId = 1,
                            Name = "1WBTC-TMFT",
                            Price = 400000m
                        });
                });

            modelBuilder.Entity("TravelAgentApp.Models.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hotel Room"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ferry Ticket"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Plane Ticket"
                        });
                });

            modelBuilder.Entity("TravelAgentApp.Models.ProductSubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductSubCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Superior Room"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Deluxe Room"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Suite Room"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Economy Class"
                        },
                        new
                        {
                            Id = 5,
                            Name = "VIP Class"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Business Class"
                        },
                        new
                        {
                            Id = 7,
                            Name = "First Class"
                        });
                });

            modelBuilder.Entity("TravelAgentApp.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TransactionNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("TransactionNo")
                        .IsUnique();

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("TravelAgentApp.Models.Booking", b =>
                {
                    b.HasOne("TravelAgentApp.Models.BookingStatus", "BookingStatus")
                        .WithMany("Bookings")
                        .HasForeignKey("BookingStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelAgentApp.Models.Customer", "Customer")
                        .WithMany("Bookings")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelAgentApp.Models.Product", "Product")
                        .WithMany("Bookings")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookingStatus");

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("TravelAgentApp.Models.CategoryMapping", b =>
                {
                    b.HasOne("TravelAgentApp.Models.ProductCategory", "Category")
                        .WithMany("CategoryMappings")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelAgentApp.Models.ProductSubCategory", "SubCategory")
                        .WithMany("CategoryMappings")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("TravelAgentApp.Models.Inventory", b =>
                {
                    b.HasOne("TravelAgentApp.Models.Product", "Product")
                        .WithMany("Inventories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("TravelAgentApp.Models.Payment", b =>
                {
                    b.HasOne("TravelAgentApp.Models.Customer", "Customer")
                        .WithMany("Payments")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelAgentApp.Models.PaymentMethod", "PaymentMethod")
                        .WithMany("Payments")
                        .HasForeignKey("PaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("PaymentMethod");
                });

            modelBuilder.Entity("TravelAgentApp.Models.Product", b =>
                {
                    b.HasOne("TravelAgentApp.Models.CategoryMapping", "CategoryMapping")
                        .WithMany("Products")
                        .HasForeignKey("CategoryMappingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelAgentApp.Models.Merchant", "Merchant")
                        .WithMany("Products")
                        .HasForeignKey("MerchantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryMapping");

                    b.Navigation("Merchant");
                });

            modelBuilder.Entity("TravelAgentApp.Models.Transaction", b =>
                {
                    b.HasOne("TravelAgentApp.Models.Booking", "Booking")
                        .WithMany("Transactions")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelAgentApp.Models.Payment", "Payment")
                        .WithMany("Transactions")
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("TravelAgentApp.Models.Booking", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("TravelAgentApp.Models.BookingStatus", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("TravelAgentApp.Models.CategoryMapping", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("TravelAgentApp.Models.Customer", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("TravelAgentApp.Models.Merchant", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("TravelAgentApp.Models.Payment", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("TravelAgentApp.Models.PaymentMethod", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("TravelAgentApp.Models.Product", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Inventories");
                });

            modelBuilder.Entity("TravelAgentApp.Models.ProductCategory", b =>
                {
                    b.Navigation("CategoryMappings");
                });

            modelBuilder.Entity("TravelAgentApp.Models.ProductSubCategory", b =>
                {
                    b.Navigation("CategoryMappings");
                });
#pragma warning restore 612, 618
        }
    }
}
