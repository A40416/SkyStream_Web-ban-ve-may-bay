﻿// <auto-generated />
using System;
using BanVeMayBay.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BanVeMayBay.Migrations
{
    [DbContext(typeof(BanVeMayBayContext))]
    [Migration("20240420032246_Add")]
    partial class Add
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BanVeMayBay.Models.ChuyenBay", b =>
                {
                    b.Property<long>("MaChuyenBay")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("MaChuyenBay"), 1L, 1);

                    b.Property<string>("DiemDen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiemDi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GioBay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayDi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Site")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rowguid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaChuyenBay");

                    b.ToTable("ChuyenBay");
                });

            modelBuilder.Entity("BanVeMayBay.Models.DuongBay", b =>
                {
                    b.Property<long>("MaDuongBay")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("MaDuongBay"), 1L, 1);

                    b.Property<decimal>("ChieuDai")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ChieuRong")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Site")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ViTri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rowguid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaDuongBay");

                    b.ToTable("DuongBay");
                });

            modelBuilder.Entity("BanVeMayBay.Models.KhachHang", b =>
                {
                    b.Property<long>("MaKhachHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("MaKhachHang"), 1L, 1);

                    b.Property<string>("CMND")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Site")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenKhachHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rowguid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaKhachHang");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("BanVeMayBay.Models.MayBay", b =>
                {
                    b.Property<long>("MaMayBay")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("MaMayBay"), 1L, 1);

                    b.Property<string>("HangSanXuat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Site")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoGheLoai1")
                        .HasColumnType("int");

                    b.Property<int>("SoGheLoai2")
                        .HasColumnType("int");

                    b.Property<string>("TenMayBay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TongGhe")
                        .HasColumnType("int");

                    b.Property<string>("rowguid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaMayBay");

                    b.ToTable("MayBay");
                });

            modelBuilder.Entity("BanVeMayBay.Models.NhanVien", b =>
                {
                    b.Property<long>("MaNhanVien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("MaNhanVien"), 1L, 1);

                    b.Property<string>("ChucVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Site")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDangNhap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rowguid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaNhanVien");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("BanVeMayBay.Models.ThongBao", b =>
                {
                    b.Property<long>("Ma")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Ma"), 1L, 1);

                    b.Property<int>("KiemTraChu")
                        .HasColumnType("int");

                    b.Property<int>("KiemTraTram")
                        .HasColumnType("int");

                    b.Property<string>("NhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ThoiGian")
                        .HasColumnType("datetime2");

                    b.Property<string>("ThongBao1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rowguid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ma");

                    b.ToTable("ThongBao");
                });

            modelBuilder.Entity("BanVeMayBay.Models.VeBan", b =>
                {
                    b.Property<long>("MaVe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("MaVe"), 1L, 1);

                    b.Property<decimal>("GiaVe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Site")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TongTienThanhToan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("rowguid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaVe");

                    b.ToTable("VeBan");
                });
#pragma warning restore 612, 618
        }
    }
}