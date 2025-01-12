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
    public class CurrentProductListManager : GenericManager<CurrentProductList, DtoCurrentProductList>, ICurrentProductListService
    {
        public CurrentProductListManager(IServiceProvider service) : base(service)
        {
        }

        public IQueryable<DtoCurrentProductList> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
