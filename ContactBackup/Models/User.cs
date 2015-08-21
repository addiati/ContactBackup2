using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactBackup.Models
{
    public class User
    {
        [Key]
        public String ID { get; set; }
        public String EmailID { get; set; }
        public String Password { get; set; }
        public String PicturePath { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String PhoneNumber { get; set; }
        public bool IsFacebookUser { get; set; }
        public bool IsActivated { get; set; }
        public String Language { get; set; }
        public String CreatedDate { get; set; }
        public String LastChanged { get; set; }
        public DateTime LastLoginTime { get; set; }
        public int LoginAttempted { get; set; }
        public String SecurityToken { get; set; }

        public virtual List<Contact> Contacts { get; set; }
    }
}