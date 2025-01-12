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
    public class CategorySalesFor1997Manager : GenericManager<CategorySalesFor1997, DtoCategorySalesFor1997>, ICategorySalesFor1997Service
    {
        public CategorySalesFor1997Manager(IServiceProvider service) : base(service)
        {
        }

        public IQueryable<DtoCategorySalesFor1997> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
