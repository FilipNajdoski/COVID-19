using Microsoft.EntityFrameworkCore.Migrations;

namespace Cov19.Migrations
{
    public partial class Sredeuvanjepromenlivi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfCOVID19Patients",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "DeadInCountry",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "HomeTreatedCasesInCountry",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "HospitalizedCasesInCountry",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "InfectedInCountry",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "RecoveredInCountry",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "DeadInCity",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "HomeTreatedCasesInCity",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "HospitalizedCasesInCity",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "InfectedInCity",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "RecoveredInCity",
                table: "Cities");

            migrationBuilder.AddColumn<int>(
                name: "TimeToRecovery",
                table: "Patients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentlyHospitalizedPatients",
                table: "Hospitals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentlyHomeTreatedCasesInCountry",
                table: "Country",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentlyHospitalizedCasesInCountry",
                table: "Country",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentlyInfectedInCountry",
                table: "Country",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentlyHomeTreatedCasesInCity",
                table: "Cities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentlyHospitalizedCasesInCity",
                table: "Cities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentlyInfectedInCity",
                table: "Cities",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeToRecovery",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "CurrentlyHospitalizedPatients",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "CurrentlyHomeTreatedCasesInCountry",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "CurrentlyHospitalizedCasesInCountry",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "CurrentlyInfectedInCountry",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "CurrentlyHomeTreatedCasesInCity",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CurrentlyHospitalizedCasesInCity",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CurrentlyInfectedInCity",
                table: "Cities");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfCOVID19Patients",
                table: "Hospitals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeadInCountry",
                table: "Country",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HomeTreatedCasesInCountry",
                table: "Country",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HospitalizedCasesInCountry",
                table: "Country",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InfectedInCountry",
                table: "Country",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecoveredInCountry",
                table: "Country",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeadInCity",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HomeTreatedCasesInCity",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HospitalizedCasesInCity",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InfectedInCity",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecoveredInCity",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
