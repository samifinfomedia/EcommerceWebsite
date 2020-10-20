using PerfumeStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfumeStore.Data.Interfaces
{
    public interface IDrinkRepository
    {
        public IEnumerable<Drink> Drinks { get; }
        public IEnumerable<Drink> PreferredDrinks { get; }
        Drink GetDrinkById(int drinkId);
    }
}
