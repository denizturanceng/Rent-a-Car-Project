using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entities.Concretes
{
    [Table("Araclar")]
    public class Araclar
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int aracID { get; set; }

        [Required, StringLength(15)]
        public string aracMarka { get; set; }

        [Required, StringLength(15)]
        public string aracModel { get; set; }

        [Required]
        public int aracYil { get; set; }

        [Required, StringLength(15)]
        public string aracRenk { get; set; }

        [Required]
        public int aracKoltukSayisi { get; set; }

        [Required]
        public int aracAirBag { get; set; }

        [Required]
        public int aracBaslangicKM { get; set; }

        public int aracSonKM { get; set; }

        [Required]
        public float aracGunlukFiyat { get; set; }

        [Required]
        public int aracKiralanabilirlikDurumu { get; set; }

        public int aracKiralayanMusteriID { get; set; }
        public int aracKiralananGun { get; set; }
        public float aracToplamTutar{ get; set; }


    }
}
