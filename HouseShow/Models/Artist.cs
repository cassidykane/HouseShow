using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HouseShow.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }

        //private List<string> links = new List<string>();
        //private List<Show> shows = new List<Show>();

        [StringLength(50, MinimumLength = 5)]
        [Required(ErrorMessage = "Add an Artist name")]
        public string Name { get; set; }

        [StringLength(300, MinimumLength = 5)]
        public string Description { get; set; }

        [StringLength(50, MinimumLength = 5)]
        [Required(ErrorMessage = "Add a city")]
        public string City { get; set; }

        [StringLength(2, MinimumLength = 2)]
        [Required(ErrorMessage = "Select a state")]
        public string State { get; set; }

        [DataType(DataType.EmailAddress)]
        //[Required(ErrorMessage = "Add an email address")]
        public string Email { get; set; }

        //public ICollection<string> Links => links;
        //public ICollection<Show> Shows => shows;
    }
}
