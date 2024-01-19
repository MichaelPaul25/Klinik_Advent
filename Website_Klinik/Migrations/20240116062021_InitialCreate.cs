using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Website_Klinik.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_ALAMATs",
                columns: table => new
                {
                    ID_ALAMAT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JALAN_PERUMAHAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RT_RW = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KECAMATAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KABUPATEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KOTA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PROVINSI = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_ALAMATs", x => x.ID_ALAMAT);
                });

            migrationBuilder.CreateTable(
                name: "TBL_PASIENs",
                columns: table => new
                {
                    ID_PASIEN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REKAM_MEDIS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NAMA_PASIEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ALAMATID_ALAMAT = table.Column<int>(type: "int", nullable: true),
                    JENIS_KELAMIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AGAMA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PEKERJAAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STATUS_KAWIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NOMOR_TELEPON = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMAIL_PASIEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TEMPAT_LAHIR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TANGGAL_LAHIR = table.Column<DateTime>(type: "datetime2", nullable: true),
                    REGISTER_BY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MODIFIED_BY = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_PASIENs", x => x.ID_PASIEN);
                    table.ForeignKey(
                        name: "FK_TBL_PASIENs_TBL_ALAMATs_ALAMATID_ALAMAT",
                        column: x => x.ALAMATID_ALAMAT,
                        principalTable: "TBL_ALAMATs",
                        principalColumn: "ID_ALAMAT");
                });

            migrationBuilder.CreateTable(
                name: "TBL_PENDAFTARANs",
                columns: table => new
                {
                    ID_PENDAFTARAN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_PASIEN = table.Column<int>(type: "int", nullable: false),
                    ID_ADMIN = table.Column<int>(type: "int", nullable: false),
                    PASIENID_PASIEN = table.Column<int>(type: "int", nullable: false),
                    ALAMATID_ALAMAT = table.Column<int>(type: "int", nullable: false),
                    NAMA_PASIEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UNIT_DITUJU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID_TINDAKAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KONSULTASI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TANGGAL_BEROBAT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    STATUS_FORM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DIBUAT_OLEH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TANGGAL_DIBUAT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DIUPDATE_OLEH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TANGGAL_UPDATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ID_OBAT = table.Column<int>(type: "int", nullable: false),
                    REKAM_MEDIS = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_PENDAFTARANs", x => x.ID_PENDAFTARAN);
                    table.ForeignKey(
                        name: "FK_TBL_PENDAFTARANs_TBL_ALAMATs_ALAMATID_ALAMAT",
                        column: x => x.ALAMATID_ALAMAT,
                        principalTable: "TBL_ALAMATs",
                        principalColumn: "ID_ALAMAT",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBL_PENDAFTARANs_TBL_PASIENs_PASIENID_PASIEN",
                        column: x => x.PASIENID_PASIEN,
                        principalTable: "TBL_PASIENs",
                        principalColumn: "ID_PASIEN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBL_PASIENs_ALAMATID_ALAMAT",
                table: "TBL_PASIENs",
                column: "ALAMATID_ALAMAT");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_PENDAFTARANs_ALAMATID_ALAMAT",
                table: "TBL_PENDAFTARANs",
                column: "ALAMATID_ALAMAT");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_PENDAFTARANs_PASIENID_PASIEN",
                table: "TBL_PENDAFTARANs",
                column: "PASIENID_PASIEN");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_PENDAFTARANs");

            migrationBuilder.DropTable(
                name: "TBL_PASIENs");

            migrationBuilder.DropTable(
                name: "TBL_ALAMATs");
        }
    }
}
