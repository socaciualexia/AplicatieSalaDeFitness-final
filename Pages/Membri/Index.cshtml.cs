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
    public class IndexModel : PageModel
    {
        private readonly AplicatieSalaDeFitness.Data.AplicatieSalaDeFitnessContext _context;

        public IndexModel(AplicatieSalaDeFitness.Data.AplicatieSalaDeFitnessContext context)
        {
            _context = context;
        }

        public IList<Membru> Membru { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Membru = await _context.Membru.ToListAsync();
        }
    }
}
