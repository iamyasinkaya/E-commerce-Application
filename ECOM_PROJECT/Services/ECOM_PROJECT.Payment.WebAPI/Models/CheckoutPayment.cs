﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECOM_PROJECT.Payment.WebAPI.Models
{
    public class CheckoutPayment
    {
        
        public string Province { get; set; }

      
        public string District { get; set; }

       
        public string Street { get; set; }

       
        public string ZipCode { get; set; }

        
        public string Line { get; set; }

       
        public string CardName { get; set; }

        
        public string CardNumber { get; set; }

       
        public string Expiration { get; set; }

        public string CVV { get; set; }
    }
}
