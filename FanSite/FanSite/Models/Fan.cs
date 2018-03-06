using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{
    public class Fan
    {
        public int FanID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int StoryModelID { get; set; }
        public User Member { get; set; }


    }
}
