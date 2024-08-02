using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BanVeMayBay.Migrations
{
    public partial class fk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.AddColumn<long>(
                name: "MaChuyenBay",
                table: "VeBan",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "MaKhachHang",
                table: "VeBan",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "MaNhanVien",
                table: "VeBan",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

           
            migrationBuilder.AddColumn<long>(
                name: "MaDuongBay",
                table: "ChuyenBay",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "MaMayBay",
                table: "ChuyenBay",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            
            migrationBuilder.CreateIndex(
                name: "IX_VeBan_MaKhachHang",
                table: "VeBan",
                column: "MaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_VeBan_MaNhanVien",
                table: "VeBan",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenBay_MaDuongBay",
                table: "ChuyenBay",
                column: "MaDuongBay");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenBay_MaMayBay",
                table: "ChuyenBay",
                column: "MaMayBay");

            migrationBuilder.AddForeignKey(
                name: "FK_ChuyenBay_DuongBay_MaDuongBay",
                table: "ChuyenBay",
                column: "MaDuongBay",
                principalTable: "DuongBay",
                principalColumn: "MaDuongBay",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChuyenBay_MayBay_MaMayBay",
                table: "ChuyenBay",
                column: "MaMayBay",
                principalTable: "MayBay",
                principalColumn: "MaMayBay",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VeBan_KhachHang_MaKhachHang",
                table: "VeBan",
                column: "MaKhachHang",
                principalTable: "KhachHang",
                principalColumn: "MaKhachHang",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VeBan_NhanVien_MaNhanVien",
                table: "VeBan",
                column: "MaNhanVien",
                principalTable: "NhanVien",
                principalColumn: "MaNhanVien",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChuyenBay_DuongBay_MaDuongBay",
                table: "ChuyenBay");

            migrationBuilder.DropForeignKey(
                name: "FK_ChuyenBay_MayBay_MaMayBay",
                table: "ChuyenBay");

            migrationBuilder.DropForeignKey(
                name: "FK_VeBan_KhachHang_MaKhachHang",
                table: "VeBan");

            migrationBuilder.DropForeignKey(
                name: "FK_VeBan_NhanVien_MaNhanVien",
                table: "VeBan");

            migrationBuilder.DropIndex(
                name: "IX_VeBan_MaKhachHang",
                table: "VeBan");

            migrationBuilder.DropIndex(
                name: "IX_VeBan_MaNhanVien",
                table: "VeBan");

            migrationBuilder.DropIndex(
                name: "IX_ChuyenBay_MaDuongBay",
                table: "ChuyenBay");

            migrationBuilder.DropIndex(
                name: "IX_ChuyenBay_MaMayBay",
                table: "ChuyenBay");

            migrationBuilder.DropColumn(
                name: "MaChuyenBay",
                table: "VeBan");

            migrationBuilder.DropColumn(
                name: "MaKhachHang",
                table: "VeBan");

            migrationBuilder.DropColumn(
                name: "MaNhanVien",
                table: "VeBan");

            migrationBuilder.DropColumn(
                name: "MaDuongBay",
                table: "ChuyenBay");

            migrationBuilder.DropColumn(
                name: "MaMayBay",
                table: "ChuyenBay");
        }
    }
}
