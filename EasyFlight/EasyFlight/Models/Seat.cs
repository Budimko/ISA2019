using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Models
{
    public class Seat
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("Airplane")]
        public Guid AirplaneId { get; set; }
        public Guid TypeId { get; set; }
        public string ColumnNumber { get; set; }
        public string RowNumber { get; set; }
        
    }
}
