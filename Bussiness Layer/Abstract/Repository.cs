using Data_Access_Layer.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Layer.Abstract
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DbSet<T> _objectSet;
        public readonly DataContext _dbContext = new DataContext();

       
        

        public Repository()
        {
            _objectSet = _dbContext.Set<T>();
        }

        public int Delete(T obj)
        {
            _objectSet.Remove(obj);
            return Save();
        }

        public T GetByID(int id)
        {
            return _objectSet.Find(id);
        }

        public T GetByValue(string value)
        {
            return _objectSet.Find(value);
        }

        public int Insert(T obj)
        {
            _objectSet.Add(obj);
            return Save();
        }

        public List<T> List()
        {
            return _objectSet.ToList();
        }

        public List<T> ToListAsync()
        {
            return _objectSet.ToList();
        }


        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public int Update(T obj)
        {
            return Save();
        }
    }
}
