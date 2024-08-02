using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BanVeMayBay.Migrations
{
    public partial class fk1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<long>(
                name: "KhachHangsMaKhachHang",
                table: "VeBan",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "NhanViensMaNhanVien",
                table: "VeBan",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "rowguid",
                table: "ChuyenBay",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "GhiChu",
                table: "ChuyenBay",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<long>(
                name: "DuongBaysMaDuongBay",
                table: "ChuyenBay",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "MayBaysMaMayBay",
                table: "ChuyenBay",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VeBan_KhachHangsMaKhachHang",
                table: "VeBan",
                column: "KhachHangsMaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_VeBan_NhanViensMaNhanVien",
                table: "VeBan",
                column: "NhanViensMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenBay_DuongBaysMaDuongBay",
                table: "ChuyenBay",
                column: "DuongBaysMaDuongBay");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenBay_MayBaysMaMayBay",
                table: "ChuyenBay",
                column: "MayBaysMaMayBay");

            migrationBuilder.AddForeignKey(
                name: "FK_ChuyenBay_DuongBay_DuongBaysMaDuongBay",
                table: "ChuyenBay",
                column: "DuongBaysMaDuongBay",
                principalTable: "DuongBay",
                principalColumn: "MaDuongBay");

            migrationBuilder.AddForeignKey(
                name: "FK_ChuyenBay_MayBay_MayBaysMaMayBay",
                table: "ChuyenBay",
                column: "MayBaysMaMayBay",
                principalTable: "MayBay",
                principalColumn: "MaMayBay");

            migrationBuilder.AddForeignKey(
                name: "FK_VeBan_KhachHang_KhachHangsMaKhachHang",
                table: "VeBan",
                column: "KhachHangsMaKhachHang",
                principalTable: "KhachHang",
                principalColumn: "MaKhachHang");

            migrationBuilder.AddForeignKey(
                name: "FK_VeBan_NhanVien_NhanViensMaNhanVien",
                table: "VeBan",
                column: "NhanViensMaNhanVien",
                principalTable: "NhanVien",
                principalColumn: "MaNhanVien");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChuyenBay_DuongBay_DuongBaysMaDuongBay",
                table: "ChuyenBay");

            migrationBuilder.DropForeignKey(
                name: "FK_ChuyenBay_MayBay_MayBaysMaMayBay",
                table: "ChuyenBay");

            migrationBuilder.DropForeignKey(
                name: "FK_VeBan_KhachHang_KhachHangsMaKhachHang",
                table: "VeBan");

            migrationBuilder.DropForeignKey(
                name: "FK_VeBan_NhanVien_NhanViensMaNhanVien",
                table: "VeBan");

            migrationBuilder.DropIndex(
                name: "IX_VeBan_KhachHangsMaKhachHang",
                table: "VeBan");

            migrationBuilder.DropIndex(
                name: "IX_VeBan_NhanViensMaNhanVien",
                table: "VeBan");

            migrationBuilder.DropIndex(
                name: "IX_ChuyenBay_DuongBaysMaDuongBay",
                table: "ChuyenBay");

            migrationBuilder.DropIndex(
                name: "IX_ChuyenBay_MayBaysMaMayBay",
                table: "ChuyenBay");

            migrationBuilder.DropColumn(
                name: "KhachHangsMaKhachHang",
                table: "VeBan");

            migrationBuilder.DropColumn(
                name: "NhanViensMaNhanVien",
                table: "VeBan");

            migrationBuilder.DropColumn(
                name: "DuongBaysMaDuongBay",
                table: "ChuyenBay");

            migrationBuilder.DropColumn(
                name: "MayBaysMaMayBay",
                table: "ChuyenBay");

            migrationBuilder.AlterColumn<string>(
                name: "rowguid",
                table: "ChuyenBay",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GhiChu",
                table: "ChuyenBay",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
