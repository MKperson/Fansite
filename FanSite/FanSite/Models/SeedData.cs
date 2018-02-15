
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace FanSite.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider services)
        {
            ApplicationDbContext context = services.GetRequiredService<ApplicationDbContext>();
            context.Database.EnsureCreated();
            if (!context.Storys.Any())
            {
                StoryModel story = new StoryModel { Title = "Lord of the Rings", Date = DateTime.Parse("1/1/1937"), Story= "This is the one ring"}; // month/day/year
                context.Storys.Add(story);    // add the book to the dB Context
                context.SaveChanges();      // save it so it gets an ID (PK value)
                Fan fan = new Fan { Name = "Samuel Shellabarger", Email= "Sam@example.com", StoryModelID = story.StoryModelID };
                context.Fans.Add(fan);
                story.Fans.Add(fan);
                //context.SaveChanges();





                context.SaveChanges(); // save the last addition
            }
        }
    }
}

/* Code in Initialize is based on:
 * https://dotnetthoughts.net/seed-database-in-aspnet-core/
 */
