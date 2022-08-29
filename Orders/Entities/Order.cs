namespace Orders.Entities
{
    using ECommerce.Application;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Order : BaseEntity
    {
        public new int Id { get; set; }

        public bool IsClosed { get; set; }

        public string Comment { get; set; }

        public decimal BasePrice { get; set; }

        public decimal FinalPrice { get; set; }

        public int? DiscountValue { get; set; }

        public DateTimeOffset CreationDateTime { get; set; }

        public DateTimeOffset? ClosedDateTime { get; set; }

    }
}
