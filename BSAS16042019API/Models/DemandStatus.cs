using System.Collections.Generic;

namespace Models
{
    public class DemandStatus
    {
        public int Id { get; set; }

        public string StatusName { get; set; }

        public List<Demand> Demands { get; set; }
    }
}