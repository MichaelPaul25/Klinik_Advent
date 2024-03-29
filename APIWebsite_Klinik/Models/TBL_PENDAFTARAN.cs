﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APIWebsite_Klinik.Models
{
    public class TBL_PENDAFTARAN
    {
        [Key]
        public int ID_PENDAFTARAN { get; set; }
        [ForeignKey("ID_PASIEN")]
        public int ID_PASIEN { get; set; }
        [ForeignKey("ID_ADMIN")]
        public int ID_ADMIN { get; set; }
        public TBL_PASIEN? PASIEN { get; set; }
        public string NAMA_PASIEN { get; set; }
        public string UNIT_DITUJU { get; set; }
        public string ID_TINDAKAN { get; set; }
        public string KONSULTASI { get; set; }
        public DateTime? TANGGAL_BEROBAT { get; set; }
        public string STATUS_FORM { get; set; }
        public string DIBUAT_OLEH { get; set; }
        public DateTime? TANGGAL_DIBUAT { get; set; }
        public string DIUPDATE_OLEH { get; set; }
        public DateTime? TANGGAL_UPDATE { get; set; }
        public int ID_OBAT { get; set; }
        public string REKAM_MEDIS { get; set; }
    }
}
