using Data_Entities;
using Data_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Entity_Framework
{
    public class DataContext : DbContext
    {
       
        public DbSet<Araclar> araclar { get; set; }
        public DbSet<Admin> admin { get; set; }
        public DbSet<Calisan> calisan { get; set; }
        public DbSet<Musteri> musteri { get; set; }
        
    }
}
