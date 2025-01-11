using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AplicatieSalaDeFitness.Data;

namespace AplicatieSalaDeFitness.Pages.Sesiuni
{
    public class CreateModel : PageModel
    {
        private readonly AplicatieSalaDeFitness.Data.AplicatieSalaDeFitnessContext _context;

        public CreateModel(AplicatieSalaDeFitness.Data.AplicatieSalaDeFitnessContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AntrenorId"] = new SelectList(_context.Antrenor, "AntrenorId", "Nume");
            return Page();
        }

        [BindProperty]
        public Sesiune Sesiune { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["AntrenorId"] = new SelectList(_context.Antrenor, "AntrenorId", "Nume");
                return Page();
            }

            _context.Sesiune.Add(Sesiune);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
