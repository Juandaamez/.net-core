﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using usta_videos.Data.Enum;

namespace usta_videos.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price {  get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }


        //MovieCategory 

        //one to many
        public List<Actor_Movie> Actor_Movies { get; set; }

        //many to one
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]

        public Cinema Cinema { get; set; }

        public int DirectorId { get; set; }
        [ForeignKey("DirectorId")]
        public Director Director { get; set; }


    }
}
