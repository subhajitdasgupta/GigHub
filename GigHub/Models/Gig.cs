using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GigHub.Models
{
    public class Gig
    {
        public int id { get; set; }
        [Required]
        public ApplicationUser Artist { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public String Venue { get; set; }
        public Genre Genre { get; set; }
    }
}