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
        /*
        public void AddArtist(Show show, Artist artist)
        {
            Show currentShow = shows.First<Show>(s => s.ShowID == show.ShowID);
            currentShow.ArtistNames.Add(artist.Name);
        }
        */
        public void AddShow(Show show)
        {
            show.ShowID = shows.Count();
            shows.Add(show);
        }
        /*
        public List<Show> GetShowsByCity(string city, string state)
        {
            List<Show> selectedShows = (from s in shows
                                where s.Venue.City.ToLower() == city.ToLower() &&
                                s.Venue.State.ToLower() == state.ToLower()
                                select s).ToList();
            return selectedShows;
        }

        public List<Show> GetShowsByArtist(string artistName)
        {
            List<Show> selectedShows = (from s in shows
                                        from a in s.Artists
                                        where a.Name.ToLower() == artistName.ToLower()
                                        select s).ToList();
            return selectedShows;
        }

        public List<Show> GetShowsByVenue(string venueName)
        {
            List<Show> selectedShows = (from s in shows
                                        where s.Venue.Name.ToLower() == venueName.ToLower()
                                        select s).ToList();
            return selectedShows;
        }
        */
        void AddTestData()
        {
            Venue venue1 = new Venue
            {
                Name = "Seedy Tavern",
                Address = "1234 Cedar Dr.",
                City = "Eugene",
                State = "OR",
                Email = "seedyseed@seedmail.com"
            };

            Venue venue2 = new Venue
            {
                Name = "Seed House",
                Address = "12345 Cedar Dr.",
                City = "Portland",
                State = "OR",
                Email = "seeeed@seedmail.com"
            };

            Show show1 = new Show
            {
                Venue = venue1,
                Time = new DateTime(2018, 12, 12, 21, 0, 0),
                Cost = 5.0m
            };
            show1.Artists.Add("The Seeds");
            show1.Artists.Add("The Bad Seeds");
            shows.Add(show1);

            Show show2 = new Show
            {
                Venue = venue1,
                Time = new DateTime(2018, 12, 13, 21, 0, 0),
                Cost = 5.0m
            };
            show2.Artists.Add("The Seeds");
            show2.Artists.Add("The Bad Seeds");
            shows.Add(show2);

            Show show3 = new Show
            {
                Venue = venue1,
                Time = new DateTime(2018, 12, 14, 21, 0, 0),
                Cost = 5.0m
            };
            show3.Artists.Add("The Seeds");
            show3.Artists.Add("The Bad Seeds");
            show3.Artists.Add("Seedy Dan");
            shows.Add(show3);

            Show show4 = new Show
            {
                Venue = venue2,
                Time = new DateTime(2019, 1, 14, 21, 0, 0),
                Cost = 5.0m
            };
            show4.Artists.Add("Seeder");
            shows.Add(show4);
        }
    }
}
