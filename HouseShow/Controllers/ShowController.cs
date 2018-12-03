using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HouseShow.Models;
using HouseShow.Repositories;

namespace HouseShow.Controllers
{
    public class ShowController : Controller
    {
        IShowRepository repo;
        public ShowController(IShowRepository r)
        {
            repo = r;
        }

        public IActionResult Index()
        {
            //List<Show> shows = repo.Shows.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Index(string city, string state)
        {
            //ViewBag.City = city;
            List<Show> shows = (from s in repo.Shows
                                where s.Venue.City.ToLower() == city.ToLower() &&
                                s.Venue.State.ToLower() == state.ToLower()
                                select s).ToList();
            SortShows(shows);
            return View(shows);
        }

        public IActionResult AddShow()
        {
            return View();
        }

        public ViewResult DisplayShow(string showID)
        {
            Show show = (from s in repo.Shows
                         where s.ShowID.ToString() == showID
                         select s).First();
            return View(show);
        }

        [HttpPost]
        public IActionResult AddShow(Show show, string artistName)
        {
            repo.AddShow(show);
            return View("ViewShow", show);
        }

        public void SortShows(List<Show> shows)
        {
            shows.Sort((s1, s2) => DateTime.Compare(s1.Time, s2.Time));
            shows.Reverse();
        }
        
    }
}
