using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DziennikSzkolnyMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedSchoolYearToClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SchoolYear",
                table: "SchoolClasses",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SchoolYear",
                table: "SchoolClasses");
        }
    }
}
