using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessAPI.Migrations
{
    public partial class MuscleGroupAlternateKeyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MuscleGroupType",
                table: "MuscleGroups",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddUniqueConstraint(
                name: "AK_MuscleGroups_MuscleGroupType",
                table: "MuscleGroups",
                column: "MuscleGroupType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_MuscleGroups_MuscleGroupType",
                table: "MuscleGroups");

            migrationBuilder.AlterColumn<string>(
                name: "MuscleGroupType",
                table: "MuscleGroups",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
