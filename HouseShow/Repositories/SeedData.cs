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
                show1.Artists.Add("The Seeds");
                show1.Artists.Add("The Bad Seeds");
                context.Shows.Add(show1);

                Show show2 = new Show
                {
                    Venue = venue1,
                    Time = new DateTime(2018, 12, 13, 21, 0, 0),
                    Cost = 5.0m
                };
                show2.Artists.Add("The Seeds");
                show2.Artists.Add("The Bad Seeds");
                context.Shows.Add(show2);

                Show show3 = new Show
                {
                    Venue = venue1,
                    Time = new DateTime(2018, 12, 14, 21, 0, 0),
                    Cost = 5.0m
                };
                show3.Artists.Add("The Seeds");
                show3.Artists.Add("The Bad Seeds");
                show3.Artists.Add("Seedy Dan");
                context.Shows.Add(show3);

                Show show4 = new Show
                {
                    Venue = venue2,
                    Time = new DateTime(2019, 1, 14, 21, 0, 0),
                    Cost = 5.0m
                };
                show4.Artists.Add("Seeder");
                context.Shows.Add(show4);

                context.SaveChanges();
            }
        }
    }
}
