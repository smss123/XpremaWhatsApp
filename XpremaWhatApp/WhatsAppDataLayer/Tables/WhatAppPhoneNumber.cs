using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppDataLayer.Tables
{
    public class WhatAppPhoneNumber
    {
        public int  ID { get; set; }
        public string  PhoneNumber { get; set; }
        public string  Country { get; set; }

        public Groups Group { get; set; }
    }
}
