using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseShow.Models
{
    public class Show
    {
        public int ShowID { get; set; }
        private List<Artist> artists = new List<Artist>();
        private List<User> users = new List<User>();

        public Venue Venue { get; set; }
        public DateTime Time { get; set; }
        public decimal Cost { get; set; }

        public ICollection<Artist> Artists => artists;
        public ICollection<User> Users => users;
        public string ArtistNames
        {
            get
            {
                string names = "";
                foreach (Artist a in artists)
                {
                    string name = !(a == artists.Last()) ? a.Name + ", " : a.Name;
                    names += name;
                }
                return names;
            }
        }
    }
}
