using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AplicatieSalaDeFitness.Data
{
    public class AplicatieSalaDeFitnessContext : DbContext
    {
        public AplicatieSalaDeFitnessContext (DbContextOptions<AplicatieSalaDeFitnessContext> options)
            : base(options)
        {
        }

        public DbSet<Antrenor> Antrenor { get; set; } = default!;
        public DbSet<Membru> Membru { get; set; } = default!;
        public DbSet<Abonament> Abonament { get; set; } = default!;
        public DbSet<Feedback> Feedback { get; set; } = default!;
        public DbSet<Sesiune> Sesiune { get; set; } = default!;
    }
}
