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
    public class InvoiceManager : GenericManager<Invoice, DtoInvoice>, IInvoiceService
    {
        public InvoiceManager(IServiceProvider service) : base(service)
        {
        }

        public IQueryable<DtoInvoice> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
