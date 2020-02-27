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
    [Migration("20200109123336_test2")]
    partial class test2
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
#pragma warning restore 612, 618
        }
    }
}
