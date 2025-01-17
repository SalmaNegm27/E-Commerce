﻿namespace Orders.ViewModels
{
    
    public class OrderViewModel : BaseViewModel
    {
        public string UserId { get; set; }
        public bool IsClosed { get; set; }

        public string Comment { get; set; }

        public decimal BasePrice { get; set; }

        public decimal FinalPrice { get; set; }

        public int DiscountValue { get; set; }

        public DateTimeOffset CreationDateTime { get; set; }

        public DateTimeOffset ClosedDateTime { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }
    }
}