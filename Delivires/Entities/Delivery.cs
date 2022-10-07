namespace Delivires.Entities
{
    using Adresses.Enities;
    using ECommerce.Application;
    using Orders.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Delivery :BaseEntity
    {
        public string Name { get; set; }
        public Adress Adress { get; set; }
        public Order Order { get; set; }
        public Guid OrderId { get; set; }

    }
}
