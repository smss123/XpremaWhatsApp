using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppDataLayer.Tables
{
    public class History
    {
        public int ID { get; set; }
        public string  ActionName { get; set; }
        public DateTime  ActionTime { get; set; }
        public string  Description { get; set; }
        public User  user { get; set; }
    }
}
