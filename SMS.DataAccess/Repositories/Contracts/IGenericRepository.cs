using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DataAccess.Repositories.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        void Commit();

        // For Store Procedure we are using Drapper
        IEnumerable<M> GetQueryList<M>(string sqlQuery, object parameters = null, CommandType? commandType = null);

        IEnumerable<dynamic> GetQueryDynamic(string sqlQuery, object parameters = null, CommandType? commandType = null);
    }
}
