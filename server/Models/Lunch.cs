using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Lunch
    {
        public int Id { get; set; }
        public DateTime LunchTime { get; set; }
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual List<Employee> Employees { get; set; }

    }
}
