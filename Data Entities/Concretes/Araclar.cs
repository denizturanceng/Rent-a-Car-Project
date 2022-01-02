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

        [Required, StringLength(30)]
        public string aracYil { get; set; }

        [Required, StringLength(15)]
        public string aracRenk { get; set; }

        [Required, StringLength(30)]
        public string aracKoltukSayisi { get; set; }

        [Required, StringLength(30)]
        public string aracAirBag { get; set; }

        [Required, StringLength(30)]
        public string aracBaslangicKM { get; set; }
        [Required, StringLength(30)]
        public string aracSonKM { get; set; }

        [Required, StringLength(30)]
        public string aracGunlukFiyat { get; set; }

        [Required, StringLength(30)]
        public string aracKiralanabilirlikDurumu { get; set; }

        public int aracKiralayanMusteriID { get; set; }
        [Required, StringLength(30)]
        public string aracKiralananGun { get; set; }
        [Required, StringLength(30)]
        public string aracToplamTutar{ get; set; }


    }
}
