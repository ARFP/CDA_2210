using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankTransactions.Database.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bank_transactions",
                columns: table => new
                {
                    transaction_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transaction_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    transaction_from = table.Column<long>(type: "bigint", nullable: false),
                    transaction_to = table.Column<long>(type: "bigint", nullable: false),
                    transaction_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bank_transactions", x => x.transaction_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bank_transactions");
        }
    }
}
