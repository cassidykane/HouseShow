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
                return context.Shows.Include("Artists").Include("Users");
            }
        }

        public ShowRepository(AppDbContext appDbContext)
        {
            context = appDbContext;
        }

        public void AddArtist(Show show, Artist artist)
        {
            show.Artists.Add(artist);
            context.Shows.Update(show);
            context.SaveChanges();
        }

        public void AddShow(Show show)
        {
            context.Shows.Add(show);
            context.SaveChanges();
        }

        public void AddUser(Show show, User user)
        {
            show.Users.Add(user);
            context.Shows.Update(show);
            context.SaveChanges();
        }

        public List<Show> GetShowsByCity(string city, string state)
        {
            List<Show> selectedShows = (from s in context.Shows
                                        where s.Venue.City.ToLower() == city.ToLower() &&
                                        s.Venue.State.ToLower() == state.ToLower()
                                        select s).ToList();
            return selectedShows;
        }
    }
}
