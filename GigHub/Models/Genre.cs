﻿using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Genre
    {
        public int id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}