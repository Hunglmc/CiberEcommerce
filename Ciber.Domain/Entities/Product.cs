﻿using Ciber.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciber.Domain.Entities
{
    public class Product:BaseEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? CategoryId { get; set; }
        public string ProductDescription { get; set; }

        public decimal? UnitPrice { get; set; }

    }
}
