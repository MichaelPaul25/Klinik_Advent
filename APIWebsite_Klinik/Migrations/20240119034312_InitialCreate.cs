using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIWebsiteKlinik.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_ALAMATs",
                columns: table => new
                {
                    IDALAMAT = table.Column<int>(name: "ID_ALAMAT", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JALANPERUMAHAN = table.Column<string>(name: "JALAN_PERUMAHAN", type: "nvarchar(max)", nullable: false),
                    RTRW = table.Column<string>(name: "RT_RW", type: "nvarchar(max)", nullable: false),
                    KECAMATAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KABUPATEN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KOTA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PROVINSI = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_ALAMATs", x => x.IDALAMAT);
                });

            migrationBuilder.CreateTable(
                name: "TBL_PASIENs",
                columns: table => new
                {
                    IDPASIEN = table.Column<int>(name: "ID_PASIEN", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REKAMMEDIS = table.Column<string>(name: "REKAM_MEDIS", type: "nvarchar(max)", nullable: false),
                    NAMAPASIEN = table.Column<string>(name: "NAMA_PASIEN", type: "nvarchar(max)", nullable: false),
                    ALAMATIDALAMAT = table.Column<int>(name: "ALAMATID_ALAMAT", type: "int", nullable: true),
                    JENISKELAMIN = table.Column<string>(name: "JENIS_KELAMIN", type: "nvarchar(max)", nullable: false),
                    AGAMA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PEKERJAAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STATUSKAWIN = table.Column<string>(name: "STATUS_KAWIN", type: "nvarchar(max)", nullable: false),
                    NOMORTELEPON = table.Column<string>(name: "NOMOR_TELEPON", type: "nvarchar(max)", nullable: false),
                    EMAILPASIEN = table.Column<string>(name: "EMAIL_PASIEN", type: "nvarchar(max)", nullable: false),
                    TEMPATLAHIR = table.Column<string>(name: "TEMPAT_LAHIR", type: "nvarchar(max)", nullable: false),
                    TANGGALLAHIR = table.Column<DateTime>(name: "TANGGAL_LAHIR", type: "datetime2", nullable: true),
                    REGISTERBY = table.Column<string>(name: "REGISTER_BY", type: "nvarchar(max)", nullable: false),
                    MODIFIEDBY = table.Column<string>(name: "MODIFIED_BY", type: "nvarchar(max)", nullable: false),
                    UMUR = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_PASIENs", x => x.IDPASIEN);
                    table.ForeignKey(
                        name: "FK_TBL_PASIENs_TBL_ALAMATs_ALAMATID_ALAMAT",
                        column: x => x.ALAMATIDALAMAT,
                        principalTable: "TBL_ALAMATs",
                        principalColumn: "ID_ALAMAT");
                });

            migrationBuilder.CreateTable(
                name: "TBL_PENDAFTARANs",
                columns: table => new
                {
                    IDPENDAFTARAN = table.Column<int>(name: "ID_PENDAFTARAN", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPASIEN = table.Column<int>(name: "ID_PASIEN", type: "int", nullable: false),
                    IDADMIN = table.Column<int>(name: "ID_ADMIN", type: "int", nullable: false),
                    PASIENIDPASIEN = table.Column<int>(name: "PASIENID_PASIEN", type: "int", nullable: true),
                    NAMAPASIEN = table.Column<string>(name: "NAMA_PASIEN", type: "nvarchar(max)", nullable: false),
                    UNITDITUJU = table.Column<string>(name: "UNIT_DITUJU", type: "nvarchar(max)", nullable: false),
                    IDTINDAKAN = table.Column<string>(name: "ID_TINDAKAN", type: "nvarchar(max)", nullable: false),
                    KONSULTASI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TANGGALBEROBAT = table.Column<DateTime>(name: "TANGGAL_BEROBAT", type: "datetime2", nullable: true),
                    STATUSFORM = table.Column<string>(name: "STATUS_FORM", type: "nvarchar(max)", nullable: false),
                    DIBUATOLEH = table.Column<string>(name: "DIBUAT_OLEH", type: "nvarchar(max)", nullable: false),
                    TANGGALDIBUAT = table.Column<DateTime>(name: "TANGGAL_DIBUAT", type: "datetime2", nullable: true),
                    DIUPDATEOLEH = table.Column<string>(name: "DIUPDATE_OLEH", type: "nvarchar(max)", nullable: false),
                    TANGGALUPDATE = table.Column<DateTime>(name: "TANGGAL_UPDATE", type: "datetime2", nullable: true),
                    IDOBAT = table.Column<int>(name: "ID_OBAT", type: "int", nullable: false),
                    REKAMMEDIS = table.Column<string>(name: "REKAM_MEDIS", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_PENDAFTARANs", x => x.IDPENDAFTARAN);
                    table.ForeignKey(
                        name: "FK_TBL_PENDAFTARANs_TBL_PASIENs_PASIENID_PASIEN",
                        column: x => x.PASIENIDPASIEN,
                        principalTable: "TBL_PASIENs",
                        principalColumn: "ID_PASIEN");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBL_PASIENs_ALAMATID_ALAMAT",
                table: "TBL_PASIENs",
                column: "ALAMATID_ALAMAT");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_PENDAFTARANs_PASIENID_PASIEN",
                table: "TBL_PENDAFTARANs",
                column: "PASIENID_PASIEN");
        }

        /// <inheritdoc />
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
