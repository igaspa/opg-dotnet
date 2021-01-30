﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OPG.Models;

namespace OPG.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210130012137_SeedingInformation")]
    partial class SeedingInformation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("OPG.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Fruit"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Vegetables"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Dairy products and eggs"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Animal products"
                        });
                });

            modelBuilder.Entity("OPG.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            ArrivalTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 2.3m
                        },
                        new
                        {
                            OrderId = 2,
                            ArrivalTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 3.5m
                        },
                        new
                        {
                            OrderId = 3,
                            ArrivalTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 5.6m
                        },
                        new
                        {
                            OrderId = 4,
                            ArrivalTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 2.3m
                        },
                        new
                        {
                            OrderId = 5,
                            ArrivalTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 3.6m
                        });
                });

            modelBuilder.Entity("OPG.Models.OrderProduct", b =>
                {
                    b.Property<int>("OrderProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("OrderProductId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProduct");

                    b.HasData(
                        new
                        {
                            OrderProductId = 1,
                            Price = 2.3m
                        },
                        new
                        {
                            OrderProductId = 2,
                            Price = 4.6m
                        },
                        new
                        {
                            OrderProductId = 3,
                            Price = 5.5m
                        },
                        new
                        {
                            OrderProductId = 4,
                            Price = 6.6m
                        },
                        new
                        {
                            OrderProductId = 5,
                            Price = 5.2m
                        });
                });

            modelBuilder.Entity("OPG.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("PaymentType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentId");

                    b.HasIndex("OrderId");

                    b.ToTable("Payment");

                    b.HasData(
                        new
                        {
                            PaymentId = 1,
                            PaymentType = "Paypal"
                        },
                        new
                        {
                            PaymentId = 2,
                            PaymentType = "Credit Card"
                        });
                });

            modelBuilder.Entity("OPG.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                            Name = "Apple ",
                            UserId = 2
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                            Name = "Carrot",
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 3,
                            Discount = 0f,
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                            Name = "Eggs",
                            UserId = 3
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 4,
                            Discount = 0f,
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                            Name = "Tuna",
                            UserId = 4
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                            Name = "Potato",
                            UserId = 5
                        });
                });

            modelBuilder.Entity("OPG.Models.Rating", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RatingId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Rating");

                    b.HasData(
                        new
                        {
                            RatingId = 1,
                            Note = "this is good"
                        },
                        new
                        {
                            RatingId = 2,
                            Note = "this product is 3/10"
                        },
                        new
                        {
                            RatingId = 3,
                            Note = "this product is 10/10"
                        });
                });

            modelBuilder.Entity("OPG.Models.Seller", b =>
                {
                    b.Property<int>("SellerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Oib")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("SellerId");

                    b.HasIndex("UserId");

                    b.ToTable("Seller");

                    b.HasData(
                        new
                        {
                            SellerId = 1,
                            CompanyName = "OPG1",
                            Oib = 123456789
                        },
                        new
                        {
                            SellerId = 2,
                            CompanyName = "OPG2",
                            Oib = 123456789
                        },
                        new
                        {
                            SellerId = 3,
                            CompanyName = "OPG3",
                            Oib = 123456789
                        });
                });

            modelBuilder.Entity("OPG.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Adress1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adress2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SellerId")
                        .HasColumnType("int");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Adress1 = "Ruđera Boškovića 28",
                            City = "Split",
                            Country = "Hrvatska",
                            FirstName = "Ivan",
                            LastName = "Ivanović",
                            Role = "Seller",
                            SellerId = 1,
                            ZipCode = 21000
                        },
                        new
                        {
                            UserId = 2,
                            Adress1 = "Ruđera Boškovića 20",
                            City = "Split",
                            Country = "Hrvatska",
                            FirstName = "Nikola",
                            LastName = "Nikolić",
                            Role = "Customer",
                            SellerId = 0,
                            ZipCode = 21000
                        },
                        new
                        {
                            UserId = 3,
                            Adress1 = "Ruđera Boškovića 23",
                            City = "Split",
                            Country = "Hrvatska",
                            FirstName = "Ivana",
                            LastName = "Ivanović",
                            Role = "Seller",
                            SellerId = 2,
                            ZipCode = 21000
                        },
                        new
                        {
                            UserId = 4,
                            Adress1 = "Ruđera Boškovića 24",
                            City = "Split",
                            Country = "Hrvatska",
                            FirstName = "Zoran",
                            LastName = "Nikolić",
                            Role = "Customer",
                            SellerId = 0,
                            ZipCode = 21000
                        },
                        new
                        {
                            UserId = 5,
                            Adress1 = "Ruđera Boškovića 30",
                            City = "Split",
                            Country = "Hrvatska",
                            FirstName = "Josipa",
                            LastName = "Ivanović",
                            Role = "Customer",
                            SellerId = 0,
                            ZipCode = 21000
                        });
                });

            modelBuilder.Entity("OPG.Models.Order", b =>
                {
                    b.HasOne("OPG.Models.User", "User")
                        .WithMany("Order")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OPG.Models.OrderProduct", b =>
                {
                    b.HasOne("OPG.Models.Order", "Order")
                        .WithMany("OrderProduct")
                        .HasForeignKey("OrderId");

                    b.HasOne("OPG.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OPG.Models.Payment", b =>
                {
                    b.HasOne("OPG.Models.Order", "Order")
                        .WithMany("Payment")
                        .HasForeignKey("OrderId");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("OPG.Models.Product", b =>
                {
                    b.HasOne("OPG.Models.Category", "Category")
                        .WithMany("Product")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OPG.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OPG.Models.Rating", b =>
                {
                    b.HasOne("OPG.Models.Product", "Product")
                        .WithMany("Rating")
                        .HasForeignKey("ProductId");

                    b.HasOne("OPG.Models.User", "User")
                        .WithMany("Rating")
                        .HasForeignKey("UserId");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OPG.Models.Seller", b =>
                {
                    b.HasOne("OPG.Models.User", "User")
                        .WithMany("Seller")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OPG.Models.Category", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("OPG.Models.Order", b =>
                {
                    b.Navigation("OrderProduct");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("OPG.Models.Product", b =>
                {
                    b.Navigation("Rating");
                });

            modelBuilder.Entity("OPG.Models.User", b =>
                {
                    b.Navigation("Order");

                    b.Navigation("Rating");

                    b.Navigation("Seller");
                });
#pragma warning restore 612, 618
        }
    }
}