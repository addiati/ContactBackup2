using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContactBackup.Models
{
    public class Contact
    {
        [Key]
        public String ID { get; set; }
        [Required]
        [Key]
        [ForeignKey("User")]
        public String UserID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String PicturePath { get; set; }
        public List<String> Groups { get; set; }
        public virtual List<PhoneInfo> Phones { get; set; }
        public virtual List<EmailInfo> Emails { get; set; }
        public virtual List<AddressInfo> Addresses { get; set; }
        public virtual List<SocialNetworkInfo> SocialNetworks { get; set; }
        
        public virtual User User { get; set; }
    }
}