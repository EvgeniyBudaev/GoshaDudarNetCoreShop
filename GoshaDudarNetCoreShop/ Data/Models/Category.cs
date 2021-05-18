using System;
using System.Collections.Generic;

namespace GoshaDudarNetCoreShop.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public string desc { get; set; }
        public List<Car> cars { get; set; }

        public Category()
        {
        }
    }
}