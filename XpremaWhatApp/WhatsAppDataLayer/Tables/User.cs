using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppDataLayer.Tables
{
    public class User
    {
        public int ID { get; set; }
        public string  FullName { get; set; }
        public string  PhoneNumber { get; set; }
        public string  UserName { get; set; }
        public string  Password { get; set; }
        public bool  IsAdmin { get; set; }
        public bool  IsSend { get; set; }
        public bool  IsWhatsAppIDSender { get; set; }
        public bool  IsNumberManage { get; set; }
        public virtual List<History> UserHistory { get; set; }
    }
}
