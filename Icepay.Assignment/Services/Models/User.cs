namespace Icepay.Assignment.Services.Models
{
    public class User
    {
        public User(string email, string name, string password, string token)
        {
            Email = email;
            Password = password;
            Token = token;
            Name = name;
        }

        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
    }
}