using DataAccessLayer;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Repository<T> : IRepository<T> where T : class ,IEntity,new()
    {
        private DataBaseContext _databaseContext;

        private DbSet<T> _objectSet;

        public Repository()
        {
            if (_databaseContext==null)
            {
                _databaseContext=new DataBaseContext();
                _objectSet= _databaseContext.Set<T>();  
            }
        }
        public int Add(T entity)
        {
           _objectSet.Add(entity);
            return _databaseContext.SaveChanges();
        }

        public T Find(int id)
        {
            return _objectSet.Find(id);
        }

        

        public T Get(Expression<Func<T, bool>> expression)
        {
            return _objectSet.FirstOrDefault(expression);
        }

        public List<T> GetAll()
        {
            return _objectSet.ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return _objectSet.Where(expression).ToList();
        }

        public int Remove(T entity)
        {
            _objectSet.Remove(entity);
            return _databaseContext.SaveChanges();
        }

        public int Update(T entity)
        {
            _objectSet.Update(entity);
            return _databaseContext.SaveChanges();
        }
    }
}
