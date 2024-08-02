using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BanVeMayBay.Migrations
{
    public partial class aa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChuyenBay_DuongBay_DuongBaysMaDuongBay",
                table: "ChuyenBay");

            migrationBuilder.DropForeignKey(
                name: "FK_ChuyenBay_MayBay_MayBaysMaMayBay",
                table: "ChuyenBay");

            migrationBuilder.DropIndex(
                name: "IX_ChuyenBay_DuongBaysMaDuongBay",
                table: "ChuyenBay");

            migrationBuilder.DropIndex(
                name: "IX_ChuyenBay_MayBaysMaMayBay",
                table: "ChuyenBay");

            migrationBuilder.DropColumn(
                name: "DuongBaysMaDuongBay",
                table: "ChuyenBay");

            migrationBuilder.DropColumn(
                name: "MaDuongBay",
                table: "ChuyenBay");

            migrationBuilder.DropColumn(
                name: "MaMayBay",
                table: "ChuyenBay");

            migrationBuilder.DropColumn(
                name: "MayBaysMaMayBay",
                table: "ChuyenBay");

            migrationBuilder.DropColumn(
                name: "TenDuongBay",
                table: "ChuyenBay");

            migrationBuilder.DropColumn(
                name: "TenMayBay",
                table: "ChuyenBay");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DuongBaysMaDuongBay",
                table: "ChuyenBay",
                type: "bigint",
                nullable: true);

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

            migrationBuilder.AddColumn<long>(
                name: "MayBaysMaMayBay",
                table: "ChuyenBay",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenDuongBay",
                table: "ChuyenBay",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TenMayBay",
                table: "ChuyenBay",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
        }
    }
}
