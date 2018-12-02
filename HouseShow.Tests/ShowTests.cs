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
            List <Show> s1 = repo.GetShowsByCity("eugene", "or");
            List<Show> s2 = repo.GetShowsByCity("PORTLAND", "OR");

            // Assert
            Assert.Equal(2, s1.Count);
            Assert.Equal("Venue1", s1[0].Venue.Name);
            Assert.Single(s2);
            Assert.Equal("Venue3", s2[0].Venue.Name);
        }

        [Fact]
        public void TestArtistNamesToString()
        {
            // Arrange
            var repo = new FakeShowRepository();

            // Act
            List<Show> s1 = repo.GetShowsByCity("eugene", "or");

            // Assert
            Assert.Equal("Artist1, Artist2", s1[0].ArtistNames);
        }
    }
}
