using DrinkAndGo_2017.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo_2017.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get;  }
    }
}
