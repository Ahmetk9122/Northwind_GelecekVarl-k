﻿using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Interface
{
    public interface ICustomerService : IGenericService<Customer,DtoCustomer>
    {
       IResponse<IQueryable<DtoCustomer>> GetTotalReport();
        //IResponse<DtoCustomer> FindById(string id);
        IResponse<DtoCustomer> Find(string id);


    }

}
