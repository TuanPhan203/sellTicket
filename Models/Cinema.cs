using eTickets.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Logo")]

        public string Logo { get; set; }

        [Display(Name="Name")]
        public string Name { get; set; }

        [Display(Name="Descripton")]
        public string Description { get; set; }
        //relasionship
        public List<Movie> Movies { get; set; }
    }
}
