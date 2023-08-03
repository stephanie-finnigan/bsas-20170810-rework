using System;
using System.Collections.Generic;
using System.Text;

namespace Models.ViewModels
{
    public class DemandItemViewModel
    {
        public Demand Demand { get; set; }

        public DemandItem Item { get; set; }

        public int ItemQuantityId { get; set; }

        public List<Holding> Holdings { get; set; }
    }
}
