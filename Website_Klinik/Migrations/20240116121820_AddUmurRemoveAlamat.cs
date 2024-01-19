using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Website_Klinik.Migrations
{
    public partial class AddUmurRemoveAlamat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_PENDAFTARANs_TBL_ALAMATs_ALAMATID_ALAMAT",
                table: "TBL_PENDAFTARANs");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_PENDAFTARANs_TBL_PASIENs_PASIENID_PASIEN",
                table: "TBL_PENDAFTARANs");

            migrationBuilder.DropIndex(
                name: "IX_TBL_PENDAFTARANs_ALAMATID_ALAMAT",
                table: "TBL_PENDAFTARANs");

            migrationBuilder.DropColumn(
                name: "ALAMATID_ALAMAT",
                table: "TBL_PENDAFTARANs");

            migrationBuilder.AlterColumn<int>(
                name: "PASIENID_PASIEN",
                table: "TBL_PENDAFTARANs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "UMUR",
                table: "TBL_PASIENs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_PENDAFTARANs_TBL_PASIENs_PASIENID_PASIEN",
                table: "TBL_PENDAFTARANs",
                column: "PASIENID_PASIEN",
                principalTable: "TBL_PASIENs",
                principalColumn: "ID_PASIEN");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_PENDAFTARANs_TBL_PASIENs_PASIENID_PASIEN",
                table: "TBL_PENDAFTARANs");

            migrationBuilder.DropColumn(
                name: "UMUR",
                table: "TBL_PASIENs");

            migrationBuilder.AlterColumn<int>(
                name: "PASIENID_PASIEN",
                table: "TBL_PENDAFTARANs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ALAMATID_ALAMAT",
                table: "TBL_PENDAFTARANs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TBL_PENDAFTARANs_ALAMATID_ALAMAT",
                table: "TBL_PENDAFTARANs",
                column: "ALAMATID_ALAMAT");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_PENDAFTARANs_TBL_ALAMATs_ALAMATID_ALAMAT",
                table: "TBL_PENDAFTARANs",
                column: "ALAMATID_ALAMAT",
                principalTable: "TBL_ALAMATs",
                principalColumn: "ID_ALAMAT",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_PENDAFTARANs_TBL_PASIENs_PASIENID_PASIEN",
                table: "TBL_PENDAFTARANs",
                column: "PASIENID_PASIEN",
                principalTable: "TBL_PASIENs",
                principalColumn: "ID_PASIEN",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
