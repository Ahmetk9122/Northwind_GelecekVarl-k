﻿using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Abstract
{
    public interface ICustomerRepository
    {
        IQueryable<Customer> GetTotalReport();

        //Customer GetFind(string id);
        Customer Find(string id);



    }
}
