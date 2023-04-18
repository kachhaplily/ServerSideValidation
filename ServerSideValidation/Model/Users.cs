namespace ServerSideValidation.Model
{

    public class Users
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
        public string Contact { get; set; }
        public Address Addresses { get; set; }
        public bool Tearm { get; set; } = true;


    }
}
