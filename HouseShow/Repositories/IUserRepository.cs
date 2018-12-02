using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseShow.Models;

namespace HouseShow.Repositories
{
    public interface IUserRepository
    {
        IQueryable<User> Users { get; }
        void AddUser(User user);
        void AddArtist(User user, Artist artist);
        void AddVenue(User user, Venue venue);                                  
        void AddMessage(User user, Message message);
        User GetUserByName(string userName);

    }
}
