using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webapplication.Migrations
{
    /// <inheritdoc />
    public partial class signupactiveaddedsss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Userstatus",
                table: "signUps",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Userstatus",
                table: "signUps");
        }
    }
}
