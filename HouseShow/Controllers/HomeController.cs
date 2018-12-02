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
    public class HomeController : Controller
    {
        IShowRepository repo;
        User currentUser;
        public HomeController(IShowRepository r)
        {
            repo = r;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string city, string state)
        {
            ViewBag.City = city;
            List<Show> shows = repo.GetShowsByCity(city, state);
            SortShows(shows);
            return View(shows);
        }

        public void SortShows(List<Show> shows)
        {
            shows.Sort((s1, s2) => DateTime.Compare(s1.Time, s2.Time));
            shows.Reverse();
        }
        
    }
}
