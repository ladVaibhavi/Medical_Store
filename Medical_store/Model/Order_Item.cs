namespace Medical_store.Model
{
    public class Order_Item
    {
        public int Id { get; set; }
        public int OrderID { get; set; }
        public string MedicineID { get; set; }
        public int UnitPrice { get; set; }
        public int Discount { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
    }
}
