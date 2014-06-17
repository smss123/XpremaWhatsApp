using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppDataLayer.Tables
{
    public class SendQuee
    {
        public int ID { get; set; }
        public WhatAppPhoneNumber PhoneNumber { get; set; }
        public DateTime  DateOfSend { get; set; }
        public string  Message { get; set; }
        public bool  IsSend { get; set; }
    }
}
