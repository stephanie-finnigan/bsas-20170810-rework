using System;
using System.Collections.Generic;
using System.Text;

namespace Models.ViewModels
{
    public class DemandDataViewModel
    {
        public List<Demand> Demands { get; set; }

        public List<DemandItem> DemandItems { get; set; }
    }
}
