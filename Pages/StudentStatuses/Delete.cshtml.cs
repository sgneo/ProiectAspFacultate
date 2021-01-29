using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Facultate.Data;
using Facultate.Models;

namespace Facultate.Pages.StudentStatuses
{
    public class DeleteModel : PageModel
    {
        private readonly Facultate.Data.FacultateContext _context;

        public DeleteModel(Facultate.Data.FacultateContext context)
        {
            _context = context;
        }

        [BindProperty]
        public StudentStatus StudentStatus { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StudentStatus = await _context.StudentStatus.FirstOrDefaultAsync(m => m.Id == id);

            if (StudentStatus == null)
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

            StudentStatus = await _context.StudentStatus.FindAsync(id);

            if (StudentStatus != null)
            {
                _context.StudentStatus.Remove(StudentStatus);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
