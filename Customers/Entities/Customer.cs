namespace Customers.Entities
{
    using ECommerce.Application;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Customer : BaseEntity
    {
        public string CustomerName { get; set; }
        public string Adderss { get; set; }
        public int ContactAddress { get; set; }
    }
}
