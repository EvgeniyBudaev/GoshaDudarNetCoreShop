using System;
using System.Collections.Generic;
using GoshaDudarNetCoreShop.Data.Models;

namespace GoshaDudarNetCoreShop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get; }
        Car getObjectCar(int carId);
    }
}