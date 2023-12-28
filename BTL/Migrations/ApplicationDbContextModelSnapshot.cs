﻿// <auto-generated />
using System;
using BTL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BTL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("BTL.Models.HoaDon", b =>
                {
                    b.Property<int>("MaHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaKhachHang")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaPhong")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NgayThanhToan")
                        .HasColumnType("TEXT");

                    b.Property<int>("ThanhTien")
                        .HasColumnType("INTEGER");

                    b.HasKey("MaHoaDon");

                    b.HasIndex("MaKhachHang");

                    b.HasIndex("MaPhong");

                    b.ToTable("HoaDons");
                });

            modelBuilder.Entity("BTL.Models.KhachHang", b =>
                {
                    b.Property<int>("MaKhachHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NgayThue")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Tuoi")
                        .HasColumnType("INTEGER");

                    b.HasKey("MaKhachHang");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("BTL.Models.NhanVien", b =>
                {
                    b.Property<string>("MaNhanVien")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenNV")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Tuoi")
                        .HasColumnType("INTEGER");

                    b.HasKey("MaNhanVien");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("BTL.Models.Phong", b =>
                {
                    b.Property<int>("MaPhong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GiaTien")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LoaiPhong")
                        .HasColumnType("TEXT");

                    b.Property<int>("MaKhachHang")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenPhong")
                        .HasColumnType("TEXT");

                    b.HasKey("MaPhong");

                    b.HasIndex("MaKhachHang");

                    b.ToTable("Phong");
                });

            modelBuilder.Entity("BTL.Models.HoaDon", b =>
                {
                    b.HasOne("BTL.Models.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("MaKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BTL.Models.Phong", "Phong")
                        .WithMany()
                        .HasForeignKey("MaPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("Phong");
                });

            modelBuilder.Entity("BTL.Models.Phong", b =>
                {
                    b.HasOne("BTL.Models.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("MaKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");
                });
#pragma warning restore 612, 618
        }
    }
}
