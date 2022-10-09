namespace Delivires.Entities
{
    
    public class Delivery :BaseEntity
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public Order Order { get; set; }
        public Guid OrderId { get; set; }
        public Guid AddressId { get; set; }

    }
}
