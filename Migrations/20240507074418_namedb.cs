using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BanVeMayBay.Migrations
{
    public partial class namedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TenDuongBay",
                table: "ChuyenBay",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenDuongBay",
                table: "ChuyenBay");
        }
    }
}
