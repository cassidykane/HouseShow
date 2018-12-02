using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseShow.Models
{
    public class Venue : IAccount
    {
        public int VenueID { get; set; }
        private List<Message> inbox = new List<Message>();
        private List<Message> outbox = new List<Message>();
        private List<Show> shows = new List<Show>();

        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public ICollection<Message> Inbox => inbox;
        //public ICollection<Message> Outbox => outbox;
        public ICollection<Show> Shows => shows;
    }
}
