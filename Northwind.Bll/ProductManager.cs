﻿using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    public class ProductManager : GenericManager<Product, DtoProduct>, IProductService
    {
        public ProductManager(IServiceProvider service) : base(service)
        {
        }

        public IQueryable<DtoProduct> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
