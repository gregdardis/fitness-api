using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessAPI.Migrations
{
    public partial class ReAddDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_MuscleGroups_MainMuscleGroupMuscleGroupId",
                table: "Exercises");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Exercises",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "MainMuscleGroupMuscleGroupId",
                table: "Exercises",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_MuscleGroups_MainMuscleGroupMuscleGroupId",
                table: "Exercises",
                column: "MainMuscleGroupMuscleGroupId",
                principalTable: "MuscleGroups",
                principalColumn: "MuscleGroupId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_MuscleGroups_MainMuscleGroupMuscleGroupId",
                table: "Exercises");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Exercises",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MainMuscleGroupMuscleGroupId",
                table: "Exercises",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_MuscleGroups_MainMuscleGroupMuscleGroupId",
                table: "Exercises",
                column: "MainMuscleGroupMuscleGroupId",
                principalTable: "MuscleGroups",
                principalColumn: "MuscleGroupId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
