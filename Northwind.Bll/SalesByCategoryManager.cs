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
    public class SalesByCategoryManager : GenericManager<SalesByCategory, DtoSalesByCategory>, ISalesByCategoryService
    {
        public SalesByCategoryManager(IServiceProvider service) : base(service)
        {
        }

        public IQueryable<DtoSalesByCategory> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
