using CoreShopping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreShopping.DataAccess.Abstract
{
    public interface IRepositoryDAL<T>
    {
        T GetById(int id);
        T GetOne(Expression<Func<T, bool>> filter);
        IQueryable<T> GetAll(Expression<Func<T, bool>> filter);

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
