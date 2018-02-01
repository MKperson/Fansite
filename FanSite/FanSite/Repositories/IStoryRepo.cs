using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FanSite.Models;

namespace FanSite.Repositories
{
    public interface IStoryRepo
    {
        List<StoryModel> GetAllStorys();
        

    }
}
