using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using EasyFlight.ViewModel;

namespace EasyFlight.Models
{
    public class Friend
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("User")]
        public Guid UserSendId { get; set; }
        public Guid UserReceivedId { get; set; }
        public bool Accepted { get; set; }



    }
}
