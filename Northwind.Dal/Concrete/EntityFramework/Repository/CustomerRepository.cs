﻿using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContext context) : base(context)
        {
        }

        /*public Customer GetFind(string id)
        {
            return dbset.Find(id);
        }*/
        public Customer Find(string id)
        {
            return dbset.Find(id);
        }

        //this interface kalıtımına bak 
        /*
         *   public IQueryable<Customer> GetTotalReport() : this()
        {
            return dbset.AsQueryable<Customer>();
        }
         */
        public IQueryable<Customer> GetTotalReport()
        {
            return dbset.AsQueryable<Customer>();
        }
    }
}
