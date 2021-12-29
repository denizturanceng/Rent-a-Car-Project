using Data_Access_Layer.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Layer
{
    public class Test
    {
        public Test()
        {
            DataContext db = new DataContext();
            db.Database.CreateIfNotExists();
        }
    }
}
