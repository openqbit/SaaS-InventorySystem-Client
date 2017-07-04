﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Inventory.Service.WebApi.Models.Api
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public int reOrder { get; set; }

        public int CustomerId { get; set; }
    }
}