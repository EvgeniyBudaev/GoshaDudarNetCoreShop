using System;
using System.Collections.Generic;
using GoshaDudarNetCoreShop.Data.Interfaces;
using GoshaDudarNetCoreShop.Data.Models;

namespace GoshaDudarNetCoreShop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public MockCategory()
        {
        }

        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Электромобили", desc = "Современный вид транспорта"},
                    new Category { categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}