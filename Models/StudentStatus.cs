using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Facultate.Models
{
    public class StudentStatus
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Student's status")]
        [StringLength(30, ErrorMessage = "Limit to 30 characters.")]
        public string Name { get; set; }
    }
}
