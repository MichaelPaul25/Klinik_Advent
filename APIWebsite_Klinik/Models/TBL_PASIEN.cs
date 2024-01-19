using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APIWebsite_Klinik.Models
{
    public class TBL_PASIEN
    {
        [Key]
        public int ID_PASIEN { get; set; }
        public string REKAM_MEDIS { get; set; }
        public string NAMA_PASIEN { get; set; }
        public TBL_ALAMAT? ALAMAT { get; set; }
        public string JENIS_KELAMIN { get; set; }
        public string AGAMA { get; set; }
        public string PEKERJAAN { get; set; }
        public string STATUS_KAWIN { get; set; }
        public string NOMOR_TELEPON { get; set; }
        public string EMAIL_PASIEN { get; set; }
        public string TEMPAT_LAHIR { get; set; }
        public DateTime? TANGGAL_LAHIR { get; set; }
        [ForeignKey("ID_ADMIN")]
        public string REGISTER_BY { get; set; }
        public string MODIFIED_BY { get; set; }
        public string UMUR { get; set; }
    }
}
