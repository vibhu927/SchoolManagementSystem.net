using SMS.Models.ViewModels;
using SMS.DataAccess.Repositories.Contracts;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;



namespace SMS.DataAccess.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private SMSContext  _entities;
        public GenericRepository(SMSContext _context)
        {
            _entities = _context;
        }
        public virtual IQueryable<T> GetAll()
        {

            IQueryable<T> query = _entities.Set<T>();
            return query;
        }
        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            IQueryable<T> query = _entities.Set<T>().Where(predicate);
            return query;
        }
        public virtual void Add(T entity)
        {
            _entities.Set<T>().Add(entity);
        }
        public virtual void Delete(T entity)
        {
            _entities.Set<T>().Remove(entity);
        }
        public virtual void Update(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Commit()
        {
            _entities.SaveChanges();
        }

        // For Store Procedures we will use these functions 
        public virtual IEnumerable<M> GetQueryList<M>(string sqlQuery, object parameters = null, CommandType? commandType = null)
        {
            try
            {
                var a = _entities.Database.GetDbConnection();
                return _entities.Database.GetDbConnection().Query<M>(sqlQuery, parameters, null, false, null, commandType).ToList();
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public IEnumerable<dynamic> GetQueryDynamic(string sqlQuery, object parameters = null, CommandType? commandType = null)
        {
            try
            {
                return _entities.Database.GetDbConnection().Query(sqlQuery, parameters, null, false, null, commandType);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
