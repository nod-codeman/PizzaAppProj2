﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VMANpizza.Models;

namespace VMANpizza.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191126164541_OneChange")]
    partial class OneChange
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VMANpizza.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("VMANpizza.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("totalPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("VMANpizza.Models.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("PizzaType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("QtyL")
                        .HasColumnType("float");

                    b.Property<double>("QtyM")
                        .HasColumnType("float");

                    b.Property<double>("QtyS")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("VMANpizza.Models.ViewModel.OrderPizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("PriceLbac")
                        .HasColumnType("float");

                    b.Property<double>("PriceLche")
                        .HasColumnType("float");

                    b.Property<double>("PriceLchk")
                        .HasColumnType("float");

                    b.Property<double>("PriceLmus")
                        .HasColumnType("float");

                    b.Property<double>("PriceLpep")
                        .HasColumnType("float");

                    b.Property<double>("PriceLsal")
                        .HasColumnType("float");

                    b.Property<double>("PriceMbac")
                        .HasColumnType("float");

                    b.Property<double>("PriceMche")
                        .HasColumnType("float");

                    b.Property<double>("PriceMchk")
                        .HasColumnType("float");

                    b.Property<double>("PriceMmus")
                        .HasColumnType("float");

                    b.Property<double>("PriceMpep")
                        .HasColumnType("float");

                    b.Property<double>("PriceMsal")
                        .HasColumnType("float");

                    b.Property<double>("PriceSbac")
                        .HasColumnType("float");

                    b.Property<double>("PriceSche")
                        .HasColumnType("float");

                    b.Property<double>("PriceSchk")
                        .HasColumnType("float");

                    b.Property<double>("PriceSmus")
                        .HasColumnType("float");

                    b.Property<double>("PriceSpep")
                        .HasColumnType("float");

                    b.Property<double>("PriceSsal")
                        .HasColumnType("float");

                    b.Property<double>("QtyLbac")
                        .HasColumnType("float");

                    b.Property<double>("QtyLche")
                        .HasColumnType("float");

                    b.Property<double>("QtyLchk")
                        .HasColumnType("float");

                    b.Property<double>("QtyLmus")
                        .HasColumnType("float");

                    b.Property<double>("QtyLpep")
                        .HasColumnType("float");

                    b.Property<double>("QtyLsal")
                        .HasColumnType("float");

                    b.Property<double>("QtyMbac")
                        .HasColumnType("float");

                    b.Property<double>("QtyMche")
                        .HasColumnType("float");

                    b.Property<double>("QtyMchk")
                        .HasColumnType("float");

                    b.Property<double>("QtyMmus")
                        .HasColumnType("float");

                    b.Property<double>("QtyMpep")
                        .HasColumnType("float");

                    b.Property<double>("QtyMsal")
                        .HasColumnType("float");

                    b.Property<double>("QtySbac")
                        .HasColumnType("float");

                    b.Property<double>("QtySche")
                        .HasColumnType("float");

                    b.Property<double>("QtySchk")
                        .HasColumnType("float");

                    b.Property<double>("QtySmus")
                        .HasColumnType("float");

                    b.Property<double>("QtySpep")
                        .HasColumnType("float");

                    b.Property<double>("QtySsal")
                        .HasColumnType("float");

                    b.Property<int>("customerId")
                        .HasColumnType("int");

                    b.Property<int>("orderId")
                        .HasColumnType("int");

                    b.Property<string>("pizzaTypeBac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pizzaTypeChe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pizzaTypeChk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pizzaTypeMus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pizzaTypePep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pizzaTypeSal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("totalPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("OrderPizza");
                });

            modelBuilder.Entity("VMANpizza.Models.Order", b =>
                {
                    b.HasOne("VMANpizza.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VMANpizza.Models.Pizza", b =>
                {
                    b.HasOne("VMANpizza.Models.Order", null)
                        .WithMany("Pizzas")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
