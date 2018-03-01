﻿using Microsoft.AspNetCore.Identity;

namespace FanSite.Models
{
    public class User : IdentityUser
    {
        public string FirstName{get;set;}
        public string LastName { get; set; }

    }
}
