using Microsoft.AspNetCore.Identity;

namespace API_Rest_Store_Management.Data
{
    public class ApiUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
