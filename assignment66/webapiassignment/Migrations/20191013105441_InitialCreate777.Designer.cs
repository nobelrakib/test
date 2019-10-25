﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapiassignment;
using WebApi.Store;
namespace webapiassignment.Migrations
{
    [DbContext(typeof(librarycontext))]
    [Migration("20191013105441_InitialCreate777")]
    partial class InitialCreate777
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("webapiassignment.Model.book", b =>
                {
                    b.Property<int>("bookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("author");

                    b.Property<string>("barcode");

                    b.Property<int>("copycount");

                    b.Property<string>("edition");

                    b.Property<string>("title");

                    b.HasKey("bookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("webapiassignment.Model.student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("fine");

                    b.Property<int>("studentId");

                    b.HasKey("id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("webapiassignment.Model.studentbook", b =>
                {
                    b.Property<int>("studentId");

                    b.Property<int>("bookId");

                    b.Property<string>("bookbarcode");

                    b.Property<DateTime>("issuedate");

                    b.Property<DateTime>("returneDate");

                    b.HasKey("studentId", "bookId");

                    b.HasIndex("bookId");

                    b.ToTable("studentbooks");
                });

            modelBuilder.Entity("webapiassignment.Model.studentbook", b =>
                {
                    b.HasOne("webapiassignment.Model.book", "book")
                        .WithMany()
                        .HasForeignKey("bookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("webapiassignment.Model.student", "student")
                        .WithMany("books")
                        .HasForeignKey("studentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}