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
    public class OrderDetailsExtendedManager : GenericManager<OrderDetailsExtended, DtoOrderDetailsExtended>, IOrderDetailsExtendedService
    {
        public OrderDetailsExtendedManager(IServiceProvider service) : base(service)
        {
        }

        public IQueryable<DtoOrderDetailsExtended> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
