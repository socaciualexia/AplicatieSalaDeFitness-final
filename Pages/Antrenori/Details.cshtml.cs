using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AplicatieSalaDeFitness.Data;

namespace AplicatieSalaDeFitness.Pages.Antrenori
{
    public class DetailsModel : PageModel
    {
        private readonly AplicatieSalaDeFitness.Data.AplicatieSalaDeFitnessContext _context;

        public DetailsModel(AplicatieSalaDeFitness.Data.AplicatieSalaDeFitnessContext context)
        {
            _context = context;
        }

        public Antrenor Antrenor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var antrenor = await _context.Antrenor.FirstOrDefaultAsync(m => m.AntrenorId == id);
            if (antrenor == null)
            {
                return NotFound();
            }
            else
            {
                Antrenor = antrenor;
            }
            return Page();
        }
    }
}
