using RazorEventMaker23Class.Models;

namespace RazorEventMaker23Class.Interfaces
{
    
    public interface IUserService
    {
        List<User> GetAllUsers();

        User GetUser(int id);

    }

}
