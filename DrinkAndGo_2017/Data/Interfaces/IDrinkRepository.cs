using DrinkAndGo_2017.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo_2017.Data.Interfaces
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get; }

        IEnumerable<Drink> PreferredDrinks { get; }

        Drink GetDrinkById(int drinkId);
    }

}
