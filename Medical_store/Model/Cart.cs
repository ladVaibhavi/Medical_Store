namespace Medical_store.Model
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public string MedicineID { get; set; }
        public int UnitPrice { get; set; }
        public int Discount { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
        public string ImageURL { get;set; }
        public string manufacturename { get; set; } 
    }
}
