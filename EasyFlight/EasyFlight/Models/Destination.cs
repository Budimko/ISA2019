using System;
using System.ComponentModel.DataAnnotations;

namespace EasyFlight.Models
{
    public class Destination
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
