namespace Orders.Entities
{
    using ECommerce.Application;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OrderProduct: BaseEntity
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
        public  Order Order { get; set; }
        public Guid ProductId { get; set; }
        public Guid OrderId { get; set; }
    }
}
