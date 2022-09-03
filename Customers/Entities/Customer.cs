namespace Customers.Entities
{
    using Adresses.Enities;
    using ECommerce.Application;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Customer : BaseEntity
    {
        public string CustomerName { get; set; }
        public int ContactAddress { get; set; }
        public string UserId { get; set; }
        public Adress Adress { get; set; }
        public Guid AdreesId { get; set; }
    }
}
