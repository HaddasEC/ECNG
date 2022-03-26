﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebStore.Models
{
    public class BasketViewModel
    {
        public string ProductName { get; set; }

        public decimal? Price { get; set; }

        public decimal? Quantity { get; set; }

        /// <summary>
        /// Consumer name
        /// </summary>
        public string Name { get; set; }

        public string NationalID { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string InternalOrderID { get; set; }

        public Guid? ConsumerID { get; set; }

        public bool IssueInvoice { get; set; }

        public bool AllowPinPad { get; set; }

        public bool UserAmount { get; set; }

        public bool Refund { get; set; }
    }
}
