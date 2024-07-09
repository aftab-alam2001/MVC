using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UnitofWorkDbContext : DbContext
    {
        public UnitofWorkDbContext(DbContextOptions<UnitofWorkDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
    }
}
