﻿using CoreShopping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreShopping.BusinessLogic.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        List<Product> GetAll(Expression<Func<Product,bool>>filter=null);
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}