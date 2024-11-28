using eTickets.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Địa chỉ Url hình ảnh")]
        [Required(ErrorMessage ="Khong duoc de trong")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name = "Diễn viên")]
        [Required(ErrorMessage ="Khong duoc de trong")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="It nhat 3 ki tu")]
        public string FullName { get; set; }

        [Display(Name = "Thông tin")]
        [Required(ErrorMessage="Khong duoc de trong")]
        public string Bio { get; set; }
        
        //relationship
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
