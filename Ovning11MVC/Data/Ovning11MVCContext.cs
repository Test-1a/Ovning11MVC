using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Ovning11MVC.Models
{
    public class Ovning11MVCContext : DbContext
    {
        public Ovning11MVCContext (DbContextOptions<Ovning11MVCContext> options)
            : base(options)
        {
        }

        public DbSet<Ovning11MVC.Models.Product> Product { get; set; }
    }
}
