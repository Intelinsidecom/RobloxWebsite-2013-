using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Roblox.Website.ViewModels.Admi.UserAdmin
{
    public class BillingInfoViewModel
    {
        /// <summary>
        /// The billing name associated with the user
        /// </summary>
        public string BillingName { get; set; }

        /// <summary>
        /// The postal code associated with the user
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// The billing email address associated with the user
        /// </summary>
        public string BillingEmail { get; set; }

        /// <summary>
        /// The credit card info associated with the user
        /// </summary>
        public string CreditCardInfo { get; set; }
    }
}