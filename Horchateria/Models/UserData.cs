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
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get => password; set => password = value; }
    }
}
