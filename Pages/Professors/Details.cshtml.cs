using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Facultate.Data;
using Facultate.Models;

namespace Facultate.Pages.Professors
{
    public class DetailsModel : PageModel
    {
        private readonly Facultate.Data.FacultateContext _context;

        public DetailsModel(Facultate.Data.FacultateContext context)
        {
            _context = context;
        }

        public Professor Professor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Professor = await _context.Professor
                .Include(p => p.Rank).FirstOrDefaultAsync(m => m.Id == id);

            if (Professor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
