using DrinkAndGo_2017.Data.Interfaces;
using DrinkAndGo_2017.Data.Models;
using DrinkAndGo_2017.ViewModels;
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
            DrinkListViewModel vm = new DrinkListViewModel();
            vm.Drinks = _drinkRepository.Drinks;
            vm.CurrentCategory = "DrinkCategory";

            return View(vm);
        }
    }
}
