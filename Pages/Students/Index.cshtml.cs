﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Facultate.Data;
using Facultate.Models;

namespace Facultate.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly Facultate.Data.FacultateContext _context;

        public IndexModel(Facultate.Data.FacultateContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student
                .Include(s => s.Status).ToListAsync();
        }
    }
}
