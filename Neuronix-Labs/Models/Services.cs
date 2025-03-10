﻿using System.ComponentModel.DataAnnotations;

namespace Neuronix_Labs.Models
{
    public class Services
    {
        [Key] // Explicitly marking it as Primary Key
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Link { get; set; }
    }
}
