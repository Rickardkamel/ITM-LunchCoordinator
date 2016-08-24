using System;
using System.Collections.Generic;

namespace Contracts
{
    public class LunchContract
    {
        public int Id { get; set; }
        public DateTime LunchTime { get; set; }
        public int RestaurantId { get; set; }
        public virtual List<EmployeeContract> Employees { get; set; }
        public virtual RestaurantContract Restaurant { get; set; }

    }
}
