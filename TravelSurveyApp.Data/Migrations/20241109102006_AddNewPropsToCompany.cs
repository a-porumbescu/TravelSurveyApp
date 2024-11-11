using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelSurveyApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewPropsToCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Keywords",
                table: "Companies",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Companies",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Keywords",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "Companies");
        }
    }
}
