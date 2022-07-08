using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinkPal.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CryptoTable",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    UsdLiquidity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsdPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BtcPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnnualInflation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CryptoTable", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CryptoTable");
        }
    }
}
