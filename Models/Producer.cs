using eTickets.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="PictureUrl")]
        [Required(ErrorMessage ="Khong duoc de trong")]
        public string ProfilePictureURL { get; set; }
        [Display(Name ="FullName")]
        [Required(ErrorMessage = "Khong duoc de trong")]
        [StringLength(30, MinimumLength = 2, ErrorMessage ="Phai hon 2 ki tu")]
        public string FullName { get; set; }
        [Display(Name ="Bio")]
        [Required(ErrorMessage = "Khong duoc de trong")]
        public string Bio { get; set; }

        //relasionship
        public List<Movie> Movies { get; set; }
    }
}
