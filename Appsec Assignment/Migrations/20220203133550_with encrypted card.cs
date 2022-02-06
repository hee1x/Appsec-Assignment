using Microsoft.EntityFrameworkCore.Migrations;

namespace Appsec_Assignment.Migrations
{
    public partial class withencryptedcard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreditCardNo",
                table: "AspNetUsers",
                type: "nvarchar(MAX)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreditCardNo",
                table: "AspNetUsers",
                type: "nvarchar(16)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(MAX)",
                oldNullable: true);
        }
    }
}
