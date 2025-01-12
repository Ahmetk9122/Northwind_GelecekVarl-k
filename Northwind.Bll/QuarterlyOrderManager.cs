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
    public class QuarterlyOrderManager : GenericManager<QuarterlyOrder, DtoQuarterlyOrder>, IQuarterlyOrderService
    {
        public QuarterlyOrderManager(IServiceProvider service) : base(service)
        {
        }

        public IQueryable<DtoQuarterlyOrder> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
