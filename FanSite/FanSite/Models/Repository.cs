
using System.Collections.Generic;


namespace FanSite.Models
{
    public class Repository
    {
        private static List<StoryModel> responses = new List<StoryModel>();
        public static IEnumerable<StoryModel> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(StoryModel response)
        {
            responses.Add(response);
        }
    }
}
