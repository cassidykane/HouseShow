using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseShow.Models;

namespace HouseShow.Repositories
{
    public interface IShowRepository
    {
        IQueryable<Show> Shows { get; }

        void AddShow(Show show);
        void AddVenue(Show show, Venue venue);
        void AddArtist(Show show, Artist artist);

        Show GetShow(string showID);

        string GetArtistNames(Show show);

        //void SetArtistNames();

    }
}
