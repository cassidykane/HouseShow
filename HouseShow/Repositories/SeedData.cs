using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseShow.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace HouseShow.Repositories
{
    public class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices.GetRequiredService<AppDbContext>();
            context.Database.EnsureCreated();

            if (!context.Shows.Any())
            {
                Venue venue1 = new Venue
                {
                    Name = "Seedy Tavern",
                    Address = "1234 Cedar Dr.",
                    City = "Eugene",
                    State = "OR",
                    Email = "seedyseed@seedmail.com"
                };
                context.Venues.Add(venue1);

                Venue venue2 = new Venue
                {
                    Name = "Seed House",
                    Address = "12345 Cedar Dr.",
                    City = "Portland",
                    State = "OR",
                    Email = "seeeed@seedmail.com"
                };
                context.Venues.Add(venue2);

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
                context.Artists.Add(artist1);

                Artist artist2 = new Artist
                {
                    Name = "The Bad Seeds",
                    Description = "Nick Cave's backing band",
                    City = "Melbourne",
                    State = "AU",
                    Email = "sadbeeds@seedmail.com"
                };
                context.Artists.Add(artist2);

                Artist artist3 = new Artist
                {
                    Name = "Seedy Dan",
                    Description = "Spooky soft rock",
                    City = "Dayton",
                    State = "OH",
                    Email = "dandandan@seedmail.com"
                };
                context.Artists.Add(artist3);

                Artist artist4 = new Artist
                {
                    Name = "Seeder",
                    City = "Dayton",
                    State = "OH",
                    Email = "seederthanthou@seedmail.com"
                };
                context.Artists.Add(artist4);

                show1.Artists.Add(artist1);
                show1.Artists.Add(artist2);
                show2.Artists.Add(artist1);
                show3.Artists.Add(artist1);
                show3.Artists.Add(artist2);
                show3.Artists.Add(artist3);
                show4.Artists.Add(artist4);

                context.Shows.Add(show1);
                context.Shows.Add(show2);
                context.Shows.Add(show3);
                context.Shows.Add(show4);
                context.SaveChanges();
            }
        }
    }
}
