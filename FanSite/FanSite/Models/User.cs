using Microsoft.AspNetCore.Identity;

namespace FanSite.Models
{
    public class User : IdentityUser
    {
        //public int UserId { get; set; }
        public string FirstName{get;set;}
        public string LastName { get; set; }

    }
}
