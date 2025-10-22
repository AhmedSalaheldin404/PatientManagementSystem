using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatientManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePetInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Patients",
                newName: "Species");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Patients",
                newName: "Sex");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Patients",
                newName: "Phone");

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Diagnosis",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnerName",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PetName",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Details",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Diagnosis",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "OwnerName",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PetName",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "Species",
                table: "Patients",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Sex",
                table: "Patients",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Patients",
                newName: "City");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Height",
                table: "Patients",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Weight",
                table: "Patients",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
