using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Station
    {
        public int StationId { get; set; }

        public string StationName { get; set; }

        public StationRegion Region { get; set; }

        public List<User> Users { get; set; }
    }
}
