using Microsoft.EntityFrameworkCore.Migrations;

namespace DataprossingWeb.Data.Migrations
{
    public partial class ApplicationDbContextMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PopulationAgeGroupInBaishaPenghus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    year = table.Column<int>(type: "int", nullable: false),
                    month = table.Column<int>(type: "int", nullable: false),
                    sum = table.Column<int>(type: "int", nullable: false),
                    age0 = table.Column<int>(type: "int", nullable: false),
                    age1 = table.Column<int>(type: "int", nullable: false),
                    age2 = table.Column<int>(type: "int", nullable: false),
                    age3 = table.Column<int>(type: "int", nullable: false),
                    age4 = table.Column<int>(type: "int", nullable: false),
                    age5 = table.Column<int>(type: "int", nullable: false),
                    age6 = table.Column<int>(type: "int", nullable: false),
                    age7 = table.Column<int>(type: "int", nullable: false),
                    age8 = table.Column<int>(type: "int", nullable: false),
                    age9 = table.Column<int>(type: "int", nullable: false),
                    age10 = table.Column<int>(type: "int", nullable: false),
                    age11 = table.Column<int>(type: "int", nullable: false),
                    age12 = table.Column<int>(type: "int", nullable: false),
                    age13 = table.Column<int>(type: "int", nullable: false),
                    age14 = table.Column<int>(type: "int", nullable: false),
                    age15 = table.Column<int>(type: "int", nullable: false),
                    age16 = table.Column<int>(type: "int", nullable: false),
                    age17 = table.Column<int>(type: "int", nullable: false),
                    age18 = table.Column<int>(type: "int", nullable: false),
                    age19 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PopulationAgeGroupInBaishaPenghus", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PopulationAgeGroupInBaishaPenghus");
        }
    }
}
