using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPWebshopDatabase.Migrations
{
    public partial class AddUniqueEmailAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Users_EMail",
                table: "Users",
                column: "EMail",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_EMail",
                table: "Users");
        }
    }
}
