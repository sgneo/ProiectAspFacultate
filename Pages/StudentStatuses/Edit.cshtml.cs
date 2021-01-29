using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Facultate.Data;
using Facultate.Models;

namespace Facultate.Pages.StudentStatuses
{
    public class EditModel : PageModel
    {
        private readonly Facultate.Data.FacultateContext _context;

        public EditModel(Facultate.Data.FacultateContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(StudentStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentStatusExists(StudentStatus.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool StudentStatusExists(int id)
        {
            return _context.StudentStatus.Any(e => e.Id == id);
        }
    }
}
