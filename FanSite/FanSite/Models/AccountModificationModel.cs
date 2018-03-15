using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{
    public class AccountModificationModel
    {
        [Required]
        public string FirstName { get; set; }
        public string UserId { get; set; }
        public string[] IdsToAdd { get; set; }
        public string[] IdsToDelete { get; set; }
    }
}

