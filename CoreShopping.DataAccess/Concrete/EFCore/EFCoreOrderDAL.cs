using CoreShopping.DataAccess.Abstract;
using CoreShopping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreShopping.DataAccess.Concrete.EFCore
{
    public class EFCoreOrderDAL : EFCoreGenericRepository<Order, Context>, IOrderDAL
    {
    }
}
