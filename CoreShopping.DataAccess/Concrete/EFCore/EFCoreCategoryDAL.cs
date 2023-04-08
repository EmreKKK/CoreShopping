using CoreShopping.DataAccess.Abstract;
using CoreShopping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreShopping.DataAccess.Concrete.EFCore
{
    public class EFCoreCategoryDAL : ICategoryDAL
    {
        Context db = new Context();
        public void Create(Category entity)
        {
            db.Categories.Add(entity);
            db.SaveChanges();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Category> GetAll(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetOne(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
