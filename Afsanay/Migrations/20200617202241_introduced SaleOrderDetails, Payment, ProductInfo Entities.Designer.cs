﻿// <auto-generated />
using System;
using Afsanay.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Afsanay.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200617202241_introduced SaleOrderDetails, Payment, ProductInfo Entities")]
    partial class introducedSaleOrderDetailsPaymentProductInfoEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Afsanay.Core.DomainObjects.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(300) CHARACTER SET utf8mb4")
                        .HasMaxLength(300);

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(45) CHARACTER SET utf8mb4")
                        .HasMaxLength(45);

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Afsanay.Core.DomainObjects.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("varchar(250) CHARACTER SET utf8mb4")
                        .HasMaxLength(250);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("varchar(45) CHARACTER SET utf8mb4")
                        .HasMaxLength(45);

                    b.Property<string>("ContactNo")
                        .HasColumnType("varchar(11) CHARACTER SET utf8mb4")
                        .HasMaxLength(11);

                    b.Property<string>("Email")
                        .HasColumnType("varchar(45) CHARACTER SET utf8mb4")
                        .HasMaxLength(45);

                    b.Property<bool>("Gender")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(45) CHARACTER SET utf8mb4")
                        .HasMaxLength(45);

                    b.Property<string>("Profession")
                        .HasColumnType("varchar(45) CHARACTER SET utf8mb4")
                        .HasMaxLength(45);

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Afsanay.Core.DomainObjects.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Allowed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("PaymentType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("PaymentId");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("Afsanay.Core.DomainObjects.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(45) CHARACTER SET utf8mb4")
                        .HasMaxLength(45);

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("Stamp")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Afsanay.Core.DomainObjects.ProductInfo", b =>
                {
                    b.Property<int>("ProductInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("ProductInfoId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductInfo");
                });

            modelBuilder.Entity("Afsanay.Core.DomainObjects.SaleOrder", b =>
                {
                    b.Property<int>("SaleOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("varchar(300) CHARACTER SET utf8mb4")
                        .HasMaxLength(300);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<double>("DiscountAmount")
                        .HasColumnType("double");

                    b.Property<double>("DiscountPercentage")
                        .HasColumnType("double");

                    b.Property<int>("DiscountType")
                        .HasColumnType("int");

                    b.Property<double>("Freight")
                        .HasColumnType("double");

                    b.Property<bool>("IsNewCustomer")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.Property<int>("SaleOrderNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("Stamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<double>("SubTotal")
                        .HasColumnType("double");

                    b.Property<double>("TaxAmount")
                        .HasColumnType("double");

                    b.Property<double>("TaxPercentage")
                        .HasColumnType("double");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("double");

                    b.HasKey("SaleOrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PaymentId");

                    b.ToTable("SaleOrders");
                });

            modelBuilder.Entity("Afsanay.Core.DomainObjects.SaleOrderDetails", b =>
                {
                    b.Property<int>("SaleOrderDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Discount")
                        .HasColumnType("double");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SaleOrderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Stamp")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Total")
                        .HasColumnType("double");

                    b.Property<double>("UnitCost")
                        .HasColumnType("double");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("double");

                    b.HasKey("SaleOrderDetailsId");

                    b.HasIndex("SaleOrderId");

                    b.ToTable("SaleOrderDetails");
                });

            modelBuilder.Entity("Afsanay.Core.DomainObjects.Product", b =>
                {
                    b.HasOne("Afsanay.Core.DomainObjects.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Afsanay.Core.DomainObjects.ProductInfo", b =>
                {
                    b.HasOne("Afsanay.Core.DomainObjects.Product", "Product")
                        .WithMany("ProductInfos")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Afsanay.Core.DomainObjects.SaleOrder", b =>
                {
                    b.HasOne("Afsanay.Core.DomainObjects.Customer", "Customer")
                        .WithMany("SaleOrders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Afsanay.Core.DomainObjects.Payment", "Payment")
                        .WithMany("SaleOrders")
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Afsanay.Core.DomainObjects.SaleOrderDetails", b =>
                {
                    b.HasOne("Afsanay.Core.DomainObjects.SaleOrder", "SaleOrder")
                        .WithMany("SaleOrderDetails")
                        .HasForeignKey("SaleOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
