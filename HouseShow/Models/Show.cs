using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HouseShow.Models
{
    public class Show
    {
        public int ShowID { get; set; }
        private List<string> artists = new List<string>();

        //[Required(ErrorMessage = "Enter a venue")]
        public Venue Venue { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Enter a date and time")]
        public DateTime Time { get; set; }

        [DataType(DataType.Currency)]
        public decimal Cost { get; set; }

        [StringLength(300, MinimumLength = 5)]
        public string Description { get; set; }

        public string ArtistNames
        {
            get
            {
                string names = "";
                foreach (string a in artists)
                {
                    string name = !(a == artists.Last()) ? a + ", " : a;
                    names += name;
                }
                return names;
            }
        }

        public ICollection<string> Artists => artists;
    }
}
