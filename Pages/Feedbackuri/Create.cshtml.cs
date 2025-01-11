using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AplicatieSalaDeFitness.Data;

namespace AplicatieSalaDeFitness.Pages.Feedbackuri
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
        public Feedback Feedback { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["AntrenorId"] = new SelectList(_context.Antrenor, "AntrenorId", "Nume");
                return Page();
            }

            _context.Feedback.Add(Feedback);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
