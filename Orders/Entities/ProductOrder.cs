namespace Orders.Entities
{
    using ECommerce.Application;
    using Products.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ProductOrder : BaseEntity
    {
        public int Amount { get; set; }

        public decimal CurrentProductPrice { get;  set; }

        public decimal FinalPrice { get;  set; }

        public string Comment { get;  set; }

        public decimal CharmsPrice { get;  set; }

        public int? DiscountValue { get; set; }

        public string Size { get; set; }

        public string Color { get; set; }

        public string Graver { get;  set; }

      

        public virtual Order Order { get;  set; }

        public virtual Product Product { get; set; }
    }
}
