using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InclusionTracker.Models
{
    public class InclusionTrackerDbContext : DbContext
    {
        public InclusionTrackerDbContext (DbContextOptions<InclusionTrackerDbContext> options)
            : base(options)
        {
        }

        public DbSet<InclusionTracker.Models.Student> Student { get; set; }
    }
}
