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

        public void AddShow(Show show)
        {
            context.Shows.Add(show);
            context.SaveChanges();
        }
        public void AddArtist(Show show, Artist artist)
        {
            show.Artists.Add(artist);
            //artist.ShowIDs.Add(show.ShowID);
            context.Shows.Update(show);
            context.SaveChanges();
        }
        public void AddVenue(Show show, Venue venue)
        {
            show.Venue = venue;
            context.Shows.Update(show);
            context.SaveChanges();
        }

        public Show GetShow(string showID)
        {
            Show show = (from s in context.Shows
                         where s.ShowID.ToString() == showID
                         select s).First();
            return show;
        }
        public string GetArtistNames(Show show)
        {
            List<Artist> artists = (from s in context.Shows
                                    from a in s.Artists
                                    from id in a.ShowIDs
                                    where id == s.ShowID
                                    select a).ToList();
            string names = "";
            if (artists.Count > 1)
            {
                foreach (Artist a in artists)
                {
                    string name = !(a == artists.Last()) ? a.Name + ", " : a.Name;
                    names += name;
                }
            }
            else if (artists.Count == 1)
            {
                names = artists[0].Name;
            }
            return names;
        }
        /*
        public void SetArtistNames()
        {
            foreach (Show s in context.Shows)
            {
                if (s.Artists == null)
                {
                    List<Artist> artists = GetArtists(s);
                    string names = "";
                    if (artists.Count > 1)
                    {
                        foreach (Artist a in artists)
                        {
                            string name = !(a == artists.Last()) ? a.Name + ", " : a.Name;
                            names += name;
                        }
                    }
                    else if (artists.Count == 1)
                    {
                        names = artists[0].Name;
                    }
                    s.ArtistNames = names;
                    context.Shows.Update(s);
                }
                context.SaveChanges();
            }
        }
        */
    }
}
