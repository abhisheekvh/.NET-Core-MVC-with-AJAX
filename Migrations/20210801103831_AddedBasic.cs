using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace JqueryAjax.Migrations
{
    public partial class AddedBasic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "transaction",
                columns: table => new
                {
                    transactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    accountNumber = table.Column<string>(type: "nvarchar(12)", nullable: true),
                    BenificiaryName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    bankName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    swiftCode = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaction", x => x.transactionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "transaction");
        }
    }
}
