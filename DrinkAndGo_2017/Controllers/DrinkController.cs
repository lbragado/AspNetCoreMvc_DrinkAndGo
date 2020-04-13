using DrinkAndGo_2017.Data.Interfaces;
using DrinkAndGo_2017.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo_2017.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDrinkRepository _drinkRepository;

        public DrinkController(IDrinkRepository drinkRepository, ICategoryRepository categoryRepository)
        {
            this._drinkRepository = drinkRepository;
            this._categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            var drinks = _drinkRepository.Drinks;
            return View(drinks);
        }
    }
}
