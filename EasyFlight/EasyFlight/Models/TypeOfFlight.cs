﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Models
{
    public class TypeOfFlight
    {
        [Key]
        public Guid Id { get; set; }

        public string Type { get; set; }
    }
}
