using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Car.Any()) 
            {
                content.AddRange(
                    new Car
                    {
                        name = "Audi A6",
                        shortDesc = "Представитель среднего класса от Audi",
                        longDesc = "asdfghujikolp;",
                        img = "/img/AudiA6.jpg",
                        price = 55000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Авто с ДВС"]
                    },
                    new Car
                    {
                        name = "Audi A8",
                        shortDesc = "Представитель премиального класса от Audi",
                        longDesc = "cvbnm,./",
                        img = "/img/AudiA8.jpg",
                        price = 150000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Авто с ДВС"]
                    },
                    new Car
                    {
                        name = "BMW 5 series",
                        shortDesc = "Представитель среднего класса от BMW",
                        longDesc = "scdfbgnh,",
                        img = "/img/BMW5.jpg",
                        price = 45000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Авто с ДВС"]
                    },
                    new Car
                    {
                        name = "BMW 7 series",
                        shortDesc = "Представитель премиального класса от BMW",
                        longDesc = "sdfghmj,",
                        img = "/img/BMW7.jpg",
                        price = 86000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Авто с ДВС"]
                    },
                    new Car
                    {
                        name = "Land Rover Range Rover",
                        shortDesc = "Премиальный внедорожник от Land Rover",
                        longDesc = "dsfdghjhk",
                        img = "/img/Range.jpg",
                        price = 55000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Авто с ДВС"]
                    },
                    new Car
                    {
                        name = "Jeep Grand Cherokee",
                        shortDesc = "Самый быстрый внедорожник в мире",
                        longDesc = "adsfghj",
                        img = "/img/GrandCherokee.jpg",
                        price = 87000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Авто с ДВС"]
                    },
                    new Car
                    {
                        name = "Mercedes Benz E klasse",
                        shortDesc = "Представитель среднего класса от Mercedess",
                        longDesc = "sadfghjkl;",
                        img = "/img/Eklasse.jpg",
                        price = 54000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Авто с ДВС"]
                    },
                    new Car
                    {
                        name = "Mercedes Benz S klasse",
                        shortDesc = "Представитель премиального класса от Mercedess",
                        longDesc = "asdfghjkl.,",
                        img = "/img/Sklasse.jpg",
                        price = 138000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Авто с ДВС"]
                    },
                    new Car
                    {
                        name = "Volkswagen Passat",
                        shortDesc = "Представитель среднего класса от Volkswagen",
                        longDesc = "asdfgrhtjykulk;",
                        img = "/img/Passat.jpg",
                        price = 20000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Авто с ДВС"]
                    },
                    new Car
                    {
                        name = "Volkswagen Touareg",
                        shortDesc = "Премиальный внедорожник от Volkswagen",
                        longDesc = "cvbnm,./",
                        img = "/img/Touareg.jpg",
                        price = 75000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Авто с ДВС"]
                    },
                    new Car
                    {
                        name = "Toyota Camry",
                        shortDesc = "Быстрый, комфортный и надежный седан от Toyota",
                        longDesc = "asdfgrhtjykulk",
                        img = "/img/Camry.jpg",
                        price = 35000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Авто с ДВС"]
                    },
                    new Car
                    {
                        name = "Jaguar XF",
                        shortDesc = "Холодный, элегантный английский стиль в купе с надежностью и скоростью",
                        longDesc = "asdfgrhtjykulk",
                        img = "/img/JaguarXF.jpg",
                        price = 71000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Авто с ДВС"]
                    },
                    new Car
                    {
                        name = "Hummer H3",
                        shortDesc = "Строгий, мощный внедорожник от Hummer",
                        longDesc = "asdfgrhtjykulk",
                        img = "/img/H3.jpg",
                        price = 33000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Авто с ДВС"]
                    },
                    new Car
                    {
                        name = "Ford Mustang",
                        shortDesc = "Малолитражный спорткар от Ford",
                        longDesc = "asdfgrhtjykulk",
                        img = "/img/Mustang.jpg",
                        price = 35000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Авто с ДВС"]
                    },
                    new Car
                    {
                        name = "Tesla Model 3",
                        shortDesc = "Быстрый, бесшумный, дорогой электромобиль с тряпочкой из Соляриса в салоне",
                        longDesc = "asdfgrhtjykulk",
                        img = "/img/Tesla.jpg",
                        price = 47190,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "Bentley Continental",
                        shortDesc = "Прекрасная, властная, неповторимая Bentley",
                        longDesc = "asdfgrhtjykulk",
                        img = "/img/Bentley.jpg",
                        price = 202500,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Авто с ДВС"]
                    }
                    );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category{categoryName = "Авто с ДВС", desc = "Просто ахуенная вещь, эта залупа на миллиард+ лошадей (потенциально) разъебет эти повербанки на колесах с закрытыми глазами, 100 из 10 по персии нашего журнала"},
                        new Category{categoryName = "Электромобили", desc = "Беззвучная шустрая фигня. Раньше была выгодной, но теперь за зарядку авто надо платить, 0 из 10 по версии нашего журнала"},
                    };

                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }

                }
                return category;
            }
        }

    }
}
