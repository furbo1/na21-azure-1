﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstExample.Models
{
    public partial class OrderLine
    {
        public int OrderId { get; set; }
        public int OrderLineNr { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}