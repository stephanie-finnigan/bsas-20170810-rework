using System;
using System.Collections.Generic;

namespace Models
{
    public class Demand
    {
        public int DemandId { get; set; }
        
        public DateTime SubmitDate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public string SpecialInstructions { get; set; }

        public string Remarks { get; set; }

        public int StatusId { get; set; }
        public DemandStatus Status { get; set; }

        public DateTime? DateDespatched { get; set; }

        public DateTime? DateDelivered { get; set; }

        public List<DemandItem> DemandItems { get; set; }
    }
}