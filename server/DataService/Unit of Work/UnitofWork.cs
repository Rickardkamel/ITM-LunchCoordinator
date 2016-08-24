using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataService.Repository;
using Models;

namespace DataService.Unit_of_Work
{
    public class UnitofWork
    {
        private readonly object _db;

        private GenericRepository<Employee> _employeeRepository;
        private GenericRepository<Restaurant> _restaurantRepository;
        private GenericRepository<Lunch> _lunchRepository;
        private GenericRepository<Rating> _ratingRepository;
        public UnitofWork(object db)
        {
            _db = db;
        }

        public GenericRepository<Employee> EmployeeRepository
            => _employeeRepository ?? (_employeeRepository = new GenericRepository<Employee>(_db));

        public GenericRepository<Restaurant> RestaurantRepository
            => _restaurantRepository ?? (_restaurantRepository = new GenericRepository<Restaurant>(_db));

        public GenericRepository<Lunch> LunchRepository
            => _lunchRepository ?? (_lunchRepository = new GenericRepository<Lunch>(_db));

        public GenericRepository<Rating> RatingRepository
            => _ratingRepository ?? (_ratingRepository = new GenericRepository<Rating>(_db));
    }
}
