using Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Holding
    {
        public int Id { get; set; }

        public string NSN { get; set; }

        public string HoldingName { get; set; }

        public HoldingCategory Category { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        public int QuantityInStock { get; set; }

        public HoldingCondition Condition { get; set; }

        public string PartNumber { get; set; }
    }
}
