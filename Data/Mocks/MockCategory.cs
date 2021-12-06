using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{categoryName = "Авто с ДВС", desc = "Просто ахуенная вещь, эта залупа на миллиард+ лошадей (потенциально) разъебет эти повербанки на колесах с закрытыми глазами, 100 из 10 по персии нашего журнала"},
                    new Category{categoryName = "Электромобили", desc = "Беззвучная шустрая фигня. Раньше была выгодной, но теперь за зарядку авто надо платить, 0 из 10 по версии нашего журнала"},
                };
            }
        }
    }
}
