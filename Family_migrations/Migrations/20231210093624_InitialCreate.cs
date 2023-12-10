using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Family_migrations.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id_User = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Surname = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    budget = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id_User);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id_transaction = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name_transaction = table.Column<string>(type: "text", nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    sum = table.Column<int>(type: "integer", nullable: false),
                    UserId_User = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id_transaction);
                    table.ForeignKey(
                        name: "FK_Transactions_Users_UserId_User",
                        column: x => x.UserId_User,
                        principalTable: "Users",
                        principalColumn: "Id_User");
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id_Category = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name_category = table.Column<string>(type: "text", nullable: true),
                    TransactionId_transaction = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id_Category);
                    table.ForeignKey(
                        name: "FK_Category_Transactions_TransactionId_transaction",
                        column: x => x.TransactionId_transaction,
                        principalTable: "Transactions",
                        principalColumn: "Id_transaction");
                });

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    Id_Type = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name_type = table.Column<string>(type: "text", nullable: true),
                    TransactionId_transaction = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.Id_Type);
                    table.ForeignKey(
                        name: "FK_Type_Transactions_TransactionId_transaction",
                        column: x => x.TransactionId_transaction,
                        principalTable: "Transactions",
                        principalColumn: "Id_transaction");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_TransactionId_transaction",
                table: "Category",
                column: "TransactionId_transaction");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UserId_User",
                table: "Transactions",
                column: "UserId_User");

            migrationBuilder.CreateIndex(
                name: "IX_Type_TransactionId_transaction",
                table: "Type",
                column: "TransactionId_transaction");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Type");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
