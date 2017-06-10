﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Inventory.Service.WebApi.Models.Api
{
    public class Return
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int Qty { get; set; }

        public int BatchID { get; set; }
        public int SupplierID { get; set; }
    }
}