using CoreShopping.DataAccess.Abstract;
using CoreShopping.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreShopping.DataAccess.Concrete.EFCore
{
    public class EFCoreProductDAL : EFCoreGenericRepository<Product, Context>, IProductDAL

    //Abstract Klasörü içerisindeki Interface'deki imza komutlar miras alınarak aşağıya implement edildi.  EntityFramework komutlarını kullanarak methodların içleri dolduruldu. Farklı bir yapı kullanarak işlem yapmak için farklı bir klasör açılarak onun içerisinde yapılabilir. Mesela MySQL gibi

    {
        public Product GetById(int id) // Products içerindeki resimleri new leyerek listeye almıştık. Bu sebeple Productlar details sayfasında çağırırken images ler gelmiyor. Bu sebeple Generic methodlar dışında EFCoreProductDAL içerisine özellikle Product tipinde bir method tanımladık ve database'deki Product tablosuna Image tablosunu dahil ederek getirmesini istedik.

        {
            using (var context = new Context())
            {
                return context.Products.Include("Images").FirstOrDefault(i => i.Id == id);
            }
        }
    }
}
