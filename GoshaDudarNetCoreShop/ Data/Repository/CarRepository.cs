using System;
using System.Collections.Generic;
using System.Linq;
using GoshaDudarNetCoreShop._Data;
using GoshaDudarNetCoreShop.Data.Interfaces;
using GoshaDudarNetCoreShop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GoshaDudarNetCoreShop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);

        public IEnumerable<Car> getFavCars => appDBContent.Car.Where(p => p.isFavourite).Include(c => c.Category);

        public Car getObjectCar(int carId) => appDBContent.Car.FirstOrDefault(p => p.id == carId);
    }
}