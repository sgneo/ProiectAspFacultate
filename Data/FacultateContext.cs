using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Facultate.Models;

namespace Facultate.Data
{
    public class FacultateContext : DbContext
    {
        public FacultateContext (DbContextOptions<FacultateContext> options)
            : base(options)
        {
        }

        public DbSet<Facultate.Models.StudentStatus> StudentStatus { get; set; }

        public DbSet<Facultate.Models.ProfessorRank> ProfessorRank { get; set; }

        public DbSet<Facultate.Models.Professor> Professor { get; set; }

        public DbSet<Facultate.Models.Course> Course { get; set; }

        public DbSet<Facultate.Models.Student> Student { get; set; }
    }
}
