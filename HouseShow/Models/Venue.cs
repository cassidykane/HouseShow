using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HouseShow.Models
{
    public class Venue
    {
        public int VenueID { get; set; }
        //private List<Show> shows = new List<Show>();

        [StringLength(50, MinimumLength = 5)]
        [Required(ErrorMessage = "Add a Venue name")]
        public string Name { get; set; }

        [StringLength(50, MinimumLength = 5)]
        [Required(ErrorMessage = "Add a Venue address")]
        public string Address { get; set; }

        [StringLength(50, MinimumLength = 5)]
        [Required(ErrorMessage = "Add a city")]
        public string City { get; set; }

        [StringLength(2, MinimumLength = 2)]
        [Required(ErrorMessage = "Select a state")]
        public string State { get; set; }

        [DataType(DataType.Url)]
        public string Website { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Add an email address")]
        public string Email { get; set; }
        
        //public ICollection<Message> Outbox => outbox;
        //public ICollection<Show> Shows => shows;
    }
}
