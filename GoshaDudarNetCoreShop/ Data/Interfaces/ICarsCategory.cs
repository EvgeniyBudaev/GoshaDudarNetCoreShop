using System;
using System.Collections.Generic;
using GoshaDudarNetCoreShop.Data.Models;

namespace GoshaDudarNetCoreShop.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}