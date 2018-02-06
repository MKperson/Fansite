using System;
using Xunit;
using FanSite.Models;
using FanSite.Controllers;
using FanSiteUnitTests;
using System.Collections.Generic;

namespace FansiteUnitTests
{
    public class StoryTests
    {
        public StoryTests()
        {

        }
        [Fact]
        public void TestAllStorys()
        {
            //Arange
            FakeStoryRepo repository = new FakeStoryRepo();
            HomeController controller = new HomeController(repository);
            //Act
            List<StoryModel> storys = controller.AllStories().ViewData.Model as List<StoryModel>;
            //Assert
            Assert.Equal(repository.GetAllStorys()[0].Title,
                storys[0].Title);
            Assert.Equal(repository.GetAllStorys()[0].Date,
                storys[0].Date);
            Assert.Equal(repository.GetAllStorys()[0].Story,
                storys[0].Story);
            Assert.Equal(repository.GetAllStorys()[1].Title,
                storys[1].Title);
            Assert.Equal(repository.GetAllStorys()[1].Date,
                storys[1].Date);
            Assert.Equal(repository.GetAllStorys()[1].Story,
                storys[1].Story);



        }
    }
}
