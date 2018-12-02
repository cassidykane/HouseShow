using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseShow.Models
{
    public class Message
    {
        public int MessageID { get; set; }

        public bool Unread { get; set; }
        public DateTime Time { get; set; }
        public string Sender { get; set; }
    }
}
