using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataService.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataContext context)
        {
            var restaurants = new List<Restaurant>
            {
                new Restaurant {Id = 1, ImageUrl = "burgerlove.jpg", Name = "Burger Love"},
                new Restaurant {Id = 2, ImageUrl = "mcdonalds.jpg", Name = "McDonald's"},
                new Restaurant {Id = 3, ImageUrl = "burgerking.jpg", Name = "Burger King"},
                new Restaurant {Id = 4, ImageUrl = "salladinn.jpg", Name = "Sallad Inn"},
                new Restaurant {Id = 5, ImageUrl = "dannes.jpg", Name = "Dannes"},
                new Restaurant {Id = 6, ImageUrl = "greken.jpg", Name = "Grekiska Kolgrillsbaren"},
                new Restaurant {Id = 7, ImageUrl = "sweetchili.jpg", Name = "Sweet Chili"},
                new Restaurant {Id = 8, ImageUrl = "cocothai.jpg", Name = "Coco Thai"},
                new Restaurant {Id = 9, ImageUrl = "subway.jpg", Name = "Subway"},
                new Restaurant {Id = 10, ImageUrl = "texasstar.jpg", Name = "Texas Star"},
                new Restaurant {Id = 11, ImageUrl = "saluhallen.jpg", Name = "Saluhallen"},
                new Restaurant {Id = 12, ImageUrl = "rosalis.jpg", Name = "Rosalis Deli"},
                new Restaurant {Id = 13, ImageUrl = "wongs.jpg", Name = "Wongs"},
                new Restaurant {Id = 14, ImageUrl = "pitchers.jpg", Name = "Pitcher's"},
                new Restaurant {Id = 15, ImageUrl = "mikesfoodtruck.jpg", Name = "Mike´s Foodtruck"},
                new Restaurant {Id = 16, ImageUrl = "sushiyama.jpg", Name = "Sushi Yama"},
                new Restaurant {Id = 17, ImageUrl = "pampa.jpg", Name = "La Pampa"},
                new Restaurant {Id = 18, ImageUrl = "kinamuren.jpg", Name = "Kinamuren"},
                new Restaurant {Id = 19, ImageUrl = "texaslonghorn.jpg", Name = "Texas Longhorn"},
                new Restaurant {Id = 20, ImageUrl = "strikeoco.jpg", Name = "Strike & Co"},
                new Restaurant {Id = 21, ImageUrl = "norrtull.jpg", Name = "Norr Tull"},
                new Restaurant {Id = 22, ImageUrl = "wobbler.jpg", Name = "Wobbler"},
                new Restaurant {Id = 23, ImageUrl = "jensen.jpg", Name = "Jensens Bofhus"},
                new Restaurant {Id = 24, ImageUrl = "svalan.jpg", Name = "Svalan"}
            };
            var ratings = new List<Rating>
            {
                new Rating {Id = 1, RestaurantId = 1, StarRating = 5, EmployeeId = 1},
                new Rating {Id = 2, RestaurantId = 6, StarRating = 6, EmployeeId = 1},
                new Rating {Id = 3, RestaurantId = 7, StarRating = 7, EmployeeId = 1},
                new Rating {Id = 4, RestaurantId = 8, StarRating = 8, EmployeeId = 1},
                new Rating {Id = 5, RestaurantId = 9, StarRating = 9, EmployeeId = 1},
            };

            var lunches = new List<Lunch>
            {
                new Lunch { Id = 2, LunchTime = DateTime.Today.AddDays(2), RestaurantId = 1, Employees = new List<Employee>
                {
                    new Employee { City = "Örebro", Name = "Rickard Kamel"},
                    new Employee { City = "Örebro", Name = "Marcus Carlsson"},
                    new Employee { City = "Örebro", Name = "Michel Ishak"},
                    new Employee { City = "Örebro", Name = "Johan Palmqvist"},
                } },
                new Lunch { Id = 3, LunchTime = DateTime.Today.AddDays(2), RestaurantId = 2, Employees = new List<Employee>
                {
                    new Employee { City = "Örebro", Name = "Saman Gustavsson"},
                    new Employee { City = "Örebro", Name = "Johan Qvarnström"},
                    new Employee { City = "Örebro", Name = "Elie Kamel"},
                } },
                new Lunch { Id = 4, LunchTime = DateTime.Today.AddDays(2), RestaurantId = 3, Employees = new List<Employee>
                {
                    new Employee { City = "Örebro", Name = "Martin Börjeskog"},
                    new Employee { City = "Örebro", Name = "Peter Essenberg"},
                    new Employee { City = "Örebro", Name = "Göran Ekeberg"},
                } },
                new Lunch { Id = 5, LunchTime = DateTime.Today.AddDays(2), RestaurantId = 4, Employees = new List<Employee>
                {
                    new Employee { City = "Örebro", Name = "Göran Lejerwik"},
                    new Employee { City = "Örebro", Name = "Anders Persson"},
                } },
                new Lunch { Id = 6, LunchTime = DateTime.Today.AddDays(2), RestaurantId = 5, Employees = new List<Employee>
                {
                    new Employee { City = "Örebro", Name = "Robert Amartinenisei"},
                } },

            };

            lunches.ForEach(x => context.Lunches.AddOrUpdate(x));
            ratings.ForEach(x => context.Ratings.AddOrUpdate(x));
            restaurants.ForEach(x => context.Restaurants.AddOrUpdate(x));

            context.SaveChanges();
        }
    }
}
