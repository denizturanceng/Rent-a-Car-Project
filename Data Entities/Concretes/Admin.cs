using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entities
{
    [Table("Admin")]
    public class Admin
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int adminID { get; set; }

        [Required,StringLength(15)]
        public string adminKullaniciAd { get; set; }

        [Required, StringLength(15)]
        public string adminSifre { get; set; }
    }
}
