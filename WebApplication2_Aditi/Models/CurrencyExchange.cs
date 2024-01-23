using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2_Aditi.Models
{
    public class CurrencyExchange
    {
        public float exchangeRate { get; set; }
        public string currencyCode { get; set; }
        public DateTime validFrom { get; set; }
        public DateTime validTo { get; set; }

    }
}