using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FraudDetectionMaster.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Step = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameOrig = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OldBalanceOrg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewBalanceOrg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameDest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OldBalanceDest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFraud = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
