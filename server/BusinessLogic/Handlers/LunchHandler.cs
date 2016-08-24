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
    public class LunchHandler
    {
        private readonly UnitofWork _uow;

        public LunchHandler()
        {
            _uow = new UnitofWork(new DataContext());
        }

        public List<LunchContract> GetAll()
        {
            return _uow.LunchRepository.GetAll().ToContracts();
        }

        public LunchContract Get(int id)
        {
            return _uow.LunchRepository.Get(id).ToContract();
        }

        public bool InsertEmployee(int employeeId, int lunchId)
        {
            var lunch = _uow.LunchRepository.Get(lunchId);
            var employee = _uow.EmployeeRepository.Get(employeeId);
            lunch?.Employees.Add(employee);

            return _uow.LunchRepository.SaveChanges();
        }
        public bool Post(LunchContract lunchContract)
        {
            return _uow.LunchRepository.CreateOrUpdate(lunchContract.ToEntity());
        }

        public bool Delete(int id)
        {
            return _uow.LunchRepository.Delete(id);
        }
    }
}
