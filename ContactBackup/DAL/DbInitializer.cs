using ContactBackup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactBackup.DAL
{
    public class DbInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<ContactBackupContext>
    {
        protected override void Seed(ContactBackupContext context)
        {
            var users = new List<User>
            {
                new User { ID = "abcd-efgh-1234-5678", CreatedDate = DateTime.Now, EmailID = "backcross50@gmail.com", FirstName = "Ajay", IsActivated = true, IsFacebookUser = true, Language = "EN", LastChanged = DateTime.Now, LastLoginTime= DateTime.Now, LastName = "Shrestha", LoginAttempted = 0, Password = "", PhoneNumber = "6414510751", PicturePath= "", SecurityToken= ""},
                new User { ID = "abcd-efgh-9876-5432", CreatedDate = DateTime.Now, EmailID = "dini.addiati@gmail.com", FirstName = "Duffer", IsActivated = true, IsFacebookUser = false, Language = "EN", LastChanged = DateTime.Now, LastLoginTime= DateTime.Now, LastName = "Shrestha", LoginAttempted = 0, Password = "", PhoneNumber = "6414510751", PicturePath= "", SecurityToken= ""}
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var contacts = new List<Contact>
            {
                new Contact { ID = "1234-5678-0987-4576", UserID = "abcd-efgh-1234-5678", FirstName = "Duffer", LastName = "Duffer", PicturePath = ""},
                new Contact { ID = "1235-5678-0987-4576", UserID = "abcd-efgh-1234-5678", FirstName = "Honey", LastName = "Bunny", PicturePath = ""},
                new Contact { ID = "1236-5678-0987-4576", UserID = "abcd-efgh-1234-5678", FirstName = "Love", LastName = "Duffer", PicturePath = ""}
            };

            contacts.ForEach(s => context.Contact.Add(s));
            context.SaveChanges();

            var phones = new List<PhoneInfo>()
            {
                new PhoneInfo { ID = "1234-0987-5614-7236", ContactID = "1234-5678-0987-4576", Order = 1, Type = "Personal", UserID = "abcd-efgh-1234-5678", Value = "6419998888"},
                new PhoneInfo { ID = "1278-0987-5614-7236", ContactID = "1234-5678-0987-4576", Order = 1, Type = "Work", UserID = "abcd-efgh-1234-5678", Value = "6411234672"},
                new PhoneInfo { ID = "1234-0987-5614-7236", ContactID = "1235-5678-0987-4576", Order = 1, Type = "Home", UserID = "abcd-efgh-1234-5678", Value = "264523764523"}
            };

            phones.ForEach(s => context.Phones.Add(s));
            context.SaveChanges();

            var emails = new List<EmailInfo>()
            {
                new EmailInfo { ID = "1234-0987-5614-7236", ContactID = "1234-5678-0987-4576", Order = 1, Type = "Personal", UserID = "abcd-efgh-1234-5678", Value = "duffer@gmail.com"},
                new EmailInfo { ID = "1278-0987-5614-7236", ContactID = "1234-5678-0987-4576", Order = 1, Type = "Work", UserID = "abcd-efgh-1234-5678", Value = "honey@gmail.com"},
                new EmailInfo { ID = "1234-0987-5614-7236", ContactID = "1235-5678-0987-4576", Order = 1, Type = "Home", UserID = "abcd-efgh-1234-5678", Value = "hajur@gmail.com"}
            };

            emails.ForEach(s => context.Emails.Add(s));
            context.SaveChanges();

            var addresses = new List<AddressInfo>()
            {
                new AddressInfo { ID = "1234-0987-5614-7236", ContactID = "1234-5678-0987-4576", Order = 1, Type = "Personal", UserID = "abcd-efgh-1234-5678", Value = "1000 N 4TH STREET FAIRFIELD IOWA 52557"},
                new AddressInfo { ID = "1278-0987-5614-7236", ContactID = "1234-5678-0987-4576", Order = 1, Type = "Work", UserID = "abcd-efgh-1234-5678", Value = "1100 N 4TH STREET FAIRFIELD IOWA 52557"},
                new AddressInfo { ID = "1234-0987-5614-7236", ContactID = "1235-5678-0987-4576", Order = 1, Type = "Home", UserID = "abcd-efgh-1234-5678", Value = "1200 N 4TH STREET FAIRFIELD IOWA 52557"}
            };

            addresses.ForEach(s => context.Addresses.Add(s));
            context.SaveChanges();

            var socialNetworks = new List<SocialNetworkInfo>()
            {
                new SocialNetworkInfo { ID = "1234-0987-5614-7236", ContactID = "1234-5678-0987-4576", Order = 1, Type = "Facebook", UserID = "abcd-efgh-1234-5678", Value = "duffer.duffer"},
                new SocialNetworkInfo { ID = "1278-0987-5614-7236", ContactID = "1234-5678-0987-4576", Order = 1, Type = "Twitter", UserID = "abcd-efgh-1234-5678", Value = "honey.duffer"},
                new SocialNetworkInfo { ID = "1234-0987-5614-7236", ContactID = "1235-5678-0987-4576", Order = 1, Type = "Facebook", UserID = "abcd-efgh-1234-5678", Value = "hajur.duffer"}
            };

            socialNetworks.ForEach(s => context.SocialNetworks.Add(s));
            context.SaveChanges();
        }
    }
}