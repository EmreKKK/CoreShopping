using CoreShopping.BusinessLogic.Abstract;
using CoreShopping.DataAccess.Abstract;
using CoreShopping.DataAccess.Concrete.EFCore;
using CoreShopping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreShopping.BusinessLogic.Concrete
{
    public class ProductManager : IProductService
    {//BU İŞLEM INJECTI0N 
        // private bir instance aldık 
        private IProductDAL _productDAL;

        // construct method ile bu işlemi new'ledik ve artık RAM üzerinde bir karşılığı var.
        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }


        public void Create(Product entity)
        {
            _productDAL.Create(entity);
        }

        public void Delete(Product entity)
        {
            _productDAL.Delete(entity);
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter)
        {
            return _productDAL.GetAll(filter).ToList();
        }

        public Product GetById(int id)
        {
            return _productDAL.GetById(id);
        }

        public Product GetProductDetails(int id)
        {
            return _productDAL.GetProductDetails(id);
        }

        public List<Product> GetProductsByCategory(string category,int page,int pageSize)
        {
            return _productDAL.GetProductsByCategory(category,page,pageSize);
        }

        public void Update(Product entity)
        {
            _productDAL.Update(entity);
        }
    }
}
