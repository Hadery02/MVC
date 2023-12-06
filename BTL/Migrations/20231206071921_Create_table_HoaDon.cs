using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTL.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_HoaDon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    MaHoaDon = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaKhachHang = table.Column<int>(type: "INTEGER", nullable: false),
                    MaPhong = table.Column<int>(type: "INTEGER", nullable: false),
                    ThanhTien = table.Column<int>(type: "INTEGER", nullable: false),
                    NgayThanhToan = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.MaHoaDon);
                    table.ForeignKey(
                        name: "FK_HoaDons_KhachHang_MaKhachHang",
                        column: x => x.MaKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "MaKhachHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDons_Phong_MaPhong",
                        column: x => x.MaPhong,
                        principalTable: "Phong",
                        principalColumn: "MaPhong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_MaKhachHang",
                table: "HoaDons",
                column: "MaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_MaPhong",
                table: "HoaDons",
                column: "MaPhong");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDons");
        }
    }
}
