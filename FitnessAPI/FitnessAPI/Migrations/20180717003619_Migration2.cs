using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessAPI.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainMuscleGroup",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "MuscleGroupsInternalData",
                table: "Exercises");

            migrationBuilder.AddColumn<int>(
                name: "MainMuscleGroupId",
                table: "Exercises",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MuscleGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MuscleGroupType = table.Column<int>(nullable: false),
                    ExerciseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuscleGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MuscleGroup_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_MainMuscleGroupId",
                table: "Exercises",
                column: "MainMuscleGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_MuscleGroup_ExerciseId",
                table: "MuscleGroup",
                column: "ExerciseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_MuscleGroup_MainMuscleGroupId",
                table: "Exercises",
                column: "MainMuscleGroupId",
                principalTable: "MuscleGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_MuscleGroup_MainMuscleGroupId",
                table: "Exercises");

            migrationBuilder.DropTable(
                name: "MuscleGroup");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_MainMuscleGroupId",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "MainMuscleGroupId",
                table: "Exercises");

            migrationBuilder.AddColumn<int>(
                name: "MainMuscleGroup",
                table: "Exercises",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MuscleGroupsInternalData",
                table: "Exercises",
                nullable: true);
        }
    }
}
