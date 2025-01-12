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
    public class SalesTotalsByAmountManager : GenericManager<SalesTotalsByAmount, DtoSalesTotalsByAmount>, ISalesTotalsByAmountService
    {
        public SalesTotalsByAmountManager(IServiceProvider service) : base(service)
        {
        }

        public IQueryable<DtoSalesTotalsByAmount> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
