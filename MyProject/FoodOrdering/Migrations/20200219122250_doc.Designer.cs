﻿// <auto-generated />
using System;
using FoodOrdering.Core.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodOrdering.Migrations
{
    [DbContext(typeof(FoodStoreContext))]
    [Migration("20200219122250_doc")]
    partial class doc
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoodOrdering.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("FoodOrdering.Core.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("FoodOrdering.Core.Entities.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("FoodItemId");

                    b.HasKey("Id");

                    b.HasIndex("FoodItemId")
                        .IsUnique();

                    b.ToTable("Discount");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Discount");
                });

            modelBuilder.Entity("FoodOrdering.Core.Entities.FoodImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlternativeText");

                    b.Property<int?>("FoodItemId");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("FoodItemId");

                    b.ToTable("FoodImages");
                });

            modelBuilder.Entity("FoodOrdering.Core.Entities.FoodItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.ToTable("FoodItems");
                });

            modelBuilder.Entity("FoodOrdering.Core.Entities.FoodItemCategory", b =>
                {
                    b.Property<int>("FoodItemId");

                    b.Property<int>("CategoryId");

                    b.Property<string>("CategoryName");

                    b.Property<string>("Foodname");

                    b.HasKey("FoodItemId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("FoodItemCategory");
                });

            modelBuilder.Entity("FoodOrdering.Core.Entities.OffLinePayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("OffLinePayment");
                });

            modelBuilder.Entity("FoodOrdering.Core.Entities.OnlinePayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardNumber");

                    b.Property<int>("OrderId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("OnlinePayment");
                });

            modelBuilder.Entity("FoodOrdering.Core.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("FoodItemId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("FoodItemId");

                    b.ToTable("Order");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Order");
                });

            modelBuilder.Entity("FoodOrdering.Core.Entities.FixedAmountDiscount", b =>
                {
                    b.HasBaseType("FoodOrdering.Core.Entities.Discount");

                    b.HasDiscriminator().HasValue("FixedAmountDiscount");
                });

            modelBuilder.Entity("FoodOrdering.Core.Entities.PercentageAmountDiscount", b =>
                {
                    b.HasBaseType("FoodOrdering.Core.Entities.Discount");

                    b.HasDiscriminator().HasValue("PercentageAmountDiscount");
                });

            modelBuilder.Entity("FoodOrdering.Core.Entities.ConfirmedOrder", b =>
                {
                    b.HasBaseType("FoodOrdering.Core.Entities.Order");

                    b.HasDiscriminator().HasValue("ConfirmedOrder");
                });

            modelBuilder.Entity("FoodOrdering.Core.Entities.PendingOrder", b =>
                {
                    b.HasBaseType("FoodOrdering.Core.Entities.Order");

                    b.HasDiscriminator().HasValue("PendingOrder");
                });

            modelBuilder.Entity("FoodOrdering.Core.Entities.Discount", b =>
                {
                    b.HasOne("FoodOrdering.Core.Entities.FoodItem", "FoodItem")
                        .WithOne("PriceDiscount")
                        .HasForeignKey("FoodOrdering.Core.Entities.Discount", "FoodItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FoodOrdering.Core.Entities.FoodImage", b =>
                {
                    b.HasOne("FoodOrdering.Core.Entities.FoodItem", "FoodItem")
                        .WithMany("Images")
                        .HasForeignKey("FoodItemId");
                });

            modelBuilder.Entity("FoodOrdering.Core.Entities.FoodItemCategory", b =>
                {
                    b.HasOne("FoodOrdering.Core.Entities.Category", "Category")
                        .WithMany("Categories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FoodOrdering.Core.Entities.FoodItem", "FoodItem")
                        .WithMany("Categories")
                        .HasForeignKey("FoodItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FoodOrdering.Core.Entities.OffLinePayment", b =>
                {
                    b.HasOne("FoodOrdering.Core.Entities.Order", "Order")
                        .WithOne("OffLinePayment")
                        .HasForeignKey("FoodOrdering.Core.Entities.OffLinePayment", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FoodOrdering.Core.Entities.OnlinePayment", b =>
                {
                    b.HasOne("FoodOrdering.Core.Entities.Order", "Order")
                        .WithOne("OnlinePayment")
                        .HasForeignKey("FoodOrdering.Core.Entities.OnlinePayment", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FoodOrdering.Core.Entities.Order", b =>
                {
                    b.HasOne("FoodOrdering.Core.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FoodOrdering.Core.Entities.FoodItem", "FoodItem")
                        .WithMany("Orders")
                        .HasForeignKey("FoodItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
