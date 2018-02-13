using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FanSite.Models;
using Microsoft.EntityFrameworkCore;

namespace FanSite.Repositories
{
    public class StoryRepo : IStoryRepo
    {
        private ApplicationDbContext context;

        public StoryRepo(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        static List<StoryModel> storys = new List<StoryModel>();
        /*public StoryRepo()
        {
            StoryModel story = new StoryModel { Title = "Me and She", Date = DateTime.Parse("01/18/2018") , Story = "We did a thing" };
            storys.Add(story);

            story = new StoryModel { Title = "Time to Shine", Date = DateTime.Parse("01/28/2018"), Story = "Casted Lumos" };
            storys.Add(story);

            story = new StoryModel { Title = "Quitage", Date = DateTime.Parse("01/04/2018"), Story = "We have the snich" };
            storys.Add(story);

        }*/
        public List<StoryModel> GetAllStorys()
        {
            return context.Storys.ToList();
        }
        /*public List<StoryModel> GetAllStorys()
        {
            
            return storys;
        }*/
        public void Add(StoryModel s)
        {
            context.Storys.Update(s);
            context.SaveChanges();
            //storys.Add(s);
        }
    }
}
