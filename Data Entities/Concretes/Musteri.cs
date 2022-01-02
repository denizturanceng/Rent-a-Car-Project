using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entities.Concretes
{
    [Table("Musteriler")]
    public class Musteri
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int musteriID { get; set; }

        [Required, StringLength(30)]
        public string musteriKullaniciAd { get; set; }

        [Required, StringLength(30)]
        public string musteriSifre { get; set; }

        [Required, StringLength(30)]
        public string musteriAdres { get; set; }

        [Required, StringLength(30)]
        public string musteriAd { get; set; }

        [Required, StringLength(30)]
        public string musteriSoyad { get; set; }

        [Required, StringLength(30)]
        public string musteriTelefon { get; set; }

        [Required, StringLength(30)]
        public string musteriTC { get; set; }     

        public int musteriKiraladigiAracID { get; set; }
   
        public string musteriKiralamaTutari { get; set; }
        
        public string musteriKiralamaSuresiGun { get; set; }
       

    }
}
