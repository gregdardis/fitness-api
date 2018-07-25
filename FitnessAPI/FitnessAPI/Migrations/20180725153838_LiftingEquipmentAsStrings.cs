using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessAPI.Migrations
{
    public partial class LiftingEquipmentAsStrings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LiftingEquipmentType",
                table: "LiftingEquipment",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddUniqueConstraint(
                name: "AK_LiftingEquipment_LiftingEquipmentType",
                table: "LiftingEquipment",
                column: "LiftingEquipmentType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_LiftingEquipment_LiftingEquipmentType",
                table: "LiftingEquipment");

            migrationBuilder.AlterColumn<int>(
                name: "LiftingEquipmentType",
                table: "LiftingEquipment",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
