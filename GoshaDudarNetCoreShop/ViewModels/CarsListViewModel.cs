using System;
using System.Collections.Generic;
using GoshaDudarNetCoreShop.Data.Models;

namespace GoshaDudarNetCoreShop.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars { get; set; }

        public string currCategory { get; set; }

        public CarsListViewModel()
        {
        }
    }
}
