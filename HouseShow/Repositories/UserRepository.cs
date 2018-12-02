using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseShow.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseShow.Repositories
{
    public class UserRepository : IUserRepository
    {
        private AppDbContext context;
        public IQueryable<User> Users
        {
            get
            {
                return context.Users.Include("Artists").Include("Venues").Include("Shows");
            }
        }

        public UserRepository(AppDbContext appDbContext)
        {
            context = appDbContext;
        }

        public void AddArtist(User user, Artist artist)
        {
            user.Artists.Add(artist);
            context.Users.Update(user);
            context.SaveChanges();
        }

        public void AddMessage(User user, Message message)
        {
            user.Inbox.Add(message);
            context.Users.Update(user);
            context.SaveChanges();
        }

        public void AddUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public void AddVenue(User user, Venue venue)
        {
            user.Venues.Add(venue);
            context.Users.Update(user);
            context.SaveChanges();
        }

        public User GetUserByName(string userName)
        {
            User user;
            user = context.Users.First(u => u.Name == userName);
            return user;
        }

    }
}
