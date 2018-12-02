using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseShow.Models
{
    public class Artist : IAccount
    {
        public int ArtistID { get; set; }
        private List<string> links = new List<string>();
        private List<Message> inbox = new List<Message>();
        //private List<Message> outbox = new List<Message>();
        private List<Show> shows = new List<Show>();

        public string Name { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public ICollection<string> Links => links;
        public ICollection<Message> Inbox => inbox;
        //public ICollection<Message> Outbox => outbox;
        public ICollection<Show> Shows => shows;
    }
}
