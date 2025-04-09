using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IngenieriaWeb1.Models;

    public class AutosContext : DbContext
    {
        public AutosContext (DbContextOptions<AutosContext> options)
            : base(options)
        {
        }

        public DbSet<IngenieriaWeb1.Models.Autos> Autos { get; set; } = default!;
    }
