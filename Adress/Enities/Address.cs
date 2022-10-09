namespace Adresses.Enities
{
   

    public class Address : BaseEntity
    {
      
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
        public int PhoneNumber { get; set; }
    }
}
