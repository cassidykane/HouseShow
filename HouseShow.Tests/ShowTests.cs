using System.Linq;
using System.Collections.Generic;
using System.Text;
using Xunit;
using HouseShow.Controllers;
using HouseShow.Models;
using HouseShow.Repositories;

namespace HouseShow.Tests
{
    public class ShowTests
    {
        [Fact]
        public void TestGetShowsByCity()
        {
            // Arrange
            var repo = new FakeShowRepository();

            // Act
            List<Show> s1 = repo.GetShowsByCity("eugene", "or");
            List<Show> s2 = repo.GetShowsByCity("portland", "or");

            // Assert
            Assert.Equal(3, s1.Count);
            Assert.Single(s2);
            Assert.Equal("Seedy Tavern", s1[0].Venue.Name);
            Assert.Equal("Seed House", s2[0].Venue.Name);

        }

        [Fact]
        public void TestGetShowsByArtist()
        {
            // Arrange
            var repo = new FakeShowRepository();

            // Act
            List<Show> s1 = repo.GetShowsByArtist("The Bad Seeds");

            // Assert
            Assert.Equal(2, s1.Count);
        }

        [Fact]
        public void TestGetShowsByVenue()
        {
            // Arrange
            var repo = new FakeShowRepository();

            // Act
            List<Show> s1 = repo.GetShowsByVenue("Seed House");

            // Assert
            Assert.Single(s1);
        }

        [Fact]
        public void TestArtistNamesToString()
        {
            // Arrange
            var repo = new FakeShowRepository();

            // Act
            List<Show> s1 = repo.GetShowsByCity("eugene", "or");

            // Assert
            Assert.Equal("The Seeds, The Bad Seeds", s1[0].ArtistNames);
        }
    }
}
