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
    public class RatingHandler
    {
        private readonly UnitofWork _uow;

        public RatingHandler()
        {
            _uow = new UnitofWork(new DataContext());
        }

        public bool Post(RatingContract ratingContract)
        {
            return _uow.RatingRepository.CreateOrUpdate(ratingContract.ToEntity());
        }
    }
}
