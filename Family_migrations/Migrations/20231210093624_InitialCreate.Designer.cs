﻿// <auto-generated />
using System;
using Family_migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Family_migrations.Migrations
{
    [DbContext(typeof(FamilyDataContext))]
    [Migration("20231210093624_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Family_migrations.Models.Category_transaction", b =>
                {
                    b.Property<int>("Id_Category")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id_Category"));

                    b.Property<string>("Name_category")
                        .HasColumnType("text");

                    b.Property<int?>("TransactionId_transaction")
                        .HasColumnType("integer");

                    b.HasKey("Id_Category");

                    b.HasIndex("TransactionId_transaction");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Family_migrations.Models.Transaction", b =>
                {
                    b.Property<int>("Id_transaction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id_transaction"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name_transaction")
                        .HasColumnType("text");

                    b.Property<int?>("UserId_User")
                        .HasColumnType("integer");

                    b.Property<int>("sum")
                        .HasColumnType("integer");

                    b.HasKey("Id_transaction");

                    b.HasIndex("UserId_User");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Family_migrations.Models.Type_transaction", b =>
                {
                    b.Property<int>("Id_Type")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id_Type"));

                    b.Property<string>("Name_type")
                        .HasColumnType("text");

                    b.Property<int?>("TransactionId_transaction")
                        .HasColumnType("integer");

                    b.HasKey("Id_Type");

                    b.HasIndex("TransactionId_transaction");

                    b.ToTable("Type");
                });

            modelBuilder.Entity("Family_migrations.Models.User", b =>
                {
                    b.Property<int>("Id_User")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id_User"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.Property<int>("budget")
                        .HasColumnType("integer");

                    b.HasKey("Id_User");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Family_migrations.Models.Category_transaction", b =>
                {
                    b.HasOne("Family_migrations.Models.Transaction", null)
                        .WithMany("CategoryTransactions")
                        .HasForeignKey("TransactionId_transaction");
                });

            modelBuilder.Entity("Family_migrations.Models.Transaction", b =>
                {
                    b.HasOne("Family_migrations.Models.User", null)
                        .WithMany("Transactons")
                        .HasForeignKey("UserId_User");
                });

            modelBuilder.Entity("Family_migrations.Models.Type_transaction", b =>
                {
                    b.HasOne("Family_migrations.Models.Transaction", null)
                        .WithMany("Type_transaction")
                        .HasForeignKey("TransactionId_transaction");
                });

            modelBuilder.Entity("Family_migrations.Models.Transaction", b =>
                {
                    b.Navigation("CategoryTransactions");

                    b.Navigation("Type_transaction");
                });

            modelBuilder.Entity("Family_migrations.Models.User", b =>
                {
                    b.Navigation("Transactons");
                });
#pragma warning restore 612, 618
        }
    }
}
