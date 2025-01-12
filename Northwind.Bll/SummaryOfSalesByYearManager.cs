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
    public class SummaryOfSalesByYearManager : GenericManager<SummaryOfSalesByYear, DtoSummaryOfSalesByYear>, ISummaryOfSalesByYearService
    {
        public SummaryOfSalesByYearManager(IServiceProvider service) : base(service)
        {
        }

        public IQueryable<DtoSummaryOfSalesByYear> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
