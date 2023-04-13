using CoreShopping.DataAccess.Abstract;
using CoreShopping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreShopping.DataAccess.Concrete.Memory
{
    public class MemoryProductDAL : IProductDAL
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll(Expression<Func<Product, bool>> filter)
        {
            var products = new List<Product>()
            {
                new Product{ Id = 1,Name="John Wick 4",Price=300,Images={new Image() {ImageUrl="1.jpg" } }},
                new Product{ Id = 1,Name="Matrix 4",Price=400,Images={new Image() {ImageUrl="2.jpg" } }},
                new Product{ Id = 1,Name="Avangers 3",Price=500,Images={new Image() {ImageUrl="3.jpg" } }}
            };

            return products;
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
