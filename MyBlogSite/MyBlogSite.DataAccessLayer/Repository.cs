using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.DataAccessLayer
{
    public class Repository<T> : RepositoryBase, IRepository<T> where T : class
    {
        private DbSet<T> _objectSet;
        
        public Repository()
        {
            _objectSet = db.Set<T>();
        }

        public T GetById(int id)
        {
            return _objectSet.Find(id);
        }

        public IEnumerable<T> List()
        {
            return _objectSet.AsEnumerable();
        }

        public IEnumerable<T> List(Expression<Func<T, bool>> predicate)
        {
            return _objectSet
                   .Where(predicate)
                   .AsEnumerable();
        }

        public void Add(T entity)
        {
            _objectSet.Add(entity);
            db.SaveChanges();
        }

        public void Edit(T entity)
        {
            db.SaveChanges();
        }

        public void Delete(T entity)
        {
            _objectSet.Remove(entity);
            db.SaveChanges();
        }
    }
}
