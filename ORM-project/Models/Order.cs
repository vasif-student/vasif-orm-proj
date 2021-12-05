﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORM_project.Models
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        public List<Product> Products { get; set; }
    }
}
