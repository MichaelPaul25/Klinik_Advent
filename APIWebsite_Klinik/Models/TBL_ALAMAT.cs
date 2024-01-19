using System.ComponentModel.DataAnnotations;

namespace APIWebsite_Klinik.Models
{
    public class TBL_ALAMAT
    {
        [Key]
        public int ID_ALAMAT { get; set; }
        public string JALAN_PERUMAHAN { get; set; }
        public string RT_RW { get; set; }
        public string KECAMATAN { get; set; }
        public string KABUPATEN { get; set; }
        public string KOTA { get; set; }
        public string PROVINSI { get; set; }
    }
}
