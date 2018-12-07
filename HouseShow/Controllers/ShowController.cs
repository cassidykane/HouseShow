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
            List<Show> shows = (from s in repo.Shows
                                where s.Venue.City.ToLower() == city.ToLower() &&
                                s.Venue.State.ToLower() == state.ToLower()
                                select s).ToList();
            ViewBag.Names = new Dictionary<int, string>(); 

            foreach (Show s in shows)
            {
                if (s.ArtistNames.Length < 1)
                    ViewBag.Names.Add(s.ShowID, repo.GetArtistNames(s));
            }
            SortShows(shows);

            return View(shows);
        }
         
        public ViewResult DisplayArtist(string artist)
        {
            List<Show> shows = (from s in repo.Shows
                                from a in s.Artists
                                where a.Name.ToLower() == artist.ToLower()
                                select s).ToList();
            ViewBag.Artist = (from s in repo.Shows
                                 from a in s.Artists
                                 where a.Name.ToLower() == artist.ToLower()
                                 select a).Single();
            SortShows(shows);
            return View(shows);
        }

        public IActionResult DisplayArtists()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DisplayArtists(string city, string state)
        {
            List<Artist> artists = (from s in repo.Shows
                                    from a in s.Artists
                                    where a.City.ToLower() == city.ToLower() &&
                                    a.State.ToLower() == state.ToLower()
                                    select a).Distinct().ToList();
            artists.Sort((a1, a2) => string.Compare(a1.Name, a2.Name));
            return View(artists);
        }

        public ViewResult DisplayVenue(string venue)
        {
            List<Show> shows = (from s in repo.Shows
                                where s.Venue.Name.ToLower() == venue.ToLower()
                                select s).ToList();
            ViewBag.Venue = shows[0].Venue;

            SortShows(shows);
            return View(shows);
        }

        public IActionResult DisplayVenues()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DisplayVenues(string city, string state)
        {
            List<Venue> venues = (from s in repo.Shows
                                    where s.Venue.City.ToLower() == city.ToLower() &&
                                    s.Venue.State.ToLower() == state.ToLower()
                                    select s.Venue).Distinct().ToList();
            venues.Sort((v1, v2) => string.Compare(v1.Name, v2.Name));
            return View(venues);
        }

        public ViewResult DisplayShow(string showID)
        {
            Show show = (from s in repo.Shows
                         where s.ShowID.ToString() == showID
                         select s).Single();
            return View(show);
        }

        public IActionResult AddShow()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddShow(Show show)
        {
            if (ModelState.IsValid)
            {
                repo.AddShow(show);
                return RedirectToAction("AddVenue");
            }
            return RedirectToAction();
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
            Show show = repo.Shows.OrderByDescending(s => s.ShowID).First();
            
            //repo.AddVenue(repo.Shows.Last(), venue);
            show.Venue = venue;
            return RedirectToAction("AddArtist");
        }

        [HttpPost]
        public RedirectToActionResult AddNewVenue(Venue venue)
        {
            Show show = repo.Shows.OrderByDescending(s => s.ShowID).First();
            if (ModelState.IsValid)
            {
                //repo.AddVenue(repo.Shows.Last(), venue);
                show.Venue = venue;
            }
            return RedirectToAction("AddArtist");
        }

        public IActionResult AddArtist()
        {
            Show show = repo.Shows.OrderByDescending(s => s.ShowID).First();
            ViewBag.ShowID = show.ShowID.ToString();
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddExistingArtist(string artistName)
        {
            Artist artist = (from s in repo.Shows
                             from a in s.Artists
                             where a.Name.ToLower() == artistName.ToLower()
                             select a).Single();
            Show show = repo.Shows.OrderByDescending(s => s.ShowID).First();

            repo.AddArtist(show, artist);
            //show.Artists.Add(artist);
            return RedirectToAction("AddArtist");
        }

        [HttpPost]
        public RedirectToActionResult AddNewArtist(Artist artist)
        {
            Show show = repo.Shows.OrderByDescending(s => s.ShowID).First();

            if (ModelState.IsValid)
            {
                repo.AddArtist(show, artist);
                //show.Artists.Add(artist);
            }
            return RedirectToAction("AddArtist");
        }

        public void SortShows(List<Show> shows)
        {
            shows.Sort((s1, s2) => DateTime.Compare(s1.Time, s2.Time));
        }
        
    }
}
