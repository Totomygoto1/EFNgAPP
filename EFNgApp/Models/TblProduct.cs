﻿using System;
using System.Collections.Generic;

namespace EFNgApp.Models
{
    public partial class TblProduct
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string CategoryName { get; set; }
    }
}
