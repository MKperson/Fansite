using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        public DbSet<StoryModel> Storys { get; set; }
        public DbSet<Fan> Fans { get; set; }






    }
}
