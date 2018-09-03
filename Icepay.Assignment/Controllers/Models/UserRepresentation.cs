namespace Icepay.Assignment.Controllers.Models
{
    public class UserRepresentation
    {
        public UserRepresentation(string email, string name)
        {
            Email = email;
            Name = name;
        }

        public string Email { get; set; }
        public string Name { get; set; }
    }
}
