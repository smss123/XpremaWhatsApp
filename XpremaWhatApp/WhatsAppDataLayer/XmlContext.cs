using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using WhatsAppDataLayer.Tables;
namespace WhatsAppDataLayer
{
    public class XmlContext
    {
        public List<Groups> Group { get; set; }
        public List<WhatsAppIDSender> IDSender { get; set; }
     public   XmlContext()
        {
            this.Group = new List<Groups>();
            this.IDSender = new List<WhatsAppIDSender>();
            try
            {
                //Xprema_XML xpre = new Xprema_XML();
                //var q = xpre.Load("context.xml", this) ;
                ////this.Group = q.Group;
                ////this.IDSender = q.IDSender;
            }
            catch (Exception ex)
            {
                
               
            }

        }

        public void submitChange()
        {

            this.Group.Add(new Groups() { ID = 1, GroupName = "samer1", Description = "Descriiption1" });
            this.Group.Add(new Groups() { ID = 2, GroupName = "samer2", Description = "Descriiption2" });
            this.Group.Add(new Groups() { ID = 3, GroupName = "samer3", Description = "Descriiption3" });
            this.Group.Add(new Groups() { ID = 4, GroupName = "samer4", Description = "Descriiption4" });
            this.IDSender.Add(new WhatsAppIDSender(){ ID=1, IDSenderPhone="num1", IsActive=true, PassKey="Pas1" });
            this.IDSender.Add(new WhatsAppIDSender(){ ID=2, IDSenderPhone="num2", IsActive=true, PassKey="Pas2" });
            this.IDSender.Add(new WhatsAppIDSender() { ID = 3, IDSenderPhone = "num3", IsActive = true, PassKey = "Pas3" });
          
          
            //Xprema_XML xpre = new Xprema_XML();
            //xpre.Save("context.xml", this);
           
        }
    }
}
