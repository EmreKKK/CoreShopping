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
    public class EFCoreProductDAL : IProductDAL

    //Abstract Klasörü içerisindeki Interface'deki imza komutlar miras alınarak aşağıya implement edildi.  EntityFramework komutlarını kullanarak methodların içleri dolduruldu. Farklı bir yapı kullanarak işlem yapmak için farklı bir klasör açılarak onun içerisinde yapılabilir. Mesela MySQL gibi
    {
        Context db = new Context();
        public void Create(Product entity)
        {
            db.Products.Add(entity);
            db.SaveChanges();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetAll(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetOne(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetPopularProducts()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
