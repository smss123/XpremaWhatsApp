using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppDataLayer.Tables
{
     public class Groups
    {
        public int ID { get; set; }
        public string  GroupName { get; set; }
        public string  Description { get; set; }
        public virtual List<WhatAppPhoneNumber> PhoneNumbers { get; set; }
     
     }
}
