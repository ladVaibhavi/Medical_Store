using System.ComponentModel.DataAnnotations;

namespace Medical_store.Model
{
    public class Order
    {
       
       public int Id { get; set; }
       public int UserId { get; set; }
       public int OrderNumber { get; set; }
        public int OrderTotal { get; set; }
        public int OrderStatus { get; set; }
    }
}
