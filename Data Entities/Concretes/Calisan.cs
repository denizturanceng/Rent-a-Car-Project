using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entities.Concretes
{
    [Table("Calisan")]
    public class Calisan
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int calisanID { get; set; }

        [Required, StringLength(15)]
        public string calisanKullaniciAd { get; set; }

        [Required, StringLength(15)]
        public string calisanSifre { get; set; }

        [Required, StringLength(30)]
        public string calisanAd { get; set; }

        [Required, StringLength(30)]
        public string calisanSoyad { get; set; }

        [Required, StringLength(10)]
        public string calisanTelefon { get; set; }
    }
}
