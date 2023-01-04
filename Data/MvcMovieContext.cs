using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhuonQuocChien106.Models;

    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<PhuonQuocChien106.Models.UniversityPQC106> UniversityPQC106 { get; set; } = default!;

        public DbSet<PhuonQuocChien106.Models.PQC0106> PQC0106 { get; set; } = default!;
    }
