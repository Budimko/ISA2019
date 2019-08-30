using System;
using System.ComponentModel.DataAnnotations;

namespace EasyFlight.Models
{
    public class Airline
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public double? Rating { get; set; }
        
    }
}
