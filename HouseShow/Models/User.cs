using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseShow.Models
{
    public class User : IAccount
    {
        public int UserID { get; set; }
        private List<Artist> artists = new List<Artist>();
        private List<Venue> venues = new List<Venue>();
        private List<Message> inbox = new List<Message>();
        //private List<Message> outbox = new List<Message>();
        private List<Show> shows = new List<Show>();

        public string Name { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public ICollection<Artist> Artists => artists;
        public ICollection<Venue> Venues => venues;
        public ICollection<Message> Inbox => inbox;
        //public ICollection<Message> Outbox => outbox;
        public ICollection<Show> Shows => shows;
    }
}
