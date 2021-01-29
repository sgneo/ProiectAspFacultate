using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Facultate.Data;
using Facultate.Models;

namespace Facultate.Pages.ProfessorRanks
{
    public class DeleteModel : PageModel
    {
        private readonly Facultate.Data.FacultateContext _context;

        public DeleteModel(Facultate.Data.FacultateContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ProfessorRank ProfessorRank { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProfessorRank = await _context.ProfessorRank.FirstOrDefaultAsync(m => m.Id == id);

            if (ProfessorRank == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProfessorRank = await _context.ProfessorRank.FindAsync(id);

            if (ProfessorRank != null)
            {
                _context.ProfessorRank.Remove(ProfessorRank);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
