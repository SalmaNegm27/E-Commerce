namespace Customers.Entities
{
   

    public class Customer : BaseEntity
    {
        public string CustomerName { get; set; }
        public int ContactAddress { get; set; }
        public string UserId { get; set; }
        public Address Adress { get; set; }
        public Guid AdreesId { get; set; }
    }
}
