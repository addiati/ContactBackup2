using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContactBackup.Models
{
    public class PhoneInfo
    {
        [Key]
        public String ID { get; set; }
        [Required]
        [Key]
        [ForeignKey("User")]
        public String UserID { get; set; }
        [Required]
        [Key]
        [ForeignKey("Contact")]
        public String ContactID { get; set; }
        public String Value { get; set; }
        public DateTime LastChanged { get; set; }
        public String Type { get; set; }
        public int Order { get; set; }

        public virtual User User { get; set; }
        public virtual Contact Contact { get; set; }
    }
}