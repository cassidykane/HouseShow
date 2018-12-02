using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseShow.Models;

namespace HouseShow.Repositories
{
    public class FakeUserRepository : IUserRepository
    {
        private List<User> users = new List<User>();
        public IQueryable<User> Users { get { return users.AsQueryable(); } }

        public FakeUserRepository()
        {
            AddTestData();
        }

        public void AddArtist(User user, Artist artist)
        {
            User currentUser = users.First<User>(u => u.UserID == user.UserID);
            currentUser.Artists.Add(artist);
        }

        public void AddMessage(User user, Message message)
        {
            User currentUser = users.First<User>(u => u.UserID == user.UserID);
            currentUser.Inbox.Add(message);
        }

        public void AddUser(User user)
        {
            user.UserID = users.Count();
            users.Add(user);
        }

        public void AddVenue(User user, Venue venue)
        {
            User currentUser = users.First<User>(u => u.UserID == user.UserID);
            currentUser.Venues.Add(venue);
        }

        public User GetUserByName(string userName)
        {
            User user = users.Find(u => u.Name == userName);
            return user;
        }

        void AddTestData()
        {
            User user = new User
            {
                UserID = 1,
                Name = "User1",
                Password = "12345",
                City = "Eugene",
                State = "OR"
            };
            Artist artist = new Artist
            {
                ArtistID = 1,
                Name = "Artist1",
                Description = "this is a test",
                City = "Eugene",
                State = "OR"
            };
            Venue venue = new Venue
            {
                Name = "Venue1",
                Address = "1234 abc st.",
                City = "Eugene",
                State = "OR"
            };
            Show show = new Show
            {
                Venue = venue,
                Time = new DateTime(2019, 1, 1, 21, 0, 0),
                Cost = 5.0m
            };

            user.Artists.Add(artist);
            user.Venues.Add(venue);
            user.Shows.Add(show);
            users.Add(user);
        }
    }
}
