﻿using System.ComponentModel.DataAnnotations;

namespace ustaVideos.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio {  get; set; }

        //Realtionships

        public List<Movie> Movies { get; set; }
    }
}