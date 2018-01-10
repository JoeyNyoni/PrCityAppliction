using System;
using System.ComponentModel.DataAnnotations;

namespace GBTC.Models
{
    public class Event
    {
        //Add Data-Annotations

        public int Id { get; set; }

        [Required]
        public ApplicationUser Organiser  { get; set; }
        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

        [Required]
        public Type Type { get; set; }
    }
}