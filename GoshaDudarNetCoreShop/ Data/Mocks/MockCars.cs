using System;
using System.Collections.Generic;
using System.Linq;
using GoshaDudarNetCoreShop.Data.Interfaces;
using GoshaDudarNetCoreShop.Data.Models;

namespace GoshaDudarNetCoreShop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public MockCars()
        {
        }

        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                    new Car {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        img = "https://www.tesla.com/content/dam/tesla-site/sx-redesign/img/socialcard/MS.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                     new Car {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://www.winnerauto.ua/uploads/gallery_photo/photo/0179/91.jpg",
                        price = 11000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                     new Car {
                        name = "BMW M3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://img.tipcars.com/fotky_velke/33550669_9/2018/E/bmv-m3-top-m-perfomance-paket.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                      new Car {
                        name = "Mercedes C class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://nahodim.com.ua/uploads/cars/new/mercedesbenz/861/vghv3LEgeglm17fGh6HfqVqQ/slider_mercedesbenz_c-class-sedan.jpg",
                        price = 40000,
                        isFavourite = false,
                        available = false,
                        Category = _categoryCars.AllCategories.Last()
                    },
                      new Car {
                        name = "Nisan Leaf",
                        shortDesc = "Бесшумный и экономный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://wroom.ru/i/cars2/nissan_leaf_2.jpg",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                };
            }
        }

        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}