using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BanVeMayBay.Migrations
{
    public partial class MK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NhapLaiMatKhau",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NhapLaiMatKhau",
                table: "NhanVien");
        }
    }
}
