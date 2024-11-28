using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using eTickets.Data.Enums;
using eTickets.Data.Base;

namespace eTickets.Models
{
    public class Movie: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Tên phim")]
        public string Name { get; set; }
        [Display(Name="Mô tả")]
        public string Description { get; set; }
        [Display(Name = "Giá")]
        public double Price { get; set; }
        [Display(Name="Hình ảnh")]
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //relationship
        public List<Actor_Movie> Actors_Movies { get; set; }

        //cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
