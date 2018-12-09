using AdminECommerceModel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace AdminECommerceAPI.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
        T GetByID(object id);
        IEnumerable<T> GetMany(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "");
        void SaveChanges();

    }
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private DbContext dataContext;
        private IDbSet<T> dbset;
        public BaseRepository(DbContext dataContext)
        {
            this.dataContext = dataContext;
            dbset = dataContext.Set<T>();
        }
        public virtual void Add(T entity)
        {
            dbset.Add(entity);
        }
        public virtual void Update(T entity)
        {
            dbset.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
        }
        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbset.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbset.Remove(obj);
        }
        public virtual T GetByID(object id)
        {
            return dbset.Find(id);
        }
        public virtual IEnumerable<T> GetMany(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<T> query = dbset;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public void SaveChanges()
        {
            this.dataContext.SaveChanges();
        }

        //public virtual T GetById(long id)
        //{
        //    return dbset.Find(id);
        //}
        //public virtual T GetById(string id)
        //{
        //    return dbset.Find(id);
        //}
        //public virtual IEnumerable<T> GetAll()
        //{
        //    return dbset.ToList();
        //}
        //public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        //{
        //    return dbset.Where(where).ToList();
        //}
        //public T Get(Expression<Func<T, bool>> where)
        //{
        //    return dbset.Where(where).FirstOrDefault<T>();
        //}
    }
}