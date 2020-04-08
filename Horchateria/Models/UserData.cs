using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Horchateria.Models
{
    public class UserData
    {
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private string password;
        private string gender;
        private string spanishSpeaker;

        [DisplayName("First Name")]
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string FirstName { get => firstName; set => firstName = value; }

        [DisplayName("Last Name")]
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string LastName { get => lastName; set => lastName = value; }

        [DisplayName("E-mail")]
        [EmailAddress]
        [Required]
        public string Email { get => email; set => email = value; }
        
        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Required]
        [MinLength(10)]
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        [DisplayName("Password")]
        [PasswordPropertyText]
        [DataType(DataType.Password)]
        [Required]
        [MinLength(6)]
        public string Password { get => password; set => password = value; }

        [DisplayName("Gender")]
        [Required]
        public string Gender { get => gender; set => gender = value; }
        
        [DisplayName("¿Hablas español?")]
        public string SpanishSpeaker { get => spanishSpeaker; set => spanishSpeaker = value; }
    }
}
