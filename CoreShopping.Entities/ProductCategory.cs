using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreShopping.Entities
{
    public class ProductCategory
    {
        //public int Id { get; set; }  iki adet PrimaryKey olması için bunu siliyoruz. Çoka çok ilişki 
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
