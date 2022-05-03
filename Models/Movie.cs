using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MajestyApi.Models
{
    public class Movie
    {
      

        public int ID { get; set; }

        [Required(ErrorMessage = "The title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The director is required")]
        [MinLength(3, ErrorMessage = "The director field must have at least 3 characteres")]
        public string Director { get; set; }
        
    }
}
