using PerfumeStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfumeStore.Data.Interfaces
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> Categories { get; }
    }
}
