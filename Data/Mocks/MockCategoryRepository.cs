using PerfumeStore.Data.Interfaces;
using PerfumeStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfumeStore.Data.Mocks
{
    public class MockCategoryRepository:ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName="Alcoholic", Description="All Alcohololic Drinks"},
                    new Category { CategoryName="Non-Alcoholic", Description="All Non-Alcohololic Drinks"}
                };
            }
        }
    }
}
