using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AplicatieSalaDeFitness.Data;

namespace AplicatieSalaDeFitness.Pages.Antrenori
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
            return Page();
        }

        [BindProperty]
        public Antrenor Antrenor { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Antrenor.Add(Antrenor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
