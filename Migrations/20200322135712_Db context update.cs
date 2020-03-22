using Microsoft.EntityFrameworkCore.Migrations;

namespace Cov19.Migrations
{
    public partial class Dbcontextupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    TotalInfectedInCity = table.Column<int>(nullable: false),
                    TotalRecoveredInCity = table.Column<int>(nullable: false),
                    TotalDeadInCity = table.Column<int>(nullable: false),
                    InfectedInCity = table.Column<int>(nullable: false),
                    RecoveredInCity = table.Column<int>(nullable: false),
                    DeadInCity = table.Column<int>(nullable: false),
                    HospitalizedCasesInCity = table.Column<int>(nullable: false),
                    HomeTreatedCasesInCity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    TotalInfectedInCountry = table.Column<int>(nullable: false),
                    TotalRecoveredInCountry = table.Column<int>(nullable: false),
                    TotalDeadInCountry = table.Column<int>(nullable: false),
                    InfectedInCountry = table.Column<int>(nullable: false),
                    RecoveredInCountry = table.Column<int>(nullable: false),
                    DeadInCountry = table.Column<int>(nullable: false),
                    HospitalizedCasesInCountry = table.Column<int>(nullable: false),
                    HomeTreatedCasesInCountry = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    NumberOfCOVID19Patients = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Hospitals");
        }
    }
}
