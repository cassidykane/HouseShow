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

        public void AddVenue(Show show, Venue venue)
        {
            Show currentShow = shows.First<Show>(s => s.ShowID == show.ShowID);
            currentShow.Venue = venue;
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
        public Show GetShow(string showID)
        {
            Show show = (from s in shows
                         where s.ShowID.ToString() == showID
                         select s).First();
            return show;
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
            Show show2 = new Show
            {
                Venue = venue1,
                Time = new DateTime(2018, 12, 13, 21, 0, 0),
                Cost = 5.0m
            };
            Show show3 = new Show
            {
                Venue = venue1,
                Time = new DateTime(2018, 12, 14, 21, 0, 0),
                Cost = 5.0m
            };
            Show show4 = new Show
            {
                Venue = venue2,
                Time = new DateTime(2019, 1, 14, 21, 0, 0),
                Cost = 5.0m
            };
            Artist artist1 = new Artist
            {
                Name = "The Seeds",
                Description = "60s garage rock",
                City = "Los Angeles",
                State = "CA",
                Email = "seedsband@seedmail.com"
            };
            Artist artist2 = new Artist
            {
                Name = "The Bad Seeds",
                Description = "Nick Cave's backing band",
                City = "Melbourne",
                State = "AU",
                Email = "sadbeeds@seedmail.com"
            };
            Artist artist3 = new Artist
            {
                Name = "Seedy Dan",
                Description = "Spooky soft rock",
                City = "Dayton",
                State = "OH",
                Email = "dandandan@seedmail.com"
            };
            Artist artist4 = new Artist
            {
                Name = "Seeder",
                City = "Dayton",
                State = "OH",
                Email = "seederthanthou@seedmail.com"
            };
            show1.Artists.Add(artist1);
            show1.Artists.Add(artist2);
            show2.Artists.Add(artist1);
            show3.Artists.Add(artist1);
            show3.Artists.Add(artist2);
            show3.Artists.Add(artist3);
            show4.Artists.Add(artist4);
            
            shows.Add(show1);
            shows.Add(show2);
            shows.Add(show3);
            shows.Add(show4);
        }

        public string GetArtistNames(Show show)
        {
            throw new NotImplementedException();
        }
    }
}
