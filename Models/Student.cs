using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MajestyApi.Models
{
    public class Student
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        [Required(ErrorMessage = "The grade is required")]
        [MaxLength(3, ErrorMessage = "Grade must be 3 characteres")]
        [MinLength(3, ErrorMessage = "Grade must be 3 characteres")]
        public string Grade { get; set; }
    }
}
