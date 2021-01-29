using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Facultate.Models
{
    public class Professor
    {
        [Required]
        [Display(Name = "First Name")]
        [StringLength(30, ErrorMessage = "Limit first name to 30 characters.")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(30, ErrorMessage = "Limit last name to 30 characters.")]
        public string LastName { get; set; }
        [Required] public DateTime DateOfBirth { get; set; }

        public ProfessorRank Rank { get; set; }
        public int RankID { get; set; }
        public int Id { get; set; }
        [Required] public DateTime JoinedAt { get; set; }
    }
}
