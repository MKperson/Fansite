using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace FanSite.Models
{
    public class PictureClass
    {
        
        
        public List<string> FileNames { get; set; }


        public PictureClass()
        {
            DirectoryInfo files = new DirectoryInfo(@".\wwwroot\images\");
            FileInfo[] fileinfos = null;
            try
            {
                fileinfos = files.GetFiles();
                FileNames = files.GetFiles().Select(x => x.Name).ToList();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            
            
            
        }
    }
}
