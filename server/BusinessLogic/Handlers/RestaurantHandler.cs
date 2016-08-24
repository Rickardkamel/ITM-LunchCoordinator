using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using DataService;
using DataService.Unit_of_Work;
using Mappers;

namespace BusinessLogic.Handlers
{
    public class RestaurantHandler
    {
        private readonly UnitofWork _uow;

        public RestaurantHandler()
        {
            _uow = new UnitofWork(new DataContext());
        }

        public List<RestaurantContract> GetAll()
        {
            return _uow.RestaurantRepository.GetAll().ToContracts();
        }

        public RestaurantContract Get(int id)
        {
            return _uow.RestaurantRepository.Get(id).ToContract();
        }

        public bool Post(RestaurantContract restaurantContract)
        {
            return _uow.RestaurantRepository.CreateOrUpdate(restaurantContract.ToEntity());
        }

        public bool Delete(int id)
        {
            return _uow.RestaurantRepository.Delete(id);
        }
    }
}
