using DrinkAndGo_2017.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo_2017.Data.Interfaces
{
    interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get; set; }

        IEnumerable<Drink> PreferredDrinks { get; set; }

        Drink GetDrinkById(int drinkId);
    }

}
