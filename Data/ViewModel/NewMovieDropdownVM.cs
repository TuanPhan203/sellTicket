using eTickets.Models;
using System.Collections.Generic;

namespace eTickets.Data.ViewModel
{
    public class NewMovieDropdownVM
    {
        public NewMovieDropdownVM() {
            Producers = new List<Producer>();
            Actors=  new List<Actor>();
            Cinemas = new List<Cinema>();
        }
        public List<Producer> Producers { get; set; }
        public List<Actor> Actors { get; set; }
        public List<Cinema> Cinemas { get; set; }
    }
}
