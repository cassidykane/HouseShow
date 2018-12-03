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

        public ViewResult DisplayShow(string showID)
        {
            Show show = repo.GetShow(showID);
            return View(show);
        }

        public IActionResult AddVenue()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddExistingVenue(string venueName)
        {
            Venue venue = (from s in repo.Shows
                           where s.Venue.Name.ToLower() == venueName.ToLower()
                           select s.Venue).Single();

            Show show = new Show();
            show.Venue = venue;
            repo.AddShow(show);
            ViewBag.ThisShow = show.ShowID;
            return RedirectToAction("AddArtist");
        }

        [HttpPost]
        public RedirectToActionResult AddNewVenue(Venue venue)
        {
            if (ModelState.IsValid)
            {
                Show show = new Show();
                show.Venue = venue;
                repo.AddShow(show);
                ViewBag.ThisShow = show.ShowID;
            }
            return RedirectToAction("AddArtist");
        }

        public IActionResult AddArtist()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddExistingArtist(string artistName)
        {
            Artist artist = (from s in repo.Shows
                             from a in s.Artists
                             where a.Name.ToLower() == artistName.ToLower()
                             select a).Single();
            string showID = ViewBag.ThisShow;
            Show show = repo.GetShow(ViewBag.ShowID);

            show.Artists.Add(artist);
            //ViewBag.ThisShow = show.ShowID;
            return RedirectToAction("DisplayShow", show.ShowID);
        }

        [HttpPost]
        public RedirectToActionResult AddNewArtist(Artist artist)
        {
            Show show = repo.GetShow(ViewBag.ShowID);
            if (ModelState.IsValid)
            {
                show.Artists.Add(artist);
            }
            return RedirectToAction("DisplayShow", show.ShowID);
        }

        public void SortShows(List<Show> shows)
        {
            shows.Sort((s1, s2) => DateTime.Compare(s1.Time, s2.Time));
            shows.Reverse();
        }
        
    }
}
