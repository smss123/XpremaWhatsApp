using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppDataLayer.Tables
{
    public class WhatsAppIDSender
    {
        public int ID { get; set; }
        public string  IDSenderPhone { get; set; }
        public string  PassKey { get; set; }
        public bool  IsActive { get; set; }

    }
}
