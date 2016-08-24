using System.Collections.Generic;
using Contracts;
using DataService;
using DataService.Unit_of_Work;
using Mappers;

namespace BusinessLogic.Handlers
{
    public class EmployeeHandler
    {
        private readonly UnitofWork _uow;

        public EmployeeHandler()
        {
            _uow = new UnitofWork(new DataContext());
        }

        public List<EmployeeContract> GetAll()
        {
            return _uow.EmployeeRepository.GetAll().ToContracts();
        }

        public EmployeeContract Get(int id)
        {
            return _uow.EmployeeRepository.Get(id).ToContract();
        }

        public bool Post(EmployeeContract employeeContract)
        {
            return _uow.EmployeeRepository.CreateOrUpdate(employeeContract.ToEntity());
        }

        public bool Delete(int id)
        {
            return _uow.EmployeeRepository.Delete(id);
        }
    }
}
