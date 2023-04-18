using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;


namespace ServerSideValidation.Model

{

    public class  Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
    public class UsersDto
    {
        [Required]
        public string UserName { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "The password must be at least 8 characters long.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).{8,}$", ErrorMessage = "The password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character.")]
        public string Password { get; set; }



        [Required]
        [Compare("Password", ErrorMessage = "The password and confirm password must match.")]
        public string ConfirmPassword { get; set; }
        public string Contact { get; set; }

        [Required]
        
        public Address Addresses { get; set; }

        [Required]
        [MustBeTrue(ErrorMessage = "The Tearm must be true.")]
        public bool Tearm { get; set; } = true;





    }
}
