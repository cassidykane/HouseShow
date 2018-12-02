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
                User user = new User
                {
                    Name = "seeder",
                    Password = "password",
                    City = "Eugene",
                    State = "OR"
                };
                Venue venue = new Venue
                {
                    Name = "Seedy Tavern",
                    Address = "1234 Cedar Dr.",
                    City = "Eugene",
                    State = "OR"
                };
                Show show1 = new Show
                {
                    Venue = venue,
                    Time = new DateTime(2018, 12, 12, 21, 0, 0),
                    Cost = 5.0m
                };
                Show show2 = new Show
                {
                    Venue = venue,
                    Time = new DateTime(2018, 12, 13, 21, 0, 0),
                    Cost = 5.0m
                };
                Show show3 = new Show
                {
                    Venue = venue,
                    Time = new DateTime(2018, 12, 14, 21, 0, 0),
                    Cost = 5.0m
                };
                Artist artist1 = new Artist
                {
                    Name = "The Seeds",
                    Description = "60s garage rock",
                    City = "Los Angeles",
                    State = "CA"
                };
                Artist artist2 = new Artist
                {
                    Name = "The Bad Seeds",
                    Description = "Nick Cave's backing band",
                    City = "Melbourne",
                    State = "AU"
                };
                Artist artist3 = new Artist
                {
                    Name = "Seedy Dan",
                    Description = "Spooky soft rock",
                    City = "Dayton",
                    State = "OH"
                };
                show1.Artists.Add(artist1);
                show1.Artists.Add(artist2);
                show2.Artists.Add(artist1);
                show3.Artists.Add(artist1);
                show3.Artists.Add(artist2);
                show3.Artists.Add(artist3);
                user.Shows.Add(show1);
                user.Shows.Add(show3);

                context.Shows.Add(show1);
                context.Shows.Add(show2);
                context.Shows.Add(show3);
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
