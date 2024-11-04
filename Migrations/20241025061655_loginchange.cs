using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webapplication.Migrations
{
    /// <inheritdoc />
    public partial class loginchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Message",
                table: "logintable");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "logintable");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "logintable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "logintable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
