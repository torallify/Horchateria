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
        [Required(ErrorMessage = "First name is required.")]
        [MaxLength(20 , ErrorMessage = "Sorry your first name is too long. Maximum length is 20")]
        [MinLength(2, ErrorMessage = "First name has a minimum length of 2")]
        public string FirstName { get => firstName; set => firstName = value; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        [MaxLength(20, ErrorMessage = "Sorry your last name is too long. Maximum length is 20")]
        [MinLength(2, ErrorMessage = "Last name has a minimum length of 2")]
        public string LastName { get => lastName; set => lastName = value; }

        [DisplayName("E-mail")]
        [EmailAddress]
        [Required]
        public string Email { get => email; set => email = value; }
        
        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone Number is required.")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        [DisplayName("Password")]
        [PasswordPropertyText]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required. Minimun length is 6")]
        [MinLength(6)]
        public string Password { get => password; set => password = value; }

        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get => gender; set => gender = value; }
        
        [DisplayName("¿Hablas español?")]
        public string SpanishSpeaker { get => spanishSpeaker; set => spanishSpeaker = value; }
    }
}
