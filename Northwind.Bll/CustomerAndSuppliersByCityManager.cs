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
    public class CustomerAndSuppliersByCityManager : GenericManager<CustomerAndSuppliersByCity, DtoCustomerAndSuppliersByCity>, ICustomerAndSuppliersByCityService
    {
        public CustomerAndSuppliersByCityManager(IServiceProvider service) : base(service)
        {
        }

        public IQueryable<DtoCustomerAndSuppliersByCity> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
