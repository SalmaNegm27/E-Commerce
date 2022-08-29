namespace Adresses
{
    using ECommerce.Application;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Adress :BaseEntity
    {
        public string Street { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string PostCode { get; set; }

        public int PhoneNumber { get; set; }
    }
}
