using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car 
                    {
                        name = "Audi A6",
                        shortDesc = "Представитель среднего класса от Audi",
                        longDesc = "",
                        img = "/img/AudiA6.jpg",
                        price = 55000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Audi A8",
                        shortDesc = "Представитель премиального класса от Audi",
                        longDesc = "",
                        img = "/img/AudiA8.jpg",
                        price = 150000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "BMW 5 series",
                        shortDesc = "Представитель среднего класса от BMW",
                        longDesc = "",
                        img = "/img/BMW5.jpg",
                        price = 45000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "BMW 7 series",
                        shortDesc = "Представитель премиального класса от BMW",
                        longDesc = "",
                        img = "/img/BMW7.jpg",
                        price = 86000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Land Rover Range Rover",
                        shortDesc = "Премиальный внедорожник от Land Rover",
                        longDesc = "",
                        img = "/img/Range.jpg",
                        price = 55000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Jeep Grand Cherokee",
                        shortDesc = "Самый быстрый внедорожник в мире",
                        longDesc = "",
                        img = "/img/GrandCherokee.jpg",
                        price = 87000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Mercedes Benz E klasse",
                        shortDesc = "Представитель среднего класса от Mercedess",
                        longDesc = "",
                        img = "/img/Eklasse.jpg",
                        price = 54000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Mercedes Benz S klasse",
                        shortDesc = "Представитель премиального класса от Mercedess",
                        longDesc = "",
                        img = "/img/Sklasse.jpg",
                        price = 138000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Volkswagen Passat",
                        shortDesc = "Представитель среднего класса от Volkswagen",
                        longDesc = "",
                        img = "/img/Passat.jpg",
                        price = 20000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Volkswagen Touareg",
                        shortDesc = "Премиальный внедорожник от Volkswagen",
                        longDesc = "",
                        img = "/img/Touareg.jpg",
                        price = 75000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Toyota Camry",
                        shortDesc = "Быстрый, комфортный и надежный седан от Toyota",
                        longDesc = "",
                        img = "/img/Camry.jpg",
                        price = 35000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Jaguar XF",
                        shortDesc = "Холодный, элегантный английский стиль в купе с надежностью и скоростью",
                        longDesc = "",
                        img = "/img/JaguarXF.jpg",
                        price = 71000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Hummer H3",
                        shortDesc = "Строгий, мощный внедорожник от Hummer",
                        longDesc = "",
                        img = "/img/H3.jpg",
                        price = 33000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Ford Mustang",
                        shortDesc = "Малолитражный спорткар от Ford",
                        longDesc = "",
                        img = "/img/Mustang.jpg",
                        price = 35000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Tesla Model 3",
                        shortDesc = "Быстрый, бесшумный, дорогой электромобиль с тряпочкой из Соляриса в салоне",
                        longDesc = "",
                        img = "/img/Tesla.jpg",
                        price = 47190,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Bentley Continental",
                        shortDesc = "Прекрасная, властная, неповторимая Bentley",
                        longDesc = "",
                        img = "/img/Bentley.jpg",
                        price = 202500,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
