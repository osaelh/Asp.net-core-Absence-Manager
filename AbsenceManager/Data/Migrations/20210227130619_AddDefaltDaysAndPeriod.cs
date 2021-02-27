using Microsoft.EntityFrameworkCore.Migrations;

namespace AbsenceManager.Data.Migrations
{
    public partial class AddDefaltDaysAndPeriod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DefaultDays",
                table: "AbsenceTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "AbsenceAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DefaultDays",
                table: "AbsenceTypes");

            migrationBuilder.DropColumn(
                name: "Period",
                table: "AbsenceAllocations");
        }
    }
}
