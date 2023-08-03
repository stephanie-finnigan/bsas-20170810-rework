using System.Collections.Generic;

namespace Models
{
    public class StationRegion
    {
        public int Id { get; set; }

        public string RegionName { get; set; }

        public List<Station> Stations { get; set; }
    }
}