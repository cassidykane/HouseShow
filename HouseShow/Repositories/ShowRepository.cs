using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseShow.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseShow.Repositories
{
    public class ShowRepository : IShowRepository
    {
        private AppDbContext context;
        public IQueryable<Show> Shows
        {
            get
            {
                return context.Shows.Include("Artists").Include("Venue");
            }
        }

        public ShowRepository(AppDbContext appDbContext)
        {
            context = appDbContext;
        }
        /*
        public void AddArtist(Show show, Artist artist)
        {
            show.Artists.Add(artist);
            context.Shows.Update(show);
            context.SaveChanges();
        }
        */
        public void AddShow(Show show)
        {
            context.Shows.Add(show);
            context.SaveChanges();
        }

        public Show GetShow(string showID)
        {
            Show show = (from s in context.Shows
                         where s.ShowID.ToString() == showID
                         select s).First();
            return show;
        }
        /*
        public List<Show> GetShowsByCity(string city, string state)
        {
            List<Show> selectedShows = (from s in context.Shows
                                        where s.Venue.City.ToLower() == city.ToLower() &&
                                        s.Venue.State.ToLower() == state.ToLower()
                                        select s).ToList();
            return selectedShows;
        }

        public List<Show> GetShowsByArtist(string artistName)
        {
            List<Show> selectedShows = (from s in context.Shows
                                        from a in s.Artists
                                        where a.Name.ToLower() == artistName.ToLower() 
                                        select s).ToList();
            return selectedShows;
        }

        public List<Show> GetShowsByVenue(string venueName)
        {
            List<Show> selectedShows = (from s in context.Shows
                                        where s.Venue.Name.ToLower() == venueName.ToLower()
                                        select s).ToList();
            return selectedShows;
        }
        */
    }
}
