using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseShow.Models
{
    public interface IAccount
    {
        string Name { get; set; }
        string City { get; set; }
        string State { get; set; }

        ICollection<Message> Inbox { get; }
        //ICollection<Message> Outbox { get; }
        ICollection<Show> Shows { get; }
    }
}
