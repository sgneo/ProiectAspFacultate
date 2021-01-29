using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Facultate.Data;
using Facultate.Models;

namespace Facultate.Pages.Professors
{
    public class CreateModel : PageModel
    {
        private readonly Facultate.Data.FacultateContext _context;

        public CreateModel(Facultate.Data.FacultateContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["RankID"] = new SelectList(_context.ProfessorRank, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Professor Professor { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Professor.Add(Professor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
