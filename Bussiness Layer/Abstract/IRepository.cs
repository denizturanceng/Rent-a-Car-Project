using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Layer.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();

        List<T> ToListAsync();

        int Save();

        int Insert(T obj);

        int Update(T obj);

        int Delete(T obj);

        T GetByID(int id);

        T GetByValue(string value);

    }
}
