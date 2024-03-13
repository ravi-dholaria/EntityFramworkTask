using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramworkTask1.Migrations
{
    /// <inheritdoc />
    public partial class AddNationalityToPassport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "Passports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "Passports");
        }
    }
}
