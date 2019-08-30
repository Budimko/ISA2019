using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.ViewModel
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Obavezno je navesti ime prilikom registracije")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Obavezno je navesti ime prilikom registracije")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Obavezno je navesti ime prilikom registracije")]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Obavezno je navesti ime prilikom registracije")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Obavezno je navesti ime prilikom registracije")]
        public string PhoneNumber { get; set; }
    }
}
