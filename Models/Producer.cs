using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name ="FullName")]
        public string FullName { get; set; }
        [Display(Name ="Bio")]
        public string Bio { get; set; }

        //relasionship
        public List<Movie> Movies { get; set; }
    }
}
