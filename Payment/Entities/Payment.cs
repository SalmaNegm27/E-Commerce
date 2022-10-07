﻿namespace Payments.Entities
{
    using ECommerce.Application;
    using Orders.Entities;
    using System;

    public class Payment : BaseEntity
    {
        public string Name { get;  set; }

        public string NameSecondLanguges { get;  set; }
         public int CardNumber { get; set; }
        public string Amount { get; set; }
        public Order Order { get; set; }
        public Guid OrderId { get; set; }
    }
}
