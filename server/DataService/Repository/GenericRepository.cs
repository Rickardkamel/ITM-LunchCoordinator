using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Repository
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private readonly DataContext _db;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(object db)
        {
            _db = (DataContext)db;
            _dbSet = _db.Set<TEntity>();
        }

        public TEntity Get(int id)
        {
            return _dbSet.Find(id);
        }

        public List<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public bool Delete(int id)
        {
            _dbSet.Remove(_dbSet.Find(id));
            return SaveChanges();
        }

        public bool Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            return SaveChanges();
        }

        public bool CreateOrUpdate(TEntity entity)
        {
            _dbSet.AddOrUpdate(entity);
            return SaveChanges();
        }

        public bool SaveChanges()
        {
            return _db.SaveChanges() > 0;
        }
    }
}
