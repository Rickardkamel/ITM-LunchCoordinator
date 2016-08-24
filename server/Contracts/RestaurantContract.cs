using System;
using System.Collections.Generic;

namespace Contracts
{
    public class RestaurantContract
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public double Rating { get; set; }
    }
}
