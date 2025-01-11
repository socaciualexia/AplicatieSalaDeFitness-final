using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AplicatieSalaDeFitness.Data;

namespace AplicatieSalaDeFitness.Pages.Membri
{
    public class DetailsModel : PageModel
    {
        private readonly AplicatieSalaDeFitness.Data.AplicatieSalaDeFitnessContext _context;

        public DetailsModel(AplicatieSalaDeFitness.Data.AplicatieSalaDeFitnessContext context)
        {
            _context = context;
        }

        public Membru Membru { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membru = await _context.Membru.FirstOrDefaultAsync(m => m.MembruId == id);
            if (membru == null)
            {
                return NotFound();
            }
            else
            {
                Membru = membru;
            }
            return Page();
        }
    }
}
