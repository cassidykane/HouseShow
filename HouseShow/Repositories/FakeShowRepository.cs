using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseShow.Models;

namespace HouseShow.Repositories
{
    public class FakeShowRepository : IShowRepository
    {
        List<Show> shows = new List<Show>();
        public IQueryable<Show> Shows { get { return shows.AsQueryable(); } }

        public FakeShowRepository()
        {
            AddTestData();
        }

        public void AddArtist(Show show, Artist artist)
        {
            Show currentShow = shows.First<Show>(s => s.ShowID == show.ShowID);
            currentShow.Artists.Add(artist);
        }

        public void AddShow(Show show)
        {
            show.ShowID = shows.Count();
            shows.Add(show);
        }

        public void AddUser(Show show, User user)
        {
            Show currentShow = shows.First<Show>(s => s.ShowID == show.ShowID);
            currentShow.Users.Add(user);
        }

        public List<Show> GetShowsByCity(string city, string state)
        {
            List<Show> selectedShows = (from s in shows
                                where s.Venue.City.ToLower() == city.ToLower() &&
                                s.Venue.State.ToLower() == state.ToLower()
                                select s).ToList();
            return selectedShows;
        }

        void AddTestData()
        {
            User user = new User
            {
                Name = "User1",
                Password = "12345",
                City = "Eugene",
                State = "OR"
            };
            Artist artist = new Artist
            {
                Name = "Artist1",
                Description = "this is a test",
                City = "Eugene",
                State = "OR"
            };
            Artist artist2 = new Artist
            {
                Name = "Artist2",
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

            show.Artists.Add(artist);
            show.Artists.Add(artist2);
            show.Users.Add(user);
            shows.Add(show);

            User user2 = new User
            {
                Name = "User1",
                Password = "12345",
                City = "Eugene",
                State = "OR"
            };
            venue = new Venue
            {
                Name = "Venue2",
                Address = "345 abc st.",
                City = "Eugene",
                State = "OR"
            };
            show = new Show
            {
                Venue = venue,
                Time = new DateTime(2019, 1, 13, 20, 0, 0),
                Cost = 0m
            };

            show.Artists.Add(artist);
            show.Users.Add(user);
            show.Users.Add(user2);
            shows.Add(show);

            venue = new Venue
            {
                Name = "Venue3",
                Address = "345 abc st.",
                City = "Portland",
                State = "OR"
            };
            show = new Show
            {
                Venue = venue,
                Time = new DateTime(2019, 1, 3, 20, 0, 0),
                Cost = 0m
            };

            show.Artists.Add(artist);
            show.Users.Add(user);
            show.Users.Add(user2);
            shows.Add(show);
        }
    }
}
