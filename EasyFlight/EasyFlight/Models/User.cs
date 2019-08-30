using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Models
{
    public class User
    {
        
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Role")]
        public Guid RoleId { get; set; }

        public string Name { get;  set; } 
        public string Surname { get;  set; }
        public string Email { get;  set; }
        public string Password { get;  set; }
        public string Address { get;  set; }
        public string PhoneNumber { get;  set; }

       
    }
}
