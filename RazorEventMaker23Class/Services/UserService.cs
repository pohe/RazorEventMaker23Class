using RazorEventMaker23Class.Helpers;
using RazorEventMaker23Class.Interfaces;
using RazorEventMaker23Class.Models;

namespace RazorEventMaker23Class.Services
{
    public class UserService : IUserService
    {
        private string JsonFileName = @"Data\JsonUsers.json";

        public List<User> GetAllUsers()
        {
            return JsonFileReader<User>.ReadJson(JsonFileName);
        }

        public User GetUser(int id)
        {
            List<User> users = JsonFileReader<User>.ReadJson(JsonFileName);
            foreach (var item in users)
            {
                if (item.UserId == id)
                    return item;
            }
            return null;
        }
    }

}
