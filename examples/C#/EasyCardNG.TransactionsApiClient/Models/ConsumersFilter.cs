﻿using Shared.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MerchantProfileApi.Models.Billing
{
    public class ConsumersFilter : FilterBase
    {
        public string Search { get; set; }

        public Guid? ConsumerID { get; set; }

        public string ConsumersID { get; set; }

        public string NationalID { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string ExternalReference { get; set; }

        public string BillingDesktopRefNumber { get; set; }

        public string Origin { get; set; }
    }
}
