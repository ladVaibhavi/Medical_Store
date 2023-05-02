namespace Medical_store.Model
{
    public class Medicine
    {
        public int Id { get; set; }
        public string medicine { get; set; }

        public string ManufacturerName { get; set; }
        public DateTime Exp_date { get; set; }
        public int Unitprice { get; set; }

        public int Quantity { get; set; }

        public int Discount { get; set; }

        public string Disease { get; set; }

        public string Uses { get; set; }
        public string ImageUrl { get; set; }
        public string Status { get; set; }
    }
}
