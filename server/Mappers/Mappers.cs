using System.Collections.Generic;
using System.Linq;
using Contracts;
using Models;

namespace Mappers
{
    public static class Mappers
    {
        #region Contracts

        #region ToContract

        public static EmployeeContract ToContract(this Employee employee)
        {
            return new EmployeeContract
            {
                Id = employee.Id,
                Name = employee.Name,
                City = employee.City
            };
        }

        public static RestaurantContract ToContract(this Restaurant restaurant)
        {
            return new RestaurantContract
            {
                Id = restaurant.Id,
                Name = restaurant.Name,
                ImageUrl = restaurant.ImageUrl,
                Rating = restaurant.Ratings.DefaultIfEmpty().Average(x => x?.StarRating ?? 0)
        };
        }

        public static LunchContract ToContract(this Lunch lunch)
        {
            return new LunchContract
            {
                Id = lunch.Id,
                LunchTime = lunch.LunchTime,
                RestaurantId = lunch.RestaurantId,
                Employees = lunch.Employees?.ToContracts(),
                Restaurant = lunch.Restaurant?.ToContract()

            };
        }

        public static RatingContract ToContract(this Rating rating)
        {
            return new RatingContract
            {
                Id = rating.Id,
                StarRating = rating.StarRating,
                RestaurantId = rating.RestaurantId
            };
        }
        #endregion

        #region ToContracts

        public static List<EmployeeContract> ToContracts(this List<Employee> employees)
        {
            return employees.ConvertAll(x => new EmployeeContract
            {
                Id = x.Id,
                Name = x.Name,
                City = x.City
            });
        }

        public static List<RestaurantContract> ToContracts(this List<Restaurant> restaurants)
        {
            return restaurants.ConvertAll(x => new RestaurantContract
            {
                Id = x.Id,
                Name = x.Name,
                ImageUrl = x.ImageUrl,
                Rating = x.Ratings.ToContracts().Average(r => r.StarRating)
            });
        }

        public static List<LunchContract> ToContracts(this List<Lunch> lunches)
        {
            return lunches.ConvertAll(x => new LunchContract
            {
                Id = x.Id,
                LunchTime = x.LunchTime,
                RestaurantId = x.RestaurantId,
                Employees = x.Employees?.ToContracts(),
                Restaurant = x.Restaurant?.ToContract()
            });
        }

        public static List<RatingContract> ToContracts(this List<Rating> ratings)
        {
            return ratings.ConvertAll(x => new RatingContract
            {
                Id = x.Id,
                StarRating = x.StarRating,
                RestaurantId = x.RestaurantId
            });
        }

        #endregion

        #endregion

        #region Models

        #region ToEntity

        public static Employee ToEntity(this EmployeeContract employee)
        {
            return new Employee
            {
                Id = employee.Id,
                Name = employee.Name,
                City = employee.City
            };
        }

        public static Restaurant ToEntity(this RestaurantContract restaurant)
        {
            return new Restaurant
            {
                Id = restaurant.Id,
                Name = restaurant.Name,
                ImageUrl = restaurant.ImageUrl
            };
        }

        public static Lunch ToEntity(this LunchContract lunch)
        {
            return new Lunch
            {
                Id = lunch.Id,
                LunchTime = lunch.LunchTime,
                RestaurantId = lunch.RestaurantId,
                Employees = lunch.Employees?.ToEntities(),
                Restaurant = lunch.Restaurant?.ToEntity(),

            };
        }

        public static Rating ToEntity(this RatingContract rating)
        {
            return new Rating
            {
                Id = rating.Id,
                RestaurantId = rating.RestaurantId,
                StarRating = rating.StarRating
            };
        }

        #endregion

        #region ToEntities

        public static List<Employee> ToEntities(this List<EmployeeContract> employees)
        {
            return employees.ConvertAll(x => new Employee
            {
                Id = x.Id,
                Name = x.Name,
                City = x.City
            });
        }

        public static List<Restaurant> ToEntities(this List<RestaurantContract> restaurants)
        {
            return restaurants.ConvertAll(x => new Restaurant
            {
                Id = x.Id,
                Name = x.Name,
                ImageUrl = x.ImageUrl
            });
        }

        public static List<Lunch> ToEntities(this List<LunchContract> lunches)
        {
            return lunches.ConvertAll(x => new Lunch
            {
                Id = x.Id,
                LunchTime = x.LunchTime,
                RestaurantId = x.RestaurantId,
                Employees = x.Employees?.ToEntities(),
                Restaurant = x.Restaurant?.ToEntity()
            });
        }

        public static List<Rating> ToEntities(this List<RatingContract> ratings)
        {
            return ratings.ConvertAll(x => new Rating
            {
                Id = x.Id,
                StarRating = x.StarRating,
                RestaurantId = x.RestaurantId
            });
        }

        #endregion

        #endregion
    }
}
