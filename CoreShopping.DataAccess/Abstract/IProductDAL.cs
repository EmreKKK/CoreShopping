﻿using CoreShopping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreShopping.DataAccess.Abstract
{
    public interface IProductDAL : IRepositoryDAL<Product>
    {
        List<Product> GetProductsByCategory(string category, int page,int pageSize);
        Product GetProductDetails(int id);
        int GetCountByCategory(string category);
    }
}
