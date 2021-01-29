using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Facultate.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Course Name")]
        [StringLength(30, ErrorMessage = "Limit Title to 30 characters.")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Number of sessions")]
        public int NumberOfSessions { get; set; }
    }
}
