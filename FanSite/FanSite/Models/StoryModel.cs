using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{
    public class StoryModel
    {
        private List<Fan> fans = new List<Fan>();

        public int StoryModelID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Story { get; set; }
        public List<Fan> Fans { get { return fans; } }


    }
}
