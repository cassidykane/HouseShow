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
        void AddArtist(Show show, Artist artist);
        void AddUser(Show show, User user);
        List<Show> GetShowsByCity(string city, string state);
    }
}
