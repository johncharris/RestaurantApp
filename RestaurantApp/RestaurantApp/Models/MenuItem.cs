﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ThumbnailUri { get; set; }
    }
}
