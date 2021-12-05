using ORM_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORM_project.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<User> Users { get; set; }
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }
        public List<Category> Categories { get; set; }
    }
}
