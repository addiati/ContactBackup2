using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ContactBackup.Models;

namespace ContactBackup.DAL
{
    public class ContactBackupContext: DbContext
    {
        public ContactBackupContext() : base("ContactBackupContext")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<PhoneInfo> Phones { get; set; }
        public DbSet<EmailInfo> Emails { get; set; }
        public DbSet<AddressInfo> Addresses { get; set; }
        public DbSet<SocialNetworkInfo> SocialNetworks { get; set; }
    }
}