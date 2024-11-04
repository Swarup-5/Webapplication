using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webapplication.Migrations
{
    /// <inheritdoc />
    public partial class updateageinsignup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "signUps",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "signUps");
        }
    }
}
