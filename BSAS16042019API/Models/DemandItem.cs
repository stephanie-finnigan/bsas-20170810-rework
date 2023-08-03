namespace Models
{
    public class DemandItem
    {
        public int DemandItemId { get; set; }

        public Demand Demand { get; set; }

        public Holding Holding { get; set; }

        public int ItemQuantity { get; set; }

        public DemandItem() { }

        public DemandItem(Holding holding, Demand demand, int itemQuantity)
        {
            Holding = holding;
            Demand = demand;
            ItemQuantity = itemQuantity;
        }
    }
}