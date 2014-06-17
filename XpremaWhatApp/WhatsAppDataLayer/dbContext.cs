using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsAppDataLayer.Tables;
namespace WhatsAppDataLayer
{
   public class dbContext:DbContext
    {
        public DbSet<Groups> groups { get; set; }
        public DbSet<History> histories { get; set; }
        public DbSet<User> users  { get; set; }
        public DbSet<WhatAppPhoneNumber> phoneNumbers { get; set; }
        public DbSet<WhatsAppIDSender> IDSenders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Groups>().MapToStoredProcedures();
            modelBuilder.Entity<History>().MapToStoredProcedures();
            modelBuilder.Entity<User>().MapToStoredProcedures();
            modelBuilder.Entity<WhatAppPhoneNumber>().MapToStoredProcedures();
            modelBuilder.Entity<WhatsAppIDSender>().MapToStoredProcedures();

            
            base.OnModelCreating(modelBuilder);
        }

    }
}
