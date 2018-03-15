using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace FanSite.Models
{
    public class AccountEditModel
    {
        public IdentityUser User { get; set; }
        //public IEnumerable<User> Members { get; set; }
        //public IEnumerable<User> NonMembers { get; set; }
    }
}

