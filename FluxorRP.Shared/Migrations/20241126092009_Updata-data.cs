using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluxorRP.Shared.Migrations
{
    /// <inheritdoc />
    public partial class Updatadata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Characters",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Characters");
        }
    }
}
