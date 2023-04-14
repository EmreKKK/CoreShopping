using CoreShopping.BusinessLogic.Abstract;
using CoreShopping.DataAccess.Abstract;
using CoreShopping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreShopping.BusinessLogic.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void Create(Category entity)
        {
            _categoryDAL.Create(entity);
        }

        public void Delete(Category entity)
        {
            _categoryDAL.Delete(entity);
        }

        public IEnumerable<Category> GetAll()
        {
            return _categoryDAL.GetAll(null);
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
