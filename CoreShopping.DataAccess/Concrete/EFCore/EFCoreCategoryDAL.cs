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
    public class EFCoreCategoryDAL : EFCoreGenericRepository<Category, Context>, ICategoryDAL
    {

    }
}
