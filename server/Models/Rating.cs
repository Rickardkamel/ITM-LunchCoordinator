using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Rating
    {
        public int Id { get; set; }
        public int StarRating { get; set; }
        public int RestaurantId { get; set; }
        public int EmployeeId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual Employee Employee { get; set; }

    }
}
