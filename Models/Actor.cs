using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Picture")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name = "Actor")]
        public string FullName { get; set; }

        [Display(Name = "Bio")]
        public string Bio { get; set; }
        
        //relationship
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
