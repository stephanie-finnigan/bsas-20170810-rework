using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class HoldingQuantity
    {
        public int QuantityId { get; set; }
        public int QuantityInStock { get; set; }

        public int HoldingId { get; set; }
        public Holding Holding { get; set; }

        public int DemandId { get; set; }
        public Demand Demand { get; set; }

        //public int DemandItemId { get; set; }
        //public virtual DemandItem DemandItem { get; set; }

        //public int SupplierId { get; set; }
    }
}
