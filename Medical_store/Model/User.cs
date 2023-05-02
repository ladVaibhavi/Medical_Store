namespace Medical_store.Model
{
    public class User
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string password { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public DateTime DOB { get; set; }
       
        public string Address { get; set; }

        public int Funds { get; set; }

        public String Type { get; set; }

        public String Status { get; set; }

    }
}
