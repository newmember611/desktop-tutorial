using Microsoft.EntityFrameworkCore.Migrations;

namespace DoAn.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DongDienThoai",
                columns: table => new
                {
                    IMEI = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaDongDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MauSac = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DongDienThoai", x => x.IMEI);
                });

            migrationBuilder.CreateTable(
                name: "DienThoai",
                columns: table => new
                {
                    MaDongDT = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaLoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaHangSX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaNCC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenDongDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonGia = table.Column<float>(type: "real", nullable: false),
                    GiaKM = table.Column<float>(type: "real", nullable: false),
                    DongDienThoaiIMEI = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DienThoai", x => x.MaDongDT);
                    table.ForeignKey(
                        name: "FK_DienThoai_DongDienThoai_DongDienThoaiIMEI",
                        column: x => x.DongDienThoaiIMEI,
                        principalTable: "DongDienThoai",
                        principalColumn: "IMEI",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DienThoai_DongDienThoaiIMEI",
                table: "DienThoai",
                column: "DongDienThoaiIMEI");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DienThoai");

            migrationBuilder.DropTable(
                name: "DongDienThoai");
        }
    }
}
