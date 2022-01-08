using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rosca_Theodora_MOutlet.Models;

namespace Rosca_Theodora_MOutlet.Data
{
    public class Rosca_Theodora_MOutletContext : DbContext
    {
        public Rosca_Theodora_MOutletContext (DbContextOptions<Rosca_Theodora_MOutletContext> options)
            : base(options)
        {
        }

        public DbSet<Rosca_Theodora_MOutlet.Models.Product> Product { get; set; }

        public DbSet<Rosca_Theodora_MOutlet.Models.Company> Company { get; set; }

        public DbSet<Rosca_Theodora_MOutlet.Models.Category> Category { get; set; }
    }
}
