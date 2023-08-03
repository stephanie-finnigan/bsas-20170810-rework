using System.Collections.Generic;

namespace Models
{
    public class HoldingCategory
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public List<Holding> Holdings { get; set; }
    }
}